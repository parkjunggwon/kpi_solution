
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module mod공통

    '----------------------------------------------------------------------------------------------------------------------------------
    '   sql 관련 변수
    '----------------------------------------------------------------------------------------------------------------------------------
    Private SqlConnStr As String = "server=220.95.232.227;User Id=ekpi2; password=idekpi2()%!; database=kpi_base; charset=utf8"
    Public SqlConn As New MySqlConnection
    Public SqlCmd As New MySqlCommand
    Public SqlRS As MySqlDataReader
    Public SqlStr As String

    Public Structure userinfo
        Public Id As String
        Public Name As String
        Public Dept As String
        Public DoctorYN As String
        Public Auth As String  '00 일반사용자  10 병원관리자  20 KPI
    End Structure
    Public mUserInfo As New userinfo



    Public Function mSQLConn() As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------
        '   서버연결
        '----------------------------------------------------------------------------------------------------------------------------------
        Try
            SqlConn = New MySqlConnection(SqlConnStr)
            SqlConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("DataBase 연결오류 발생", "Database 연결", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub mSQLDisconn()
        '----------------------------------------------------------------------------------------------------------------------------------
        '   서버연결종료
        '----------------------------------------------------------------------------------------------------------------------------------
        Try
            SqlConn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub


    Public Function mSQLSelect(pSqlStr As String, ByRef pSqlRS As MySqlDataReader) As Boolean

        '----------------------------------------------------------------------------------------------------------------------------------
        '   select sql 문장 실행
        '----------------------------------------------------------------------------------------------------------------------------------
        Try
            If SqlConn.Ping = False Then mSQLConn()
            SqlCmd = New MySqlCommand(pSqlStr, SqlConn)
            pSqlRS = SqlCmd.ExecuteReader
            Return True
        Catch ex As Exception
            Dim ret As DialogResult
            While (1 = 1)
                ret = MessageBox.Show("DataBase 재연결합니다.", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If ret = DialogResult.No Then
                    Application.Exit()
                Else
                    SqlConn.Close()
                    If mSQLConn() = True Then Exit While
                End If
            End While

            Try
                SqlCmd = New MySqlCommand(pSqlStr, SqlConn)
                pSqlRS = SqlCmd.ExecuteReader
                Return True
            Catch ex1 As Exception
                Call MessageBox.Show(SqlStr, "SQL 확인", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mSQLSelect = False

            End Try
        End Try

    End Function


    Public Function mSQLExec(pSqlStr As String) As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------
        '   insert / update sql 문장 실행
        '----------------------------------------------------------------------------------------------------------------------------------
        mSQLExec = True
        Try
            SqlCmd = New MySqlCommand(pSqlStr, SqlConn)
            SqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Dim ret As DialogResult
            While (1 = 1)
                ret = MessageBox.Show("DataBase 재연결합니다.", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If ret = DialogResult.No Then
                    Application.Exit()
                Else
                    SqlConn.Close()
                    If mSQLConn() = True Then Exit While
                End If
            End While

            Try
                SqlCmd = New MySqlCommand(pSqlStr, SqlConn)
                SqlCmd.ExecuteNonQuery()
            Catch ex1 As Exception
                Call MessageBox.Show(pSqlStr, "SQL 확인", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mSQLExec = False
            End Try

        End Try
    End Function

    Public Sub mSprPrint(스프레드 As FarPoint.Win.Spread.FpSpread, 미리보기 As Boolean, 타이틀 As String, Optional 좌측상단검색조건 As String = "", Optional 상단마진 As Double = 10, Optional 좌측마진 As Double = 10)

        '-------------------------------------------------------------------------------------------------
        '   스프레드 출력 기능
        '   헤더/ 바닥글 정의
        '-------------------------------------------------------------------------------------------------
        Dim printset As New FarPoint.Win.Spread.PrintInfo()
        printset.Header = "/c/fb1/fz""15""" + 타이틀 + "/n"

        printset.Header = printset.Header + "/n/fb0/fz""10""" + 좌측상단검색조건 + vbCrLf + "출력시간 : " + Date.Now + " (" + mUserInfo.Name + "." + mUserInfo.Name + ")/n"

        printset.Footer = "/c/p / /pc"
        printset.UseSmartPrint = True
        printset.Margin.Top = 상단마진
        printset.Margin.Left = 좌측마진

        스프레드.Sheets(0).PrintInfo = printset

        If 미리보기 = True Then
            Dim pi As New PrintPreviewDialog()
            pi.BackColor = Color.Cyan
            pi.ForeColor = Color.Red
            pi.Text = "출력미리보기"
            pi.WindowState = FormWindowState.Maximized

            스프레드.SetPrintPreview(pi)
            스프레드.ActiveSheet.PrintInfo.Preview = True
            스프레드.ActiveSheet.PrintInfo.ZoomFactor = 0.9

        End If
        '-------------------------------------------------------------------------------------------------
        '   보기
        '-------------------------------------------------------------------------------------------------
        스프레드.PrintSheet(스프레드.ActiveSheet)


    End Sub

    Public Sub mSprSetRS(스프레드 As FarPoint.Win.Spread.FpSpread, ByRef pSqlRS As MySqlDataReader, Optional 줄높이자동조정 As Boolean = True)

        '----------------------------------------------------------------------------------------------------------------------------------
        '   select 결과를 스프레드에 출력하기
        '----------------------------------------------------------------------------------------------------------------------------------
        Dim sprR As Long
        Dim sprC As Integer
        Dim row As FarPoint.Win.Spread.Row
        Dim size As Single

        sprR = -1
        스프레드.ActiveSheet.RowCount = 0

        While pSqlRS.Read()
            sprR = sprR + 1
            스프레드.ActiveSheet.RowCount = sprR + 1
            For sprC = 0 To pSqlRS.FieldCount - 1
                스프레드.ActiveSheet.SetText(sprR, sprC, pSqlRS(sprC))
            Next

            If 줄높이자동조정 = True Then
                row = 스프레드.ActiveSheet.Rows(CType(sprR, Integer))
                size = row.GetPreferredHeight()
                row.Height = size
            End If

        End While

        pSqlRS.Close()


    End Sub

    Public Sub mErr(폼명칭 As String, 루틴명칭 As String, 에러메세지 As String, Optional 메세지출력여부 As Boolean = True)

        '----------------------------------------------------------------------------------------------------------------------------------
        '   에러발생시 데이타 발생
        '----------------------------------------------------------------------------------------------------------------------------------
        SqlStr = "insert into kpi_log.l_pgerr"
        SqlStr = SqlStr & vbCrLf & "   (폼명칭,루틴명칭,에러메세지,조작자,조작일시)"
        SqlStr = SqlStr & vbCrLf & "VALUES('" + 폼명칭 + "',"
        SqlStr = SqlStr & vbCrLf & "       '" + 루틴명칭 + "',"
        SqlStr = SqlStr & vbCrLf & "       '" + 에러메세지 + "',"
        SqlStr = SqlStr & vbCrLf & "       '" + mUserInfo.Id + "',"
        SqlStr = SqlStr & vbCrLf & "            now())"
        Call mSQLExec(SqlStr)

        If 메세지출력여부 = True Then
            Call MessageBox.Show(에러메세지, 폼명칭 + " (" + 루틴명칭 + ")", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Public Function age_check(생년월일 As String) As String

        '----------------------------------------------------------------------------------------------------------------------------------
        '   나이구하기
        '----------------------------------------------------------------------------------------------------------------------------------
        Dim birth_year As Integer
        Dim birth_month As String
        Dim birth_day As String
        Dim age_chk As String
        Dim age As Integer
        Dim birth_month_day As String
        Dim birth_date As Date
        Dim date_diff

        birth_year = Microsoft.VisualBasic.Left(생년월일.Replace("-", ""), 4)   '생년월일 년도
        birth_month = Microsoft.VisualBasic.Mid(생년월일.Replace("-", ""), 5, 2) '생년월일 월
        birth_day = Microsoft.VisualBasic.Mid(생년월일.Replace("-", ""), 7, 2) '생년월일 일

        date_diff = Format(Now, "MMdd")
        '생년월일 월일 
        birth_month_day = birth_month + birth_day

        birth_date = 생년월일
        '현재날짜 - 생년월일
        date_diff = DateDiff(DateInterval.Month, birth_date, Now)

        '날짜 차이가 24개월 이상일때
        If date_diff >= 24 Then

            If Format(Now, "MMdd") >= birth_month_day Then
                age = CInt(date_diff / 12)
                age_chk = CStr(age) + "세"
            Else
                age = CInt(date_diff / 12) - 1
                age_chk = CStr(age) + "세"
            End If

        Else

            age = CInt(date_diff)

            '0개월인경우 1개월로
            If age = 0 Then
                age = 1
            End If

            age_chk = CStr(age) + "개월"

        End If

        '결과 값 반환
        Return age_chk

    End Function



    Public Function m날짜시간(형식구분값 As String) As String
        On Error GoTo ErrRtn
        If 형식구분값 = "1" Then SqlStr = "select curdate()"
        If 형식구분값 = "2" Then SqlStr = "select curtime()"
        If 형식구분값 = "3" Then SqlStr = "select now()"

        While SqlRS.Read()
            Return SqlRS.GetString(0).ToString()
        End While
        SqlRS.Close()
        Exit Function
ErrRtn:

    End Function

    Public Function m문자열찾기(문자열 As String, 순번 As Integer) As String

        Dim arr_split

        '문자열,구분자가  없을 경우
        If (Len(문자열) = 0) Then Return ""

        arr_split = Split(문자열, "@")

        Return arr_split(순번)

    End Function
    Public Sub m콤보기초(구분 As String, 코드명 As String, 분류항 As String, 적용일자 As String, 콤보박스 As ComboBox)

        SqlStr = "select 구분,코드명,분류항,분류목,메모,비고"
        SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_base A"
        SqlStr = SqlStr & vbCrLf & "where 구분     = '" + 구분 + "'"
        If 코드명.Trim() <> "" Then SqlStr = SqlStr & vbCrLf & "and   코드명   = '" + 코드명 + "'"
        If 분류항.Trim() <> "" Then SqlStr = SqlStr & vbCrLf & "and   분류항   = '" + 분류항 + "'"


        콤보박스.Items.Clear()
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        While SqlRS.Read()
            콤보박스.Items.Add(SqlRS.GetString("메모") + Space(50) + "@" + SqlRS.GetString("코드명") + "@" + SqlRS.GetString("분류항") + "@" + SqlRS.GetString("분류목") + "@" + SqlRS.GetString("비고") + "@")
        End While
        SqlRS.Close()

    End Sub


End Module





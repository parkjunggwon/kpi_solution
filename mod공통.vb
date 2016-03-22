
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
        Public 아이디 As String
        Public 이름 As String
        Public 부서 As String
        Public 의사여부 As String
        Public 권한레벨 As String  '00 일반사용자  10 병원관리자  20 KPI
    End Structure
    Public m사용자 As New userinfo


    Public Function mSQLConn() As Boolean

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
        Try
            SqlConn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub


    Public Function mSQLSelect(pSqlStr As String, ByRef pSqlRS As MySqlDataReader) As Boolean
        Try
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
                'Call MessageBox.Show(ex1.Message, "SQL 확인", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mSQLSelect = False

            End Try
        End Try

    End Function


    Public Function mSQLExec(SqlStr As String) As Boolean
        mSQLExec = True
        Try
            SqlCmd = New MySqlCommand(SqlStr, SqlConn)
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
                SqlCmd = New MySqlCommand(SqlStr, SqlConn)
                SqlCmd.ExecuteNonQuery()
            Catch ex1 As Exception
                Call MessageBox.Show(SqlStr, "SQL 확인", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mSQLExec = False
            End Try

        End Try
    End Function

    Public Sub mSprPrint(스프레드 As FarPoint.Win.Spread.FpSpread, 미리보기 As Boolean, 타이틀 As String, Optional 좌측상단검색조건 As String = "", Optional 상단마진 As Double = 10, Optional 좌측마진 As Double = 10)

        '-------------------------------------------------------------------------------------------------
        '   헤더/바닥글 정의
        '-------------------------------------------------------------------------------------------------
        Dim printset As New FarPoint.Win.Spread.PrintInfo()
        printset.Header = "/c/fb1/fz""15""" + 타이틀 + "/n"
        If 좌측상단검색조건.Trim() <> "" Then
            printset.Header = printset.Header + "/fb0/fz""10""" + 좌측상단검색조건 + "/n"
        End If
        printset.Footer = Date.Now + "/c" + m사용자.아이디 + "." + m사용자.이름 + "/r/p / /pc"
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

    Public Function age_check(생년월일 As String) As String

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

End Module





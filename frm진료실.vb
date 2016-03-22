Imports FarPoint.Win.Spread

Public Class frm진료실

    Dim date_chk As String  '검색 날짜
    Dim accept As String    '접수구분 chk1=진료대기,예약 chk2=치료실, chk3=진료완료, chk_all=전체
    Dim doctor_chk As String '의사 체크

    Private doctor As New List(Of String)() '배열 (의사리스트)

    Private Sub h_doctor_list_의사리스트()
        On Error GoTo ErrRtn
        '의사 리스트 쿼리문
        SqlStr = "select 아이디,성명,면허번호 "
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_user"
        SqlStr = SqlStr & vbCrLf & "where h_user.면허번호 is not null;"

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        CbB의사리스트.Items.Clear()
        While SqlRS.Read()
            CbB의사리스트.Items.Add(SqlRS.GetString("성명").Trim())
            doctor.Add(SqlRS.GetString("면허번호").Trim())
        End While
        SqlRS.Close()
        '선택 의사 표시
        CbB의사리스트.SelectedIndex = 0

        Exit Sub
ErrRtn:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub h_user_list_환자리스트()

        Dim accept_chk As String = ""

        If accept = "chk1" Then
            '1= 진료대기,5=예약
            accept_chk = " and kpi_wonmu.w_jubsu.접수구분 in (1,5) "
        ElseIf accept = "chk2" Then
            '4=치료실
            accept_chk = " and kpi_wonmu.w_jubsu.접수구분 = 4"
        ElseIf accept = "chk3" Then
            '2=진료완료
            accept_chk = " and kpi_wonmu.w_jubsu.접수구분 = 2"
        ElseIf accept = "chk_all" Then
            '전체
            accept_chk = ""
        End If

        If date_chk = "" Then
            '날짜 선택 초기 값 오늘 날짜
            date_chk = Format(Now, "yyyy-MM-dd")
        End If

        Dim sprR As Long

        SqlStr = "select kpi_wonmu.w_hmaster.성명 as 성명,kpi_wonmu.w_hmaster.챠트번호 as 챠트번호,kpi_wonmu.w_hmaster.성별 as 성별,kpi_wonmu.w_jubsu.접수시간 as 접수시간, kpi_wonmu.w_hmaster.생년월일, "
        SqlStr = SqlStr & vbCrLf & "(select kpi_base.h_base.메모 from kpi_base.h_base where 구분='진료과목' and kpi_base.h_base.분류항 = kpi_wonmu.w_jubsu.진료과목) as 진료과"
        SqlStr = SqlStr & vbCrLf & "from kpi_wonmu.w_hmaster "
        SqlStr = SqlStr & vbCrLf & "left join kpi_wonmu.w_jubsu on kpi_wonmu.w_hmaster.챠트번호=kpi_wonmu.w_jubsu.챠트번호"
        SqlStr = SqlStr & vbCrLf & "where kpi_wonmu.w_jubsu.취소여부 <> 1 "
        SqlStr = SqlStr & vbCrLf & accept_chk
        SqlStr = SqlStr & vbCrLf & " and kpi_wonmu.w_jubsu.진료일자 ='" + date_chk + "' "
        SqlStr = SqlStr & vbCrLf & " and kpi_wonmu.w_jubsu.진료의사 ='" + doctor_chk + "'; "

        Fps환자리스트.Sheets(0).RowCount = 0

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        sprR = -1
        Dim accept_date As String
        Dim hour As String
        Dim min As String
        Dim hour_min As String

        While SqlRS.Read()
            sprR = sprR + 1

            accept_date = SqlRS.GetString("접수시간")
            hour = Microsoft.VisualBasic.Left(accept_date, 2)
            min = Microsoft.VisualBasic.Right(accept_date, 2)

            hour_min = hour + ":" + min + ""
            Dim age_ccc As String
            '나이 뽑아 오는 함수
            age_ccc = age_check(SqlRS.GetString("생년월일"))

            Fps환자리스트.Sheets(0).RowCount = sprR + 1
            Fps환자리스트.Sheets(0).SetText(sprR, 0, SqlRS.GetString("성명").Trim())
            Fps환자리스트.Sheets(0).SetText(sprR, 1, SqlRS.GetString("챠트번호").Trim())
            Fps환자리스트.Sheets(0).SetText(sprR, 2, SqlRS.GetString("진료과").ToString.Trim())
            Fps환자리스트.Sheets(0).SetText(sprR, 3, SqlRS.GetString("성별").Trim())
            Fps환자리스트.Sheets(0).SetText(sprR, 4, age_ccc.Trim())
            Fps환자리스트.Sheets(0).SetText(sprR, 5, hour_min.Trim())

        End While


        SqlRS.Close()
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub 제증명ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 제증명ToolStripMenuItem.Click
        Frm제증명입력.Show()
    End Sub

    Private Sub 상병조회ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 상병조회ToolStripMenuItem.Click
        Frm상병조회.Show()
    End Sub

    Private Sub CbB의사리스트_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbB의사리스트.SelectedIndexChanged
        Dim strValue As String = doctor(CbB의사리스트.SelectedIndex)
        Dim strText As String = CbB의사리스트.SelectedItem
        doctor_chk = ""
        doctor_chk = strValue
        Call h_user_list_환자리스트()
    End Sub

    Private Sub frm진료실_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call h_doctor_list_의사리스트()
        accept = "chk1"
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Rdb진료대기_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb진료대기.CheckedChanged
        accept = "chk1"
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Rdb치료실_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb치료실.CheckedChanged
        accept = "chk2"
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Rdb진료완료_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb진료완료.CheckedChanged
        accept = "chk3"
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Rdb전체_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb전체.CheckedChanged
        accept = "chk_all"
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Dtp진료일자_ValueChanged(sender As Object, e As EventArgs) Handles Dtp진료일자.ValueChanged
        date_chk = ""
        date_chk = Format(Dtp진료일자.Value, "yyyy-MM-dd")
        Call h_user_list_환자리스트()
    End Sub

    Private Sub Fps환자리스트_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Fps환자리스트.CellDoubleClick

        With Fps환자리스트.ActiveSheet

            'Tb챠트번호.Text = "aaaa"

            '의사 리스트 쿼리문

            'MessageBox.Show(.GetText(.ActiveCell.Row.Index, 1))
        End With

    End Sub

    Private Sub Fps환자리스트_CellClick(sender As Object, e As CellClickEventArgs) Handles Fps환자리스트.CellClick

    End Sub
End Class
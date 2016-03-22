Public Class frm사용자등록
    Dim nim As String
    Dim cim As String
    Dim select_chk As String
    Private team As New List(Of String)()
    Private Sub txt주민번호1_TextChanged(sender As Object, e As EventArgs) Handles txt주민번호1.TextChanged
        Dim b As String
        If txt주민번호1.Text.Length = 6 Then
            txt주민번호2.Focus()
            txt생년월일.Text = Format(txt주민번호1.Text, "Short date")

        End If
    End Sub
    Private Sub txt주민번호2_TextChanged(sender As Object, e As EventArgs) Handles txt주민번호2.TextChanged
        If txt주민번호2.Text.Length = 7 Then
            txt연락처.Focus()
        End If
    End Sub
    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub
    Private Sub btn검색_Click(sender As Object, e As EventArgs) Handles btn검색.Click
        txtpw.Focus()
        SqlStr = "select 아이디"
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_user"
        SqlStr = SqlStr & vbCrLf & "where 아이디= '" + txt아이디.Text + "'"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
        While SqlRS.Read()
            If SqlRS.GetString("아이디").Trim() = txt아이디.Text.Trim() Then MessageBox.Show("중복 입니다.")
            txt아이디.Text = ""
        End While
        SqlRS.Close()
    End Sub
    Private Sub frm사용자등록_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call m콤보기초("부서", "", "", "", cbo부서)
        Call m콤보기초("직위", "", "", "", cbo직위)
        Call m콤보기초("진료과목", "", "", "", cbo과목)
        Call m콤보기초("부서", "", "", "", cbo부서별)
    End Sub

    Private Sub 화면ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 화면ClearToolStripMenuItem.Click
        txt아이디.Text = ""
        txtpw.Text = ""
        txt성명.Text = ""
        txt주민번호1.Text = ""
        txt주민번호2.Text = ""
        txt생년월일.Text = ""
        txt연락처.Text = ""
        txt핸드폰.Text = ""
        txt우편번호.Text = ""
        txt주소.Text = ""
        txt면허번호.Text = ""
        txt메모.Text = ""

    End Sub
    Private Sub btn검색1_Click(sender As Object, e As EventArgs) Handles btn검색1.Click
        Dim sprR As Long
        SqlStr = "select 성명,아이디,password,담당부서,직위,입사일자,면허번호"
        SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_user "
        SqlStr = SqlStr & vbCrLf & "where 성명= '" + txt성명1.Text + "' "
        SqlStr = SqlStr & vbCrLf & "order by 성명"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
        sprR = -1
        FpSpread1.Sheets(0).RowCount = 0
        While SqlRS.Read()
            sprR = sprR + 1
            FpSpread1.Sheets(0).RowCount = sprR + 1
            FpSpread1.Sheets(0).SetText(sprR, 0, SqlRS.GetString("성명"))
            FpSpread1.Sheets(0).SetText(sprR, 1, SqlRS.GetString("아이디"))
            FpSpread1.Sheets(0).SetText(sprR, 2, SqlRS.GetString("PASSWORD"))
            FpSpread1.Sheets(0).SetText(sprR, 3, SqlRS.GetString("담당부서"))
            FpSpread1.Sheets(0).SetText(sprR, 4, SqlRS.GetString("직위"))
            FpSpread1.Sheets(0).SetText(sprR, 5, SqlRS.GetString("입사일자"))
            FpSpread1.Sheets(0).SetText(sprR, 6, SqlRS.GetString("면허번호"))
        End While
        SqlRS.Close()
    End Sub
    Private Sub txt아이디_keydown(sender As Object, e As KeyEventArgs) Handles txt아이디.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpw.Focus()
                SqlStr = "select 아이디"
                SqlStr = SqlStr & vbCrLf & "from kpi_base.h_user"
                SqlStr = SqlStr & vbCrLf & "where 아이디= '" + txt아이디.Text + "'"
                If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
                While SqlRS.Read()
                    If SqlRS.GetString("아이디").Trim() = txt아이디.Text.Trim() Then MessageBox.Show("중복 입니다.")
                    txt아이디.Text = ""
                    txt아이디.Focus()
                End While
                SqlRS.Close()
        End Select
    End Sub
    Private Sub txtpw_keydown(sender As Object, e As KeyEventArgs) Handles txtpw.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt성명.Focus()
        End Select
    End Sub
    Private Sub txt성명_keydown(sender As Object, e As KeyEventArgs) Handles txt성명.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt주민번호1.Focus()
        End Select
    End Sub
    Private Sub txt생년월일_keydown(sender As Object, e As KeyEventArgs) Handles txt생년월일.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt연락처.Focus()
        End Select
    End Sub
    Private Sub txt연락처_keydown(sender As Object, e As KeyEventArgs) Handles txt연락처.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt핸드폰.Focus()
        End Select
    End Sub
    Private Sub txt핸드폰_keydown(sender As Object, e As KeyEventArgs) Handles txt핸드폰.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt우편번호.Focus()
        End Select
    End Sub
    Private Sub txt우편번호_keydown(sender As Object, e As KeyEventArgs) Handles txt우편번호.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt주소.Focus()
        End Select
    End Sub
    Private Sub txt성명1_keydown(sender As Object, e As KeyEventArgs) Handles txt성명1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim sprR As Long
                SqlStr = "select 성명,아이디,password,담당부서,직위,입사일자,면허번호"
                SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_user "
                SqlStr = SqlStr & vbCrLf & "where 성명= '" + txt성명1.Text + "' "
                SqlStr = SqlStr & vbCrLf & "order by 성명"
                If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
                sprR = -1
                FpSpread1.Sheets(0).RowCount = 0
                While SqlRS.Read()
                    sprR = sprR + 1
                    FpSpread1.Sheets(0).RowCount = sprR + 1
                    FpSpread1.Sheets(0).SetText(sprR, 0, SqlRS.GetString("성명"))
                    FpSpread1.Sheets(0).SetText(sprR, 1, SqlRS.GetString("아이디"))
                    FpSpread1.Sheets(0).SetText(sprR, 2, SqlRS.GetString("PASSWORD"))
                    FpSpread1.Sheets(0).SetText(sprR, 3, SqlRS.GetString("담당부서"))
                    FpSpread1.Sheets(0).SetText(sprR, 4, SqlRS.GetString("직위"))
                    FpSpread1.Sheets(0).SetText(sprR, 5, SqlRS.GetString("입사일자"))
                    FpSpread1.Sheets(0).SetText(sprR, 6, SqlRS.GetString("면허번호"))
                End While
                SqlRS.Close()
        End Select
    End Sub
    Private Sub cbo부서별_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo부서별.SelectedIndexChanged
        Dim a = m문자열찾기(cbo부서별.Text, 0)
        Dim sprR As Long
        SqlStr = "select 성명,아이디,password,담당부서,직위,입사일자,면허번호"
        SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_user "
        SqlStr = SqlStr & vbCrLf & "where 담당부서=  '" + a + "' "
        SqlStr = SqlStr & vbCrLf & "order by 성명"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
        sprR = -1
        FpSpread1.Sheets(0).RowCount = 0
        While SqlRS.Read()
            sprR = sprR + 1
            FpSpread1.Sheets(0).RowCount = sprR + 1
            FpSpread1.Sheets(0).SetText(sprR, 0, SqlRS.GetString("성명"))
            FpSpread1.Sheets(0).SetText(sprR, 1, SqlRS.GetString("아이디"))
            FpSpread1.Sheets(0).SetText(sprR, 2, SqlRS.GetString("PASSWORD"))
            FpSpread1.Sheets(0).SetText(sprR, 3, SqlRS.GetString("담당부서"))
            FpSpread1.Sheets(0).SetText(sprR, 4, SqlRS.GetString("직위"))
            FpSpread1.Sheets(0).SetText(sprR, 5, Format(SqlRS.GetString("입사일자"), "short date"))
            FpSpread1.Sheets(0).SetText(sprR, 6, SqlRS.GetString("면허번호"))
        End While
        SqlRS.Close()
    End Sub
    Private Function h_base_저장() As Boolean '저장기능은 무조건 function 으로 해야한다.
        Dim sprR As Long


        '-------------------------------------------------------------------------------------------------------------
        '   자료점검
        '-------------------------------------------------------------------------------------------------------------
        If txt아이디.Text.Trim() = "" Then
            Return False
            If txtpw.Text.Trim() = "" Then
                Return False
                If txt주민번호1.Text.Trim() = "" Then
                    Return False
                End If
            End If
        End If
        '-------------------------------------------------------------------------------------------------------------
        '   구분 조건으로 삭제
        '-------------------------------------------------------------------------------------------------------------
        SqlStr = "delete"
        SqlStr = SqlStr & vbCrLf & "from   kpi_base.h_user "
    End Function
End Class
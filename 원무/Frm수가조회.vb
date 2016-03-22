Public Class Frm수가조회
    Dim sFrom As String
    Dim sTo As String
    Dim codeclass As String
    Dim code As String
    Dim pay As Integer
    Dim nim As String
    Private Sub h_hsuga_검색조회()
        Dim sprR As Long
        SqlStr = "select 병원코드,수가명칭,단미구분,보험단가,자보단가,비급단가"
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_hsuga"
        SqlStr = SqlStr & vbCrLf & "where 수가명칭 like '" & nim & "%" & "' "
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
        sprR = -1
        While SqlRS.Read()
            sprR = sprR + 1
            fpSPr8.Sheets(0).RowCount = sprR + 1
            fpSPr8.Sheets(0).SetText(sprR, 0, SqlRS.GetString("병원코드"))
            fpSPr8.Sheets(0).SetText(sprR, 1, SqlRS.GetString("수가명칭"))
            Select Case SqlRS.GetString("단미구분")
                Case "A"
                    fpSPr8.Sheets(0).SetText(sprR, 2, "단미")
                Case "B"
                    fpSPr8.Sheets(0).SetText(sprR, 2, "혼합")
            End Select
            fpSPr8.Sheets(0).SetText(sprR, 3, Format(CType(SqlRS.GetString("보험단가"), Double), "#,#"))
            fpSPr8.Sheets(0).SetText(sprR, 4, Format(CType(SqlRS.GetString("자보단가"), Double), "#,#"))
            fpSPr8.Sheets(0).SetText(sprR, 5, Format(CType(SqlRS.GetString("비급단가"), Double), "#,#"))
        End While
        SqlRS.Close()
    End Sub
    Private Sub h_hsuga_수가내역조회()
        Dim sprR As Long
        SqlStr = "select 병원코드,수가명칭,항번호,코드구분,단미구분,보험단가,자보단가,비급단가"
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_hsuga"
        SqlStr = SqlStr & vbCrLf & " where 수가명칭>= '" & sFrom & "'"
        SqlStr = SqlStr & vbCrLf & " And 수가명칭 < '" & sTo & "' "
        If codeclass <> "*" Then
            SqlStr = SqlStr & vbCrLf & " And 코드구분 = '" & codeclass & "' "
        End If
        If pay = "2" Then
            SqlStr = SqlStr & vbCrLf & " And 급여구분 = '" & pay & "' "
        End If
        SqlStr = SqlStr & vbCrLf & " order by 단미구분 ASC, 수가명칭,코드구분"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub
        sprR = -1
        While SqlRS.Read()
            sprR = sprR + 1
            fpSPr8.Sheets(0).RowCount = sprR + 1
            fpSPr8.Sheets(0).SetText(sprR, 0, SqlRS.GetString("병원코드"))
            fpSPr8.Sheets(0).SetText(sprR, 1, SqlRS.GetString("수가명칭"))
            Select Case SqlRS.GetString("단미구분")
                Case "A"
                    fpSPr8.Sheets(0).SetText(sprR, 2, "단미")
                Case "B"
                    fpSPr8.Sheets(0).SetText(sprR, 2, "혼합")
            End Select
            fpSPr8.Sheets(0).SetText(sprR, 3, Format(CType(SqlRS.GetString("보험단가"), Double), "#,#"))
            fpSPr8.Sheets(0).SetText(sprR, 4, Format(CType(SqlRS.GetString("자보단가"), Double), "#,#"))
            fpSPr8.Sheets(0).SetText(sprR, 5, Format(CType(SqlRS.GetString("비급단가"), Double), "#,#"))
        End While
        SqlRS.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn가.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "가"
        sTo = "나"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn나.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "나"
        sTo = "다"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn다_Click(sender As Object, e As EventArgs) Handles btn다.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "다"
        sTo = "라"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn라_Click(sender As Object, e As EventArgs) Handles btn라.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "라"
        sTo = "마"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn마_Click(sender As Object, e As EventArgs) Handles btn마.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "마"
        sTo = "바"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn바_Click(sender As Object, e As EventArgs) Handles btn바.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "바"
        sTo = "사"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn사_Click(sender As Object, e As EventArgs) Handles btn사.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "사"
        sTo = "아"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn아_Click(sender As Object, e As EventArgs) Handles btn아.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "아"
        sTo = "자"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn자_Click(sender As Object, e As EventArgs) Handles btn자.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "자"
        sTo = "차"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn차_Click(sender As Object, e As EventArgs) Handles btn차.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "차"
        sTo = "카"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn카_Click(sender As Object, e As EventArgs) Handles btn카.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "카"
        sTo = "타"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn타_Click(sender As Object, e As EventArgs) Handles btn타.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "타"
        sTo = "파"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn파_Click(sender As Object, e As EventArgs) Handles btn파.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "파"
        sTo = "하"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub btn하_Click(sender As Object, e As EventArgs) Handles btn하.Click
        fpSPr8.Sheets(0).Rows.Clear()
        sFrom = "하"
        Call h_hsuga_수가내역조회()
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = "true" Then codeclass = "C"
    End Sub
    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb1.Checked = "true" Then codeclass = "H"
    End Sub
    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb1.Checked = "true" Then codeclass = "W" Or pay = "2"
    End Sub
    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = "true" Then codeclass = "A"
    End Sub
    Private Sub rb5_CheckedChanged(sender As Object, e As EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked = "true" Then codeclass = "*"
    End Sub

    Private Sub btn검색_Click(sender As Object, e As EventArgs) Handles btn검색.Click
        nim = txt명칭.Text
        Call h_hsuga_검색조회()
    End Sub
    Private Sub txt명칭_KeyDown(sender As Object, e As KeyEventArgs) Handles txt명칭.KeyDown
        nim = txt명칭.Text
        Call h_hsuga_검색조회()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class
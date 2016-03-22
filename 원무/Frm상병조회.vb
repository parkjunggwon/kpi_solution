Public Class Frm상병조회

    Private sang As New List(Of String)() '배열 (의사리스트)

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub Lb순번_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lb순번.SelectedIndexChanged

        Dim sprR As Long
        Dim search_lb상병검색 As String
        Dim where_lb상병검색 As String

        search_lb상병검색 = Lb순번.Text.ToString
        where_lb상병검색 = ""

        If search_lb상병검색 = "A00~B99" Then

            where_lb상병검색 = " 구분1 >= 'A00' and 구분2 <='B99'"

        ElseIf search_lb상병검색 = "C00~D49" Then

            where_lb상병검색 = " 구분1 >= 'C00' and 구분2 <='D49'"

        ElseIf search_lb상병검색 = "D50~D89" Then

            where_lb상병검색 = " 구분1 >= 'D50' and 구분2 <='D89'"

        ElseIf search_lb상병검색 = "E00~E90" Then

            where_lb상병검색 = " 구분1 >= 'E00' and 구분2 <='E90'"

        ElseIf search_lb상병검색 = "F00~F99" Then

            where_lb상병검색 = " 구분1 >= 'F00' and 구분2 <='F99'"

        ElseIf search_lb상병검색 = "G00~G99" Then

            where_lb상병검색 = " 구분1 >= 'G00' and 구분2 <='G99'"

        ElseIf search_lb상병검색 = "H00~H59" Then

            where_lb상병검색 = " 구분1 >= 'H00' and 구분2 <='H59'"

        ElseIf search_lb상병검색 = "H60~H99" Then

            where_lb상병검색 = " 구분1 >= 'H60' and 구분2 <='H99'"

        ElseIf search_lb상병검색 = "I00~I99" Then

            where_lb상병검색 = " 구분1 >= 'I00' and 구분2 <='I99'"

        ElseIf search_lb상병검색 = "J00~J99" Then

            where_lb상병검색 = " 구분1 >= 'J00' and 구분2 <='J99'"

        ElseIf search_lb상병검색 = "K00~K99" Then

            where_lb상병검색 = " 구분1 >= 'K00' and 구분2 <='K99'"

        ElseIf search_lb상병검색 = "L00~L99" Then

            where_lb상병검색 = " 구분1 >= 'L00' and 구분2 <='L99'"

        ElseIf search_lb상병검색 = "M00~M99" Then

            where_lb상병검색 = " 구분1 >= 'M00' and 구분2 <='m99'"

        ElseIf search_lb상병검색 = "N00~N99" Then

            where_lb상병검색 = " 구분1 >= 'N00' and 구분2 <='N99'"

        ElseIf search_lb상병검색 = "O00~O99" Then

            where_lb상병검색 = " 구분1 >= 'O00' and 구분2 <='O99'"

        ElseIf search_lb상병검색 = "P00~P99" Then

            where_lb상병검색 = " 구분1 >= 'P00' and 구분2 <='P99'"

        ElseIf search_lb상병검색 = "Q00~Q99" Then

            where_lb상병검색 = " 구분1 >= 'Q00' and 구분2 <='Q99'"

        ElseIf search_lb상병검색 = "R00~R99" Then

            where_lb상병검색 = " 구분1 >= 'R00' and 구분2 <='R99'"

        ElseIf search_lb상병검색 = "S00~T99" Then

            where_lb상병검색 = " 구분1 >= 'S00' and 구분2 <='T99'"

        ElseIf search_lb상병검색 = "U00~U99" Then

            where_lb상병검색 = " 구분1 >= 'U00' and 구분2 <='U99'"

        ElseIf search_lb상병검색 = "V00~Y99" Then

            where_lb상병검색 = " 구분1 >= 'V00' and 구분2 <='Y99'"

        End If

        SqlStr = "select 구분1,구분2,내역 "
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_sangsearch"
        SqlStr = SqlStr & vbCrLf & "where "
        SqlStr = SqlStr & vbCrLf & where_lb상병검색

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        Fps상병분류.Sheets(0).RowCount = 0

        sprR = -1
        sang.Clear()
        While SqlRS.Read()
            sprR = sprR + 1

            Fps상병분류.Sheets(0).RowCount = sprR + 1
            Fps상병분류.Sheets(0).SetText(sprR, 0, SqlRS.GetString("내역").Trim())
            Fps상병분류.Sheets(0).SetText(sprR, 1, SqlRS.GetString("구분1") & "," & SqlRS.GetString("구분2").Trim())

        End While

        SqlRS.Close()


    End Sub



    Private Sub Fps상병분류_MouseUp(sender As Object, e As MouseEventArgs) Handles Fps상병분류.MouseUp
        With Fps상병분류.ActiveSheet
            Call h_snag_list_리스트("cell_click", .GetText(.ActiveCell.Row.Index, 1))
        End With
    End Sub

    Private Sub h_snag_list_리스트(search_type As String, gooboon As String)
        On Error GoTo ErrRtn
        '상병기호 리스트 쿼리문
        Dim sprR As Long
        Dim arr_gooboon
        arr_gooboon = ""

        If gooboon <> "" Then
            arr_gooboon = Split(gooboon, ",")
        End If

        SqlStr = "select * "
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_sang"
        SqlStr = SqlStr & vbCrLf & "where "
        If search_type = "cell_click" Then
            SqlStr = SqlStr & vbCrLf & " 상병기호 >='" & arr_gooboon(0) & "' and 상병기호 <='" & arr_gooboon(1) & "99'"
        Else
            SqlStr = SqlStr & vbCrLf & " 한글명 like '%" & search_type & "%' "
        End If
        SqlStr = SqlStr & vbCrLf & " order by 상병기호 asc, 한글명 asc "

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        Fps상병검색.Sheets(0).RowCount = 0

        sprR = -1
        sang.Clear()
        While SqlRS.Read()
            sprR = sprR + 1

            Fps상병검색.Sheets(0).RowCount = sprR + 1
            Fps상병검색.Sheets(0).SetText(sprR, 0, SqlRS.GetString("순번").Trim())
            Fps상병검색.Sheets(0).SetText(sprR, 1, SqlRS.GetString("상병기호").Trim())
            Fps상병검색.Sheets(0).SetText(sprR, 2, SqlRS.GetString("한글명").Trim())
            Fps상병검색.Sheets(0).SetText(sprR, 3, SqlRS.GetString("특정기호").Trim())

        End While

        SqlRS.Close()
        Exit Sub
ErrRtn:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub Btn검색_Click(sender As Object, e As System.EventArgs) Handles Btn검색.Click
        Call h_snag_list_리스트(txt상병명칭.Text.ToString, "")
    End Sub

    Private Sub txt상병명칭_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt상병명칭.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            Call h_snag_list_리스트(txt상병명칭.Text.ToString, "")
            Fps상병분류.Sheets(0).RowCount = 0
        End If
    End Sub

    Private Sub Fps상병분류_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles Fps상병분류.CellClick

    End Sub
End Class
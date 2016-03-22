
Public Class frm기본자료등록

    Private Sub h_base_구분조회()

        SqlStr = "select distinct 구분"
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_base "
        SqlStr = SqlStr & vbCrLf & "Order by 구분"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        Lst메뉴.Items.Clear()
        While SqlRS.Read()
            Lst메뉴.Items.Add(SqlRS.GetString("구분"))
        End While
        SqlRS.Close()

    End Sub

    Private Sub h_base_구분내역조회()
        Dim sprR As Long

        SqlStr = "select 구분,코드명,분류항,분류목,메모,비고,적용일자,사용여부"
        SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_base "
        SqlStr = SqlStr & vbCrLf & "where  구분 = '" + txt구분.Text + "'"
        SqlStr = SqlStr & vbCrLf & "order by 코드명,분류항, 분류목"


        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        sprR = -1
        sprDisplay.Sheets(0).RowCount = 0

        Dim row As FarPoint.Win.Spread.Row
        Dim size As Single

        While SqlRS.Read()
            sprR = sprR + 1
            sprDisplay.Sheets(0).RowCount = sprR + 1
            sprDisplay.Sheets(0).SetText(sprR, 0, SqlRS.GetString("코드명"))
            sprDisplay.Sheets(0).SetText(sprR, 1, SqlRS.GetString("분류항"))
            sprDisplay.Sheets(0).SetText(sprR, 2, SqlRS.GetString("분류목"))
            sprDisplay.Sheets(0).SetText(sprR, 3, SqlRS.GetString("메모"))
            sprDisplay.Sheets(0).SetText(sprR, 4, SqlRS.GetString("비고"))
            sprDisplay.Sheets(0).SetText(sprR, 5, IIf(SqlRS.GetString("사용여부") = "Y", True, False))

            row = sprDisplay.ActiveSheet.Rows(CType(sprR, Integer))
            size = row.GetPreferredHeight()
            row.Height = size

        End While

        SqlRS.Close()

    End Sub
    Private Function h_base_저장() As Boolean '저장기능은 무조건 function 으로 해야한다.
        Dim sprR As Long


        '-------------------------------------------------------------------------------------------------------------
        '   자료점검
        '-------------------------------------------------------------------------------------------------------------
        If txt구분.Text.Trim() = "" Then
            Return False
        End If

        '-------------------------------------------------------------------------------------------------------------
        '   구분 조건으로 삭제
        '-------------------------------------------------------------------------------------------------------------
        SqlStr = "delete"
        SqlStr = SqlStr & vbCrLf & "from   kpi_base.h_base "
        SqlStr = SqlStr & vbCrLf & "where  구분 = '" + txt구분.Text + "'"

        If mSQLExec(SqlStr) = False Then Return False

        For sprR = 0 To sprDisplay.Sheets(0).RowCount - 1

            SqlStr = "insert into kpi_base.h_base"
            SqlStr = SqlStr & vbCrLf & "   (구분,코드명,분류항,분류목,메모,비고,적용일자,사용여부,조작자,조작일시)"
            SqlStr = SqlStr & vbCrLf & "VALUES('" + txt구분.Text + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 0) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 1) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 2) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 3) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 4) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + "0000-00-00" + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + IIf(sprDisplay.Sheets(0).GetText(sprR, 5) = False, "N", "Y") + "',"
            SqlStr = SqlStr & vbCrLf & "       '"
            SqlStr = SqlStr & vbCrLf & "            now())"

            SqlStr = SqlStr & vbCrLf & "ON DUPLICATE KEY UPDATE"
            SqlStr = SqlStr & vbCrLf & "   메모     ='" + sprDisplay.Sheets(0).GetText(sprR, 3) + "',"
            SqlStr = SqlStr & vbCrLf & "   비고     ='" + sprDisplay.Sheets(0).GetText(sprR, 4) + "',"
            SqlStr = SqlStr & vbCrLf & "   적용일자 ='" + "0000-00-00" + "',"
            SqlStr = SqlStr & vbCrLf & "   사용여부 ='" + IIf(sprDisplay.Sheets(0).GetText(sprR, 5) = False, "N", "Y") + "',"
            SqlStr = SqlStr & vbCrLf & "   조작자   ="
            SqlStr = SqlStr & vbCrLf & "   조작일시 = now()"

            Call mSQLExec(SqlStr)

        Next

        Return True


    End Function

    Private Sub frm기본자료등록_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call h_base_구분조회()
    End Sub

    Private Sub Lst메뉴_DoubleClick(sender As Object, e As EventArgs) Handles Lst메뉴.DoubleClick
        txt구분.Text = Lst메뉴.Text
        Call h_base_구분내역조회()
    End Sub
    Private Sub sprDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles sprDisplay.KeyDown

        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("줄삭제 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                sprDisplay.Sheets(0).RemoveRows(sprDisplay.Sheets(0).ActiveRowIndex, 1)
            End If
        End If
    End Sub


    Private Sub 종료ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub




    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub 출력ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 출력ToolStripMenuItem.Click
        Call mSprPrint(sprDisplay, True, txt구분.Text.Trim())
    End Sub

    Private Sub 라인추가ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 라인추가ToolStripMenuItem.Click
        Call sprDisplay.Sheets(0).AddRows(sprDisplay.Sheets(0).ActiveRowIndex, 1)
    End Sub

    Private Sub 저장ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 저장ToolStripMenuItem.Click
        If h_base_저장() = True Then Call MessageBox.Show("저장되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub 화면ClearToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 화면ClearToolStripMenuItem.Click
        Call h_base_구분조회()
        txt구분.Text = ""
        sprDisplay.Sheets(0).RowCount = 0
    End Sub
End Class
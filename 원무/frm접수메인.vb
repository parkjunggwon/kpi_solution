Public Class frm접수메인
    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub 화면clearToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 화면ClearToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 화면ClearToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Frm예약관리.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Frm미수수납.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Frm제증명입력.Show()
    End Sub
End Class
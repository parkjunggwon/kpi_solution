Public Class frm수납메인


    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub 유형변경ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 유형변경ToolStripMenuItem.Click
        Frm유형변경.Show()
    End Sub

    Private Sub 환불ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 환불ToolStripMenuItem.Click
        Frm환불.Show()
    End Sub

    Private Sub 미수수납ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 미수수납ToolStripMenuItem.Click
        Frm미수수납.Show()
    End Sub

    Private Sub 예약관리ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 예약관리ToolStripMenuItem.Click
        Frm예약관리.Show()
    End Sub
End Class
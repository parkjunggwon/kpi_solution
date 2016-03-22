Public Class FrmMain

    Public FormMax As Integer = 5
    Public Formcnt As Integer = 0


    Private Sub 진료실ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        frm진료실.MdiParent = Me
        frm진료실.Show()

    End Sub

    Private Sub 수납ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm수납메인.MdiParent = Me
        frm수납메인.Show()
    End Sub

    Private Sub 수가관리ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm수가등록.MdiParent = Me
        frm수가등록.Show()
    End Sub

    Private Sub 약속코드등록ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm약속처방등록.MdiParent = Me
        frm약속처방등록.Show()
    End Sub

    Private Sub 사용자등록ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm사용자등록.MdiParent = Me
        frm사용자등록.Show()
    End Sub

    Private Sub 사용자등록ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 기본자료등록ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm기본자료등록.MdiParent = Me
        frm기본자료등록.Show()
    End Sub




    Private Sub 사용자등록ToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        frm사용자등록.MdiParent = Me
        frm사용자등록.Show()
    End Sub

    Private Sub 상병관리ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 접수ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 접수ToolStripMenuItem.Click
        frm접수메인.MdiParent = Me
        frm접수메인.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call mSQLConn()
    End Sub

    Private Sub FrmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Call mSQLDisconn()
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Me.Dispose()
        Application.Exit()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 수납ToolStripMenuItem1.Click
        frm수납메인.MdiParent = Me
        frm수납메인.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 진료실ToolStripMenuItem.Click
        frm진료실.MdiParent = Me
        frm진료실.Show()
    End Sub

    Private Sub 수가등록ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 수가등록ToolStripMenuItem.Click
        frm수가등록.MdiParent = Me
        frm수가등록.Show()
    End Sub

    Private Sub 기초자료등록ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 기초자료등록ToolStripMenuItem.Click
        frm기본자료등록.MdiParent = Me
        frm기본자료등록.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub 사용자등록ToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles 사용자등록ToolStripMenuItem.Click
        frm사용자등록.MdiParent = Me
        frm사용자등록.Show()
    End Sub
End Class

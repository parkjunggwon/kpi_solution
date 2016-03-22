Imports FarPoint.Win.Spread

Public Class frm프로그램설정

    Private Sub h_pgconfig_화면명조회()

        SqlStr = "select distinct 화면명"
        SqlStr = SqlStr & vbCrLf & "from kpi_base.h_pgconfig "
        SqlStr = SqlStr & vbCrLf & "Order by 화면명"
        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        Lst화면명.Items.Clear()
        While SqlRS.Read()
            Lst화면명.Items.Add(SqlRS.GetString("화면명"))
        End While
        SqlRS.Close()

    End Sub

    Private Sub h_pgconfig_화면명내역조회()
        Dim sprR As Long

        SqlStr = "select 설정명,설정값,비고,권한레벨"
        SqlStr = SqlStr & vbCrLf & "from  kpi_base.h_pgconfig "
        SqlStr = SqlStr & vbCrLf & "where  화면명 = '" + txt화면명.Text + "'"
        SqlStr = SqlStr & vbCrLf & "order by 화면명,설정명"

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        sprR = -1
        sprDisplay.Sheets(0).RowCount = 0

        Dim row As FarPoint.Win.Spread.Row
        Dim size As Single

        While SqlRS.Read()
            sprR = sprR + 1
            sprDisplay.Sheets(0).RowCount = sprR + 1
            sprDisplay.Sheets(0).SetText(sprR, 0, SqlRS.GetString("설정명"))
            sprDisplay.Sheets(0).SetText(sprR, 1, SqlRS.GetString("설정값"))
            sprDisplay.Sheets(0).SetText(sprR, 2, SqlRS.GetString("비고"))

            Select Case SqlRS.GetString("권한레벨")
                Case "20" : sprDisplay.Sheets(0).Cells(sprR, 5).Value = True
                Case "10" : sprDisplay.Sheets(0).Cells(sprR, 4).Value = True
                Case Else : sprDisplay.Sheets(0).Cells(sprR, 3).Value = True
            End Select

            row = sprDisplay.ActiveSheet.Rows(CType(sprR, Integer))
            size = row.GetPreferredHeight()
            row.Height = size

        End While

        SqlRS.Close()

    End Sub
    Private Function h_pgconfig_저장() As Boolean '저장기능은 무조건 function 으로 해야한다.
        Dim sprR As Long
        Dim 권한레벨 As String


        '-------------------------------------------------------------------------------------------------------------
        '   자료점검
        '-------------------------------------------------------------------------------------------------------------
        If txt화면명.Text.Trim() = "" Then
            Return False
        End If


        For sprR = 0 To sprDisplay.Sheets(0).RowCount - 1

            권한레벨 = "00"
            If sprDisplay.Sheets(0).Cells(sprR, 4).Value = True Then 권한레벨 = "10"
            If sprDisplay.Sheets(0).Cells(sprR, 5).Value = True Then 권한레벨 = "20"

            SqlStr = "insert into kpi_base.h_pgconfig"
            SqlStr = SqlStr & vbCrLf & "   (화면명,설정명,설정값,비고,권한레벨,조작자,조작일시)"
            SqlStr = SqlStr & vbCrLf & "VALUES('" + txt화면명.Text + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 0) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 1) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + sprDisplay.Sheets(0).GetText(sprR, 2) + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + 권한레벨 + "',"
            SqlStr = SqlStr & vbCrLf & "       '" + m사용자.아이디 + "',"
            SqlStr = SqlStr & vbCrLf & "            now())"

            SqlStr = SqlStr & vbCrLf & "ON DUPLICATE KEY UPDATE"
            SqlStr = SqlStr & vbCrLf & "   설정값     ='" + sprDisplay.Sheets(0).GetText(sprR, 1) + "',"
            SqlStr = SqlStr & vbCrLf & "   비고     ='" + sprDisplay.Sheets(0).GetText(sprR, 2) + "',"
            SqlStr = SqlStr & vbCrLf & "   권한레벨 ='" + 권한레벨 + "',"
            SqlStr = SqlStr & vbCrLf & "   조작자   ='" + m사용자.아이디 + "',"
            SqlStr = SqlStr & vbCrLf & "   조작일시 = now()"

            Call mSQLExec(SqlStr)
        Next

        Return True


    End Function

    Private Sub frm프로그램설정_Load(sender As Object, e As EventArgs) Handles Me.Load


        Call h_pgconfig_화면명조회()
    End Sub

    Private Sub Lst화면명_DoubleClick(sender As Object, e As EventArgs) Handles Lst화면명.DoubleClick
        txt화면명.Text = Lst화면명.Text
        Call h_pgconfig_화면명내역조회()
    End Sub
    Private Sub sprDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles sprDisplay.KeyDown

        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("줄삭제 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                sprDisplay.Sheets(0).RemoveRows(sprDisplay.Sheets(0).ActiveRowIndex, 1)
            End If
        End If
    End Sub

    Private Sub 화면clearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 화면clearToolStripMenuItem.Click
        Call h_pgconfig_화면명조회()
        txt화면명.Text = ""
        sprDisplay.Sheets(0).RowCount = 0
    End Sub

    Private Sub 종료ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem1.Click
        Me.Dispose()
    End Sub

    Private Sub 저장ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 저장ToolStripMenuItem.Click
        If h_pgconfig_저장() = True Then Call MessageBox.Show("저장되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub 라인추가ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 라인추가ToolStripMenuItem.Click
        If sprDisplay.Sheets(0).RowCount = 0 Then
            sprDisplay.Sheets(0).RowCount = 1
        Else
            Call sprDisplay.Sheets(0).AddRows(sprDisplay.Sheets(0).ActiveRowIndex, 1)
        End If
    End Sub

    Private Sub 출력ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 출력ToolStripMenuItem.Click

        Call mSprPrint(sprDisplay, True, txt화면명.Text.Trim())
    End Sub



    Private Sub sprDisplay_Change(sender As Object, e As ChangeEventArgs) Handles sprDisplay.Change
        Dim c As Long
        If sprDisplay.Sheets(0).ActiveColumnIndex >= 3 Then
            For c = 3 To 5
                If c <> sprDisplay.Sheets(0).ActiveColumnIndex Then sprDisplay.Sheets(0).Cells(sprDisplay.Sheets(0).ActiveRowIndex, c).Value = False
            Next
        End If
    End Sub

End Class
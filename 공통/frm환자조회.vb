Public Class frm환자조회


    Private Sub w_hmaster_환자조회()
        Dim sprR As Long

        If txt검색조건.Text.Trim() = "" Then Exit Sub
        If cbo검색조건.Text.Trim() = "" Then Exit Sub

        SqlStr = "select 성명,챠트번호,생년월일,핸드폰,최종방문일,주소"
        SqlStr = SqlStr & vbCrLf & "from  kpi_wonmu.w_hmaster "
        If cbo검색조건.SelectedIndex = 0 Then SqlStr = SqlStr & vbCrLf & "where 성명 like '" + txt검색조건.Text + "%'"
        SqlStr = SqlStr & vbCrLf & "order by 성명,최종방문일 desc"

        If mSQLSelect(SqlStr, SqlRS) = False Then Exit Sub

        sprR = -1
        sprDisplay.Sheets(0).RowCount = 0

        While SqlRS.Read()
            sprR = sprR + 1
            sprDisplay.Sheets(0).RowCount = sprR + 1
            sprDisplay.Sheets(0).SetText(sprR, 0, SqlRS.GetString("성명"))
            sprDisplay.Sheets(0).SetText(sprR, 1, SqlRS.GetString("챠트번호"))
            sprDisplay.Sheets(0).SetText(sprR, 2, SqlRS.GetString("생년월일"))
            sprDisplay.Sheets(0).SetText(sprR, 3, SqlRS.GetString("핸드폰"))
            sprDisplay.Sheets(0).SetText(sprR, 4, SqlRS.GetString("최종방문일"))
            sprDisplay.Sheets(0).SetText(sprR, 5, SqlRS.GetString("주소"))

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
            SqlStr = SqlStr & vbCrLf & "       '" + m사용자.아이디 + "',"
            SqlStr = SqlStr & vbCrLf & "            now())"

            SqlStr = SqlStr & vbCrLf & "ON DUPLICATE KEY UPDATE"
            SqlStr = SqlStr & vbCrLf & "   메모     ='" + sprDisplay.Sheets(0).GetText(sprR, 3) + "',"
            SqlStr = SqlStr & vbCrLf & "   비고     ='" + sprDisplay.Sheets(0).GetText(sprR, 4) + "',"
            SqlStr = SqlStr & vbCrLf & "   적용일자 ='" + "0000-00-00" + "',"
            SqlStr = SqlStr & vbCrLf & "   사용여부 ='" + IIf(sprDisplay.Sheets(0).GetText(sprR, 5) = False, "N", "Y") + "',"
            SqlStr = SqlStr & vbCrLf & "   조작자   ='" + m사용자.아이디 + "',"
            SqlStr = SqlStr & vbCrLf & "   조작일시 = now()"

            Call mSQLExec(SqlStr)
        Next

        Return True


    End Function

    Private Sub frm기본자료등록_Load(sender As Object, e As EventArgs)
        Call h_base_구분조회()
    End Sub


    Private Sub 화면clearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 화면clearToolStripMenuItem.Click

    End Sub

    Private Sub 종료ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem1.Click
        Me.Dispose()
    End Sub


End Class
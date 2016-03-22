<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm환자조회
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim RichTextCellType1 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType2 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType3 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType4 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType5 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType6 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim NoPrinterPrintInfo1 As FarPoint.Win.Spread.NoPrinterPrintInfo = New FarPoint.Win.Spread.NoPrinterPrintInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm환자조회))
        Me.txt검색조건 = New System.Windows.Forms.TextBox()
        Me.sprDisplay = New FarPoint.Win.Spread.FpSpread()
        Me.sprDisplay_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.sprDisplay_Sheet2 = New FarPoint.Win.Spread.SheetView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면clearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.선택ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbo검색조건 = New System.Windows.Forms.ComboBox()
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt검색조건
        '
        Me.txt검색조건.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt검색조건.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt검색조건.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txt검색조건.Location = New System.Drawing.Point(138, 51)
        Me.txt검색조건.Name = "txt검색조건"
        Me.txt검색조건.Size = New System.Drawing.Size(128, 22)
        Me.txt검색조건.TabIndex = 28
        Me.txt검색조건.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sprDisplay
        '
        Me.sprDisplay.AccessibleDescription = "sprDisplay, Sheet1, Row 0, Column 0, "
        Me.sprDisplay.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.sprDisplay.Location = New System.Drawing.Point(12, 79)
        Me.sprDisplay.Name = "sprDisplay"
        Me.sprDisplay.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.sprDisplay_Sheet1, Me.sprDisplay_Sheet2})
        Me.sprDisplay.Size = New System.Drawing.Size(587, 396)
        Me.sprDisplay.TabIndex = 68
        '
        'sprDisplay_Sheet1
        '
        Me.sprDisplay_Sheet1.Reset()
        Me.sprDisplay_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.sprDisplay_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.sprDisplay_Sheet1.ColumnCount = 6
        Me.sprDisplay_Sheet1.RowCount = 5
        Me.sprDisplay_Sheet1.Cells.Get(0, 0).Value = "{\rtf1\ansi\ansicpg949\deff0\deflang1033\deflangfe1042{\fonttbl{\f0\fswiss\fchars" &
    "et0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang1042\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.sprDisplay_Sheet1.Cells.Get(0, 2).Value = "{\rtf1\ansi\ansicpg949\deff0\deflang1033\deflangfe1042{\fonttbl{\f0\fswiss\fchars" &
    "et0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang1042\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.sprDisplay_Sheet1.ColumnFooter.Rows.Get(0).Height = 0!
        Me.sprDisplay_Sheet1.ColumnFooter.Visible = True
        Me.sprDisplay_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprDisplay_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.sprDisplay_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.sprDisplay_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "성명"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "챠트번호"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "생년월일"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "핸드폰"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "최종방문일"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "주소"
        RichTextCellType1.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(0).CellType = RichTextCellType1
        Me.sprDisplay_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(0).Label = "성명"
        Me.sprDisplay_Sheet1.Columns.Get(0).Width = 70.0!
        RichTextCellType2.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(1).CellType = RichTextCellType2
        Me.sprDisplay_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(1).Label = "챠트번호"
        Me.sprDisplay_Sheet1.Columns.Get(1).Width = 63.0!
        RichTextCellType3.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(2).CellType = RichTextCellType3
        Me.sprDisplay_Sheet1.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(2).Label = "생년월일"
        Me.sprDisplay_Sheet1.Columns.Get(2).Width = 68.0!
        RichTextCellType4.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(3).CellType = RichTextCellType4
        Me.sprDisplay_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(3).Label = "핸드폰"
        Me.sprDisplay_Sheet1.Columns.Get(3).Width = 92.0!
        RichTextCellType5.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(4).CellType = RichTextCellType5
        Me.sprDisplay_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(4).Label = "최종방문일"
        Me.sprDisplay_Sheet1.Columns.Get(4).Width = 82.0!
        RichTextCellType6.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(5).CellType = RichTextCellType6
        Me.sprDisplay_Sheet1.Columns.Get(5).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(5).Label = "주소"
        Me.sprDisplay_Sheet1.Columns.Get(5).Width = 299.0!
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprDisplay_Sheet1.PrintInfo.Footer = ""
        Me.sprDisplay_Sheet1.PrintInfo.Header = ""
        Me.sprDisplay_Sheet1.PrintInfo.JobName = ""
        NoPrinterPrintInfo1.Bounds = New System.Drawing.Rectangle(0, 0, 816, 11)
        NoPrinterPrintInfo1.HardMarginX = 0!
        NoPrinterPrintInfo1.HardMarginY = 0!
        NoPrinterPrintInfo1.SupportColor = True
        Me.sprDisplay_Sheet1.PrintInfo.NoPrinterSetting = NoPrinterPrintInfo1
        Me.sprDisplay_Sheet1.PrintInfo.Printer = ""
        Me.sprDisplay_Sheet1.PrintInfo.SmartPrintRules = CType(resources.GetObject("resource.SmartPrintRules"), FarPoint.Win.Spread.SmartPrintRulesCollection)
        Me.sprDisplay_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.sprDisplay_Sheet1.RowHeader.Columns.Get(0).Width = 66.0!
        Me.sprDisplay_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'sprDisplay_Sheet2
        '
        Me.sprDisplay_Sheet2.Reset()
        Me.sprDisplay_Sheet2.SheetName = "Sheet2"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.sprDisplay_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.sprDisplay_Sheet2.ActiveColumnIndex = 2
        Me.sprDisplay_Sheet2.ActiveRowIndex = 32
        Me.sprDisplay_Sheet2.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprDisplay_Sheet2.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.sprDisplay_Sheet2.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.sprDisplay_Sheet2.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprDisplay_Sheet2.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprDisplay_Sheet2.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.sprDisplay_Sheet2.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.sprDisplay_Sheet2.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprDisplay_Sheet2.RowHeader.Columns.Default.Resizable = False
        Me.sprDisplay_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면clearToolStripMenuItem, Me.선택ToolStripMenuItem, Me.종료ToolStripMenuItem, Me.종료ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 40)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '화면clearToolStripMenuItem
        '
        Me.화면clearToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.가퇴원
        Me.화면clearToolStripMenuItem.Name = "화면clearToolStripMenuItem"
        Me.화면clearToolStripMenuItem.Size = New System.Drawing.Size(68, 36)
        Me.화면clearToolStripMenuItem.Text = "화면clear"
        Me.화면clearToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '선택ToolStripMenuItem
        '
        Me.선택ToolStripMenuItem.Name = "선택ToolStripMenuItem"
        Me.선택ToolStripMenuItem.Size = New System.Drawing.Size(51, 36)
        Me.선택ToolStripMenuItem.Text = "선  택"
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(12, 36)
        '
        '종료ToolStripMenuItem1
        '
        Me.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1"
        Me.종료ToolStripMenuItem1.Size = New System.Drawing.Size(51, 36)
        Me.종료ToolStripMenuItem1.Text = "종  료"
        '
        'cbo검색조건
        '
        Me.cbo검색조건.FormattingEnabled = True
        Me.cbo검색조건.Items.AddRange(New Object() {"성명", "생년월일", "피보험자"})
        Me.cbo검색조건.Location = New System.Drawing.Point(12, 51)
        Me.cbo검색조건.Name = "cbo검색조건"
        Me.cbo검색조건.Size = New System.Drawing.Size(120, 20)
        Me.cbo검색조건.TabIndex = 76
        '
        'frm환자조회
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 487)
        Me.Controls.Add(Me.cbo검색조건)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.sprDisplay)
        Me.Controls.Add(Me.txt검색조건)
        Me.Name = "frm환자조회"
        Me.Text = "환자조회"
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt검색조건 As TextBox
    Friend WithEvents sprDisplay As FarPoint.Win.Spread.FpSpread
    Friend WithEvents sprDisplay_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents sprDisplay_Sheet2 As FarPoint.Win.Spread.SheetView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면clearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 선택ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cbo검색조건 As ComboBox
End Class

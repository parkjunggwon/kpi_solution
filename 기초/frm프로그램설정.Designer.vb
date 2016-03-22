<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm프로그램설정
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
        Dim RichTextCellType4 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType5 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType6 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim CheckBoxCellType4 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim CheckBoxCellType5 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim CheckBoxCellType6 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim NoPrinterPrintInfo2 As FarPoint.Win.Spread.NoPrinterPrintInfo = New FarPoint.Win.Spread.NoPrinterPrintInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm프로그램설정))
        Me.sprDisplay = New FarPoint.Win.Spread.FpSpread()
        Me.sprDisplay_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.sprDisplay_Sheet2 = New FarPoint.Win.Spread.SheetView()
        Me.Lst화면명 = New System.Windows.Forms.ListBox()
        Me.txt화면명 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면clearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.치료실ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.라인추가ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.출력ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sprDisplay
        '
        Me.sprDisplay.AccessibleDescription = "sprDisplay, Sheet1, Row 0, Column 0, "
        Me.sprDisplay.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.sprDisplay.Location = New System.Drawing.Point(322, 96)
        Me.sprDisplay.Name = "sprDisplay"
        Me.sprDisplay.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.sprDisplay_Sheet1, Me.sprDisplay_Sheet2})
        Me.sprDisplay.Size = New System.Drawing.Size(824, 822)
        Me.sprDisplay.TabIndex = 8
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
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "설정명"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "값"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "비고"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "사용자"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "병원관리자"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "KPI"
        Me.sprDisplay_Sheet1.ColumnHeader.Rows.Get(0).Height = 31.0!
        RichTextCellType4.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(0).CellType = RichTextCellType4
        Me.sprDisplay_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(0).Label = "설정명"
        Me.sprDisplay_Sheet1.Columns.Get(0).Width = 226.0!
        RichTextCellType5.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(1).CellType = RichTextCellType5
        Me.sprDisplay_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(1).Label = "값"
        Me.sprDisplay_Sheet1.Columns.Get(1).Width = 62.0!
        RichTextCellType6.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(2).CellType = RichTextCellType6
        Me.sprDisplay_Sheet1.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(2).Label = "비고"
        Me.sprDisplay_Sheet1.Columns.Get(2).Width = 228.0!
        Me.sprDisplay_Sheet1.Columns.Get(3).CellType = CheckBoxCellType4
        Me.sprDisplay_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(3).Label = "사용자"
        Me.sprDisplay_Sheet1.Columns.Get(3).Width = 50.0!
        Me.sprDisplay_Sheet1.Columns.Get(4).CellType = CheckBoxCellType5
        Me.sprDisplay_Sheet1.Columns.Get(4).Label = "병원관리자"
        Me.sprDisplay_Sheet1.Columns.Get(4).Width = 50.0!
        Me.sprDisplay_Sheet1.Columns.Get(5).CellType = CheckBoxCellType6
        Me.sprDisplay_Sheet1.Columns.Get(5).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(5).Label = "KPI"
        Me.sprDisplay_Sheet1.Columns.Get(5).Width = 50.0!
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.sprDisplay_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprDisplay_Sheet1.PrintInfo.Footer = ""
        Me.sprDisplay_Sheet1.PrintInfo.Header = ""
        Me.sprDisplay_Sheet1.PrintInfo.JobName = ""
        NoPrinterPrintInfo2.Bounds = New System.Drawing.Rectangle(0, 0, 816, 11)
        NoPrinterPrintInfo2.HardMarginX = 0!
        NoPrinterPrintInfo2.HardMarginY = 0!
        NoPrinterPrintInfo2.SupportColor = True
        Me.sprDisplay_Sheet1.PrintInfo.NoPrinterSetting = NoPrinterPrintInfo2
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
        'Lst화면명
        '
        Me.Lst화면명.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lst화면명.FormattingEnabled = True
        Me.Lst화면명.ItemHeight = 12
        Me.Lst화면명.Location = New System.Drawing.Point(12, 96)
        Me.Lst화면명.Name = "Lst화면명"
        Me.Lst화면명.Size = New System.Drawing.Size(304, 820)
        Me.Lst화면명.TabIndex = 76
        '
        'txt화면명
        '
        Me.txt화면명.Location = New System.Drawing.Point(436, 58)
        Me.txt화면명.Name = "txt화면명"
        Me.txt화면명.Size = New System.Drawing.Size(193, 21)
        Me.txt화면명.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "화면명"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면clearToolStripMenuItem, Me.저장ToolStripMenuItem, Me.치료실ToolStripMenuItem, Me.라인추가ToolStripMenuItem, Me.출력ToolStripMenuItem, Me.종료ToolStripMenuItem, Me.종료ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 40)
        Me.MenuStrip1.TabIndex = 79
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
        '저장ToolStripMenuItem
        '
        Me.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem"
        Me.저장ToolStripMenuItem.Size = New System.Drawing.Size(51, 36)
        Me.저장ToolStripMenuItem.Text = "저  장"
        '
        '치료실ToolStripMenuItem
        '
        Me.치료실ToolStripMenuItem.Name = "치료실ToolStripMenuItem"
        Me.치료실ToolStripMenuItem.Size = New System.Drawing.Size(12, 36)
        '
        '라인추가ToolStripMenuItem
        '
        Me.라인추가ToolStripMenuItem.Name = "라인추가ToolStripMenuItem"
        Me.라인추가ToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.라인추가ToolStripMenuItem.Text = "라인추가"
        '
        '출력ToolStripMenuItem
        '
        Me.출력ToolStripMenuItem.Name = "출력ToolStripMenuItem"
        Me.출력ToolStripMenuItem.Size = New System.Drawing.Size(51, 36)
        Me.출력ToolStripMenuItem.Text = "출  력"
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
        'frm프로그램설정
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 699)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt화면명)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lst화면명)
        Me.Controls.Add(Me.sprDisplay)
        Me.Name = "frm프로그램설정"
        Me.Text = "프로그램설정"
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sprDisplay As FarPoint.Win.Spread.FpSpread
    Friend WithEvents sprDisplay_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents sprDisplay_Sheet2 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Lst화면명 As ListBox
    Friend WithEvents txt화면명 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면clearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 치료실ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 라인추가ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 출력ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem1 As ToolStripMenuItem
End Class

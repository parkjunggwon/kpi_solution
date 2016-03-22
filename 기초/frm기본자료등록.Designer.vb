<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm기본자료등록
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RichTextCellType1 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType2 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType3 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType4 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim RichTextCellType5 As FarPoint.Win.Spread.CellType.RichTextCellType = New FarPoint.Win.Spread.CellType.RichTextCellType()
        Dim CheckBoxCellType1 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim NoPrinterPrintInfo1 As FarPoint.Win.Spread.NoPrinterPrintInfo = New FarPoint.Win.Spread.NoPrinterPrintInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm기본자료등록))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt구분 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sprDisplay = New FarPoint.Win.Spread.FpSpread()
        Me.sprDisplay_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.sprDisplay_Sheet2 = New FarPoint.Win.Spread.SheetView()
        Me.Lst메뉴 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.라인추가ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.출력ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt구분)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.sprDisplay)
        Me.Panel2.Controls.Add(Me.Lst메뉴)
        Me.Panel2.Location = New System.Drawing.Point(2, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 1009)
        Me.Panel2.TabIndex = 5
        '
        'txt구분
        '
        Me.txt구분.Location = New System.Drawing.Point(69, 11)
        Me.txt구분.Name = "txt구분"
        Me.txt구분.Size = New System.Drawing.Size(193, 21)
        Me.txt구분.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "항목구분"
        '
        'sprDisplay
        '
        Me.sprDisplay.AccessibleDescription = "sprDisplay, Sheet1, Row 0, Column 0, "
        Me.sprDisplay.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.sprDisplay.Location = New System.Drawing.Point(136, 42)
        Me.sprDisplay.Name = "sprDisplay"
        Me.sprDisplay.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.sprDisplay_Sheet1, Me.sprDisplay_Sheet2})
        Me.sprDisplay.Size = New System.Drawing.Size(1056, 822)
        Me.sprDisplay.TabIndex = 7
        Me.sprDisplay.SetViewportTopRow(1, 0, 3)
        '
        'sprDisplay_Sheet1
        '
        Me.sprDisplay_Sheet1.Reset()
        Me.sprDisplay_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.sprDisplay_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.sprDisplay_Sheet1.ColumnCount = 6
        Me.sprDisplay_Sheet1.RowCount = 5
        Me.sprDisplay_Sheet1.AddCustomName("구분", "#REF!", 0, 0, False, "")
        Me.sprDisplay_Sheet1.Cells.Get(0, 0).Value = "{\rtf1\ansi\ansicpg949\deff0\deflang1033\deflangfe1042{\fonttbl{\f0\fswiss\fchars" &
    "et0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang1042\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.sprDisplay_Sheet1.Cells.Get(0, 2).Value = "{\rtf1\ansi\ansicpg949\deff0\deflang1033\deflangfe1042{\fonttbl{\f0\fswiss\fchars" &
    "et0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang1042\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.sprDisplay_Sheet1.ColumnFooter.Rows.Get(0).Height = 0!
        Me.sprDisplay_Sheet1.ColumnFooter.Visible = True
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "코드명"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "분류항"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "분류목"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "메모"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "비고"
        Me.sprDisplay_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "사용여부"
        Me.sprDisplay_Sheet1.ColumnHeader.Rows.Get(0).Height = 32.0!
        RichTextCellType1.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(0).CellType = RichTextCellType1
        Me.sprDisplay_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.sprDisplay_Sheet1.Columns.Get(0).Label = "코드명"
        Me.sprDisplay_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(0).Width = 96.0!
        RichTextCellType2.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(1).CellType = RichTextCellType2
        Me.sprDisplay_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(1).Label = "분류항"
        Me.sprDisplay_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(1).Width = 40.0!
        RichTextCellType3.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(2).CellType = RichTextCellType3
        Me.sprDisplay_Sheet1.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(2).Label = "분류목"
        Me.sprDisplay_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(2).Width = 40.0!
        RichTextCellType4.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(3).CellType = RichTextCellType4
        Me.sprDisplay_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.sprDisplay_Sheet1.Columns.Get(3).Label = "메모"
        Me.sprDisplay_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(3).Width = 418.0!
        RichTextCellType5.WordWrap = True
        Me.sprDisplay_Sheet1.Columns.Get(4).CellType = RichTextCellType5
        Me.sprDisplay_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.sprDisplay_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.sprDisplay_Sheet1.Columns.Get(4).Label = "비고"
        Me.sprDisplay_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(4).Width = 109.0!
        CheckBoxCellType1.TextAlign = FarPoint.Win.ButtonTextAlign.TextLeftPictRight
        Me.sprDisplay_Sheet1.Columns.Get(5).CellType = CheckBoxCellType1
        Me.sprDisplay_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(5).Label = "사용여부"
        Me.sprDisplay_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprDisplay_Sheet1.Columns.Get(5).Width = 33.0!
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
        Me.sprDisplay_Sheet2.AddCustomName("구분", "#REF!", 0, 0, False, "")
        Me.sprDisplay_Sheet2.ActiveColumnIndex = 2
        Me.sprDisplay_Sheet2.ActiveRowIndex = 32
        Me.sprDisplay_Sheet2.RowHeader.Columns.Default.Resizable = False
        Me.sprDisplay_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Lst메뉴
        '
        Me.Lst메뉴.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lst메뉴.FormattingEnabled = True
        Me.Lst메뉴.ItemHeight = 12
        Me.Lst메뉴.Location = New System.Drawing.Point(0, 42)
        Me.Lst메뉴.Name = "Lst메뉴"
        Me.Lst메뉴.Size = New System.Drawing.Size(133, 820)
        Me.Lst메뉴.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면ClearToolStripMenuItem, Me.저장ToolStripMenuItem, Me.라인추가ToolStripMenuItem, Me.출력ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 39)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '화면ClearToolStripMenuItem
        '
        Me.화면ClearToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.취소1
        Me.화면ClearToolStripMenuItem.Name = "화면ClearToolStripMenuItem"
        Me.화면ClearToolStripMenuItem.Size = New System.Drawing.Size(70, 35)
        Me.화면ClearToolStripMenuItem.Text = "화면Clear"
        Me.화면ClearToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '저장ToolStripMenuItem
        '
        Me.저장ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.저장
        Me.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem"
        Me.저장ToolStripMenuItem.Size = New System.Drawing.Size(51, 35)
        Me.저장ToolStripMenuItem.Text = " 저 장"
        Me.저장ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '라인추가ToolStripMenuItem
        '
        Me.라인추가ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.diary
        Me.라인추가ToolStripMenuItem.Name = "라인추가ToolStripMenuItem"
        Me.라인추가ToolStripMenuItem.Size = New System.Drawing.Size(67, 35)
        Me.라인추가ToolStripMenuItem.Text = "라인추가"
        Me.라인추가ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '출력ToolStripMenuItem
        '
        Me.출력ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.출력1
        Me.출력ToolStripMenuItem.Name = "출력ToolStripMenuItem"
        Me.출력ToolStripMenuItem.Size = New System.Drawing.Size(47, 35)
        Me.출력ToolStripMenuItem.Text = "출 력"
        Me.출력ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.종료
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(47, 35)
        Me.종료ToolStripMenuItem.Text = "종 료"
        Me.종료ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frm기본자료등록
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 913)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm기본자료등록"
        Me.Text = "기본자료 등록"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.sprDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprDisplay_Sheet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sprDisplay As FarPoint.Win.Spread.FpSpread
    Friend WithEvents sprDisplay_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt구분 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lst메뉴 As ListBox
    Friend WithEvents sprDisplay_Sheet2 As FarPoint.Win.Spread.SheetView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 라인추가ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 출력ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
End Class

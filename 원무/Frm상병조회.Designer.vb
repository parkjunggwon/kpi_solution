<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm상병조회
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
        Dim CheckBoxCellType1 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn검색 = New System.Windows.Forms.Button()
        Me.txt상병명칭 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.내상병저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.내상병조회ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lb순번 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Fps상병분류 = New FarPoint.Win.Spread.FpSpread()
        Me.Fps상병분류_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Fps상병검색 = New FarPoint.Win.Spread.FpSpread()
        Me.Fps상병검색_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Fps상병분류, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fps상병분류_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Fps상병검색, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fps상병검색_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn검색)
        Me.Panel1.Controls.Add(Me.txt상병명칭)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 69)
        Me.Panel1.TabIndex = 0
        '
        'Btn검색
        '
        Me.Btn검색.Location = New System.Drawing.Point(567, 43)
        Me.Btn검색.Name = "Btn검색"
        Me.Btn검색.Size = New System.Drawing.Size(67, 23)
        Me.Btn검색.TabIndex = 67
        Me.Btn검색.Text = "검색"
        Me.Btn검색.UseVisualStyleBackColor = True
        '
        'txt상병명칭
        '
        Me.txt상병명칭.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt상병명칭.Location = New System.Drawing.Point(336, 43)
        Me.txt상병명칭.Name = "txt상병명칭"
        Me.txt상병명칭.Size = New System.Drawing.Size(128, 21)
        Me.txt상병명칭.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(281, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "상병명칭"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면ClearToolStripMenuItem, Me.내상병저장ToolStripMenuItem, Me.내상병조회ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 36)
        Me.MenuStrip1.TabIndex = 79
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '화면ClearToolStripMenuItem
        '
        Me.화면ClearToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.취소1
        Me.화면ClearToolStripMenuItem.Name = "화면ClearToolStripMenuItem"
        Me.화면ClearToolStripMenuItem.Size = New System.Drawing.Size(71, 32)
        Me.화면ClearToolStripMenuItem.Text = "화면Clear"
        Me.화면ClearToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '내상병저장ToolStripMenuItem
        '
        Me.내상병저장ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.저장
        Me.내상병저장ToolStripMenuItem.Name = "내상병저장ToolStripMenuItem"
        Me.내상병저장ToolStripMenuItem.Size = New System.Drawing.Size(77, 32)
        Me.내상병저장ToolStripMenuItem.Text = "내상병저장"
        Me.내상병저장ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '내상병조회ToolStripMenuItem
        '
        Me.내상병조회ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.조회
        Me.내상병조회ToolStripMenuItem.Name = "내상병조회ToolStripMenuItem"
        Me.내상병조회ToolStripMenuItem.Size = New System.Drawing.Size(77, 32)
        Me.내상병조회ToolStripMenuItem.Text = "내상병조회"
        Me.내상병조회ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.종료
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(49, 32)
        Me.종료ToolStripMenuItem.Text = "종  료"
        Me.종료ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Lb순번)
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 546)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(74, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(163, 506)
        Me.Panel3.TabIndex = 2
        '
        'Lb순번
        '
        Me.Lb순번.FormattingEnabled = True
        Me.Lb순번.ItemHeight = 12
        Me.Lb순번.Items.AddRange(New Object() {"A00~B99", "C00~D49", "D50~D89", "E00~E90", "F00~F99", "G00~G99", "H00~H59", "H60~H99", "I00~I99", "J00~J99", "K00~K99", "L00~L99", "M00~M99", "N00~N99", "O00~O99", "P00~P99", "Q00~Q99", "R00~R99", "S00~T99", "U00~U99", "V00~Y99"})
        Me.Lb순번.Location = New System.Drawing.Point(1, 4)
        Me.Lb순번.Name = "Lb순번"
        Me.Lb순번.Size = New System.Drawing.Size(67, 544)
        Me.Lb순번.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.Fps상병분류)
        Me.Panel4.Location = New System.Drawing.Point(74, 72)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 546)
        Me.Panel4.TabIndex = 2
        '
        'Fps상병분류
        '
        Me.Fps상병분류.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.Fps상병분류.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.Fps상병분류.Location = New System.Drawing.Point(1, 2)
        Me.Fps상병분류.Name = "Fps상병분류"
        Me.Fps상병분류.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Fps상병분류_Sheet1})
        Me.Fps상병분류.Size = New System.Drawing.Size(195, 540)
        Me.Fps상병분류.TabIndex = 0
        '
        'Fps상병분류_Sheet1
        '
        Me.Fps상병분류_Sheet1.Reset()
        Me.Fps상병분류_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Fps상병분류_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Fps상병분류_Sheet1.ColumnCount = 3
        Me.Fps상병분류_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "상병분류"
        Me.Fps상병분류_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "구분1"
        Me.Fps상병분류_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "구분2"
        Me.Fps상병분류_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.Fps상병분류_Sheet1.Columns.Get(0).Label = "상병분류"
        Me.Fps상병분류_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Fps상병분류_Sheet1.Columns.Get(0).Width = 170.0!
        Me.Fps상병분류_Sheet1.Columns.Get(1).Label = "구분1"
        Me.Fps상병분류_Sheet1.Columns.Get(1).Visible = False
        Me.Fps상병분류_Sheet1.Columns.Get(2).Label = "구분2"
        Me.Fps상병분류_Sheet1.Columns.Get(2).Visible = False
        Me.Fps상병분류_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Fps상병분류_Sheet1.RowHeader.Visible = False
        Me.Fps상병분류_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel5.Controls.Add(Me.Fps상병검색)
        Me.Panel5.Location = New System.Drawing.Point(277, 72)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(359, 544)
        Me.Panel5.TabIndex = 3
        '
        'Fps상병검색
        '
        Me.Fps상병검색.AccessibleDescription = "FpSpread4, Sheet1, Row 0, Column 0, "
        Me.Fps상병검색.BackColor = System.Drawing.Color.SlateGray
        Me.Fps상병검색.Location = New System.Drawing.Point(3, 3)
        Me.Fps상병검색.Name = "Fps상병검색"
        Me.Fps상병검색.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Fps상병검색_Sheet1})
        Me.Fps상병검색.Size = New System.Drawing.Size(354, 539)
        Me.Fps상병검색.TabIndex = 66
        '
        'Fps상병검색_Sheet1
        '
        Me.Fps상병검색_Sheet1.Reset()
        Me.Fps상병검색_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Fps상병검색_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Fps상병검색_Sheet1.ColumnCount = 5
        Me.Fps상병검색_Sheet1.RowCount = 3
        Me.Fps상병검색_Sheet1.Cells.Get(0, 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.Fps상병검색_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Fps상병검색_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Fps상병검색_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.Fps상병검색_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Fps상병검색_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "선택"
        Me.Fps상병검색_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "상병기호"
        Me.Fps상병검색_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "KCD상병명"
        Me.Fps상병검색_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "특정기호"
        Me.Fps상병검색_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "상해외인"
        Me.Fps상병검색_Sheet1.ColumnHeader.Rows.Get(0).Height = 28.0!
        Me.Fps상병검색_Sheet1.Columns.Get(0).CellType = CheckBoxCellType1
        Me.Fps상병검색_Sheet1.Columns.Get(0).Label = "선택"
        Me.Fps상병검색_Sheet1.Columns.Get(0).Width = 19.0!
        Me.Fps상병검색_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps상병검색_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Fps상병검색_Sheet1.Columns.Get(1).Label = "상병기호"
        Me.Fps상병검색_Sheet1.Columns.Get(1).Width = 54.0!
        Me.Fps상병검색_Sheet1.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps상병검색_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.Fps상병검색_Sheet1.Columns.Get(2).Label = "KCD상병명"
        Me.Fps상병검색_Sheet1.Columns.Get(2).Width = 281.0!
        Me.Fps상병검색_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps상병검색_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps상병검색_Sheet1.Columns.Get(3).Label = "특정기호"
        Me.Fps상병검색_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps상병검색_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps상병검색_Sheet1.Columns.Get(4).Label = "상해외인"
        Me.Fps상병검색_Sheet1.Columns.Get(4).Width = 54.0!
        Me.Fps상병검색_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Fps상병검색_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Fps상병검색_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Fps상병검색_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Fps상병검색_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Fps상병검색_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Frm상병조회
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 619)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm상병조회"
        Me.Text = "상병조회"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Fps상병분류, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fps상병분류_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.Fps상병검색, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fps상병검색_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lb순번 As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Fps상병분류 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents Fps상병분류_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Fps상병검색 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents Fps상병검색_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Label17 As Label
    Friend WithEvents Btn검색 As Button
    Friend WithEvents txt상병명칭 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 내상병저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 내상병조회ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
End Class

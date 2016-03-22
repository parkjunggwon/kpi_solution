<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm약속처방등록
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("황련해독탕")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("개연교탕")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("한약제", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("침")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("검사")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("비급여")
        Dim ComboBoxCellType1 As FarPoint.Win.Spread.CellType.ComboBoxCellType = New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FpSpread2 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.FpSpread1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 268)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(130, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(644, 29)
        Me.Panel3.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(213, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 25)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "전체수가조회"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(68, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 21)
        Me.TextBox3.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(567, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "닫기"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "초기화"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.PeachPuff
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Location = New System.Drawing.Point(1, 1)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "노드3"
        TreeNode1.Text = "황련해독탕"
        TreeNode2.Name = "노드6"
        TreeNode2.Text = "개연교탕"
        TreeNode3.Name = "노드0"
        TreeNode3.Text = "한약제"
        TreeNode4.Name = "노드1"
        TreeNode4.Text = "침"
        TreeNode5.Name = "노드2"
        TreeNode5.Text = "검사"
        TreeNode6.Name = "노드4"
        TreeNode6.Text = "비급여"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.TreeView1.Size = New System.Drawing.Size(129, 266)
        Me.TreeView1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(1, 271)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(774, 29)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.FpSpread2)
        Me.Panel5.Location = New System.Drawing.Point(2, 302)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(774, 398)
        Me.Panel5.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "대분류"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(53, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 21)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(236, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(135, 21)
        Me.TextBox4.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "소분류"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(376, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 27)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "등록"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(707, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 27)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "항목삭제"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.FpSpread1_Sheet1.ColumnCount = 4
        Me.FpSpread1_Sheet1.RowCount = 2
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "병원코드"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "수가명칭"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "단위"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "함량"
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(0).Label = "병원코드"
        Me.FpSpread1_Sheet1.Columns.Get(0).Width = 81.0!
        Me.FpSpread1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(1).Label = "수가명칭"
        Me.FpSpread1_Sheet1.Columns.Get(1).Width = 347.0!
        Me.FpSpread1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
        Me.FpSpread1_Sheet1.Columns.Get(2).Label = "단위"
        Me.FpSpread1_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Justify
        Me.FpSpread1_Sheet1.Columns.Get(3).Label = "함량"
        Me.FpSpread1_Sheet1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.FpSpread1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.FpSpread1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.FpSpread1_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread1.Location = New System.Drawing.Point(130, 32)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(643, 232)
        Me.FpSpread1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "수가명칭"
        '
        'FpSpread2
        '
        Me.FpSpread2.AccessibleDescription = "FpSpread2, Sheet1, Row 0, Column 0, "
        Me.FpSpread2.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread2.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread2.Location = New System.Drawing.Point(1, 1)
        Me.FpSpread2.Name = "FpSpread2"
        Me.FpSpread2.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread2.Size = New System.Drawing.Size(770, 393)
        Me.FpSpread2.TabIndex = 65
        '
        'SheetView1
        '
        Me.SheetView1.Reset()
        Me.SheetView1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView1.ColumnCount = 18
        Me.SheetView1.RowCount = 3
        Me.SheetView1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnHeader.Cells.Get(0, 0).Value = "오더구분"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 1).Value = "오더명칭"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 2).Value = "급여구분"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 3).Value = "일투여량"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 4).Value = "투여일수"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 5).Value = "첩수"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 6).Value = "팩수"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 7).Value = "용법"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 8).Value = "청구메모"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 9).Value = "전송부서"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 10).Value = "의사명"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 11).Value = "가감코드"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 12).Value = "보험코드"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 13).Value = "병원코드"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 14).Value = "혈명코드"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 15).Value = "특정코드"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 16).Value = "특정내역"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 17).Value = "면허번호"
        Me.SheetView1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnHeader.Rows.Get(0).Height = 29.0!
        ComboBoxCellType1.AllowEditorVerticalAlign = True
        ComboBoxCellType1.ButtonAlign = FarPoint.Win.ButtonAlign.Right
        Me.SheetView1.Columns.Get(0).CellType = ComboBoxCellType1
        Me.SheetView1.Columns.Get(0).Label = "오더구분"
        Me.SheetView1.Columns.Get(1).Label = "오더명칭"
        Me.SheetView1.Columns.Get(1).Width = 290.0!
        Me.SheetView1.Columns.Get(2).Label = "급여구분"
        Me.SheetView1.Columns.Get(2).Width = 30.0!
        Me.SheetView1.Columns.Get(3).Label = "일투여량"
        Me.SheetView1.Columns.Get(3).Width = 56.0!
        Me.SheetView1.Columns.Get(4).Label = "투여일수"
        Me.SheetView1.Columns.Get(4).Width = 55.0!
        Me.SheetView1.Columns.Get(5).Label = "첩수"
        Me.SheetView1.Columns.Get(5).Width = 48.0!
        Me.SheetView1.Columns.Get(6).Label = "팩수"
        Me.SheetView1.Columns.Get(6).Width = 48.0!
        Me.SheetView1.Columns.Get(7).Label = "용법"
        Me.SheetView1.Columns.Get(7).Width = 149.0!
        Me.SheetView1.Columns.Get(8).Label = "청구메모"
        Me.SheetView1.Columns.Get(8).Width = 31.0!
        Me.SheetView1.Columns.Get(9).Label = "전송부서"
        Me.SheetView1.Columns.Get(9).Width = 32.0!
        Me.SheetView1.Columns.Get(10).Label = "의사명"
        Me.SheetView1.Columns.Get(10).Width = 49.0!
        Me.SheetView1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.RowHeader.Columns.Default.Resizable = False
        Me.SheetView1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'frm약속처방등록
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 701)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm약속처방등록"
        Me.Text = "약속코드 등록"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FpSpread2 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView1 As FarPoint.Win.Spread.SheetView
End Class

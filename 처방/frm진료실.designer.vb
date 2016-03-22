<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm진료실
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
        Dim CbB진찰구분 As System.Windows.Forms.ComboBox
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim CheckBoxCellType1 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim EmptyBorder1 As FarPoint.Win.EmptyBorder = New FarPoint.Win.EmptyBorder()
        Dim EmptyBorder2 As FarPoint.Win.EmptyBorder = New FarPoint.Win.EmptyBorder()
        Dim ButtonCellType1 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim EmptyBorder3 As FarPoint.Win.EmptyBorder = New FarPoint.Win.EmptyBorder()
        Dim ButtonCellType2 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim EmptyBorder4 As FarPoint.Win.EmptyBorder = New FarPoint.Win.EmptyBorder()
        Dim ButtonCellType3 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim EmptyBorder5 As FarPoint.Win.EmptyBorder = New FarPoint.Win.EmptyBorder()
        Dim ButtonCellType4 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim MultiColumnComboBoxCellType1 As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType()
        Dim CheckBoxCellType2 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim ComboBoxCellType1 As FarPoint.Win.Spread.CellType.ComboBoxCellType = New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Dim CheckBoxCellType3 As FarPoint.Win.Spread.CellType.CheckBoxCellType = New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        Dim ComboBoxCellType2 As FarPoint.Win.Spread.CellType.ComboBoxCellType = New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Dim ComboBoxCellType3 As FarPoint.Win.Spread.CellType.ComboBoxCellType = New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Fps환자리스트 = New FarPoint.Win.Spread.FpSpread()
        Me.Fps환자리스트_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Dtp진료일자 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Rdb전체 = New System.Windows.Forms.RadioButton()
        Me.Rdb진료완료 = New System.Windows.Forms.RadioButton()
        Me.Rdb치료실 = New System.Windows.Forms.RadioButton()
        Me.Rdb진료대기 = New System.Windows.Forms.RadioButton()
        Me.CbB의사리스트 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gb환자정보 = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Tb증상 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Tb최종내원일 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chk야간 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb접수메모 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb보험종별 = New System.Windows.Forms.TextBox()
        Me.Tb성별 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb나이 = New System.Windows.Forms.TextBox()
        Me.Tb성명 = New System.Windows.Forms.TextBox()
        Me.Tb챠트번호 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown11 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown12 = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.FpSpread6 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView5 = New FarPoint.Win.Spread.SheetView()
        Me.FpSpread3 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView2 = New FarPoint.Win.Spread.SheetView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.FpSpread7 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView6 = New FarPoint.Win.Spread.SheetView()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkGusul9 = New System.Windows.Forms.CheckBox()
        Me.chkGusul8 = New System.Windows.Forms.CheckBox()
        Me.chkGusul5 = New System.Windows.Forms.CheckBox()
        Me.chkGusul7 = New System.Windows.Forms.CheckBox()
        Me.chkGusul6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkGusul4 = New System.Windows.Forms.CheckBox()
        Me.chkGusul1 = New System.Windows.Forms.CheckBox()
        Me.chkGusul3 = New System.Windows.Forms.CheckBox()
        Me.chkGusul2 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.CheckBox35 = New System.Windows.Forms.CheckBox()
        Me.CheckBox34 = New System.Windows.Forms.CheckBox()
        Me.CheckBox33 = New System.Windows.Forms.CheckBox()
        Me.CheckBox32 = New System.Windows.Forms.CheckBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.CheckBox31 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox28 = New System.Windows.Forms.CheckBox()
        Me.CheckBox27 = New System.Windows.Forms.CheckBox()
        Me.CheckBox26 = New System.Windows.Forms.CheckBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.ChkToo1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.ChkChuk9 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk8 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk7 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk6 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk5 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk4 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk3 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk2 = New System.Windows.Forms.CheckBox()
        Me.ChkChuk1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ChkKwan19 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan18 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan17 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan16 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan15 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan14 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan12 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan11 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan10 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan9 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan8 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan7 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan6 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan5 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan4 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan3 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan2 = New System.Windows.Forms.CheckBox()
        Me.ChkKwan1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ChkBok8 = New System.Windows.Forms.CheckBox()
        Me.ChkBok7 = New System.Windows.Forms.CheckBox()
        Me.ChkBok6 = New System.Windows.Forms.CheckBox()
        Me.ChkBok5 = New System.Windows.Forms.CheckBox()
        Me.ChkBok4 = New System.Windows.Forms.CheckBox()
        Me.ChkBok3 = New System.Windows.Forms.CheckBox()
        Me.ChkBok2 = New System.Windows.Forms.CheckBox()
        Me.ChkBok1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ChkBi = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ChkAn2 = New System.Windows.Forms.CheckBox()
        Me.ChkAn1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.CheckBox49 = New System.Windows.Forms.CheckBox()
        Me.CheckBox48 = New System.Windows.Forms.CheckBox()
        Me.CheckBox47 = New System.Windows.Forms.CheckBox()
        Me.CheckBox46 = New System.Windows.Forms.CheckBox()
        Me.CheckBox45 = New System.Windows.Forms.CheckBox()
        Me.CheckBox44 = New System.Windows.Forms.CheckBox()
        Me.CheckBox43 = New System.Windows.Forms.CheckBox()
        Me.CheckBox42 = New System.Windows.Forms.CheckBox()
        Me.CheckBox37 = New System.Windows.Forms.CheckBox()
        Me.CheckBox40 = New System.Windows.Forms.CheckBox()
        Me.CheckBox41 = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.CheckBox36 = New System.Windows.Forms.CheckBox()
        Me.CheckBox38 = New System.Windows.Forms.CheckBox()
        Me.CheckBox39 = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.CheckBox75 = New System.Windows.Forms.CheckBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.CheckBox74 = New System.Windows.Forms.CheckBox()
        Me.CheckBox66 = New System.Windows.Forms.CheckBox()
        Me.CheckBox68 = New System.Windows.Forms.CheckBox()
        Me.CheckBox69 = New System.Windows.Forms.CheckBox()
        Me.CheckBox70 = New System.Windows.Forms.CheckBox()
        Me.CheckBox71 = New System.Windows.Forms.CheckBox()
        Me.CheckBox72 = New System.Windows.Forms.CheckBox()
        Me.CheckBox73 = New System.Windows.Forms.CheckBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.CheckBox77 = New System.Windows.Forms.CheckBox()
        Me.CheckBox64 = New System.Windows.Forms.CheckBox()
        Me.CheckBox58 = New System.Windows.Forms.CheckBox()
        Me.CheckBox59 = New System.Windows.Forms.CheckBox()
        Me.CheckBox60 = New System.Windows.Forms.CheckBox()
        Me.CheckBox61 = New System.Windows.Forms.CheckBox()
        Me.CheckBox62 = New System.Windows.Forms.CheckBox()
        Me.CheckBox63 = New System.Windows.Forms.CheckBox()
        Me.CheckBox65 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.CheckBox57 = New System.Windows.Forms.CheckBox()
        Me.CheckBox56 = New System.Windows.Forms.CheckBox()
        Me.CheckBox55 = New System.Windows.Forms.CheckBox()
        Me.CheckBox54 = New System.Windows.Forms.CheckBox()
        Me.CheckBox53 = New System.Windows.Forms.CheckBox()
        Me.CheckBox50 = New System.Windows.Forms.CheckBox()
        Me.CheckBox51 = New System.Windows.Forms.CheckBox()
        Me.CheckBox52 = New System.Windows.Forms.CheckBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.FpSpread8 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView7 = New FarPoint.Win.Spread.SheetView()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.FpSpread9 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView8 = New FarPoint.Win.Spread.SheetView()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FpSpread2 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnSin = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.FpSpread5 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView4 = New FarPoint.Win.Spread.SheetView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox79 = New System.Windows.Forms.CheckBox()
        Me.CheckBox78 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FpSpread4 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView3 = New FarPoint.Win.Spread.SheetView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.제증명ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.검사결과ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.상병조회ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CbB진찰구분 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Fps환자리스트, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fps환자리스트_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb환자정보.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FpSpread7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.FpSpread8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.FpSpread9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.FpSpread5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FpSpread4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbB진찰구분
        '
        CbB진찰구분.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        CbB진찰구분.FormattingEnabled = True
        CbB진찰구분.Location = New System.Drawing.Point(269, 73)
        CbB진찰구분.Name = "CbB진찰구분"
        CbB진찰구분.Size = New System.Drawing.Size(65, 20)
        CbB진찰구분.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Dtp진료일자)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Rdb전체)
        Me.GroupBox2.Controls.Add(Me.Rdb진료완료)
        Me.GroupBox2.Controls.Add(Me.Rdb치료실)
        Me.GroupBox2.Controls.Add(Me.Rdb진료대기)
        Me.GroupBox2.Controls.Add(Me.CbB의사리스트)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 212)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel6.Controls.Add(Me.Fps환자리스트)
        Me.Panel6.Location = New System.Drawing.Point(4, 56)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(392, 150)
        Me.Panel6.TabIndex = 63
        '
        'Fps환자리스트
        '
        Me.Fps환자리스트.AccessibleDescription = "Fps환자리스트, Sheet1, Row 0, Column 0, "
        Me.Fps환자리스트.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Fps환자리스트.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.Fps환자리스트.Location = New System.Drawing.Point(0, 1)
        Me.Fps환자리스트.Name = "Fps환자리스트"
        Me.Fps환자리스트.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Fps환자리스트_Sheet1})
        Me.Fps환자리스트.Size = New System.Drawing.Size(391, 145)
        Me.Fps환자리스트.TabIndex = 64
        '
        'Fps환자리스트_Sheet1
        '
        Me.Fps환자리스트_Sheet1.Reset()
        Me.Fps환자리스트_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Fps환자리스트_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Fps환자리스트_Sheet1.ColumnCount = 6
        Me.Fps환자리스트_Sheet1.RowCount = 3
        Me.Fps환자리스트_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Fps환자리스트_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Fps환자리스트_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.Fps환자리스트_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "성명"
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "챠트번호"
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "진료과"
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "성별"
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "나이"
        Me.Fps환자리스트_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "접수시간"
        Me.Fps환자리스트_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps환자리스트_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps환자리스트_Sheet1.Columns.Get(0).Label = "성명"
        Me.Fps환자리스트_Sheet1.Columns.Get(0).Width = 54.0!
        TextCellType1.AllowEditorVerticalAlign = True
        Me.Fps환자리스트_Sheet1.Columns.Get(1).CellType = TextCellType1
        Me.Fps환자리스트_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps환자리스트_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps환자리스트_Sheet1.Columns.Get(1).Label = "챠트번호"
        Me.Fps환자리스트_Sheet1.Columns.Get(1).Width = 69.0!
        Me.Fps환자리스트_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps환자리스트_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps환자리스트_Sheet1.Columns.Get(3).Label = "성별"
        Me.Fps환자리스트_Sheet1.Columns.Get(3).Width = 37.0!
        Me.Fps환자리스트_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps환자리스트_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps환자리스트_Sheet1.Columns.Get(4).Label = "나이"
        Me.Fps환자리스트_Sheet1.Columns.Get(4).Width = 39.0!
        Me.Fps환자리스트_Sheet1.Columns.Get(5).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Fps환자리스트_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.Fps환자리스트_Sheet1.Columns.Get(5).Label = "접수시간"
        Me.Fps환자리스트_Sheet1.Columns.Get(5).Width = 66.0!
        Me.Fps환자리스트_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Fps환자리스트_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Fps환자리스트_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Fps환자리스트_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Fps환자리스트_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Fps환자리스트_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Dtp진료일자
        '
        Me.Dtp진료일자.CustomFormat = ""
        Me.Dtp진료일자.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp진료일자.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Dtp진료일자.Location = New System.Drawing.Point(69, 12)
        Me.Dtp진료일자.Name = "Dtp진료일자"
        Me.Dtp진료일자.Size = New System.Drawing.Size(95, 21)
        Me.Dtp진료일자.TabIndex = 62
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "진료일자"
        '
        'Rdb전체
        '
        Me.Rdb전체.AutoSize = True
        Me.Rdb전체.Location = New System.Drawing.Point(208, 38)
        Me.Rdb전체.Name = "Rdb전체"
        Me.Rdb전체.Size = New System.Drawing.Size(47, 16)
        Me.Rdb전체.TabIndex = 10
        Me.Rdb전체.TabStop = True
        Me.Rdb전체.Text = "전체"
        Me.Rdb전체.UseVisualStyleBackColor = True
        '
        'Rdb진료완료
        '
        Me.Rdb진료완료.AutoSize = True
        Me.Rdb진료완료.Location = New System.Drawing.Point(135, 38)
        Me.Rdb진료완료.Name = "Rdb진료완료"
        Me.Rdb진료완료.Size = New System.Drawing.Size(71, 16)
        Me.Rdb진료완료.TabIndex = 9
        Me.Rdb진료완료.TabStop = True
        Me.Rdb진료완료.Text = "진료완료"
        Me.Rdb진료완료.UseVisualStyleBackColor = True
        '
        'Rdb치료실
        '
        Me.Rdb치료실.AutoSize = True
        Me.Rdb치료실.Location = New System.Drawing.Point(76, 38)
        Me.Rdb치료실.Name = "Rdb치료실"
        Me.Rdb치료실.Size = New System.Drawing.Size(59, 16)
        Me.Rdb치료실.TabIndex = 8
        Me.Rdb치료실.TabStop = True
        Me.Rdb치료실.Text = "치료실"
        Me.Rdb치료실.UseVisualStyleBackColor = True
        '
        'Rdb진료대기
        '
        Me.Rdb진료대기.AutoSize = True
        Me.Rdb진료대기.Checked = True
        Me.Rdb진료대기.Location = New System.Drawing.Point(6, 38)
        Me.Rdb진료대기.Name = "Rdb진료대기"
        Me.Rdb진료대기.Size = New System.Drawing.Size(71, 16)
        Me.Rdb진료대기.TabIndex = 7
        Me.Rdb진료대기.TabStop = True
        Me.Rdb진료대기.Text = "진료대기"
        Me.Rdb진료대기.UseVisualStyleBackColor = True
        '
        'CbB의사리스트
        '
        Me.CbB의사리스트.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbB의사리스트.FormattingEnabled = True
        Me.CbB의사리스트.Location = New System.Drawing.Point(289, 13)
        Me.CbB의사리스트.Name = "CbB의사리스트"
        Me.CbB의사리스트.Size = New System.Drawing.Size(102, 20)
        Me.CbB의사리스트.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "담당의사"
        '
        'Gb환자정보
        '
        Me.Gb환자정보.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Gb환자정보.Controls.Add(Me.Button20)
        Me.Gb환자정보.Controls.Add(Me.Button8)
        Me.Gb환자정보.Controls.Add(Me.Tb증상)
        Me.Gb환자정보.Controls.Add(Me.Label30)
        Me.Gb환자정보.Controls.Add(Me.Tb최종내원일)
        Me.Gb환자정보.Controls.Add(Me.Label7)
        Me.Gb환자정보.Controls.Add(Me.Chk야간)
        Me.Gb환자정보.Controls.Add(CbB진찰구분)
        Me.Gb환자정보.Controls.Add(Me.Label4)
        Me.Gb환자정보.Controls.Add(Me.Tb접수메모)
        Me.Gb환자정보.Controls.Add(Me.Label3)
        Me.Gb환자정보.Controls.Add(Me.Tb보험종별)
        Me.Gb환자정보.Controls.Add(Me.Tb성별)
        Me.Gb환자정보.Controls.Add(Me.Label2)
        Me.Gb환자정보.Controls.Add(Me.Tb나이)
        Me.Gb환자정보.Controls.Add(Me.Tb성명)
        Me.Gb환자정보.Controls.Add(Me.Tb챠트번호)
        Me.Gb환자정보.Controls.Add(Me.Label9)
        Me.Gb환자정보.Controls.Add(Me.GroupBox4)
        Me.Gb환자정보.Controls.Add(Me.Label14)
        Me.Gb환자정보.Controls.Add(Me.Label15)
        Me.Gb환자정보.Controls.Add(Me.Label16)
        Me.Gb환자정보.Location = New System.Drawing.Point(409, 36)
        Me.Gb환자정보.Name = "Gb환자정보"
        Me.Gb환자정보.Size = New System.Drawing.Size(343, 209)
        Me.Gb환자정보.TabIndex = 2
        Me.Gb환자정보.TabStop = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Pink
        Me.Button20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button20.Location = New System.Drawing.Point(66, 150)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(30, 26)
        Me.Button20.TabIndex = 48
        Me.Button20.Text = "::"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(33, 176)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(63, 26)
        Me.Button8.TabIndex = 47
        Me.Button8.Text = "증상저장"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Tb증상
        '
        Me.Tb증상.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb증상.Location = New System.Drawing.Point(109, 150)
        Me.Tb증상.Multiline = True
        Me.Tb증상.Name = "Tb증상"
        Me.Tb증상.Size = New System.Drawing.Size(222, 51)
        Me.Tb증상.TabIndex = 29
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(31, 158)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 12)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "증상"
        '
        'Tb최종내원일
        '
        Me.Tb최종내원일.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb최종내원일.Location = New System.Drawing.Point(109, 97)
        Me.Tb최종내원일.Name = "Tb최종내원일"
        Me.Tb최종내원일.Size = New System.Drawing.Size(158, 21)
        Me.Tb최종내원일.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "최종내원일"
        '
        'Chk야간
        '
        Me.Chk야간.AutoSize = True
        Me.Chk야간.ForeColor = System.Drawing.Color.Red
        Me.Chk야간.Location = New System.Drawing.Point(286, 98)
        Me.Chk야간.Name = "Chk야간"
        Me.Chk야간.Size = New System.Drawing.Size(48, 16)
        Me.Chk야간.TabIndex = 25
        Me.Chk야간.Tag = "야간에 진료분 낮에 입력할때만 체크"
        Me.Chk야간.Text = "야간"
        Me.Chk야간.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "진찰구분"
        '
        'Tb접수메모
        '
        Me.Tb접수메모.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb접수메모.Location = New System.Drawing.Point(109, 121)
        Me.Tb접수메모.Multiline = True
        Me.Tb접수메모.Name = "Tb접수메모"
        Me.Tb접수메모.Size = New System.Drawing.Size(222, 23)
        Me.Tb접수메모.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "접수메모"
        '
        'Tb보험종별
        '
        Me.Tb보험종별.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb보험종별.Location = New System.Drawing.Point(110, 71)
        Me.Tb보험종별.Name = "Tb보험종별"
        Me.Tb보험종별.Size = New System.Drawing.Size(56, 21)
        Me.Tb보험종별.TabIndex = 11
        '
        'Tb성별
        '
        Me.Tb성별.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb성별.Location = New System.Drawing.Point(268, 49)
        Me.Tb성별.Name = "Tb성별"
        Me.Tb성별.Size = New System.Drawing.Size(42, 21)
        Me.Tb성별.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "성 별"
        '
        'Tb나이
        '
        Me.Tb나이.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb나이.Location = New System.Drawing.Point(267, 24)
        Me.Tb나이.Name = "Tb나이"
        Me.Tb나이.Size = New System.Drawing.Size(43, 21)
        Me.Tb나이.TabIndex = 8
        '
        'Tb성명
        '
        Me.Tb성명.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb성명.Location = New System.Drawing.Point(109, 46)
        Me.Tb성명.Name = "Tb성명"
        Me.Tb성명.Size = New System.Drawing.Size(100, 21)
        Me.Tb성명.TabIndex = 7
        '
        'Tb챠트번호
        '
        Me.Tb챠트번호.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb챠트번호.Location = New System.Drawing.Point(109, 22)
        Me.Tb챠트번호.Name = "Tb챠트번호"
        Me.Tb챠트번호.Size = New System.Drawing.Size(100, 21)
        Me.Tb챠트번호.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "챠트번호"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(349, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 179)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "챠트번호"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "보험종별"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "나      이"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "성      명"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "보험종별"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(223, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 12)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "나 이"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "성      명"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox5.Controls.Add(Me.TabControl1)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 241)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(398, 674)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(388, 657)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.FpSpread6)
        Me.TabPage1.Controls.Add(Me.FpSpread3)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(380, 631)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "History"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel9.Controls.Add(Me.NumericUpDown9)
        Me.Panel9.Controls.Add(Me.NumericUpDown10)
        Me.Panel9.Controls.Add(Me.NumericUpDown11)
        Me.Panel9.Controls.Add(Me.NumericUpDown12)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.Label32)
        Me.Panel9.Controls.Add(Me.Label33)
        Me.Panel9.Controls.Add(Me.Label34)
        Me.Panel9.Location = New System.Drawing.Point(5, 131)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(310, 35)
        Me.Panel9.TabIndex = 67
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(266, 6)
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown9.TabIndex = 27
        '
        'NumericUpDown10
        '
        Me.NumericUpDown10.Location = New System.Drawing.Point(198, 6)
        Me.NumericUpDown10.Name = "NumericUpDown10"
        Me.NumericUpDown10.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown10.TabIndex = 26
        '
        'NumericUpDown11
        '
        Me.NumericUpDown11.Location = New System.Drawing.Point(131, 6)
        Me.NumericUpDown11.Name = "NumericUpDown11"
        Me.NumericUpDown11.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown11.TabIndex = 25
        '
        'NumericUpDown12
        '
        Me.NumericUpDown12.Location = New System.Drawing.Point(54, 7)
        Me.NumericUpDown12.Name = "NumericUpDown12"
        Me.NumericUpDown12.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown12.TabIndex = 24
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Maroon
        Me.Label31.Location = New System.Drawing.Point(243, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(17, 12)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "첩"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Green
        Me.Label32.Location = New System.Drawing.Point(177, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(17, 12)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "팩"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Magenta
        Me.Label33.Location = New System.Drawing.Point(99, 9)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 12)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "일수"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.Location = New System.Drawing.Point(1, 11)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 12)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "1일수량"
        '
        'FpSpread6
        '
        Me.FpSpread6.AccessibleDescription = "FpSpread6, Sheet1, Row 0, Column 0, "
        Me.FpSpread6.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread6.Location = New System.Drawing.Point(2, 166)
        Me.FpSpread6.Name = "FpSpread6"
        Me.FpSpread6.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView5})
        Me.FpSpread6.Size = New System.Drawing.Size(375, 466)
        Me.FpSpread6.TabIndex = 66
        '
        'SheetView5
        '
        Me.SheetView5.Reset()
        Me.SheetView5.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView5.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView5.ColumnCount = 13
        Me.SheetView5.RowCount = 3
        Me.SheetView5.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView5.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView5.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView5.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView5.ColumnHeader.Cells.Get(0, 0).Value = "S"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 1).Value = "오더명칭"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 2).Value = "급여"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 3).Value = "일투여량"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 4).Value = "총일수"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 5).Value = "팩"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 6).Value = "첩"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 7).Value = "용법"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 8).Value = "메모"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 9).Value = "혈명코드"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 10).Value = "구분코드"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 11).Value = "코드내역"
        Me.SheetView5.ColumnHeader.Cells.Get(0, 12).Value = "수가코드"
        Me.SheetView5.Columns.Get(0).CellType = CheckBoxCellType1
        Me.SheetView5.Columns.Get(0).Label = "S"
        Me.SheetView5.Columns.Get(0).Width = 18.0!
        Me.SheetView5.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView5.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView5.Columns.Get(1).Label = "오더명칭"
        Me.SheetView5.Columns.Get(1).Width = 195.0!
        Me.SheetView5.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView5.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView5.Columns.Get(2).Label = "급여"
        Me.SheetView5.Columns.Get(2).Visible = False
        Me.SheetView5.Columns.Get(2).Width = 37.0!
        Me.SheetView5.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView5.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView5.Columns.Get(3).Label = "일투여량"
        Me.SheetView5.Columns.Get(3).Width = 55.0!
        Me.SheetView5.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView5.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView5.Columns.Get(4).Label = "총일수"
        Me.SheetView5.Columns.Get(4).Width = 48.0!
        Me.SheetView5.Columns.Get(5).Label = "팩"
        Me.SheetView5.Columns.Get(5).Width = 45.0!
        Me.SheetView5.Columns.Get(6).Label = "첩"
        Me.SheetView5.Columns.Get(6).Width = 45.0!
        Me.SheetView5.Columns.Get(7).Label = "용법"
        Me.SheetView5.Columns.Get(7).Width = 188.0!
        Me.SheetView5.Columns.Get(8).Label = "메모"
        Me.SheetView5.Columns.Get(8).Width = 39.0!
        Me.SheetView5.Columns.Get(9).Label = "혈명코드"
        Me.SheetView5.Columns.Get(9).Visible = False
        Me.SheetView5.Columns.Get(10).Label = "구분코드"
        Me.SheetView5.Columns.Get(10).Visible = False
        Me.SheetView5.Columns.Get(11).Label = "코드내역"
        Me.SheetView5.Columns.Get(11).Visible = False
        Me.SheetView5.Columns.Get(12).Label = "수가코드"
        Me.SheetView5.Columns.Get(12).Visible = False
        Me.SheetView5.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView5.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView5.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView5.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView5.RowHeader.Columns.Default.Resizable = False
        Me.SheetView5.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'FpSpread3
        '
        Me.FpSpread3.AccessibleDescription = "FpSpread3, Sheet1, Row 0, Column 0, 2016-01-01"
        Me.FpSpread3.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread3.Location = New System.Drawing.Point(2, 6)
        Me.FpSpread3.Name = "FpSpread3"
        Me.FpSpread3.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView2})
        Me.FpSpread3.Size = New System.Drawing.Size(375, 124)
        Me.FpSpread3.TabIndex = 16
        '
        'SheetView2
        '
        Me.SheetView2.Reset()
        Me.SheetView2.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView2.ColumnCount = 6
        Me.SheetView2.RowCount = 5
        Me.SheetView2.Cells.Get(0, 0).ParseFormatString = "yyyy-MM-dd"
        Me.SheetView2.Cells.Get(0, 0).Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.SheetView2.Cells.Get(0, 2).BackColor = System.Drawing.Color.Pink
        Me.SheetView2.Cells.Get(0, 2).Border = EmptyBorder1
        Me.SheetView2.Cells.Get(2, 1).BackColor = System.Drawing.Color.White
        Me.SheetView2.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView2.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView2.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView2.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView2.ColumnHeader.Cells.Get(0, 0).Value = "진료일자"
        Me.SheetView2.ColumnHeader.Cells.Get(0, 1).Value = "진료과"
        Me.SheetView2.ColumnHeader.Cells.Get(0, 2).Value = "한약재"
        Me.SheetView2.ColumnHeader.Cells.Get(0, 3).Value = "침술"
        Me.SheetView2.ColumnHeader.Cells.Get(0, 4).Value = "검사"
        Me.SheetView2.ColumnHeader.Cells.Get(0, 5).Value = "기타"
        Me.SheetView2.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView2.Columns.Get(0).Label = "진료일자"
        Me.SheetView2.Columns.Get(0).Width = 64.0!
        Me.SheetView2.Columns.Get(1).Label = "진료과"
        Me.SheetView2.Columns.Get(1).Width = 58.0!
        Me.SheetView2.Columns.Get(2).BackColor = System.Drawing.Color.Pink
        Me.SheetView2.Columns.Get(2).Border = EmptyBorder2
        ButtonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SheetView2.Columns.Get(2).CellType = ButtonCellType1
        Me.SheetView2.Columns.Get(2).Label = "한약재"
        Me.SheetView2.Columns.Get(2).Locked = True
        Me.SheetView2.Columns.Get(2).Width = 49.0!
        Me.SheetView2.Columns.Get(3).BackColor = System.Drawing.Color.Pink
        Me.SheetView2.Columns.Get(3).Border = EmptyBorder3
        ButtonCellType2.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType2.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SheetView2.Columns.Get(3).CellType = ButtonCellType2
        Me.SheetView2.Columns.Get(3).Label = "침술"
        Me.SheetView2.Columns.Get(3).Locked = True
        Me.SheetView2.Columns.Get(3).Width = 49.0!
        Me.SheetView2.Columns.Get(4).BackColor = System.Drawing.Color.Pink
        Me.SheetView2.Columns.Get(4).Border = EmptyBorder4
        ButtonCellType3.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType3.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SheetView2.Columns.Get(4).CellType = ButtonCellType3
        Me.SheetView2.Columns.Get(4).Label = "검사"
        Me.SheetView2.Columns.Get(4).Locked = True
        Me.SheetView2.Columns.Get(4).Width = 49.0!
        Me.SheetView2.Columns.Get(5).BackColor = System.Drawing.Color.Pink
        Me.SheetView2.Columns.Get(5).Border = EmptyBorder5
        ButtonCellType4.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType4.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SheetView2.Columns.Get(5).CellType = ButtonCellType4
        Me.SheetView2.Columns.Get(5).Label = "기타"
        Me.SheetView2.Columns.Get(5).Locked = True
        Me.SheetView2.Columns.Get(5).Width = 49.0!
        Me.SheetView2.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView2.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView2.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView2.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView2.RowHeader.Columns.Default.Resizable = False
        Me.SheetView2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(317, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "적용"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.FpSpread7)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.TextBox11)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(380, 631)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "약속"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(208, 4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(48, 26)
        Me.Button13.TabIndex = 66
        Me.Button13.Text = "조회"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'FpSpread7
        '
        Me.FpSpread7.AccessibleDescription = "FpSpread7, Sheet1, Row 0, Column 0, "
        Me.FpSpread7.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread7.Location = New System.Drawing.Point(79, 33)
        Me.FpSpread7.Name = "FpSpread7"
        Me.FpSpread7.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView6})
        Me.FpSpread7.Size = New System.Drawing.Size(297, 594)
        Me.FpSpread7.TabIndex = 65
        Me.FpSpread7.SetViewportLeftColumn(0, 0, 1)
        '
        'SheetView6
        '
        Me.SheetView6.Reset()
        Me.SheetView6.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView6.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView6.ColumnCount = 13
        Me.SheetView6.RowCount = 3
        Me.SheetView6.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView6.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView6.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.ColumnHeader.Cells.Get(0, 0).Value = "오더구분"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 1).Value = "오더명칭"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 2).Value = "급여"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 3).Value = "일투여량"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 4).Value = "총일수"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 5).Value = "팩"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 6).Value = "첩"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 7).Value = "용법"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 8).Value = "메모"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 9).Value = "혈명코드"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 10).Value = "구분코드"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 11).Value = "코드내역"
        Me.SheetView6.ColumnHeader.Cells.Get(0, 12).Value = "수가코드"
        Me.SheetView6.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView6.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.ColumnHeader.Rows.Get(0).Height = 26.0!
        MultiColumnComboBoxCellType1.AllowEditorVerticalAlign = True
        MultiColumnComboBoxCellType1.ColumnEditName = Nothing
        MultiColumnComboBoxCellType1.DataColumnName = Nothing
        Me.SheetView6.Columns.Get(0).CellType = MultiColumnComboBoxCellType1
        Me.SheetView6.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView6.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView6.Columns.Get(0).Label = "오더구분"
        Me.SheetView6.Columns.Get(0).Visible = False
        Me.SheetView6.Columns.Get(0).Width = 65.0!
        Me.SheetView6.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView6.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView6.Columns.Get(1).Label = "오더명칭"
        Me.SheetView6.Columns.Get(1).Width = 148.0!
        Me.SheetView6.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView6.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView6.Columns.Get(2).Label = "급여"
        Me.SheetView6.Columns.Get(2).Visible = False
        Me.SheetView6.Columns.Get(2).Width = 37.0!
        Me.SheetView6.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView6.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView6.Columns.Get(3).Label = "일투여량"
        Me.SheetView6.Columns.Get(3).Width = 34.0!
        Me.SheetView6.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView6.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView6.Columns.Get(4).Label = "총일수"
        Me.SheetView6.Columns.Get(4).Width = 46.0!
        Me.SheetView6.Columns.Get(5).Label = "팩"
        Me.SheetView6.Columns.Get(5).Width = 45.0!
        Me.SheetView6.Columns.Get(6).Label = "첩"
        Me.SheetView6.Columns.Get(6).Width = 45.0!
        Me.SheetView6.Columns.Get(7).Label = "용법"
        Me.SheetView6.Columns.Get(7).Width = 188.0!
        Me.SheetView6.Columns.Get(8).Label = "메모"
        Me.SheetView6.Columns.Get(8).Width = 39.0!
        Me.SheetView6.Columns.Get(9).Label = "혈명코드"
        Me.SheetView6.Columns.Get(9).Visible = False
        Me.SheetView6.Columns.Get(10).Label = "구분코드"
        Me.SheetView6.Columns.Get(10).Visible = False
        Me.SheetView6.Columns.Get(11).Label = "코드내역"
        Me.SheetView6.Columns.Get(11).Visible = False
        Me.SheetView6.Columns.Get(12).Label = "수가코드"
        Me.SheetView6.Columns.Get(12).Visible = False
        Me.SheetView6.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView6.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView6.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView6.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.RowHeader.Columns.Default.Resizable = False
        Me.SheetView6.RowHeader.Columns.Get(0).Width = 27.0!
        Me.SheetView6.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView6.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView6.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView6.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView6.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView6.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(305, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 28)
        Me.Button12.TabIndex = 27
        Me.Button12.Text = "적용"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Location = New System.Drawing.Point(44, 6)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(162, 21)
        Me.TextBox11.TabIndex = 26
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 12)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = "명칭"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Items.AddRange(New Object() {"한약", "비급여", "침", "물리", "검사"})
        Me.ListBox1.Location = New System.Drawing.Point(5, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(72, 592)
        Me.ListBox1.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.GroupBox7)
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(380, 631)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "구/부항"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(285, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "적용"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkGusul9)
        Me.GroupBox7.Controls.Add(Me.chkGusul8)
        Me.GroupBox7.Controls.Add(Me.chkGusul5)
        Me.GroupBox7.Controls.Add(Me.chkGusul7)
        Me.GroupBox7.Controls.Add(Me.chkGusul6)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(27, 143)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(333, 129)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "부항술"
        '
        'chkGusul9
        '
        Me.chkGusul9.AutoSize = True
        Me.chkGusul9.ForeColor = System.Drawing.Color.Black
        Me.chkGusul9.Location = New System.Drawing.Point(57, 98)
        Me.chkGusul9.Name = "chkGusul9"
        Me.chkGusul9.Size = New System.Drawing.Size(118, 16)
        Me.chkGusul9.TabIndex = 12
        Me.chkGusul9.Tag = "40323"
        Me.chkGusul9.Text = "주관법(건식부항)"
        Me.chkGusul9.UseVisualStyleBackColor = True
        '
        'chkGusul8
        '
        Me.chkGusul8.AutoSize = True
        Me.chkGusul8.ForeColor = System.Drawing.Color.Black
        Me.chkGusul8.Location = New System.Drawing.Point(185, 65)
        Me.chkGusul8.Name = "chkGusul8"
        Me.chkGusul8.Size = New System.Drawing.Size(118, 16)
        Me.chkGusul8.TabIndex = 11
        Me.chkGusul8.Tag = "40322"
        Me.chkGusul8.Text = "섬관법(건식부항)"
        Me.chkGusul8.UseVisualStyleBackColor = True
        '
        'chkGusul5
        '
        Me.chkGusul5.AutoSize = True
        Me.chkGusul5.ForeColor = System.Drawing.Color.Black
        Me.chkGusul5.Location = New System.Drawing.Point(57, 30)
        Me.chkGusul5.Name = "chkGusul5"
        Me.chkGusul5.Size = New System.Drawing.Size(72, 16)
        Me.chkGusul5.TabIndex = 7
        Me.chkGusul5.Tag = "40312"
        Me.chkGusul5.Text = "자락관법"
        Me.chkGusul5.UseVisualStyleBackColor = True
        '
        'chkGusul7
        '
        Me.chkGusul7.AutoSize = True
        Me.chkGusul7.ForeColor = System.Drawing.Color.Black
        Me.chkGusul7.Location = New System.Drawing.Point(57, 65)
        Me.chkGusul7.Name = "chkGusul7"
        Me.chkGusul7.Size = New System.Drawing.Size(118, 16)
        Me.chkGusul7.TabIndex = 10
        Me.chkGusul7.Tag = "40321"
        Me.chkGusul7.Text = "유관법(건식부항)"
        Me.chkGusul7.UseVisualStyleBackColor = True
        '
        'chkGusul6
        '
        Me.chkGusul6.AutoSize = True
        Me.chkGusul6.ForeColor = System.Drawing.Color.Black
        Me.chkGusul6.Location = New System.Drawing.Point(185, 30)
        Me.chkGusul6.Name = "chkGusul6"
        Me.chkGusul6.Size = New System.Drawing.Size(130, 16)
        Me.chkGusul6.TabIndex = 8
        Me.chkGusul6.Tag = "40313"
        Me.chkGusul6.Text = "자락관법2부위 이상"
        Me.chkGusul6.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.chkGusul4)
        Me.GroupBox6.Controls.Add(Me.chkGusul1)
        Me.GroupBox6.Controls.Add(Me.chkGusul3)
        Me.GroupBox6.Controls.Add(Me.chkGusul2)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(27, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(333, 107)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "구술"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(33, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "구술 직접구"
        '
        'chkGusul4
        '
        Me.chkGusul4.AutoSize = True
        Me.chkGusul4.ForeColor = System.Drawing.Color.Black
        Me.chkGusul4.Location = New System.Drawing.Point(234, 65)
        Me.chkGusul4.Name = "chkGusul4"
        Me.chkGusul4.Size = New System.Drawing.Size(72, 16)
        Me.chkGusul4.TabIndex = 11
        Me.chkGusul4.Tag = "40307"
        Me.chkGusul4.Text = "기기구술"
        Me.chkGusul4.UseVisualStyleBackColor = True
        '
        'chkGusul1
        '
        Me.chkGusul1.AutoSize = True
        Me.chkGusul1.ForeColor = System.Drawing.Color.Black
        Me.chkGusul1.Location = New System.Drawing.Point(117, 30)
        Me.chkGusul1.Name = "chkGusul1"
        Me.chkGusul1.Size = New System.Drawing.Size(88, 16)
        Me.chkGusul1.TabIndex = 7
        Me.chkGusul1.Tag = "40304"
        Me.chkGusul1.Text = "직접 애주구"
        Me.chkGusul1.UseVisualStyleBackColor = True
        '
        'chkGusul3
        '
        Me.chkGusul3.AutoSize = True
        Me.chkGusul3.ForeColor = System.Drawing.Color.Black
        Me.chkGusul3.Location = New System.Drawing.Point(117, 65)
        Me.chkGusul3.Name = "chkGusul3"
        Me.chkGusul3.Size = New System.Drawing.Size(88, 16)
        Me.chkGusul3.TabIndex = 10
        Me.chkGusul3.Tag = "40306"
        Me.chkGusul3.Text = "간접 애주구"
        Me.chkGusul3.UseVisualStyleBackColor = True
        '
        'chkGusul2
        '
        Me.chkGusul2.AutoSize = True
        Me.chkGusul2.ForeColor = System.Drawing.Color.Black
        Me.chkGusul2.Location = New System.Drawing.Point(234, 30)
        Me.chkGusul2.Name = "chkGusul2"
        Me.chkGusul2.Size = New System.Drawing.Size(60, 16)
        Me.chkGusul2.TabIndex = 8
        Me.chkGusul2.Tag = "40305"
        Me.chkGusul2.Text = "반흔구"
        Me.chkGusul2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(33, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "구술 간접구"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.GroupBox13)
        Me.TabPage4.Controls.Add(Me.GroupBox14)
        Me.TabPage4.Controls.Add(Me.GroupBox12)
        Me.TabPage4.Controls.Add(Me.GroupBox11)
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox9)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(380, 631)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = " 침술"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.CheckBox35)
        Me.GroupBox13.Controls.Add(Me.CheckBox34)
        Me.GroupBox13.Controls.Add(Me.CheckBox33)
        Me.GroupBox13.Controls.Add(Me.CheckBox32)
        Me.GroupBox13.Location = New System.Drawing.Point(23, 528)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(354, 57)
        Me.GroupBox13.TabIndex = 31
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "기타"
        '
        'CheckBox35
        '
        Me.CheckBox35.AutoSize = True
        Me.CheckBox35.ForeColor = System.Drawing.Color.Black
        Me.CheckBox35.Location = New System.Drawing.Point(36, 34)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox35.TabIndex = 34
        Me.CheckBox35.Tag = "40120"
        Me.CheckBox35.Text = "분구침술"
        Me.CheckBox35.UseVisualStyleBackColor = True
        '
        'CheckBox34
        '
        Me.CheckBox34.AutoSize = True
        Me.CheckBox34.ForeColor = System.Drawing.Color.Black
        Me.CheckBox34.Location = New System.Drawing.Point(234, 15)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox34.TabIndex = 33
        Me.CheckBox34.Tag = "40100"
        Me.CheckBox34.Text = "레이져침술"
        Me.CheckBox34.UseVisualStyleBackColor = True
        '
        'CheckBox33
        '
        Me.CheckBox33.AutoSize = True
        Me.CheckBox33.ForeColor = System.Drawing.Color.Black
        Me.CheckBox33.Location = New System.Drawing.Point(138, 15)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox33.TabIndex = 32
        Me.CheckBox33.Tag = "40092"
        Me.CheckBox33.Text = "전자침술"
        Me.CheckBox33.UseVisualStyleBackColor = True
        '
        'CheckBox32
        '
        Me.CheckBox32.AutoSize = True
        Me.CheckBox32.ForeColor = System.Drawing.Color.Black
        Me.CheckBox32.Location = New System.Drawing.Point(36, 15)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox32.TabIndex = 31
        Me.CheckBox32.Tag = "40091"
        Me.CheckBox32.Text = "침전기자극술"
        Me.CheckBox32.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CheckBox31)
        Me.GroupBox14.Controls.Add(Me.CheckBox30)
        Me.GroupBox14.Controls.Add(Me.CheckBox29)
        Me.GroupBox14.Controls.Add(Me.CheckBox28)
        Me.GroupBox14.Controls.Add(Me.CheckBox27)
        Me.GroupBox14.Controls.Add(Me.CheckBox26)
        Me.GroupBox14.Controls.Add(Me.CheckBox25)
        Me.GroupBox14.Controls.Add(Me.CheckBox24)
        Me.GroupBox14.Controls.Add(Me.CheckBox23)
        Me.GroupBox14.Controls.Add(Me.CheckBox22)
        Me.GroupBox14.Controls.Add(Me.CheckBox21)
        Me.GroupBox14.Controls.Add(Me.CheckBox20)
        Me.GroupBox14.Controls.Add(Me.CheckBox19)
        Me.GroupBox14.Controls.Add(Me.CheckBox18)
        Me.GroupBox14.Controls.Add(Me.CheckBox17)
        Me.GroupBox14.Controls.Add(Me.CheckBox16)
        Me.GroupBox14.Controls.Add(Me.CheckBox15)
        Me.GroupBox14.Controls.Add(Me.CheckBox14)
        Me.GroupBox14.Controls.Add(Me.CheckBox13)
        Me.GroupBox14.Controls.Add(Me.CheckBox12)
        Me.GroupBox14.Controls.Add(Me.CheckBox11)
        Me.GroupBox14.Controls.Add(Me.CheckBox10)
        Me.GroupBox14.Controls.Add(Me.ChkToo1)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Fuchsia
        Me.GroupBox14.Location = New System.Drawing.Point(23, 327)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(354, 192)
        Me.GroupBox14.TabIndex = 23
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "투자법"
        '
        'CheckBox31
        '
        Me.CheckBox31.AutoSize = True
        Me.CheckBox31.ForeColor = System.Drawing.Color.Black
        Me.CheckBox31.Location = New System.Drawing.Point(36, 174)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox31.TabIndex = 30
        Me.CheckBox31.Tag = "40080TE002/TE004 "
        Me.CheckBox31.Text = "액문-양지"
        Me.CheckBox31.UseVisualStyleBackColor = True
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.ForeColor = System.Drawing.Color.Black
        Me.CheckBox30.Location = New System.Drawing.Point(240, 152)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox30.TabIndex = 29
        Me.CheckBox30.Tag = "40080LR007/LE201 "
        Me.CheckBox30.Text = "슬관-슬안"
        Me.CheckBox30.UseVisualStyleBackColor = True
        '
        'CheckBox29
        '
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.ForeColor = System.Drawing.Color.Black
        Me.CheckBox29.Location = New System.Drawing.Point(132, 152)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox29.TabIndex = 28
        Me.CheckBox29.Tag = "40080PC005/TE006"
        Me.CheckBox29.Text = "간사-지구"
        Me.CheckBox29.UseVisualStyleBackColor = True
        '
        'CheckBox28
        '
        Me.CheckBox28.AutoSize = True
        Me.CheckBox28.ForeColor = System.Drawing.Color.Black
        Me.CheckBox28.Location = New System.Drawing.Point(36, 152)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox28.TabIndex = 27
        Me.CheckBox28.Tag = "40080GB001/HN041 "
        Me.CheckBox28.Text = "동자료-어요"
        Me.CheckBox28.UseVisualStyleBackColor = True
        '
        'CheckBox27
        '
        Me.CheckBox27.AutoSize = True
        Me.CheckBox27.ForeColor = System.Drawing.Color.Black
        Me.CheckBox27.Location = New System.Drawing.Point(240, 130)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox27.TabIndex = 26
        Me.CheckBox27.Tag = "40080LI004/PC008 "
        Me.CheckBox27.Text = "합곡-노궁"
        Me.CheckBox27.UseVisualStyleBackColor = True
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.ForeColor = System.Drawing.Color.Black
        Me.CheckBox26.Location = New System.Drawing.Point(132, 130)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(102, 16)
        Me.CheckBox26.TabIndex = 25
        Me.CheckBox26.Tag = "40080GB034/SP009 "
        Me.CheckBox26.Text = "양릉천-음릉천"
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.ForeColor = System.Drawing.Color.Black
        Me.CheckBox25.Location = New System.Drawing.Point(36, 130)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox25.TabIndex = 24
        Me.CheckBox25.Tag = "40080GB020/GV016 "
        Me.CheckBox25.Text = "풍지-풍부"
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.ForeColor = System.Drawing.Color.Black
        Me.CheckBox24.Location = New System.Drawing.Point(240, 108)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox24.TabIndex = 23
        Me.CheckBox24.Tag = "40080LU007/LU009 "
        Me.CheckBox24.Text = "열결-태연"
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.ForeColor = System.Drawing.Color.Black
        Me.CheckBox23.Location = New System.Drawing.Point(132, 108)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox23.TabIndex = 22
        Me.CheckBox23.Tag = "40080TE023/GB008 "
        Me.CheckBox23.Text = "사죽공-솔곡"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.ForeColor = System.Drawing.Color.Black
        Me.CheckBox22.Location = New System.Drawing.Point(36, 108)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox22.TabIndex = 21
        Me.CheckBox22.Tag = "40080LI011/LU005 "
        Me.CheckBox22.Text = "곡지-척택"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.ForeColor = System.Drawing.Color.Black
        Me.CheckBox21.Location = New System.Drawing.Point(240, 86)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox21.TabIndex = 20
        Me.CheckBox21.Tag = "40080LI011/LI010 "
        Me.CheckBox21.Text = "곡지-수삼리"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.ForeColor = System.Drawing.Color.Black
        Me.CheckBox20.Location = New System.Drawing.Point(132, 86)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox20.TabIndex = 19
        Me.CheckBox20.Tag = "40080SI018/LI020 "
        Me.CheckBox20.Text = "관료-영향"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.ForeColor = System.Drawing.Color.Black
        Me.CheckBox19.Location = New System.Drawing.Point(36, 86)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox19.TabIndex = 18
        Me.CheckBox19.Tag = "40080HN001/BL002 "
        Me.CheckBox19.Text = "인당-찬죽"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.ForeColor = System.Drawing.Color.Black
        Me.CheckBox18.Location = New System.Drawing.Point(240, 64)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox18.TabIndex = 17
        Me.CheckBox18.Tag = "40080GB001/SI018  "
        Me.CheckBox18.Text = "동자료-관료"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.ForeColor = System.Drawing.Color.Black
        Me.CheckBox17.Location = New System.Drawing.Point(132, 64)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.Tag = "40080TE021/SI019 "
        Me.CheckBox17.Text = "이문-청궁"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.ForeColor = System.Drawing.Color.Black
        Me.CheckBox16.Location = New System.Drawing.Point(36, 64)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox16.TabIndex = 15
        Me.CheckBox16.Tag = "40080BL060/KI003 "
        Me.CheckBox16.Text = "곤륜-태계"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.ForeColor = System.Drawing.Color.Black
        Me.CheckBox15.Location = New System.Drawing.Point(240, 42)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox15.TabIndex = 14
        Me.CheckBox15.Tag = "40080TE014/HT001 "
        Me.CheckBox15.Text = "견료-극천"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.ForeColor = System.Drawing.Color.Black
        Me.CheckBox14.Location = New System.Drawing.Point(132, 42)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Tag = "40080LI004/SI003 "
        Me.CheckBox14.Text = "합곡-후계"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.ForeColor = System.Drawing.Color.Black
        Me.CheckBox13.Location = New System.Drawing.Point(36, 42)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.Tag = "40080SP006/GB039 "
        Me.CheckBox13.Text = "삼음교-현종"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.ForeColor = System.Drawing.Color.Black
        Me.CheckBox12.Location = New System.Drawing.Point(132, 174)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Tag = "40080PC006/TE005"
        Me.CheckBox12.Text = "내관-외관"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.ForeColor = System.Drawing.Color.Black
        Me.CheckBox11.Location = New System.Drawing.Point(240, 20)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Tag = "40080HN046/GB008 "
        Me.CheckBox11.Text = "태양-솔곡"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.ForeColor = System.Drawing.Color.Black
        Me.CheckBox10.Location = New System.Drawing.Point(132, 20)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(78, 16)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Tag = "40080ST004/ST002 "
        Me.CheckBox10.Text = "지창-사백"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'ChkToo1
        '
        Me.ChkToo1.AutoSize = True
        Me.ChkToo1.ForeColor = System.Drawing.Color.Black
        Me.ChkToo1.Location = New System.Drawing.Point(36, 20)
        Me.ChkToo1.Name = "ChkToo1"
        Me.ChkToo1.Size = New System.Drawing.Size(78, 16)
        Me.ChkToo1.TabIndex = 8
        Me.ChkToo1.Tag = "40080ST004/ST006 "
        Me.ChkToo1.Text = "지창-협거"
        Me.ChkToo1.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.ChkChuk9)
        Me.GroupBox12.Controls.Add(Me.ChkChuk8)
        Me.GroupBox12.Controls.Add(Me.ChkChuk7)
        Me.GroupBox12.Controls.Add(Me.ChkChuk6)
        Me.GroupBox12.Controls.Add(Me.ChkChuk5)
        Me.GroupBox12.Controls.Add(Me.ChkChuk4)
        Me.GroupBox12.Controls.Add(Me.ChkChuk3)
        Me.GroupBox12.Controls.Add(Me.ChkChuk2)
        Me.GroupBox12.Controls.Add(Me.ChkChuk1)
        Me.GroupBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox12.Location = New System.Drawing.Point(23, 261)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(354, 66)
        Me.GroupBox12.TabIndex = 21
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "척추간"
        '
        'ChkChuk9
        '
        Me.ChkChuk9.AutoSize = True
        Me.ChkChuk9.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk9.Location = New System.Drawing.Point(300, 42)
        Me.ChkChuk9.Name = "ChkChuk9"
        Me.ChkChuk9.Size = New System.Drawing.Size(60, 16)
        Me.ChkChuk9.TabIndex = 16
        Me.ChkChuk9.Text = "요양관"
        Me.ChkChuk9.UseVisualStyleBackColor = True
        '
        'ChkChuk8
        '
        Me.ChkChuk8.AutoSize = True
        Me.ChkChuk8.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk8.Location = New System.Drawing.Point(254, 42)
        Me.ChkChuk8.Name = "ChkChuk8"
        Me.ChkChuk8.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk8.TabIndex = 15
        Me.ChkChuk8.Text = "근축"
        Me.ChkChuk8.UseVisualStyleBackColor = True
        '
        'ChkChuk7
        '
        Me.ChkChuk7.AutoSize = True
        Me.ChkChuk7.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk7.Location = New System.Drawing.Point(189, 42)
        Me.ChkChuk7.Name = "ChkChuk7"
        Me.ChkChuk7.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk7.TabIndex = 14
        Me.ChkChuk7.Text = "지양"
        Me.ChkChuk7.UseVisualStyleBackColor = True
        '
        'ChkChuk6
        '
        Me.ChkChuk6.AutoSize = True
        Me.ChkChuk6.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk6.Location = New System.Drawing.Point(112, 42)
        Me.ChkChuk6.Name = "ChkChuk6"
        Me.ChkChuk6.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk6.TabIndex = 13
        Me.ChkChuk6.Text = "신도"
        Me.ChkChuk6.UseVisualStyleBackColor = True
        '
        'ChkChuk5
        '
        Me.ChkChuk5.AutoSize = True
        Me.ChkChuk5.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk5.Location = New System.Drawing.Point(36, 42)
        Me.ChkChuk5.Name = "ChkChuk5"
        Me.ChkChuk5.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk5.TabIndex = 12
        Me.ChkChuk5.Text = "신주"
        Me.ChkChuk5.UseVisualStyleBackColor = True
        '
        'ChkChuk4
        '
        Me.ChkChuk4.AutoSize = True
        Me.ChkChuk4.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk4.Location = New System.Drawing.Point(254, 21)
        Me.ChkChuk4.Name = "ChkChuk4"
        Me.ChkChuk4.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk4.TabIndex = 11
        Me.ChkChuk4.Text = "명문"
        Me.ChkChuk4.UseVisualStyleBackColor = True
        '
        'ChkChuk3
        '
        Me.ChkChuk3.AutoSize = True
        Me.ChkChuk3.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk3.Location = New System.Drawing.Point(189, 20)
        Me.ChkChuk3.Name = "ChkChuk3"
        Me.ChkChuk3.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk3.TabIndex = 10
        Me.ChkChuk3.Text = "척중"
        Me.ChkChuk3.UseVisualStyleBackColor = True
        '
        'ChkChuk2
        '
        Me.ChkChuk2.AutoSize = True
        Me.ChkChuk2.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk2.Location = New System.Drawing.Point(112, 20)
        Me.ChkChuk2.Name = "ChkChuk2"
        Me.ChkChuk2.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk2.TabIndex = 9
        Me.ChkChuk2.Text = "풍부"
        Me.ChkChuk2.UseVisualStyleBackColor = True
        '
        'ChkChuk1
        '
        Me.ChkChuk1.AutoSize = True
        Me.ChkChuk1.ForeColor = System.Drawing.Color.Black
        Me.ChkChuk1.Location = New System.Drawing.Point(36, 20)
        Me.ChkChuk1.Name = "ChkChuk1"
        Me.ChkChuk1.Size = New System.Drawing.Size(48, 16)
        Me.ChkChuk1.TabIndex = 8
        Me.ChkChuk1.Text = "대추"
        Me.ChkChuk1.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.ChkKwan19)
        Me.GroupBox11.Controls.Add(Me.ChkKwan18)
        Me.GroupBox11.Controls.Add(Me.ChkKwan17)
        Me.GroupBox11.Controls.Add(Me.ChkKwan16)
        Me.GroupBox11.Controls.Add(Me.ChkKwan15)
        Me.GroupBox11.Controls.Add(Me.ChkKwan14)
        Me.GroupBox11.Controls.Add(Me.ChkKwan12)
        Me.GroupBox11.Controls.Add(Me.ChkKwan11)
        Me.GroupBox11.Controls.Add(Me.ChkKwan10)
        Me.GroupBox11.Controls.Add(Me.ChkKwan9)
        Me.GroupBox11.Controls.Add(Me.ChkKwan8)
        Me.GroupBox11.Controls.Add(Me.ChkKwan7)
        Me.GroupBox11.Controls.Add(Me.ChkKwan6)
        Me.GroupBox11.Controls.Add(Me.ChkKwan5)
        Me.GroupBox11.Controls.Add(Me.ChkKwan4)
        Me.GroupBox11.Controls.Add(Me.ChkKwan3)
        Me.GroupBox11.Controls.Add(Me.ChkKwan2)
        Me.GroupBox11.Controls.Add(Me.ChkKwan1)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Fuchsia
        Me.GroupBox11.Location = New System.Drawing.Point(23, 128)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(354, 127)
        Me.GroupBox11.TabIndex = 20
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "관절내"
        '
        'ChkKwan19
        '
        Me.ChkKwan19.AutoSize = True
        Me.ChkKwan19.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan19.Location = New System.Drawing.Point(189, 108)
        Me.ChkKwan19.Name = "ChkKwan19"
        Me.ChkKwan19.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan19.TabIndex = 26
        Me.ChkKwan19.Tag = "40060LE202 "
        Me.ChkKwan19.Text = "슬안(슬부)"
        Me.ChkKwan19.UseVisualStyleBackColor = True
        '
        'ChkKwan18
        '
        Me.ChkKwan18.AutoSize = True
        Me.ChkKwan18.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan18.Location = New System.Drawing.Point(112, 108)
        Me.ChkKwan18.Name = "ChkKwan18"
        Me.ChkKwan18.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan18.TabIndex = 25
        Me.ChkKwan18.Tag = "40060ST035 "
        Me.ChkKwan18.Text = "독비"
        Me.ChkKwan18.UseVisualStyleBackColor = True
        '
        'ChkKwan17
        '
        Me.ChkKwan17.AutoSize = True
        Me.ChkKwan17.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan17.Location = New System.Drawing.Point(36, 108)
        Me.ChkKwan17.Name = "ChkKwan17"
        Me.ChkKwan17.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan17.TabIndex = 24
        Me.ChkKwan17.Tag = "40060GB030 "
        Me.ChkKwan17.Text = "환도(고부)"
        Me.ChkKwan17.UseVisualStyleBackColor = True
        '
        'ChkKwan16
        '
        Me.ChkKwan16.AutoSize = True
        Me.ChkKwan16.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan16.Location = New System.Drawing.Point(189, 86)
        Me.ChkKwan16.Name = "ChkKwan16"
        Me.ChkKwan16.Size = New System.Drawing.Size(94, 16)
        Me.ChkKwan16.TabIndex = 23
        Me.ChkKwan16.Tag = "40060ST007 "
        Me.ChkKwan16.Text = "하관(악관절)"
        Me.ChkKwan16.UseVisualStyleBackColor = True
        '
        'ChkKwan15
        '
        Me.ChkKwan15.AutoSize = True
        Me.ChkKwan15.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan15.Location = New System.Drawing.Point(112, 86)
        Me.ChkKwan15.Name = "ChkKwan15"
        Me.ChkKwan15.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan15.TabIndex = 22
        Me.ChkKwan15.Tag = "40060GB003 "
        Me.ChkKwan15.Text = "상관"
        Me.ChkKwan15.UseVisualStyleBackColor = True
        '
        'ChkKwan14
        '
        Me.ChkKwan14.AutoSize = True
        Me.ChkKwan14.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan14.Location = New System.Drawing.Point(36, 86)
        Me.ChkKwan14.Name = "ChkKwan14"
        Me.ChkKwan14.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan14.TabIndex = 21
        Me.ChkKwan14.Tag = "40060LI017 "
        Me.ChkKwan14.Text = "천정(주부)"
        Me.ChkKwan14.UseVisualStyleBackColor = True
        '
        'ChkKwan12
        '
        Me.ChkKwan12.AutoSize = True
        Me.ChkKwan12.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan12.Location = New System.Drawing.Point(254, 64)
        Me.ChkKwan12.Name = "ChkKwan12"
        Me.ChkKwan12.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan12.TabIndex = 19
        Me.ChkKwan12.Tag = "40060LI011 "
        Me.ChkKwan12.Text = "곡지"
        Me.ChkKwan12.UseVisualStyleBackColor = True
        '
        'ChkKwan11
        '
        Me.ChkKwan11.AutoSize = True
        Me.ChkKwan11.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan11.Location = New System.Drawing.Point(189, 64)
        Me.ChkKwan11.Name = "ChkKwan11"
        Me.ChkKwan11.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan11.TabIndex = 18
        Me.ChkKwan11.Tag = "40060SI008 "
        Me.ChkKwan11.Text = "소해"
        Me.ChkKwan11.UseVisualStyleBackColor = True
        '
        'ChkKwan10
        '
        Me.ChkKwan10.AutoSize = True
        Me.ChkKwan10.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan10.Location = New System.Drawing.Point(112, 64)
        Me.ChkKwan10.Name = "ChkKwan10"
        Me.ChkKwan10.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan10.TabIndex = 17
        Me.ChkKwan10.Tag = "40060LR004 "
        Me.ChkKwan10.Text = "중봉(족구)"
        Me.ChkKwan10.UseVisualStyleBackColor = True
        '
        'ChkKwan9
        '
        Me.ChkKwan9.AutoSize = True
        Me.ChkKwan9.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan9.Location = New System.Drawing.Point(36, 64)
        Me.ChkKwan9.Name = "ChkKwan9"
        Me.ChkKwan9.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan9.TabIndex = 16
        Me.ChkKwan9.Tag = "40060KI006 "
        Me.ChkKwan9.Text = "조해"
        Me.ChkKwan9.UseVisualStyleBackColor = True
        '
        'ChkKwan8
        '
        Me.ChkKwan8.AutoSize = True
        Me.ChkKwan8.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan8.Location = New System.Drawing.Point(254, 42)
        Me.ChkKwan8.Name = "ChkKwan8"
        Me.ChkKwan8.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan8.TabIndex = 15
        Me.ChkKwan8.Tag = "40060BL062 "
        Me.ChkKwan8.Text = "신맥"
        Me.ChkKwan8.UseVisualStyleBackColor = True
        '
        'ChkKwan7
        '
        Me.ChkKwan7.AutoSize = True
        Me.ChkKwan7.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan7.Location = New System.Drawing.Point(189, 42)
        Me.ChkKwan7.Name = "ChkKwan7"
        Me.ChkKwan7.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan7.TabIndex = 14
        Me.ChkKwan7.Tag = "40060GB040 "
        Me.ChkKwan7.Text = "구허"
        Me.ChkKwan7.UseVisualStyleBackColor = True
        '
        'ChkKwan6
        '
        Me.ChkKwan6.AutoSize = True
        Me.ChkKwan6.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan6.Location = New System.Drawing.Point(112, 42)
        Me.ChkKwan6.Name = "ChkKwan6"
        Me.ChkKwan6.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan6.TabIndex = 13
        Me.ChkKwan6.Tag = "40060PC007 "
        Me.ChkKwan6.Text = "대릉(수부)"
        Me.ChkKwan6.UseVisualStyleBackColor = True
        '
        'ChkKwan5
        '
        Me.ChkKwan5.AutoSize = True
        Me.ChkKwan5.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan5.Location = New System.Drawing.Point(36, 42)
        Me.ChkKwan5.Name = "ChkKwan5"
        Me.ChkKwan5.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan5.TabIndex = 12
        Me.ChkKwan5.Tag = "40060SI005 "
        Me.ChkKwan5.Text = "양곡"
        Me.ChkKwan5.UseVisualStyleBackColor = True
        '
        'ChkKwan4
        '
        Me.ChkKwan4.AutoSize = True
        Me.ChkKwan4.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan4.Location = New System.Drawing.Point(254, 20)
        Me.ChkKwan4.Name = "ChkKwan4"
        Me.ChkKwan4.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan4.TabIndex = 11
        Me.ChkKwan4.Tag = "40060TE004 "
        Me.ChkKwan4.Text = "양지"
        Me.ChkKwan4.UseVisualStyleBackColor = True
        '
        'ChkKwan3
        '
        Me.ChkKwan3.AutoSize = True
        Me.ChkKwan3.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan3.Location = New System.Drawing.Point(189, 20)
        Me.ChkKwan3.Name = "ChkKwan3"
        Me.ChkKwan3.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan3.TabIndex = 10
        Me.ChkKwan3.Tag = "40060LI005 "
        Me.ChkKwan3.Text = "양계"
        Me.ChkKwan3.UseVisualStyleBackColor = True
        '
        'ChkKwan2
        '
        Me.ChkKwan2.AutoSize = True
        Me.ChkKwan2.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan2.Location = New System.Drawing.Point(112, 20)
        Me.ChkKwan2.Name = "ChkKwan2"
        Me.ChkKwan2.Size = New System.Drawing.Size(82, 16)
        Me.ChkKwan2.TabIndex = 9
        Me.ChkKwan2.Tag = "40060SI010 "
        Me.ChkKwan2.Text = "노수(견부)"
        Me.ChkKwan2.UseVisualStyleBackColor = True
        '
        'ChkKwan1
        '
        Me.ChkKwan1.AutoSize = True
        Me.ChkKwan1.ForeColor = System.Drawing.Color.Black
        Me.ChkKwan1.Location = New System.Drawing.Point(36, 20)
        Me.ChkKwan1.Name = "ChkKwan1"
        Me.ChkKwan1.Size = New System.Drawing.Size(48, 16)
        Me.ChkKwan1.TabIndex = 8
        Me.ChkKwan1.Tag = "40060LI015 "
        Me.ChkKwan1.Text = "견우"
        Me.ChkKwan1.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ChkBok8)
        Me.GroupBox10.Controls.Add(Me.ChkBok7)
        Me.GroupBox10.Controls.Add(Me.ChkBok6)
        Me.GroupBox10.Controls.Add(Me.ChkBok5)
        Me.GroupBox10.Controls.Add(Me.ChkBok4)
        Me.GroupBox10.Controls.Add(Me.ChkBok3)
        Me.GroupBox10.Controls.Add(Me.ChkBok2)
        Me.GroupBox10.Controls.Add(Me.ChkBok1)
        Me.GroupBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox10.Location = New System.Drawing.Point(23, 56)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(354, 66)
        Me.GroupBox10.TabIndex = 19
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "복강내"
        '
        'ChkBok8
        '
        Me.ChkBok8.AutoSize = True
        Me.ChkBok8.ForeColor = System.Drawing.Color.Black
        Me.ChkBok8.Location = New System.Drawing.Point(254, 42)
        Me.ChkBok8.Name = "ChkBok8"
        Me.ChkBok8.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok8.TabIndex = 15
        Me.ChkBok8.Tag = "40050SP015 "
        Me.ChkBok8.Text = "대횡"
        Me.ChkBok8.UseVisualStyleBackColor = True
        '
        'ChkBok7
        '
        Me.ChkBok7.AutoSize = True
        Me.ChkBok7.ForeColor = System.Drawing.Color.Black
        Me.ChkBok7.Location = New System.Drawing.Point(189, 42)
        Me.ChkBok7.Name = "ChkBok7"
        Me.ChkBok7.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok7.TabIndex = 14
        Me.ChkBok7.Tag = "40050ST025 "
        Me.ChkBok7.Text = "천추"
        Me.ChkBok7.UseVisualStyleBackColor = True
        '
        'ChkBok6
        '
        Me.ChkBok6.AutoSize = True
        Me.ChkBok6.ForeColor = System.Drawing.Color.Black
        Me.ChkBok6.Location = New System.Drawing.Point(112, 42)
        Me.ChkBok6.Name = "ChkBok6"
        Me.ChkBok6.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok6.TabIndex = 13
        Me.ChkBok6.Tag = "40050CV003 "
        Me.ChkBok6.Text = "중극"
        Me.ChkBok6.UseVisualStyleBackColor = True
        '
        'ChkBok5
        '
        Me.ChkBok5.AutoSize = True
        Me.ChkBok5.ForeColor = System.Drawing.Color.Black
        Me.ChkBok5.Location = New System.Drawing.Point(36, 42)
        Me.ChkBok5.Name = "ChkBok5"
        Me.ChkBok5.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok5.TabIndex = 12
        Me.ChkBok5.Tag = "40050CV004 "
        Me.ChkBok5.Text = "관원"
        Me.ChkBok5.UseVisualStyleBackColor = True
        '
        'ChkBok4
        '
        Me.ChkBok4.AutoSize = True
        Me.ChkBok4.ForeColor = System.Drawing.Color.Black
        Me.ChkBok4.Location = New System.Drawing.Point(254, 21)
        Me.ChkBok4.Name = "ChkBok4"
        Me.ChkBok4.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok4.TabIndex = 11
        Me.ChkBok4.Tag = "40050CV006 "
        Me.ChkBok4.Text = "기해"
        Me.ChkBok4.UseVisualStyleBackColor = True
        '
        'ChkBok3
        '
        Me.ChkBok3.AutoSize = True
        Me.ChkBok3.ForeColor = System.Drawing.Color.Black
        Me.ChkBok3.Location = New System.Drawing.Point(189, 20)
        Me.ChkBok3.Name = "ChkBok3"
        Me.ChkBok3.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok3.TabIndex = 10
        Me.ChkBok3.Tag = "40050CV010 "
        Me.ChkBok3.Text = "하완"
        Me.ChkBok3.UseVisualStyleBackColor = True
        '
        'ChkBok2
        '
        Me.ChkBok2.AutoSize = True
        Me.ChkBok2.ForeColor = System.Drawing.Color.Black
        Me.ChkBok2.Location = New System.Drawing.Point(112, 20)
        Me.ChkBok2.Name = "ChkBok2"
        Me.ChkBok2.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok2.TabIndex = 9
        Me.ChkBok2.Tag = "40050CV012 "
        Me.ChkBok2.Text = "중완"
        Me.ChkBok2.UseVisualStyleBackColor = True
        '
        'ChkBok1
        '
        Me.ChkBok1.AutoSize = True
        Me.ChkBok1.ForeColor = System.Drawing.Color.Black
        Me.ChkBok1.Location = New System.Drawing.Point(36, 20)
        Me.ChkBok1.Name = "ChkBok1"
        Me.ChkBok1.Size = New System.Drawing.Size(48, 16)
        Me.ChkBok1.TabIndex = 8
        Me.ChkBok1.Tag = "40050CV013 "
        Me.ChkBok1.Text = "상완"
        Me.ChkBok1.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ChkBi)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Fuchsia
        Me.GroupBox8.Location = New System.Drawing.Point(182, 7)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(112, 43)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "비강내"
        '
        'ChkBi
        '
        Me.ChkBi.AutoSize = True
        Me.ChkBi.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkBi.ForeColor = System.Drawing.Color.Black
        Me.ChkBi.Location = New System.Drawing.Point(36, 20)
        Me.ChkBi.Name = "ChkBi"
        Me.ChkBi.Size = New System.Drawing.Size(60, 16)
        Me.ChkBi.TabIndex = 8
        Me.ChkBi.Tag = "40040HN160 "
        Me.ChkBi.Text = "내영향"
        Me.ChkBi.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ChkAn2)
        Me.GroupBox9.Controls.Add(Me.ChkAn1)
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(23, 7)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(153, 43)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "안와내"
        '
        'ChkAn2
        '
        Me.ChkAn2.AutoSize = True
        Me.ChkAn2.ForeColor = System.Drawing.Color.Black
        Me.ChkAn2.Location = New System.Drawing.Point(94, 20)
        Me.ChkAn2.Name = "ChkAn2"
        Me.ChkAn2.Size = New System.Drawing.Size(48, 16)
        Me.ChkAn2.TabIndex = 9
        Me.ChkAn2.Tag = "40030ST001 "
        Me.ChkAn2.Text = "승읍"
        Me.ChkAn2.UseVisualStyleBackColor = True
        '
        'ChkAn1
        '
        Me.ChkAn1.AutoSize = True
        Me.ChkAn1.ForeColor = System.Drawing.Color.Black
        Me.ChkAn1.Location = New System.Drawing.Point(36, 20)
        Me.ChkAn1.Name = "ChkAn1"
        Me.ChkAn1.Size = New System.Drawing.Size(48, 16)
        Me.ChkAn1.TabIndex = 8
        Me.ChkAn1.Tag = "40030BL001 "
        Me.ChkAn1.Text = "정명"
        Me.ChkAn1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(296, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 28)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "적용"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.GroupBox16)
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.GroupBox15)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(380, 631)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "물리/처치"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.CheckBox49)
        Me.GroupBox16.Controls.Add(Me.CheckBox48)
        Me.GroupBox16.Controls.Add(Me.CheckBox47)
        Me.GroupBox16.Controls.Add(Me.CheckBox46)
        Me.GroupBox16.Controls.Add(Me.CheckBox45)
        Me.GroupBox16.Controls.Add(Me.CheckBox44)
        Me.GroupBox16.Controls.Add(Me.CheckBox43)
        Me.GroupBox16.Controls.Add(Me.CheckBox42)
        Me.GroupBox16.Controls.Add(Me.CheckBox37)
        Me.GroupBox16.Controls.Add(Me.CheckBox40)
        Me.GroupBox16.Controls.Add(Me.CheckBox41)
        Me.GroupBox16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox16.Location = New System.Drawing.Point(21, 149)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(354, 356)
        Me.GroupBox16.TabIndex = 34
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "처치"
        '
        'CheckBox49
        '
        Me.CheckBox49.AutoSize = True
        Me.CheckBox49.ForeColor = System.Drawing.Color.Black
        Me.CheckBox49.Location = New System.Drawing.Point(79, 185)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox49.TabIndex = 42
        Me.CheckBox49.Tag = "45590"
        Me.CheckBox49.Text = "비위관삽관술"
        Me.CheckBox49.UseVisualStyleBackColor = True
        '
        'CheckBox48
        '
        Me.CheckBox48.AutoSize = True
        Me.CheckBox48.ForeColor = System.Drawing.Color.Black
        Me.CheckBox48.Location = New System.Drawing.Point(79, 163)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.Size = New System.Drawing.Size(114, 16)
        Me.CheckBox48.TabIndex = 41
        Me.CheckBox48.Tag = "45580"
        Me.CheckBox48.Text = "산소흡입[1일당]"
        Me.CheckBox48.UseVisualStyleBackColor = True
        '
        'CheckBox47
        '
        Me.CheckBox47.AutoSize = True
        Me.CheckBox47.ForeColor = System.Drawing.Color.Black
        Me.CheckBox47.Location = New System.Drawing.Point(79, 141)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(138, 16)
        Me.CheckBox47.TabIndex = 40
        Me.CheckBox47.Tag = "45572"
        Me.CheckBox47.Text = "일반처치-염증성처치"
        Me.CheckBox47.UseVisualStyleBackColor = True
        '
        'CheckBox46
        '
        Me.CheckBox46.AutoSize = True
        Me.CheckBox46.ForeColor = System.Drawing.Color.Black
        Me.CheckBox46.Location = New System.Drawing.Point(79, 119)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox46.TabIndex = 39
        Me.CheckBox46.Tag = "45560"
        Me.CheckBox46.Text = "첩대총관도수법"
        Me.CheckBox46.UseVisualStyleBackColor = True
        '
        'CheckBox45
        '
        Me.CheckBox45.AutoSize = True
        Me.CheckBox45.ForeColor = System.Drawing.Color.Black
        Me.CheckBox45.Location = New System.Drawing.Point(79, 97)
        Me.CheckBox45.Name = "CheckBox45"
        Me.CheckBox45.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox45.TabIndex = 38
        Me.CheckBox45.Tag = "45550"
        Me.CheckBox45.Text = "총관도수법"
        Me.CheckBox45.UseVisualStyleBackColor = True
        '
        'CheckBox44
        '
        Me.CheckBox44.AutoSize = True
        Me.CheckBox44.ForeColor = System.Drawing.Color.Black
        Me.CheckBox44.Location = New System.Drawing.Point(77, 263)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(130, 16)
        Me.CheckBox44.TabIndex = 37
        Me.CheckBox44.Tag = "45540"
        Me.CheckBox44.Text = "통목욕 간호[1일당]"
        Me.CheckBox44.UseVisualStyleBackColor = True
        '
        'CheckBox43
        '
        Me.CheckBox43.AutoSize = True
        Me.CheckBox43.ForeColor = System.Drawing.Color.Black
        Me.CheckBox43.Location = New System.Drawing.Point(77, 241)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(142, 16)
        Me.CheckBox43.TabIndex = 36
        Me.CheckBox43.Tag = "45530"
        Me.CheckBox43.Text = "침상목욕 간호[1일당]"
        Me.CheckBox43.UseVisualStyleBackColor = True
        '
        'CheckBox42
        '
        Me.CheckBox42.AutoSize = True
        Me.CheckBox42.ForeColor = System.Drawing.Color.Black
        Me.CheckBox42.Location = New System.Drawing.Point(77, 219)
        Me.CheckBox42.Name = "CheckBox42"
        Me.CheckBox42.Size = New System.Drawing.Size(130, 16)
        Me.CheckBox42.TabIndex = 35
        Me.CheckBox42.Tag = "45520"
        Me.CheckBox42.Text = "회음부 간호[1일당]"
        Me.CheckBox42.UseVisualStyleBackColor = True
        '
        'CheckBox37
        '
        Me.CheckBox37.AutoSize = True
        Me.CheckBox37.ForeColor = System.Drawing.Color.Black
        Me.CheckBox37.Location = New System.Drawing.Point(79, 74)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(138, 16)
        Me.CheckBox37.TabIndex = 34
        Me.CheckBox37.Tag = "45510"
        Me.CheckBox37.Text = "체위변경처치[1일당]"
        Me.CheckBox37.UseVisualStyleBackColor = True
        '
        'CheckBox40
        '
        Me.CheckBox40.AutoSize = True
        Me.CheckBox40.ForeColor = System.Drawing.Color.Black
        Me.CheckBox40.Location = New System.Drawing.Point(79, 52)
        Me.CheckBox40.Name = "CheckBox40"
        Me.CheckBox40.Size = New System.Drawing.Size(106, 16)
        Me.CheckBox40.TabIndex = 32
        Me.CheckBox40.Tag = "45502"
        Me.CheckBox40.Text = "관장(수기관장)"
        Me.CheckBox40.UseVisualStyleBackColor = True
        '
        'CheckBox41
        '
        Me.CheckBox41.AutoSize = True
        Me.CheckBox41.ForeColor = System.Drawing.Color.Black
        Me.CheckBox41.Location = New System.Drawing.Point(79, 30)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.Size = New System.Drawing.Size(162, 16)
        Me.CheckBox41.TabIndex = 31
        Me.CheckBox41.Tag = "45501"
        Me.CheckBox41.Text = "관장(약물 또는 기타관장)"
        Me.CheckBox41.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(302, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 28)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "적용"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CheckBox36)
        Me.GroupBox15.Controls.Add(Me.CheckBox38)
        Me.GroupBox15.Controls.Add(Me.CheckBox39)
        Me.GroupBox15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox15.Location = New System.Drawing.Point(23, 27)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(354, 113)
        Me.GroupBox15.TabIndex = 32
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "물리요법"
        '
        'CheckBox36
        '
        Me.CheckBox36.AutoSize = True
        Me.CheckBox36.ForeColor = System.Drawing.Color.Black
        Me.CheckBox36.Location = New System.Drawing.Point(79, 74)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox36.TabIndex = 34
        Me.CheckBox36.Tag = "40702"
        Me.CheckBox36.Text = "경피경근한냉요법"
        Me.CheckBox36.UseVisualStyleBackColor = True
        '
        'CheckBox38
        '
        Me.CheckBox38.AutoSize = True
        Me.CheckBox38.ForeColor = System.Drawing.Color.Black
        Me.CheckBox38.Location = New System.Drawing.Point(79, 52)
        Me.CheckBox38.Name = "CheckBox38"
        Me.CheckBox38.Size = New System.Drawing.Size(132, 16)
        Me.CheckBox38.TabIndex = 32
        Me.CheckBox38.Tag = "40701"
        Me.CheckBox38.Text = "경피적외선조사요법"
        Me.CheckBox38.UseVisualStyleBackColor = True
        '
        'CheckBox39
        '
        Me.CheckBox39.AutoSize = True
        Me.CheckBox39.ForeColor = System.Drawing.Color.Black
        Me.CheckBox39.Location = New System.Drawing.Point(79, 30)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox39.TabIndex = 31
        Me.CheckBox39.Tag = "40700"
        Me.CheckBox39.Text = "경피경근온열요법"
        Me.CheckBox39.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.CheckBox75)
        Me.TabPage7.Controls.Add(Me.GroupBox19)
        Me.TabPage7.Controls.Add(Me.GroupBox18)
        Me.TabPage7.Controls.Add(Me.Button6)
        Me.TabPage7.Controls.Add(Me.GroupBox17)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(380, 631)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "검사/기타"
        '
        'CheckBox75
        '
        Me.CheckBox75.AutoSize = True
        Me.CheckBox75.ForeColor = System.Drawing.Color.Black
        Me.CheckBox75.Location = New System.Drawing.Point(64, 546)
        Me.CheckBox75.Name = "CheckBox75"
        Me.CheckBox75.Size = New System.Drawing.Size(320, 16)
        Me.CheckBox75.TabIndex = 42
        Me.CheckBox75.Tag = "93025"
        Me.CheckBox75.Text = "경피적외선조사요법(초음파·초단파·극초단파요법 동시)"
        Me.CheckBox75.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.CheckBox74)
        Me.GroupBox19.Controls.Add(Me.CheckBox66)
        Me.GroupBox19.Controls.Add(Me.CheckBox68)
        Me.GroupBox19.Controls.Add(Me.CheckBox69)
        Me.GroupBox19.Controls.Add(Me.CheckBox70)
        Me.GroupBox19.Controls.Add(Me.CheckBox71)
        Me.GroupBox19.Controls.Add(Me.CheckBox72)
        Me.GroupBox19.Controls.Add(Me.CheckBox73)
        Me.GroupBox19.ForeColor = System.Drawing.Color.Red
        Me.GroupBox19.Location = New System.Drawing.Point(3, 381)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(374, 191)
        Me.GroupBox19.TabIndex = 36
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "자동차보험 예외항목"
        '
        'CheckBox74
        '
        Me.CheckBox74.AutoSize = True
        Me.CheckBox74.ForeColor = System.Drawing.Color.Black
        Me.CheckBox74.Location = New System.Drawing.Point(61, 140)
        Me.CheckBox74.Name = "CheckBox74"
        Me.CheckBox74.Size = New System.Drawing.Size(308, 16)
        Me.CheckBox74.TabIndex = 41
        Me.CheckBox74.Tag = "93024"
        Me.CheckBox74.Text = "경피경근온열요법(초음파·초단파·극초단파요법 동시)"
        Me.CheckBox74.UseVisualStyleBackColor = True
        '
        'CheckBox66
        '
        Me.CheckBox66.AutoSize = True
        Me.CheckBox66.ForeColor = System.Drawing.Color.Black
        Me.CheckBox66.Location = New System.Drawing.Point(228, 96)
        Me.CheckBox66.Name = "CheckBox66"
        Me.CheckBox66.Size = New System.Drawing.Size(136, 16)
        Me.CheckBox66.TabIndex = 39
        Me.CheckBox66.Tag = "93022"
        Me.CheckBox66.Text = "추나요법(2부위이상)"
        Me.CheckBox66.UseVisualStyleBackColor = True
        '
        'CheckBox68
        '
        Me.CheckBox68.AutoSize = True
        Me.CheckBox68.ForeColor = System.Drawing.Color.Black
        Me.CheckBox68.Location = New System.Drawing.Point(61, 74)
        Me.CheckBox68.Name = "CheckBox68"
        Me.CheckBox68.Size = New System.Drawing.Size(100, 16)
        Me.CheckBox68.TabIndex = 38
        Me.CheckBox68.Tag = "93011"
        Me.CheckBox68.Text = "약침술(1부위)"
        Me.CheckBox68.UseVisualStyleBackColor = True
        '
        'CheckBox69
        '
        Me.CheckBox69.AutoSize = True
        Me.CheckBox69.ForeColor = System.Drawing.Color.Black
        Me.CheckBox69.Location = New System.Drawing.Point(61, 96)
        Me.CheckBox69.Name = "CheckBox69"
        Me.CheckBox69.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox69.TabIndex = 37
        Me.CheckBox69.Tag = "93021"
        Me.CheckBox69.Text = "추나요법(1부위)"
        Me.CheckBox69.UseVisualStyleBackColor = True
        '
        'CheckBox70
        '
        Me.CheckBox70.AutoSize = True
        Me.CheckBox70.ForeColor = System.Drawing.Color.Black
        Me.CheckBox70.Location = New System.Drawing.Point(61, 52)
        Me.CheckBox70.Name = "CheckBox70"
        Me.CheckBox70.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox70.TabIndex = 36
        Me.CheckBox70.Tag = "97014"
        Me.CheckBox70.Text = "사후처치 "
        Me.CheckBox70.UseVisualStyleBackColor = True
        '
        'CheckBox71
        '
        Me.CheckBox71.AutoSize = True
        Me.CheckBox71.ForeColor = System.Drawing.Color.Black
        Me.CheckBox71.Location = New System.Drawing.Point(228, 74)
        Me.CheckBox71.Name = "CheckBox71"
        Me.CheckBox71.Size = New System.Drawing.Size(124, 16)
        Me.CheckBox71.TabIndex = 35
        Me.CheckBox71.Tag = "93012"
        Me.CheckBox71.Text = "약침술(2부위이상)"
        Me.CheckBox71.UseVisualStyleBackColor = True
        '
        'CheckBox72
        '
        Me.CheckBox72.AutoSize = True
        Me.CheckBox72.ForeColor = System.Drawing.Color.Black
        Me.CheckBox72.Location = New System.Drawing.Point(228, 30)
        Me.CheckBox72.Name = "CheckBox72"
        Me.CheckBox72.Size = New System.Drawing.Size(126, 16)
        Me.CheckBox72.TabIndex = 34
        Me.CheckBox72.Tag = "91024"
        Me.CheckBox72.Text = "체온열검사-부위별"
        Me.CheckBox72.UseVisualStyleBackColor = True
        '
        'CheckBox73
        '
        Me.CheckBox73.AutoSize = True
        Me.CheckBox73.ForeColor = System.Drawing.Color.Black
        Me.CheckBox73.Location = New System.Drawing.Point(61, 30)
        Me.CheckBox73.Name = "CheckBox73"
        Me.CheckBox73.Size = New System.Drawing.Size(118, 16)
        Me.CheckBox73.TabIndex = 31
        Me.CheckBox73.Tag = "91014"
        Me.CheckBox73.Text = "체온열검사(전신)"
        Me.CheckBox73.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.CheckBox77)
        Me.GroupBox18.Controls.Add(Me.CheckBox64)
        Me.GroupBox18.Controls.Add(Me.CheckBox58)
        Me.GroupBox18.Controls.Add(Me.CheckBox59)
        Me.GroupBox18.Controls.Add(Me.CheckBox60)
        Me.GroupBox18.Controls.Add(Me.CheckBox61)
        Me.GroupBox18.Controls.Add(Me.CheckBox62)
        Me.GroupBox18.Controls.Add(Me.CheckBox63)
        Me.GroupBox18.Controls.Add(Me.CheckBox65)
        Me.GroupBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox18.Location = New System.Drawing.Point(3, 158)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(374, 214)
        Me.GroupBox18.TabIndex = 35
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "기타"
        '
        'CheckBox77
        '
        Me.CheckBox77.AutoSize = True
        Me.CheckBox77.ForeColor = System.Drawing.Color.Black
        Me.CheckBox77.Location = New System.Drawing.Point(61, 185)
        Me.CheckBox77.Name = "CheckBox77"
        Me.CheckBox77.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox77.TabIndex = 42
        Me.CheckBox77.Tag = "19100"
        Me.CheckBox77.Text = "가정간호교통비"
        Me.CheckBox77.UseVisualStyleBackColor = True
        '
        'CheckBox64
        '
        Me.CheckBox64.AutoSize = True
        Me.CheckBox64.ForeColor = System.Drawing.Color.Black
        Me.CheckBox64.Location = New System.Drawing.Point(61, 165)
        Me.CheckBox64.Name = "CheckBox64"
        Me.CheckBox64.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox64.TabIndex = 40
        Me.CheckBox64.Text = "가정간호료"
        Me.CheckBox64.UseVisualStyleBackColor = True
        '
        'CheckBox58
        '
        Me.CheckBox58.AutoSize = True
        Me.CheckBox58.ForeColor = System.Drawing.Color.Black
        Me.CheckBox58.Location = New System.Drawing.Point(61, 143)
        Me.CheckBox58.Name = "CheckBox58"
        Me.CheckBox58.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox58.TabIndex = 39
        Me.CheckBox58.Tag = "59103"
        Me.CheckBox58.Text = "가족치료"
        Me.CheckBox58.UseVisualStyleBackColor = True
        '
        'CheckBox59
        '
        Me.CheckBox59.AutoSize = True
        Me.CheckBox59.ForeColor = System.Drawing.Color.Black
        Me.CheckBox59.Location = New System.Drawing.Point(61, 77)
        Me.CheckBox59.Name = "CheckBox59"
        Me.CheckBox59.Size = New System.Drawing.Size(178, 16)
        Me.CheckBox59.TabIndex = 38
        Me.CheckBox59.Tag = "59003"
        Me.CheckBox59.Text = "개인정신치료(경자평지요법)"
        Me.CheckBox59.UseVisualStyleBackColor = True
        '
        'CheckBox60
        '
        Me.CheckBox60.AutoSize = True
        Me.CheckBox60.ForeColor = System.Drawing.Color.Black
        Me.CheckBox60.Location = New System.Drawing.Point(61, 121)
        Me.CheckBox60.Name = "CheckBox60"
        Me.CheckBox60.Size = New System.Drawing.Size(136, 16)
        Me.CheckBox60.TabIndex = 37
        Me.CheckBox60.Tag = "59102"
        Me.CheckBox60.Text = "정신과적 개인력조사"
        Me.CheckBox60.UseVisualStyleBackColor = True
        '
        'CheckBox61
        '
        Me.CheckBox61.AutoSize = True
        Me.CheckBox61.ForeColor = System.Drawing.Color.Black
        Me.CheckBox61.Location = New System.Drawing.Point(61, 55)
        Me.CheckBox61.Name = "CheckBox61"
        Me.CheckBox61.Size = New System.Drawing.Size(178, 16)
        Me.CheckBox61.TabIndex = 36
        Me.CheckBox61.Tag = "59002"
        Me.CheckBox61.Text = "개인정신치료(지언고론요법)"
        Me.CheckBox61.UseVisualStyleBackColor = True
        '
        'CheckBox62
        '
        Me.CheckBox62.AutoSize = True
        Me.CheckBox62.ForeColor = System.Drawing.Color.Black
        Me.CheckBox62.Location = New System.Drawing.Point(61, 99)
        Me.CheckBox62.Name = "CheckBox62"
        Me.CheckBox62.Size = New System.Drawing.Size(202, 16)
        Me.CheckBox62.TabIndex = 35
        Me.CheckBox62.Tag = "59004"
        Me.CheckBox62.Text = "개인정신치료(오지상승위치료법)"
        Me.CheckBox62.UseVisualStyleBackColor = True
        '
        'CheckBox63
        '
        Me.CheckBox63.AutoSize = True
        Me.CheckBox63.ForeColor = System.Drawing.Color.Black
        Me.CheckBox63.Location = New System.Drawing.Point(61, 33)
        Me.CheckBox63.Name = "CheckBox63"
        Me.CheckBox63.Size = New System.Drawing.Size(178, 16)
        Me.CheckBox63.TabIndex = 34
        Me.CheckBox63.Tag = "59001"
        Me.CheckBox63.Text = "개인정신치료(이정변기요법)"
        Me.CheckBox63.UseVisualStyleBackColor = True
        '
        'CheckBox65
        '
        Me.CheckBox65.AutoSize = True
        Me.CheckBox65.ForeColor = System.Drawing.Color.Black
        Me.CheckBox65.Location = New System.Drawing.Point(61, 11)
        Me.CheckBox65.Name = "CheckBox65"
        Me.CheckBox65.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox65.TabIndex = 31
        Me.CheckBox65.Tag = "45600"
        Me.CheckBox65.Text = "비강내영양"
        Me.CheckBox65.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(299, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 28)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "적용"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.CheckBox57)
        Me.GroupBox17.Controls.Add(Me.CheckBox56)
        Me.GroupBox17.Controls.Add(Me.CheckBox55)
        Me.GroupBox17.Controls.Add(Me.CheckBox54)
        Me.GroupBox17.Controls.Add(Me.CheckBox53)
        Me.GroupBox17.Controls.Add(Me.CheckBox50)
        Me.GroupBox17.Controls.Add(Me.CheckBox51)
        Me.GroupBox17.Controls.Add(Me.CheckBox52)
        Me.GroupBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox17.Location = New System.Drawing.Point(3, 29)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(374, 131)
        Me.GroupBox17.TabIndex = 33
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "검사"
        '
        'CheckBox57
        '
        Me.CheckBox57.AutoSize = True
        Me.CheckBox57.ForeColor = System.Drawing.Color.Black
        Me.CheckBox57.Location = New System.Drawing.Point(233, 96)
        Me.CheckBox57.Name = "CheckBox57"
        Me.CheckBox57.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox57.TabIndex = 39
        Me.CheckBox57.Tag = "29005"
        Me.CheckBox57.Text = "치매검사 "
        Me.CheckBox57.UseVisualStyleBackColor = True
        '
        'CheckBox56
        '
        Me.CheckBox56.AutoSize = True
        Me.CheckBox56.ForeColor = System.Drawing.Color.Black
        Me.CheckBox56.Location = New System.Drawing.Point(61, 96)
        Me.CheckBox56.Name = "CheckBox56"
        Me.CheckBox56.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox56.TabIndex = 38
        Me.CheckBox56.Tag = "29004"
        Me.CheckBox56.Text = "인성검사 "
        Me.CheckBox56.UseVisualStyleBackColor = True
        '
        'CheckBox55
        '
        Me.CheckBox55.AutoSize = True
        Me.CheckBox55.ForeColor = System.Drawing.Color.Black
        Me.CheckBox55.Location = New System.Drawing.Point(233, 74)
        Me.CheckBox55.Name = "CheckBox55"
        Me.CheckBox55.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox55.TabIndex = 37
        Me.CheckBox55.Tag = "29003"
        Me.CheckBox55.Text = "현훈검사 "
        Me.CheckBox55.UseVisualStyleBackColor = True
        '
        'CheckBox54
        '
        Me.CheckBox54.AutoSize = True
        Me.CheckBox54.ForeColor = System.Drawing.Color.Black
        Me.CheckBox54.Location = New System.Drawing.Point(61, 74)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New System.Drawing.Size(154, 16)
        Me.CheckBox54.TabIndex = 36
        Me.CheckBox54.Tag = "20032"
        Me.CheckBox54.Text = "경락기능검사-수양명경 "
        Me.CheckBox54.UseVisualStyleBackColor = True
        '
        'CheckBox53
        '
        Me.CheckBox53.AutoSize = True
        Me.CheckBox53.ForeColor = System.Drawing.Color.Black
        Me.CheckBox53.Location = New System.Drawing.Point(233, 52)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New System.Drawing.Size(142, 16)
        Me.CheckBox53.TabIndex = 35
        Me.CheckBox53.Tag = "20031"
        Me.CheckBox53.Text = "경락기능검사-양명경 "
        Me.CheckBox53.UseVisualStyleBackColor = True
        '
        'CheckBox50
        '
        Me.CheckBox50.AutoSize = True
        Me.CheckBox50.ForeColor = System.Drawing.Color.Black
        Me.CheckBox50.Location = New System.Drawing.Point(61, 52)
        Me.CheckBox50.Name = "CheckBox50"
        Me.CheckBox50.Size = New System.Drawing.Size(100, 16)
        Me.CheckBox50.TabIndex = 34
        Me.CheckBox50.Tag = "20030"
        Me.CheckBox50.Text = "경락기능검사 "
        Me.CheckBox50.UseVisualStyleBackColor = True
        '
        'CheckBox51
        '
        Me.CheckBox51.AutoSize = True
        Me.CheckBox51.ForeColor = System.Drawing.Color.Black
        Me.CheckBox51.Location = New System.Drawing.Point(233, 30)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.Size = New System.Drawing.Size(88, 16)
        Me.CheckBox51.TabIndex = 32
        Me.CheckBox51.Tag = "20020"
        Me.CheckBox51.Text = "맥전도검사 "
        Me.CheckBox51.UseVisualStyleBackColor = True
        '
        'CheckBox52
        '
        Me.CheckBox52.AutoSize = True
        Me.CheckBox52.ForeColor = System.Drawing.Color.Black
        Me.CheckBox52.Location = New System.Drawing.Point(61, 30)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New System.Drawing.Size(88, 16)
        Me.CheckBox52.TabIndex = 31
        Me.CheckBox52.Tag = "20010"
        Me.CheckBox52.Text = "양도락검사 "
        Me.CheckBox52.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage8.Controls.Add(Me.FpSpread8)
        Me.TabPage8.Controls.Add(Me.Button14)
        Me.TabPage8.Controls.Add(Me.Panel3)
        Me.TabPage8.Controls.Add(Me.Button10)
        Me.TabPage8.Controls.Add(Me.TextBox9)
        Me.TabPage8.Controls.Add(Me.Label18)
        Me.TabPage8.Controls.Add(Me.ListBox3)
        Me.TabPage8.Controls.Add(Me.ListBox2)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(380, 631)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "한약재"
        '
        'FpSpread8
        '
        Me.FpSpread8.AccessibleDescription = "FpSpread8, Sheet1, Row 0, Column 0, "
        Me.FpSpread8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FpSpread8.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread8.Location = New System.Drawing.Point(80, 93)
        Me.FpSpread8.Name = "FpSpread8"
        Me.FpSpread8.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView7})
        Me.FpSpread8.Size = New System.Drawing.Size(297, 528)
        Me.FpSpread8.TabIndex = 66
        '
        'SheetView7
        '
        Me.SheetView7.Reset()
        Me.SheetView7.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView7.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView7.ColumnCount = 3
        Me.SheetView7.RowCount = 3
        Me.SheetView7.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView7.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView7.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.ColumnHeader.Cells.Get(0, 0).Value = "S"
        Me.SheetView7.ColumnHeader.Cells.Get(0, 1).Value = "오더구분"
        Me.SheetView7.ColumnHeader.Cells.Get(0, 2).Value = "약재명칭"
        Me.SheetView7.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView7.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.SheetView7.Columns.Get(0).CellType = CheckBoxCellType2
        Me.SheetView7.Columns.Get(0).Label = "S"
        Me.SheetView7.Columns.Get(0).Width = 20.0!
        ComboBoxCellType1.AllowEditorVerticalAlign = True
        ComboBoxCellType1.ButtonAlign = FarPoint.Win.ButtonAlign.Right
        Me.SheetView7.Columns.Get(1).CellType = ComboBoxCellType1
        Me.SheetView7.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView7.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView7.Columns.Get(1).Label = "오더구분"
        Me.SheetView7.Columns.Get(1).Width = 59.0!
        Me.SheetView7.Columns.Get(2).Label = "약재명칭"
        Me.SheetView7.Columns.Get(2).Width = 194.0!
        Me.SheetView7.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView7.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView7.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView7.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.RowHeader.Columns.Default.Resizable = False
        Me.SheetView7.RowHeader.Columns.Get(0).Width = 31.0!
        Me.SheetView7.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView7.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView7.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView7.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView7.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView7.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(171, 64)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(48, 26)
        Me.Button14.TabIndex = 23
        Me.Button14.Text = "조회"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel3.Controls.Add(Me.NumericUpDown4)
        Me.Panel3.Controls.Add(Me.NumericUpDown3)
        Me.Panel3.Controls.Add(Me.NumericUpDown2)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.TextBox6)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.RadioButton6)
        Me.Panel3.Controls.Add(Me.RadioButton5)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Location = New System.Drawing.Point(6, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(371, 57)
        Me.Panel3.TabIndex = 22
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(313, 31)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown4.TabIndex = 27
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(231, 31)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown3.TabIndex = 26
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(154, 31)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown2.TabIndex = 25
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(60, 32)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown1.TabIndex = 24
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(241, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(127, 21)
        Me.TextBox6.TabIndex = 17
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(175, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 12)
        Me.Label29.TabIndex = 16
        Me.Label29.Text = "임의처방명"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(10, 4)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton6.TabIndex = 15
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "기준처방"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(94, 4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton5.TabIndex = 14
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "임의처방"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(290, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 12)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "첩"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(210, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 12)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "팩"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Magenta
        Me.Label20.Location = New System.Drawing.Point(122, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 12)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "일수"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(7, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 12)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "1일수량"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(302, 62)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 28)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "적용"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(50, 66)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(117, 21)
        Me.TextBox9.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "명칭"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 12
        Me.ListBox3.Items.AddRange(New Object() {"가~", "나~", "다~", "라~", "마~", "바~", "사~", "아~", "자~", "차~", "카~", "타~", "파~", "하~"})
        Me.ListBox3.Location = New System.Drawing.Point(5, 181)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(72, 436)
        Me.ListBox3.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Items.AddRange(New Object() {"단미제", "혼합제"})
        Me.ListBox2.Location = New System.Drawing.Point(6, 92)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(72, 88)
        Me.ListBox2.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Button17)
        Me.TabPage3.Controls.Add(Me.FpSpread9)
        Me.TabPage3.Controls.Add(Me.RadioButton8)
        Me.TabPage3.Controls.Add(Me.RadioButton7)
        Me.TabPage3.Controls.Add(Me.Button11)
        Me.TabPage3.Controls.Add(Me.TextBox10)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(380, 631)
        Me.TabPage3.TabIndex = 8
        Me.TabPage3.Text = "비급/재료"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(156, 34)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(48, 26)
        Me.Button17.TabIndex = 68
        Me.Button17.Text = "조회"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'FpSpread9
        '
        Me.FpSpread9.AccessibleDescription = "FpSpread9, Sheet1, Row 0, Column 0, "
        Me.FpSpread9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FpSpread9.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread9.Location = New System.Drawing.Point(6, 91)
        Me.FpSpread9.Name = "FpSpread9"
        Me.FpSpread9.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView8})
        Me.FpSpread9.Size = New System.Drawing.Size(368, 523)
        Me.FpSpread9.TabIndex = 67
        '
        'SheetView8
        '
        Me.SheetView8.Reset()
        Me.SheetView8.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView8.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView8.ColumnCount = 2
        Me.SheetView8.RowCount = 3
        Me.SheetView8.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView8.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView8.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.ColumnHeader.Cells.Get(0, 0).Value = "S"
        Me.SheetView8.ColumnHeader.Cells.Get(0, 1).Value = "약재명칭"
        Me.SheetView8.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView8.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.SheetView8.Columns.Get(0).CellType = CheckBoxCellType3
        Me.SheetView8.Columns.Get(0).Label = "S"
        Me.SheetView8.Columns.Get(0).Width = 20.0!
        Me.SheetView8.Columns.Get(1).Label = "약재명칭"
        Me.SheetView8.Columns.Get(1).Width = 298.0!
        Me.SheetView8.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView8.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView8.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView8.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.RowHeader.Columns.Default.Resizable = False
        Me.SheetView8.RowHeader.Columns.Get(0).Width = 31.0!
        Me.SheetView8.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView8.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView8.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView8.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView8.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView8.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(86, 10)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton8.TabIndex = 29
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "재료"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Red
        Me.RadioButton7.Location = New System.Drawing.Point(10, 10)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton7.TabIndex = 28
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "비급여"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(301, 33)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 28)
        Me.Button11.TabIndex = 26
        Me.Button11.Text = "적용"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(43, 37)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(107, 21)
        Me.TextBox10.TabIndex = 25
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 12)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "명칭"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.NumericUpDown5)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.NumericUpDown6)
        Me.Panel4.Controls.Add(Me.NumericUpDown7)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.NumericUpDown8)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Location = New System.Drawing.Point(5, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(371, 27)
        Me.Panel4.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Maroon
        Me.Label23.Location = New System.Drawing.Point(283, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 12)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "첩"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(301, 3)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown5.TabIndex = 33
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(202, 7)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 12)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "팩"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(219, 3)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown6.TabIndex = 32
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(142, 3)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown7.TabIndex = 31
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Magenta
        Me.Label25.Location = New System.Drawing.Point(114, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 12)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "일수"
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(48, 4)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(39, 21)
        Me.NumericUpDown8.TabIndex = 30
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(3, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 12)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "1일수량"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.CausesValidation = False
        Me.Panel1.Controls.Add(Me.FpSpread2)
        Me.Panel1.Location = New System.Drawing.Point(407, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 349)
        Me.Panel1.TabIndex = 23
        '
        'FpSpread2
        '
        Me.FpSpread2.AccessibleDescription = "FpSpread2, Sheet1, Row 0, Column 0, "
        Me.FpSpread2.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread2.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread2.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread2.Name = "FpSpread2"
        Me.FpSpread2.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread2.Size = New System.Drawing.Size(835, 347)
        Me.FpSpread2.TabIndex = 64
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
        ComboBoxCellType2.AllowEditorVerticalAlign = True
        ComboBoxCellType2.ButtonAlign = FarPoint.Win.ButtonAlign.Right
        Me.SheetView1.Columns.Get(0).CellType = ComboBoxCellType2
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.Button21)
        Me.Panel5.Controls.Add(Me.Button16)
        Me.Panel5.Controls.Add(Me.Button15)
        Me.Panel5.Location = New System.Drawing.Point(758, 69)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(487, 26)
        Me.Panel5.TabIndex = 24
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(135, 1)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(75, 23)
        Me.Button21.TabIndex = 67
        Me.Button21.Text = "라인추가"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(411, 1)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 66
        Me.Button16.Text = "상병저장"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(2, 1)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(133, 23)
        Me.Button15.TabIndex = 65
        Me.Button15.Text = "전월상병가져오기"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Controls.Add(Me.Button7)
        Me.Panel7.Controls.Add(Me.TextBox7)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.BtnSin)
        Me.Panel7.Location = New System.Drawing.Point(407, 607)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(836, 27)
        Me.Panel7.TabIndex = 25
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(619, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 23)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "메모적용"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(71, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(547, 21)
        Me.TextBox7.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "청구메모"
        '
        'BtnSin
        '
        Me.BtnSin.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSin.ForeColor = System.Drawing.Color.Red
        Me.BtnSin.Location = New System.Drawing.Point(721, 1)
        Me.BtnSin.Name = "BtnSin"
        Me.BtnSin.Size = New System.Drawing.Size(112, 24)
        Me.BtnSin.TabIndex = 39
        Me.BtnSin.Text = "당일오더로전송"
        Me.BtnSin.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel8.Controls.Add(Me.FpSpread5)
        Me.Panel8.Location = New System.Drawing.Point(407, 637)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(838, 275)
        Me.Panel8.TabIndex = 0
        '
        'FpSpread5
        '
        Me.FpSpread5.AccessibleDescription = "FpSpread2, Sheet1, Row 0, Column 0, "
        Me.FpSpread5.BackColor = System.Drawing.Color.Fuchsia
        Me.FpSpread5.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread5.Location = New System.Drawing.Point(0, 1)
        Me.FpSpread5.Name = "FpSpread5"
        Me.FpSpread5.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView4})
        Me.FpSpread5.Size = New System.Drawing.Size(836, 272)
        Me.FpSpread5.TabIndex = 65
        '
        'SheetView4
        '
        Me.SheetView4.Reset()
        Me.SheetView4.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView4.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView4.ColumnCount = 18
        Me.SheetView4.RowCount = 3
        Me.SheetView4.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView4.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView4.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.ColumnHeader.Cells.Get(0, 0).Value = "오더구분"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 1).Value = "오더명칭"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 2).Value = "급여구분"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 3).Value = "일투여량"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 4).Value = "투여일수"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 5).Value = "첩수"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 6).Value = "팩수"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 7).Value = "용법"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 8).Value = "청구메모"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 9).Value = "전송부서"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 10).Value = "의사명"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 11).Value = "가감코드"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 12).Value = "보험코드"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 13).Value = "병원코드"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 14).Value = "혈명코드"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 15).Value = "특정코드"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 16).Value = "특정내역"
        Me.SheetView4.ColumnHeader.Cells.Get(0, 17).Value = "면허번호"
        Me.SheetView4.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView4.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.ColumnHeader.Rows.Get(0).Height = 29.0!
        ComboBoxCellType3.AllowEditorVerticalAlign = True
        ComboBoxCellType3.ButtonAlign = FarPoint.Win.ButtonAlign.Right
        Me.SheetView4.Columns.Get(0).CellType = ComboBoxCellType3
        Me.SheetView4.Columns.Get(0).Label = "오더구분"
        Me.SheetView4.Columns.Get(1).Label = "오더명칭"
        Me.SheetView4.Columns.Get(1).Width = 290.0!
        Me.SheetView4.Columns.Get(2).Label = "급여구분"
        Me.SheetView4.Columns.Get(2).Width = 30.0!
        Me.SheetView4.Columns.Get(3).Label = "일투여량"
        Me.SheetView4.Columns.Get(3).Width = 56.0!
        Me.SheetView4.Columns.Get(4).Label = "투여일수"
        Me.SheetView4.Columns.Get(4).Width = 55.0!
        Me.SheetView4.Columns.Get(5).Label = "첩수"
        Me.SheetView4.Columns.Get(5).Width = 48.0!
        Me.SheetView4.Columns.Get(6).Label = "팩수"
        Me.SheetView4.Columns.Get(6).Width = 48.0!
        Me.SheetView4.Columns.Get(7).Label = "용법"
        Me.SheetView4.Columns.Get(7).Width = 149.0!
        Me.SheetView4.Columns.Get(8).Label = "청구메모"
        Me.SheetView4.Columns.Get(8).Width = 31.0!
        Me.SheetView4.Columns.Get(9).Label = "전송부서"
        Me.SheetView4.Columns.Get(9).Width = 32.0!
        Me.SheetView4.Columns.Get(10).Label = "의사명"
        Me.SheetView4.Columns.Get(10).Width = 49.0!
        Me.SheetView4.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView4.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView4.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView4.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.RowHeader.Columns.Default.Resizable = False
        Me.SheetView4.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView4.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView4.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView4.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView4.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView4.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(974, 50)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 68
        Me.CheckBox1.Text = "청구안함"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox79
        '
        Me.CheckBox79.AutoSize = True
        Me.CheckBox79.ForeColor = System.Drawing.Color.Red
        Me.CheckBox79.Location = New System.Drawing.Point(884, 50)
        Me.CheckBox79.Name = "CheckBox79"
        Me.CheckBox79.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox79.TabIndex = 67
        Me.CheckBox79.Text = "변증기술료"
        Me.CheckBox79.UseVisualStyleBackColor = True
        '
        'CheckBox78
        '
        Me.CheckBox78.AutoSize = True
        Me.CheckBox78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox78.Location = New System.Drawing.Point(768, 50)
        Me.CheckBox78.Name = "CheckBox78"
        Me.CheckBox78.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox78.TabIndex = 66
        Me.CheckBox78.Text = "진찰료청구안함"
        Me.CheckBox78.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Controls.Add(Me.FpSpread4)
        Me.Panel2.Location = New System.Drawing.Point(758, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 146)
        Me.Panel2.TabIndex = 69
        '
        'FpSpread4
        '
        Me.FpSpread4.AccessibleDescription = "FpSpread4, Sheet1, Row 0, Column 0, "
        Me.FpSpread4.BackColor = System.Drawing.Color.SlateGray
        Me.FpSpread4.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread4.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread4.Name = "FpSpread4"
        Me.FpSpread4.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView3})
        Me.FpSpread4.Size = New System.Drawing.Size(485, 144)
        Me.FpSpread4.TabIndex = 65
        '
        'SheetView3
        '
        Me.SheetView3.Reset()
        Me.SheetView3.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView3.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView3.ColumnCount = 5
        Me.SheetView3.RowCount = 3
        Me.SheetView3.Cells.Get(0, 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.SheetView3.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView3.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView3.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView3.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView3.ColumnHeader.Cells.Get(0, 0).Value = "구분"
        Me.SheetView3.ColumnHeader.Cells.Get(0, 1).Value = "상병기호"
        Me.SheetView3.ColumnHeader.Cells.Get(0, 2).Value = "KCD상병명"
        Me.SheetView3.ColumnHeader.Cells.Get(0, 3).Value = "특정기호"
        Me.SheetView3.ColumnHeader.Cells.Get(0, 4).Value = "상해외인"
        Me.SheetView3.Columns.Get(0).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView3.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView3.Columns.Get(0).Label = "구분"
        Me.SheetView3.Columns.Get(0).Width = 39.0!
        Me.SheetView3.Columns.Get(1).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView3.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView3.Columns.Get(1).Label = "상병기호"
        Me.SheetView3.Columns.Get(1).Width = 54.0!
        Me.SheetView3.Columns.Get(2).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView3.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.SheetView3.Columns.Get(2).Label = "KCD상병명"
        Me.SheetView3.Columns.Get(2).Width = 281.0!
        Me.SheetView3.Columns.Get(3).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView3.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView3.Columns.Get(3).Label = "특정기호"
        Me.SheetView3.Columns.Get(4).Font = New System.Drawing.Font("굴림", 9.0!)
        Me.SheetView3.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView3.Columns.Get(4).Label = "상해외인"
        Me.SheetView3.Columns.Get(4).Width = 54.0!
        Me.SheetView3.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView3.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView3.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView3.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView3.RowHeader.Columns.Default.Resizable = False
        Me.SheetView3.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면ClearToolStripMenuItem, Me.저장ToolStripMenuItem, Me.제증명ToolStripMenuItem, Me.검사결과ToolStripMenuItem, Me.상병조회ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1249, 39)
        Me.MenuStrip1.TabIndex = 70
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
        Me.저장ToolStripMenuItem.Text = "저  장"
        Me.저장ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '제증명ToolStripMenuItem
        '
        Me.제증명ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.심사화면
        Me.제증명ToolStripMenuItem.Name = "제증명ToolStripMenuItem"
        Me.제증명ToolStripMenuItem.Size = New System.Drawing.Size(55, 35)
        Me.제증명ToolStripMenuItem.Text = "제증명"
        Me.제증명ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '검사결과ToolStripMenuItem
        '
        Me.검사결과ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.가퇴원
        Me.검사결과ToolStripMenuItem.Name = "검사결과ToolStripMenuItem"
        Me.검사결과ToolStripMenuItem.Size = New System.Drawing.Size(67, 35)
        Me.검사결과ToolStripMenuItem.Text = "검사결과"
        Me.검사결과ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '상병조회ToolStripMenuItem
        '
        Me.상병조회ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.조회
        Me.상병조회ToolStripMenuItem.Name = "상병조회ToolStripMenuItem"
        Me.상병조회ToolStripMenuItem.Size = New System.Drawing.Size(67, 35)
        Me.상병조회ToolStripMenuItem.Text = "상병조회"
        Me.상병조회ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.종료
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(51, 35)
        Me.종료ToolStripMenuItem.Text = "종  료"
        Me.종료ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frm진료실
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1249, 913)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox79)
        Me.Controls.Add(Me.CheckBox78)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gb환자정보)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm진료실"
        Me.Text = "진료실"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.Fps환자리스트, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fps환자리스트_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb환자정보.ResumeLayout(False)
        Me.Gb환자정보.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.FpSpread7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.FpSpread8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.FpSpread9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.FpSpread5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.FpSpread4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rdb전체 As RadioButton
    Friend WithEvents Rdb진료완료 As RadioButton
    Friend WithEvents Rdb치료실 As RadioButton
    Friend WithEvents Rdb진료대기 As RadioButton
    Friend WithEvents CbB의사리스트 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Gb환자정보 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb보험종별 As TextBox
    Friend WithEvents Tb성별 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb나이 As TextBox
    Friend WithEvents Tb성명 As TextBox
    Friend WithEvents Tb챠트번호 As TextBox
    Friend WithEvents Tb접수메모 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chkGusul9 As CheckBox
    Friend WithEvents chkGusul8 As CheckBox
    Friend WithEvents chkGusul5 As CheckBox
    Friend WithEvents chkGusul7 As CheckBox
    Friend WithEvents chkGusul6 As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkGusul4 As CheckBox
    Friend WithEvents chkGusul1 As CheckBox
    Friend WithEvents chkGusul3 As CheckBox
    Friend WithEvents chkGusul2 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents ChkToo1 As CheckBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents ChkChuk9 As CheckBox
    Friend WithEvents ChkChuk8 As CheckBox
    Friend WithEvents ChkChuk7 As CheckBox
    Friend WithEvents ChkChuk6 As CheckBox
    Friend WithEvents ChkChuk5 As CheckBox
    Friend WithEvents ChkChuk4 As CheckBox
    Friend WithEvents ChkChuk3 As CheckBox
    Friend WithEvents ChkChuk2 As CheckBox
    Friend WithEvents ChkChuk1 As CheckBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ChkKwan19 As CheckBox
    Friend WithEvents ChkKwan18 As CheckBox
    Friend WithEvents ChkKwan17 As CheckBox
    Friend WithEvents ChkKwan16 As CheckBox
    Friend WithEvents ChkKwan15 As CheckBox
    Friend WithEvents ChkKwan14 As CheckBox
    Friend WithEvents ChkKwan12 As CheckBox
    Friend WithEvents ChkKwan11 As CheckBox
    Friend WithEvents ChkKwan10 As CheckBox
    Friend WithEvents ChkKwan9 As CheckBox
    Friend WithEvents ChkKwan8 As CheckBox
    Friend WithEvents ChkKwan7 As CheckBox
    Friend WithEvents ChkKwan6 As CheckBox
    Friend WithEvents ChkKwan5 As CheckBox
    Friend WithEvents ChkKwan4 As CheckBox
    Friend WithEvents ChkKwan3 As CheckBox
    Friend WithEvents ChkKwan2 As CheckBox
    Friend WithEvents ChkKwan1 As CheckBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents ChkBok8 As CheckBox
    Friend WithEvents ChkBok7 As CheckBox
    Friend WithEvents ChkBok6 As CheckBox
    Friend WithEvents ChkBok5 As CheckBox
    Friend WithEvents ChkBok4 As CheckBox
    Friend WithEvents ChkBok3 As CheckBox
    Friend WithEvents ChkBok2 As CheckBox
    Friend WithEvents ChkBok1 As CheckBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ChkBi As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents ChkAn2 As CheckBox
    Friend WithEvents ChkAn1 As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox26 As CheckBox
    Friend WithEvents CheckBox25 As CheckBox
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents CheckBox35 As CheckBox
    Friend WithEvents CheckBox34 As CheckBox
    Friend WithEvents CheckBox33 As CheckBox
    Friend WithEvents CheckBox32 As CheckBox
    Friend WithEvents CheckBox31 As CheckBox
    Friend WithEvents CheckBox30 As CheckBox
    Friend WithEvents CheckBox29 As CheckBox
    Friend WithEvents CheckBox28 As CheckBox
    Friend WithEvents CheckBox27 As CheckBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents CheckBox49 As CheckBox
    Friend WithEvents CheckBox48 As CheckBox
    Friend WithEvents CheckBox47 As CheckBox
    Friend WithEvents CheckBox46 As CheckBox
    Friend WithEvents CheckBox45 As CheckBox
    Friend WithEvents CheckBox44 As CheckBox
    Friend WithEvents CheckBox43 As CheckBox
    Friend WithEvents CheckBox42 As CheckBox
    Friend WithEvents CheckBox37 As CheckBox
    Friend WithEvents CheckBox40 As CheckBox
    Friend WithEvents CheckBox41 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents CheckBox36 As CheckBox
    Friend WithEvents CheckBox38 As CheckBox
    Friend WithEvents CheckBox39 As CheckBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents CheckBox64 As CheckBox
    Friend WithEvents CheckBox58 As CheckBox
    Friend WithEvents CheckBox59 As CheckBox
    Friend WithEvents CheckBox60 As CheckBox
    Friend WithEvents CheckBox61 As CheckBox
    Friend WithEvents CheckBox62 As CheckBox
    Friend WithEvents CheckBox63 As CheckBox
    Friend WithEvents CheckBox65 As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents CheckBox57 As CheckBox
    Friend WithEvents CheckBox56 As CheckBox
    Friend WithEvents CheckBox55 As CheckBox
    Friend WithEvents CheckBox54 As CheckBox
    Friend WithEvents CheckBox53 As CheckBox
    Friend WithEvents CheckBox50 As CheckBox
    Friend WithEvents CheckBox51 As CheckBox
    Friend WithEvents CheckBox52 As CheckBox
    Friend WithEvents CheckBox75 As CheckBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents CheckBox74 As CheckBox
    Friend WithEvents CheckBox66 As CheckBox
    Friend WithEvents CheckBox68 As CheckBox
    Friend WithEvents CheckBox69 As CheckBox
    Friend WithEvents CheckBox70 As CheckBox
    Friend WithEvents CheckBox71 As CheckBox
    Friend WithEvents CheckBox72 As CheckBox
    Friend WithEvents CheckBox73 As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Chk야간 As CheckBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Button14 As Button
    Friend WithEvents Tb최종내원일 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents CheckBox77 As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Dtp진료일자 As DateTimePicker
    Friend WithEvents FpSpread3 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView2 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Fps환자리스트 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents Fps환자리스트_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnSin As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FpSpread6 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView5 As FarPoint.Win.Spread.SheetView
    Friend WithEvents FpSpread2 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents NumericUpDown10 As NumericUpDown
    Friend WithEvents NumericUpDown11 As NumericUpDown
    Friend WithEvents NumericUpDown12 As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents FpSpread7 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView6 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Button13 As Button
    Friend WithEvents FpSpread8 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView7 As FarPoint.Win.Spread.SheetView
    Friend WithEvents FpSpread9 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView8 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Tb증상 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents FpSpread5 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView4 As FarPoint.Win.Spread.SheetView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox79 As CheckBox
    Friend WithEvents CheckBox78 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FpSpread4 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView3 As FarPoint.Win.Spread.SheetView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 제증명ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 검사결과ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 상병조회ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm사용자등록
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
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt주소 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt우편번호 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt생년월일 = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt핸드폰 = New System.Windows.Forms.TextBox()
        Me.txt연락처 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo직위 = New System.Windows.Forms.ComboBox()
        Me.cbo부서 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt퇴사 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt주민번호2 = New System.Windows.Forms.TextBox()
        Me.txt주민번호1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt성명 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn검색 = New System.Windows.Forms.Button()
        Me.txt아이디 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbo면허종류 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt면허번호 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbo과목 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt성명1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn검색1 = New System.Windows.Forms.Button()
        Me.cbo부서별 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt메모 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.화면ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt주소)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt우편번호)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txt생년월일)
        Me.Panel1.Controls.Add(Me.txtpw)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txt핸드폰)
        Me.Panel1.Controls.Add(Me.txt연락처)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cbo직위)
        Me.Panel1.Controls.Add(Me.cbo부서)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt퇴사)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt주민번호2)
        Me.Panel1.Controls.Add(Me.txt주민번호1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt성명)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn검색)
        Me.Panel1.Controls.Add(Me.txt아이디)
        Me.Panel1.Location = New System.Drawing.Point(2, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 362)
        Me.Panel1.TabIndex = 0
        '
        'txt주소
        '
        Me.txt주소.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt주소.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txt주소.Location = New System.Drawing.Point(70, 251)
        Me.txt주소.Multiline = True
        Me.txt주소.Name = "txt주소"
        Me.txt주소.Size = New System.Drawing.Size(237, 42)
        Me.txt주소.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 12)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "주  소"
        '
        'txt우편번호
        '
        Me.txt우편번호.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt우편번호.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txt우편번호.Location = New System.Drawing.Point(70, 217)
        Me.txt우편번호.Name = "txt우편번호"
        Me.txt우편번호.Size = New System.Drawing.Size(106, 21)
        Me.txt우편번호.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 221)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "우편번호"
        '
        'txt생년월일
        '
        Me.txt생년월일.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt생년월일.Location = New System.Drawing.Point(70, 137)
        Me.txt생년월일.Name = "txt생년월일"
        Me.txt생년월일.Size = New System.Drawing.Size(81, 21)
        Me.txt생년월일.TabIndex = 57
        '
        'txtpw
        '
        Me.txtpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpw.Location = New System.Drawing.Point(70, 57)
        Me.txtpw.MaxLength = 10
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(81, 21)
        Me.txtpw.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 12)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Password"
        '
        'txt핸드폰
        '
        Me.txt핸드폰.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt핸드폰.Location = New System.Drawing.Point(70, 190)
        Me.txt핸드폰.Name = "txt핸드폰"
        Me.txt핸드폰.Size = New System.Drawing.Size(106, 21)
        Me.txt핸드폰.TabIndex = 59
        '
        'txt연락처
        '
        Me.txt연락처.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt연락처.Location = New System.Drawing.Point(70, 164)
        Me.txt연락처.Name = "txt연락처"
        Me.txt연락처.Size = New System.Drawing.Size(106, 21)
        Me.txt연락처.TabIndex = 58
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "핸드폰"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "연락처"
        '
        'cbo직위
        '
        Me.cbo직위.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo직위.FormattingEnabled = True
        Me.cbo직위.Location = New System.Drawing.Point(212, 326)
        Me.cbo직위.Name = "cbo직위"
        Me.cbo직위.Size = New System.Drawing.Size(77, 20)
        Me.cbo직위.TabIndex = 65
        '
        'cbo부서
        '
        Me.cbo부서.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo부서.FormattingEnabled = True
        Me.cbo부서.Location = New System.Drawing.Point(68, 325)
        Me.cbo부서.Name = "cbo부서"
        Me.cbo부서.Size = New System.Drawing.Size(83, 20)
        Me.cbo부서.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "직위"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "담당부서"
        '
        'txt퇴사
        '
        Me.txt퇴사.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt퇴사.Location = New System.Drawing.Point(210, 299)
        Me.txt퇴사.Name = "txt퇴사"
        Me.txt퇴사.Size = New System.Drawing.Size(81, 21)
        Me.txt퇴사.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(151, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "퇴사일자"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(70, 301)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(81, 21)
        Me.DateTimePicker1.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "입사일자"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(288, 25)
        Me.Panel4.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "공통사항"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "생년월일"
        '
        'txt주민번호2
        '
        Me.txt주민번호2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt주민번호2.Location = New System.Drawing.Point(150, 109)
        Me.txt주민번호2.MaxLength = 7
        Me.txt주민번호2.Name = "txt주민번호2"
        Me.txt주민번호2.Size = New System.Drawing.Size(109, 21)
        Me.txt주민번호2.TabIndex = 56
        '
        'txt주민번호1
        '
        Me.txt주민번호1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt주민번호1.Location = New System.Drawing.Point(70, 109)
        Me.txt주민번호1.MaxLength = 6
        Me.txt주민번호1.Name = "txt주민번호1"
        Me.txt주민번호1.Size = New System.Drawing.Size(81, 21)
        Me.txt주민번호1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "주민번호"
        '
        'txt성명
        '
        Me.txt성명.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt성명.Location = New System.Drawing.Point(70, 82)
        Me.txt성명.MaxLength = 10
        Me.txt성명.Name = "txt성명"
        Me.txt성명.Size = New System.Drawing.Size(81, 21)
        Me.txt성명.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "성  명"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "아이디"
        '
        'btn검색
        '
        Me.btn검색.Location = New System.Drawing.Point(152, 29)
        Me.btn검색.Name = "btn검색"
        Me.btn검색.Size = New System.Drawing.Size(75, 24)
        Me.btn검색.TabIndex = 52
        Me.btn검색.Text = "아이디검색"
        Me.btn검색.UseVisualStyleBackColor = True
        '
        'txt아이디
        '
        Me.txt아이디.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt아이디.Location = New System.Drawing.Point(70, 31)
        Me.txt아이디.MaxLength = 10
        Me.txt아이디.Name = "txt아이디"
        Me.txt아이디.Size = New System.Drawing.Size(81, 21)
        Me.txt아이디.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbo면허종류)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txt면허번호)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cbo과목)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(315, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 128)
        Me.Panel2.TabIndex = 1
        '
        'cbo면허종류
        '
        Me.cbo면허종류.DisplayMember = "한의사"
        Me.cbo면허종류.FormattingEnabled = True
        Me.cbo면허종류.Items.AddRange(New Object() {"한의사", "의사"})
        Me.cbo면허종류.Location = New System.Drawing.Point(74, 89)
        Me.cbo면허종류.Name = "cbo면허종류"
        Me.cbo면허종류.Size = New System.Drawing.Size(121, 20)
        Me.cbo면허종류.TabIndex = 68
        Me.cbo면허종류.Text = "한의사"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 12)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "면허종류"
        '
        'txt면허번호
        '
        Me.txt면허번호.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt면허번호.Location = New System.Drawing.Point(74, 60)
        Me.txt면허번호.Name = "txt면허번호"
        Me.txt면허번호.Size = New System.Drawing.Size(81, 21)
        Me.txt면허번호.TabIndex = 67
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "면허번호"
        '
        'cbo과목
        '
        Me.cbo과목.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo과목.FormattingEnabled = True
        Me.cbo과목.Location = New System.Drawing.Point(74, 34)
        Me.cbo과목.Name = "cbo과목"
        Me.cbo과목.Size = New System.Drawing.Size(121, 20)
        Me.cbo과목.TabIndex = 66
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "진료과목"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(4, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(288, 25)
        Me.Panel5.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "진료의사"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txt성명1)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.btn검색1)
        Me.Panel6.Controls.Add(Me.cbo부서별)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Location = New System.Drawing.Point(2, 408)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(605, 25)
        Me.Panel6.TabIndex = 62
        '
        'txt성명1
        '
        Me.txt성명1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt성명1.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txt성명1.Location = New System.Drawing.Point(439, 1)
        Me.txt성명1.Name = "txt성명1"
        Me.txt성명1.Size = New System.Drawing.Size(81, 21)
        Me.txt성명1.TabIndex = 71
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(395, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 12)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "성  명"
        '
        'btn검색1
        '
        Me.btn검색1.Location = New System.Drawing.Point(521, -1)
        Me.btn검색1.Name = "btn검색1"
        Me.btn검색1.Size = New System.Drawing.Size(75, 23)
        Me.btn검색1.TabIndex = 72
        Me.btn검색1.Text = "검색"
        Me.btn검색1.UseVisualStyleBackColor = True
        '
        'cbo부서별
        '
        Me.cbo부서별.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo부서별.FormattingEnabled = True
        Me.cbo부서별.Location = New System.Drawing.Point(75, 1)
        Me.cbo부서별.Name = "cbo부서별"
        Me.cbo부서별.Size = New System.Drawing.Size(121, 20)
        Me.cbo부서별.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 12)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "부서별검색"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Pink
        Me.Panel3.Controls.Add(Me.FpSpread1)
        Me.Panel3.Location = New System.Drawing.Point(4, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 337)
        Me.Panel3.TabIndex = 65
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread1.Location = New System.Drawing.Point(2, 1)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(598, 331)
        Me.FpSpread1.TabIndex = 73
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.FpSpread1_Sheet1.ColumnCount = 7
        Me.FpSpread1_Sheet1.RowCount = 2
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "성명"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "ID"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "pw"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "부서"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "직위"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "입사일자"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "면허번호"
        Me.FpSpread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(0).Label = "성명"
        Me.FpSpread1_Sheet1.Columns.Get(0).Width = 81.0!
        Me.FpSpread1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(1).Label = "ID"
        Me.FpSpread1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(2).Label = "pw"
        Me.FpSpread1_Sheet1.Columns.Get(2).Width = 68.0!
        Me.FpSpread1_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(3).Label = "부서"
        Me.FpSpread1_Sheet1.Columns.Get(3).Width = 71.0!
        Me.FpSpread1_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.FpSpread1_Sheet1.Columns.Get(4).Label = "직위"
        Me.FpSpread1_Sheet1.Columns.Get(4).Width = 71.0!
        TextCellType1.AllowEditorVerticalAlign = True
        Me.FpSpread1_Sheet1.Columns.Get(5).CellType = TextCellType1
        Me.FpSpread1_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.FpSpread1_Sheet1.Columns.Get(5).Label = "입사일자"
        Me.FpSpread1_Sheet1.Columns.Get(5).Width = 71.0!
        Me.FpSpread1_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.FpSpread1_Sheet1.Columns.Get(6).Label = "면허번호"
        Me.FpSpread1_Sheet1.Columns.Get(6).Width = 71.0!
        Me.FpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(319, 202)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 12)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "메모"
        '
        'txt메모
        '
        Me.txt메모.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt메모.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txt메모.Location = New System.Drawing.Point(321, 217)
        Me.txt메모.Multiline = True
        Me.txt메모.Name = "txt메모"
        Me.txt메모.Size = New System.Drawing.Size(283, 42)
        Me.txt메모.TabIndex = 69
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.화면ClearToolStripMenuItem, Me.저장ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 36)
        Me.MenuStrip1.TabIndex = 82
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
        '저장ToolStripMenuItem
        '
        Me.저장ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.저장
        Me.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem"
        Me.저장ToolStripMenuItem.Size = New System.Drawing.Size(49, 32)
        Me.저장ToolStripMenuItem.Text = "저  장"
        Me.저장ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.종료
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(49, 32)
        Me.종료ToolStripMenuItem.Text = "종  료"
        Me.종료ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frm사용자등록
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 780)
        Me.Controls.Add(Me.txt메모)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm사용자등록"
        Me.Text = "사용자등록"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn검색 As Button
    Friend WithEvents txt아이디 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt주민번호2 As TextBox
    Friend WithEvents txt주민번호1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt성명 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt퇴사 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt주소 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt우편번호 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt생년월일 As TextBox
    Friend WithEvents txtpw As TextBox
    Private WithEvents Label13 As Label
    Friend WithEvents txt핸드폰 As TextBox
    Friend WithEvents txt연락처 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo직위 As ComboBox
    Friend WithEvents cbo부서 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo면허종류 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt면허번호 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbo과목 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbo부서별 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn검색1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Label20 As Label
    Friend WithEvents txt메모 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 화면ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt성명1 As TextBox
    Friend WithEvents Label21 As Label
End Class

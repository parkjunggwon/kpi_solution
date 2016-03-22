<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.접수ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.수납ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.미수관리ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.진료실ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.수가등록ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.사용자등록ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.기초자료등록ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.제증명발급ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.제증명발급조회ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.병원정보등록ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.약속코드등록ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMS전송ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.수납현황ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.할인현황ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.진료실적ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.미수금조회ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.미수금수납ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.청구빌드ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.건강보험심사ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.의료급여심사ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.산재보험심사ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.자동차보험심사ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.송신업무ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.수신업무ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.청구통계ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.접수ToolStripMenuItem, Me.수납ToolStripMenuItem1, Me.미수관리ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.진료실ToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem1, Me.ToolStripMenuItem7, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(899, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '접수ToolStripMenuItem
        '
        Me.접수ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.접수
        Me.접수ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.접수ToolStripMenuItem.Name = "접수ToolStripMenuItem"
        Me.접수ToolStripMenuItem.Size = New System.Drawing.Size(51, 36)
        Me.접수ToolStripMenuItem.Text = "접  수"
        Me.접수ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '수납ToolStripMenuItem1
        '
        Me.수납ToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.수납
        Me.수납ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.수납ToolStripMenuItem1.Name = "수납ToolStripMenuItem1"
        Me.수납ToolStripMenuItem1.Size = New System.Drawing.Size(51, 36)
        Me.수납ToolStripMenuItem1.Text = "수  납"
        Me.수납ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '미수관리ToolStripMenuItem2
        '
        Me.미수관리ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.미수금조회ToolStripMenuItem, Me.미수금수납ToolStripMenuItem})
        Me.미수관리ToolStripMenuItem2.Image = Global.WindowsApplication1.My.Resources.Resources.진행1
        Me.미수관리ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.미수관리ToolStripMenuItem2.Name = "미수관리ToolStripMenuItem2"
        Me.미수관리ToolStripMenuItem2.Size = New System.Drawing.Size(67, 36)
        Me.미수관리ToolStripMenuItem2.Text = "미수관리"
        Me.미수관리ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.청구빌드ToolStripMenuItem, Me.건강보험심사ToolStripMenuItem, Me.의료급여심사ToolStripMenuItem, Me.산재보험심사ToolStripMenuItem, Me.자동차보험심사ToolStripMenuItem, Me.송신업무ToolStripMenuItem, Me.수신업무ToolStripMenuItem, Me.청구통계ToolStripMenuItem})
        Me.ToolStripMenuItem3.Image = Global.WindowsApplication1.My.Resources.Resources.청구현황1
        Me.ToolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripMenuItem3.Text = "보험청구"
        Me.ToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '진료실ToolStripMenuItem
        '
        Me.진료실ToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.DoctorMale
        Me.진료실ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.진료실ToolStripMenuItem.Name = "진료실ToolStripMenuItem"
        Me.진료실ToolStripMenuItem.Size = New System.Drawing.Size(55, 36)
        Me.진료실ToolStripMenuItem.Text = "진료실"
        Me.진료실ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.WindowsApplication1.My.Resources.Resources.nurse
        Me.ToolStripMenuItem5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(55, 36)
        Me.ToolStripMenuItem5.Text = "치료실"
        Me.ToolStripMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.수납현황ToolStripMenuItem, Me.할인현황ToolStripMenuItem, Me.진료실적ToolStripMenuItem})
        Me.ToolStripMenuItem6.Image = Global.WindowsApplication1.My.Resources.Resources.심사화면1
        Me.ToolStripMenuItem6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripMenuItem6.Text = "자료통계"
        Me.ToolStripMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.수가등록ToolStripMenuItem, Me.사용자등록ToolStripMenuItem, Me.기초자료등록ToolStripMenuItem, Me.병원정보등록ToolStripMenuItem, Me.약속코드등록ToolStripMenuItem})
        Me.ToolStripMenuItem7.Image = Global.WindowsApplication1.My.Resources.Resources.처방
        Me.ToolStripMenuItem7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripMenuItem7.Text = "기초자료"
        Me.ToolStripMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '수가등록ToolStripMenuItem
        '
        Me.수가등록ToolStripMenuItem.Name = "수가등록ToolStripMenuItem"
        Me.수가등록ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.수가등록ToolStripMenuItem.Text = "수가등록"
        '
        '사용자등록ToolStripMenuItem
        '
        Me.사용자등록ToolStripMenuItem.Name = "사용자등록ToolStripMenuItem"
        Me.사용자등록ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.사용자등록ToolStripMenuItem.Text = "사용자등록"
        '
        '기초자료등록ToolStripMenuItem
        '
        Me.기초자료등록ToolStripMenuItem.Name = "기초자료등록ToolStripMenuItem"
        Me.기초자료등록ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.기초자료등록ToolStripMenuItem.Text = "기초자료등록"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMS전송ToolStripMenuItem})
        Me.ToolStripMenuItem9.Image = Global.WindowsApplication1.My.Resources.Resources.재계산
        Me.ToolStripMenuItem9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripMenuItem9.Text = "기타업무"
        Me.ToolStripMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = Global.WindowsApplication1.My.Resources.Resources.종료
        Me.ToolStripMenuItem10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(43, 36)
        Me.ToolStripMenuItem10.Text = "종료"
        Me.ToolStripMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.제증명발급ToolStripMenuItem, Me.제증명발급조회ToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.가퇴원
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 36)
        Me.ToolStripMenuItem1.Text = "제증명"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '제증명발급ToolStripMenuItem
        '
        Me.제증명발급ToolStripMenuItem.Name = "제증명발급ToolStripMenuItem"
        Me.제증명발급ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.제증명발급ToolStripMenuItem.Text = "제증명발급"
        '
        '제증명발급조회ToolStripMenuItem
        '
        Me.제증명발급조회ToolStripMenuItem.Name = "제증명발급조회ToolStripMenuItem"
        Me.제증명발급조회ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.제증명발급조회ToolStripMenuItem.Text = "제증명발급조회"
        '
        '병원정보등록ToolStripMenuItem
        '
        Me.병원정보등록ToolStripMenuItem.Name = "병원정보등록ToolStripMenuItem"
        Me.병원정보등록ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.병원정보등록ToolStripMenuItem.Text = "병원정보등록"
        '
        '약속코드등록ToolStripMenuItem
        '
        Me.약속코드등록ToolStripMenuItem.Name = "약속코드등록ToolStripMenuItem"
        Me.약속코드등록ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.약속코드등록ToolStripMenuItem.Text = "약속코드등록"
        '
        'SMS전송ToolStripMenuItem
        '
        Me.SMS전송ToolStripMenuItem.Name = "SMS전송ToolStripMenuItem"
        Me.SMS전송ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SMS전송ToolStripMenuItem.Text = "SMS전송"
        '
        '수납현황ToolStripMenuItem
        '
        Me.수납현황ToolStripMenuItem.Name = "수납현황ToolStripMenuItem"
        Me.수납현황ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.수납현황ToolStripMenuItem.Text = "수납대장"
        '
        '할인현황ToolStripMenuItem
        '
        Me.할인현황ToolStripMenuItem.Name = "할인현황ToolStripMenuItem"
        Me.할인현황ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.할인현황ToolStripMenuItem.Text = "할인현황"
        '
        '진료실적ToolStripMenuItem
        '
        Me.진료실적ToolStripMenuItem.Name = "진료실적ToolStripMenuItem"
        Me.진료실적ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.진료실적ToolStripMenuItem.Text = "진료실적"
        '
        '미수금조회ToolStripMenuItem
        '
        Me.미수금조회ToolStripMenuItem.Name = "미수금조회ToolStripMenuItem"
        Me.미수금조회ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.미수금조회ToolStripMenuItem.Text = "미수금조회"
        '
        '미수금수납ToolStripMenuItem
        '
        Me.미수금수납ToolStripMenuItem.Name = "미수금수납ToolStripMenuItem"
        Me.미수금수납ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.미수금수납ToolStripMenuItem.Text = "미수금수납"
        '
        '청구빌드ToolStripMenuItem
        '
        Me.청구빌드ToolStripMenuItem.Name = "청구빌드ToolStripMenuItem"
        Me.청구빌드ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.청구빌드ToolStripMenuItem.Text = "청구빌드"
        '
        '건강보험심사ToolStripMenuItem
        '
        Me.건강보험심사ToolStripMenuItem.Name = "건강보험심사ToolStripMenuItem"
        Me.건강보험심사ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.건강보험심사ToolStripMenuItem.Text = "건강보험심사"
        '
        '의료급여심사ToolStripMenuItem
        '
        Me.의료급여심사ToolStripMenuItem.Name = "의료급여심사ToolStripMenuItem"
        Me.의료급여심사ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.의료급여심사ToolStripMenuItem.Text = "의료급여심사"
        '
        '산재보험심사ToolStripMenuItem
        '
        Me.산재보험심사ToolStripMenuItem.Name = "산재보험심사ToolStripMenuItem"
        Me.산재보험심사ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.산재보험심사ToolStripMenuItem.Text = "산재보험심사"
        '
        '자동차보험심사ToolStripMenuItem
        '
        Me.자동차보험심사ToolStripMenuItem.Name = "자동차보험심사ToolStripMenuItem"
        Me.자동차보험심사ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.자동차보험심사ToolStripMenuItem.Text = "자동차보험심사"
        '
        '송신업무ToolStripMenuItem
        '
        Me.송신업무ToolStripMenuItem.Name = "송신업무ToolStripMenuItem"
        Me.송신업무ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.송신업무ToolStripMenuItem.Text = "EDI송신"
        '
        '수신업무ToolStripMenuItem
        '
        Me.수신업무ToolStripMenuItem.Name = "수신업무ToolStripMenuItem"
        Me.수신업무ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.수신업무ToolStripMenuItem.Text = "EDI수신"
        '
        '청구통계ToolStripMenuItem
        '
        Me.청구통계ToolStripMenuItem.Name = "청구통계ToolStripMenuItem"
        Me.청구통계ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.청구통계ToolStripMenuItem.Text = "청구통계"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 777)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "KPICHART"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 접수ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 수납ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 미수관리ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents 진료실ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents 수가등록ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 사용자등록ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 기초자료등록ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 미수금조회ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 미수금수납ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 청구빌드ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 건강보험심사ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 의료급여심사ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 산재보험심사ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 자동차보험심사ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 송신업무ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 수신업무ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 청구통계ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 수납현황ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 할인현황ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 진료실적ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 제증명발급ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 제증명발급조회ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 병원정보등록ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 약속코드등록ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SMS전송ToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnlgn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblregis = New System.Windows.Forms.Label()
        Me.TimerGambarKanan = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGambarKiri = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fotoprofil = New System.Windows.Forms.PictureBox()
        Me.txtKpwR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtEmR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnregis = New System.Windows.Forms.Button()
        Me.txtPwR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNmR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.gbrlogo = New System.Windows.Forms.PictureBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.fotoprofil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(606, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 5
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(741, 759)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(358, 52)
        Me.BunifuMaterialTextbox1.TabIndex = 4
        Me.BunifuMaterialTextbox1.Text = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtuser.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtuser.HintText = "Username"
        Me.txtuser.isPassword = False
        Me.txtuser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtuser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtuser.LineThickness = 6
        Me.txtuser.Location = New System.Drawing.Point(604, 224)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(257, 53)
        Me.txtuser.TabIndex = 5
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtpass
        '
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtpass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtpass.HintText = "Password"
        Me.txtpass.isPassword = False
        Me.txtpass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtpass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtpass.LineThickness = 6
        Me.txtpass.Location = New System.Drawing.Point(604, 288)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(257, 55)
        Me.txtpass.TabIndex = 5
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnlgn
        '
        Me.btnlgn.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnlgn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlgn.FlatAppearance.BorderSize = 0
        Me.btnlgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlgn.Font = New System.Drawing.Font("Gill Sans MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlgn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlgn.Location = New System.Drawing.Point(604, 386)
        Me.btnlgn.Name = "btnlgn"
        Me.btnlgn.Size = New System.Drawing.Size(257, 56)
        Me.btnlgn.TabIndex = 6
        Me.btnlgn.Text = "Login"
        Me.btnlgn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Belum ada akun?"
        '
        'lblregis
        '
        Me.lblregis.AutoSize = True
        Me.lblregis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblregis.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregis.Location = New System.Drawing.Point(758, 473)
        Me.lblregis.Name = "lblregis"
        Me.lblregis.Size = New System.Drawing.Size(92, 29)
        Me.lblregis.TabIndex = 8
        Me.lblregis.Text = "Registrasi"
        '
        'TimerGambarKanan
        '
        Me.TimerGambarKanan.Interval = 5
        '
        'TimerGambarKiri
        '
        Me.TimerGambarKiri.Interval = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(131, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 65)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Registrasi"
        '
        'btnsignin
        '
        Me.btnsignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnsignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignin.FlatAppearance.BorderSize = 0
        Me.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignin.Font = New System.Drawing.Font("Gill Sans MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsignin.Location = New System.Drawing.Point(604, 402)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(257, 56)
        Me.btnsignin.TabIndex = 16
        Me.btnsignin.Text = "Sign-in"
        Me.btnsignin.UseVisualStyleBackColor = False
        Me.btnsignin.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.fotoprofil)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtKpwR)
        Me.Panel1.Controls.Add(Me.txtUsR)
        Me.Panel1.Controls.Add(Me.txtEmR)
        Me.Panel1.Controls.Add(Me.btnregis)
        Me.Panel1.Controls.Add(Me.txtPwR)
        Me.Panel1.Controls.Add(Me.txtNmR)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 657)
        Me.Panel1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(203, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 69)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Pilih Gambar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fotoprofil
        '
        Me.fotoprofil.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.fotoprofil.Location = New System.Drawing.Point(130, 452)
        Me.fotoprofil.Name = "fotoprofil"
        Me.fotoprofil.Size = New System.Drawing.Size(75, 69)
        Me.fotoprofil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoprofil.TabIndex = 27
        Me.fotoprofil.TabStop = False
        '
        'txtKpwR
        '
        Me.txtKpwR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKpwR.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKpwR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtKpwR.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtKpwR.HintText = "Konfirmasi Password"
        Me.txtKpwR.isPassword = False
        Me.txtKpwR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtKpwR.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtKpwR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtKpwR.LineThickness = 5
        Me.txtKpwR.Location = New System.Drawing.Point(130, 362)
        Me.txtKpwR.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtKpwR.Name = "txtKpwR"
        Me.txtKpwR.Size = New System.Drawing.Size(257, 55)
        Me.txtKpwR.TabIndex = 25
        Me.txtKpwR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsR
        '
        Me.txtUsR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUsR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsR.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtUsR.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtUsR.HintText = "Username"
        Me.txtUsR.isPassword = False
        Me.txtUsR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtUsR.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtUsR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtUsR.LineThickness = 6
        Me.txtUsR.Location = New System.Drawing.Point(130, 231)
        Me.txtUsR.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtUsR.Name = "txtUsR"
        Me.txtUsR.Size = New System.Drawing.Size(257, 53)
        Me.txtUsR.TabIndex = 24
        Me.txtUsR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtEmR
        '
        Me.txtEmR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmR.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtEmR.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtEmR.HintText = "E-mail"
        Me.txtEmR.isPassword = False
        Me.txtEmR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtEmR.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtEmR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtEmR.LineThickness = 6
        Me.txtEmR.Location = New System.Drawing.Point(130, 168)
        Me.txtEmR.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtEmR.Name = "txtEmR"
        Me.txtEmR.Size = New System.Drawing.Size(257, 53)
        Me.txtEmR.TabIndex = 23
        Me.txtEmR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnregis
        '
        Me.btnregis.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnregis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregis.FlatAppearance.BorderSize = 0
        Me.btnregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregis.Font = New System.Drawing.Font("Gill Sans MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnregis.Location = New System.Drawing.Point(130, 559)
        Me.btnregis.Name = "btnregis"
        Me.btnregis.Size = New System.Drawing.Size(257, 56)
        Me.btnregis.TabIndex = 22
        Me.btnregis.Text = "Registrasi"
        Me.btnregis.UseVisualStyleBackColor = False
        '
        'txtPwR
        '
        Me.txtPwR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPwR.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtPwR.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtPwR.HintText = "Password"
        Me.txtPwR.isPassword = False
        Me.txtPwR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtPwR.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtPwR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtPwR.LineThickness = 5
        Me.txtPwR.Location = New System.Drawing.Point(130, 295)
        Me.txtPwR.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtPwR.Name = "txtPwR"
        Me.txtPwR.Size = New System.Drawing.Size(257, 55)
        Me.txtPwR.TabIndex = 20
        Me.txtPwR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNmR
        '
        Me.txtNmR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNmR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNmR.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtNmR.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtNmR.HintText = "Nama"
        Me.txtNmR.isPassword = False
        Me.txtNmR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtNmR.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtNmR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtNmR.LineThickness = 6
        Me.txtNmR.Location = New System.Drawing.Point(130, 105)
        Me.txtNmR.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtNmR.Name = "txtNmR"
        Me.txtNmR.Size = New System.Drawing.Size(257, 53)
        Me.txtNmR.TabIndex = 21
        Me.txtNmR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gbrlogo
        '
        Me.gbrlogo.Image = Global.PAVISUAL.My.Resources.Resources.Artboard_1_1
        Me.gbrlogo.Location = New System.Drawing.Point(-2, -25)
        Me.gbrlogo.Name = "gbrlogo"
        Me.gbrlogo.Size = New System.Drawing.Size(500, 700)
        Me.gbrlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrlogo.TabIndex = 0
        Me.gbrlogo.TabStop = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnexit.FlatAppearance.BorderSize = 0
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(910, 3)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(70, 56)
        Me.btnexit.TabIndex = 61
        Me.btnexit.Text = "X"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsignin)
        Me.Controls.Add(Me.gbrlogo)
        Me.Controls.Add(Me.lblregis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnlgn)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fotoprofil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbrlogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnlgn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblregis As Label
    Friend WithEvents TimerGambarKanan As Timer
    Friend WithEvents TimerGambarKiri As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsignin As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents fotoprofil As PictureBox
    Friend WithEvents txtKpwR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtEmR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnregis As Button
    Friend WithEvents txtPwR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNmR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnexit As Button
End Class

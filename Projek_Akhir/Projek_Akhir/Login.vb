Imports System.IO
Imports Bunifu.Framework.UI
Imports MySql.Data.MySqlClient

Public Class Login

    Private WithEvents transitionTimer As New Timer()

    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
        txtNmR.Text = ""
        txtEmR.Text = ""
        txtUsR.Text = ""
        txtPwR.Text = ""
        txtKpwR.Text = ""
        txtKpwR.HintText = "Konfirmasi Password"
        txtPwR.HintText = "Password"
        txtpass.HintText = "Password"
        fotoprofil.Image = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb In New List(Of BunifuMaterialTextbox)({txtNmR, txtEmR, txtUsR, txtuser})
            AddHandler tb.Leave, AddressOf coba
        Next
        btnsignin.Visible = False
        koneksi()
    End Sub
    Sub coba()
        For Each tb In New List(Of BunifuMaterialTextbox)({txtNmR, txtEmR, txtUsR, txtuser})
            If String.IsNullOrWhiteSpace(tb.Text) Then
                tb.Text = ""
            End If
        Next
    End Sub
    Private Sub txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter, txtPwR.Enter
        For Each tb In New List(Of BunifuMaterialTextbox)({txtPwR, txtpass})
            If tb.HintText = "Password" Then
                tb.HintText = ""
                tb.Text = ""
                tb.isPassword = True
            End If
        Next
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave, txtPwR.Leave
        For Each tb In New List(Of BunifuMaterialTextbox)({txtPwR, txtpass})
            If tb.Text = "" Then
                tb.Text = "Password"
                tb.HintText = "Password"
                tb.isPassword = False
            End If
        Next
    End Sub

    Private Sub txtkpwr_Enter(sender As Object, e As EventArgs) Handles txtKpwR.Enter
        If txtKpwR.HintText = "Konfirmasi Password" Then
            txtKpwR.HintText = ""
            txtKpwR.Text = ""
            txtKpwR.isPassword = True
        End If
    End Sub

    Private Sub txtkpwr_Leave(sender As Object, e As EventArgs) Handles txtKpwR.Leave
        If txtKpwR.Text = "" Then
            txtKpwR.HintText = "Konfirmasi Password"
            txtKpwR.Text = "Konfirmasi Password"
            txtKpwR.isPassword = False
        End If
    End Sub

    Private Sub lblregis_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles lblregis.MouseHover
        lblregis.ForeColor = Color.FromArgb(190, 30, 45)
    End Sub

    Private Sub lblregis_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblregis.MouseLeave
        lblregis.ForeColor = Color.Black
    End Sub

    Private Sub lblregis_Click(sender As Object, e As EventArgs) Handles lblregis.Click
        TimerGambarKanan.Enabled = True
    End Sub

    Private Sub TimerGambarKanan_Tick(sender As Object, e As EventArgs) Handles TimerGambarKanan.Tick
        Dim targetX As Integer = Me.Width / 2
        Dim currentX As Integer = gbrlogo.Location.X
        If currentX < targetX Then
            currentX += 20
            If currentX > targetX Then
                currentX = targetX
            End If
            gbrlogo.Location = New Point(currentX, gbrlogo.Location.Y)
        Else
            transitionTimer.Stop()
            TimerGambarKanan.Enabled = False
            btnsignin.Visible = True
        End If
    End Sub

    Private Function cekInputReg() As Boolean
        For Each txt In Panel1.Controls.OfType(Of BunifuMaterialTextbox)
            If (txt.Text = "") Then
                MessageBox.Show("Mohon Isi Semua", "Konfirmasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        TimerGambarKiri.Enabled = True
        bersih()
        btnlgn.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregis.Click
        Dim nama, email, username, password, cpassword, gambar As String
        If cekInputReg() = False Then
            Exit Sub
        End If

        nama = txtNmR.Text
        email = txtEmR.Text
        username = txtUsR.Text
        password = txtPwR.Text
        cpassword = txtKpwR.Text

        Dim namaFile As String = Path.GetFileName(OpenFileDialog1.FileName)
        If namaFile = "OpenFileDialog1" Then
            namaFile = "default.png"
        End If

        Dim query As String = "Select * From tbakun where username='" & username & "' or email='" & email & "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        RD.Close()

        If Not RD.HasRows Then
            Dim pathProject As String = AppDomain.CurrentDomain.BaseDirectory
            Dim profileFolder As String = pathProject.Replace("\bin\Debug\", "\profile\")
            Dim ex As String = ""

            Dim i As Integer = namaFile.LastIndexOf(".")
            If (i > 0) Then
                ex = namaFile.Substring(i + 1)
            End If

            If namaFile = "default.png" Then
                File.Copy(pathProject.Replace("\bin\Debug\", "\profile\") + namaFile, profileFolder + txtEmR.Text + "." + ex)
            Else
                File.Copy(Path.GetFullPath(OpenFileDialog1.FileName), profileFolder + txtEmR.Text + "." + ex)
            End If

            Dim simpan As String = "insert into tbakun values ('','" & nama & "','" & email & "','" & username & "','" & password & "','" & txtEmR.Text + "." + ex & "')"
            CMD = New MySqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Simpan berhasil", MsgBoxStyle.Information, "Perhatian")
        Else
            MsgBox("Username Telah Digunakan")
            txtUsR.Focus()
        End If
        TimerGambarKiri.Enabled = True
        bersih()
    End Sub

    Private Sub TimerGambarKiri_Tick(sender As Object, e As EventArgs) Handles TimerGambarKiri.Tick
        Dim targetX As Integer = -2
        Dim currentX As Integer = gbrlogo.Location.X
        If currentX > targetX Then
            currentX -= 20
            If currentX < targetX Then
                currentX = targetX
            End If
            gbrlogo.Location = New Point(currentX, gbrlogo.Location.Y)
            btnsignin.Visible = False
        Else
            transitionTimer.Stop()
            TimerGambarKiri.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        '"Image Files|*.jpg|*.png|*.bmp"
        OpenFileDialog1.Filter = "Image Files|*png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim namaFile As String = Path.GetFileName(OpenFileDialog1.FileName)

            fotoprofil.ImageLocation = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub btnlgn_Click(sender As Object, e As EventArgs) Handles btnlgn.Click
        Dim username, password, query As String

        username = txtuser.Text
        password = txtpass.Text

        query = "Select * from tbakun where username='" + username + "' and password='" + password + "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        If RD.HasRows Then
            Dim profileFolder As String
            Dim pathProject As String = AppDomain.CurrentDomain.BaseDirectory
            profileFolder = pathProject.Replace("\bin\Debug\", "\profile\")
            Dim img As Image
            bersih()
            Me.Hide()
            If (username = "Admin") Then
                FormAdmin.Label2.Text = username
                FormAdmin.PictureBox5.Image = Image.FromFile(profileFolder + RD.Item(5))
                RD.Close()
                FormAdmin.Show()
            Else
                FormUser.iduser.Text = RD.Item(0)
                FormUser.Label2.Text = username
                FormUser.PictureBox5.Image = Image.FromFile(profileFolder + RD.Item(5))
                RD.Close()
                FormUser.Show()
            End If
        Else
            MessageBox.Show("Username atau Password Salah", "Konfirmasi",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtuser.Focus()
            RD.Close()
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result As DialogResult = MessageBox.Show("Keluar dari Aplikasi?", "Konfirmasi Keluar",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class

Imports System.Drawing.Printing
Imports Bunifu.Framework.UI
Imports MySql.Data.MySqlClient

Public Class FormAdmin
    Dim PrintDocument1 As New PrintDocument()
    Dim PrintPreviewDialog1 As New PrintPreviewDialog()
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btntambah.BackColor = Color.FromArgb(152, 24, 36)
        koneksi()
        tampilsosis()
        tampilnugget()
        tampilriwayat()

        AddHandler PrintDocument1.PrintPage, AddressOf printDocument1_PrintPage
        AddHandler PrintDocument1.BeginPrint, AddressOf PD_BeginPrint
        PrintPreviewDialog1.Document = PrintDocument1

        For Each tb In New List(Of BunifuMaterialTextbox)({txtstok, txtharga, txtberat})
            AddHandler tb.KeyPress, AddressOf txt_Keypress
        Next
    End Sub


    Private Sub gv_Paint(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles GVnugget.CellPainting, GVsosis.CellPainting, GVriwayat.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single
    End Sub

    Private Sub sosis_paint(sender As Object, e As PaintEventArgs) Handles btnsosis.Paint
        e.Graphics.DrawImage(PictureBox2.Image, CInt(btnsosis.Width / 1.4), CInt(btnsosis.Height / 2.2), CInt(btnsosis.Width / 8), CInt(btnsosis.Height / 3.5))
        e.Graphics.DrawImage(PictureBox3.Image, CInt(btnsosis.Width / 2.7), CInt(btnsosis.Height / 4.2), CInt(btnsosis.Width / 3.5), CInt(btnsosis.Height / 1.75))
        e.Graphics.DrawImage(PictureBox4.Image, CInt(btnsosis.Width / 7.3), CInt(btnsosis.Height / 3.2), CInt(btnsosis.Width / 6), CInt(btnsosis.Height / 2.5))
    End Sub

    Private Sub nugget_paint(sender As Object, e As PaintEventArgs) Handles btnnugget.Paint
        e.Graphics.DrawImage(PictureBox7.Image, CInt(btnnugget.Width / 7.2), CInt(btnnugget.Height / 4.2), CInt(btnnugget.Height / 3.2), CInt(btnnugget.Height / 3.2))
        e.Graphics.DrawImage(PictureBox8.Image, CInt(btnnugget.Width / 1.6), CInt(btnnugget.Height / 2), CInt(btnnugget.Height / 7), CInt(btnnugget.Height / 7))
        e.Graphics.DrawImage(PictureBox9.Image, CInt(btnnugget.Width / 5), CInt(btnnugget.Height / 1.7), CInt(btnnugget.Height / 5), CInt(btnnugget.Height / 5))
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        For Each txt In PanelTambahData.Controls
            If TypeOf (txt) Is Bunifu.Framework.UI.BunifuMaterialTextbox Then
                txt.Text = ""
            End If
        Next
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        btntambah.BackColor = Color.FromArgb(152, 24, 36)
        btnlihat.BackColor = Color.FromArgb(190, 30, 45)
        btnriwayat.BackColor = Color.FromArgb(190, 30, 45)
        PanelLihatData.Visible = False
        PanelTambahData.Visible = False
        PanelRiwayat.Visible = False
        PanelTambah_Pilih.Visible = True
        btnclr_Click(sender, e)
    End Sub

    Private Sub btnlihat_Click(sender As Object, e As EventArgs) Handles btnlihat.Click
        btntambah.BackColor = Color.FromArgb(190, 30, 45)
        btnlihat.BackColor = Color.FromArgb(152, 24, 36)
        btnriwayat.BackColor = Color.FromArgb(190, 30, 45)
        PanelRiwayat.Visible = False
        PanelTambah_Pilih.Visible = False
        PanelTambahData.Visible = False
        PanelLihatData.Visible = True
        tampilsosis()
    End Sub

    Private Sub btnriwayat_Click(sender As Object, e As EventArgs) Handles btnriwayat.Click
        btntambah.BackColor = Color.FromArgb(190, 30, 45)
        btnlihat.BackColor = Color.FromArgb(190, 30, 45)
        btnriwayat.BackColor = Color.FromArgb(152, 24, 36)
        PanelTambah_Pilih.Visible = False
        PanelTambahData.Visible = False
        PanelLihatData.Visible = False
        PanelRiwayat.Visible = True
        tampilriwayat()
    End Sub

    Sub show_gambar_nugget()
        Dim nugget As New List(Of PictureBox)({nugget1, nugget2, nugget3, nugget4})
        For Each gambar In nugget
            gambar.Visible = True
        Next
    End Sub

    Sub hide_gambar_nugget()
        Dim nugget As New List(Of PictureBox)({nugget1, nugget2, nugget3, nugget4})
        For Each gambar In nugget
            gambar.Visible = False
        Next
    End Sub

    Sub show_gambar_sosis()
        Dim sosis As New List(Of PictureBox)({sosis1, sosis2, sosis3, sosis4})
        For Each gambar In sosis
            gambar.Visible = True
        Next
    End Sub

    Sub hide_gambar_sosis()
        Dim sosis As New List(Of PictureBox)({sosis1, sosis2, sosis3, sosis4})
        For Each gambar In sosis
            gambar.Visible = False
        Next
    End Sub

    Private Sub btnsosis_Click(sender As Object, e As EventArgs) Handles btnsosis.Click
        PanelTambah_Pilih.Visible = False
        labeltambah.Text = "Tambah Produk"
        labeltambah.Location = New Point(10, labeltambah.Location.Y)
        btnadd.Text = "Add Data"
        PanelTambahData.Visible = True
        cbbentuk.Visible = False
        cbpanjang.Visible = True

        show_gambar_sosis()
        hide_gambar_nugget()

        Dim pensil As New List(Of PictureBox)({pensil1, pensil2, pensil3, pensil4})
        For Each gambar In pensil
            gambar.Visible = False
        Next
    End Sub

    Private Sub btnnugget_Click(sender As Object, e As EventArgs) Handles btnnugget.Click
        PanelTambah_Pilih.Visible = False
        PanelTambahData.Visible = True
        cbbentuk.Visible = True
        cbpanjang.Visible = False

        show_gambar_nugget()
        hide_gambar_sosis()

        Dim pensil As New List(Of PictureBox)({pensil1, pensil2, pensil3, pensil4})
        For Each gambar In pensil
            gambar.Visible = False
        Next
    End Sub

    Sub tampilsosis()
        GVsosis.Rows.Clear()
        Dim query As String = "Select * From tbproduk where jenis = 'sosis'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            Dim i As Integer = 0
            Do While RD.Read()
                GVsosis.Rows.Add()
                GVsosis.Rows(i).Cells(0).Value = RD(0)
                GVsosis.Rows(i).Cells(1).Value = RD(1)
                GVsosis.Rows(i).Cells(2).Value = RD(2)
                GVsosis.Rows(i).Cells(3).Value = RD(3).ToString() + " g"
                GVsosis.Rows(i).Cells(4).Value = RD(4)
                GVsosis.Rows(i).Cells(5).Value = "Rp " + RD(5).ToString()
                GVsosis.Rows(i).Cells(6).Value = RD(6).ToString() + " cm"
                i += 1
            Loop
            RD.Close()
        Else
            RD.Close()
        End If
    End Sub
    Sub tampilnugget()
        GVnugget.Rows.Clear()
        Dim query As String = "Select * From tbproduk where jenis = 'nugget'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            Dim i As Integer = 0
            Do While RD.Read()
                GVnugget.Rows.Add()
                GVnugget.Rows(i).Cells(0).Value = RD(0)
                GVnugget.Rows(i).Cells(1).Value = RD(1)
                GVnugget.Rows(i).Cells(2).Value = RD(2)
                GVnugget.Rows(i).Cells(3).Value = RD(3).ToString() + " g"
                GVnugget.Rows(i).Cells(4).Value = RD(4)
                GVnugget.Rows(i).Cells(5).Value = "Rp " + RD(5).ToString()
                GVnugget.Rows(i).Cells(6).Value = RD(7)
                i += 1
            Loop
            RD.Close()
        Else
            RD.Close()
        End If
    End Sub

    Sub tampilriwayat()
        GVriwayat.Rows.Clear()

        Dim query As String = "SELECT * FROM tborder WHERE dibayar=1"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            Dim i As Integer = 0
            Do While RD.Read()
                GVriwayat.Rows.Add()
                GVriwayat.Rows(i).Cells(0).Value = RD(0)
                GVriwayat.Rows(i).Cells(1).Value = RD(1)
                GVriwayat.Rows(i).Cells(2).Value = String.Format("{0:dd-MM-yyyy}", RD(4))
                GVriwayat.Rows(i).Cells(3).Value = RD(2)
                GVriwayat.Rows(i).Cells(4).Value = RD(3)
                i += 1
            Loop
            RD.Close()
        Else
            RD.Close()
        End If
    End Sub

    Private Sub btndatasos_Click(sender As Object, e As EventArgs) Handles btndatasos.Click
        labellihat.Text = "Data Produk Sosis"
        labellihat.Location = New Point(42, labellihat.Location.Y)
        Panel5.Visible = True
        Panel6.Visible = False
        tampilsosis()
    End Sub

    Private Sub btndatanug_Click(sender As Object, e As EventArgs) Handles btndatanug.Click
        labellihat.Text = "Data Produk Nugget"
        labellihat.Location = New Point(15, labellihat.Location.Y)
        Panel5.Visible = False
        Panel6.Visible = True
        tampilnugget()
    End Sub

    Private Sub btnhps_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        Dim rowIndex As Integer
        Dim id, nama As String

        If GVsosis.Visible = True Then
            rowIndex = GVsosis.CurrentRow.Index
            id = GVsosis.Rows(rowIndex).Cells(0).Value.ToString()
            nama = GVsosis.Rows(rowIndex).Cells(1).Value.ToString()
        Else
            rowIndex = GVnugget.CurrentRow.Index
            id = GVnugget.Rows(rowIndex).Cells(0).Value.ToString()
            nama = GVnugget.Rows(rowIndex).Cells(1).Value.ToString()
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus " & nama & "?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CMD = New MySqlCommand("DELETE FROM tbproduk WHERE id_produk='" & id & "'", CONN)
            CMD.ExecuteNonQuery()
            tampilnugget()
            tampilsosis()
        End If
    End Sub

    Dim id As Integer
    Dim tempNama, tempBahan, tempBentuk, jenis As String
    Dim tempBerat As Integer = 0
    Dim tempStok As Integer = 0
    Dim tempHarga As Integer = 0
    Dim tempPanjang As Double

    Sub setPrompEdit()
        txtnama.Text = "Nama : " & tempNama
        txtbahan.Text = "Bahan : " & tempBahan
        txtberat.Text = "Berat : " & tempBerat
        txtstok.Text = "Stok : " & tempStok
        txtharga.Text = "Harga : " & tempHarga

        If GVsosis.Visible = True Then
            cbpanjang.Text = tempPanjang & ".0"
        Else
            cbbentuk.Text = tempBentuk
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim edit = False
        If GVsosis.Visible = True Then
            If GVsosis.RowCount > 0 Then
                Dim rowIndex As Integer = GVsosis.CurrentRow.Index
                If rowIndex > -1 Then
                    cbbentuk.Visible = False
                    cbpanjang.Visible = True

                    id = GVsosis.Rows(rowIndex).Cells(0).Value
                    tempNama = GVsosis.Rows(rowIndex).Cells(1).Value.ToString()
                    tempBahan = GVsosis.Rows(rowIndex).Cells(2).Value.ToString()
                    tempBerat = GVsosis.Rows(rowIndex).Cells(3).Value.ToString().Split(" "c)(0)
                    tempStok = GVsosis.Rows(rowIndex).Cells(4).Value
                    tempHarga = GVsosis.Rows(rowIndex).Cells(5).Value.ToString().Split(" "c)(1)
                    tempPanjang = GVsosis.Rows(rowIndex).Cells(6).Value.ToString().Split(" "c)(0)
                    jenis = "sosis"
                    setPrompEdit()
                    edit = True
                End If
            End If
        Else
            If GVnugget.RowCount > 0 Then
                Dim rowIndex As Integer = GVnugget.CurrentRow.Index
                If rowIndex > -1 Then
                    cbbentuk.Visible = True
                    cbpanjang.Visible = False

                    id = GVnugget.Rows(rowIndex).Cells(0).Value
                    tempNama = GVnugget.Rows(rowIndex).Cells(1).Value.ToString()
                    tempBahan = GVnugget.Rows(rowIndex).Cells(2).Value.ToString()
                    tempBerat = GVnugget.Rows(rowIndex).Cells(3).Value.ToString().Split(" "c)(0)
                    tempStok = GVnugget.Rows(rowIndex).Cells(4).Value
                    tempHarga = GVnugget.Rows(rowIndex).Cells(5).Value.ToString().Split(" "c)(1)
                    tempBentuk = GVnugget.Rows(rowIndex).Cells(6).Value.ToString()
                    jenis = "nugget"
                    setPrompEdit()
                    edit = True
                End If
            End If
        End If

        If edit Then
            PanelLihatData.Visible = False
            PanelTambahData.Visible = True
            labeltambah.Text = "Edit Produk"
            labeltambah.Location = New Point(35, labeltambah.Location.Y)
            btnadd.Text = "Save Data"

            Dim pensil As New List(Of PictureBox)({pensil1, pensil2, pensil3, pensil4})
            For Each gambar In pensil
                gambar.Visible = True
            Next

            hide_gambar_nugget()
            hide_gambar_sosis()
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If pensil1.Visible = True Then
            Dim newNama As String = txtnama.Text
            Dim newBahan As String = txtbahan.Text
            Dim newBeratStr As String = txtberat.Text
            Dim newBerat As Integer
            Dim newStokStr As String = txtstok.Text
            Dim newStok As Integer
            Dim newHargaStr As String = txtharga.Text
            Dim newHarga As Integer

            If jenis = "sosis" Then
                Dim newPanjang As Double = Val(cbpanjang.Text)
                If String.IsNullOrWhiteSpace(newNama) Or newNama = "" Or newNama = "Nama : " & tempNama Then
                    newNama = tempNama
                End If
                If newBahan = "" Or newBahan = "Bahan : " & tempBahan Then
                    newBahan = tempBahan
                End If
                If newBeratStr = "" Or newBeratStr = "Berat : " & tempBerat Then
                    newBerat = tempBerat
                Else
                    newBerat = txtberat.Text
                End If
                If newStokStr = "" Or newStokStr = "Stok : " & tempStok Then
                    newStok = tempStok
                Else
                    newStok = txtstok.Text
                End If
                If newHargaStr = "" Or newHargaStr = "Harga : " & tempHarga Then
                    newHarga = tempHarga
                Else
                    newHarga = txtharga.Text
                End If

                CMD = New MySqlCommand("UPDATE tbproduk SET nama=@2,bahan=@3,berat=@4,stok=@5,harga=@6,panjang=@7,jenis='sosis' where id_produk=@1", CONN)
                CMD.Parameters.AddWithValue("@1", id)
                CMD.Parameters.AddWithValue("@2", newNama)
                CMD.Parameters.AddWithValue("@3", newBahan)
                CMD.Parameters.AddWithValue("@4", newBerat)
                CMD.Parameters.AddWithValue("@5", newStok)
                CMD.Parameters.AddWithValue("@6", newHarga)
                CMD.Parameters.AddWithValue("@7", newPanjang)
                CMD.ExecuteNonQuery()

                tampilsosis()

                btnclr_Click(sender, e)
                btnlihat_Click(sender, e)
                btndatasos_Click(sender, e)
            Else
                Dim newBentuk As String = cbbentuk.Text
                If newNama = "" Or newNama = "Nama : " & tempNama Then
                    newNama = tempNama
                End If
                If newBahan = "" Or newBahan = "Bahan : " & tempBahan Then
                    newBahan = tempBahan
                End If
                If newBeratStr = "" Or newBeratStr = "Berat : " & tempBerat Then
                    newBerat = tempBerat
                Else
                    newBerat = txtberat.Text
                End If
                If newStokStr = "" Or newStokStr = "Stok : " & tempStok Then
                    newStok = tempStok
                Else
                    newStok = txtstok.Text
                End If
                If newHargaStr = "" Or newHargaStr = "Harga : " & tempHarga Then
                    newHarga = tempHarga
                Else
                    newHarga = txtharga.Text
                End If
                tes.Show()
                CMD = New MySqlCommand("UPDATE tbproduk SET nama=@2,bahan=@3,berat=@4,stok=@5,harga=@6,bentuk=@7,jenis='nugget' where id_produk=@1", CONN)
                CMD.Parameters.AddWithValue("@1", id)
                CMD.Parameters.AddWithValue("@2", newNama)
                CMD.Parameters.AddWithValue("@3", newBahan)
                CMD.Parameters.AddWithValue("@4", newBerat)
                CMD.Parameters.AddWithValue("@5", newStok)
                CMD.Parameters.AddWithValue("@6", newHarga)
                CMD.Parameters.AddWithValue("@7", newBentuk)
                CMD.ExecuteNonQuery()

                tampilnugget()

                btnclr_Click(sender, e)
                btnlihat_Click(sender, e)
                btndatanug_Click(sender, e)
            End If
        Else
            Dim panjang As Double
            panjang = Val(cbpanjang.Text)
            If cbpanjang.Visible = True Then
                CMD = New MySqlCommand("INSERT INTO tbproduk(nama, bahan, berat, stok, harga, panjang, jenis) VALUES (@1,@2,@3,@4,@5,@6,@7)", CONN)
                CMD.Parameters.AddWithValue("@1", txtnama.Text)
                CMD.Parameters.AddWithValue("@2", txtbahan.Text)
                CMD.Parameters.AddWithValue("@3", txtberat.Text)
                CMD.Parameters.AddWithValue("@4", txtstok.Text)
                CMD.Parameters.AddWithValue("@5", txtharga.Text)
                CMD.Parameters.AddWithValue("@6", panjang)
                CMD.Parameters.AddWithValue("@7", "sosis")
                CMD.ExecuteNonQuery()

                MsgBox("Tambah Data Sosis Berhasil", MsgBoxStyle.Information, "INPUT BERHASIL!")
                tampilsosis()
            ElseIf cbbentuk.Visible = True Then
                Dim berat, stok, harga As Integer
                berat = txtberat.Text
                stok = txtstok.Text
                harga = txtharga.Text
                CMD = New MySqlCommand("INSERT INTO tbproduk(nama, bahan, berat, stok, harga, bentuk, jenis) VALUES (@1,@2,@3,@4,@5,@6,@7)", CONN)
                CMD.Parameters.AddWithValue("@1", txtnama.Text)
                CMD.Parameters.AddWithValue("@2", txtbahan.Text)
                CMD.Parameters.AddWithValue("@3", txtberat.Text)
                CMD.Parameters.AddWithValue("@4", txtstok.Text)
                CMD.Parameters.AddWithValue("@5", txtharga.Text)
                CMD.Parameters.AddWithValue("@6", cbbentuk.Text)
                CMD.Parameters.AddWithValue("@7", "nugget")
                CMD.ExecuteNonQuery()

                MsgBox("Tambah Data Nugget Berhasil", MsgBoxStyle.Information, "INPUT BERHASIL!")
                tampilnugget()
            End If
        End If
    End Sub

    Private Sub txt_Keypress(sender As Object, e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin Logout? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub


    Private Sub txtnama_Enter(sender As Object, e As EventArgs) Handles txtnama.Enter
        If pensil1.Visible = True Then
            If txtnama.Text = "Nama : " & tempNama Then
                txtnama.Text = ""
            End If
        End If
    End Sub
    Private Sub txtnama_Leave(sender As Object, e As EventArgs) Handles txtnama.Leave
        If pensil1.Visible = True Then
            If txtnama.Text = "" Then
                txtnama.Text = "Nama : " & tempNama
            End If
        End If
    End Sub

    Private Sub txtbahan_Enter(sender As Object, e As EventArgs) Handles txtbahan.Enter
        If pensil1.Visible = True Then
            If txtbahan.Text = "Bahan : " & tempBahan Then
                txtbahan.Text = ""
            End If
        End If
    End Sub
    Private Sub txtbahan_Leave(sender As Object, e As EventArgs) Handles txtbahan.Leave
        If pensil1.Visible = True Then
            If txtbahan.Text = "" Then
                txtbahan.Text = "Bahan : " & tempBahan
            End If
        End If
    End Sub

    Private Sub txtberat_Enter(sender As Object, e As EventArgs) Handles txtberat.Enter
        If pensil1.Visible = True Then
            If txtberat.Text = "Berat : " & tempBerat Then
                txtberat.Text = ""
            End If
        End If
    End Sub
    Private Sub txtberat_Leave(sender As Object, e As EventArgs) Handles txtberat.Leave
        If pensil1.Visible = True Then
            If txtberat.Text = "" Then
                txtberat.Text = "Berat : " & tempBerat
            End If
        End If
    End Sub

    Private Sub txtstok_Enter(sender As Object, e As EventArgs) Handles txtstok.Enter
        If pensil1.Visible = True Then
            If txtstok.Text = "Stok : " & tempStok Then
                txtstok.Text = ""
            End If
        End If
    End Sub

    Private Sub cb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbpanjang.KeyPress, cbbentuk.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtstok_Leave(sender As Object, e As EventArgs) Handles txtstok.Leave
        If pensil1.Visible = True Then
            If txtstok.Text = "" Then
                txtstok.Text = "Stok : " & tempStok
            End If
        End If
    End Sub

    Private Sub txtharga_Enter(sender As Object, e As EventArgs) Handles txtharga.Enter
        If pensil1.Visible = True Then
            If txtharga.Text = "Harga : " & tempHarga Then
                txtharga.Text = ""
            End If
        End If
    End Sub

    Private Sub txtharga_Leave(sender As Object, e As EventArgs) Handles txtharga.Leave
        If pensil1.Visible = True Then
            If txtharga.Text = "" Then
                txtharga.Text = "Harga : " & tempHarga
            End If
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result As DialogResult = MessageBox.Show("Keluar dari Aplikasi?", "Konfirmasi Keluar",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs)
        Dim pagesetup As New PageSettings
        Dim pagew = 400
        Dim pageh = 195

        Dim rowIndex = GVriwayat.CurrentRow.Index
        Dim id_order = GVriwayat.Rows(rowIndex).Cells(0).Value

        Dim query As String = "SELECT * FROM tbkeranjang WHERE id_order='" & id_order & "'"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            While RD.Read()
                pageh += 25
            End While
        End If

        RD.Close()

        pagesetup.PaperSize = New PaperSize("Custom", pagew, pageh)
        PrintDocument1.DefaultPageSettings = pagesetup
    End Sub
    Private Sub printDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim rowIndex = GVriwayat.CurrentRow.Index
        Dim id_order = GVriwayat.Rows(rowIndex).Cells(0).Value
        Dim nama = GVriwayat.Rows(rowIndex).Cells(1).Value.ToString()

        Dim f8 As New Font("Gill Sans MT", 12, FontStyle.Regular)
        Dim fb As New Font("Gill Sans MT", 12, FontStyle.Bold)

        Dim p As Pen = New Pen(Color.FromArgb(190, 30, 45))
        Dim brush As New SolidBrush(Color.FromArgb(190, 30, 45))

        Dim panjang As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Height
        Dim lebar As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width
        Dim tengah As Integer = (lebar - 120) / 2

        Dim query As String = "Select tp.nama, tk.jumlah, tk.harga, tp.jenis, tord.tanggal, ta.nama FROM tbkeranjang tk 
                               INNER JOIN tbproduk tp ON tk.id_produk = tp.id_produk
                               INNER JOIN tborder tord ON tk.id_order = tord.id_order
                               INNER JOIN tbakun ta ON tk.id_akun = ta.id_akun
                               WHERE tk.id_order='" & id_order & "'"

        Dim center As New StringFormat
        center.Alignment = StringAlignment.Center

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        Dim rec As Rectangle = New Rectangle(0, 0, lebar, 70)
        e.Graphics.FillRectangle(brush, rec)

        If RD.HasRows Then
            e.Graphics.DrawString("Nama Produk", fb, brush, 20, 75)
            e.Graphics.DrawString("Jumlah", fb, brush, 220, 75)
            e.Graphics.DrawString("Harga", fb, brush, 300, 75)
            Dim rect As New Rectangle(0, 105, lebar, 1)
            e.Graphics.FillRectangle(brush, rect)
            Dim awal = 110
            Dim i = 1
            Dim total = 0

            While RD.Read()
                PrintDocument1.DefaultPageSettings.PaperSize.Height += 100
                e.Graphics.DrawString(i.ToString() + ". " + RD.Item(0) + " (" + RD.Item(3) + ")", f8, brush, 20, awal)
                e.Graphics.DrawString(RD.Item(1).ToString() + " pcs", f8, brush, 220, awal)
                e.Graphics.DrawString("Rp " + RD.Item(2).ToString(), f8, brush, 300, awal)
                awal += 25
                i += 1
                total += RD.Item(2)
            End While

            rect.Y = awal + 5
            e.Graphics.FillRectangle(brush, rect)
            e.Graphics.DrawString("Total Harga", f8, brush, 20, awal + 10)
            e.Graphics.DrawString(":", f8, brush, 220, awal + 10)
            e.Graphics.DrawString("Rp " + total.ToString(), f8, brush, 300, awal + 10)

            e.Graphics.FillRectangle(brush, New Rectangle(0, panjang - 40, lebar, 40))
            e.Graphics.DrawString(String.Format("{0:dd-MM-yyyy}", RD.Item(4)), fb, Brushes.White, 290, awal + 55)
            e.Graphics.DrawString(RD.Item(5), fb, Brushes.White, 20, awal + 55)
        End If
        RD.Close()

        Dim logoImage As Image = My.Resources.Asset_12
        e.Graphics.DrawImage(logoImage, tengah, 20, 120, 30)
    End Sub

    Private Sub printstruk(sender As Object, e As EventArgs) Handles btnstruk.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class

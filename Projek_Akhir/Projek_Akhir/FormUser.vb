Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormUser
    Private Sub gv_Paint(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles GVnugget.CellPainting, GVsosis.CellPainting, GVkeranjang.CellPainting, GVriwayat.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single
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

    Private Sub btnkeranjang_Click(sender As Object, e As EventArgs) Handles btnkeranjang.Click
        PanelProduk.Visible = False
        PanelRiwayat.Visible = False
        PanelKeranjang.Visible = True
        bersih()
        tampilkeranjang()
        GVkeranjang.ClearSelection()
    End Sub

    Private Sub btnproduk_Click(sender As Object, e As EventArgs) Handles btnproduk.Click
        PanelKeranjang.Visible = False
        PanelRiwayat.Visible = False
        PanelProduk.Visible = True
        bersih()
    End Sub

    Private Sub btnriwayat_Click(sender As Object, e As EventArgs) Handles btnriwayat.Click
        PanelKeranjang.Visible = False
        PanelProduk.Visible = False
        PanelRiwayat.Visible = True
        bersih()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin Logout? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Sub bersih()
        txtjumlah.Text = ""
        txtnamaproduk.Text = ""
        txtjumlah.Enabled = False
    End Sub

    Sub tampilsosis()
        GVsosis.Rows.Clear()
        Dim query As String = "Select * From tbproduk WHERE jenis LIKE 'sosis' AND nama LIKE '%" & cari & "%'"
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

            If GVsosis.RowCount > 0 Then
                For Each row As DataGridViewRow In GVsosis.Rows
                    If row.Cells(4).Value = 0 Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(190, 30, 45)
                        row.DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End If
        Else
            RD.Close()
        End If
    End Sub
    Sub tampilnugget()
        GVnugget.Rows.Clear()
        Dim query As String = "Select * From tbproduk WHERE jenis LIKE 'nugget' AND nama LIKE '%" & cari & "%'"
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

    Sub tampilkeranjang()
        GVkeranjang.Rows.Clear()
        ambil_order()

        Dim query As String = "Select tk.id_produk, tp.nama, tk.jumlah, tk.harga FROM tbkeranjang tk 
                               INNER JOIN tbproduk tp ON tk.id_produk = tp.id_produk 
                               WHERE tk.id_order='" & id_order & "' AND tk.id_akun='" & iduser.Text & "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            Dim i As Integer = 0
            Do While RD.Read()
                GVkeranjang.Rows.Add()
                GVkeranjang.Rows(i).Cells(0).Value = RD(0)
                GVkeranjang.Rows(i).Cells(1).Value = RD(1)
                GVkeranjang.Rows(i).Cells(2).Value = RD(2)
                GVkeranjang.Rows(i).Cells(3).Value = RD(3)
                i += 1
            Loop
            RD.Close()
        Else
            RD.Close()
        End If

        If GVkeranjang.RowCount > index_keranjang Then
            GVkeranjang.Rows(index_keranjang).Selected = True
        End If
        hitungtotal()
    End Sub

    Sub tampilriwayat()
        GVriwayat.Rows.Clear()

        Dim query As String = "SELECT * FROM tborder WHERE id_akun='" & iduser.Text & "' AND dibayar=1"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            Dim i As Integer = 0
            Do While RD.Read()
                GVriwayat.Rows.Add()
                GVriwayat.Rows(i).Cells(0).Value = RD(0)
                GVriwayat.Rows(i).Cells(1).Value = String.Format("{0:dd-MM-yyyy}", RD(4))
                GVriwayat.Rows(i).Cells(2).Value = RD(3)
                GVriwayat.Rows(i).Cells(3).Value = RD(2)
                i += 1
            Loop
            RD.Close()
        Else
            RD.Close()
        End If
    End Sub

    Sub updategv()
        tampilkeranjang()
        tampilnugget()
        tampilriwayat()
        tampilsosis()
    End Sub

    Dim PrintDocument1 As New PrintDocument()
    Dim PrintPreviewDialog1 As New PrintPreviewDialog()

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        updategv()
        AddHandler PrintDocument1.PrintPage, AddressOf printDocument1_PrintPage
        AddHandler PrintDocument1.BeginPrint, AddressOf PD_BeginPrint
        PrintPreviewDialog1.Document = PrintDocument1
        GVkeranjang.ClearSelection()
    End Sub

    Sub ambil_order()
        CMD = New MySqlCommand("SELECT * FROM tborder WHERE id_akun='" & iduser.Text & "' AND dibayar=0", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        If Not RD.HasRows Then
            RD.Close()
            CMD = New MySqlCommand("INSERT INTO tborder(id_akun, dibayar) VALUES('" & iduser.Text & "',0)", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("SELECT * FROM tborder WHERE id_akun='" & iduser.Text & "' AND dibayar=0", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            id_order = RD.Item(0)
            RD.Close()
        Else
            id_order = RD.Item(0)
            RD.Close()
        End If
    End Sub

    Dim id_order, index_keranjang As Integer
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim rowIndex, harga, id_produk As Integer
        Dim nama As String
        Dim ada = True

        If GVsosis.Visible = True Then
            If GVsosis.RowCount > 0 Then
                rowIndex = GVsosis.CurrentRow.Index
                id_produk = GVsosis.Rows(rowIndex).Cells(0).Value
                nama = GVsosis.Rows(rowIndex).Cells(1).Value.ToString()
                harga = GVsosis.Rows(rowIndex).Cells(5).Value.ToString().Split(" "c)(1)
                If GVsosis.Rows(rowIndex).Cells(4).Value = 0 Then
                    ada = False
                End If
            Else
                ada = False
            End If
        Else
            If GVnugget.RowCount > 0 Then
                rowIndex = GVnugget.CurrentRow.Index
                id_produk = GVnugget.Rows(rowIndex).Cells(0).Value
                nama = GVnugget.Rows(rowIndex).Cells(1).Value.ToString()
                harga = GVnugget.Rows(rowIndex).Cells(5).Value.ToString().Split(" "c)(1)
                If GVnugget.Rows(rowIndex).Cells(4).Value = 0 Then
                    ada = False
                End If
            Else
                ada = False
            End If
        End If

        If ada Then
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menambahkan " & nama & " ke keranjang?", "Konfirmasi",
                                                MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ambil_order()
                CMD = New MySqlCommand("SELECT * FROM tbkeranjang WHERE id_akun='" & iduser.Text & "' AND id_produk='" & id_produk & "' AND id_order='" & id_order & "'", CONN)
                RD = CMD.ExecuteReader()
                If Not RD.HasRows Then
                    RD.Close()
                    CMD = New MySqlCommand("INSERT INTO tbkeranjang VALUES (@1,@2,@3,@4,@5)", CONN)
                    CMD.Parameters.AddWithValue("@1", iduser.Text)
                    CMD.Parameters.AddWithValue("@2", id_order)
                    CMD.Parameters.AddWithValue("@3", id_produk)
                    CMD.Parameters.AddWithValue("@4", 1)
                    CMD.Parameters.AddWithValue("@5", harga)
                    CMD.ExecuteNonQuery()
                    MsgBox("Produk Berhasil ditambahkan ke keranjang")
                    updategv()
                Else
                    MsgBox("Produk sudah ada di keranjang")
                End If
                RD.Close()
            End If
        Else
            MsgBox("Stok Habis!! liat itu ada merah-merah nya woy")
        End If
    End Sub

    Dim keranjang_produk, harga, stok As Integer

    Sub ambil_stokharga()
        CMD = New MySqlCommand("SELECT * FROM tbproduk WHERE id_produk='" & keranjang_produk & "'", CONN)
        RD = CMD.ExecuteReader()
        If RD.HasRows Then
            RD.Read()
            harga = RD.Item(5)
            stok = RD.Item(4)
        End If
        RD.Close()
    End Sub

    Private Sub GVkeranjang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVkeranjang.CellClick
        If e.RowIndex > -1 Then
            txtjumlah.Enabled = True
            txtnamaproduk.Text = GVkeranjang.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtjumlah.Text = GVkeranjang.Rows(e.RowIndex).Cells(2).Value.ToString()
            keranjang_produk = GVkeranjang.Rows(e.RowIndex).Cells(0).Value
            ambil_stokharga()
            index_keranjang = e.RowIndex
        End If
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        If txtjumlah.Text IsNot "" Then
            If (txtjumlah.Text > 1) Then
                txtjumlah.Text = txtjumlah.Text - 1
            End If
            update_keranjang()
            updategv()
            GVkeranjang.ClearSelection()
        End If
    End Sub

    Sub update_keranjang()
        CMD = New MySqlCommand("UPDATE tbkeranjang SET harga='" & harga * txtjumlah.Text &
                               "', jumlah='" & txtjumlah.Text & "' WHERE id_produk='" &
                               keranjang_produk & "' AND id_order='" & id_order & "'", CONN)
        CMD.ExecuteNonQuery()
        RD.Close()
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If txtjumlah.Text IsNot "" Then
            If (txtjumlah.Text < stok) Then
                txtjumlah.Text = txtjumlah.Text + 1
            End If
            update_keranjang()
            updategv()
        End If
    End Sub

    Dim total_harga, jumlah_produk As Integer

    Private Sub txtjumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles txtjumlah.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtjumlah.Text IsNot "" Then
                If txtjumlah.Text > stok Then
                    txtjumlah.Text = stok
                ElseIf txtjumlah.Text < 1 Then
                    txtjumlah.Text = 1
                End If
                update_keranjang()
                updategv()
            End If
        End If
    End Sub

    Dim cari As String

    Private Sub txtcari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcari.KeyDown
        If e.KeyCode = Keys.Enter Then
            cari = txtcari.Text
            tampilsosis()
            tampilnugget()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim nama = GVkeranjang.SelectedRows.Item(0).Cells(1).Value.ToString()
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus " & nama & " dari keranjang?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CMD = New MySqlCommand("DELETE FROM tbkeranjang WHERE id_order='" & id_order & "' AND id_produk='" & keranjang_produk & "'", CONN)
            CMD.ExecuteNonQuery()
            bersih()
            updategv()
            If GVkeranjang.RowCount > 0 Then
                txtnamaproduk.Text = GVkeranjang.SelectedRows.Item(0).Cells(1).Value.ToString()
                txtjumlah.Text = GVkeranjang.SelectedRows.Item(0).Cells(2).Value.ToString()
                keranjang_produk = GVkeranjang.SelectedRows.Item(0).Cells(0).Value
                ambil_stokharga()
            End If
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

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result As DialogResult = MessageBox.Show("Keluar dari Aplikasi?", "Konfirmasi Keluar",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        If GVkeranjang.RowCount > 0 Then
            hitungtotal()
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memesan?", "Konfirmasi",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                CMD = New MySqlCommand("UPDATE tborder SET jumlah=@1, total_harga=@2, tanggal=@3, dibayar=1 WHERE id_order=@4", CONN)
                CMD.Parameters.AddWithValue("@1", jumlah_produk)
                CMD.Parameters.AddWithValue("@2", total_harga)
                CMD.Parameters.AddWithValue("@3", DateTime.Now)
                CMD.Parameters.AddWithValue("@4", id_order)
                If CMD.ExecuteNonQuery() Then
                    For Each row As DataGridViewRow In GVkeranjang.Rows
                        CMD = New MySqlCommand("UPDATE tbproduk SET stok=stok-@1 WHERE id_produk=@2", CONN)
                        CMD.Parameters.AddWithValue("@1", row.Cells(2).Value)
                        CMD.Parameters.AddWithValue("@2", row.Cells(0).Value)
                        CMD.ExecuteNonQuery()
                    Next
                    bersih()
                    MsgBox("Berhasil Pesan")
                    ambil_order()
                    updategv()
                End If
            End If
        End If
    End Sub

    Private Sub txtjumlah_Leave(sender As Object, e As EventArgs) Handles txtjumlah.Leave
        If txtjumlah.Text IsNot "" Then
            If txtjumlah.Text > stok Then
                txtjumlah.Text = stok
            ElseIf txtjumlah.Text < 1 Then
                txtjumlah.Text = 1
            End If
            update_keranjang()
            tampilkeranjang()
        End If
    End Sub

    Private Sub txtjumlah_Keypress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Sub hitungtotal()
        total_harga = 0
        jumlah_produk = 0
        CMD = New MySqlCommand("SELECT * FROM tbkeranjang WHERE id_akun='" & iduser.Text & "' AND id_order='" & id_order & "'", CONN)
        RD = CMD.ExecuteReader()
        If RD.HasRows Then
            While RD.Read()
                total_harga += RD.Item(4)
                jumlah_produk += RD.Item(3)
            End While
        End If
        txttotal.Text = "Rp " & total_harga
        RD.Close()
    End Sub
End Class
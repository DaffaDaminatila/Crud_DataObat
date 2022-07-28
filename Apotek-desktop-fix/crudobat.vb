Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Public Class crudobat
    Public id As String
    Public Sub getdata()
        Try
            Dim no As Integer
            DataGridView1.Rows.Clear()
            no = 1
            Dim uristring As String = "http://localhost/Apotek3/api/GetDataObat"
            Dim uri As New Uri(uristring)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(no, item("kode").ToString, item("supplier_id").ToString, item("nama_obat").ToString, item("produsen").ToString, item("stok").ToString, item("harga").ToString)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub

    Private Sub create()
        Dim uriString As String = "http://localhost/Apotek3/api/PostObat/" + txt_kd.Text + "/" + txt_supplier.Text + "/" + txt_nama.Text + "/" + txt_produsen.Text + "/" + txt_stok.Text + "/" + txt_harga.Text
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(Uri)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
        MsgBox("Input Data Obat Baru Sukses", MsgBoxStyle.Information, "Pemberitahuan")


    End Sub

    Private Sub updatedd()
        Dim uriString As String = "http://localhost/Apotek3/api/PutObat/" + txt_kd.Text + "/" + txt_supplier.Text + "/" + txt_nama.Text + "/" + txt_produsen.Text + "/" + txt_stok.Text + "/" + txt_harga.Text
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "PUT"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
        MsgBox("Update Data Obat Sukses", MsgBoxStyle.Information, "Pemberitahuan")

        txt_kd.Text = ""
        txt_supplier.Text = ""
        txt_nama.Text = ""
        txt_produsen.Text = ""
        txt_stok.Text = ""
        txt_harga.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub deleted()
        Dim uriString As String = "http://localhost/Apotek3/api/DeleteObat/" + txt_kd.Text + "/" + txt_supplier.Text + "/" + txt_nama.Text + "/" + txt_produsen.Text + "/" + txt_stok.Text + "/" + txt_harga.Text
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "DELETE"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
        MsgBox("Delete Data Obat Sukses", MsgBoxStyle.Information, "Pemberitahuan")

        txt_kd.Text = ""
        txt_supplier.Text = ""
        txt_nama.Text = ""
        txt_produsen.Text = ""
        txt_stok.Text = ""
        txt_harga.Text = ""
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub Clear()
        txt_kd.Text = ""
        txt_supplier.Text = ""
        txt_nama.Text = ""
        txt_produsen.Text = ""
        txt_stok.Text = ""
        txt_harga.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        getdata()
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        create()
        Clear()
        getdata()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_kd.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_supplier.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_produsen.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_stok.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txt_harga.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        updatedd()
        getdata()

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        deleted()
        Clear()
        getdata()

    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Close()
        Login.Show()

    End Sub

    Private Sub crudobat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.DataGridView1.Rows.Clear()
        buka()
        rec.Open("Select * from obat where nama_obat like '%" & txt_cari.Text & "%' order by nama_obat", con, 3, 2)
        no = 1
        Do While Not rec.EOF

            Me.DataGridView1.Rows.Add(no, rec.Fields.Item("kode").Value, rec.Fields.Item("supplier_id").Value, rec.Fields("nama_obat").Value,
                                      rec.Fields.Item("produsen").Value, rec.Fields.Item("stok").Value, rec.Fields.Item("harga").Value)
            rec.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
End Class
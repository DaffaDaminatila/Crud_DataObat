Imports System.Net
Imports System.IO
Imports ADODB
Imports System.Web.Script.Serialization
Public Class Login
    Public Sub login()

        Dim uristring As String = "http://localhost/Apotek3/api/Login" & TextBox1.Text & "/" & TextBox2.Text
        Dim uri As New Uri(uristring)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "GET"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buka()
        Dim sql As String
        Dim users As String
        sql = "select * from admin where username ='" & TextBox1.Text & "' AND password ='" & TextBox2.Text & "'"

        rec.Open(sql, con, 3, 2)

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong!", MsgBoxStyle.Exclamation)
        ElseIf TextBox1.Text = "" Then
            MsgBox("Username Anda Harus Di isi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "!")
            TextBox2.Text = ""
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Password Anda Harus Di isi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "!")
            TextBox2.Text = ""
            TextBox1.Clear()
            TextBox1.Focus()

        Else

            If users = "" Then
                MsgBox("Selamat Datang " + rec.Fields.Item("nama").Value, MsgBoxStyle.MsgBoxRight)
                TextBox1.Text = ""
                TextBox2.Text = ""

                MsgBox("Login Berhasil", MsgBoxStyle.Information)
                Me.Hide()
                crudobat.Show()
            End If
        End If
        tutup()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient

Public Class adduser
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If TextBox2.Text.Length >= 10 Then
            e.Handled = True
            MessageBox.Show("only 10 numbers are allowed")
        End If
        If Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("please enter all the details")
        ElseIf TextBox4.Text.Length < 8 Then
            MessageBox.Show("password must be 8 digits")
        ElseIf TextBox3.Text.EndsWith("@gmail.com") = False Then
            MessageBox.Show("invalid email")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Admin(UserName,password,email,mobileNo,Address) values(@name,@pass,@email,@mobile,@address)"
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox4.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@mobile", SqlDbType.BigInt).Value = Convert.ToInt64(TextBox2.Text)
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox5.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("data saved successfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If
        con.Close()
    End Sub

    Private Sub adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient

Public Class delete

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True")
        con.Open()
        If TextBox1.Text = "" Then
            MessageBox.Show("enter the phone no")
        ElseIf TextBox1.Text.Length <> 10 Then
            MsgBox("invalid number", MsgBoxStyle.Information, "warn")

        Else
            Dim cmd As New SqlCommand("SELECT * FROM table_reg WHERE phoneno =@phone", con)
            cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = TextBox1.Text
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                TextBox2.Text = table(0)(0)
                TextBox3.Text = table(0)(6)
                TextBox4.Text = table(0)(4)
                TextBox5.Text = table(0)(5)
                TextBox6.Text = table(0)(7)
                TextBox7.Text = table(0)(2)
                TextBox8.Text = table(0)(3)
                MessageBox.Show("press delete button to delete data")
            Else
                MessageBox.Show("data not found")
            End If
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        Dim con As New SqlConnection("Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("delete from table_reg WHERE phoneno =@phone", con)
        cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = TextBox1.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("data deleted successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        con.Close()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text.Length >= 10 Then
            e.Handled = True
            MessageBox.Show("only 10 numbers are allowed")

        End If
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("only number is allowed")

        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Blue
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Font = New Font("Arial", 19)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black
        Button1.Font = New Font("Maiandra GD", 18)
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Blue
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Font = New Font("Arial", 19)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Transparent
        Button2.ForeColor = Color.Black
        Button2.Font = New Font("Maiandra GD", 18)
    End Sub

    Private Sub Button4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.Blue
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Font = New Font("Arial", 19)
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.Transparent
        Button4.ForeColor = Color.Black
        Button4.Font = New Font("Maiandra GD", 18)
    End Sub

    Private Sub delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
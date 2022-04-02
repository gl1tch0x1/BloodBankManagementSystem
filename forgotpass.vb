Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class forgotpass
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.WhiteSmoke
        Button1.ForeColor = Color.Red

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub forgotpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If ConnectionState.Open = True Then
            con.Close()
        End If
        TextBox1.PasswordChar = "*"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox2.Text.Length < 8 Then
                MessageBox.Show("password must be of 8 characters")
            Else
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Admin set password='" + TextBox2.Text + "' where UserName='" + AdminLogin.txtUname.Text + "'"
                cmd.ExecuteNonQuery()
                MsgBox("password updated successfully", MsgBoxStyle.Information, "info")
            End If
        Else
            MessageBox.Show("please fill all the data")
        End If
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = TextBox2.Text And TextBox1.Text <> "" Then
            
            ErrorProvider1.SetError(TextBox1, "")
        Else
            ErrorProvider1.SetError(TextBox1, "password doesnot match")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")
        Dim str As String
        str = TextBox2.Text
        If upper.Matches(str).Count < 2 Then
            Label4.Visible = True
            Label4.Text = "password must have 2  uppercase"
        ElseIf lower.Matches(str).Count < 2 Then
            Label4.Visible = True
            Label4.Text = "password must have 2 lowercase"
        ElseIf number.Matches(str).Count < 2 Then
            Label4.Visible = True
            Label4.Text = "password must have 2 numbers"

        ElseIf special.Matches(str).Count < 2 Then
            Label4.Visible = True
            Label4.Text = "password must contain 2 special characters"
        Else
            Label4.Visible = False
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Dispose()
        AdminLogin.Show()
    End Sub
End Class
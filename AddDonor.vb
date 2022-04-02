Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class AddDonor
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtname.Text = ""
        dttaker.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True")
        con.Open()
        If (txtname.Text = "" Or dttaker.Text = "" Or ComboBox2.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox1.Text = "" Or TextBox4.Text = "") Then
            MessageBox.Show("please enter all the fields")
        ElseIf dttaker.Value.Year > 2005 Then
            MessageBox.Show("Age must be 16 or above!")
        ElseIf TextBox4.Text.Length < 8 Then
            MessageBox.Show("password must be of 8 or more characters")
        ElseIf TextBox1.Text.EndsWith("@gmail.com") = False Then
            MessageBox.Show("invalid email")
        ElseIf TextBox2.Text.Length < 10 Then
            MessageBox.Show("invalid mobile numbers")

        Else

            Dim cmd As New SqlCommand("insert into table_reg(fullname,phoneno,email,password,gender,bloodgroup,dob,address) values(@name,@phone,@email,@pass,@gender,@blood,@dob,@address)", con)
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
            cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = dttaker.Text
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = ComboBox2.Text
            cmd.Parameters.Add("@blood", SqlDbType.VarChar).Value = ComboBox1.Text
            cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = Convert.ToInt64(TextBox2.Text)
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox4.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("data saved successfully")
            adddonorrep.Show()
        End If
        con.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If TextBox2.Text.Length >= 10 Then
            e.Handled = True
            MessageBox.Show("only 10 numbers are allowed")

        End If
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")

        End If
    End Sub

    Private Sub AddDonor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox2.Items
            .Add("Male")
            .Add("female")
            .Add("others")

        End With
        With ComboBox1.Items
            .Add("A+")
            .Add("A-")
            .Add("B+")
            .Add("B-")
            .Add("O+")
            .Add("O-")
            .Add("AB+")
            .Add("AB-")

        End With
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox2.Text <> ComboBox2.SelectedItem Then

            End If
            e.Handled = True
            MsgBox("select the item", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox1.Text <> ComboBox1.SelectedItem Then

            End If
            e.Handled = True
            MsgBox("select the item", MsgBoxStyle.Information, "info")
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("only characters are allowed", MsgBoxStyle.Information, "info")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.Red
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 64 Then
        Else
            e.Handled = True
            MessageBox.Show("only [a-z],[0-9],(.) are allowed")
        End If
    End Sub

    
End Class
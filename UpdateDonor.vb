Imports System.Data
Imports System.Data.SqlClient

Public Class UpdateDonor
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("enter the phone number")
        
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM table_reg WHERE phoneno =@phone"
            cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = TextBox1.Text
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                TextBox2.Text = table(0)(0)
                ComboBox2.Text = table(0)(4)
                DateTimePicker1.Text = table(0)(6)
                ComboBox3.Text = table(0)(5)
                TextBox3.Text = table(0)(7)
                TextBox4.Text = table(0)(2)
                TextBox5.Text = table(0)(3)
                MessageBox.Show("enter the data to update & press Update button")
            Else

                MessageBox.Show("No Data Found")
            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or DateTimePicker1.Text = "" Then
            MessageBox.Show("please fill all the data to update")
        Else
            If DateTimePicker1.Value.Year > 2005 Then
                MsgBox("Age must be 16 or above")
            ElseIf TextBox5.Text.Length < 8 Then
                MessageBox.Show("password must be of 8 or more characters")
            Else

                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update table_reg set fullname='" + TextBox2.Text + "',phoneno='" + TextBox1.Text + "',email='" + TextBox4.Text + "',password='" + TextBox5.Text + "',gender='" + ComboBox2.Text + "',bloodgroup='" + ComboBox3.Text + "',dob='" + DateTimePicker1.Text + "',address='" + TextBox3.Text + "' where phoneno='" & TextBox1.Text.ToString() & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("data updated successfully")
                con.Close()
            End If
        End If
    End Sub

    Private Sub UpdateDonor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox2.Items
            .Add("Male")
            .Add("Female")
            .Add("others")
        End With
        With ComboBox3.Items
            .Add("A+")
            .Add("A-")
            .Add("B+")
            .Add("B-")
            .Add("O+")
            .Add("O-")
            .Add("AB+")
            .Add("AB-")
        End With

        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        DateTimePicker1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
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

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsControl(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
            MessageBox.Show("enter only characters")
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If ComboBox2.Text <> ComboBox2.SelectedItem And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "warn")

        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If ComboBox3.Text <> ComboBox3.SelectedItem And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "info")

        End If
    End Sub
End Class
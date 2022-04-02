Imports System.Data
Imports System.Data.SqlClient

Public Class Bloodtest
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.Blue
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Blue
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "" Then
            MessageBox.Show("please fill all the details")
        ElseIf TextBox3.Text.Length < 10 Then
            MsgBox("invalid phone number", MsgBoxStyle.Information, "info")
        ElseIf DateTimePicker1.Value.Year > 2005 Then
            MsgBox("Age must be 16 or above", MsgBoxStyle.Information, "warn")
        Else
            Dim today, dob As Integer
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into table_test(Name,Gender,Age,DOB,Phoneno,BloodGroup,Haemoglobin,WBC,RBC,HIV,cancer,COVID,ID) values(@name,@gender,@age,@date,@phone,@blood,@haem,@wbc,@rbc,@hiv,@cancer,@covid,@id)"
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = ComboBox1.Text
            today = Date.Today.Year
            dob = DateTimePicker1.Value.Year
            ComboBox2.Text = today - dob
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = ComboBox2.Text
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTimePicker1.Text
            cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = TextBox3.Text
            cmd.Parameters.Add("@blood", SqlDbType.VarChar).Value = ComboBox3.Text
            cmd.Parameters.Add("@haem", SqlDbType.Int).Value = TextBox4.Text
            cmd.Parameters.Add("@wbc", SqlDbType.Int).Value = TextBox5.Text
            cmd.Parameters.Add("@rbc", SqlDbType.Int).Value = TextBox6.Text
            cmd.Parameters.Add("@hiv", SqlDbType.VarChar).Value = ComboBox4.Text
            cmd.Parameters.Add("@cancer", SqlDbType.VarChar).Value = ComboBox5.Text
            cmd.Parameters.Add("@covid", SqlDbType.VarChar).Value = ComboBox6.Text
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox2.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("data collected successfully")
        End If
        con.Close()
    End Sub

    Private Sub Bloodtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Male")
            .Add("Female")
            .Add("Others")

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
        With ComboBox6.Items
            .Add("Negative")
            .Add("positive")

        End With
        With ComboBox4.Items
            .Add("Negative")
            .Add("positive")

        End With
        With ComboBox5.Items
            .Add("Negative")
            .Add("positive")
        End With
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub

 
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsControl(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
            MsgBox("only characters are allowed", MsgBoxStyle.Information, "info")

        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("age will be automatically calculated")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If TextBox2.Text.Length >= 3 Then
            e.Handled = True
            MsgBox("only 3 numbers are allowed", MsgBoxStyle.Information, "info")

        End If

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("only numbers are allowed")


            End If
        End If


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("only 10 numbers are allowed", MsgBoxStyle.Information, "info")


            End If
        End If

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("only numbers are allowed")

            End If
        End If

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox1.Text <> ComboBox1.SelectedItem Then
               
            End If
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "info")
            ComboBox1.Text = ""

        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox3.Text <> ComboBox3.SelectedItem Then

            End If
            e.Handled = True
            MsgBox("select the item", MsgBoxStyle.Information, "info")

        End If
    End Sub

    Private Sub ComboBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox6.Text <> ComboBox6.SelectedItem Then

            End If
            e.Handled = True
            MsgBox("select the item", MsgBoxStyle.Information, "info")

        End If
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        If ComboBox4.Text <> ComboBox4.SelectedItem And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "info")

        End If
    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        If ComboBox5.Text <> ComboBox5.SelectedItem And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "info")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("only number is allowed")
        End If

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("only number is allowed")
        End If

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("only number is allowed")
        End If

    End Sub
End Class
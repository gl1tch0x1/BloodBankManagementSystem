Imports System.Data
Imports System.Data.SqlClient
Public Class Stock
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        Try
            If TextBox1.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or DateTimePicker1.Text = "" Or TextBox3.Text = "" Then
                MessageBox.Show("please fill the data")
            ElseIf DateTimePicker1.Value.Year < 2022 Or DateTimePicker1.Value.Month < Today.Month Or DateTimePicker1.Value.Day < Today.Day Then
                MessageBox.Show("invalid date")
            ElseIf TextBox3.Text.Length > 4 Then
                MessageBox.Show("only 4 digits id is allowed")
            Else
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "insert into table_stock(ID,BloodGroup,Quantity,Entrydate,Expirydate) values(@id,@blood,@quantity,@endate,@exdate)"
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox3.Text)
                cmd.Parameters.Add("@blood", SqlDbType.VarChar).Value = ComboBox1.Text
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = TextBox1.Text
                cmd.Parameters.Add("@endate", SqlDbType.DateTime).Value = DateTimePicker1.Value
                Dim start As Date = Date.Parse(DateTimePicker1.Value)
                TextBox2.Text = DateAdd("d", 42, start)
                cmd.Parameters.Add("@exdate", SqlDbType.VarChar).Value = TextBox2.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("data saved successfully")
                stockrep.Show()
                TextBox1.Text = ""
                TextBox2.Text = ""
                ComboBox1.Text = ""
                TextBox3.Text = ""
                DateTimePicker1.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("enter the valid id number")
        End Try
        disp_data()
        con.Close()
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select * from table_stock")
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        con.ConnectionString = ("Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        disp_data()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) Then
            e.Handled = True
            MessageBox.Show("only number is allowed")
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If ComboBox1.Text <> ComboBox1.SelectedItem Then
            End If
            e.Handled = True
            MsgBox("select item", MsgBoxStyle.Information, "info")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.AliceBlue
        Button3.ForeColor = Color.Red
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Transparent
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.AliceBlue
        Button1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("date will be automatically generated")
        End If
    End Sub
End Class
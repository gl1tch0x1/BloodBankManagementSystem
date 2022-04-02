Imports System.Data
Imports System.Data.SqlClient
Public Class stockdec
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If ComboBox1.Text = "" Then
            MessageBox.Show("please select the blood group ")
        Else

            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table_stock where BloodGroup='" + ComboBox1.Text + "'"
            disp_data()
        End If
        con.Close()
    End Sub

    Private Sub stockdec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("A+")
            .Add("A-")
            .Add("B+")
            .Add("B-")
            .Add("AB+")
            .Add("AB-")
            .Add("O+")
            .Add("O-")
        End With

        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table_stock where BloodGroup='" + ComboBox1.Text + "'"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("please enter the id and units ")
        Else
            Dim num As Integer
            Dim n1 As Integer
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table_stock where id='" + TextBox1.Text + "'"
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                n1 = dt(0)(0)
                If n1 = TextBox1.Text Then
                Else
                    MessageBox.Show("invalid id")
                End If
                num = dt(0)(2)
                If num = TextBox2.Text Then
                    cmd.CommandText = "delete from table_stock where id='" + TextBox1.Text + "' and BloodGroup='" + ComboBox1.Text + "'"
                    cmd.ExecuteNonQuery()
                ElseIf num > TextBox2.Text Then
                    cmd.CommandText = "update table_stock set Quantity=Quantity-'" + TextBox2.Text + "' where BloodGroup='" + ComboBox1.Text + "' and id='" + TextBox1.Text + "' "
                    cmd.ExecuteNonQuery()
                Else
                    MessageBox.Show("the required amount of blood for this id is not available")
                End If
            End If

            disp_data()
        End If    
        con.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If ComboBox1.Text <> ComboBox1.SelectedItem Then
            e.Handled = True
            MessageBox.Show("please select the item")

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")
        End If
    End Sub
End Class
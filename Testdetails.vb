Imports System.Data
Imports System.Data.SqlClient

Public Class Testdetails
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Testdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()

    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table_test"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("please enter the ID")
        Else
            Dim num As Integer
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table_test where id='" + TextBox1.Text + "'"
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                num = Integer.Parse(dt(0)(0))               
            End If
            If num = TextBox1.Text Then
                Me.Hide()
                report.Show()
            Else
                MessageBox.Show("id not match")
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text.Length >= 4 Then
            e.Handled = True
            MessageBox.Show("only 4 numbers are allowed")
        ElseIf Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MessageBox.Show("only numbers are allowed")

        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Purple
        Button1.Font = New Font("Arial", 14)

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black
        Button1.Font = New Font("Maiandra GD", 18)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub
End Class
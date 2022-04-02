Imports System.Data
Imports System.Data.SqlClient

Public Class details
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        disp_data()

    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table_reg"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button1.Font = New Font("Arial", 17)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Purple
        Button1.ForeColor = Color.Black
        Button1.Font = New Font("Maiandra", 16)
    End Sub
End Class
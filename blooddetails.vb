Imports System.Data
Imports System.Data.SqlClient

Public Class blooddetails
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub blooddetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        disp_data()
        DataGridView1.AllowUserToAddRows = False
        Dim column5 As New DataGridViewTextBoxColumn
        column5.Name = "rdays"
        column5.HeaderText = "Remaining days"
        column5.Width = 200
        DataGridView1.Columns.Insert(5, column5)
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim exdate_v As Date = row.Cells("Expirydate").Value
            Dim calcdays_v As Integer = DateDiff(DateInterval.Day, Date.Now, exdate_v)
            row.Cells("rdays").Value = calcdays_v
            If row.Cells("rdays").Value < 10 Then
                MessageBox.Show("plz check blood is expiring")
            End If
        Next
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table_stock"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
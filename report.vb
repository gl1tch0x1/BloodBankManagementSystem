Imports System.Data
Imports System.Data.SqlClient

Public Class report
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table_test where id='" + Testdetails.TextBox1.Text + "'"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TextBox2.Text = dt(0)(1)
            TextBox3.Text = dt(0)(2)
            TextBox4.Text = dt(0)(3)
            TextBox5.Text = dt(0)(4)
            TextBox6.Text = dt(0)(6)
            TextBox7.Text = dt(0)(5)
            TextBox14.Text = dt(0)(7)
            TextBox15.Text = dt(0)(8)
            TextBox16.Text = dt(0)(9)
            TextBox17.Text = dt(0)(10)
            TextBox18.Text = dt(0)(11)
            TextBox19.Text = dt(0)(12)
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub
End Class
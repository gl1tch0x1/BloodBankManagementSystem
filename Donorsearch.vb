Imports System.Data
Imports System.Data.SqlClient

Public Class Donorsearch
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Donorsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        disp_data()
       
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If ComboBox1.Text <> ComboBox1.SelectedItem And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("select the item", MsgBoxStyle.Information, "warning")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If ComboBox1.Text = "" Then
            MessageBox.Show("please choose the blood group")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table_reg where bloodgroup='" + ComboBox1.Text + "'"
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ComboBox1.Text = dt(0)(5)
                disp_data()
            Else
                MessageBox.Show("that blood group's donor details not available")
            End If
        End If
        con.Close()
        
    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select * from table_reg where bloodgroup='" + ComboBox1.Text + "'")
        'cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub
End Class
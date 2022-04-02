Imports System.Data
Imports System.Data.SqlClient
Public Class generate
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("enter name to generate certificate", MsgBoxStyle.Exclamation, "info")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table_reg where fullname='" + TextBox1.Text + "'"
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Try
                If dt.Rows.Count > 0 Then
                    TextBox1.Text = dt(0)(0)
                    certificate.Show()
                Else
                    MsgBox("invalid donor name", MsgBoxStyle.Information, "warn")
                End If
            Catch ex As Exception
                MessageBox.Show("not donated blood")
            End Try

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim LowerCase, UpperCase
        LowerCase = TextBox1.Text
        UpperCase = UCase(LowerCase)
        certificate.TextBox1.Text = UpperCase
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) And Asc(e.KeyChar) <> 32 Then
                e.Handled = True
                MessageBox.Show("only characters are allowed")

            End If
        End If

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Blue


    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black



    End Sub

    Private Sub generate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Dispose()
        AdminDashboard.Show()
    End Sub
End Class
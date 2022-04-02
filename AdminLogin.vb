Imports System.Data
Imports System.Data.SqlClient

Public Class AdminLogin
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim len As Integer
    Dim counter As Integer
    Dim txt As String

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.White
        Button1.Font = New Font("Arial", 20)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black
        Button1.Font = New Font("Maiandra GD", 18)
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        If txtUname.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("please enter username and password to login")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Admin where UserName='" + txtUname.Text + "' and password='" + txtPass.Text + "' "
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                txtUname.Text = dt(0)(0)
                txtPass.Text = dt(0)(1)
                MessageBox.Show("login successfull")
                Me.Hide()
                AdminDashboard.Show()
            Else
                MessageBox.Show("invalid username or password")
            End If           
        End If
        con.Close()
    End Sub
    Private Sub AdminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        txtPass.PasswordChar = "*"
        counter = 0
        len = Label11.Text.Length
        txt = Label11.Text
        Timer1.Start()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        con.Open()
        If txtUname.Text <> "" Then
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Admin where UserName='" + txtUname.Text + "'"
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtUname.Text = dt(0)(0)
                Me.Hide()
                forgotpass.Show()
            Else
                MessageBox.Show("user doesnot exit")
            End If
        Else
            MessageBox.Show("fill the username field")

        End If
        con.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter += 1
        If counter > len Then
            counter = 0
            Label11.Text = ""
        Else
            Label11.Text = txt.Substring(0, counter)
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient

Public Class AdminDashboard
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub UpdateDonoruserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateDonoruserToolStripMenuItem.Click
        UpdateDonor.Show()
    End Sub

    Private Sub AddDonorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDonorToolStripMenuItem.Click
        criteria.Show()
    End Sub

    Private Sub CampaignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CampaignToolStripMenuItem.Click
        campaings.Show()

    End Sub

    Private Sub IncreaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseToolStripMenuItem.Click
        Stock.Show()
    End Sub

    Private Sub DecreaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Stock.Show()
    End Sub

    Private Sub BloodTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloodTestToolStripMenuItem.Click
        Bloodtest.Show()
    End Sub

    Private Sub TestDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestDetailsToolStripMenuItem.Click
        Testdetails.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        details.Show()
    End Sub

    Private Sub CertificateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateToolStripMenuItem1.Click
        generate.Show()
    End Sub

    Private Sub DeleteDonorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteDonorToolStripMenuItem.Click
        delete.Show()
    End Sub

    Private Sub AdminDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=MRAASHISH0X1\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
       
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to logout?", vbYesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            AdminLogin.Show()
        Else
            Me.Show()
        End If       
    End Sub

    Private Sub DonorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorToolStripMenuItem.Click
        Donorsearch.Show()
    End Sub

    Private Sub DecreaseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecreaseToolStripMenuItem.Click
        stockdec.Show()
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        blooddetails.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        adduser.Show()
    End Sub
End Class
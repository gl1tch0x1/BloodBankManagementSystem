Public Class criteria
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (RadioButton9.Checked = False And RadioButton10.Checked = False) Or (RadioButton11.Checked = False And RadioButton12.Checked = False) And (RadioButton13.Checked = False And RadioButton14.Checked = False) Or (RadioButton15.Checked = False And RadioButton16.Checked = False) Then
            MessageBox.Show("please check at least one ")
        Else
            If (RadioButton9.Checked = True And RadioButton10.Checked = False) And (RadioButton11.Checked = True And RadioButton12.Checked = False) And (RadioButton13.Checked = False And RadioButton14.Checked = True) And (RadioButton15.Checked = True And RadioButton16.Checked = False) Then
                MessageBox.Show("you are eligible for blood donation")
                Me.Hide()
                AddDonor.Show()
            Else
                MessageBox.Show("you are not eligible")
            End If
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
Public Class student
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles profilebox.Click
        profilebox.Image = BackgroundImage
        OpenFileDialog1.ShowDialog()
        imageholderstudent.Text = OpenFileDialog1.FileName
        If (System.IO.File.Exists(imageholderstudent.Text)) Then
            profilebox.Image = Image.FromFile(imageholderstudent.Text)



        End If
    End Sub

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageholderstudent.Hide()
    End Sub

    Private Sub stdtxtclearbtn_Click(sender As Object, e As EventArgs) Handles stdtxtclearbtn.Click
        Studentmainpanel.Refresh()
        Stdfnamebox.ResetText()
        Stdlnamebox.ResetText()
        stdaddressbox.ResetText()
        Stdcontactbox.ResetText()
        Stddobbox.ResetText()
        Stdemailbox.ResetText()
        profilebox.Image = profilebox.BackgroundImage

        Stdparentnamebox.ResetText()
        Stdrollbox.ResetText()


    End Sub
End Class
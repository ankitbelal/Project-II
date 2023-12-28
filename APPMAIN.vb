Public Class APPMAIN
    Private Sub APPMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'this is to close already opened forms inside menu panel


        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        menupanel.Controls.Add(com)
        com.Show



    End Sub

    Private Sub menupanel_Paint(sender As Object, e As PaintEventArgs) Handles menupanel.Paint

    End Sub
End Class
Public Class commom_menu
    Private Sub commonstudentbtn_Click(sender As Object, e As EventArgs) Handles commonstudentbtn.Click

        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim std As New studentmenu With {.TopMost = False, .AutoSize = False}
        std.TopLevel = False
        std.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(std)
        std.Show()



    End Sub

    Private Sub commonteacherbtn_Click(sender As Object, e As EventArgs) Handles commonteacherbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim teacher As New teachermenu With {.TopMost = False, .AutoSize = False}
        teacher.TopLevel = False
        teacher.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(teacher)
        teacher.Show()


    End Sub

    Private Sub commonsubjectbtn_Click(sender As Object, e As EventArgs) Handles commonsubjectbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim subject As New Subject With {.TopMost = False, .AutoSize = False}
        subject.TopLevel = False
        subject.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(subject)
        subject.Show()
    End Sub
End Class
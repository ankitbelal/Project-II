Public Class studentmenu
    Private Sub studentmenuaddbtn_Click(sender As Object, e As EventArgs) Handles studentmenuaddbtn.Click
        'this is to close already opened forms

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim std As New student With {.TopMost = False, .AutoSize = False}
        std.TopLevel = False
        std.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(std)
        std.Show()


    End Sub

    Private Sub studentmenuhidebtn_Click(sender As Object, e As EventArgs) Handles studentmenuhidebtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub studentmenuteacherbtn_Click(sender As Object, e As EventArgs) Handles studentmenuteacherbtn.Click
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

End Class
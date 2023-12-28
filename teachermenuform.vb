Public Class teachermenu
    Private Sub teachermenuform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub teachermenuteachebtn_Click(sender As Object, e As EventArgs) Handles teachermenuhidebtn.Click
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

    Private Sub teachermenuaddbtn_Click(sender As Object, e As EventArgs) Handles teachermenuaddbtn.Click
        'this is to close already opened forms

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim teacher As New Teacher With {.TopMost = False, .AutoSize = False}
        teacher.TopLevel = False
        teacher.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(teacher)
        teacher.Show()
    End Sub

    Private Sub teachermenustudentbtn_Click(sender As Object, e As EventArgs) Handles teachermenustudentbtn.Click
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
End Class
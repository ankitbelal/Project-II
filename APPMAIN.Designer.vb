<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        OpenFileDialog1 = New OpenFileDialog()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        controlbarpanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        menupanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        appmainpanel = New Panel()
        controlbarpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = controlbarpanel
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' controlbarpanel
        ' 
        controlbarpanel.BackColor = Color.Transparent
        controlbarpanel.Controls.Add(Guna2ControlBox2)
        controlbarpanel.Controls.Add(Guna2ControlBox1)
        controlbarpanel.FillColor = SystemColors.ActiveCaption
        controlbarpanel.Location = New Point(372, 4)
        controlbarpanel.Name = "controlbarpanel"
        controlbarpanel.ShadowColor = Color.Black
        controlbarpanel.Size = New Size(1537, 60)
        controlbarpanel.TabIndex = 36
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox2.FillColor = Color.Gray
        Guna2ControlBox2.ForeColor = SystemColors.ControlText
        Guna2ControlBox2.IconColor = Color.White
        Guna2ControlBox2.ImeMode = ImeMode.NoControl
        Guna2ControlBox2.Location = New Point(1401, 5)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox2.Size = New Size(67, 51)
        Guna2ControlBox2.TabIndex = 35
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.Maroon
        Guna2ControlBox1.IconColor = Color.White
        Guna2ControlBox1.Location = New Point(1469, 5)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(67, 51)
        Guna2ControlBox1.TabIndex = 34
        ' 
        ' menupanel
        ' 
        menupanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        menupanel.BackColor = Color.Transparent
        menupanel.BorderStyle = BorderStyle.FixedSingle
        menupanel.FillColor = Color.CadetBlue
        menupanel.Location = New Point(0, 0)
        menupanel.Name = "menupanel"
        menupanel.ShadowColor = Color.Black
        menupanel.Size = New Size(374, 999)
        menupanel.TabIndex = 6
        ' 
        ' appmainpanel
        ' 
        appmainpanel.Location = New Point(371, 66)
        appmainpanel.Name = "appmainpanel"
        appmainpanel.Size = New Size(1542, 934)
        appmainpanel.TabIndex = 8
        ' 
        ' APPMAIN
        ' 
        AutoScaleDimensions = New SizeF(192F, 192F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(1914, 1008)
        ControlBox = False
        Controls.Add(menupanel)
        Controls.Add(controlbarpanel)
        Controls.Add(appmainpanel)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "APPMAIN"
        StartPosition = FormStartPosition.CenterScreen
        controlbarpanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents menupanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents appmainpanel As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents controlbarpanel As Guna.UI2.WinForms.Guna2ShadowPanel
End Class

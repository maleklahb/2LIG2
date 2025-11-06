<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Labelnom = New Label()
        Labelage = New Label()
        Btnafficher = New Button()
        txtnom = New TextBox()
        txtage = New TextBox()
        SuspendLayout()
        ' 
        ' Labelnom
        ' 
        Labelnom.AutoSize = True
        Labelnom.Location = New Point(146, 102)
        Labelnom.Name = "Labelnom"
        Labelnom.Size = New Size(42, 20)
        Labelnom.TabIndex = 0
        Labelnom.Text = "Nom"
        ' 
        ' Labelage
        ' 
        Labelage.AutoSize = True
        Labelage.Location = New Point(146, 179)
        Labelage.Name = "Labelage"
        Labelage.Size = New Size(40, 20)
        Labelage.TabIndex = 1
        Labelage.Text = "Age "
        ' 
        ' Btnafficher
        ' 
        Btnafficher.Location = New Point(304, 271)
        Btnafficher.Name = "Btnafficher"
        Btnafficher.Size = New Size(94, 29)
        Btnafficher.TabIndex = 2
        Btnafficher.Text = "Afficher"
        Btnafficher.UseVisualStyleBackColor = True
        ' 
        ' txtnom
        ' 
        txtnom.Location = New Point(293, 102)
        txtnom.Name = "txtnom"
        txtnom.Size = New Size(125, 27)
        txtnom.TabIndex = 3
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(293, 172)
        txtage.Name = "txtage"
        txtage.Size = New Size(125, 27)
        txtage.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtage)
        Controls.Add(txtnom)
        Controls.Add(Btnafficher)
        Controls.Add(Labelage)
        Controls.Add(Labelnom)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelage As Label
    Friend WithEvents Btnafficher As Button
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtage As TextBox

End Class

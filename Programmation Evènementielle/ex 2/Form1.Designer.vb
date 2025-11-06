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
        btnres = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Labelres = New Label()
        txt1 = New TextBox()
        txt2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnres
        ' 
        btnres.Location = New Point(287, 239)
        btnres.Name = "btnres"
        btnres.Size = New Size(94, 29)
        btnres.TabIndex = 0
        btnres.Text = "calculer "
        btnres.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(123, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 1
        Label1.Text = "premier nombre "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(123, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 2
        Label2.Text = "deuxieme nombre "
        ' 
        ' Labelres
        ' 
        Labelres.AutoSize = True
        Labelres.Location = New Point(415, 243)
        Labelres.Name = "Labelres"
        Labelres.Size = New Size(58, 20)
        Labelres.TabIndex = 3
        Labelres.Text = "resultat"
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(269, 67)
        txt1.Name = "txt1"
        txt1.Size = New Size(125, 27)
        txt1.TabIndex = 4
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(269, 148)
        txt2.Name = "txt2"
        txt2.Size = New Size(125, 27)
        txt2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Controls.Add(Labelres)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnres)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnres As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Labelres As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox

End Class

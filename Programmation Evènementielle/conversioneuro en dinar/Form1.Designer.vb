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
        Label1 = New Label()
        txteuros = New TextBox()
        btnconvertir = New Button()
        btninit = New Button()
        label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "montant en euro"
        ' 
        ' txteuros
        ' 
        txteuros.Location = New Point(198, 128)
        txteuros.Name = "txteuros"
        txteuros.Size = New Size(125, 27)
        txteuros.TabIndex = 1
        ' 
        ' btnconvertir
        ' 
        btnconvertir.Location = New Point(365, 126)
        btnconvertir.Name = "btnconvertir"
        btnconvertir.Size = New Size(94, 29)
        btnconvertir.TabIndex = 2
        btnconvertir.Text = "convertir"
        btnconvertir.UseVisualStyleBackColor = True
        ' 
        ' btninit
        ' 
        btninit.Location = New Point(365, 187)
        btninit.Name = "btninit"
        btninit.Size = New Size(94, 29)
        btninit.TabIndex = 3
        btninit.Text = "reset"
        btninit.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(48, 187)
        label2.Name = "label2"
        label2.Size = New Size(123, 20)
        label2.TabIndex = 4
        label2.Text = "montant en dinar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 5
        Label3.Text = "lblresultat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(label2)
        Controls.Add(btninit)
        Controls.Add(btnconvertir)
        Controls.Add(txteuros)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txteuros As TextBox
    Friend WithEvents btnconvertir As Button
    Friend WithEvents btninit As Button
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label

End Class

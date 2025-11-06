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
        txta = New TextBox()
        txtb = New TextBox()
        btnplus = New Button()
        lblresultat = New Label()
        SuspendLayout()
        ' 
        ' txta
        ' 
        txta.BackColor = SystemColors.InactiveCaption
        txta.Location = New Point(144, 97)
        txta.Name = "txta"
        txta.Size = New Size(125, 27)
        txta.TabIndex = 0
        ' 
        ' txtb
        ' 
        txtb.BackColor = SystemColors.InactiveCaption
        txtb.Location = New Point(489, 97)
        txtb.Name = "txtb"
        txtb.Size = New Size(125, 27)
        txtb.TabIndex = 1
        ' 
        ' btnplus
        ' 
        btnplus.Location = New Point(330, 104)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(94, 29)
        btnplus.TabIndex = 2
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = True
        ' 
        ' lblresultat
        ' 
        lblresultat.AutoSize = True
        lblresultat.Location = New Point(312, 236)
        lblresultat.Name = "lblresultat"
        lblresultat.Size = New Size(58, 20)
        lblresultat.TabIndex = 3
        lblresultat.Text = "resultat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblresultat)
        Controls.Add(btnplus)
        Controls.Add(txtb)
        Controls.Add(txta)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txta As TextBox
    Friend WithEvents txtb As TextBox
    Friend WithEvents btnplus As Button
    Friend WithEvents lblresultat As Label

End Class

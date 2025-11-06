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
        components = New ComponentModel.Container()
        code = New Label()
        designation = New Label()
        prix = New Label()
        quantite = New Label()
        btnafficher = New Button()
        txtcode = New TextBox()
        txtdesignation = New TextBox()
        txtprix = New TextBox()
        txtquanti = New TextBox()
        btnajouter = New Button()
        btnannuler = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btncalculer = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' code
        ' 
        code.AutoSize = True
        code.Location = New Point(75, 87)
        code.Name = "code"
        code.Size = New Size(46, 20)
        code.TabIndex = 0
        code.Text = "code "
        ' 
        ' designation
        ' 
        designation.AutoSize = True
        designation.Location = New Point(66, 139)
        designation.Name = "designation"
        designation.Size = New Size(87, 20)
        designation.TabIndex = 1
        designation.Text = "designation"
        ' 
        ' prix
        ' 
        prix.AutoSize = True
        prix.Location = New Point(75, 192)
        prix.Name = "prix"
        prix.Size = New Size(34, 20)
        prix.TabIndex = 2
        prix.Text = "prix"
        ' 
        ' quantite
        ' 
        quantite.AutoSize = True
        quantite.Location = New Point(66, 263)
        quantite.Name = "quantite"
        quantite.Size = New Size(68, 20)
        quantite.TabIndex = 3
        quantite.Text = "quantite "
        ' 
        ' btnafficher
        ' 
        btnafficher.Location = New Point(398, 199)
        btnafficher.Name = "btnafficher"
        btnafficher.Size = New Size(94, 29)
        btnafficher.TabIndex = 5
        btnafficher.Text = "afficher "
        btnafficher.UseVisualStyleBackColor = True
        ' 
        ' txtcode
        ' 
        txtcode.Location = New Point(166, 84)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(125, 27)
        txtcode.TabIndex = 6
        ' 
        ' txtdesignation
        ' 
        txtdesignation.Location = New Point(168, 136)
        txtdesignation.Name = "txtdesignation"
        txtdesignation.Size = New Size(125, 27)
        txtdesignation.TabIndex = 7
        ' 
        ' txtprix
        ' 
        txtprix.Location = New Point(168, 189)
        txtprix.Name = "txtprix"
        txtprix.Size = New Size(125, 27)
        txtprix.TabIndex = 8
        ' 
        ' txtquanti
        ' 
        txtquanti.Location = New Point(168, 260)
        txtquanti.Name = "txtquanti"
        txtquanti.Size = New Size(125, 27)
        txtquanti.TabIndex = 9
        ' 
        ' btnajouter
        ' 
        btnajouter.Location = New Point(398, 78)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 10
        btnajouter.Text = "ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.Location = New Point(398, 254)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 11
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btncalculer
        ' 
        btncalculer.Location = New Point(398, 130)
        btncalculer.Name = "btncalculer"
        btncalculer.Size = New Size(94, 29)
        btncalculer.TabIndex = 4
        btncalculer.Text = "calculer "
        btncalculer.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnannuler)
        Controls.Add(btnajouter)
        Controls.Add(txtquanti)
        Controls.Add(txtprix)
        Controls.Add(txtdesignation)
        Controls.Add(txtcode)
        Controls.Add(btnafficher)
        Controls.Add(btncalculer)
        Controls.Add(quantite)
        Controls.Add(prix)
        Controls.Add(designation)
        Controls.Add(code)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents code As Label
    Friend WithEvents designation As Label
    Friend WithEvents prix As Label
    Friend WithEvents quantite As Label
    Friend WithEvents btnafficher As Button
    Friend WithEvents txtcode As TextBox
    Friend WithEvents txtdesignation As TextBox
    Friend WithEvents txtprix As TextBox
    Friend WithEvents txtquanti As TextBox
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btncalculer As Button

End Class

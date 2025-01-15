<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        EspaceLogin = New GroupBox()
        btnExit = New Button()
        EspaceLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(193, 76)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(193, 129)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaption
        btnLogin.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(60, 176)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(121, 34)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Connexion"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblUsername.Location = New Point(51, 79)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(130, 21)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Nom d'utilisateur "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblPassword.Location = New Point(73, 132)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(106, 21)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Mot de passe "
        ' 
        ' EspaceLogin
        ' 
        EspaceLogin.BackgroundImage = My.Resources.Resources.téléchargement1
        EspaceLogin.Controls.Add(btnExit)
        EspaceLogin.Controls.Add(lblUsername)
        EspaceLogin.Controls.Add(txtUsername)
        EspaceLogin.Controls.Add(lblPassword)
        EspaceLogin.Controls.Add(txtPassword)
        EspaceLogin.Controls.Add(btnLogin)
        EspaceLogin.Location = New Point(46, 47)
        EspaceLogin.Name = "EspaceLogin"
        EspaceLogin.Size = New Size(720, 312)
        EspaceLogin.TabIndex = 6
        EspaceLogin.TabStop = False
        EspaceLogin.Text = "Espace Login"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ActiveCaption
        btnExit.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnExit.Location = New Point(218, 176)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(126, 34)
        btnExit.TabIndex = 5
        btnExit.Text = "Fermer"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(EspaceLogin)
        Name = "LoginForm"
        Text = "LoginForm"
        EspaceLogin.ResumeLayout(False)
        EspaceLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents EspaceLogin As GroupBox
    Friend WithEvents btnExit As Button
End Class

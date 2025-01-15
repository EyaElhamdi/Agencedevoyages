Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If username = "admin" And password = "admin123" Then
            MessageBox.Show("Bienvenue, Admin !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim adminPanel As New AdminPanel()
            adminPanel.Show()

        ElseIf username = "user" And password = "user123" Then
            MessageBox.Show("Bienvenue, Utilisateur !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim userPanel As New UserPanel()
            userPanel.Show()

        Else
            MessageBox.Show("Identifiants incorrects. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class

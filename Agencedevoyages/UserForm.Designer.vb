<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        cmbDestination = New ComboBox()
        lblDestination = New Label()
        EspaceUtilisateur = New GroupBox()
        btnBookTicket = New Button()
        lblClientPhone = New Label()
        txtClientPhone = New TextBox()
        txtClientLastName = New TextBox()
        lblClientLastName = New Label()
        lblClientFirstName = New Label()
        txtClientFirstName = New TextBox()
        dgvAvailableFlights = New DataGridView()
        btnSearchFlights = New Button()
        lblSearchDate = New Label()
        dtpSearchDate = New DateTimePicker()
        EspaceUtilisateur.SuspendLayout()
        CType(dgvAvailableFlights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbDestination
        ' 
        cmbDestination.FormattingEnabled = True
        cmbDestination.Location = New Point(148, 42)
        cmbDestination.Name = "cmbDestination"
        cmbDestination.Size = New Size(121, 23)
        cmbDestination.TabIndex = 0
        ' 
        ' lblDestination
        ' 
        lblDestination.AutoSize = True
        lblDestination.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblDestination.Location = New Point(12, 44)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(91, 21)
        lblDestination.TabIndex = 1
        lblDestination.Text = "Destination"
        ' 
        ' EspaceUtilisateur
        ' 
        EspaceUtilisateur.BackgroundImage = My.Resources.Resources.téléchargement1
        EspaceUtilisateur.Controls.Add(btnBookTicket)
        EspaceUtilisateur.Controls.Add(lblClientPhone)
        EspaceUtilisateur.Controls.Add(txtClientPhone)
        EspaceUtilisateur.Controls.Add(txtClientLastName)
        EspaceUtilisateur.Controls.Add(lblClientLastName)
        EspaceUtilisateur.Controls.Add(lblClientFirstName)
        EspaceUtilisateur.Controls.Add(txtClientFirstName)
        EspaceUtilisateur.Controls.Add(dgvAvailableFlights)
        EspaceUtilisateur.Controls.Add(btnSearchFlights)
        EspaceUtilisateur.Controls.Add(lblSearchDate)
        EspaceUtilisateur.Controls.Add(dtpSearchDate)
        EspaceUtilisateur.Controls.Add(cmbDestination)
        EspaceUtilisateur.Controls.Add(lblDestination)
        EspaceUtilisateur.Location = New Point(12, 22)
        EspaceUtilisateur.Name = "EspaceUtilisateur"
        EspaceUtilisateur.Size = New Size(721, 384)
        EspaceUtilisateur.TabIndex = 2
        EspaceUtilisateur.TabStop = False
        EspaceUtilisateur.Text = "Espace Utilisateur"
        ' 
        ' btnBookTicket
        ' 
        btnBookTicket.BackColor = SystemColors.ActiveCaption
        btnBookTicket.Font = New Font("Segoe UI Symbol", 10F, FontStyle.Bold Or FontStyle.Italic)
        btnBookTicket.Location = New Point(43, 334)
        btnBookTicket.Name = "btnBookTicket"
        btnBookTicket.Size = New Size(208, 32)
        btnBookTicket.TabIndex = 12
        btnBookTicket.Text = "Confirmer la réservation"
        btnBookTicket.UseVisualStyleBackColor = False
        ' 
        ' lblClientPhone
        ' 
        lblClientPhone.AutoSize = True
        lblClientPhone.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblClientPhone.Location = New Point(12, 291)
        lblClientPhone.Name = "lblClientPhone"
        lblClientPhone.Size = New Size(125, 21)
        lblClientPhone.TabIndex = 11
        lblClientPhone.Text = "Numéro de client"
        ' 
        ' txtClientPhone
        ' 
        txtClientPhone.Location = New Point(169, 289)
        txtClientPhone.Name = "txtClientPhone"
        txtClientPhone.Size = New Size(100, 23)
        txtClientPhone.TabIndex = 10
        ' 
        ' txtClientLastName
        ' 
        txtClientLastName.Location = New Point(169, 248)
        txtClientLastName.Name = "txtClientLastName"
        txtClientLastName.Size = New Size(100, 23)
        txtClientLastName.TabIndex = 9
        ' 
        ' lblClientLastName
        ' 
        lblClientLastName.AutoSize = True
        lblClientLastName.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblClientLastName.Location = New Point(12, 250)
        lblClientLastName.Name = "lblClientLastName"
        lblClientLastName.Size = New Size(103, 21)
        lblClientLastName.TabIndex = 8
        lblClientLastName.Text = "Nom du client"
        ' 
        ' lblClientFirstName
        ' 
        lblClientFirstName.AutoSize = True
        lblClientFirstName.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblClientFirstName.Location = New Point(12, 206)
        lblClientFirstName.Name = "lblClientFirstName"
        lblClientFirstName.Size = New Size(126, 21)
        lblClientFirstName.TabIndex = 7
        lblClientFirstName.Text = "Prénom du client "
        ' 
        ' txtClientFirstName
        ' 
        txtClientFirstName.Location = New Point(169, 204)
        txtClientFirstName.Name = "txtClientFirstName"
        txtClientFirstName.Size = New Size(100, 23)
        txtClientFirstName.TabIndex = 6
        ' 
        ' dgvAvailableFlights
        ' 
        dgvAvailableFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAvailableFlights.Location = New Point(380, 22)
        dgvAvailableFlights.Name = "dgvAvailableFlights"
        dgvAvailableFlights.Size = New Size(240, 150)
        dgvAvailableFlights.TabIndex = 5
        ' 
        ' btnSearchFlights
        ' 
        btnSearchFlights.BackColor = SystemColors.ActiveCaption
        btnSearchFlights.Font = New Font("Segoe UI Symbol", 11F, FontStyle.Bold Or FontStyle.Italic)
        btnSearchFlights.Location = New Point(119, 137)
        btnSearchFlights.Name = "btnSearchFlights"
        btnSearchFlights.Size = New Size(118, 35)
        btnSearchFlights.TabIndex = 4
        btnSearchFlights.Text = "Rechercher "
        btnSearchFlights.UseVisualStyleBackColor = False
        ' 
        ' lblSearchDate
        ' 
        lblSearchDate.AutoSize = True
        lblSearchDate.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblSearchDate.Location = New Point(12, 86)
        lblSearchDate.Name = "lblSearchDate"
        lblSearchDate.Size = New Size(141, 21)
        lblSearchDate.TabIndex = 3
        lblSearchDate.Text = "Date de recherche "
        ' 
        ' dtpSearchDate
        ' 
        dtpSearchDate.Location = New Point(169, 86)
        dtpSearchDate.Name = "dtpSearchDate"
        dtpSearchDate.Size = New Size(200, 23)
        dtpSearchDate.TabIndex = 2
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(EspaceUtilisateur)
        Name = "UserForm"
        Text = "UserForm"
        EspaceUtilisateur.ResumeLayout(False)
        EspaceUtilisateur.PerformLayout()
        CType(dgvAvailableFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbDestination As ComboBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents EspaceUtilisateur As GroupBox
    Friend WithEvents lblSearchDate As Label
    Friend WithEvents dtpSearchDate As DateTimePicker
    Friend WithEvents lblClientLastName As Label
    Friend WithEvents lblClientFirstName As Label
    Friend WithEvents txtClientFirstName As TextBox
    Friend WithEvents dgvAvailableFlights As DataGridView
    Friend WithEvents btnSearchFlights As Button
    Friend WithEvents txtClientLastName As TextBox
    Friend WithEvents lblClientPhone As Label
    Friend WithEvents txtClientPhone As TextBox
    Friend WithEvents btnBookTicket As Button
End Class

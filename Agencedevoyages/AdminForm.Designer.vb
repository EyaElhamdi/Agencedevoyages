<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        lblFlightNumber = New Label()
        txtFlightNumber = New TextBox()
        txtDestination = New TextBox()
        lblDestination = New Label()
        lblPrice = New Label()
        txtPrice = New TextBox()
        lblFlightDate = New Label()
        dtpFlightDate = New DateTimePicker()
        lblAvailableSeats = New Label()
        nudAvailableSeats = New NumericUpDown()
        dgvFlights = New DataGridView()
        Numéro_de_vol = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        Date_ = New DataGridViewTextBoxColumn()
        Places_disponibles = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        btnAddFlight = New Button()
        btnEditFlight = New Button()
        btnDeleteFlight = New Button()
        EspaceAdmin = New GroupBox()
        CType(nudAvailableSeats, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFlights, ComponentModel.ISupportInitialize).BeginInit()
        EspaceAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFlightNumber
        ' 
        lblFlightNumber.AutoSize = True
        lblFlightNumber.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblFlightNumber.Location = New Point(38, 21)
        lblFlightNumber.Name = "lblFlightNumber"
        lblFlightNumber.Size = New Size(108, 21)
        lblFlightNumber.TabIndex = 0
        lblFlightNumber.Text = "Numéro de vol"
        ' 
        ' txtFlightNumber
        ' 
        txtFlightNumber.Location = New Point(181, 19)
        txtFlightNumber.Name = "txtFlightNumber"
        txtFlightNumber.Size = New Size(100, 23)
        txtFlightNumber.TabIndex = 1
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(181, 71)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(100, 23)
        txtDestination.TabIndex = 2
        ' 
        ' lblDestination
        ' 
        lblDestination.AutoSize = True
        lblDestination.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblDestination.Location = New Point(38, 78)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(91, 21)
        lblDestination.TabIndex = 3
        lblDestination.Text = "Destination"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblPrice.Location = New Point(38, 135)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(37, 21)
        lblPrice.TabIndex = 4
        lblPrice.Text = "Prix"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(181, 128)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 5
        ' 
        ' lblFlightDate
        ' 
        lblFlightDate.AutoSize = True
        lblFlightDate.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblFlightDate.Location = New Point(26, 191)
        lblFlightDate.Name = "lblFlightDate"
        lblFlightDate.Size = New Size(149, 21)
        lblFlightDate.TabIndex = 6
        lblFlightDate.Text = "Date et heure du vol"
        ' 
        ' dtpFlightDate
        ' 
        dtpFlightDate.Location = New Point(181, 186)
        dtpFlightDate.Name = "dtpFlightDate"
        dtpFlightDate.Size = New Size(200, 23)
        dtpFlightDate.TabIndex = 7
        ' 
        ' lblAvailableSeats
        ' 
        lblAvailableSeats.AutoSize = True
        lblAvailableSeats.Font = New Font("Papyrus", 9.75F, FontStyle.Bold)
        lblAvailableSeats.Location = New Point(24, 242)
        lblAvailableSeats.Name = "lblAvailableSeats"
        lblAvailableSeats.Size = New Size(136, 21)
        lblAvailableSeats.TabIndex = 8
        lblAvailableSeats.Text = "Places disponibles"
        ' 
        ' nudAvailableSeats
        ' 
        nudAvailableSeats.Location = New Point(183, 242)
        nudAvailableSeats.Name = "nudAvailableSeats"
        nudAvailableSeats.Size = New Size(120, 23)
        nudAvailableSeats.TabIndex = 9
        ' 
        ' dgvFlights
        ' 
        dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlights.Columns.AddRange(New DataGridViewColumn() {Numéro_de_vol, Destination, Date_, Places_disponibles, Prix})
        dgvFlights.Location = New Point(26, 287)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.Size = New Size(551, 128)
        dgvFlights.TabIndex = 10
        ' 
        ' Numéro_de_vol
        ' 
        Numéro_de_vol.HeaderText = "Numéro de vol"
        Numéro_de_vol.Name = "Numéro_de_vol"
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination"
        Destination.Name = "Destination"
        ' 
        ' Date_
        ' 
        Date_.HeaderText = "Date"
        Date_.Name = "Date_"
        ' 
        ' Places_disponibles
        ' 
        Places_disponibles.HeaderText = "Places disponibles"
        Places_disponibles.Name = "Places_disponibles"
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.Name = "Prix"
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.BackColor = SystemColors.ActiveCaption
        btnAddFlight.FlatStyle = FlatStyle.Flat
        btnAddFlight.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnAddFlight.Location = New Point(432, 62)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(107, 35)
        btnAddFlight.TabIndex = 11
        btnAddFlight.Text = "Ajouter"
        btnAddFlight.UseVisualStyleBackColor = False
        ' 
        ' btnEditFlight
        ' 
        btnEditFlight.BackColor = SystemColors.ActiveCaption
        btnEditFlight.FlatStyle = FlatStyle.Flat
        btnEditFlight.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnEditFlight.Location = New Point(432, 103)
        btnEditFlight.Name = "btnEditFlight"
        btnEditFlight.Size = New Size(107, 36)
        btnEditFlight.TabIndex = 12
        btnEditFlight.Text = "Modifier"
        btnEditFlight.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteFlight
        ' 
        btnDeleteFlight.BackColor = SystemColors.ActiveCaption
        btnDeleteFlight.FlatStyle = FlatStyle.Flat
        btnDeleteFlight.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnDeleteFlight.Location = New Point(432, 145)
        btnDeleteFlight.Name = "btnDeleteFlight"
        btnDeleteFlight.Size = New Size(107, 38)
        btnDeleteFlight.TabIndex = 13
        btnDeleteFlight.Text = "Supprimer"
        btnDeleteFlight.UseVisualStyleBackColor = False
        ' 
        ' EspaceAdmin
        ' 
        EspaceAdmin.BackgroundImage = My.Resources.Resources.téléchargement2
        EspaceAdmin.Controls.Add(dgvFlights)
        EspaceAdmin.Controls.Add(txtPrice)
        EspaceAdmin.Controls.Add(lblFlightNumber)
        EspaceAdmin.Controls.Add(btnDeleteFlight)
        EspaceAdmin.Controls.Add(txtFlightNumber)
        EspaceAdmin.Controls.Add(btnEditFlight)
        EspaceAdmin.Controls.Add(btnAddFlight)
        EspaceAdmin.Controls.Add(txtDestination)
        EspaceAdmin.Controls.Add(lblDestination)
        EspaceAdmin.Controls.Add(nudAvailableSeats)
        EspaceAdmin.Controls.Add(lblPrice)
        EspaceAdmin.Controls.Add(lblAvailableSeats)
        EspaceAdmin.Controls.Add(lblFlightDate)
        EspaceAdmin.Controls.Add(dtpFlightDate)
        EspaceAdmin.Location = New Point(12, 23)
        EspaceAdmin.Name = "EspaceAdmin"
        EspaceAdmin.Size = New Size(765, 435)
        EspaceAdmin.TabIndex = 14
        EspaceAdmin.TabStop = False
        EspaceAdmin.Text = "Espace Admin"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(EspaceAdmin)
        Name = "AdminForm"
        Text = "AdminForm"
        CType(nudAvailableSeats, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        EspaceAdmin.ResumeLayout(False)
        EspaceAdmin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblFlightNumber As Label
    Friend WithEvents txtFlightNumber As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblFlightDate As Label
    Friend WithEvents dtpFlightDate As DateTimePicker
    Friend WithEvents lblAvailableSeats As Label
    Friend WithEvents nudAvailableSeats As NumericUpDown
    Friend WithEvents dgvFlights As DataGridView
    Friend WithEvents Numéro_de_vol As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents Date_ As DataGridViewTextBoxColumn
    Friend WithEvents Places_disponibles As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnEditFlight As Button
    Friend WithEvents btnDeleteFlight As Button
    Friend WithEvents EspaceAdmin As GroupBox
End Class

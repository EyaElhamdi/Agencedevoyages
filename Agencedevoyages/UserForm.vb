Imports System.IO

Public Class UserForm
    Private Flights As New List(Of AdminForm.Flight)()

    Private Sub btnSearchFlights_Click(sender As Object, e As EventArgs) Handles btnSearchFlights.Click
        Dim searchDestination As String = cmbDestination.Text
        Dim searchDate As DateTime = dtpSearchDate.Value


        Dim filteredFlights = Flights.Where(Function(f) f.Destination.Contains(searchDestination) AndAlso
                                                 f.FlightDate.Date = searchDate.Date).ToList()

        dgvAvailableFlights.Rows.Clear()
        For Each flight In filteredFlights
            dgvAvailableFlights.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate.ToString("dd/MM/yyyy"), flight.AvailableSeats, flight.Price)
        Next
    End Sub

    Private Sub btnBookTicket_Click(sender As Object, e As EventArgs) Handles btnBookTicket.Click
        If dgvAvailableFlights.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvAvailableFlights.SelectedRows(0).Index
            Dim selectedFlight = Flights(selectedRowIndex)

            If selectedFlight.AvailableSeats > 0 Then
                selectedFlight.AvailableSeats -= 1
                Flights(selectedRowIndex) = selectedFlight

                Dim receipt = $"*** Reçu de Réservation ***{Environment.NewLine}" &
                              $"Nom : {txtClientFirstName.Text}{Environment.NewLine}" &
                              $"Prénom : {txtClientLastName.Text}{Environment.NewLine}" &
                              $"Téléphone : {txtClientPhone.Text}{Environment.NewLine}" &
                              $"Vol : {selectedFlight.FlightNumber} - {selectedFlight.Destination}{Environment.NewLine}" &
                              $"Date : {selectedFlight.FlightDate.ToString("dd/MM/yyyy")}{Environment.NewLine}" &
                              $"Prix : {selectedFlight.Price:C}{Environment.NewLine}" &
                              $"Merci pour votre réservation !"

                File.WriteAllText("Reçu_Reservation.txt", receipt)

                UpdateAvailableFlightsGrid()
                MessageBox.Show("Réservation réussie ! Le reçu a été généré.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Plus de places disponibles pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un vol pour effectuer une réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateAvailableFlightsGrid()
        dgvAvailableFlights.Rows.Clear()
        For Each flight In Flights
            If flight.AvailableSeats > 0 Then
                dgvAvailableFlights.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate.ToString("dd/MM/yyyy"), flight.AvailableSeats, flight.Price)
            End If
        Next
    End Sub

    Private Sub ClearClientInputs()
        txtClientFirstName.Clear()
        txtClientLastName.Clear()
        txtClientPhone.Clear()
    End Sub


End Class

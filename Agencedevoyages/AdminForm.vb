Imports System

Public Class AdminForm
    Private Flights As New List(Of Flight)()

    Public Structure Flight
        Public FlightNumber As String
        Public Destination As String
        Public FlightDate As DateTime
        Public AvailableSeats As Integer
        Public Price As Decimal
    End Structure

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        If ValidateFlightInput() Then
            Dim newFlight As New Flight With {
                .FlightNumber = txtFlightNumber.Text,
                .Destination = txtDestination.Text,
                .FlightDate = dtpFlightDate.Value,
                .AvailableSeats = CInt(nudAvailableSeats.Value),
                .Price = CDec(txtPrice.Text)
            }

            Flights.Add(newFlight)
            UpdateFlightGrid()
            ClearFlightInputs()
            MessageBox.Show("Vol ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditFlight_Click(sender As Object, e As EventArgs) Handles btnEditFlight.Click
        If dgvFlights.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = dgvFlights.SelectedRows(0).Index
            Flights(selectedIndex) = New Flight With {
                .FlightNumber = txtFlightNumber.Text,
                .Destination = txtDestination.Text,
                .FlightDate = dtpFlightDate.Value,
                .AvailableSeats = CInt(nudAvailableSeats.Value),
                .Price = CDec(txtPrice.Text)
            }

            UpdateFlightGrid()
            ClearFlightInputs()
            MessageBox.Show("Vol modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDeleteFlight_Click(sender As Object, e As EventArgs) Handles btnDeleteFlight.Click
        If dgvFlights.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = dgvFlights.SelectedRows(0).Index
            Flights.RemoveAt(selectedIndex)
            UpdateFlightGrid()
            ClearFlightInputs()
            MessageBox.Show("Vol supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateFlightGrid()
        dgvFlights.Rows.Clear()
        For Each flight In Flights
            dgvFlights.Rows.Add(flight.FlightNumber, flight.Destination, flight.FlightDate.ToString("dd/MM/yyyy"), flight.AvailableSeats, flight.Price)
        Next
    End Sub

    Private Sub ClearFlightInputs()
        txtFlightNumber.Clear()
        txtDestination.Clear()
        dtpFlightDate.Value = DateTime.Now
        nudAvailableSeats.Value = 1
        txtPrice.Clear()
    End Sub

    Private Function ValidateFlightInput() As Boolean
        If String.IsNullOrWhiteSpace(txtFlightNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtDestination.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Le prix doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
End Class

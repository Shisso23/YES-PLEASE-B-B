Public Class Reservation_Report

    Private Sub Reservation_Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ReservationTableAdapter1.FillBy(Me.Group6DataSet1.RESERVATION)
        crystalReport61.SetDataSource(Me.Group6DataSet1)

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
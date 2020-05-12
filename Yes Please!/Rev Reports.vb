Public Class Rev_Reports

    Private Sub Rev_Reports_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Rev_Reports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.RESERVATION' table. You can move, or remove it, as needed.
        Me.RESERVATIONTableAdapter.display_Reservation(Me.Group6DataSet.RESERVATION)
        PictureBox1.Enabled = True


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.RESERVATIONTableAdapter.FillBy(Me.Group6DataSet.RESERVATION)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
        Catch ex As Exception
            MsgBox("search using the reservation number")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
        Catch ex As Exception
            ' MsgBox("search using the reservation number")
        End Try
        If TextBox1.Text = "" Then
            Try
                Me.RESERVATIONTableAdapter.display_Reservation(Me.Group6DataSet.RESERVATION)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox4_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            Dim i As Integer
            Dim sum As Double
            login.ReservationTableAdapter1.FillBy(login.Group6DataSet1.RESERVATION)
            For i = 0 To login.Group6DataSet1.RESERVATION.Rows.Count - 1
                sum += login.Group6DataSet1.RESERVATION.Rows(i).Item(5)
            Next
            TextBox2.Text = sum.ToString("c")
        Catch ex As Exception
            MsgBox("something went wrong", MsgBoxStyle.Information)
        End Try



    End Sub
End Class
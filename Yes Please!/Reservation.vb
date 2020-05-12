Public Class Reservation
    Dim cusNo As Integer = 0
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Reservation_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Reservation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")
        Dim timer1 As Timer = New Timer
        'time.Start()
        ' timer1.Enabled = True
        'timer1.Start()
        Label3.Text = strDate
        'strDate = DateTimePicker1.Text
        'Label1.Text = DateTime.Now.ToString()
        'Label1.Text = Now.ToLongTimeString.ToString()
        'TODO: This line of code loads data into the 'Group6DataSet.RESERVATION' table. You can move, or remove it, as needed.
        Me.RESERVATIONTableAdapter.display_Reservation(Me.Group6DataSet.RESERVATION)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = Now.ToLongTimeString
        'Label.Text = TimeString
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Home.Show()


    End Sub



    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        reservation2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
        Catch ex As Exception
            MsgBox("search using the reservation number")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
            '   DataGridView1.
        Catch ex As Exception
            '  MsgBox("search using the reservation number")
        End Try
        If TextBox1.Text = "" Then
            Try
                Me.RESERVATIONTableAdapter.display_Reservation(Me.Group6DataSet.RESERVATION)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
  Me.Close()
        Home.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
        Catch ex As Exception
            MsgBox("search using the reservation number")
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Try
            RESERVATIONTableAdapter.searchReservation(Me.Group6DataSet.RESERVATION, TextBox1.Text)
        Catch ex As Exception
            MsgBox("search using the reservation number")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cust_registration.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        login.CustomerTableAdapter1.SearchCustomer(login.Group6DataSet1.CUSTOMER, TextBox1.Text)
        Try
            If login.Group6DataSet1.CUSTOMER.Rows.Count > 0 Then
                MsgBox("The Customer exist in the database")
                cusNo = login.Group6DataSet1.CUSTOMER.Rows(0).Item(0)
            Else
                MsgBox("The Customer does not exist ")
            End If
        Catch ex As Exception
            MsgBox("something went wrong!, check the supplied information")
        End Try
    End Sub
End Class
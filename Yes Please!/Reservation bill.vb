Public Class Reservation_bill

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Reservation_bill_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label6.Text = DateAndTime.Now
        Dim regDate As Date = Date.Now
        Dim duration As Integer
        regDate = reservation2.DateTimePicker1.Text
        duration = reservation2.duration1.Text
        Dim custname As String = reservation2.cust_name.Text
        Dim custsurname As String = reservation2.TextBox4.Text
        Dim Eventtype As String = reservation2.ComboBox1.SelectedItem
        Dim totalcost As String = reservation2.TextBox1.Text
        Dim time As String = reservation2.reservation_time.SelectedItem



        ListBox1.Items.Add("Reservation Start Date:       " & regDate)
        ListBox1.Items.Add("Duration:                     " & duration)
        ListBox1.Items.Add("Event Type:                    " & Eventtype)
        ListBox1.Items.Add("Customer:                     " & custname & " " & custsurname)
        ListBox1.Items.Add("Time:                          " & time)
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("                    ")
        ListBox1.Items.Add("TOTAL:                                              " & totalcost)
        ListBox1.Items.Add("................................................................")
        ListBox1.Items.Add("     Have a lovely day  ")

    End Sub
End Class
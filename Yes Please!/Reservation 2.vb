Public Class reservation2
    Dim order_n As Integer
    Dim total_cost As Double = 0


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click



        Dim state As Boolean = False
        Dim cus_no As String = 0
        Dim countclash As Integer
        'Dim reser_times As String = reservation_time
        Dim reser_time As Integer = reservation_time.SelectedItem



        total_cost = Double.Parse((duration1.Text) * 50 + no_of_people.SelectedItem * 50)
        TextBox1.Text = total_cost.ToString("c")
       
        Dim employee_no As Integer = 0

        Try
            login.WaiterTableAdapter1.getNumber(login.Group6DataSet1.WAITER, waiter_name.Text)
            'login.WaiterTableAdapter1.getName(login.Group6DataSet1.WAITER, waiter_name.Text)
            employee_no = login.Group6DataSet1.WAITER.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox("please enter all the required fields")
        End Try
        If waiter_name.Text <> "" Then
            'login.Group6DataSet1.WAITER.Rows(0).Item(0)
            login.WaiterTableAdapter1.getNumber(login.Group6DataSet1.WAITER, waiter_name.Text)
            employee_no = login.Group6DataSet1.WAITER.Rows(0).Item(0)
            'working   MsgBox("the employee number is  : " & employee_no)
        Else
            MsgBox("enter all required information")
        End If

        ' MsgBox("Please fill in all the required fields")

        Dim regDate As Date = Date.Now
        regDate = DateTimePicker1.Text

        Dim strDate As Date = regDate.Date
        ' MsgBox(strDate)
        ' strDate = DateTimePicker1.Text

        Dim no As Integer = 0
        Try
            no = login.CustomerTableAdapter1.getID(login.Group6DataSet1.CUSTOMER, cust_name.Text, id_no.Text)
        Catch ex As Exception
        End Try
        ' MsgBox(no & " records found")
        ' Catch ex As Exception
        ' MsgBox("please enter all the required fields")
        ' End Try
        If cust_name.Text <> "" Then
            'MsgBox("enter all required information")

            ''''' get customer number
            Try
                login.CustomerTableAdapter1.getID(login.Group6DataSet1.CUSTOMER, cust_name.Text, id_no.Text)
                cus_no = login.Group6DataSet1.CUSTOMER.Rows(0).Item(0)
                no = login.Group6DataSet1.CUSTOMER.Rows.Count

                'MsgBox("customer number" & cus_no)
                'working: finds the id of this customer    MsgBox(login.Group6DataSet1.CUSTOMER.Rows(0).Item(0))
            Catch ex As Exception

            End Try
        End If

        ' working perfecrtly: 
        ' MsgBox(login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER) & "MaximumSize number of orders")

        Dim previous As Integer = 0
        ' MsgBox("employee number is" & employee_no)
        ''Try

        ''login.OrderTableAdapter1.Insertorder(employee_no, strDate, 9, "reservation")
        ''   MsgBox("order inserted successfully..")
        ''  Catch ex As Exception
        ''MsgBox("cannot insert order")
        '' End Try
        Dim current As Integer = 0


        '''''' update number of orders of the employee responsible of this order

        ' login.OrderTableAdapter1.getEmpOrder(login.Group6DataSet1.ORDER, employee_no)
        Try
            login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
        Catch ex As Exception
            ' MsgBox("enter all required information")
        End Try
        Dim count As Integer = login.Group6DataSet1.ORDER.Rows.Count
        Try
            order_n = login.Group6DataSet1.ORDER.Rows(count - 1).Item(0)
        Catch ex As Exception
        End Try
        ' login.Group6DataSet1.me()
        ' MsgBox(login.Group6DataSet1.CUSTOMER.Rows(0).Item(0))
        'INSERT INTO [dbo].[ORDER] ([emp_no], [order_date], [order_cost], [table_no]) VALUES ( @emp_no, @order_date, @order_cost, @table_no);
        'SELECT order_no, emp_no, order_date, order_cost, table_no FROM [ORDER] WHERE (order_no = SCOPE_IDENTITY())

        login.ReservationTableAdapter1.CheckClash(login.Group6DataSet1.RESERVATION, strDate, reser_time)
        countclash = login.Group6DataSet1.RESERVATION.Rows.Count
        MsgBox("there is :  " & countclash & "  clashes")

        'MsgBox(group6DataSet \
        '    .RESERVATION.ROWS.COUNT)

        '  Dim check As String = ""

        'For Each row As DataRow In login.Group6DataSet1.RESERVATION.Rows
        'MsgBox(row("date"))
        ' check &= "  ," & row("date").ToString And reser_time.ToString = row("time").ToString
        '  If strDate.ToString = row("date").ToString And reser_time.ToString = row("time").ToString Then
        ' countclash += 1
        ' End If
        ' Next row
        ' MsgBox()
        ' MsgBox("number of claches" & "  " & countclash & "    " & check)
        Dim duration As Integer = 0
        Try
            duration = Int(Int(duration1.Text))
        Catch ex As Exception
        End Try

        If countclash < 1 And (DateTime.Compare(strDate, Date.Today) >= 0) Then
            If (no = 0 Or cust_name.Text = "") And waiter_name.Text <> "" And id_no.Text <> "" Then

                Try

                    previous = login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                    login.OrderTableAdapter1.Insertorder(employee_no, strDate, 9, "reservation")
                    current = login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                    MsgBox("order inserted successfully..")
                Catch ex As Exception
                End Try
                Try
                    order_n = login.Group6DataSet1.ORDER.Rows(count - 1).Item(0)

                    login.ReservationTableAdapter1.Insert2(order_n, strDate, duration, TextBox1.Text, reser_time)
                    MsgBox("reservation added successfully")
                    state = True
                Catch ex As Exception
                End Try
            End If
            If no = 1 And cust_name.Text <> "" And waiter_name.Text <> "" And id_no.Text <> "" Then
                Try
                    previous = login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                    login.OrderTableAdapter1.Insertorder(employee_no, strDate, 9, "reservation")
                    current = login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                    MsgBox("order inserted successfully..")

                    Try
                        order_n = login.Group6DataSet1.ORDER.Rows(count - 1).Item(0)
                        login.ReservationTableAdapter1.InsertReservation(cus_no, order_n, strDate, duration, TextBox1.Text, reser_time)
                        MsgBox("reservation added successfully")
                        state = True
                    Catch ex As Exception
                        MsgBox("could not add reseration")
                    End Try
                Catch ex As Exception
                    MsgBox("cannot insert order")
                End Try

            Else
                ' MsgBox("enter all required information")
            End If
        Else
            MsgBox("select a correct date! or the lunchbox might already have been booked")
            state = False
        End If
        If current > previous Then

            login.WaiterTableAdapter1.IncreaseNUmOfOrders(employee_no)
        End If
        '  If countclash > 0 Then
        '
        '  Else

        '  Try
        '  login.ReservationTableAdapter1.InsertReservation(cus_no, order_n, strDate, Int(Int(duration1.Text)), reser_time)
        ' MsgBox("reservation added successfully")
        '   Catch ex As Exception
        ' MsgBox("reservation not added")
        '  End Try

        '  Catch ex As Exception
        '  MsgBox("make sure all the fields have have values")
        'MsgBox("reservation added successfully")
        '    End Try
        'End If

        ' Dim I As Integer
        'Dim max As Integer = login.Group6DataSet1.WAITER.Rows(I).Item("no_of_orders")
        'For I = 0 To login.Group6DataSet1.WAITER.Rows.Count - 1

        ' max += 1
        'login.Group6DataSet1.WAITER.Rows(I).Item("no_of_orders") = max

        ' Next
        ' login.WaiterTableAdapter1.Update(login.Group6DataSet1.WAITER)
        'If duration1.Text.ToString <> "" And no_of_people.SelectedItem.ToString <> "" Then

        'End If
        If state = True Then
            reservation_ordered_items.Show()


        Else
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Reservation.Show()

    End Sub

    Private Sub reservation2_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '  MessagesTableAdapter1.InsertQuery(2, )
    '  End Sub

    Private Sub reservation2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' TextBox1.Text = login.OrdeR_ITEMTableAdapter1.get_Total_cost(login.Group6DataSet1.ORDER_ITEM)
        TextBox1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub reservation_time_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles reservation_time.SelectedIndexChanged

    End Sub

    Private Sub no_of_people_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles no_of_people.SelectedIndexChanged

    End Sub

    Private Sub duration1_TextChanged(sender As System.Object, e As System.EventArgs) Handles duration1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Reservation_bill.Show()
        Button2.Enabled = True

    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        Me.Close()
        Home.Show()

    End Sub
End Class
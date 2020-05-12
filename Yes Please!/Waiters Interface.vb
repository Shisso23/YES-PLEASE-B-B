Public Class WaiterF
    Dim price1 As Double = 0
    Dim price2 As Double = 0
    Dim price3 As Double = 0
    Dim price4 As Double = 0
    Dim current_query As Integer = 0
    Public total1 As Double = 0

    Dim qty1 As Integer = 0
    Dim qty2 As Integer = 0
    Dim qty3 As Integer = 0
    Dim qty4 As Integer = 0

    Dim control1 As Integer = 0
    Dim control2 As Integer = 1
    Dim control3 As Integer = 2
    Dim control4 As Integer = 3
    Public submt As Integer = 0

    'the declarations below are specifically for creating an order to database
    Public tableNo As Integer = 0
    Public emp_num As Integer = 0
    Public datenow As DateTime
    Public type As String = " "
    Dim confirm As Integer = 0
    'customer loyalty points
    Public customerNo As Integer = 0
    Public custpoint As Integer




    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        cust_registration.Show()
        'Me.Hide()
    End Sub

    Private Sub WaiterF_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub WaiterF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Button23.Enabled = False
        ListBox1.Items.Clear()
        For i As Integer = 0 To Waiters_Interface2.ListBox1.Items.Count - 1
            ListBox1.Items.Add(Waiters_Interface2.ListBox1.Items(i))
        Next

        login.WaiterTableAdapter1.employeeData(login.Group6DataSet1.WAITER, login.Custname) 'getting emp no using emp username got from login
        Try
            emp_num = login.Group6DataSet1.WAITER.Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox("the system failed to get employee number of currently logged in waiter! you must be a manager.")
        End Try
        Label16.Text = login.Custname

        Button17.Enabled = True
        Waiters_Interface2.Close()
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3

        current_query = 1 'we system form is running the main query
        Label12.Text = "Our Speciality dishes"
        login.MenU_ITEMTableAdapter1.Fill(login.Group6DataSet1.MENU_ITEM)
        Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
        Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString  'taking old items which were added first in the database
        Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
        cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
        Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString

        Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
        Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
        Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
        Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString

        Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString  'taking old items which were added first in the database
        Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
        Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
        Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString

        Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
        Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
        Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
        Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString


    End Sub

    Private Sub description1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        current_query = 2 'we system form is running query2
        Dim name As String = "chicken/beef dishes"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        current_query = 3 'we system form is running query3
        Dim name As String = "lunch ala carte"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        current_query = 4 'we system form is running query4
        Dim name As String = "side dishes"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3

        current_query = 5 'we system form is running query5
        Dim name As String = "toasted sandwiches"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3

        current_query = 6 'we system form is running query6
        Dim name As String = "beverages"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        current_query = 7 'we system form is running query7
        Dim name As String = "in house ala carte"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("you might have zero or less information in your database")
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            price1 += Double.Parse(Label45.Text)
            qty1 = CInt(TextBox6.Text)
            total1 += (price1 * qty1)
            ListBox1.Items.Add(Labelone.Text + vbNewLine + "    |    " & qty1 & "x  " & price1)
            'Waiters_Interface2.ListBox1.Items.Add(Labelone.Text + vbNewLine + "        " & qty1 & "x  " & price1)
            kitchen_display.ListBox1.Items.Add(Labelone.Text + vbNewLine + "        " & qty1 & "x  " & price1)
        Catch ex As Exception
            MsgBox("you can not have zero as quantity")
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            price2 += Double.Parse(Label33.Text)
            qty2 = CInt(TextBox3.Text)
            total1 += (price2 * qty2)
            ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "    |    " & qty2 & "x  " & price2)
            'Waiters_Interface2.ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "        " & qty2 & "x  " & price2)
            kitchen_display.ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "        " & qty2 & "x  " & price2)
        Catch ex As Exception
            MsgBox("you cannot have zero as quantity")
        End Try
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            price3 += Double.Parse(Label48.Text)
            qty3 = CInt(TextBox4.Text)
            total1 += (price3 * qty3)
            ListBox1.Items.Add(Labeltri.Text + vbNewLine + "     |   " & qty3 & "x  " & price3)
            'Waiters_Interface2.ListBox1.Items.Add(Labeltri.Text + vbNewLine + "        " & qty3 & "x  " & price3)
            kitchen_display.ListBox1.Items.Add(Labeltri.Text + vbNewLine + "        " & qty3 & "x  " & price3)
        Catch ex As Exception
            MsgBox("you cannot have zero quantity")
        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Try
            price4 += Double.Parse(Label36.Text)
            qty4 = CInt(TextBox5.Text)
            total1 += (price4 * qty4)
            ListBox1.Items.Add(Labelfou.Text + vbNewLine + "    |    " & qty4 & "x  " & price4)
            'Waiters_Interface2.ListBox1.Items.Add(Labelfou.Text + vbNewLine + "        " & qty4 & "x  " & price4)
            kitchen_display.ListBox1.Items.Add(Labelfou.Text + vbNewLine + "        " & qty4 & "x  " & price4)
        Catch ex As Exception
            MsgBox("you cannot have quantity as zero")
        End Try
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        'here we gonna add order items to the database


        If confirm = 1 Then
            Try
                submt = 1
                TextBox1.Text = total1 + Waiters_Interface2.total2
                Waiters_Interface2.TextBox1.Text = total1 + Waiters_Interface2.total2
                MsgBox("Order Submitted successfully!")
                kitchen_display.Show()

                'adding order_items
                Dim ordernum As Integer
                login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                If login.Group6DataSet1.ORDER.Rows.Count > 0 Then
                    ordernum = login.Group6DataSet1.ORDER.Rows(login.Group6DataSet1.ORDER.Rows.Count - 1).Item(0)
                End If

            Catch ex As Exception
                MsgBox("something went wrong!, check all the entered information")
            End Try

        Else
            MsgBox("create!")
        End If

    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Dim answer As String = InputBox("Enter your password", "Password Confirmation")
        login.UserTableAdapter1.VoidItem(login.Group6DataSet1.USER, answer)
        Try
            If login.Group6DataSet1.USER.Rows.Count > 0 Then
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            ElseIf answer.Length = 0 Then
                MessageBox.Show("Please eneter valid password!")
            Else
                MessageBox.Show("wrong password!")
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Text = "    "
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel8_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click

        login.CustomerTableAdapter1.SearchCustomer(login.Group6DataSet1.CUSTOMER, TextBox2.Text)
        Try
            If login.Group6DataSet1.CUSTOMER.Rows.Count > 0 Then
                MsgBox("The Customer exists in the database")
                customerNo = login.Group6DataSet1.CUSTOMER.Rows(0).Item(0)
            Else
                MsgBox("The Customer does not exist ")
            End If
        Catch ex As Exception
            MsgBox("something went wrong!, check the supplied information")
        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click
        If control1 = 0 Then  'we can not have negative indexing!!
            control1 = 0
            control2 = 1
            control3 = 2
            control4 = 3
        Else
            control1 -= 4
            control2 -= 4
            control3 -= 4
            control4 -= 4
        End If

        'This Navigation button has to know which category is navigating for
        If current_query = 1 Then
            login.MenU_ITEMTableAdapter1.Fill(login.Group6DataSet1.MENU_ITEM)
        ElseIf current_query = 2 Then
            Dim name As String = "chicken/beef dishes"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 3 Then
            Dim name As String = "lunch ala carte"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 4 Then
            Dim name As String = "side dishes"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 5 Then
            Dim name As String = "toasted sandwiches"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 6 Then
            Dim name As String = "beverages"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 7 Then
            Dim name As String = "in house ala carte"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        End If

        Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
        Try
            Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
            Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
            cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
            Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString

            Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
            Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
            Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
            Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString


            Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
            Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
            Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
            Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString


            Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
            Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
            Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
            Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
        Catch ex As Exception
            MsgBox("no more items!")
        End Try


    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        'This Navigation button has to know which category is navigating for
        If current_query = 1 Then
            login.MenU_ITEMTableAdapter1.Fill(login.Group6DataSet1.MENU_ITEM)
        ElseIf current_query = 2 Then
            Dim name As String = "chicken/beef dishes"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 3 Then
            Dim name As String = "lunch ala carte"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 4 Then
            Dim name As String = "side dishes"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 5 Then
            Dim name As String = "toasted sandwiches"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 6 Then
            Dim name As String = "beverages"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        ElseIf current_query = 7 Then
            Dim name As String = "in house ala carte"
            login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        End If

        Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
        If numrows >= control4 * 2 Then 'we can still get more 4 rows
            control1 += 4
            control2 += 4
            control3 += 4
            control4 += 4
        Else  'we can not move now we have terminated rows
            control1 = control1
            control2 = control2
            control3 = control3
            control4 = control4
        End If
        Try
            If numrows >= (control4 + 1) Then 'we still have rows increasingly
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                cat41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
            End If

            If numrows >= (control4 + 2) Then
                Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString 'taking new
                Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
            End If
            If numrows >= (control4 + 3) Then
                Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString
                Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
            End If
            If numrows >= (control4 + 4) Then
                Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString 'taking new items
                Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
            End If

        Catch ex As Exception
            MsgBox("no more items!")
        End Try
    End Sub


    Private Sub Label32_Click(sender As System.Object, e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click

        If total1 <> 0 Then
            TextBox1.Text = total1 + Waiters_Interface2.total2 'order cost to int
            Waiters_Interface2.TextBox1.Text = total1 + Waiters_Interface2.total2
            Dim name As String
            Try
                If ComboBox1.SelectedItem.ToString <> " " And ComboBox2.SelectedItem.ToString <> " " Then
                    tableNo = CInt(ComboBox1.SelectedItem)
                    type = ComboBox2.SelectedItem.ToString
                    datenow = Date.Now.ToString("yyyy/MM/dd")
                End If
            Catch ex As Exception
                MsgBox("please select table number and order type!")
            End Try

            'now adding the order to database
            Try
                login.OrderTableAdapter1.orderCreation(emp_num, datenow, CInt(TextBox1.Text), tableNo, type)
                confirm = 1
                MsgBox("the order was added successfully!")
                name = Label16.Text.ToString
                login.WaiterTableAdapter1.AddPoints(name) 'adding number of orders made by a waiter

                'adding customer loyalty points.
                If customerNo <> 0 Then
                    If CInt(TextBox1.Text) >= 100 And CInt(TextBox1.Text) < 200 Then
                        login.CustomerTableAdapter1.oneP(customerNo)
                    ElseIf CInt(TextBox1.Text) >= 200 And CInt(TextBox1.Text) < 300 Then
                        login.CustomerTableAdapter1.twoP(customerNo)
                    ElseIf CInt(TextBox1.Text) >= 300 Then
                        login.CustomerTableAdapter1.threeP(customerNo)
                    End If
                End If

            Catch ex As Exception
                MsgBox("order creation failed!")
            End Try
        Else
            MsgBox("No items were added!")

        End If

    End Sub

    Private Sub time_Click(sender As System.Object, e As System.EventArgs) Handles time.Click

    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        submt = 0
        Try
            tableNo = CInt(ComboBox1.SelectedItem)
            type = ComboBox2.SelectedItem.ToString
            Waiters_Interface2.Button24.Enabled = True
            Waiters_Interface2.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("please select a table number and order type first!")
        End Try

    End Sub


    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Bill.Show()


        ListBox1.Items.Clear()
        Waiters_Interface2.ListBox1.Items.Clear()
        TextBox1.Text = " "
        Waiters_Interface2.TextBox1.Text = " "
        TextBox6.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        Waiters_Interface2.TextBox3.Text = " "
        Waiters_Interface2.TextBox4.Text = " "
        Waiters_Interface2.TextBox5.Text = " "
        Waiters_Interface2.TextBox6.Text = " "
        Waiters_Interface2.TextBox7.Text = " "
        Waiters_Interface2.TextBox8.Text = " "
        Waiters_Interface2.TextBox9.Text = " "
        Waiters_Interface2.TextBox10.Text = " "
        Waiters_Interface2.TextBox11.Text = " "
        Waiters_Interface2.TextBox12.Text = " "

    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Waiters_Interface2.Hide()
        Home.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button23.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub



  

  
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Allocation.Show()
    End Sub
    Dim num As Integer = 1
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Select Case num 'Chicken and Beef Dishes
            Case 1
                PictureBox1.Image = My.Resources._001
                Label7.Text = "Chicken Burger"
                num = 2
            Case 2
                PictureBox1.Image = My.Resources._002
                Label7.Text = "Beef Burger"
                num = 3
            Case 3
                PictureBox1.Image = My.Resources._008
                Label7.Text = "Cheese and Pineapple"
                num = 4
            Case 4
                PictureBox1.Image = My.Resources._009
                Label7.Text = "Bacon and Feta Cheese"
                num = 5
            Case 5
                PictureBox1.Image = My.Resources._048
                Label7.Text = "Elongated Hamburger"
                num = 6
            Case 6
                PictureBox1.Image = My.Resources._052
                Label7.Text = "Chicken Strips"
                num = 7
            Case 7
                PictureBox1.Image = My.Resources._056
                Label7.Text = "Chicken Wings"
                num = 8
            Case 8
                PictureBox1.Image = My.Resources._063
                Label7.Text = "Pepper Steak Pie"
                num = 1
            Case 9
                PictureBox1.Image = My.Resources._058
                Label7.Text = "Steak and Kidney Pie"
                num = 9
            Case 10
                PictureBox1.Image = My.Resources._062
                Label7.Text = "Roasted Chicken"
                num = 1
        End Select
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Select Case num 'Lunch Ala Carte
            Case 1
                PictureBox2.Image = My.Resources._006
                Label8.Text = "Cheese Russian Dog"
                num = 2
            Case 2
                PictureBox2.Image = My.Resources._013
                Label8.Text = "Beef Burger, Chips and Salad"
                num = 3
            Case 3
                PictureBox2.Image = My.Resources._018
                Label8.Text = "Chicken Schnitzel"
                num = 4
            Case 4
                PictureBox2.Image = My.Resources._023
                Label8.Text = "Mutton Curry"
                num = 5
            Case 5
                PictureBox2.Image = My.Resources._028
                Label8.Text = "Chicken Curry"
                num = 6
            Case 6
                PictureBox2.Image = My.Resources._034
                Label8.Text = "Beef Curry"
                num = 7
            Case 7
                PictureBox2.Image = My.Resources._037
                Label8.Text = "Traditional Hake"
                num = 8
            Case 8
                PictureBox2.Image = My.Resources._046
                Label8.Text = "Vegetarian Burger"
                num = 9
            Case 9
                PictureBox2.Image = My.Resources._050
                Label8.Text = "Chicken Strips"
                num = 10
            Case 10
                PictureBox2.Image = My.Resources._054
                Label8.Text = "Steak Plain"
                num = 1
        End Select
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Select Case num 'Side Dishes
            Case 1
                PictureBox3.Image = My.Resources._004
                Label9.Text = "Chips Small Plate"
                num = 2
            Case 2
                PictureBox3.Image = My.Resources._011
                Label9.Text = "Chips Large Plate"
                num = 3
            Case 3
                PictureBox3.Image = My.Resources._016
                Label9.Text = "Garden Salad (small)"
                num = 4
            Case 4
                PictureBox3.Image = My.Resources._021
                Label9.Text = "Garden Salad (Large)"
                num = 5
            Case 5
                PictureBox3.Image = My.Resources._026
                Label9.Text = "Feta Cheese Portion"
                num = 6
            Case 6
                PictureBox3.Image = My.Resources._031
                Label9.Text = "Olives Portion"
                num = 7
            Case 7
                PictureBox3.Image = My.Resources._035
                Label9.Text = "Cheese Slice"
                num = 8
            Case 8
                PictureBox3.Image = My.Resources._038
                Label9.Text = "Bread Rolls"
                num = 9
            Case 9
                PictureBox3.Image = My.Resources._044
                Label9.Text = "Hot Sauce"
                num = 10
            Case 10
                PictureBox3.Image = My.Resources._045
                Label9.Text = "Cheese and Corn Samoosa"
                num = 1
        End Select
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Select Case num 'Toasted Sandwiches
            Case 1
                PictureBox4.Image = My.Resources._003
                Label6.Text = "Chicken and Mayo Sandwich"
                num = 2
            Case 2
                PictureBox4.Image = My.Resources._015
                Label6.Text = "Chicken Chilli Sandwich"
                num = 3
            Case 3
                PictureBox4.Image = My.Resources._020
                Label6.Text = "Prego Steak and Cheese Sandwich"
                num = 4
            Case 4
                PictureBox4.Image = My.Resources._025
                Label6.Text = "Steak, Cheese and Gherkin Sandwich"
                num = 5
            Case 5
                PictureBox4.Image = My.Resources._030
                Label6.Text = "Steak, Egg and Cheese"
                num = 6
            Case 1
                PictureBox4.Image = My.Resources._049
                Label6.Text = "Cheese and Tomato Sandwich"
                num = 7
            Case 2
                PictureBox4.Image = My.Resources._053
                Label6.Text = "Toasted Turkey Sandwich"
                num = 8
            Case 3
                PictureBox4.Image = My.Resources._061
                Label6.Text = "Peanut Butter Sandwich"
                num = 9
            Case 4
                PictureBox4.Image = My.Resources._066
                Label6.Text = "Toasted Apple and Brie"
                num = 10
            Case 5
                PictureBox4.Image = My.Resources._057
                Label6.Text = "Tuna Paste Toastie"
                num = 1
        End Select
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Select Case num 'Beverages
            Case 1
                PictureBox5.Image = My.Resources._005
                Label5.Text = "Jacobs Coffee"
                num = 2
            Case 2
                PictureBox5.Image = My.Resources._012
                Label5.Text = "Five Roses Tea"
                num = 3
            Case 3
                PictureBox5.Image = My.Resources._017
                Label5.Text = "Rooibos Tea"
                num = 4
            Case 4
                PictureBox5.Image = My.Resources._022
                Label5.Text = "Hot Chocolate"
                num = 5
            Case 5
                PictureBox5.Image = My.Resources._027
                Label5.Text = "Filter Coffee"
                num = 6
            Case 6
                PictureBox5.Image = My.Resources._032
                Label5.Text = "Exotic Tea"
                num = 7
            Case 7
                PictureBox5.Image = My.Resources._033
                Label5.Text = "Soda Cans"
                num = 8
            Case 8
                PictureBox5.Image = My.Resources._040
                Label5.Text = "Imported Beers"
                num = 9
            Case 9
                PictureBox5.Image = My.Resources._041
                Label5.Text = "Imported Ciders"
                num = 10
            Case 10
                PictureBox5.Image = My.Resources._042
                Label5.Text = "House Wine Red"
                num = 11
            Case 11
                PictureBox5.Image = My.Resources._043
                Label5.Text = "House Wine White"
                num = 1
        End Select
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Select Case num 'In House Ala Carte
            Case 1
                PictureBox6.Image = My.Resources._007
                Label4.Text = "Chicken Burger, Chips and Salad"
                num = 2
            Case 2
                PictureBox6.Image = My.Resources._014
                Label4.Text = "Cornish Pasty and Chips"
                num = 3
            Case 3
                PictureBox6.Image = My.Resources._019
                Label4.Text = "Pork Sausages"
                num = 4
            Case 4
                PictureBox6.Image = My.Resources._024
                Label4.Text = "Chuck Steak, Pap and Chakalaka"
                num = 5
            Case 5
                PictureBox6.Image = My.Resources._029
                Label4.Text = "Boerewors, Mashed Potato and Salad"
                num = 1
            Case 6
                PictureBox6.Image = My.Resources._047
                Label4.Text = "Beans Curry (Vegeterian)"
                num = 2
            Case 7
                PictureBox6.Image = My.Resources._051
                Label4.Text = "Lamb Bruchette"
                num = 3
            Case 8
                PictureBox6.Image = My.Resources._064
                Label4.Text = "Blue Cheese, Pear and Chutney"
                num = 4
            Case 9
                PictureBox6.Image = My.Resources._067
                Label4.Text = "Roasted Veggies"
                num = 5
            Case 10
                PictureBox6.Image = My.Resources._065
                Label4.Text = "Kosher Turkey, Salad and Strips"
                num = 1
        End Select
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub
End Class
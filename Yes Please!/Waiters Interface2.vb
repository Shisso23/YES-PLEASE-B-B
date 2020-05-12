Public Class Waiters_Interface2

    Dim current_query As Integer = 0
    Dim current_order_number As Integer = 0  ' '''''''''''''''''''''''''''''''''''''''''''''''i added this to get the current order_no. now initialized to 0
    Dim price1 As Double = 0
    Dim price2 As Double = 0
    Dim price3 As Double = 0
    Dim price4 As Double = 0
    Dim price5 As Double = 0
    Dim price6 As Double = 0
    Dim price7 As Double = 0
    Dim price8 As Double = 0
    Dim price9 As Double = 0
    Dim price10 As Double = 0

    Public total2 As Double = 0
    Public submt2 As Integer = 0
    Public tableNo As Integer = 0
    Dim qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8, qty9, qty10 As Integer

    Dim control1 As Integer = 0
    Dim control2 As Integer = 1
    Dim control3 As Integer = 2
    Dim control4 As Integer = 3
    Dim control5 As Integer = 4
    Dim control6 As Integer = 5
    Dim control7 As Integer = 6
    Dim control8 As Integer = 7
    Dim control9 As Integer = 8
    Dim control10 As Integer = 9

    'the following is for order creation
    Dim confirm As Integer = 0
    Public datenow As DateTime






    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Labeltr.Click

    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Labelse.Click

    End Sub

    Private Sub Label53_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label60_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            price1 += Double.Parse(Label45.Text)
            qty1 = CInt(TextBox3.Text)
            total2 += (price1 * qty1)
            ListBox1.Items.Add(Labelone.Text + vbNewLine + "    |    " & qty1 & "x  " & price1)
            'WaiterF.ListBox1.Items.Add(Labelone.Text + vbNewLine + "    |    " & qty1 & "x  " & price1)
            kitchen_display.ListBox1.Items.Add(Labelone.Text + vbNewLine + "    |    " & qty1 & "x  " & price1)
        Catch ex As Exception
            MsgBox("you cannot have 0 in quantity field")
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        login.CustomerTableAdapter1.SearchCustomer(login.Group6DataSet1.CUSTOMER, TextBox2.Text)
        Try
            If login.Group6DataSet1.CUSTOMER.Rows.Count > 0 Then
                MsgBox("The Customer exist in the database", "Customer Check")
                WaiterF.customerNo = login.Group6DataSet1.CUSTOMER.Rows(0).Item(0)
            Else
                MsgBox("The Customer does not exist ")
            End If
        Catch ex As Exception
            MsgBox("something went wrong!, re-try")
        End Try
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Waiters_Interface2_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Waiters_Interface2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        For i As Integer = 0 To WaiterF.ListBox1.Items.Count - 1
            ListBox1.Items.Add(WaiterF.ListBox1.Items(i))
        Next
        Label16.Text = WaiterF.Label16.Text

        Button24.Enabled = True
        WaiterF.Hide()
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        current_query = 1 'we system form is running the main query
        Label12.Text = "Our Speciality dishes"
        login.MenU_ITEMTableAdapter1.Fill(login.Group6DataSet1.MENU_ITEM)
        Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
        Try
            Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
            Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
            Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
            Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

            Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
            Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
            Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
            Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString

            Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
            Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
            Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
            Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

            Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
            Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
            Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
            Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString

            Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
            Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
            Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
            Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString

            Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
            Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
            Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
            Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString

            Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
            Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
            Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
            Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString

            Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
            Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
            Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
            Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString

            Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
            Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
            Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
            Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString

            Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
            Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
            Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
            Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString



        Catch ex As Exception
            MsgBox("you might have searched for unexisting information")
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
        If numrows = control10 Then
            'we can not move now we have terminated rows
            control1 = control1
            control2 = control2
            control3 = control3
            control4 = control4
            control5 = control5
            control6 = control6
            control7 = control7
            control8 = control8
            control9 = control9
            control10 = control10

        ElseIf numrows >= (control10 * 2) Then 'we can still get more 10 rows
            control1 += 10
            control2 += 10
            control3 += 10
            control4 += 10
            control5 += 10
            control6 += 10
            control7 += 10
            control8 += 10
            control9 += 10
            control10 += 10

        ElseIf numrows < (control10 * 2) And numrows > control10 Then 'we can not increase by 10 rows, but we can check and increase 1 by 1

            If numrows >= (control10 + 1) Then
                control1 += 10 'we can get 1 more rows from our query
            End If
            If numrows >= (control10 + 2) Then
                control2 += 10 'we can get 2 more rows from our query
            End If
            If numrows >= (control10 + 3) Then
                control3 += 10 'we can get 3 more rows from our query AND SO ON
            End If
            If numrows >= (control10 + 4) Then
                control4 += 10
            End If
            If numrows >= (control10 + 5) Then
                control5 += 10
            End If
            If numrows >= (control10 + 6) Then
                control6 += 10
            End If
            If numrows >= (control10 + 7) Then
                control7 += 10
            End If
            If numrows >= (control10 + 8) Then
                control8 += 10
            End If
            If numrows >= (control10 + 9) Then
                control9 += 10
            End If
        End If

        Try
            Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
            Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
            Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
            Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

            Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
            Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
            Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
            Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString

            Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
            Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
            Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
            Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

            Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
            Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
            Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
            Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString

            Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
            Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
            Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
            Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString

            Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
            Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
            Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
            Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString

            Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
            Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
            Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
            Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString

            Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
            Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
            Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
            Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString

            Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
            Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
            Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
            Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString

            Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
            Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
            Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
            Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
        Catch ex As Exception
            MsgBox("no more items!")
        End Try

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            price2 += Double.Parse(Label33.Text)
            qty2 = CInt(TextBox4.Text)
            total2 += (price2 * qty2)
            ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "    |    " & qty2 & "x  " & price2)
            ' WaiterF.ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "    |    " & qty2 & "x  " & price2)
            kitchen_display.ListBox1.Items.Add(Labeltwo.Text + vbNewLine + "    |    " & qty2 & "x  " & price2)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            price3 += Double.Parse(Label48.Text)
            qty3 = CInt(TextBox5.Text)
            total2 += (price3 * qty3)
            ListBox1.Items.Add(Labeltri.Text + vbNewLine + "    |    " & qty3 & "x  " & price3)
            'WaiterF.ListBox1.Items.Add(Labeltri.Text + vbNewLine + "    |   " & qty3 & "x  " & price3)
            kitchen_display.ListBox1.Items.Add(Labeltri.Text + vbNewLine + "    |    " & qty3 & "x  " & price3)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Try
            price4 += Double.Parse(Label36.Text)
            qty4 = CInt(TextBox6.Text)
            total2 += (price4 * qty4)
            ListBox1.Items.Add(Labelfou.Text + vbNewLine + "    |    " & qty4 & "x  " & price4)
            'WaiterF.ListBox1.Items.Add(Labelfou.Text + vbNewLine + "    |    " & qty4 & "x  " & price4)
            kitchen_display.ListBox1.Items.Add(Labelfou.Text + vbNewLine + "    |    " & qty4 & "x  " & price4)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Try
            price5 += Double.Parse(Label51.Text)
            qty5 = CInt(TextBox7.Text)
            total2 += (price5 * qty5)
            ListBox1.Items.Add(Labelfiv.Text + vbNewLine + "    |    " & qty5 & "x  " & price5)
            'WaiterF.ListBox1.Items.Add(Labelfiv.Text + vbNewLine + "    |    " & qty5 & "x  " & price5)
            kitchen_display.ListBox1.Items.Add(Labelfiv.Text + vbNewLine + "     |   " & qty5 & "x  " & price5)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Try
            price6 += Double.Parse(Label50.Text)
            qty6 = CInt(TextBox8.Text)
            total2 += (price6 * qty6)
            ListBox1.Items.Add(Labelsix.Text + vbNewLine + "    |    " & qty6 & "x  " & price6)
            'WaiterF.ListBox1.Items.Add(Labelsix.Text + vbNewLine + "    |    " & qty6 & "x  " & price6)
            kitchen_display.ListBox1.Items.Add(Labelsix.Text + vbNewLine + "    |    " & qty6 & "x  " & price6)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try


    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Try
            price7 += Double.Parse(Label39.Text)
            qty7 = CInt(TextBox9.Text)
            total2 += (price7 * qty7)
            ListBox1.Items.Add(Labelsev.Text + vbNewLine + "    |    " & qty7 & "x  " & price7)
            'WaiterF.ListBox1.Items.Add(Labelsev.Text + vbNewLine + "    |    " & qty7 & "x  " & price7)
            kitchen_display.ListBox1.Items.Add(Labelsev.Text + vbNewLine + "    |    " & qty7 & "x  " & price7)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try

    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Try
            price8 += Double.Parse(Label31.Text)
            qty8 = CInt(TextBox10.Text)
            total2 += (price8 * qty8)
            ListBox1.Items.Add(Labeleig.Text + vbNewLine + "    |    " & qty8 & "x  " & price8)
            'WaiterF.ListBox1.Items.Add(Labeleig.Text + vbNewLine + "    |    " & qty8 & "x  " & price8)
            kitchen_display.ListBox1.Items.Add(Labeleig.Text + vbNewLine + "    |    " & qty8 & "x  " & price8)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Try
            price9 += Double.Parse(Label27.Text)
            qty9 = CInt(TextBox11.Text)
            total2 += (price9 * qty9)
            ListBox1.Items.Add(Labelnin.Text + vbNewLine + "    |    " & qty9 & "x  " & price9)
            'WaiterF.ListBox1.Items.Add(Labelnin.Text + vbNewLine + "    |    " & qty9 & "x  " & price9)
            kitchen_display.ListBox1.Items.Add(Labelnin.Text + vbNewLine + "    |    " & qty9 & "x  " & price9)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try

    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Try
            price10 += Double.Parse(Label55.Text)
            qty10 = CInt(TextBox12.Text)
            total2 += (price10 * qty10)
            ListBox1.Items.Add(Labelten.Text + vbNewLine + "    |    " & qty10 & "x  " & price10)
            'WaiterF.ListBox1.Items.Add(Labelten.Text + vbNewLine + "    |    " & qty10 & "x  " & price10)
            kitchen_display.ListBox1.Items.Add(Labelsix.Text + vbNewLine + "    |    " & qty10 & "x  " & price10)
        Catch ex As Exception
            MsgBox("you can not have quantity as zero")
        End Try

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        cust_registration.Show()
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        current_query = 2 'we system form is running query2
        Dim name As String = "chicken/beef dishes"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9


        current_query = 3 'we system form is running query3
        Dim name As String = "lunch ala carte"
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        Dim name As String = "side dishes"
        current_query = 4 'we system form is running query4
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        Dim name As String = "toasted sandwiches"
        current_query = 5 'we system form is running query5
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        Dim name As String = "beverages"
        current_query = 6 'we system form is running query6
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        control1 = 0
        control2 = 1
        control3 = 2
        control4 = 3
        control5 = 4
        control6 = 5
        control7 = 6
        control8 = 7
        control9 = 8
        control10 = 9

        Dim name As String = "in house ala carte"
        current_query = 7 'we system form is running query7
        login.MenU_ITEMTableAdapter1.Categories(login.Group6DataSet1.MENU_ITEM, name)
        Try
            If login.Group6DataSet1.MENU_ITEM.Rows.Count > 0 Then
                Dim numrows As Integer = login.Group6DataSet1.MENU_ITEM.Rows.Count
                Labelone.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(1)).ToString
                Labelon.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(2)).ToString
                Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
                Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

                If numrows >= 2 Then
                    Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
                    Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
                    Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
                    Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString
                End If
                If numrows >= 3 Then
                    Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
                    Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
                    Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
                    Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

                End If
                If numrows >= 4 Then
                    Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
                    Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
                    Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
                    Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString
                End If
                If numrows >= 5 Then
                    Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
                    Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
                    Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
                    Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString
                End If
                If numrows >= 6 Then
                    Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
                    Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
                    Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
                    Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString
                End If
                If numrows >= 7 Then
                    Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
                    Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
                    Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
                    Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString
                End If
                If numrows >= 8 Then
                    Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
                    Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
                    Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
                    Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString
                End If
                If numrows >= 9 Then
                    Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
                    Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
                    Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
                    Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString
                End If
                If numrows >= 10 Then
                    Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
                    Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
                    Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
                    Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
                End If


            End If
        Catch ex As Exception
            MsgBox("something went wrong!")
        End Try
    End Sub

   

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If confirm = 1 Then
            Try
                submt2 = 1
                TextBox1.Text = WaiterF.total1 + total2
                WaiterF.TextBox1.Text = WaiterF.total1 + total2
                MsgBox("Order Submitted successfully!")
                kitchen_display.Show()


                'adding order_items
                Dim ordernum As Integer
                login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                If login.Group6DataSet1.ORDER.Rows.Count > 0 Then
                    ordernum = login.Group6DataSet1.ORDER.Rows(login.Group6DataSet1.ORDER.Rows.Count - 1).Item(0)
                End If

            Catch ex As Exception
                MsgBox("something went wrong")
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
            MsgBox("something went wrong!")
        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click
        If control1 >= 10 Then 'we can still get more 10 rows when decreasing or naviagting up
            control1 -= 10
            control2 -= 10
            control3 -= 10
            control4 -= 10
            control5 -= 10
            control6 -= 10
            control7 -= 10
            control8 -= 10
            control9 -= 10
            control10 -= 10

        Else  'we can not move now we have terminated rows
            control1 = control1
            control2 = control2
            control3 = control3
            control4 = control4
            control5 = control5
            control6 = control6
            control7 = control7
            control8 = control8
            control9 = control9
            control10 = control10

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
            Label45.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(5)).ToString
            Label41.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control1).Item(4)).ToString

            Labeltwo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(1)).ToString
            Labeltw.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(2)).ToString
            Label33.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(5)).ToString
            Label29.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control2).Item(4)).ToString

            Labeltri.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(1)).ToString
            Labeltr.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(2)).ToString
            Label48.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(5)).ToString
            Label44.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control3).Item(4)).ToString

            Labelfou.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(1)).ToString
            Labelfo.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(2)).ToString
            Label36.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(5)).ToString
            Label32.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control4).Item(4)).ToString

            Labelfiv.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(1)).ToString
            Labelfi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(2)).ToString
            Label51.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(5)).ToString
            Label47.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control5).Item(4)).ToString

            Labelsix.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(1)).ToString
            Labelsi.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(2)).ToString
            Label50.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(5)).ToString
            Label46.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control6).Item(4)).ToString

            Labelsev.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(1)).ToString
            Labelse.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(2)).ToString
            Label39.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(5)).ToString
            Label38.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control7).Item(4)).ToString

            Labeleig.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(1)).ToString
            Labelei.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(2)).ToString
            Label31.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(5)).ToString
            Label34.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control8).Item(4)).ToString

            Labelnin.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(1)).ToString
            Labelni.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(2)).ToString
            Label27.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(5)).ToString
            Label26.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control9).Item(4)).ToString

            Labelten.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(1)).ToString
            Labelte.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(2)).ToString
            Label55.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(5)).ToString
            Label59.Text = (login.Group6DataSet1.MENU_ITEM.Rows(control10).Item(4)).ToString
        Catch ex As Exception
            MsgBox("no less items")
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        If total2 <> 0 Then
            Try
                WaiterF.TextBox1.Text = WaiterF.total1 + total2
                TextBox1.Text = total2 + WaiterF.total1
            Catch ex As Exception
                MsgBox("something went wrong, it might be totaling")
            End Try

            'now adding the order to database
            datenow = Date.Now.ToString("yyyy/MM/dd")
            Dim name As String
            If WaiterF.tableNo <> 0 And WaiterF.type <> " " Then
                Try
                    login.OrderTableAdapter1.orderCreation(WaiterF.emp_num, datenow, CInt(TextBox1.Text), WaiterF.tableNo, WaiterF.type)
                    confirm = 1
                    MsgBox("The order was added successfully!")
                    name = Label16.Text.ToString
                    login.WaiterTableAdapter1.AddPoints(name) 'adding number of orders made by a waiter

                    'adding customer loyalty points.
                    If WaiterF.customerNo <> 0 Then
                        If CInt(TextBox1.Text) >= 100 And CInt(TextBox1.Text) < 200 Then
                            login.CustomerTableAdapter1.oneP(WaiterF.customerNo)
                        ElseIf CInt(TextBox1.Text) >= 200 And CInt(TextBox1.Text) < 300 Then
                            login.CustomerTableAdapter1.twoP(WaiterF.customerNo)
                        ElseIf CInt(TextBox1.Text) >= 300 Then
                            login.CustomerTableAdapter1.threeP(WaiterF.customerNo)
                        End If
                    End If

                Catch ex As Exception
                    MsgBox("order creation failed!")
                End Try
            Else
                MsgBox("please visit home page and select table number and order type")
            End If
        Else
            MsgBox("No items were added!")

        End If
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        WaiterF.Button17.Enabled = True
        WaiterF.Show()
        Me.Hide()

    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Bill.Show()
        ListBox1.Items.Clear()
        WaiterF.ListBox1.Items.Clear()
        TextBox1.Text = " "
        WaiterF.TextBox1.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "

        WaiterF.TextBox6.Text = " "
        WaiterF.TextBox3.Text = " "
        WaiterF.TextBox4.Text = " "
        WaiterF.TextBox5.Text = " "
    End Sub

    Private Sub Labeltw_Click(sender As System.Object, e As System.EventArgs) Handles Labeltw.Click

    End Sub

    Private Sub Labelon_Click(sender As System.Object, e As System.EventArgs) Handles Labelon.Click

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub time_Click(sender As System.Object, e As System.EventArgs) Handles time.Click

    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        Me.Close()
        Home.Show()
    End Sub
End Class

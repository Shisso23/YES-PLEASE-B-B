Public Class reservation_ordered_items
    Dim order_no As Integer = 0
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub reservation_ordered_items_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER_ITEM' table. You can move, or remove it, as needed.
        'Me.ORDER_ITEMTableAdapter.Fill(Me.Group6DataSet.ORDER_ITEM)
        'TODO: This line of code loads data into the 'Group6DataSet.MENU_ITEM' table. You can move, or remove it, as needed.
        Try
            Me.MENU_ITEMTableAdapter.Fill(Me.Group6DataSet.MENU_ITEM)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        ' Try
        'login.MenU_ITEMTableAdapter1.search2(login.Group6DataSet1.MENU_ITEM, TextBox1.Text)
        '  Catch ex As Exception
        'MsgBox("no matching name found")
        ' End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            MENU_ITEMTableAdapter.search2(Group6DataSet.MENU_ITEM, TextBox1.Text)
            TextBox2.Text = Group6DataSet.MENU_ITEM.Rows(0).Item(1)
            TextBox3.Text = Group6DataSet.MENU_ITEM.Rows(0).Item(5)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim item_code As String = ""
        ' Dim order_no As Integer = 0
        Dim count As Integer = 0
        '''''here Dim order_no  = 0
        Try
            'TextBox3.Text = MENU_ITEMTableAdapter.getPrice(Group6DataSet.MENU_ITEM, TextBox2.Text)
            ' TextBox3.Text = Group6DataSet.MENU_ITEM.Rows(0).Item(0)
            'MsgBox("the price : " & TextBox3.Text)
            ' TextBox3.Text *= TextBox4.Text
        Catch ex As Exception
        End Try

        ' ListBox1.Items.Add(TextBox2.Text & "  |  " & " " & TextBox3.Text)
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            Try
                item_code = MENU_ITEMTableAdapter.getCode(Group6DataSet.MENU_ITEM, TextBox2.Text)
                item_code = Group6DataSet.MENU_ITEM.Rows(0).Item(0)
                ' count = login.Group6DataSet1.ORDER.Rows.Count
                ' order_no = reservation2.res
                count = login.OrderTableAdapter1.Fill(login.Group6DataSet1.ORDER)
                order_no = login.Group6DataSet1.ORDER.Rows(count - 1).Item(0)
                ORDER_ITEMTableAdapter.InsertQuery(item_code, order_no, TextBox4.Text)
                ordercost.Items.Add(TextBox3.Text)
         
                MsgBox("Ordered item added successfully.")
            Catch ex As Exception
                MsgBox("the item code is: " & item_code)
                MsgBox("the order number is : " & order_no)
                MsgBox("invalid input")
            End Try

        End If
    End Sub

    ' Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    '  Try
    'TextBox2.Text = ListBox1.SelectedItem.ToString
    '  Catch ex As Exception
    ' End Try

    '   End Sub
    '
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Reservation.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim cost As Double = 0
        For i As Integer = 0 To ordercost.Items.Count - 1
            cost += ordercost.Items(i)

        Next
        '  MsgBox(cost)
        TextBox5.Text = cost
        Dim total As Double
        Try
            total = TextBox5.Text + reservation2.TextBox1.Text
        Catch ex As Exception
        End Try
        Try
            login.ReservationTableAdapter1.updateCost(login.Group6DataSet1.RESERVATION, total, order_no)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
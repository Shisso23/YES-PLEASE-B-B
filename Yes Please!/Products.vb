Public Class Products


    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles item_code.TextChanged

    End Sub

    Private Sub Products_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Products_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER_ITEM' table. You can move, or remove it, as needed.
        Me.ORDER_ITEMTableAdapter.Fill(Me.Group6DataSet.ORDER_ITEM)
        'TODO: This line of code loads data into the 'Group6DataSet.MENU_ITEM' table. You can move, or remove it, as needed.
        Try
            Me.MENU_ITEMTableAdapter.Fill(Me.Group6DataSet.MENU_ITEM)
        Catch ex As Exception
            MsgBox("could not loads data into the 'Group6DataSet.MENU_ITEM' table.")
        End Try

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Try
            MENUITEMBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("no next more values")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Try
            MENUITEMBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("no values found")
        End Try


    End Sub


    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Try
            MENUITEMBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox("no values to be removed")
        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Try

            MENUITEMBindingSource.AddNew()
            ' I = Numerator \ Denominator
            ' Label1.Text = I
        Catch ex As Exception
            MsgBox("no value entered ")
        End Try

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click


        ''''
        Dim countclash As Integer = 0

        login.MenU_ITEMTableAdapter1.FillBy(login.Group6DataSet1.MENU_ITEM, item_code.Text)
        'MsgBox(login.Group6DataSet1.MENU_ITEM.Rows(0).Item(0))
        For Each row1 As DataRow In login.Group6DataSet1.MENU_ITEM.Rows
            ' MsgBox(row("date"))
            If item_code.Text = row1("item_code") Then

                countclash += 1
            End If

        Next row1
        If countclash > 0 Then
            MsgBox("The product already exist")
        Else
            If String.IsNullOrEmpty(item_code.Text) Then

                MsgBox("enter item code first")
            Else

                MENU_ITEMTableAdapter.InsertMenuItem(item_code.Text, item_name.Text, description.Text, item_price.Text)
            End If
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        MENUITEMBindingSource.RemoveFilter()
        MENUITEMBindingSource.Filter = "item_name LIKE '%" & item_name.Text & "%'"
        'If item_name.Text Then
    End Sub

    Private Sub product_TextChanged(sender As System.Object, e As System.EventArgs) Handles product.TextChanged
        ' MENUITEMBindingSource.RemoveFilter()
        MENUITEMBindingSource.Filter = "item_name LIKE '%" & item_name.Text & "%'"

    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Me.Close()
        Home.Show()

    End Sub
End Class
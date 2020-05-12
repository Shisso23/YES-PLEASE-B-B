Public Class cust_registration

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If customer_name.Text <> "" And surname.Text <> "" And customer_id.Text <> "" Then
            login.CustomerTableAdapter1.getID(login.Group6DataSet1.CUSTOMER, customer_id.Text, customer_id.Text)
            If login.Group6DataSet1.CUSTOMER.Rows.Count > 0 Then
                MsgBox("the customer " & customer_name.Text & "already Exist")

            Else

                login.CustomerTableAdapter1.InsertName_Id(customer_name.Text, customer_id.Text)
                MsgBox("customer added successfully.")
            End If
        Else
            MsgBox("enter all required information")
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        WaiterF.Show()
    End Sub

    Private Sub cust_registration_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub cust_registration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Home.Show()

    End Sub
End Class
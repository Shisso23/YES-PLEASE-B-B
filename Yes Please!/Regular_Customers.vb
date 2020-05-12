Public Class Regular_Customers

    Private Sub Regular_Customers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter1.Fill(Me.Group6DataSet1.CUSTOMER)
        regulaCustomers1.SetDataSource(Me.Group6DataSet1)

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
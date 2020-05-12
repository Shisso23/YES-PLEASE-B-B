Public Class Emp_OfTheMonth

    Private Sub Emp_OfTheMonth_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WaiterTableAdapter1.FillD(Me.Group6DataSet.WAITER)
        crystalReport21.SetDataSource(Me.Group6DataSet)

        'WaiterTableAdapter1.FillBy2(login.Group6DataSet1.WAITER)
        ' TextBox1.Text = login.Group6DataSet1.WAITER.Rows(0).Item(0)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
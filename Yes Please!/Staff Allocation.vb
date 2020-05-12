Public Class Staff_Allocation

    Private Sub Staff_Allocation_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Staff_Allocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER' table. You can move, or remove it, as needed.
        '  Me.ORDERTableAdapter.Fill(Me.myds.WAITER)
        'TODO: This line of code loads data into the 'Group6DataSet.WAITER' table. You can move, or remove it, as needed.
        ' Me.WAITERTableAdapter.Fill(Me.myds.WAITER)
        ' login.WaiterTableAdapter1.Fill(myds.WAITER)



    End Sub

    Private Sub DisplayEmployeesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DisplayEmployeesToolStripButton.Click
        Try
            Me.WAITERTableAdapter.displayEmployees(Me.myds.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            ' WAITERBindingSource.
        End Try

    End Sub

    Private Sub DisplayEmployeesToolStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles DisplayEmployeesToolStrip.ItemClicked

    End Sub
End Class
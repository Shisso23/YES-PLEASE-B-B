Public Class Allocation

    Private Sub Allocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.tblStaff_Allocation' table. You can move, or remove it, as needed.
        Try
            MsgBox(login.Custname)
            Me.TblStaff_AllocationTableAdapter.Fill(Me.Group6DataSet.tblStaff_Allocation)

   
        Catch ex As Exception
        End Try
    End Sub
End Class
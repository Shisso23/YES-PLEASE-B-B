Public Class emp_management

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        userF.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Try
            login.OrderTableAdapter1.UpdateQuery(employee_no.Text)
        Catch ex As Exception
        End Try
        Try
            login.WaiterTableAdapter1.DeleteQuery(employee_no.Text)
            MsgBox("deleted successfully .")
        Catch ex As Exception
            MsgBox("employee not found")
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        employee_no.Clear()
        employee_name.Clear()
        'emp_last.Clear()
        ' contact_no.Clear()
    End Sub

    Private Sub emp_management_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub


    Private Sub emp_management_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.USER' table. You can move, or remove it, as needed.
        Me.WAITERTableAdapter.FillBy1(Me.Group6DataSet.WAITER)

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        'DataGridView1.mov()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        ' WAITERBindingSource.Filter = "emp_no = '" & TextBox4.Text & "'"
        Try
            WAITERTableAdapter.searchemployee(Group6DataSet.WAITER, TextBox4.Text)
        Catch ex As Exception
            MsgBox("search by the waiter's name or surname")
        End Try


    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Try
            WAITERTableAdapter.searchemployee(Group6DataSet.WAITER, TextBox4.Text)
        Catch ex As Exception
            ' MsgBox("search by the waiter's name or surname")
        End Try
        If TextBox4.Text = "" Then
            Me.WAITERTableAdapter.FillBy1(Me.Group6DataSet.WAITER)
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
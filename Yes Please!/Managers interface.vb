Public Class managerF

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Products.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        userF.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub



    Private Sub managerF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim v As String = ""

        login.WaiterTableAdapter1.FillBy(login.Group6DataSet1.WAITER)

        v = "The employee of the month is  " & (login.Group6DataSet1.WAITER.Rows(0).Item(1)).ToString

        Dim g As String = login.Group6DataSet1.WAITER.Rows(0).Item(2).ToString
        TextBox1.Text = v & " " & g
        ' v = (login.Group6DataSet1.WAITER.Rows(0).Item(1)).ToString
        ' MsgBox(TextBox1.Text & v)






    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()

    End Sub
End Class
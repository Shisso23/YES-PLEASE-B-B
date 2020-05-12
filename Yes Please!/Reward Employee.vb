Public Class Reward_Employee

    Private Sub Reward_Employee_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Reward_Employee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Group6DataSet.ORDER)
        Me.WAITERTableAdapter.displayEmployees(login.Group6DataSet1.WAITER)

        ' login.WaiterTableAdapter1.selectAndOrder(login.Group6DataSet1.WAITER)
        'login.Group6DataSet1.WAITER.Rows(0).Item(0)
        'login.WaiterTableAdapter1.reset_no_of_orders(empl_no)
        login.WaiterTableAdapter1.selectAndOrder(login.Group6DataSet1.WAITER)
        Dim emp As Integer = login.Group6DataSet1.WAITER.Rows(0).Item(0)

        Try
            Me.WAITERTableAdapter.displayEmployees(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim Msg, Style, Title, Help, Ctxt, Resp, MyString
        Msg = "Do you want to continue?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Confirmation"
        Help = "DEMO.HLP"
        Ctxt = 1000
        Resp = MsgBox(Msg, Style, Title)
        If Resp = vbYes Then    ' User chose Yes.
            MyString = "Yes"    ' Perform some action.
            Try

                login.WaiterTableAdapter1.setTozero0(login.Group6DataSet1.WAITER)
                MsgBox("number of orders have been set to 0")
                '  login.WaiterTableAdapter1.reset_no_of_orders(emp)
            Catch ex As Exception

                MsgBox("no best employee found")
            End Try

        Else
            Title = "ok"
        End If

        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub DisplayEmployeesToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.WAITERTableAdapter.displayEmployees(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Private Sub DisplayEmployeesToolStripButton_Click_2(sender As System.Object, e As System.EventArgs) Handles DisplayEmployeesToolStripButton.Click


    ' End Sub

    Private Sub DisplayEmployeesToolStripButton_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DisplayEmployeesToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.WAITERTableAdapter.displayEmployees(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DisplayEmployeesToolStripButton2_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.WAITERTableAdapter.displayEmployees(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DisplayEmployeesToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs)
        Try
            Me.WAITERTableAdapter.displayEmployees(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
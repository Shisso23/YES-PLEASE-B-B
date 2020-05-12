Public Class Home
    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .StartPosition = FormStartPosition.WindowsDefaultBounds
            '.Location = New Point(10, 50)
            .Show()

        End With
    End Sub



    Private Sub REGISTERToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SIGNINToolStripMenuItem1.Click
        FormSetUp(login)
        login.Show()



    End Sub

    Private Sub PASSWORDRESETToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        userF.Show()

    End Sub



    Private Sub passwordToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        reset_password.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        If (login.userType = "waiter" Or login.userType = "manager") Then
            ' Me.Hide()
            WaiterF.Show()

        Else
            MsgBox("You Need to login as  a waiter or a manager to make new Orders")

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If (login.userType = "manager" Or login.userType = "receptionist") Then
            ' Me.Hide()
            Reservation.Show()
        Else
            MsgBox("You need to login as a receptionist or a manager in order to manage reservations" & login.userType)

        End If

    End Sub

    Private Sub Home_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox3.Enabled = False
        PictureBox2.Enabled = False

        Timer1.Enabled = True

        WaiterF.Close()
        Reservation.Close()
        login.Close()

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay




    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)

    End Sub





    Private Sub SALESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Reports.Show()
    End Sub

    Private Sub REWARDCUSTOMERToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles REWARDCUSTOMERToolStripMenuItem.Click
        Me.Hide()
        Reward_Employee.Show()
    End Sub

    Private Sub PRODUCTMANAGEMENTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PRODUCTMANAGEMENTToolStripMenuItem.Click
        ' Me.Hide()
        Products.Show()
    End Sub

    Private Sub EMPLOYEEMANAGEMENTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EMPLOYEEMANAGEMENTToolStripMenuItem.Click
        ' Me.Hide()
        emp_management.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.SIGNINToolStripMenuItem1.Enabled = True
        Me.LOGOUTToolStripMenuItem.Enabled = False
        Me.passwordToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem.Enabled = False  'Registering the User disabled when the manager logout
        Me.MANAGERToolStripMenuItem.Enabled = False
        PictureBox3.Enabled = False
        PictureBox2.Enabled = False
        PictureBox1.Enabled = False
        PictureBox6.Enabled = False


    End Sub

    Private Sub RESERVATIONToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Rev_Reports.Show()
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem.Click
        Me.Hide()
        userF.Show()
    End Sub

    Private Sub passwordToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles passwordToolStripMenuItem1.Click
        Me.Hide()
        reset_password.Show()

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegisterToolStripMenuItem.Click

    End Sub
    Dim num As Integer = 1
    Private Sub Timer2_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Select Case num
            Case 1
                PictureBox5.Image = My.Resources.CghzgVVQ_4aARFF7AAAv5o7Ju88606_R_550_412
                num = 2
            Case 2
                PictureBox5.Image = My.Resources.g276882_jpg_1366x768_q85_crop_upscale
                num = 3
            Case 3
                PictureBox5.Image = My.Resources._12187_2_jpg_1366x768_q85_crop_upscale
                num = 4
            Case 4
                PictureBox5.Image = My.Resources._12187_7_jpg_1366x768_q85_crop_upscale
                num = 5
            Case 5
                PictureBox5.Image = My.Resources._488023_130710165633446
                num = 6
            Case 6
                PictureBox5.Image = My.Resources._488023_130710165634774
                num = 7
            Case 7
                PictureBox5.Image = My.Resources.yespleasetravelandtours_19_x_large
                num = 8
            Case 8
                PictureBox5.Image = My.Resources.yespleasetravelandtours_16_x_large
                num = 9
            Case 9
                PictureBox5.Image = My.Resources.yesplease_bed__breakfast_gallery_130223_20160229144930
                num = 10
            Case 10
                PictureBox5.Image = My.Resources.p
                num = 11
            Case 11
                PictureBox5.Image = My.Resources._2061d71e_b
                num = 12
            Case 12
                PictureBox5.Image = My.Resources._183573471
                num = 13
            Case 13
                PictureBox5.Image = My.Resources.g277130_jpg_1366x768_q85_crop_upscale
                num = 14
            Case 14
                PictureBox5.Image = My.Resources.HI294282663
                num = 1
        End Select
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        
        If (login.userType = "manager") Then
            FormSetUp(Report_Drop)
            Report_Drop.Show()

        Else
            MsgBox("You need to login as a receptionist or a manager in order to manage reservations" & login.userType)

        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        If (login.userType = "waiter" Or login.userType = "manager") Then
            FormSetUp(Report_Drop)
            Allocation.Show()

        Else
            MsgBox("You need to login as a manager in order to manage reservations" & login.userType)

        End If
    End Sub

    Private Sub StaffAllocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffAllocationToolStripMenuItem.Click
        Staff_Allocation.Show()

    End Sub

    Private Sub REPORTSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles REPORTSToolStripMenuItem.Click
        Report_Drop.Show()
    End Sub
End Class
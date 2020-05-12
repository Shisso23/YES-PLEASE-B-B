Public Class login
    Public Custname As String = " "
    Public userType As String



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Me.UserTableAdapter1.FillBy(Me.Group6DataSet1.USER, username.Text, password.Text)
            Custname = username.Text
        Catch ex As Exception
        End Try

        Try
            userType = Me.Group6DataSet1.USER.Rows(0).Item(1).ToString

        Catch ex As Exception
        End Try
        If Me.Group6DataSet1.USER.Rows.Count > 0 Then
            ' to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints.
            MsgBox("Welcome " & Me.Group6DataSet1.USER.Rows(0).Item(0).ToString & vbLf & " You will now be directed to the system   ")
            Try
                If userType = "waiter" Then
                    Custname = Me.Group6DataSet1.USER.Rows(0).Item(0).ToString
                    Me.Hide()
                    With Home

                        .SIGNINToolStripMenuItem1.Enabled = False
                        .LOGOUTToolStripMenuItem.Enabled = True
                        .PictureBox3.Enabled = True
                        .PictureBox2.Enabled = True
                        .Show()

                    End With
                    username.Clear()
                    password.Clear()
                    WaiterF.Show()

                ElseIf userType = "receptionist" Then
                    Me.Hide()
                    With Home

                        .SIGNINToolStripMenuItem1.Enabled = False
                        .LOGOUTToolStripMenuItem.Enabled = True
                        .PictureBox2.Enabled = True
                        .PictureBox3.Enabled = True
                        .Show()

                    End With
                    username.Clear()
                    password.Clear()
                    Reservation.Show()

                ElseIf userType = "manager" Then
                    Me.Hide()
                    With Home
                        .SIGNINToolStripMenuItem1.Enabled = False
                        .LOGOUTToolStripMenuItem.Enabled = True
                        .MANAGERToolStripMenuItem.Enabled = True
                        .ToolStripMenuItem.Enabled = True
                        .passwordToolStripMenuItem1.Enabled = True
                        .PictureBox2.Enabled = True
                        .PictureBox3.Enabled = True

                    End With
                    username.Clear()
                    password.Clear()

                End If

            Catch ex As Exception
            End Try

        Else
            ' MsgBox(ComboBox1.SelectedItem)
            MsgBox("Invalid User Details")
        End If


        '       ; If Me.Group6DataSet1.USER.Rows(0).Item(2) = "waiter" Then

        'Me.Close()
        ' Log_In_Form.hide
        'ElseIf Me.Group6DataSet1.USER.Rows(0).Item(2) = "manager" Then
        'Me.Hide()
        'managerF.Show()

        '        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        username.Clear()
        password.Clear()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WaiterF.Close()
        Reservation.Close()
        Waiters_Interface2.Close()

    End Sub
End Class

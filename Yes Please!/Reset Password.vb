Public Class reset_password
    Dim count As Integer = 0
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles username1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' login.UserTableAdapter1.FillBy1(login.Group6DataSet1.USER, TextBox1.Text)
        'Try
        ' Dim rowsAffected As Integer = login.UserTableAdapter1.Fill(login.Group6DataSet1.USER)
        ''''''''''''''
        '  Me.UserTableAdapter1.FillBy(Me.Group6DataSet1.USER, username.Text, password.Text, ComboBox1.SelectedItem)
        '   If Me.Group6DataSet1.USER.Rows.Count > 0 Then
        '    MsgBox("Welcome " & Me.Group6DataSet1.USER.Rows(0).Item(1).ToString & vbLf & "You will now be directed to the system" & Group6DataSet1.USER.Rows(0).Item(2))
        '''''''''''''
        'login.UserTableAdapter1.FillBy1(login.Group6DataSet1.USER, username1.Text, password.Text)



        ''MsgBox(login.Group6DataSet1.USER.Rows.Count)
        If username1.Text = "" Or new_pass1.Text = "" Or new_pass2.Text = "" Then
            MsgBox("Enter all the required information")
        End If

        Try
            login.UserTableAdapter1.FillBy1(login.Group6DataSet1.USER, username1.Text)
            MsgBox(login.Group6DataSet1.USER.Rows(0).Item(0))
            If login.Group6DataSet1.USER.Rows.Count > 0 Then

                If new_pass1.Text = new_pass2.Text Then
                    login.UserTableAdapter1.UpdateQuery(new_pass1.Text, username1.Text)
                    '  If rowsAffected > 0 Then
                    MsgBox("password successfully changed")
                Else
                    MsgBox("The passwords must match!")
                End If

                'MsgBox(login.Group6DataSet1.USER.Rows.Count)
                ' login.UserTableAdapter1.UpdateQuery(new_pass1.Text, username.Text)

                'End If

                '  Catch ex As Exception
            Else

                MsgBox("incorrect user name! please enter the correct user name")
                ' End Try
            End If
        Catch ex As Exception


            MsgBox("make show you enter all texts and the correct username")


        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        new_pass1.Clear()
        new_pass2.Clear()
        username1.Clear()
    End Sub

    Private Sub reset_password_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub reset_password_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub new_pass2_TextChanged(sender As System.Object, e As System.EventArgs) Handles new_pass2.TextChanged
        Try
            If new_pass1.Text <> new_pass2.Text Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
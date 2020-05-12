Public Class userF

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If passwordw.Text <> "" And us_name.Text <> "" And user_name.Text <> "" And surename.Text <> "" Then
            ''''''''''''''''here
            Dim coun As Integer = 0
            login.UserTableAdapter1.FillBy1(login.Group6DataSet1.USER, user_name.Text)

            ''  ' MsgBox(coun)

            Try
                If login.Group6DataSet1.USER.Rows(0).Item(0).ToString = user_name.Text Then
                    MsgBox("the user " & user_name.Text & "  already exist")
                End If
            Catch ex As Exception
                ' MsgBox("no user found")
                login.UserTableAdapter1.InsertQuery(user_name.Text, passwordw.Text, userType.SelectedItem)
                If userType.SelectedItem = "waiter" Then
                    login.WaiterTableAdapter1.InsertQuery1(us_name.Text, surename.Text, phone_no.Text)
                    MsgBox("user added successfully")
                End If
            End Try


        Else
            MsgBox("enter all the required information")
        End If
        Try
            login.UserTableAdapter1.FillBy1(login.Group6DataSet1.USER, user_name.Text)

        Catch ex As Exception
        End Try
        ' MsgBox(login.Group6DataSet1.USER.Rows(0).Item(0))
        Try
            If (login.Group6DataSet1.USER.Rows(0).Item(0) = user_name.Text) Then
                MsgBox("user added successfully.")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        user_name.Clear()
        passwordw.Clear()
        phone_no.Clear()
        us_name.Clear()
        surename.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub us_name_TextChanged(sender As System.Object, e As System.EventArgs) Handles us_name.TextChanged
        user_name.Text = us_name.Text
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub userF_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Help.Show()
    End Sub

    Private Sub userF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
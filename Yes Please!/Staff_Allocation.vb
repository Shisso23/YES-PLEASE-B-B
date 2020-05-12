Public Class Staff_Allocation

    Private Sub Staff_Allocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.WAITER' table. You can move, or remove it, as needed.
        Me.WAITERTableAdapter.Fill(Me.Group6DataSet.WAITER)
        login.WaiterTableAdapter1.Fill(Me.Group6DataSet.WAITER)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim shift As String = ""
            Dim daten As Date = Date.Now
            daten = DateTimePicker1.Text
            Dim nerdate As Date = daten.Date



            Dim da As Date = DateTimePicker1.Value


            If (RadioButton1.Checked) Then
                shift = "Normal Shift"
            ElseIf (RadioButton2.Checked) Then

                shift = "Reservation Shift"
            End If

            Me.TblStaff_AllocationTableAdapter1.InsertQuery(ComboBox1.SelectedValue, shift, nerdate, ComboBox2.SelectedValue, ComboBox3.SelectedValue)
            MessageBox.Show("successfully inserted")

        Catch ex As Exception
            MessageBox.Show("Insertion Failed")
        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.WAITERTableAdapter.Fill(Me.Group6DataSet.WAITER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' TextBox1.Text = DataGridView1.SelectedCells.ToString
    End Sub
End Class
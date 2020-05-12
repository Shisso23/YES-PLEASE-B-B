Public Class Reports
    



    Private Sub Reports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Group6DataSet.ORDER)
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Group6DataSet.ORDER)
        'TODO: This line of code loads data into the 'Group6DataSet.RESERVATION' table. You can move, or remove it, as needed.
        login.ReservationTableAdapter1.display_Reservation(Me.Group6DataSet.RESERVATION)
        'TODO: This line of code loads data into the 'Group6DataSet.ORDER' table. You can move, or remove it, as needed.

        Me.ORDERTableAdapter.Fill(Me.Group6DataSet.ORDER)
        crystalReport11.SetDataSource(Me.Group6DataSet)
        Me.OrdeR_ITEMTableAdapter1.Fill(Me.Group6DataSet.ORDER_ITEM)
        crystalReport41.SetDataSource(Me.Group6DataSet)









    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            'Dim i As Integer
            'Dim total As Double
            'Dim sum As Double
            'Dim R As Double
            ' For i = 0 To DataGridView2.RowCount - 1
            'If DataGridView2.Rows(i).Cells(5).Value = "normal" Then
            'total += DataGridView2.Rows(i).Cells(3).Value
            ' ElseIf DataGridView2.Rows(i).Cells(5).Value = "reservation" Then
            ' sum += DataGridView2.Rows(i).Cells(3).Value

            ' End If
            ' R = sum + total
            ' Next
            'TextBox2.Text = total.ToString("c")
            'TextBox3.Text = sum.ToString("c")
            'TextBox4.Text = R.ToString("c")
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Information)

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)
   
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
         Me.Close()
        Home.Show()
    End Sub

  

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' DataGridView2.Focus()
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty


    End Sub

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CrystalReportViewer1_Load_1(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
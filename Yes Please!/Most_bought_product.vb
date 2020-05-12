Public Class Most_bought_product

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Most_bought_product_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MostBoughtItemTableAdapter1.InsertQuery()
        Me.MostBoughtItemTableAdapter1.Fill(Me.Group6DataSet.MostBoughtItem)
        crystalReport51.SetDataSource(Me.Group6DataSet)

        MostBoughtItemTableAdapter1.DeleteQuery()

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
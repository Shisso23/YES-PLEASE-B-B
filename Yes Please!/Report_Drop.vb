Public Class Report_Drop

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Report_Combo.SelectedIndexChanged
        If Report_Combo.SelectedItem = "Most Bought Item" Then
            Most_bought_product.Show()
        ElseIf Report_Combo.SelectedItem = "Employee Of The Month" Then
            Emp_OfTheMonth.Show()
        ElseIf Report_Combo.SelectedItem = "Sales" Then
            Reports.Show()
        ElseIf Report_Combo.SelectedItem = "Regular Customers" Then
            Regular_Customers.Show()
        ElseIf Report_Combo.SelectedItem = "Reservation Report" Then
            Reservation_Report.Show()
        End If


    End Sub

    Private Sub Report_Drop_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

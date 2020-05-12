Public Class Bill

    Private Sub Bill_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim waiter As String = login.Custname
        Dim datenow As DateTime = Date.Now.ToString("yyyy/MM/dd hh:MM:ss")
        Dim table As Integer = WaiterF.tableNo
        Dim fmt As String = "{0,20}{1,20}"

        Dim full1(2) As String
        Dim full2(2) As String
        Dim price As String = 0
        Dim name As String = ""
        Dim quantity As String = ""
        Dim count As Integer = 0


        If WaiterF.submt = 1 Then
            ListBox1.Items.Add("Waiter's name:  " & waiter)
            ListBox1.Items.Add("Date         :  " & datenow)
            ListBox1.Items.Add("Table No     :  " & table)
            ListBox1.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------")


            For i As Integer = 0 To WaiterF.ListBox1.Items.Count - 1
                full1 = Split(CStr(WaiterF.ListBox1.Items(i)), "|")


                For j As Integer = 0 To full1.Length - 1
                    If j Mod 2 = 0 Then
                        name = full1(j)

                    Else
                        full2 = Split(CStr(full1(j)), "x")
                    End If


                Next

                For t As Integer = 0 To full2.Length - 1
                    If t Mod 2 = 0 Then
                        quantity = full2(t)
                    ElseIf t Mod 2 = 1 Then
                        price = full2(t)
                    End If

                Next
                ListBox1.Items.Add(String.Format(fmt, "                   ", quantity & "   " & name & "                        " & price))
            Next
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Balance due          " & WaiterF.TextBox1.Text.ToString)
            ListBox1.Items.Add("Customer No  :  " & WaiterF.customerNo)


        ElseIf Waiters_Interface2.submt2 = 1 Then
            ListBox1.Items.Add("Waiter's name:  " & waiter)
            ListBox1.Items.Add("Date         :  " & datenow)
            ListBox1.Items.Add("Table No     :  " & table)
            ListBox1.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")


            For i As Integer = 0 To Waiters_Interface2.ListBox1.Items.Count - 1
                full1 = Split(CStr(Waiters_Interface2.ListBox1.Items(i)), "|")


                For j As Integer = 0 To full1.Length - 1
                    If j Mod 2 = 0 Then
                        name = full1(j)

                    Else
                        full2 = Split(CStr(full1(j)), "x")
                    End If


                Next

                For t As Integer = 0 To full2.Length - 1
                    If t Mod 2 = 0 Then
                        quantity = full2(t)
                    ElseIf t Mod 2 = 1 Then
                        price = full2(t)
                    End If

                Next
                ListBox1.Items.Add("                   " & quantity & "   " & name & "                        " & price)
            Next
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Balance due          " & Waiters_Interface2.TextBox1.Text.ToString)
            ListBox1.Items.Add("Customer No  :  " & WaiterF.customerNo)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
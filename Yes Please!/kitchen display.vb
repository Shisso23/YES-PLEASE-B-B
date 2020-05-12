Public Class kitchen_display

    Private Sub kitchen_display_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If WaiterF.submt = 1 Then
            For i As Integer = 0 To WaiterF.ListBox1.Items.Count - 1
                ListBox1.Items.Add(WaiterF.ListBox1.Items(i))
            Next
        ElseIf Waiters_Interface2.submt2 = 1 Then
            For i As Integer = 0 To Waiters_Interface2.ListBox1.Items.Count - 1
                ListBox1.Items.Add(Waiters_Interface2.ListBox1.Items(i))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
Public Class loginform
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If (username.Equals("admin") And password.Equals("password")) Then
            MessageBox.Show("login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            form2.Show()
            Me.Hide()



        Else
            MessageBox.Show("error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
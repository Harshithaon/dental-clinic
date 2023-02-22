Imports System.Data.SqlClient

Public Class treatment
    Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=treatments;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand
    Private Sub populate()


        Con.Close()
        Dim query = "select * from treatment"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        Con.Close()

    End Sub
    Private Sub reset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""



    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("miissing information")
        Else
            Try

                Dim query = "insert into treatment  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
                Dim cmd As New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("treatment saved successfully")
                Con.Close()
                populate()
                reset()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim key As Integer = Nothing

        If key = 0 Then
            MessageBox.Show("miissing information")
        Else
            Con.Open()

            Dim query = "delete from patienttbl  where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("patient deleted successfully")
            Con.Close()
            populate()
            reset()
        End If
    End Sub
End Class
Imports System.Data.SqlClient

Public Class Feedback

    Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=feedback;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand
    Private Sub populate()


        Con.Close()
        Dim query = "select * from feedbacklist"
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

        TextBox3.Text = ""
        key = 0


    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()


    End Sub
End Class
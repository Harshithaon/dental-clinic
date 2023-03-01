Imports System.Data.SqlClient

Public Class dashboard
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub countpat()
        Con.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("select count(*) from patienttbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)

        Dim dt As DataTable
        dt = New DataTable
        adapter.Fill(dt)

        Label2.Text = dt.Rows(0)(0).ToString




        Con.Close()
    End Sub

    Private Sub counttreat()
        con.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("select count(*) from treatmenttbl ", con)
        Dim adapter As New SqlDataAdapter(cmd)

        Dim dt As DataTable
        dt = New DataTable
        adapter.Fill(dt)

        Label3.Text = dt.Rows(0)(0).ToString




        con.Close()
    End Sub
    Private Sub countpres()
        con.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("select count(*) from Prescription", con)
        Dim adapter As New SqlDataAdapter(cmd)

        Dim dt As DataTable
        dt = New DataTable
        adapter.Fill(dt)

        Label6.Text = dt.Rows(0)(0).ToString




        con.Close()
    End Sub
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countpat()
        counttreat()
        countpres()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub



End Class
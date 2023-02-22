Imports System.Data.SqlClient

Public Class prescription
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Function Load()
        'Create a Connection object.
        myConn = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Treatement, Patient FROM Prescription"

        'Open the connection.
        myConn.Open()

        'Dim cmd As New SqlCommand("SELECT Treatement, Patient FROM Prescription")
        Dim da As New SqlDataAdapter
        da.SelectCommand = myCmd

        'myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        'Do While myReader.Read()
        'results = results & myReader.GetString(0) & vbTab &
        'myReader.GetString(1) & vbLf
        'Loop
        'Display results.
        'MsgBox(results)



        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt


        'Close the reader and the database connection.
        'myReader.Close()
        myConn.Close()
    End Function
    Private Sub prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
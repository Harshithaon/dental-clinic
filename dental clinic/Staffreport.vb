Imports System.IO
Imports System.Data.SqlClient
Public Class Staffreport

    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand
    Private Sub populate()


        con.Close()
        Dim query = "select * from stafflist"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)


        con.Close()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim writer As New StreamWriter("D:\table\Staff.xls")
        For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1 Step +1
                If j = DataGridView1.Columns.Count - 1 Then
                    writer.Write(vbTab & DataGridView1.Rows(i).Cells(j).Value.ToString())
                Else
                    writer.Write(vbTab & DataGridView1.Rows(i).Cells(j).Value.ToString & vbTab)

                End If
            Next j
            writer.WriteLine()

        Next i
        writer.Close()
        MessageBox.Show("Table Saved")
    End Sub

    Private Sub Staffreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub
End Class
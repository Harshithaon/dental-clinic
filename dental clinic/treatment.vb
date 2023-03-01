Imports System.Data.SqlClient
Imports System.IO

Public Class treatment
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand
    Private Sub populate()


        Con.Close()
        Dim query = "select * from treatmenttbl"
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
            MessageBox.Show("missing information")
        Else

            Con.Open()
            Dim query = "insert into treatmenttbl  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("treatment saved successfully")
            Con.Close()
            populate()
            reset()



        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If key = 0 Then
            MessageBox.Show("missing information")
        Else
            Con.Open()

            Dim query = "delete from treatmenttbl  where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("treatment deleted successfully")
            Con.Close()
            populate()
            reset()
        End If
    End Sub
    Dim key = 0

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString

        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("missing information")
        Else
            Con.Open()

            Dim query = "update treatmenttbl  set Name='" & TextBox1.Text & "', Cost='" & TextBox2.Text & "', Description='" & TextBox3.Text & "' where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("treatment updated successfully")
            Con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim writer As New StreamWriter("D:\table\Treatment.xls")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString

        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class


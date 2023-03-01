Imports System.Data.SqlClient
Imports System.IO

Public Class Feedback

    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand
    Private Sub fillpatients()
        con.Open()
        Dim sql = " select * from patienttbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        ComboBox1.DataSource = tbl
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "Name"
        con.Close()

    End Sub
    Private Sub populate()


        con.Close()
        Dim query = "select * from feedbacklist"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()

    End Sub



    Private Sub reset()
        ComboBox1.Text = ""

        TextBox3.Text = ""

        DateTimePicker1.Text = ""

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        fillpatients()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "insert into feedbacklist  values('" + ComboBox1.Text + "','" + DateTimePicker1.Value.Date + "','" + TextBox3.Text + "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("feedback saved successfully")
            con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "update feedbacklist  set Name ='" & ComboBox1.Text & "', Date='" & DateTimePicker1.Value.Date & "', Feedback='" & TextBox3.Text & "'where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("feedback updated successfully")
            con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "delete from feedbacklist where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("feedback deleted successfully")
            con.Close()
            populate()
            reset()
        End If

    End Sub
    Dim key = 0

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(1).Value.ToString
        DateTimePicker1.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString

        If ComboBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim writer As New StreamWriter("D:\table\FeedBack.xls")
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
        ComboBox1.Text = row.Cells(1).Value.ToString
        DateTimePicker1.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString

        If ComboBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class
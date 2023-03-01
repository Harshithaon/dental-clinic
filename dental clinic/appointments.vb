Imports System.IO
Imports System.Data.SqlClient
Public Class appointments

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
        ComboBox1.DisplayMember = "name"
        ComboBox1.ValueMember = "name"
        con.Close()

    End Sub
    Private Sub filltreatments()
        con.Open()
        Dim sql = " select * from treatmenttbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        ComboBox2.DataSource = tbl
        ComboBox2.DisplayMember = "name"
        ComboBox2.ValueMember = "name"
        con.Close()

    End Sub
    Private Sub populate()


        Con.Close()
        Dim query = "select * from appointment"
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
        ComboBox1.Text = ""

        ComboBox2.Text = ""

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillpatients()
        filltreatments()

        populate()
    End Sub
    Dim key = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()
            Dim query = "insert into appointment values('" + ComboBox1.Text + "','" + DateTimePicker1.Value.Date + "','" + DateTimePicker2.Value.Date + "','" + ComboBox2.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("appointment saved successfully")
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

            Dim query = "delete from appointment  where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("appointment deleted successfully")
            Con.Close()
            populate()
            reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("missing information")
        Else
            Con.Open()

            Dim query = "update appointment  set Patient='" & ComboBox1.Text & "',Date='" & DateTimePicker1.Value.Date & "',Time='" & DateTimePicker2.Value.Date & "',Treatment='" & ComboBox2.Text & "' where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("appointment updated successfully")
            Con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(1).Value.ToString
        DateTimePicker1.Text = row.Cells(2).Value.ToString
        DateTimePicker2.Text = row.Cells(3).Value.ToString
        ComboBox2.Text = row.Cells(4).Value.ToString
        If ComboBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        ComboBox1.Text = row.Cells(1).Value.ToString
        DateTimePicker1.Text = row.Cells(2).Value.ToString
        DateTimePicker2.Text = row.Cells(3).Value.ToString
        ComboBox2.Text = row.Cells(4).Value.ToString
        If ComboBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO

Public Class prescription
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dental-clinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Dim cmd As SqlCommand
    Private Sub fillpatients()
        con.Open()
        Dim sql = " select * from patienttbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        ComboBox2.DataSource = tbl
        ComboBox2.DisplayMember = "Name"
        ComboBox2.ValueMember = "Name"
        con.Close()

    End Sub


    Private Sub populate()


        con.Open()
        Dim query = "select * from Prescription"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Private Sub fetchdata()
        con.Close()
        con.Open()
        Dim query = "select * from appointment where Treatment = '" + ComboBox2.SelectedValue.ToString() + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            TextBox1.Text = reader(2).ToString
        End While
        con.Close()


    End Sub
    Private Sub fetchcost()
        con.Open()
        Dim query = "select * from treatmenttbl where Name = '" + TextBox1.Text + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            TextBox2.Text = reader(2).ToString
        End While
        con.Close()


    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        fetchdata()

    End Sub

    Private Sub reset()
        TextBox1.Text = ""

        ComboBox2.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""




    End Sub
    Dim key = 0

    Private Sub prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillpatients()
        populate()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or ComboBox2.Text = "" Or TextBox4.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "insert into Prescription values('" + TextBox1.Text + "','" + ComboBox2.Text + "','" + TextBox4.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show(" prescription saved successfully")
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

            Dim query = "delete from Prescription where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("prescription deleted successfully")
            con.Close()
            populate()
            reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox2.Text = "" Or TextBox4.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "update Prescription  set Treatment='" & TextBox1.Text & "', Patient='" & ComboBox2.Text & "', Medicine='" & TextBox4.Text & "',Cost='" & TextBox2.Text & "',Quantity='" & TextBox3.Text & "' where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("prescription updated successfully")
            con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        ComboBox2.SelectedItem = row.Cells(2).Value.ToString
        TextBox4.Text = row.Cells(3).Value.ToString
        TextBox2.Text = row.Cells(4).Value.ToString
        TextBox3.Text = row.Cells(5).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim writer As New StreamWriter("D:\table\Prescription.xls")
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
        ComboBox2.SelectedItem = row.Cells(2).Value.ToString
        TextBox4.Text = row.Cells(3).Value.ToString
        TextBox2.Text = row.Cells(4).Value.ToString
        TextBox3.Text = row.Cells(5).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        fetchcost()
    End Sub
End Class
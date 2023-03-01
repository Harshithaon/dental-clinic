Imports System.Data.SqlClient

Public Class staff
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
    Private Sub reset()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox7.Text = ""
        TextBox5.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
        TextBox6.Text = ""
        TextBox10.Text = ""

    End Sub
    Private Sub employeeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox7.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Or ComboBox2.Text = "" Or TextBox6.Text = "" Or TextBox10.Text = "" Then
            MessageBox.Show("missing information")
        Else

            con.Open()
            Dim query = "insert into stafflist  values('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Value.Date + "','" + TextBox3.Text + "','" + ComboBox2.Text + "','" + TextBox6.Text + "','" + TextBox10.Text + "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("employee saved successfully")
            con.Close()
            populate()
            reset()

        End If
    End Sub
    Dim key = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "delete from stafflist where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("employee deleted successfully")
            con.Close()
            populate()
            reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox7.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Or ComboBox2.Text = "" Or TextBox6.Text = "" Or TextBox10.Text = "" Then
            MessageBox.Show("missing information")
        Else
            con.Open()

            Dim query = "update stafflist  set Empname='" & TextBox1.Text & "', Empdes='" & ComboBox1.SelectedItem & "', Empmail='" & TextBox2.Text & "',Empsalary='" & TextBox7.Text & "',Phno='" & TextBox5.Text & "',DOB='" & DateTimePicker1.Value.Date & "',City='" & TextBox3.Text & "',State='" & ComboBox2.SelectedItem & "',Pincode='" & TextBox6.Text & "',Country='" & TextBox10.Text & "' where id=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("employee updated successfully")
            con.Close()
            populate()
            reset()
        End If

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        ComboBox1.SelectedItem = row.Cells(2).Value.ToString
        TextBox2.Text = row.Cells(3).Value.ToString
        TextBox7.Text = row.Cells(4).Value.ToString
        TextBox5.Text = row.Cells(5).Value.ToString
        DateTimePicker1.Text = row.Cells(6).Value.ToString
        TextBox3.Text = row.Cells(7).Value.ToString
        ComboBox2.Text = row.Cells(8).Value.ToString
        TextBox6.Text = row.Cells(9).Value.ToString
        TextBox10.Text = row.Cells(10).Value.ToString

        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub
End Class
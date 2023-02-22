Imports System.Data.SqlClient

Public Class patientform
    Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=plist;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Dim cmd As SqlCommand

    Private Sub populate()


        Con.Close()
        Dim query = "select * from patienttbl"
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
        TextBox4.Text = ""


    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub patientform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox4.Text = "" Then
            MessageBox.Show("miissing information")
        Else
            Con.Open()

            Dim query = "insert into patienttbl  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Value.Date + "','" + ComboBox1.SelectedItem.ToString() + "','" + TextBox4.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("patient saved successfully")
            Con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    Dim key = 0

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString
        DateTimePicker1.Text = row.Cells(4).Value.ToString
        ComboBox1.SelectedItem = row.Cells(5).Value.ToString
        TextBox4.Text = row.Cells(6).Value.ToString
        If TextBox1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox4.Text = "" Then
            MessageBox.Show("missing information")
        Else
            Con.Open()

            Dim query = "update patienttbl  set name='" & TextBox1.Text & "', ph='" & TextBox2.Text & "', Add='" & TextBox3.Text & "',dob='" & DateTimePicker1.Value.Date & "',gen='" & ComboBox1.SelectedItem.ToString & "',allergies='" & TextBox4.Text & "' where id=" & key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("patient updated successfully")
            Con.Close()
            populate()
            reset()


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
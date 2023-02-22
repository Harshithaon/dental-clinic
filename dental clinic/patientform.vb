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
            MessageBox.show("miissing information")
        Else
            Con.Open()

            Dim query = "insert into patienttbl  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Value.Date + "','" + ComboBox1.SelectedItem.ToString() + "','" + TextBox4.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("patient saved successfully")
            Con.Close()
            populate()


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
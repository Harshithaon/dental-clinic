Imports System.Data.SqlClient

Public Class treatment
    Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=treatments;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
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

    Private Sub dataGridView1_DataBindingComplete(ByVal sender As Object,
ByVal e As DataGridViewBindingCompleteEventArgs) _
Handles DataGridView1.DataBindingComplete

        ' Hide some of the columns.
        With DataGridView1
            .Columns("name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("cost").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("treatment").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AutoResizeColumns()

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

            Try
                Con.Open()
                Dim query = "insert into treatmenttbl  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
                Dim cmd As New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("treatment saved successfully")
                Con.Close()
                populate()
                reset()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
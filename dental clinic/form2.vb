﻿Public Class form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As New treatment
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()



    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label8.Text = DateTime.Now



    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form1.Label2.Text
        ''BYE and HAPPY TEETH



    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles label8.Click


    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub SystemicToolStripMenuItem_Click(sender As Object, e As EventArgs)




















    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        ContextMenuStrip1.Show(Button1, 0, Button1.Height)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As New appointments
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n As New prescription
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ContextMenuStrip2.Show(Button7, 0, Button7.Height)


    End Sub

    Private Sub PATIENTFEEDBACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PATIENTFEEDBACKToolStripMenuItem.Click
        Dim n As New patientform
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PATENTFEEDBACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PATENTFEEDBACKToolStripMenuItem.Click
        Dim n As New Feedback
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()

    End Sub

    Private Sub STAFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STAFFToolStripMenuItem.Click

    End Sub

    Private Sub STAFFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles STAFFToolStripMenuItem1.Click
        Dim n As New staff
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()
    End Sub
End Class
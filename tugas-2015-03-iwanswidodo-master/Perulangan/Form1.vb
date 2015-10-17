Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        STARS.MdiParent = Me
        STARS.Show()
        MessageBox.Show("Bissmillah")
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        DERET.MdiParent = Me
        DERET.Show()
        MessageBox.Show("Bissmilaahhh")
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim res = MessageBox.Show("Yakin Mau Keluar nih ? ?", " Keluar Program", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        Environment.Exit(0)


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class

Public Class Form1

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
      
        SerialPort1.Open()
        SerialPort1.Write("~")
        ' SerialPort1.Write("*")
        SerialPort1.Write(TextBox2.Text)
        SerialPort1.Write("`")
        SerialPort1.Write(TextBox1.Text)
        SerialPort1.Close()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SerialPort1.Open()
        SerialPort1.Write("~")
        
        SerialPort1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        'What we will do here is trap the closing of the application and send the application

        'to the system tray (or so it will appear, we will just make it invisible, re-showing

        'it will be up to you and your notify icon)



        'First minimize the form

        Me.WindowState = FormWindowState.Minimized



        'Now make it invisible (make it look like it went into the system tray)

        Me.Visible = False

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub

    Private Sub ShowProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProgramToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Show()
    End Sub
End Class

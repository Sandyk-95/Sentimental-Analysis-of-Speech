Imports System.IO

Public Class frmAnalyzer

    Dim sideBarMax As Boolean = True
    Dim Pos As Point
    Dim Argument As String = ""

    Private Sub btnAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudio.Click
        If OfdWav.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Argument = OfdWav.FileName
            Analyze("SpeechToText.py", Argument)
        End If
    End Sub

    Private Sub btnText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnText.Click
        If OfdTxt.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Argument = OfdTxt.FileName
            Analyze("TextFile.py", Argument)
        End If
    End Sub

    Private Sub btnAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyze.Click
        If txtText.Text <> "" Then
            Argument = txtText.Text
            Using sw As StreamWriter = New StreamWriter("C:\InputFile.txt")
                sw.Write(Argument)
            End Using
            Analyze("TextFile.py", "C:\InputFile.txt")
        End If
    End Sub

    Function Analyze(ByVal FileName As String, ByVal Argument As String) As Integer
        Dim p As Process = New Process
        Dim path As String = Application.StartupPath()
        'p.StartInfo.WorkingDirectory = "E:\Project\Source Code\Final Python"
        p.StartInfo.WorkingDirectory = path
        p.StartInfo.Arguments = Argument
        p.StartInfo.FileName = FileName
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()
        tsslabel.Text = "Please Wait processing your request"
        p.WaitForExit()
        tsslabel.Text = "Request Completed"
        Return True
    End Function

    Private Sub picSideBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSideBar.Click
        If sideBarMax <> False Then
            sideBarMax = False
            btnLogOut.Hide()
            btnAbout.Hide()
            txtUserName.Hide()
            Do While pnlSideBar.Width > 39
                pnlSideBar.Width = pnlSideBar.Width - 1
            Loop
        Else
            sideBarMax = True
            Do While pnlSideBar.Width < 202
                pnlSideBar.Width = pnlSideBar.Width + 1
            Loop
            btnAbout.Show()
            btnLogOut.Show()
            txtUserName.Show()
        End If

    End Sub

    Private Sub pnlMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMain.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub pnlTopBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAnalyzer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Text = frmLogin.userName
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmLogin.Show()
    End Sub


    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub
End Class
Public Class frmAdmin

    Dim Pos As Point
    Dim sideBarMax As Boolean = True

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DbDataSet.Login)
        txtUserName.Text = frmLogin.userName
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
        DataGridView1.ForeColor = Color.Black
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        LoginBindingSource.EndEdit()
        LoginTableAdapter.Update(DbDataSet.Login)
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        LoginBindingSource.EndEdit()
        LoginTableAdapter.Update(DbDataSet.Login)
        Me.Close()
        frmLogin.Show()
    End Sub

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

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub
End Class
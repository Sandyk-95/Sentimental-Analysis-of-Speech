Imports System.Data.OleDb

Public Class frmRegister

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Db.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Try
            If txtPassword.Text <> "" And txtUserId.Text <> "" And txtUserName.Text <> "" Then
                id_con.Open()
                Dim str As String = "insert into Login values('" & txtUserId.Text & "', '" & txtPassword.Text & "', '" & 0 & "', '" & txtUserName.Text & "')"
                Dim com As New OleDbCommand(str, id_con)
                com.ExecuteNonQuery()
                MsgBox("Registered Successfully", MsgBoxStyle.Information)
                txtUserId.Text = "User Id"
                txtUserName.Text = "User Name"
                txtPassword.Text = "Password"
            Else
                MsgBox("Fill in required fields", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Clearall()
        Finally
            id_con.Close()
            Clearall()
        End Try
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        txtPassword.Clear()
        txtPassword.PasswordChar = "."
    End Sub

    Public Sub Clearall()
        txtUserId.Clear()
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class
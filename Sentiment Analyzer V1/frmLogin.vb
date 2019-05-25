Imports System.Data.OleDb

Public Class frmLogin

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Db.accdb;")
    Dim id_com As New OleDbCommand()
    Public userName As String
    
    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Try
            If txtUserId.Text <> "" And txtPassword.Text <> "" Then
                Dim id_read As OleDbDataReader
                id_con.Open()
                id_com = New OleDbCommand("Select * from Login where LoginId ='" & txtUserId.Text & "'", id_con)
                id_read = id_com.ExecuteReader()
                If id_read.HasRows Then
                    id_read.Read()
                    userName = id_read(3).ToString()
                    If txtPassword.Text = id_read(1).ToString() And id_read(2) = 0 Then
                        Clearall()
                        Me.Hide()
                        frmAnalyzer.Show()
                    ElseIf txtPassword.Text.ToString() = id_read(1).ToString() And id_read(2) = 1 Then
                        Clearall()
                        Me.Hide()
                        frmAdmin.Show()
                    Else
                        MsgBox("Please enter correct Id or Password")
                        Clearall()
                    End If
                End If
            Else
                MsgBox("Fill in Id and Password fields", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "")
            End If
        Catch ex As Exception

        Finally
            id_con.Close()
        End Try
    End Sub

    Public Sub Clearall()
        txtUserId.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        txtPassword.Clear()
        txtPassword.PasswordChar = "."
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmRegister.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load






    End Sub
End Class

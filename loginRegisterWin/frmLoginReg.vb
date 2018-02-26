Imports System.Net.Mail
Imports System.Exception

Public Class frmLoginReg
    Private Sub frmLoginReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Select()
    End Sub

    Private Sub tbCtrlLogReg_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCtrlLogReg.SelectedIndexChanged
        If tbCtrlLogReg.SelectedTab Is tbRegister Then
            frmRegCodeGen.ShowDialog() 'Shows Registration verification code only when 
        End If                         'opening Registration tab.
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tbLogin.Show()
        tbCtrlLogReg.SelectTab(tbLogin) 'This sets the login tab as active
    End Sub

    Private Sub btnFrgtPwd_Click(sender As Object, e As EventArgs) Handles btnFrgtPwd.Click
        frmForgotPwrdCodeGen.ShowDialog()
    End Sub

    Private Sub btnRegUser_Click(sender As Object, e As EventArgs) Handles btnRegUser.Click

        If validateEmail(txtEmailReg.Text) AndAlso validateStringFields(txtNameUser.Text) Then
            'Continue
            MessageBox.Show("Wuju")
        Else
            'Fallback, try again
            MessageBox.Show("Yikes")

        End If

    End Sub

    ' UTIL
    Private Function validateEmail(ByVal str As String)
        Dim userEmail As MailAddress

        Try
            userEmail = New MailAddress(txtEmailReg.Text)

        Catch ex As Exception
            Return False

        End Try

        Return True

    End Function


    Private Function validateStringFields(ByVal str As String)
        Try
            If String.IsNullOrEmpty(str) OrElse String.IsNullOrWhiteSpace(str) Then
                Throw New System.Exception("Campo Invalido o Vacio")
            End If
        Catch ex As Exception
            Return False

        End Try

        Return True

    End Function


End Class
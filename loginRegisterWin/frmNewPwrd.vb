Public Class frmNewPwrd

    Private Sub frmNewPwrd_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = frmForgotPwrdCodeGen.Location
    End Sub
    Private Sub btnValidateNewPwrdCode_Click(sender As Object, e As EventArgs) Handles btnValidateNewPwrdCode.Click
        'Validate code sent to email to reset password
    End Sub

    Private Sub btnConfirmNewPwrd_Click(sender As Object, e As EventArgs) Handles btnConfirmNewPwrd.Click
        'Update password from table to and back to login page
        Me.Close()
        frmForgotPwrdCodeGen.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmLoginReg.Show()
        Me.Close()
        frmForgotPwrdCodeGen.Close()
    End Sub
End Class
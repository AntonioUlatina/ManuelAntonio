Public Class frmForgotPwrdCodeGen

    Private Sub frmForgotPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = frmLoginReg.Location
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmNewPwrd.ShowDialog()
    End Sub

    Private Sub btnCancelPwrdResetCodeGen_Click(sender As Object, e As EventArgs) Handles btnCancelPwrdResetCodeGen.Click
        Me.Close()
    End Sub
End Class
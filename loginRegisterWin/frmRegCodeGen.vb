Public Class frmRegCodeGen
    Private Sub frmRegCodeGen_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = frmLoginReg.Location
    End Sub
    Private Sub btnSndCode_Click(sender As Object, e As EventArgs) Handles btnSndCode.Click
        'TODO email validation and code generation
        Me.Close()
    End Sub
End Class
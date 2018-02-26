<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPwrdCodeGen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEmailToResetPwd = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lbResetPwd = New System.Windows.Forms.Label()
        Me.btnCancelPwrdResetCodeGen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmailToResetPwd
        '
        Me.txtEmailToResetPwd.Location = New System.Drawing.Point(67, 73)
        Me.txtEmailToResetPwd.Name = "txtEmailToResetPwd"
        Me.txtEmailToResetPwd.Size = New System.Drawing.Size(151, 20)
        Me.txtEmailToResetPwd.TabIndex = 0
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(64, 110)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continuar"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lbResetPwd
        '
        Me.lbResetPwd.Location = New System.Drawing.Point(0, 19)
        Me.lbResetPwd.Name = "lbResetPwd"
        Me.lbResetPwd.Size = New System.Drawing.Size(284, 43)
        Me.lbResetPwd.TabIndex = 2
        Me.lbResetPwd.Text = "Digite su correo institucional. Se le enviara un codigo para verificar su identid" &
    "ad y asi poder restablecer la contraseña a continuacion." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbResetPwd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancelPwrdResetCodeGen
        '
        Me.btnCancelPwrdResetCodeGen.Location = New System.Drawing.Point(145, 110)
        Me.btnCancelPwrdResetCodeGen.Name = "btnCancelPwrdResetCodeGen"
        Me.btnCancelPwrdResetCodeGen.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelPwrdResetCodeGen.TabIndex = 3
        Me.btnCancelPwrdResetCodeGen.Text = "Cancelar."
        Me.btnCancelPwrdResetCodeGen.UseVisualStyleBackColor = True
        '
        'frmForgotPwrdCodeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 152)
        Me.Controls.Add(Me.btnCancelPwrdResetCodeGen)
        Me.Controls.Add(Me.lbResetPwd)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtEmailToResetPwd)
        Me.Name = "frmForgotPwrdCodeGen"
        Me.Text = "Generar Codigo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailToResetPwd As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents lbResetPwd As Label
    Friend WithEvents btnCancelPwrdResetCodeGen As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPwrd
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
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txtConfirmPswd = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirmNewPwrd = New System.Windows.Forms.Button()
        Me.txtNewPsw = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVerifState = New System.Windows.Forms.Label()
        Me.btnValidateNewPwrdCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(137, 135)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(118, 20)
        Me.TextBox7.TabIndex = 19
        Me.TextBox7.UseWaitCursor = True
        '
        'txtConfirmPswd
        '
        Me.txtConfirmPswd.AutoSize = True
        Me.txtConfirmPswd.Location = New System.Drawing.Point(29, 138)
        Me.txtConfirmPswd.Name = "txtConfirmPswd"
        Me.txtConfirmPswd.Size = New System.Drawing.Size(98, 13)
        Me.txtConfirmPswd.TabIndex = 21
        Me.txtConfirmPswd.Text = "Repetir Contraseña"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(191, 163)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancelar."
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirmNewPwrd
        '
        Me.btnConfirmNewPwrd.Location = New System.Drawing.Point(27, 163)
        Me.btnConfirmNewPwrd.Name = "btnConfirmNewPwrd"
        Me.btnConfirmNewPwrd.Size = New System.Drawing.Size(153, 23)
        Me.btnConfirmNewPwrd.TabIndex = 20
        Me.btnConfirmNewPwrd.Text = "Confirmar Nueva Contraseña"
        Me.btnConfirmNewPwrd.UseVisualStyleBackColor = True
        '
        'txtNewPsw
        '
        Me.txtNewPsw.Location = New System.Drawing.Point(137, 113)
        Me.txtNewPsw.Name = "txtNewPsw"
        Me.txtNewPsw.Size = New System.Drawing.Size(118, 20)
        Me.txtNewPsw.TabIndex = 18
        Me.txtNewPsw.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nueva Contraseña"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(92, 25)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Codigo Verificacion"
        '
        'txtVerifState
        '
        Me.txtVerifState.AutoSize = True
        Me.txtVerifState.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifState.Location = New System.Drawing.Point(103, 79)
        Me.txtVerifState.Name = "txtVerifState"
        Me.txtVerifState.Size = New System.Drawing.Size(79, 25)
        Me.txtVerifState.TabIndex = 23
        Me.txtVerifState.Text = "Estado"
        '
        'btnValidateNewPwrdCode
        '
        Me.btnValidateNewPwrdCode.Location = New System.Drawing.Point(105, 51)
        Me.btnValidateNewPwrdCode.Name = "btnValidateNewPwrdCode"
        Me.btnValidateNewPwrdCode.Size = New System.Drawing.Size(75, 23)
        Me.btnValidateNewPwrdCode.TabIndex = 17
        Me.btnValidateNewPwrdCode.Text = "Validar."
        Me.btnValidateNewPwrdCode.UseVisualStyleBackColor = True
        '
        'frmNewPwrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.btnValidateNewPwrdCode)
        Me.Controls.Add(Me.txtVerifState)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtConfirmPswd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirmNewPwrd)
        Me.Controls.Add(Me.txtNewPsw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmNewPwrd"
        Me.Text = "Nueva Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtConfirmPswd As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirmNewPwrd As Button
    Friend WithEvents txtNewPsw As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVerifState As Label
    Friend WithEvents btnValidateNewPwrdCode As Button
End Class

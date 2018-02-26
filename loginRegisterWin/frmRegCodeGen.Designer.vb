<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegCodeGen
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
        Me.btnSndCode = New System.Windows.Forms.Button()
        Me.lblVerifyDesc = New System.Windows.Forms.Label()
        Me.txtEmailVerif = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSndCode
        '
        Me.btnSndCode.Location = New System.Drawing.Point(81, 87)
        Me.btnSndCode.Name = "btnSndCode"
        Me.btnSndCode.Size = New System.Drawing.Size(93, 23)
        Me.btnSndCode.TabIndex = 0
        Me.btnSndCode.Text = "Enviar Codigo"
        Me.btnSndCode.UseVisualStyleBackColor = True
        '
        'lblVerifyDesc
        '
        Me.lblVerifyDesc.Location = New System.Drawing.Point(21, 9)
        Me.lblVerifyDesc.Name = "lblVerifyDesc"
        Me.lblVerifyDesc.Size = New System.Drawing.Size(212, 27)
        Me.lblVerifyDesc.TabIndex = 1
        Me.lblVerifyDesc.Text = "Digite su correo institucional para generar un codigo verificador." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEmailVerif
        '
        Me.txtEmailVerif.Location = New System.Drawing.Point(56, 48)
        Me.txtEmailVerif.Name = "txtEmailVerif"
        Me.txtEmailVerif.Size = New System.Drawing.Size(143, 20)
        Me.txtEmailVerif.TabIndex = 2
        '
        'frmRegCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 115)
        Me.Controls.Add(Me.txtEmailVerif)
        Me.Controls.Add(Me.lblVerifyDesc)
        Me.Controls.Add(Me.btnSndCode)
        Me.Name = "frmRegCode"
        Me.Text = "Verificacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSndCode As Button
    Friend WithEvents lblVerifyDesc As Label
    Friend WithEvents txtEmailVerif As TextBox
End Class

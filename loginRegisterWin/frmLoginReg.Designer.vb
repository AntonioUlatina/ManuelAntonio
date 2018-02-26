<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginReg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.lbPwrd = New System.Windows.Forms.Label()
        Me.btnFrgtPwd = New System.Windows.Forms.Button()
        Me.tbCtrlLogReg = New System.Windows.Forms.TabControl()
        Me.tbLogin = New System.Windows.Forms.TabPage()
        Me.txtPwrd = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tbRegister = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegUser = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmailReg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNameUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCtrlLogReg.SuspendLayout()
        Me.tbLogin.SuspendLayout()
        Me.tbRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(70, 50)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(137, 21)
        Me.txtLogin.TabIndex = 1
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLogin.Location = New System.Drawing.Point(118, 30)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(41, 16)
        Me.lbLogin.TabIndex = 2
        Me.lbLogin.Text = "Login"
        Me.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPwrd
        '
        Me.lbPwrd.AutoSize = True
        Me.lbPwrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPwrd.Location = New System.Drawing.Point(103, 91)
        Me.lbPwrd.Name = "lbPwrd"
        Me.lbPwrd.Size = New System.Drawing.Size(77, 16)
        Me.lbPwrd.TabIndex = 3
        Me.lbPwrd.Text = "Contraseña"
        Me.lbPwrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFrgtPwd
        '
        Me.btnFrgtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrgtPwd.Location = New System.Drawing.Point(60, 318)
        Me.btnFrgtPwd.Name = "btnFrgtPwd"
        Me.btnFrgtPwd.Size = New System.Drawing.Size(145, 29)
        Me.btnFrgtPwd.TabIndex = 4
        Me.btnFrgtPwd.Text = "Olvide mi contraseña."
        Me.btnFrgtPwd.UseVisualStyleBackColor = True
        '
        'tbCtrlLogReg
        '
        Me.tbCtrlLogReg.Controls.Add(Me.tbLogin)
        Me.tbCtrlLogReg.Controls.Add(Me.tbRegister)
        Me.tbCtrlLogReg.Location = New System.Drawing.Point(0, 0)
        Me.tbCtrlLogReg.Name = "tbCtrlLogReg"
        Me.tbCtrlLogReg.SelectedIndex = 0
        Me.tbCtrlLogReg.Size = New System.Drawing.Size(285, 384)
        Me.tbCtrlLogReg.TabIndex = 5
        '
        'tbLogin
        '
        Me.tbLogin.Controls.Add(Me.txtLogin)
        Me.tbLogin.Controls.Add(Me.txtPwrd)
        Me.tbLogin.Controls.Add(Me.btnLogin)
        Me.tbLogin.Controls.Add(Me.btnFrgtPwd)
        Me.tbLogin.Controls.Add(Me.lbLogin)
        Me.tbLogin.Controls.Add(Me.lbPwrd)
        Me.tbLogin.Location = New System.Drawing.Point(4, 22)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLogin.Size = New System.Drawing.Size(277, 358)
        Me.tbLogin.TabIndex = 1
        Me.tbLogin.Text = "Login"
        Me.tbLogin.UseVisualStyleBackColor = True
        '
        'txtPwrd
        '
        Me.txtPwrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwrd.Location = New System.Drawing.Point(70, 110)
        Me.txtPwrd.Name = "txtPwrd"
        Me.txtPwrd.Size = New System.Drawing.Size(137, 21)
        Me.txtPwrd.TabIndex = 2
        Me.txtPwrd.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(109, 179)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(71, 25)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Ingresar."
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'tbRegister
        '
        Me.tbRegister.Controls.Add(Me.TextBox3)
        Me.tbRegister.Controls.Add(Me.Label10)
        Me.tbRegister.Controls.Add(Me.TextBox1)
        Me.tbRegister.Controls.Add(Me.Label9)
        Me.tbRegister.Controls.Add(Me.Label8)
        Me.tbRegister.Controls.Add(Me.DateTimePicker1)
        Me.tbRegister.Controls.Add(Me.TextBox7)
        Me.tbRegister.Controls.Add(Me.Label7)
        Me.tbRegister.Controls.Add(Me.btnCancel)
        Me.tbRegister.Controls.Add(Me.btnRegUser)
        Me.tbRegister.Controls.Add(Me.TextBox5)
        Me.tbRegister.Controls.Add(Me.Label5)
        Me.tbRegister.Controls.Add(Me.TextBox6)
        Me.tbRegister.Controls.Add(Me.Label6)
        Me.tbRegister.Controls.Add(Me.txtEmailReg)
        Me.tbRegister.Controls.Add(Me.Label3)
        Me.tbRegister.Controls.Add(Me.TextBox4)
        Me.tbRegister.Controls.Add(Me.Label4)
        Me.tbRegister.Controls.Add(Me.TextBox2)
        Me.tbRegister.Controls.Add(Me.Label2)
        Me.tbRegister.Controls.Add(Me.txtNameUser)
        Me.tbRegister.Controls.Add(Me.Label1)
        Me.tbRegister.Location = New System.Drawing.Point(4, 22)
        Me.tbRegister.Name = "tbRegister"
        Me.tbRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegister.Size = New System.Drawing.Size(277, 358)
        Me.tbRegister.TabIndex = 0
        Me.tbRegister.Text = "Registrarse"
        Me.tbRegister.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Telefono Movil"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 192)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Telefono Fijo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fecha Nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 99)
        Me.DateTimePicker1.MaxDate = New Date(3333, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(143, 282)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Codigo Verificacion"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(198, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancelar."
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegUser
        '
        Me.btnRegUser.Location = New System.Drawing.Point(120, 330)
        Me.btnRegUser.Name = "btnRegUser"
        Me.btnRegUser.Size = New System.Drawing.Size(75, 23)
        Me.btnRegUser.TabIndex = 11
        Me.btnRegUser.Text = "Registrarse."
        Me.btnRegUser.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(144, 252)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Repetir Contraseña"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(144, 219)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Contraseña"
        '
        'txtEmailReg
        '
        Me.txtEmailReg.Location = New System.Drawing.Point(143, 132)
        Me.txtEmailReg.Name = "txtEmailReg"
        Me.txtEmailReg.Size = New System.Drawing.Size(100, 20)
        Me.txtEmailReg.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(143, 72)
        Me.TextBox4.MaxLength = 9
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cedula"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(143, 42)
        Me.TextBox2.MaxLength = 60
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos"
        '
        'txtNameUser
        '
        Me.txtNameUser.Location = New System.Drawing.Point(143, 12)
        Me.txtNameUser.MaxLength = 45
        Me.txtNameUser.Name = "txtNameUser"
        Me.txtNameUser.Size = New System.Drawing.Size(100, 20)
        Me.txtNameUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'frmLoginReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 381)
        Me.Controls.Add(Me.tbCtrlLogReg)
        Me.Name = "frmLoginReg"
        Me.Text = "Ingresar al Sistema"
        Me.tbCtrlLogReg.ResumeLayout(False)
        Me.tbLogin.ResumeLayout(False)
        Me.tbLogin.PerformLayout()
        Me.tbRegister.ResumeLayout(False)
        Me.tbRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLogin As TextBox
    Friend WithEvents lbLogin As Label
    Friend WithEvents lbPwrd As Label
    Friend WithEvents btnFrgtPwd As Button
    Friend WithEvents tbCtrlLogReg As TabControl
    Friend WithEvents tbLogin As TabPage
    Friend WithEvents btnLogin As Button
    Friend WithEvents tbRegister As TabPage
    Friend WithEvents txtPwrd As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmailReg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNameUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegUser As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
End Class

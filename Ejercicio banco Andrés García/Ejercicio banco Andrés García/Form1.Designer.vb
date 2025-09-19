<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbldescubierto = New Label()
        txtNombre = New TextBox()
        direccion = New TextBox()
        txtDNI = New TextBox()
        txtDescubierto = New TextBox()
        txtTelefono = New TextBox()
        rdbCajaAhorro = New RadioButton()
        rdbCuentaCorriente = New RadioButton()
        txtApellido = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Button1.Location = New Point(185, 316)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 58)
        Button1.TabIndex = 0
        Button1.Text = "Alta Cliente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Button2.Location = New Point(373, 316)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 58)
        Button2.TabIndex = 1
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label1.Location = New Point(185, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 2
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label2.Location = New Point(185, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 3
        Label2.Text = "Direccion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label3.Location = New Point(185, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 23)
        Label3.TabIndex = 4
        Label3.Text = "DNI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label4.Location = New Point(185, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 23)
        Label4.TabIndex = 5
        Label4.Text = "Telefono"
        ' 
        ' lbldescubierto
        ' 
        lbldescubierto.AutoSize = True
        lbldescubierto.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        lbldescubierto.Location = New Point(185, 276)
        lbldescubierto.Name = "lbldescubierto"
        lbldescubierto.Size = New Size(120, 23)
        lbldescubierto.TabIndex = 6
        lbldescubierto.Text = "Descubierto $"
        lbldescubierto.Visible = False
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtNombre.Location = New Point(324, 88)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(213, 30)
        txtNombre.TabIndex = 7
        ' 
        ' direccion
        ' 
        direccion.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        direccion.Location = New Point(324, 159)
        direccion.Name = "direccion"
        direccion.Size = New Size(213, 30)
        direccion.TabIndex = 8
        ' 
        ' txtDNI
        ' 
        txtDNI.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtDNI.Location = New Point(324, 197)
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(213, 30)
        txtDNI.TabIndex = 9
        ' 
        ' txtDescubierto
        ' 
        txtDescubierto.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtDescubierto.Location = New Point(324, 276)
        txtDescubierto.Name = "txtDescubierto"
        txtDescubierto.Size = New Size(213, 30)
        txtDescubierto.TabIndex = 11
        txtDescubierto.Visible = False
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtTelefono.Location = New Point(324, 235)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(213, 30)
        txtTelefono.TabIndex = 10
        ' 
        ' rdbCajaAhorro
        ' 
        rdbCajaAhorro.AutoSize = True
        rdbCajaAhorro.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        rdbCajaAhorro.Location = New Point(185, 36)
        rdbCajaAhorro.Name = "rdbCajaAhorro"
        rdbCajaAhorro.Size = New Size(150, 27)
        rdbCajaAhorro.TabIndex = 12
        rdbCajaAhorro.TabStop = True
        rdbCajaAhorro.Text = "Caja De Ahorro"
        rdbCajaAhorro.UseVisualStyleBackColor = True
        ' 
        ' rdbCuentaCorriente
        ' 
        rdbCuentaCorriente.AutoSize = True
        rdbCuentaCorriente.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        rdbCuentaCorriente.Location = New Point(396, 36)
        rdbCuentaCorriente.Name = "rdbCuentaCorriente"
        rdbCuentaCorriente.Size = New Size(159, 27)
        rdbCuentaCorriente.TabIndex = 13
        rdbCuentaCorriente.TabStop = True
        rdbCuentaCorriente.Text = "Cuenta Corriente"
        rdbCuentaCorriente.UseVisualStyleBackColor = True
        ' 
        ' txtApellido
        ' 
        txtApellido.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtApellido.Location = New Point(324, 125)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(213, 30)
        txtApellido.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label5.Location = New Point(185, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 23)
        Label5.TabIndex = 14
        Label5.Text = "Apellido"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtApellido)
        Controls.Add(Label5)
        Controls.Add(rdbCuentaCorriente)
        Controls.Add(rdbCajaAhorro)
        Controls.Add(txtDescubierto)
        Controls.Add(txtTelefono)
        Controls.Add(txtDNI)
        Controls.Add(direccion)
        Controls.Add(txtNombre)
        Controls.Add(lbldescubierto)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbldescubierto As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtDescubierto As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents rdbCajaAhorro As RadioButton
    Friend WithEvents rdbCuentaCorriente As RadioButton
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label5 As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1 = New Panel()
        txtImporte = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        lblSaldo = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(492, 99)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 98)
        Button1.TabIndex = 0
        Button1.Text = "Deposito"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(492, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 98)
        Button2.TabIndex = 1
        Button2.Text = "Extraccion"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(492, 321)
        Button3.Name = "Button3"
        Button3.Size = New Size(152, 60)
        Button3.TabIndex = 2
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(103, 321)
        Button4.Name = "Button4"
        Button4.Size = New Size(383, 60)
        Button4.TabIndex = 3
        Button4.Text = "Cerrar la cuenta"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(txtImporte)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(102, 97)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 212)
        Panel1.TabIndex = 4
        ' 
        ' txtImporte
        ' 
        txtImporte.Location = New Point(73, 108)
        txtImporte.Name = "txtImporte"
        txtImporte.Size = New Size(190, 23)
        txtImporte.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Importe"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Yellow
        Panel2.Controls.Add(lblSaldo)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(99, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(538, 79)
        Panel2.TabIndex = 5
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Location = New Point(393, 25)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(32, 15)
        lblSaldo.TabIndex = 1
        lblSaldo.Text = "Labe"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 0
        Label2.Text = "Saldo"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label2 As Label
End Class

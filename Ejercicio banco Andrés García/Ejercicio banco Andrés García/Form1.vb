Imports System.IO

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCajaAhorro.CheckedChanged
        lbldescubierto.Visible = False
        txtDescubierto.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCuentaCorriente.CheckedChanged
        lbldescubierto.Visible = True
        txtDescubierto.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cli As New Cliente()

        cli.nombre = txtNombre.Text
        cli.apellido = txtApellido.Text
        cli.DNI = Val(txtDNI.Text)
        cli.telefono_celular = Val(txtTelefono.Text)
        cli.descubierto = Val(txtDescubierto.Text)
        cli.direccion = direccion.Text

        If rdbCajaAhorro.Checked Then
            cli.TipoCuenta = "A"c
        ElseIf rdbCuentaCorriente.Checked Then
            cli.TipoCuenta = "C"c
        End If

        MsgBox(cli.Datos(), vbInformation, "Banco1")

        If direccion.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtDNI.Text = 0 Then
            MsgBox("Usted no puede acceder a la cuenta ya que faltan datos", vbCritical)
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class

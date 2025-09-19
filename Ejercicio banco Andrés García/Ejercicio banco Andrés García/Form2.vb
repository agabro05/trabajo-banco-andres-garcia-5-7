Public Class Form2
    Private cuenta As Cueta
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuenta = New Cueta(0)
        ActualizarSaldo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cuenta.Depositar(Val(txtImporte.Text))
        ActualizarSaldo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cuenta.Extraer(Val(txtImporte.Text))
        ActualizarSaldo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cuenta.Extraer()
        ActualizarSaldo()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
    Private Sub ActualizarSaldo()
        lblSaldo.Text = cuenta.Saldo.ToString() & " $"
    End Sub
End Class
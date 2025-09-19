Public Class Cueta

    Private _saldo As Decimal
    Public Property Saldo As Decimal
        Get
            Return _saldo
        End Get
        Set(value As Decimal)
            _saldo = value
        End Set
    End Property
    Public Sub New(saldoInicial As Decimal)
            _saldo = saldoInicial
        End Sub


    Public Sub Depositar(monto As Decimal)
            If monto > 0 Then
                _saldo += monto
            Else
                MsgBox("El importe a depositar debe ser mayor a 0", vbCritical)
            End If
        End Sub

    Public Sub Extraer(monto As Decimal)
            If monto > 0 Then
                _saldo -= monto
            Else
                MsgBox("El importe a extraer debe ser mayor a 0", vbCritical)
            End If
        End Sub

    Public Sub Extraer()
            If _saldo >= 0 Then
                MsgBox("Cuenta cerrada exitosamente", vbInformation)
                _saldo = 0
            Else
                MsgBox("Imposible cerrar la cuenta porque tiene saldo deudor", vbCritical)
            End If
        End Sub
    End Class


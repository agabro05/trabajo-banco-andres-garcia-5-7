Public Class Cliente
    Private _nombre As String
    Private _apellido As String
    Private _dni As Integer
    Private _telefono As Integer
    Private __descubierto As Integer
    Private _tipoCuenta As Char
    Private _direccion As String

    Public Property nombre As String
        Get

            Return _nombre
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                MsgBox("El nombre no puede esstar vacio", vbCritical)
            Else
                _nombre = value

            End If
        End Set
    End Property

    Public Property apellido As String
        Get

            Return _apellido
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                MsgBox("El apellido no puede estar vacio", vbCritical)
            Else
                _apellido = value

            End If
        End Set
    End Property

    Public Property DNI As Integer
        Get

            Return _dni
        End Get
        Set(value As Integer)
            If value >= 10000000 And value <= 99999999 Then
                _dni = value

            Else
                MsgBox("Por ahora no existe nadie con mas de 8 digitos en el DNI", vbCritical)
            End If
        End Set
    End Property

    Public Property telefono_celular As Long
        Get

            Return _telefono
        End Get
        Set(value As Long)
            If value >= 1000000000 And value <= 99999999990 Then
                _telefono = value

            Else
                MsgBox("un telefono no puede tener mas de 10 numeros ", vbCritical)
            End If
        End Set
    End Property
    Public Property descubierto As Integer
        Get
            Return __descubierto
        End Get
        Set(value As Integer)
            If value >= 0 Or value <= 50000 Then
                __descubierto = value

            Else
                MsgBox("el prestamo maximo es de 50000 ", vbCritical)
            End If
        End Set
    End Property
    Public Property TipoCuenta As Char
        Get
            Return _tipoCuenta
        End Get
        Set(value As Char)
            If value = "A"c Or value = "C"c Then
                _tipoCuenta = value
            Else
                MsgBox("El tipo de cuenta debe ser A (Ahorro) o C (Corriente)", vbCritical)
            End If
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                MsgBox("La dirección no puede estar vacía", vbCritical)
            Else
                _direccion = value
            End If
        End Set
    End Property
    Public Function Datos() As String
        Return "ID 0 " & nombre & " " & apellido &
               " - DNI: " & DNI &
               " - Direccion: " & direccion &
               " - Tel: " & telefono_celular &
               " - Descubierto: $" & descubierto &
               " - Tipo Cta:" & TipoCuenta
    End Function

End Class


Imports Entidades

Public NotInheritable Class Autor
    Implements I_Empleado


    Private _dni As UInteger
    Public Property Dni As UInteger Implements I_Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String Implements I_Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Count > 2 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Function CalcularGanancia() As Decimal Implements I_Empleado.CalcularGanancia
        Throw New NotImplementedException()
    End Function

    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function


End Class


Imports Entidades

Public Class Editor
    Implements I_Empleado

    ' Asociaciones 

    Private _material As List(Of MaterialBase)

    Public Sub AddMaterial(material As MaterialBase)
        If material.Editor IsNot Nothing Then
            Dim otroeditor = material.Editor
            otroeditor.RemoverMaterial(material)
        End If
        material.Editor = Me
        _material.Add(material)
    End Sub


    Public Function RemoverMaterial(material As MaterialBase) As Boolean
        material.Editor = Nothing
        _material.Remove(material)
    End Function

    Public Function GetAllMaterial() As List(Of MaterialBase)
        Return _material
    End Function


    ' --------------------------------------------------------------------------------
    Private _dni As UInteger
    Private _nombre As String

    Public Property Dni As UInteger Implements i_Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            If value > 0 Then
                _dni = value
            End If

        End Set
    End Property

    Public Property Nombre As String Implements i_Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Count > 3 Then
                _nombre = value
            End If

        End Set
    End Property

    Public Function CalcularGanancia() As Decimal Implements i_Empleado.CalcularGanancia
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

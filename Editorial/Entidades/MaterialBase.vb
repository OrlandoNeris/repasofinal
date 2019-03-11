Public MustInherit Class MaterialBase

    ' Asosiaciones    '

    Private _editor As Editor
    Public Property Editor As Editor
        Get
            Return _editor
        End Get
        Friend Set(value As Editor)
            _editor = value
        End Set
    End Property

    Private _titulo As String
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Count > 0 And value.Count <= 256 Then
                _titulo = value
            End If
        End Set
    End Property

    Private _montoContrato As Decimal
    Public Property MontoContrato As Decimal
        Get
            Return _montoContrato
        End Get
        Set(value As Decimal)
            _montoContrato = value
        End Set
    End Property

    Public Shared PorcentajeEditorPorBorrador As Byte

    Public Shared PorcentajeEditorPorLibro As Byte

    Sub New(titulo As String, montoContrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montoContrato
    End Sub

    Public Function GananciaPorcentajePorAutor() As Byte
        Return 0
    End Function

    Public Function GananciaEditor() As Decimal
        Return 0
    End Function


End Class

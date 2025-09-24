Public Class Persona
    Private nombre As String
    Private apellido As String
    Private edad As Integer

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Edad1 As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Sub New()
        'Constructor por defecto
        Me.nombre = "No hay nombre"
    End Sub

    Public Sub New(edad As Integer)
        Me.edad = edad
    End Sub

    Public Sub New(nombre1 As String, apellido1 As String, edad1 As Integer)
        Me.Nombre1 = nombre1
        Me.Apellido1 = apellido1
        Me.Edad1 = edad1
    End Sub
End Class

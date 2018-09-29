Imports System.Net.WebClient
Imports System.Web.Script.Serialization




Public Class User
    Private id As Integer
    Private name As String
    Private age As Integer
    Private email As String
    Protected url As String = "localhost:21722/test/ws/users"
    Protected webClient As System.Net.WebClient
    Protected json As String










    Public Sub New(id As Integer, name As String, age As Integer, email As String)
        Me.id = id
        Me.name = name
        Me.age = age
        Me.email = email
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Age1 As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Function findByAll() As List(Of User)
        Try
            json = webClient.DownloadString(url)
            Dim serializador As New JavaScriptSerializer
            Dim listUser As New List(Of User)
            listUser = serializador.Deserialize(Of List(Of User))(json)

            Return listUser
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function






End Class

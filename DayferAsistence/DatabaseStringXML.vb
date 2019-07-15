Imports System.Xml
Public Class DatabaseStringXML
    'Esquema Basico del XML
    Private ServerName As String
    Private LoginName As String
    Private Password As String
    Private Database As String
    Private Identity As Boolean
    Private Descripcion As String
#Region "Propiedades del Esquema XML"
    Public ReadOnly Property str_ServerName() As String
        Get
            Return ServerName
        End Get
    End Property
    Public ReadOnly Property str_LoginName() As String
        Get
            Return LoginName
        End Get
    End Property
    Public ReadOnly Property str_Password() As String
        Get
            Return Password
        End Get
    End Property
    Public ReadOnly Property bol_Identity() As Boolean
        Get
            Return Identity
        End Get
    End Property
    Public ReadOnly Property str_Descripcion() As String
        Get
            Return Descripcion
        End Get
    End Property
    Public ReadOnly Property str_DataBase() As String
        Get
            Return Database
        End Get
    End Property
#End Region

#Region "Constructores"
    Sub New()

    End Sub
    Public Sub New(serverName As String, loginName As String, password As String, identity As Boolean, descripcion As String, database As String)
        Me.ServerName = serverName
        Me.LoginName = loginName
        Me.Password = password
        Me.Identity = identity
        Me.Descripcion = descripcion
        Me.Database = database
    End Sub
#End Region

#Region "Acciones"
    Public Sub EscribeXML()
        ' Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim Document As New XmlDocument

        settings.Indent = True



        ' Create XmlWriter.

        Document.Load("C:\fer\DatabaseTMP.xml")

        Using writer As XmlWriter = Document.CreateNavigator.AppendChild

            writer.WriteStartElement("ConexionDB") ' Root.
            ' Loop over employees in array.
            writer.WriteElementString("ServerName", Me.ServerName)
            writer.WriteElementString("LoginName", Me.LoginName)
            writer.WriteElementString("Password", Me.Password)
            writer.WriteElementString("Database", Me.Database)
            writer.WriteElementString("Identity", Me.Identity)
            writer.WriteElementString("Descripcion", Me.Descripcion)
            writer.WriteEndElement()
            writer.WriteEndDocument()


        End Using

        'Using writer As XmlWriter = XmlWriter.Create("C:\fer\DatabaseTMP.xml", settings)
        '    ' Begin writing.
        '    writer.WriteStartDocument()
        '    writer.WriteStartElement("BaseDatos") ' Root.

        '    ' Loop over employees in array.
        '    writer.WriteStartElement("ConexionDB")
        '    writer.WriteElementString("ServerName", Me.ServerName)
        '    writer.WriteElementString("LoginName", Me.LoginName)
        '    writer.WriteElementString("Password", Me.Password)
        '    writer.WriteElementString("Database", Me.Database)
        '    writer.WriteElementString("Identity", Me.Identity)
        '    writer.WriteElementString("Descripcion", Me.Descripcion)
        '    writer.WriteEndElement()

        '    ' End document.
        '    writer.WriteEndElement()
        '    writer.WriteEndDocument()
        'End Using
    End Sub


#End Region


End Class

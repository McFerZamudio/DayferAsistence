Imports System.Xml
Module xmlModule
    ''' <summary>
    ''' Employee type.
    ''' </summary>
    Class Employee
        Public Sub New(ByVal id As Integer, ByVal firstName As String,
                       ByVal lastName As String, ByVal salary As Integer)
            ' Set fields.
            Me._id = id
            Me._firstName = firstName
            Me._lastName = lastName
            Me._salary = salary
        End Sub

        ' Storage of employee data.
        Public _firstName As String
        Public _id As Integer
        Public _lastName As String
        Public _salary As Integer
    End Class

    Sub Main()
        ' Create array of employees.
        Dim employees(2) As Employee
        employees(0) = New Employee(1, "Prakash", "Rangan", 70000)
        employees(1) = New Employee(5, "Norah", "Miller", 21000)
        employees(2) = New Employee(17, "Cecil", "Walker", 60000)

        ' Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True

        ' Create XmlWriter.
        Using writer As XmlWriter = XmlWriter.Create("C:\employees.xml", settings)
            ' Begin writing.
            writer.WriteStartDocument()
            writer.WriteStartElement("Employees") ' Root.

            ' Loop over employees in array.
            Dim employee As Employee
            For Each employee In employees
                writer.WriteStartElement("Employee")
                writer.WriteElementString("ID", employee._id.ToString)
                writer.WriteElementString("FirstName", employee._firstName)
                writer.WriteElementString("LastName", employee._lastName)
                writer.WriteElementString("Salary", employee._salary.ToString)
                writer.WriteEndElement()
            Next

            ' End document.
            writer.WriteEndElement()
            writer.WriteEndDocument()
        End Using
    End Sub
End Module

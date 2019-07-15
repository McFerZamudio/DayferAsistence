Public Class frmMain
    Dim myXMLconex As New dtsDayferAsistence.ConexionStringsDataTable
    Private Sub ProcedimientosAlmacenadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcedimientosAlmacenadosToolStripMenuItem.Click
        Dim frmLocal As New frmDatabase

        frmLocal.Show()

    End Sub

    Private Sub BtnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Try
            Dim adap_execute As New SqlClient.SqlDataAdapter
            Dim tblBasess As New DataTable("tblBasess")

            cnx.ConnectionString = "Data Source=" & txtServer.Text

            If chkIntegrity.Checked = True Then
                cnx.ConnectionString = cnx.ConnectionString & "; Integrated Security=true;"
            Else
                cnx.ConnectionString = cnx.ConnectionString & "; User ID=" & txtLogin.Text & "; PWD=" & txtPassword.Text
            End If

            cnx.Open()

            adap_execute = New SqlClient.SqlDataAdapter("select name from sysdatabases", cnx)

            adap_execute.Fill(tblBasess)

            cmbDatabase.DataSource = tblBasess
            cmbDatabase.DisplayMember = "Name"
            menPrincipal.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message & " / " & cnx.ConnectionString, vbCritical, "Error")
        End Try

    End Sub

    Private Sub ChkIntegrity_CheckedChanged(sender As Object, e As EventArgs) Handles chkIntegrity.CheckedChanged
        If chkIntegrity.Checked = True Then
            txtPassword.Text = ""
            txtPassword.Enabled = False

            txtLogin.Text = ""
            txtLogin.Enabled = False
        Else
            txtPassword.Text = ""
            txtPassword.Enabled = True

            txtLogin.Text = ""
            txtLogin.Enabled = True

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim MyXMLRows As dtsDayferAsistence.ConexionStringsRow
        MyXMLRows = myXMLconex.NewRow

        With MyXMLRows
            .ServerName = txtServer.Text
            .LoginName = txtLogin.Text
            .Password = txtPassword.Text
            .Identity = chkIntegrity.Checked
            .Database = cmbDatabase.Text
            .Descripcion = txtDescripcion.Text
        End With

        myXMLconex.Rows.Add(MyXMLRows)

        Try
            My.Computer.FileSystem.DeleteFile("XMLStringConex.xml")
        Catch ex As Exception

        End Try

        myXMLconex.WriteXml("XMLStringConex.xml")







    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myXMLconex.ReadXml("XMLStringConex.xml")
            'lst_BaseDatos.DataSource = myXMLconex
            'lst_BaseDatos.DisplayMember = "Descripcion"

            my_DtsDayferAsistence.ReadXml("XMLStringConex.xml")





        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menPrincipal.ItemClicked

    End Sub
End Class
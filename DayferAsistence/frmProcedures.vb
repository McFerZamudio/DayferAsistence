Public Class frmDatabase
    Dim tblColumns As New DataTable
    Dim tblIdentidades As New DataTable


#Region "Metodos"
    Public Function CreaProcedimientoAlmacenadoAdd(ByRef str_ColumnsName As String, ByRef str_Values As String) As String
        Dim txt_Tempo As String = ""

        For i = 0 To tblColumns.Rows.Count - 1
            Dim str_Parameters As String = tblColumns.Rows(i)("parametros")
            Dim Bandera As Boolean = False

            For j = 0 To tblIdentidades.Rows.Count - 1
                Try
                    If (tblIdentidades.Rows(j)(0) = tblColumns.Rows(i)("NombreColumna")) And tblIdentidades.Rows(j)("isIdentity") = True Then
                        Bandera = True
                    End If
                Catch ex As Exception

                End Try
            Next

            If Bandera = False Then
                str_ColumnsName = str_ColumnsName & tblColumns.Rows(i)("NombreColumna") & ", "
                str_Values = str_Values & str_Parameters & ", "
            End If

            txt_Tempo = txt_Tempo & str_Parameters & " " & tblColumns.Rows(i)("TipoFinal") & "," & ChrW(13)
        Next
        str_ColumnsName = Mid(str_ColumnsName, 1, Len(str_ColumnsName) - 2)
        str_Values = Mid(str_Values, 1, Len(str_Values) - 2)
        txt_Tempo = Mid(txt_Tempo, 1, Len(txt_Tempo) - 2) & ChrW(13) & ")"
        Return txt_Tempo

    End Function
    Public Function CreaProcedimientoAlmacenadoModify(ByRef str_ColumnsName As String, ByRef str_Values As String) As String
        Dim txt_Tempo As String = ""

        For i = 0 To tblColumns.Rows.Count - 1
            Dim str_Parameters As String = tblColumns.Rows(i)("parametros")
            Dim Bandera As Boolean = False

            For j = 0 To tblIdentidades.Rows.Count - 1
                Try
                    If (tblIdentidades.Rows(j)(0) = tblColumns.Rows(i)("NombreColumna")) And tblIdentidades.Rows(j)("isIdentity") = True Then
                        Bandera = True
                        Exit For
                    End If
                Catch ex As Exception

                End Try
            Next

            If Bandera = False Then
                str_ColumnsName = str_ColumnsName & tblColumns.Rows(i)("NombreColumna") & "=@" & tblColumns.Rows(i)("NombreColumna") & ", "
                str_Values = str_Values & str_Parameters & ", "
            End If
            txt_Tempo = txt_Tempo & str_Parameters & " " & tblColumns.Rows(i)("TipoFinal") & "," & ChrW(13)
        Next

        str_ColumnsName = Mid(str_ColumnsName, 1, Len(str_ColumnsName) - 2)
        str_Values = Mid(str_Values, 1, Len(str_Values) - 2)
        txt_Tempo = Mid(txt_Tempo, 1, Len(txt_Tempo) - 2) & ChrW(13) & ")"
        Return txt_Tempo
    End Function
    Private Sub ObtieneColumnas()
        Dim Adap_Execute As SqlClient.SqlDataAdapter

        Try
            tblColumns.Clear()
        Catch ex As Exception

        End Try
        cnx.ChangeDatabase(txtDatabase.Text)
        tblColumns = New DataTable(txtTable.Text)
        Adap_Execute = New SqlClient.SqlDataAdapter("select *, COLUMN_NAME as NombreColumna, DATA_TYPE as Tipo, CHARACTER_MAXIMUM_LENGTH as Maximo, '' as TipoFinal, '@' + COLUMN_NAME as Parametros  from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" & txtTable.Text & "'", CNX)

        Adap_Execute.Fill(tblColumns)

        lstColumns.Items.Clear()
        For i = 0 To tblColumns.Rows.Count - 1
            Dim tmp_Tipo As String = tblColumns.Rows(i)("Tipo")

            If IsDBNull(tblColumns.Rows(i)("maximo")) = False Then
                tmp_Tipo = tmp_Tipo & "(" & tblColumns.Rows(i)("maximo") & ")"
            Else
                tmp_Tipo = tmp_Tipo
            End If

            tblColumns.Rows(i)("TipoFinal") = tmp_Tipo
            lstColumns.Items.Add(tblColumns.Rows(i)("NombreColumna") & " / " & tblColumns.Rows(i)("TipoFinal"))
        Next

        Adap_Execute = New SqlClient.SqlDataAdapter("select top(0) * from [" & txtTable.Text & "]", CNX)

        Dim LeeEstructura As SqlClient.SqlDataReader
        LeeEstructura = Adap_Execute.SelectCommand.ExecuteReader(CommandBehavior.KeyInfo)

        tblIdentidades.Clear()
        tblIdentidades = LeeEstructura.GetSchemaTable
        tblIdentidades.Columns.Add("Borrar", GetType(Integer))
        LeeEstructura.Close()



        Dim MisFilas As DataRow()
        MisFilas = tblIdentidades.Select("isIdentity=true or iskey=true")


        For i = 0 To tblIdentidades.Rows.Count - 1
            tblIdentidades.Rows(i)("Borrar") = 0
            For j = 0 To MisFilas.Length - 1
                If tblIdentidades.Rows(i)(0) = MisFilas(j)(0) Then
                    tblIdentidades.Rows(i)("Borrar") = tblIdentidades.Rows(i)("Borrar") + 1
                    Exit For
                End If
            Next
            If tblIdentidades.Rows(i)("Borrar") = 0 Then tblIdentidades.Rows(i).Delete()
        Next

        tblIdentidades.AcceptChanges()





    End Sub



#End Region

#Region "Formularios"

    Private Sub CmbDatabase_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim adap_Execute As New SqlClient.SqlDataAdapter("SELECT TABLE_NAME From INFORMATION_SCHEMA.COLUMNS Group By TABLE_NAME", CNX)
        Dim tblTablas As New DataTable

        Try
            cnx.ChangeDatabase(txtDatabase.Text)

            adap_Execute.Fill(tblTablas)

            lstTables.DataSource = tblTablas
            lstTables.DisplayMember = "Table_Name"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnValidate_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObtieneColumnas()
    End Sub

    Private Sub BtnStoredProcedures_Click(sender As Object, e As EventArgs) Handles btnStoredProcedures.Click
        Dim frm_StoredProcedure As New frmResult

        Dim str_ColumnsName As String = ""
        Dim str_Values As String = ""


        '  frm_StoredProcedure.txtResult.Text = "USE [Sofhia_Kernel] " & ChrW(13) & " GO " & ChrW(13) & " /****** Object:  StoredProcedure [dbo].[PA_AddLanguage]    Script Date:  12/12/2018 3:14:27 p.m. ******/ " & ChrW(13) & " SET ANSI_NULLS ON " & ChrW(13) & " GO " & ChrW(13) & " SET QUOTED_IDENTIFIER ON " & ChrW(13) & " GO " & ChrW(13) & " " & ChrW(13) & " CREATE PROCEDURE [dbo].[] " & ChrW(13) & " ( "
        frm_StoredProcedure.lbl_Tabla.Text = txtTable.Text

        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & "PA_" & Mid(frm_StoredProcedure.lbl_Tabla.Text, 5, Len(frm_StoredProcedure.lbl_Tabla.Text) - 4) & "_Add]" & ChrW(13) & "("
        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & CreaProcedimientoAlmacenadoAdd(str_ColumnsName, str_Values)

        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & ChrW(13) & ChrW(13) & "AS" & ChrW(13) & ChrW(13) & "SET NOCOUNT OFF;" & ChrW(13) & ChrW(13) & "INSERT INTO [" & txtTable.Text & "]" & ChrW(13) & ChrW(13) & "(" & str_ColumnsName & ")" & ChrW(13)
        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & ChrW(13) & "VALUES (" & str_Values & ")"



        frm_StoredProcedure.lblTittle.Text = "Procedimiento de Agregación para la tabla " & txtTable.Text

        frm_StoredProcedure.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm_StoredProcedure As New frmResult

        Dim str_ColumnsName As String = ""
        Dim str_Values As String = ""

        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & CreaProcedimientoAlmacenadoModify(str_ColumnsName, str_Values)

        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & ChrW(13) & ChrW(13) & "AS" & ChrW(13) & ChrW(13) & "SET NOCOUNT OFF;" & ChrW(13) & ChrW(13) & "UPDATE [" & txtTable.Text & "]" & ChrW(13) & ChrW(13) & "SET " & str_ColumnsName & ChrW(13) & " WHERE "

        Dim tpm_Where As String = ""
        For i = 0 To tblIdentidades.Rows.Count - 1
            Try
                tpm_Where = tpm_Where & "(" & tblIdentidades.Rows(i)(0) & "=@" & tblIdentidades.Rows(i)(0) & ") AND "
            Catch ex As Exception

            End Try
        Next

        tpm_Where = Mid(tpm_Where, 1, Len(tpm_Where) - 5)
        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & tpm_Where
        frm_StoredProcedure.lblTittle.Text = "Procedimiento de Modificacion para la tabla " & txtTable.Text
        frm_StoredProcedure.Show()
    End Sub

    Private Sub LstTables_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstTables.SelectedValueChanged
        Try
            txtTable.Text = lstTables.GetItemText(lstTables.SelectedValue)
            ObtieneColumnas()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim frm_StoredProcedure As New FrmResult

        Dim str_ColumnsName As String = ""
        Dim str_Values As String = ""

        frm_StoredProcedure.txtResult.Text = CreaProcedimientoAlmacenadoModify(str_ColumnsName, str_Values)

        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & ChrW(13) & ChrW(13) & "AS" & ChrW(13) & ChrW(13) & "SET NOCOUNT OFF;" & ChrW(13) & ChrW(13) & "UPDATE [" & txtTable.Text & "]" & ChrW(13) & ChrW(13) & "SET " & str_ColumnsName & ChrW(13) & " WHERE "

        Dim tpm_Where As String = ""
        For i = 0 To tblIdentidades.Rows.Count - 1
            Try
                tpm_Where = tpm_Where & "(" & tblIdentidades.Rows(i)(0) & "=@" & tblIdentidades.Rows(i)(0) & ") AND "
            Catch ex As Exception

            End Try
        Next

        tpm_Where = Mid(tpm_Where, 1, Len(tpm_Where) - 5)
        frm_StoredProcedure.txtResult.Text = frm_StoredProcedure.txtResult.Text & tpm_Where
        frm_StoredProcedure.lblTittle.Text = "Procedimiento de Modificacion para la tabla " & txtTable.Text
        frm_StoredProcedure.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub FrmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



#End Region

End Class

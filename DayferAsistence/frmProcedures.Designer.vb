<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstTables = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.lstColumns = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStoredProcedures = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstTables
        '
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.Location = New System.Drawing.Point(21, 157)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(276, 238)
        Me.lstTables.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Table"
        '
        'txtTable
        '
        Me.txtTable.Location = New System.Drawing.Point(389, 13)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(191, 20)
        Me.txtTable.TabIndex = 12
        Me.txtTable.Text = "2_Adm_Country"
        '
        'lstColumns
        '
        Me.lstColumns.FormattingEnabled = True
        Me.lstColumns.Location = New System.Drawing.Point(352, 40)
        Me.lstColumns.Name = "lstColumns"
        Me.lstColumns.Size = New System.Drawing.Size(321, 329)
        Me.lstColumns.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStoredProcedures
        '
        Me.btnStoredProcedures.Location = New System.Drawing.Point(352, 371)
        Me.btnStoredProcedures.Name = "btnStoredProcedures"
        Me.btnStoredProcedures.Size = New System.Drawing.Size(156, 23)
        Me.btnStoredProcedures.TabIndex = 15
        Me.btnStoredProcedures.Text = "Add Stored Procedures"
        Me.btnStoredProcedures.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(517, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Modify Stored Procedures"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(21, 401)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 17
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Add Stored Procedures"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tables"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tables"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(64, 12)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(233, 20)
        Me.txtDatabase.TabIndex = 20
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 436)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnStoredProcedures)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstColumns)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstTables)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dayfer Asistence 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTables As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTable As TextBox
    Friend WithEvents lstColumns As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnStoredProcedures As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDatabase As TextBox
End Class

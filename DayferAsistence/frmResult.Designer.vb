<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResult
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResult))
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_Tabla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Location = New System.Drawing.Point(13, 13)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(71, 13)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Ttulo General"
        '
        'txtResult
        '
        Me.txtResult.AcceptsReturn = True
        Me.txtResult.Location = New System.Drawing.Point(13, 30)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(613, 304)
        Me.txtResult.TabIndex = 1
        Me.txtResult.Text = resources.GetString("txtResult.Text")
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(13, 340)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'lbl_Tabla
        '
        Me.lbl_Tabla.AutoSize = True
        Me.lbl_Tabla.Location = New System.Drawing.Point(586, 12)
        Me.lbl_Tabla.Name = "lbl_Tabla"
        Me.lbl_Tabla.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Tabla.TabIndex = 3
        Me.lbl_Tabla.Text = "Label1"
        Me.lbl_Tabla.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 370)
        Me.Controls.Add(Me.lbl_Tabla)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblTittle)
        Me.MaximizeBox = False
        Me.Name = "FrmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result of Assitence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_Tabla As Label
End Class

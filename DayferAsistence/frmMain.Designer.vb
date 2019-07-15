<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menPrincipal = New System.Windows.Forms.MenuStrip()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcedimientosAlmacenadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesarrolloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.cmbDatabase = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkIntegrity = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lst_BaseDatos = New System.Windows.Forms.ListBox()
        Me.my_DtsDayferAsistence = New DayferAsistence.dtsDayferAsistence()
        Me.menPrincipal.SuspendLayout()
        CType(Me.my_DtsDayferAsistence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menPrincipal
        '
        Me.menPrincipal.Enabled = False
        Me.menPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem})
        Me.menPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menPrincipal.Name = "menPrincipal"
        Me.menPrincipal.Size = New System.Drawing.Size(800, 24)
        Me.menPrincipal.TabIndex = 0
        Me.menPrincipal.Text = "MenuStrip1"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcedimientosAlmacenadosToolStripMenuItem, Me.DesarrolloToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'ProcedimientosAlmacenadosToolStripMenuItem
        '
        Me.ProcedimientosAlmacenadosToolStripMenuItem.Name = "ProcedimientosAlmacenadosToolStripMenuItem"
        Me.ProcedimientosAlmacenadosToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ProcedimientosAlmacenadosToolStripMenuItem.Text = "Procedimientos Almacenados"
        '
        'DesarrolloToolStripMenuItem
        '
        Me.DesarrolloToolStripMenuItem.Name = "DesarrolloToolStripMenuItem"
        Me.DesarrolloToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.DesarrolloToolStripMenuItem.Text = "Desarrollo"
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(374, 104)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 20
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'cmbDatabase
        '
        Me.cmbDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDatabase.FormattingEnabled = True
        Me.cmbDatabase.Location = New System.Drawing.Point(246, 136)
        Me.cmbDatabase.Name = "cmbDatabase"
        Me.cmbDatabase.Size = New System.Drawing.Size(203, 21)
        Me.cmbDatabase.TabIndex = 18
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(246, 105)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtPassword.TabIndex = 17
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(246, 78)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 16
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(246, 51)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(121, 20)
        Me.txtServer.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Server"
        '
        'chkIntegrity
        '
        Me.chkIntegrity.AutoSize = True
        Me.chkIntegrity.Location = New System.Drawing.Point(374, 54)
        Me.chkIntegrity.Name = "chkIntegrity"
        Me.chkIntegrity.Size = New System.Drawing.Size(115, 17)
        Me.chkIntegrity.TabIndex = 21
        Me.chkIntegrity.Text = "Integrated Security"
        Me.chkIntegrity.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(246, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Dataset XML"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(246, 167)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(203, 20)
        Me.txtDescripcion.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Descripcion"
        '
        'lst_BaseDatos
        '
        Me.lst_BaseDatos.DataSource = Me.my_DtsDayferAsistence
        Me.lst_BaseDatos.DisplayMember = "ConexionStrings.Descripcion"
        Me.lst_BaseDatos.FormattingEnabled = True
        Me.lst_BaseDatos.Location = New System.Drawing.Point(13, 53)
        Me.lst_BaseDatos.Name = "lst_BaseDatos"
        Me.lst_BaseDatos.Size = New System.Drawing.Size(128, 134)
        Me.lst_BaseDatos.TabIndex = 27
        '
        'my_DtsDayferAsistence
        '
        Me.my_DtsDayferAsistence.DataSetName = "dtsDayferAsistence"
        Me.my_DtsDayferAsistence.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lst_BaseDatos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkIntegrity)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.cmbDatabase)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menPrincipal)
        Me.MainMenuStrip = Me.menPrincipal
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menPrincipal.ResumeLayout(False)
        Me.menPrincipal.PerformLayout()
        CType(Me.my_DtsDayferAsistence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menPrincipal As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcedimientosAlmacenadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesarrolloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnValidate As Button
    Friend WithEvents cmbDatabase As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkIntegrity As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lst_BaseDatos As ListBox
    Friend WithEvents my_DtsDayferAsistence As dtsDayferAsistence
End Class

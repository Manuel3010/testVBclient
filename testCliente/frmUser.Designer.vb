<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.dtUser = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtUser
        '
        Me.dtUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.name, Me.age, Me.email})
        Me.dtUser.Location = New System.Drawing.Point(95, 12)
        Me.dtUser.Name = "dtUser"
        Me.dtUser.Size = New System.Drawing.Size(689, 307)
        Me.dtUser.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'name
        '
        Me.name.HeaderText = "Name"
        Me.name.Name = "name"
        '
        'age
        '
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 524)
        Me.Controls.Add(Me.dtUser)
        Me.name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtUser As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class

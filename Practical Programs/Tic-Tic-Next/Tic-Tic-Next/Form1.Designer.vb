<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicTicDBDataSet = New Tic_Tic_Next.TicTicDBDataSet()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtUaddress = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TblStudentTableAdapter = New Tic_Tic_Next.TicTicDBDataSetTableAdapters.tblStudentTableAdapter()
        Me.StuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicTicDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.StuNameDataGridViewTextBoxColumn, Me.StuAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(40, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 190)
        Me.DataGridView1.TabIndex = 0
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        Me.TblStudentBindingSource.DataSource = Me.TicTicDBDataSet
        '
        'TicTicDBDataSet
        '
        Me.TicTicDBDataSet.DataSetName = "TicTicDBDataSet"
        Me.TicTicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(309, 318)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(90, 318)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(90, 249)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(90, 283)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtUaddress
        '
        Me.txtUaddress.Location = New System.Drawing.Point(205, 283)
        Me.txtUaddress.Name = "txtUaddress"
        Me.txtUaddress.Size = New System.Drawing.Size(100, 20)
        Me.txtUaddress.TabIndex = 7
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(205, 249)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(100, 20)
        Me.txtUname.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(205, 318)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'StuIDDataGridViewTextBoxColumn
        '
        Me.StuIDDataGridViewTextBoxColumn.DataPropertyName = "stuID"
        Me.StuIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.StuIDDataGridViewTextBoxColumn.Name = "StuIDDataGridViewTextBoxColumn"
        Me.StuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StuNameDataGridViewTextBoxColumn
        '
        Me.StuNameDataGridViewTextBoxColumn.DataPropertyName = "stuName"
        Me.StuNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.StuNameDataGridViewTextBoxColumn.Name = "StuNameDataGridViewTextBoxColumn"
        '
        'StuAddressDataGridViewTextBoxColumn
        '
        Me.StuAddressDataGridViewTextBoxColumn.DataPropertyName = "stuAddress"
        Me.StuAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.StuAddressDataGridViewTextBoxColumn.Name = "StuAddressDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Address"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUaddress)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataSet - TableAdapter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicTicDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TicTicDBDataSet As Tic_Tic_Next.TicTicDBDataSet
    Friend WithEvents TblStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentTableAdapter As Tic_Tic_Next.TicTicDBDataSetTableAdapters.tblStudentTableAdapter
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtUaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents StuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

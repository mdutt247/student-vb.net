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
        Me.IbsarDbDataSet = New DataGridView.IbsarDbDataSet()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentTableAdapter = New DataGridView.IbsarDbDataSetTableAdapters.tblStudentTableAdapter()
        Me.StuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbsarDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.StuNameDataGridViewTextBoxColumn, Me.StuAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 209)
        Me.DataGridView1.TabIndex = 0
        '
        'IbsarDbDataSet
        '
        Me.IbsarDbDataSet.DataSetName = "IbsarDbDataSet"
        Me.IbsarDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        Me.TblStudentBindingSource.DataSource = Me.IbsarDbDataSet
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'StuIDDataGridViewTextBoxColumn
        '
        Me.StuIDDataGridViewTextBoxColumn.DataPropertyName = "stuID"
        Me.StuIDDataGridViewTextBoxColumn.HeaderText = "stuID"
        Me.StuIDDataGridViewTextBoxColumn.Name = "StuIDDataGridViewTextBoxColumn"
        Me.StuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StuNameDataGridViewTextBoxColumn
        '
        Me.StuNameDataGridViewTextBoxColumn.DataPropertyName = "stuName"
        Me.StuNameDataGridViewTextBoxColumn.HeaderText = "stuName"
        Me.StuNameDataGridViewTextBoxColumn.Name = "StuNameDataGridViewTextBoxColumn"
        '
        'StuAddressDataGridViewTextBoxColumn
        '
        Me.StuAddressDataGridViewTextBoxColumn.DataPropertyName = "stuAddress"
        Me.StuAddressDataGridViewTextBoxColumn.HeaderText = "stuAddress"
        Me.StuAddressDataGridViewTextBoxColumn.Name = "StuAddressDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbsarDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IbsarDbDataSet As DataGridView.IbsarDbDataSet
    Friend WithEvents TblStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentTableAdapter As DataGridView.IbsarDbDataSetTableAdapters.tblStudentTableAdapter
    Friend WithEvents StuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allocation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblStaffAllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group6DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group6DataSet = New Yes_Please_.group6DataSet()
        Me.TblStaff_AllocationTableAdapter = New Yes_Please_.group6DataSetTableAdapters.tblStaff_AllocationTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffAllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group6DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Allocation For The Week"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Yes_Please_.My.Resources.Resources.Yes_Please_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(466, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Yes_Please_.My.Resources.Resources.Capture
        Me.PictureBox2.Location = New System.Drawing.Point(710, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpnoDataGridViewTextBoxColumn, Me.ShiftDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblStaffAllocationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(114, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(542, 482)
        Me.DataGridView1.TabIndex = 3
        '
        'TblStaffAllocationBindingSource
        '
        Me.TblStaffAllocationBindingSource.DataMember = "tblStaff_Allocation"
        Me.TblStaffAllocationBindingSource.DataSource = Me.Group6DataSetBindingSource
        '
        'EmpnoDataGridViewTextBoxColumn
        '
        Me.EmpnoDataGridViewTextBoxColumn.DataPropertyName = "emp_no"
        Me.EmpnoDataGridViewTextBoxColumn.HeaderText = "emp_no"
        Me.EmpnoDataGridViewTextBoxColumn.Name = "EmpnoDataGridViewTextBoxColumn"
        Me.EmpnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShiftDataGridViewTextBoxColumn
        '
        Me.ShiftDataGridViewTextBoxColumn.DataPropertyName = "shift"
        Me.ShiftDataGridViewTextBoxColumn.HeaderText = "shift"
        Me.ShiftDataGridViewTextBoxColumn.Name = "ShiftDataGridViewTextBoxColumn"
        Me.ShiftDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "start time"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "start time"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        Me.DurationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Group6DataSetBindingSource
        '
        Me.Group6DataSetBindingSource.DataSource = Me.Group6DataSet
        Me.Group6DataSetBindingSource.Position = 0
        '
        'Group6DataSet
        '
        Me.Group6DataSet.DataSetName = "group6DataSet"
        Me.Group6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStaff_AllocationTableAdapter
        '
        Me.TblStaff_AllocationTableAdapter.ClearBeforeFill = True
        '
        'Allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Background_image1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 658)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Allocation"
        Me.Text = "Allocation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffAllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group6DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Group6DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Group6DataSet As Yes_Please_.group6DataSet
    Friend WithEvents TblStaffAllocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaff_AllocationTableAdapter As Yes_Please_.group6DataSetTableAdapters.tblStaff_AllocationTableAdapter
    Friend WithEvents EmpnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShiftDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

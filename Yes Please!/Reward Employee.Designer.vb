<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reward_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reward_Employee))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Group6DataSet = New Yes_Please_.group6DataSet()
        Me.WAITERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERTableAdapter = New Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter()
        Me.WAITERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKORDERWAITERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERTableAdapter = New Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaiternameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitersurenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaiterphonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofordersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nooforders1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKORDERWAITERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(489, 414)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(184, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reward An Employee"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(481, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 73)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Group6DataSet
        '
        Me.Group6DataSet.DataSetName = "group6DataSet"
        Me.Group6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WAITERBindingSource
        '
        Me.WAITERBindingSource.DataMember = "WAITER"
        Me.WAITERBindingSource.DataSource = Me.Group6DataSet
        '
        'WAITERTableAdapter
        '
        Me.WAITERTableAdapter.ClearBeforeFill = True
        '
        'WAITERBindingSource2
        '
        Me.WAITERBindingSource2.DataMember = "WAITER"
        Me.WAITERBindingSource2.DataSource = Me.Group6DataSet
        '
        'WAITERBindingSource1
        '
        Me.WAITERBindingSource1.DataMember = "WAITER"
        Me.WAITERBindingSource1.DataSource = Me.Group6DataSet
        '
        'FKORDERWAITERBindingSource
        '
        Me.FKORDERWAITERBindingSource.DataMember = "FK_ORDER_WAITER"
        Me.FKORDERWAITERBindingSource.DataSource = Me.WAITERBindingSource1
        '
        'ORDERTableAdapter
        '
        Me.ORDERTableAdapter.ClearBeforeFill = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Capture
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(724, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpnoDataGridViewTextBoxColumn, Me.WaiternameDataGridViewTextBoxColumn, Me.WaitersurenameDataGridViewTextBoxColumn, Me.WaiterphonenoDataGridViewTextBoxColumn, Me.NoofordersDataGridViewTextBoxColumn, Me.Nooforders1DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WAITERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(104, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 178)
        Me.DataGridView1.TabIndex = 13
        '
        'EmpnoDataGridViewTextBoxColumn
        '
        Me.EmpnoDataGridViewTextBoxColumn.DataPropertyName = "emp_no"
        Me.EmpnoDataGridViewTextBoxColumn.HeaderText = "emp_no"
        Me.EmpnoDataGridViewTextBoxColumn.Name = "EmpnoDataGridViewTextBoxColumn"
        Me.EmpnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WaiternameDataGridViewTextBoxColumn
        '
        Me.WaiternameDataGridViewTextBoxColumn.DataPropertyName = "waiter_name"
        Me.WaiternameDataGridViewTextBoxColumn.HeaderText = "waiter_name"
        Me.WaiternameDataGridViewTextBoxColumn.Name = "WaiternameDataGridViewTextBoxColumn"
        '
        'WaitersurenameDataGridViewTextBoxColumn
        '
        Me.WaitersurenameDataGridViewTextBoxColumn.DataPropertyName = "waiter_surename"
        Me.WaitersurenameDataGridViewTextBoxColumn.HeaderText = "waiter_surename"
        Me.WaitersurenameDataGridViewTextBoxColumn.Name = "WaitersurenameDataGridViewTextBoxColumn"
        '
        'WaiterphonenoDataGridViewTextBoxColumn
        '
        Me.WaiterphonenoDataGridViewTextBoxColumn.DataPropertyName = "waiter_phone_no"
        Me.WaiterphonenoDataGridViewTextBoxColumn.HeaderText = "waiter_phone_no"
        Me.WaiterphonenoDataGridViewTextBoxColumn.Name = "WaiterphonenoDataGridViewTextBoxColumn"
        '
        'NoofordersDataGridViewTextBoxColumn
        '
        Me.NoofordersDataGridViewTextBoxColumn.DataPropertyName = "no_of_orders"
        Me.NoofordersDataGridViewTextBoxColumn.HeaderText = "no_of_orders"
        Me.NoofordersDataGridViewTextBoxColumn.Name = "NoofordersDataGridViewTextBoxColumn"
        Me.NoofordersDataGridViewTextBoxColumn.Visible = False
        '
        'Nooforders1DataGridViewTextBoxColumn
        '
        Me.Nooforders1DataGridViewTextBoxColumn.DataPropertyName = "no_of_orders1"
        Me.Nooforders1DataGridViewTextBoxColumn.HeaderText = "no_of_orders1"
        Me.Nooforders1DataGridViewTextBoxColumn.Name = "Nooforders1DataGridViewTextBoxColumn"
        '
        'Reward_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(783, 500)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reward_Employee"
        Me.Text = "Reward Employee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKORDERWAITERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Group6DataSet As Yes_Please_.group6DataSet
    Friend WithEvents WAITERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERTableAdapter As Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter
    Friend WithEvents WAITERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FKORDERWAITERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDERTableAdapter As Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents WAITERBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmpnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaiternameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitersurenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaiterphonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoofordersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nooforders1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

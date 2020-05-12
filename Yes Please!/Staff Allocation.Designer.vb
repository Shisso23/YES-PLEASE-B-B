<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Allocation
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
        Me.myds = New Yes_Please_.group6DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.WAITERTableAdapter = New Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter()
        Me.MessagesDataSet1 = New Yes_Please_.messagesDataSet1()
        Me.DisplayEmployeesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DisplayEmployeesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ORDERTableAdapter = New Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter()
        Me.Group6DataSet = New Yes_Please_.group6DataSet()
        Me.WAITERBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKORDERWAITERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKORDERWAITERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKORDERWAITERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WAITERBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MessagesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisplayEmployeesToolStrip.SuspendLayout()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKORDERWAITERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKORDERWAITERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKORDERWAITERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WAITERBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Allocation"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Yes_Please_.My.Resources.Resources.Yes_Please_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(407, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'myds
        '
        Me.myds.DataSetName = "group6DataSet"
        Me.myds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Staff Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Yes_Please_.My.Resources.Resources.Capture
        Me.PictureBox2.Location = New System.Drawing.Point(643, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(400, 272)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(30, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(129, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Normal Shift"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(30, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(161, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Reservation Shift"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(415, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shift"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(55, 389)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(210, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'WAITERTableAdapter
        '
        Me.WAITERTableAdapter.ClearBeforeFill = True
        '
        'MessagesDataSet1
        '
        Me.MessagesDataSet1.DataSetName = "messagesDataSet1"
        Me.MessagesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DisplayEmployeesToolStrip
        '
        Me.DisplayEmployeesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayEmployeesToolStripButton})
        Me.DisplayEmployeesToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DisplayEmployeesToolStrip.Name = "DisplayEmployeesToolStrip"
        Me.DisplayEmployeesToolStrip.Size = New System.Drawing.Size(706, 25)
        Me.DisplayEmployeesToolStrip.TabIndex = 9
        Me.DisplayEmployeesToolStrip.Text = "DisplayEmployeesToolStrip"
        '
        'DisplayEmployeesToolStripButton
        '
        Me.DisplayEmployeesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DisplayEmployeesToolStripButton.Name = "DisplayEmployeesToolStripButton"
        Me.DisplayEmployeesToolStripButton.Size = New System.Drawing.Size(105, 22)
        Me.DisplayEmployeesToolStripButton.Text = "displayEmployees"
        '
        'ORDERTableAdapter
        '
        Me.ORDERTableAdapter.ClearBeforeFill = True
        '
        'Group6DataSet
        '
        Me.Group6DataSet.DataSetName = "group6DataSet"
        Me.Group6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WAITERBindingSource7
        '
        Me.WAITERBindingSource7.DataMember = "WAITER"
        Me.WAITERBindingSource7.DataSource = Me.myds
        '
        'WAITERBindingSource6
        '
        Me.WAITERBindingSource6.DataSource = Me.myds
        Me.WAITERBindingSource6.Position = 0
        '
        'WAITERBindingSource
        '
        Me.WAITERBindingSource.DataSource = Me.myds
        Me.WAITERBindingSource.Position = 0
        '
        'WAITERBindingSource1
        '
        Me.WAITERBindingSource1.DataSource = Me.myds
        Me.WAITERBindingSource1.Position = 0
        '
        'WAITERBindingSource2
        '
        Me.WAITERBindingSource2.DataSource = Me.myds
        Me.WAITERBindingSource2.Position = 0
        '
        'WAITERBindingSource3
        '
        Me.WAITERBindingSource3.DataSource = Me.WAITERBindingSource
        Me.WAITERBindingSource3.Position = 0
        '
        'FKORDERWAITERBindingSource
        '
        Me.FKORDERWAITERBindingSource.DataMember = "FK_ORDER_WAITER"
        Me.FKORDERWAITERBindingSource.DataSource = Me.WAITERBindingSource3
        '
        'FKORDERWAITERBindingSource1
        '
        Me.FKORDERWAITERBindingSource1.DataMember = "FK_ORDER_WAITER"
        Me.FKORDERWAITERBindingSource1.DataSource = Me.WAITERBindingSource3
        '
        'FKORDERWAITERBindingSource2
        '
        Me.FKORDERWAITERBindingSource2.DataMember = "FK_ORDER_WAITER"
        Me.FKORDERWAITERBindingSource2.DataSource = Me.WAITERBindingSource3
        '
        'WAITERBindingSource4
        '
        Me.WAITERBindingSource4.DataSource = Me.myds
        Me.WAITERBindingSource4.Position = 0
        '
        'WAITERBindingSource5
        '
        Me.WAITERBindingSource5.DataSource = Me.myds
        Me.WAITERBindingSource5.Position = 0
        '
        'Staff_Allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Background_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 511)
        Me.Controls.Add(Me.DisplayEmployeesToolStrip)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Staff_Allocation"
        Me.Text = "0"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MessagesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisplayEmployeesToolStrip.ResumeLayout(False)
        Me.DisplayEmployeesToolStrip.PerformLayout()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKORDERWAITERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKORDERWAITERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKORDERWAITERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WAITERBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents myds As Yes_Please_.group6DataSet
    Friend WithEvents WAITERTableAdapter As Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter
    Friend WithEvents MessagesDataSet1 As Yes_Please_.messagesDataSet1
    Friend WithEvents DisplayEmployeesToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DisplayEmployeesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ORDERTableAdapter As Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents WAITERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Group6DataSet As Yes_Please_.group6DataSet
    Friend WithEvents WAITERBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents FKORDERWAITERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKORDERWAITERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FKORDERWAITERBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents EmpnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaiternameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitersurenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaiterphonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoofordersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WAITERBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents WAITERBindingSource7 As System.Windows.Forms.BindingSource
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Group6DataSet1 = New Yes_Please_.group6DataSet()
        Me.UserTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.USERTableAdapter()
        Me.CustomerTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.CUSTOMERTableAdapter()
        Me.ManagerTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.MANAGERTableAdapter()
        Me.MenU_ITEMTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.MENU_ITEMTableAdapter()
        Me.OrdeR_ITEMTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.ORDER_ITEMTableAdapter()
        Me.OrderTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter()
        Me.ReservationTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.RESERVATIONTableAdapter()
        Me.WaiterTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter()
        CType(Me.Group6DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1043, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 31)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(918, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 31)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(963, 408)
        Me.password.MaxLength = 10
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(196, 21)
        Me.password.TabIndex = 15
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(963, 345)
        Me.username.MaxLength = 10
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(196, 21)
        Me.username.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(864, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(864, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Username:"
        '
        'Group6DataSet1
        '
        Me.Group6DataSet1.DataSetName = "group6DataSet"
        Me.Group6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableAdapter1
        '
        Me.UserTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'ManagerTableAdapter1
        '
        Me.ManagerTableAdapter1.ClearBeforeFill = True
        '
        'MenU_ITEMTableAdapter1
        '
        Me.MenU_ITEMTableAdapter1.ClearBeforeFill = True
        '
        'OrdeR_ITEMTableAdapter1
        '
        Me.OrdeR_ITEMTableAdapter1.ClearBeforeFill = True
        '
        'OrderTableAdapter1
        '
        Me.OrderTableAdapter1.ClearBeforeFill = True
        '
        'ReservationTableAdapter1
        '
        Me.ReservationTableAdapter1.ClearBeforeFill = True
        '
        'WaiterTableAdapter1
        '
        Me.WaiterTableAdapter1.ClearBeforeFill = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1185, 652)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "login"
        Me.Text = "Log In"
        CType(Me.Group6DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Group6DataSet1 As Yes_Please_.group6DataSet
    Friend WithEvents UserTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.USERTableAdapter
    Friend WithEvents CustomerTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents ManagerTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.MANAGERTableAdapter
    Friend WithEvents MenU_ITEMTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.MENU_ITEMTableAdapter
    Friend WithEvents OrdeR_ITEMTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.ORDER_ITEMTableAdapter
    Friend WithEvents OrderTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents ReservationTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.RESERVATIONTableAdapter
    Friend WithEvents WaiterTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.WAITERTableAdapter

End Class

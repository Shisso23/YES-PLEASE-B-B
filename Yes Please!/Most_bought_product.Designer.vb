﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Most_bought_product
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.crystalReport51 = New Yes_Please_.CrystalReport5()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group6DataSet = New Yes_Please_.group6DataSet()
        Me.MenU_ITEMTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.MENU_ITEMTableAdapter()
        Me.OrdeR_ITEMTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.ORDER_ITEMTableAdapter()
        Me.OrderTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter()
        Me.TableAdapterManager = New Yes_Please_.group6DataSetTableAdapters.TableAdapterManager()
        Me.MostBoughtItemTableAdapter1 = New Yes_Please_.group6DataSetTableAdapters.MostBoughtItemTableAdapter()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Capture
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(1154, 22)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Yes_Please_LOGO
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(842, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(291, 64)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 82)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.crystalReport51
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1201, 862)
        Me.CrystalReportViewer1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(789, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Details of all ordered items with their quantity indicating the most bought item"
        '
        'Group6DataSet
        '
        Me.Group6DataSet.DataSetName = "group6DataSet"
        Me.Group6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.MANAGERTableAdapter = Nothing
        Me.TableAdapterManager.MENU_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.MostBoughtItemTableAdapter = Nothing
        Me.TableAdapterManager.ORDER_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.RESERVATIONTableAdapter = Nothing
        ' Me.TableAdapterManager.tblStaff_AllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Yes_Please_.group6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'MostBoughtItemTableAdapter1
        '
        Me.MostBoughtItemTableAdapter1.ClearBeforeFill = True
        '
        'Most_bought_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.Yes_Please_.My.Resources.Resources.Background_image1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1268, 989)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Most_bought_product"
        Me.Text = "Most_bought_product"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group6DataSet As Yes_Please_.group6DataSet
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenU_ITEMTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.MENU_ITEMTableAdapter
    Friend WithEvents OrdeR_ITEMTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.ORDER_ITEMTableAdapter
    Friend WithEvents OrderTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents TableAdapterManager As Yes_Please_.group6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MostBoughtItemTableAdapter1 As Yes_Please_.group6DataSetTableAdapters.MostBoughtItemTableAdapter
    Friend WithEvents crystalReport51 As Yes_Please_.CrystalReport5
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseAccess
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindAndViewASingleRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SupplyOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSC208SuppliesDatabaseDataSet = New Vblab10.CSC208SuppliesDatabaseDataSet()
        Me.SupplyOrdersTableAdapter = New Vblab10.CSC208SuppliesDatabaseDataSetTableAdapters.SupplyOrdersTableAdapter()
        Me.TableAdapterManager = New Vblab10.CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSC208SuppliesDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(401, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllRecordsToolStripMenuItem, Me.FindAndViewASingleRecordToolStripMenuItem, Me.AddNewRecordToolStripMenuItem, Me.TotalAmountToolStripMenuItem})
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MainMenuToolStripMenuItem.Text = "Main menu"
        '
        'ViewAllRecordsToolStripMenuItem
        '
        Me.ViewAllRecordsToolStripMenuItem.Name = "ViewAllRecordsToolStripMenuItem"
        Me.ViewAllRecordsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ViewAllRecordsToolStripMenuItem.Text = "View all records"
        '
        'FindAndViewASingleRecordToolStripMenuItem
        '
        Me.FindAndViewASingleRecordToolStripMenuItem.Name = "FindAndViewASingleRecordToolStripMenuItem"
        Me.FindAndViewASingleRecordToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.FindAndViewASingleRecordToolStripMenuItem.Text = "Find and view a single record "
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AddNewRecordToolStripMenuItem.Text = "Add new record"
        '
        'TotalAmountToolStripMenuItem
        '
        Me.TotalAmountToolStripMenuItem.Name = "TotalAmountToolStripMenuItem"
        Me.TotalAmountToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.TotalAmountToolStripMenuItem.Text = "Total Amount"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vblab10.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC 208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab 10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Amount:"
        '
        'SupplyOrdersBindingSource
        '
        Me.SupplyOrdersBindingSource.DataMember = "SupplyOrders"
        Me.SupplyOrdersBindingSource.DataSource = Me.CSC208SuppliesDatabaseDataSet
        '
        'CSC208SuppliesDatabaseDataSet
        '
        Me.CSC208SuppliesDatabaseDataSet.DataSetName = "CSC208SuppliesDatabaseDataSet"
        Me.CSC208SuppliesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplyOrdersTableAdapter
        '
        Me.SupplyOrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SupplyOrdersTableAdapter = Me.SupplyOrdersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Vblab10.CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(150, 345)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(67, 26)
        Me.lblTotal.TabIndex = 4
        '
        'DatabaseAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 395)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DatabaseAccess"
        Me.Text = "Database Access"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSC208SuppliesDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindAndViewASingleRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CSC208SuppliesDatabaseDataSet As CSC208SuppliesDatabaseDataSet
    Friend WithEvents SupplyOrdersBindingSource As BindingSource
    Friend WithEvents SupplyOrdersTableAdapter As CSC208SuppliesDatabaseDataSetTableAdapters.SupplyOrdersTableAdapter
    Friend WithEvents TableAdapterManager As CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblTotal As Label
End Class

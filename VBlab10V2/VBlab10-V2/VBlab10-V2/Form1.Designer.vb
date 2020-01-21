<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindARecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddARecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSC208SuppliesDatabaseDataSet = New VBlab10_V2.CSC208SuppliesDatabaseDataSet()
        Me.SupplyOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplyOrdersTableAdapter = New VBlab10_V2.CSC208SuppliesDatabaseDataSetTableAdapters.SupplyOrdersTableAdapter()
        Me.TableAdapterManager = New VBlab10_V2.CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CSC208SuppliesDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllRecordsToolStripMenuItem, Me.FindARecordToolStripMenuItem, Me.AddARecordToolStripMenuItem, Me.TotalToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'ViewAllRecordsToolStripMenuItem
        '
        Me.ViewAllRecordsToolStripMenuItem.Name = "ViewAllRecordsToolStripMenuItem"
        Me.ViewAllRecordsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ViewAllRecordsToolStripMenuItem.Text = "View all records "
        '
        'FindARecordToolStripMenuItem
        '
        Me.FindARecordToolStripMenuItem.Name = "FindARecordToolStripMenuItem"
        Me.FindARecordToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.FindARecordToolStripMenuItem.Text = "Find a record "
        '
        'AddARecordToolStripMenuItem
        '
        Me.AddARecordToolStripMenuItem.Name = "AddARecordToolStripMenuItem"
        Me.AddARecordToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AddARecordToolStripMenuItem.Text = "Add a record "
        '
        'TotalToolStripMenuItem
        '
        Me.TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        Me.TotalToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TotalToolStripMenuItem.Text = "Total"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "Save and Exit"
        '
        'CSC208SuppliesDatabaseDataSet
        '
        Me.CSC208SuppliesDatabaseDataSet.DataSetName = "CSC208SuppliesDatabaseDataSet"
        Me.CSC208SuppliesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplyOrdersBindingSource
        '
        Me.SupplyOrdersBindingSource.DataMember = "SupplyOrders"
        Me.SupplyOrdersBindingSource.DataSource = Me.CSC208SuppliesDatabaseDataSet
        '
        'SupplyOrdersTableAdapter
        '
        Me.SupplyOrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SupplyOrdersTableAdapter = Me.SupplyOrdersTableAdapter
        Me.TableAdapterManager.UpdateOrder = VBlab10_V2.CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBlab10_V2.My.Resources.Resources.Image
        Me.PictureBox1.Location = New System.Drawing.Point(13, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(628, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(191, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database Access"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(556, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 41)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Donark Patel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSC-208-58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vblab - 10 "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 364)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "DatabaseAccess"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CSC208SuppliesDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindARecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddARecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSC208SuppliesDatabaseDataSet As CSC208SuppliesDatabaseDataSet
    Friend WithEvents SupplyOrdersBindingSource As BindingSource
    Friend WithEvents SupplyOrdersTableAdapter As CSC208SuppliesDatabaseDataSetTableAdapters.SupplyOrdersTableAdapter
    Friend WithEvents TableAdapterManager As CSC208SuppliesDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class

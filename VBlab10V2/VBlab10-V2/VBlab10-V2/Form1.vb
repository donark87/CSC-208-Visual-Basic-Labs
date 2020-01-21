'Donark patel 
'CSC-208-58
'VBLab - 10
'Date - 4/24/2018
'With this application you can add/delet/find the data through Microsoft excess file. 
'Form - Main form
Public Class Form1
    Private Sub ViewAllRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllRecordsToolStripMenuItem.Click
        Dim frmViewAllRecords As New ViewAllRecord
        frmViewAllRecords.ShowDialog()
    End Sub

    Private Sub FindARecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindARecordToolStripMenuItem.Click
        Dim frmFind As New FindARecord
        frmFind.ShowDialog()
    End Sub

    Private Sub AddARecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddARecordToolStripMenuItem.Click
        Dim frmAddRecord As New AddARecord
        frmAddRecord.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Validate()
        Me.SupplyOrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CSC208SuppliesDatabaseDataSet)
        Me.Close()
    End Sub

    Private Sub SupplyOrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Me.Validate()
        Me.SupplyOrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CSC208SuppliesDatabaseDataSet)

    End Sub

    Private Sub TotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalToolStripMenuItem.Click
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Dim decTotal As Decimal = 0
        Dim row As CSC208SuppliesDatabaseDataSet.SupplyOrdersRow
        For Each row In Me.CSC208SuppliesDatabaseDataSet.SupplyOrders.Rows
            decTotal += row.Subtotal
        Next
        MessageBox.Show("Total Amount: " & decTotal)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
    End Sub
End Class

Public Class ViewAllRecord
    Private Sub ViewAllRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC208SuppliesDatabaseDataSet.SupplyOrders' table. You can move, or remove it, as needed.
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.SupplyOrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CSC208SuppliesDatabaseDataSet)
    End Sub
End Class
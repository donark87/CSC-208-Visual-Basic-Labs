Public Class DatabaseAccess
    Private Sub ViewAllRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllRecordsToolStripMenuItem.Click
        Dim frmViewAllRecords As New ViewAllRecord
        frmViewAllRecords.ShowDialog()
    End Sub

    Private Sub FindAndViewASingleRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindAndViewASingleRecordToolStripMenuItem.Click
        Dim frmFind As New Find
        frmFind.ShowDialog()
    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        Dim frmAddRecord As New Add
        Add.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TotalAmountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalAmountToolStripMenuItem.Click
        'Dim row As CSC208SuppliesDatabaseDataSet.SupplyOrdersRow
        'Dim decTotal As Decimal
        'For Each row In Me.CSC208SuppliesDatabaseDataSet.SupplyOrders.Rows
        '    decTotal += row.Subtotal
        'Next
        'lblTotal.Text = FormatCurrency(decTotal)



    End Sub

    Private Sub DatabaseAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC208SuppliesDatabaseDataSet.SupplyOrders' table. You can move, or remove it, as needed.
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupplyOrdersTableAdapter.FillBy1(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.SupplyOrdersTableAdapter.FillBy1(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.SupplyOrdersTableAdapter.FillBy1(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class

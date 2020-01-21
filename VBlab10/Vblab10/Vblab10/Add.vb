Public Class Add
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC208SuppliesDatabaseDataSet.SupplyOrders' table. You can move, or remove it, as needed.
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)

    End Sub

    Private Sub SaveToolStripButton_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim intSum As Integer
        Dim intQuantity As Integer
        Dim decPrice As Decimal

        intQuantity = CInt(txtQuantity.Text)
        decPrice = CDec(txtPrice.Text)
        intSum = intQuantity * decPrice
        txtSubtotal.Text = intSum

        Me.Validate()
        Me.SupplyOrdersBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CSC208SuppliesDatabaseDataSet)
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupplyOrdersTableAdapter.FillBy1(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class
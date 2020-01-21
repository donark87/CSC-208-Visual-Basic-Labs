'Donark patel 
'CSC-208-58
'VBLab - 10
'Date - 4/24/2018
'With this application you can add/delet/find the data through Microsoft excess file. 
'Form - Add new record.
Public Class AddARecord
    Private Sub AddARecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC208SuppliesDatabaseDataSet.SupplyOrders' table. You can move, or remove it, as needed.
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SupplyOrdersBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim decSubtotal As Decimal
        Dim intQuantity As Integer
        Dim decPrice As Decimal

        intQuantity = CInt(TextBox3.Text)
        decPrice = CDec(TextBox4.Text)
        decSubtotal = intQuantity * decPrice
        txtSubtotal.Text = decSubtotal
        Try
            SupplyOrdersBindingSource.EndEdit()
            SupplyOrdersTableAdapter.Update(CSC208SuppliesDatabaseDataSet.SupplyOrders)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        SupplyOrdersBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
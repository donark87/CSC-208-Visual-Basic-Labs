'Donark patel 
'CSC-208-58
'VBLab - 10
'Date - 4/24/2018
'With this application you can add/delet/find the data through Microsoft excess file. 
'Form - View all records 
Public Class ViewAllRecord
    Private Sub ViewAllRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC208SuppliesDatabaseDataSet.SupplyOrders' table. You can move, or remove it, as needed.
        Me.SupplyOrdersTableAdapter.Fill(Me.CSC208SuppliesDatabaseDataSet.SupplyOrders)

    End Sub
End Class
Public Class Purchases


    Private Sub Purchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ledger

    End Sub

    Private Sub load_ledger()
        Try

            Dim d As New DAOCLASS
            Dim ds As New DataSet
            ds = d.load_dataset("select distinct(Product_Name) from Product_Master")
            ComboBox1.DisplayMember = "Product_Name"

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Function ds() As DataSet
        Throw New NotImplementedException()
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            If ComboBox1.Text <> "" Then
                Dim d As New DAOCLASS
                Dim ds As New DataSet
                ds = d.load_dataset("select Product_Name from Product_Master")
                ComboBox1.DisplayMember = "Product_Name"

    End Sub
End Class
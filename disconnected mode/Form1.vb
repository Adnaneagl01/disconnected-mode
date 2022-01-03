Imports System.Data.SqlClient
Public Class Form1
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim cmdb As SqlCommandBuilder
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da = New SqlDataAdapter("SELECT * FROM produit", cnx)
        da.Fill(ds, "produit")
        dgvproduit.DataSource = ds.Tables("produit")
    End Sub

    Private Sub dgvproduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduit.CellContentClick

    End Sub
End Class

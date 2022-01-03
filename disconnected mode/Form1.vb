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
    Public Function champ_remplit()
        Return txtref.Text <> "" And txtqstock.Text <> "" And txtprixu.Text <> "" And txtdesg.Text <> ""

    End Function


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cmdb = New SqlCommandBuilder(da)
        da.Update(ds, "produit")
        MsgBox("mise a jour effectuee")
    End Sub
End Class

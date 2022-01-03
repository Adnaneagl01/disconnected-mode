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

    Public Function index(s As String)
        Dim i As Integer = 0
        While i < ds.Tables(0).Rows.Count
            If ds.Tables(0).Rows(i)(0) = s Then
                Return i
            End If

        End While
        Return -1

    End Function
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cmdb = New SqlCommandBuilder(da)
        da.Update(ds, "produit")
        MsgBox("mise a jour effectuee")
    End Sub
End Class

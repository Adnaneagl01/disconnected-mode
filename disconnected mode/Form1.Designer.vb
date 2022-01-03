<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.brnprec = New System.Windows.Forms.Button()
        Me.btndebut = New System.Windows.Forms.Button()
        Me.btnsuivant = New System.Windows.Forms.Button()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.btnnouveau = New System.Windows.Forms.Button()
        Me.btnmodifier = New System.Windows.Forms.Button()
        Me.btnsup = New System.Windows.Forms.Button()
        Me.btnajouter = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnauitter = New System.Windows.Forms.Button()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.txtdesg = New System.Windows.Forms.TextBox()
        Me.txtqstock = New System.Windows.Forms.TextBox()
        Me.txtprixu = New System.Windows.Forms.TextBox()
        Me.dgvproduit = New System.Windows.Forms.DataGridView()
        CType(Me.dgvproduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bl
        '
        Me.bl.AutoSize = True
        Me.bl.Location = New System.Drawing.Point(66, 69)
        Me.bl.Name = "bl"
        Me.bl.Size = New System.Drawing.Size(57, 13)
        Me.bl.TabIndex = 0
        Me.bl.Text = "Reference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "qte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "prix unite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Gestion Commercial de produits"
        '
        'brnprec
        '
        Me.brnprec.Location = New System.Drawing.Point(150, 221)
        Me.brnprec.Name = "brnprec"
        Me.brnprec.Size = New System.Drawing.Size(75, 23)
        Me.brnprec.TabIndex = 1
        Me.brnprec.Text = "Precedent"
        Me.brnprec.UseVisualStyleBackColor = True
        '
        'btndebut
        '
        Me.btndebut.Location = New System.Drawing.Point(69, 221)
        Me.btndebut.Name = "btndebut"
        Me.btndebut.Size = New System.Drawing.Size(75, 23)
        Me.btndebut.TabIndex = 1
        Me.btndebut.Text = "Debut"
        Me.btndebut.UseVisualStyleBackColor = True
        '
        'btnsuivant
        '
        Me.btnsuivant.Location = New System.Drawing.Point(387, 221)
        Me.btnsuivant.Name = "btnsuivant"
        Me.btnsuivant.Size = New System.Drawing.Size(75, 23)
        Me.btnsuivant.TabIndex = 1
        Me.btnsuivant.Text = "Suivant"
        Me.btnsuivant.UseVisualStyleBackColor = True
        '
        'btnfin
        '
        Me.btnfin.Location = New System.Drawing.Point(468, 221)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(75, 23)
        Me.btnfin.TabIndex = 1
        Me.btnfin.Text = "Fin"
        Me.btnfin.UseVisualStyleBackColor = True
        '
        'btnnouveau
        '
        Me.btnnouveau.Location = New System.Drawing.Point(601, 47)
        Me.btnnouveau.Name = "btnnouveau"
        Me.btnnouveau.Size = New System.Drawing.Size(75, 23)
        Me.btnnouveau.TabIndex = 1
        Me.btnnouveau.Text = "Nouveau"
        Me.btnnouveau.UseVisualStyleBackColor = True
        '
        'btnmodifier
        '
        Me.btnmodifier.Location = New System.Drawing.Point(601, 105)
        Me.btnmodifier.Name = "btnmodifier"
        Me.btnmodifier.Size = New System.Drawing.Size(75, 23)
        Me.btnmodifier.TabIndex = 1
        Me.btnmodifier.Text = "modifier"
        Me.btnmodifier.UseVisualStyleBackColor = True
        '
        'btnsup
        '
        Me.btnsup.Location = New System.Drawing.Point(601, 134)
        Me.btnsup.Name = "btnsup"
        Me.btnsup.Size = New System.Drawing.Size(75, 23)
        Me.btnsup.TabIndex = 1
        Me.btnsup.Text = "supprimer"
        Me.btnsup.UseVisualStyleBackColor = True
        '
        'btnajouter
        '
        Me.btnajouter.Location = New System.Drawing.Point(601, 76)
        Me.btnajouter.Name = "btnajouter"
        Me.btnajouter.Size = New System.Drawing.Size(75, 23)
        Me.btnajouter.TabIndex = 1
        Me.btnajouter.Text = "ajouter"
        Me.btnajouter.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(682, 47)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 110)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnauitter
        '
        Me.btnauitter.Location = New System.Drawing.Point(361, 459)
        Me.btnauitter.Name = "btnauitter"
        Me.btnauitter.Size = New System.Drawing.Size(75, 23)
        Me.btnauitter.TabIndex = 1
        Me.btnauitter.Text = "Quitter"
        Me.btnauitter.UseVisualStyleBackColor = True
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(150, 61)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(100, 20)
        Me.txtref.TabIndex = 2
        '
        'txtdesg
        '
        Me.txtdesg.Location = New System.Drawing.Point(150, 110)
        Me.txtdesg.Name = "txtdesg"
        Me.txtdesg.Size = New System.Drawing.Size(100, 20)
        Me.txtdesg.TabIndex = 2
        '
        'txtqstock
        '
        Me.txtqstock.Location = New System.Drawing.Point(150, 147)
        Me.txtqstock.Name = "txtqstock"
        Me.txtqstock.Size = New System.Drawing.Size(100, 20)
        Me.txtqstock.TabIndex = 2
        '
        'txtprixu
        '
        Me.txtprixu.Location = New System.Drawing.Point(443, 103)
        Me.txtprixu.Name = "txtprixu"
        Me.txtprixu.Size = New System.Drawing.Size(100, 20)
        Me.txtprixu.TabIndex = 2
        '
        'dgvproduit
        '
        Me.dgvproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduit.Location = New System.Drawing.Point(69, 250)
        Me.dgvproduit.Name = "dgvproduit"
        Me.dgvproduit.Size = New System.Drawing.Size(688, 203)
        Me.dgvproduit.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.dgvproduit)
        Me.Controls.Add(Me.txtprixu)
        Me.Controls.Add(Me.txtqstock)
        Me.Controls.Add(Me.txtdesg)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.btndebut)
        Me.Controls.Add(Me.btnsup)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnajouter)
        Me.Controls.Add(Me.btnmodifier)
        Me.Controls.Add(Me.btnnouveau)
        Me.Controls.Add(Me.btnauitter)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.btnsuivant)
        Me.Controls.Add(Me.brnprec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvproduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents brnprec As Button
    Friend WithEvents btndebut As Button
    Friend WithEvents btnsuivant As Button
    Friend WithEvents btnfin As Button
    Friend WithEvents btnnouveau As Button
    Friend WithEvents btnmodifier As Button
    Friend WithEvents btnsup As Button
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnauitter As Button
    Friend WithEvents txtref As TextBox
    Friend WithEvents txtdesg As TextBox
    Friend WithEvents txtqstock As TextBox
    Friend WithEvents txtprixu As TextBox
    Friend WithEvents dgvproduit As DataGridView
End Class

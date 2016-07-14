<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPick
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPick))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(600, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 58)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Health Services Information System"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" Project Management Office"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Menu
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(649, 508)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(295, 53)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete a Project"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(649, 250)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(295, 50)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update a Project"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(649, 379)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(295, 50)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add a Project"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnView
        '
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnView.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnView.Location = New System.Drawing.Point(649, 119)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(295, 52)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View Database"
        Me.btnView.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POM_Database_Upkeep.My.Resources.Resources.FotorCreated1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 550)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = false
        '
        'frmPick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1048, 608)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnView)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmPick"
        Me.Text = "Home Page"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
End Class

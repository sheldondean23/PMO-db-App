<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupByPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupByPopup))
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cmbGroupByOptions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(96, 90)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(114, 31)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = true
        '
        'cmbGroupByOptions
        '
        Me.cmbGroupByOptions.FormattingEnabled = true
        Me.cmbGroupByOptions.Location = New System.Drawing.Point(55, 50)
        Me.cmbGroupByOptions.Name = "cmbGroupByOptions"
        Me.cmbGroupByOptions.Size = New System.Drawing.Size(204, 21)
        Me.cmbGroupByOptions.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(52, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Which column would you like to group by?"
        '
        'frmGroupByPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 144)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cmbGroupByOptions)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmGroupByPopup"
        Me.Text = "Group Column By"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents cmbGroupByOptions As ComboBox
    Friend WithEvents Label1 As Label
End Class

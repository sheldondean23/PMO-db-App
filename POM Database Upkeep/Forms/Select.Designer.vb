<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelect))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstQuery = New System.Windows.Forms.ListBox()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.btnCustomQuery = New System.Windows.Forms.Button()
        Me.rtxtCustom = New System.Windows.Forms.RichTextBox()
        Me.lblCustom = New System.Windows.Forms.Label()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.lblWhere = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.clstColumn = New System.Windows.Forms.CheckedListBox()
        Me.cmsAggregateFunctions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AverageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistinctToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpSelect.SuspendLayout
        Me.cmsAggregateFunctions.SuspendLayout
        Me.SuspendLayout
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(519, 258)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'lstQuery
        '
        Me.lstQuery.FormattingEnabled = true
        Me.lstQuery.Location = New System.Drawing.Point(29, 258)
        Me.lstQuery.Name = "lstQuery"
        Me.lstQuery.Size = New System.Drawing.Size(465, 121)
        Me.lstQuery.TabIndex = 3
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = true
        Me.cmbTable.Location = New System.Drawing.Point(258, 56)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(121, 21)
        Me.cmbTable.TabIndex = 0
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.btnCustomQuery)
        Me.grpSelect.Controls.Add(Me.rtxtCustom)
        Me.grpSelect.Controls.Add(Me.lblCustom)
        Me.grpSelect.Controls.Add(Me.txtWhere)
        Me.grpSelect.Controls.Add(Me.lblWhere)
        Me.grpSelect.Controls.Add(Me.lblFrom)
        Me.grpSelect.Controls.Add(Me.lblSelect)
        Me.grpSelect.Controls.Add(Me.clstColumn)
        Me.grpSelect.Controls.Add(Me.cmbTable)
        Me.grpSelect.Location = New System.Drawing.Point(12, 20)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(611, 220)
        Me.grpSelect.TabIndex = 4
        Me.grpSelect.TabStop = false
        Me.grpSelect.Text = "Select Statment"
        '
        'btnCustomQuery
        '
        Me.btnCustomQuery.Location = New System.Drawing.Point(507, 140)
        Me.btnCustomQuery.Name = "btnCustomQuery"
        Me.btnCustomQuery.Size = New System.Drawing.Size(75, 38)
        Me.btnCustomQuery.TabIndex = 8
        Me.btnCustomQuery.Text = "Add Custom Query"
        Me.btnCustomQuery.UseVisualStyleBackColor = true
        '
        'rtxtCustom
        '
        Me.rtxtCustom.Location = New System.Drawing.Point(85, 128)
        Me.rtxtCustom.Name = "rtxtCustom"
        Me.rtxtCustom.Size = New System.Drawing.Size(397, 70)
        Me.rtxtCustom.TabIndex = 7
        Me.rtxtCustom.Text = ""
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = true
        Me.lblCustom.Location = New System.Drawing.Point(6, 153)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(73, 13)
        Me.lblCustom.TabIndex = 6
        Me.lblCustom.Text = "Custom Query"
        '
        'txtWhere
        '
        Me.txtWhere.Location = New System.Drawing.Point(464, 57)
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.Size = New System.Drawing.Size(100, 20)
        Me.txtWhere.TabIndex = 5
        '
        'lblWhere
        '
        Me.lblWhere.AutoSize = true
        Me.lblWhere.Location = New System.Drawing.Point(404, 64)
        Me.lblWhere.Name = "lblWhere"
        Me.lblWhere.Size = New System.Drawing.Size(39, 13)
        Me.lblWhere.TabIndex = 4
        Me.lblWhere.Text = "Where"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = true
        Me.lblFrom.Location = New System.Drawing.Point(195, 60)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 3
        Me.lblFrom.Text = "From"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = true
        Me.lblSelect.Location = New System.Drawing.Point(6, 60)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(37, 13)
        Me.lblSelect.TabIndex = 2
        Me.lblSelect.Text = "Select"
        '
        'clstColumn
        '
        Me.clstColumn.ContextMenuStrip = Me.cmsAggregateFunctions
        Me.clstColumn.FormattingEnabled = true
        Me.clstColumn.Location = New System.Drawing.Point(61, 19)
        Me.clstColumn.Name = "clstColumn"
        Me.clstColumn.Size = New System.Drawing.Size(120, 94)
        Me.clstColumn.TabIndex = 1
        '
        'cmsAggregateFunctions
        '
        Me.cmsAggregateFunctions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AverageToolStripMenuItem, Me.CountToolStripMenuItem, Me.DistinctToolStripMenuItem, Me.MaxToolStripMenuItem, Me.MinToolStripMenuItem, Me.SumToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.cmsAggregateFunctions.Name = "ContextMenuStrip1"
        Me.cmsAggregateFunctions.Size = New System.Drawing.Size(118, 158)
        '
        'AverageToolStripMenuItem
        '
        Me.AverageToolStripMenuItem.Name = "AverageToolStripMenuItem"
        Me.AverageToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AverageToolStripMenuItem.Text = "Average"
        '
        'CountToolStripMenuItem
        '
        Me.CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        Me.CountToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CountToolStripMenuItem.Text = "Count"
        '
        'DistinctToolStripMenuItem
        '
        Me.DistinctToolStripMenuItem.Name = "DistinctToolStripMenuItem"
        Me.DistinctToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DistinctToolStripMenuItem.Text = "Distinct"
        '
        'MaxToolStripMenuItem
        '
        Me.MaxToolStripMenuItem.Name = "MaxToolStripMenuItem"
        Me.MaxToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.MaxToolStripMenuItem.Text = "Max"
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.MinToolStripMenuItem.Text = "Min"
        '
        'SumToolStripMenuItem
        '
        Me.SumToolStripMenuItem.Name = "SumToolStripMenuItem"
        Me.SumToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SumToolStripMenuItem.Text = "Sum"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(519, 356)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Execute"
        Me.btnSubmit.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(519, 309)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'frmSelect
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 398)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.lstQuery)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmSelect"
        Me.Text = "Select"
        Me.grpSelect.ResumeLayout(false)
        Me.grpSelect.PerformLayout
        Me.cmsAggregateFunctions.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lstQuery As ListBox
    Friend WithEvents cmbTable As ComboBox
    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents clstColumn As CheckedListBox
    Friend WithEvents txtWhere As TextBox
    Friend WithEvents lblWhere As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents cmsAggregateFunctions As ContextMenuStrip
    Friend WithEvents AverageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistinctToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rtxtCustom As RichTextBox
    Friend WithEvents lblCustom As Label
    Friend WithEvents btnCustomQuery As Button
End Class

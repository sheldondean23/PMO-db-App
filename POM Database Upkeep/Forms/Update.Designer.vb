<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpStatusUpdate = New System.Windows.Forms.GroupBox()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.dtpStatusUpdate = New System.Windows.Forms.DateTimePicker()
        Me.lblNewStatusUpdate = New System.Windows.Forms.Label()
        Me.lblAllUpdates = New System.Windows.Forms.Label()
        Me.dgvAllUpdates = New System.Windows.Forms.DataGridView()
        Me.lblCharCountStatusUpdates = New System.Windows.Forms.Label()
        Me.rtxtStatusUpdate = New System.Windows.Forms.RichTextBox()
        Me.grpProjectBudget = New System.Windows.Forms.GroupBox()
        Me.clstResources = New System.Windows.Forms.CheckedListBox()
        Me.cmbSecondaryLead = New System.Windows.Forms.ComboBox()
        Me.lblSecondaryLead = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblFacility = New System.Windows.Forms.Label()
        Me.cmbProjectRequestType = New System.Windows.Forms.ComboBox()
        Me.mtxtProjectRanking = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtLaborHours = New System.Windows.Forms.MaskedTextBox()
        Me.lblProjectPriority = New System.Windows.Forms.Label()
        Me.cmbProjectPriority = New System.Windows.Forms.ComboBox()
        Me.lblProjectStatus = New System.Windows.Forms.Label()
        Me.cmbProjectStatus = New System.Windows.Forms.ComboBox()
        Me.lblSubmitter = New System.Windows.Forms.Label()
        Me.txtProjectSubmitter = New System.Windows.Forms.TextBox()
        Me.lblRankingScore = New System.Windows.Forms.Label()
        Me.lblLaborHours = New System.Windows.Forms.Label()
        Me.lblDepartmentRequest = New System.Windows.Forms.Label()
        Me.txtDepartmentRequest = New System.Windows.Forms.TextBox()
        Me.clstCategoryID = New System.Windows.Forms.CheckedListBox()
        Me.clstFacilityID = New System.Windows.Forms.CheckedListBox()
        Me.lblResources = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.lblProjectRequestType = New System.Windows.Forms.Label()
        Me.lblPrimaryLead = New System.Windows.Forms.Label()
        Me.cmbPrimaryLead = New System.Windows.Forms.ComboBox()
        Me.lblProjectSize = New System.Windows.Forms.Label()
        Me.cmbProjectSize = New System.Windows.Forms.ComboBox()
        Me.grpPurpose = New System.Windows.Forms.GroupBox()
        Me.lblCharCountFutureState = New System.Windows.Forms.Label()
        Me.lblCharCountComments = New System.Windows.Forms.Label()
        Me.rtxtProjectPurposeFutureState = New System.Windows.Forms.RichTextBox()
        Me.lblFutureState = New System.Windows.Forms.Label()
        Me.rtxtProjectCurrentState = New System.Windows.Forms.RichTextBox()
        Me.lblCurrentState = New System.Windows.Forms.Label()
        Me.grpBudget = New System.Windows.Forms.GroupBox()
        Me.txtFOPALnum = New System.Windows.Forms.TextBox()
        Me.lblFOPALnum = New System.Windows.Forms.Label()
        Me.mtxtActualBudget = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDesiredBudget = New System.Windows.Forms.MaskedTextBox()
        Me.lblActualBudget = New System.Windows.Forms.Label()
        Me.lblDesiredBudget = New System.Windows.Forms.Label()
        Me.grpProjectRequestor = New System.Windows.Forms.GroupBox()
        Me.txtprojectRequestorEmail = New System.Windows.Forms.TextBox()
        Me.mtxtProjectRequestorPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblProjectRequestorPhone = New System.Windows.Forms.Label()
        Me.lblProjectRequestorEmail = New System.Windows.Forms.Label()
        Me.lblProjectRequestorName = New System.Windows.Forms.Label()
        Me.txtRequestorName = New System.Windows.Forms.TextBox()
        Me.grpProjectDates = New System.Windows.Forms.GroupBox()
        Me.chkArchiveDate = New System.Windows.Forms.CheckBox()
        Me.chkContactedDate = New System.Windows.Forms.CheckBox()
        Me.chkRequestedDate = New System.Windows.Forms.CheckBox()
        Me.chkActualEndDate = New System.Windows.Forms.CheckBox()
        Me.chkScheduledEndDate = New System.Windows.Forms.CheckBox()
        Me.chkScheduledStartDate = New System.Windows.Forms.CheckBox()
        Me.chkActualStartDate = New System.Windows.Forms.CheckBox()
        Me.dtpArchiveDate = New System.Windows.Forms.DateTimePicker()
        Me.lblArchiveDate = New System.Windows.Forms.Label()
        Me.dtpContactedDate = New System.Windows.Forms.DateTimePicker()
        Me.lblContactedDate = New System.Windows.Forms.Label()
        Me.dtpRequestedDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRequestedDate = New System.Windows.Forms.Label()
        Me.dtpActualEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblActualEndDate = New System.Windows.Forms.Label()
        Me.lblActualStartDate = New System.Windows.Forms.Label()
        Me.dtpActualStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpScheduledEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblScheduledEndDate = New System.Windows.Forms.Label()
        Me.lblScheduledStartDate = New System.Windows.Forms.Label()
        Me.dtpScheduledStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpStatusUpdate.SuspendLayout
        CType(Me.dgvAllUpdates,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpProjectBudget.SuspendLayout
        Me.grpPurpose.SuspendLayout
        Me.grpBudget.SuspendLayout
        Me.grpProjectRequestor.SuspendLayout
        Me.grpProjectDates.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POM_Database_Upkeep.My.Resources.Resources.USA_Logo_Left_Red_Blue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(861, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 89)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = false
        '
        'grpStatusUpdate
        '
        Me.grpStatusUpdate.Controls.Add(Me.lblUpdateDate)
        Me.grpStatusUpdate.Controls.Add(Me.dtpStatusUpdate)
        Me.grpStatusUpdate.Controls.Add(Me.lblNewStatusUpdate)
        Me.grpStatusUpdate.Controls.Add(Me.lblAllUpdates)
        Me.grpStatusUpdate.Controls.Add(Me.dgvAllUpdates)
        Me.grpStatusUpdate.Controls.Add(Me.lblCharCountStatusUpdates)
        Me.grpStatusUpdate.Controls.Add(Me.rtxtStatusUpdate)
        Me.grpStatusUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpStatusUpdate.Location = New System.Drawing.Point(423, 398)
        Me.grpStatusUpdate.Name = "grpStatusUpdate"
        Me.grpStatusUpdate.Size = New System.Drawing.Size(432, 419)
        Me.grpStatusUpdate.TabIndex = 48
        Me.grpStatusUpdate.TabStop = false
        Me.grpStatusUpdate.Text = "Status Updates"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = true
        Me.lblUpdateDate.Location = New System.Drawing.Point(87, 400)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(123, 13)
        Me.lblUpdateDate.TabIndex = 35
        Me.lblUpdateDate.Text = "Status Update Date:"
        '
        'dtpStatusUpdate
        '
        Me.dtpStatusUpdate.Location = New System.Drawing.Point(225, 393)
        Me.dtpStatusUpdate.Name = "dtpStatusUpdate"
        Me.dtpStatusUpdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStatusUpdate.TabIndex = 34
        '
        'lblNewStatusUpdate
        '
        Me.lblNewStatusUpdate.AutoSize = true
        Me.lblNewStatusUpdate.Location = New System.Drawing.Point(13, 204)
        Me.lblNewStatusUpdate.Name = "lblNewStatusUpdate"
        Me.lblNewStatusUpdate.Size = New System.Drawing.Size(81, 13)
        Me.lblNewStatusUpdate.TabIndex = 33
        Me.lblNewStatusUpdate.Text = "New Update:"
        '
        'lblAllUpdates
        '
        Me.lblAllUpdates.AutoSize = true
        Me.lblAllUpdates.Location = New System.Drawing.Point(12, 26)
        Me.lblAllUpdates.Name = "lblAllUpdates"
        Me.lblAllUpdates.Size = New System.Drawing.Size(76, 13)
        Me.lblAllUpdates.TabIndex = 32
        Me.lblAllUpdates.Text = "All Updates:"
        '
        'dgvAllUpdates
        '
        Me.dgvAllUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllUpdates.Location = New System.Drawing.Point(9, 46)
        Me.dgvAllUpdates.Name = "dgvAllUpdates"
        Me.dgvAllUpdates.Size = New System.Drawing.Size(412, 150)
        Me.dgvAllUpdates.TabIndex = 31
        '
        'lblCharCountStatusUpdates
        '
        Me.lblCharCountStatusUpdates.AutoSize = true
        Me.lblCharCountStatusUpdates.Location = New System.Drawing.Point(13, 396)
        Me.lblCharCountStatusUpdates.Name = "lblCharCountStatusUpdates"
        Me.lblCharCountStatusUpdates.Size = New System.Drawing.Size(0, 13)
        Me.lblCharCountStatusUpdates.TabIndex = 30
        '
        'rtxtStatusUpdate
        '
        Me.rtxtStatusUpdate.Location = New System.Drawing.Point(9, 223)
        Me.rtxtStatusUpdate.Name = "rtxtStatusUpdate"
        Me.rtxtStatusUpdate.Size = New System.Drawing.Size(416, 165)
        Me.rtxtStatusUpdate.TabIndex = 29
        Me.rtxtStatusUpdate.Text = ""
        '
        'grpProjectBudget
        '
        Me.grpProjectBudget.Controls.Add(Me.clstResources)
        Me.grpProjectBudget.Controls.Add(Me.cmbSecondaryLead)
        Me.grpProjectBudget.Controls.Add(Me.lblSecondaryLead)
        Me.grpProjectBudget.Controls.Add(Me.lblCategory)
        Me.grpProjectBudget.Controls.Add(Me.lblFacility)
        Me.grpProjectBudget.Controls.Add(Me.cmbProjectRequestType)
        Me.grpProjectBudget.Controls.Add(Me.mtxtProjectRanking)
        Me.grpProjectBudget.Controls.Add(Me.mtxtLaborHours)
        Me.grpProjectBudget.Controls.Add(Me.lblProjectPriority)
        Me.grpProjectBudget.Controls.Add(Me.cmbProjectPriority)
        Me.grpProjectBudget.Controls.Add(Me.lblProjectStatus)
        Me.grpProjectBudget.Controls.Add(Me.cmbProjectStatus)
        Me.grpProjectBudget.Controls.Add(Me.lblSubmitter)
        Me.grpProjectBudget.Controls.Add(Me.txtProjectSubmitter)
        Me.grpProjectBudget.Controls.Add(Me.lblRankingScore)
        Me.grpProjectBudget.Controls.Add(Me.lblLaborHours)
        Me.grpProjectBudget.Controls.Add(Me.lblDepartmentRequest)
        Me.grpProjectBudget.Controls.Add(Me.txtDepartmentRequest)
        Me.grpProjectBudget.Controls.Add(Me.clstCategoryID)
        Me.grpProjectBudget.Controls.Add(Me.clstFacilityID)
        Me.grpProjectBudget.Controls.Add(Me.lblResources)
        Me.grpProjectBudget.Controls.Add(Me.lblProjectName)
        Me.grpProjectBudget.Controls.Add(Me.txtProjectName)
        Me.grpProjectBudget.Controls.Add(Me.lblProjectRequestType)
        Me.grpProjectBudget.Controls.Add(Me.lblPrimaryLead)
        Me.grpProjectBudget.Controls.Add(Me.cmbPrimaryLead)
        Me.grpProjectBudget.Controls.Add(Me.lblProjectSize)
        Me.grpProjectBudget.Controls.Add(Me.cmbProjectSize)
        Me.grpProjectBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpProjectBudget.Location = New System.Drawing.Point(18, 242)
        Me.grpProjectBudget.Name = "grpProjectBudget"
        Me.grpProjectBudget.Size = New System.Drawing.Size(364, 578)
        Me.grpProjectBudget.TabIndex = 47
        Me.grpProjectBudget.TabStop = false
        Me.grpProjectBudget.Text = "Project Information"
        '
        'clstResources
        '
        Me.clstResources.FormattingEnabled = true
        Me.clstResources.Location = New System.Drawing.Point(197, 193)
        Me.clstResources.Name = "clstResources"
        Me.clstResources.Size = New System.Drawing.Size(151, 109)
        Me.clstResources.TabIndex = 31
        '
        'cmbSecondaryLead
        '
        Me.cmbSecondaryLead.FormattingEnabled = true
        Me.cmbSecondaryLead.Location = New System.Drawing.Point(7, 193)
        Me.cmbSecondaryLead.Name = "cmbSecondaryLead"
        Me.cmbSecondaryLead.Size = New System.Drawing.Size(151, 21)
        Me.cmbSecondaryLead.TabIndex = 30
        '
        'lblSecondaryLead
        '
        Me.lblSecondaryLead.AutoSize = true
        Me.lblSecondaryLead.Location = New System.Drawing.Point(6, 177)
        Me.lblSecondaryLead.Name = "lblSecondaryLead"
        Me.lblSecondaryLead.Size = New System.Drawing.Size(136, 13)
        Me.lblSecondaryLead.TabIndex = 29
        Me.lblSecondaryLead.Text = "HSIS Secondary Lead:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = true
        Me.lblCategory.Location = New System.Drawing.Point(194, 428)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(62, 13)
        Me.lblCategory.TabIndex = 28
        Me.lblCategory.Text = "Category*"
        '
        'lblFacility
        '
        Me.lblFacility.AutoSize = true
        Me.lblFacility.Location = New System.Drawing.Point(6, 428)
        Me.lblFacility.Name = "lblFacility"
        Me.lblFacility.Size = New System.Drawing.Size(52, 13)
        Me.lblFacility.TabIndex = 27
        Me.lblFacility.Text = "Facility*"
        '
        'cmbProjectRequestType
        '
        Me.cmbProjectRequestType.FormattingEnabled = true
        Me.cmbProjectRequestType.Location = New System.Drawing.Point(197, 99)
        Me.cmbProjectRequestType.Name = "cmbProjectRequestType"
        Me.cmbProjectRequestType.Size = New System.Drawing.Size(151, 21)
        Me.cmbProjectRequestType.TabIndex = 5
        '
        'mtxtProjectRanking
        '
        Me.mtxtProjectRanking.Location = New System.Drawing.Point(6, 286)
        Me.mtxtProjectRanking.Mask = "00"
        Me.mtxtProjectRanking.Name = "mtxtProjectRanking"
        Me.mtxtProjectRanking.Size = New System.Drawing.Size(151, 20)
        Me.mtxtProjectRanking.TabIndex = 12
        '
        'mtxtLaborHours
        '
        Me.mtxtLaborHours.Location = New System.Drawing.Point(9, 379)
        Me.mtxtLaborHours.Mask = "00000.00"
        Me.mtxtLaborHours.Name = "mtxtLaborHours"
        Me.mtxtLaborHours.Size = New System.Drawing.Size(151, 20)
        Me.mtxtLaborHours.TabIndex = 13
        '
        'lblProjectPriority
        '
        Me.lblProjectPriority.AutoSize = true
        Me.lblProjectPriority.Location = New System.Drawing.Point(194, 315)
        Me.lblProjectPriority.Name = "lblProjectPriority"
        Me.lblProjectPriority.Size = New System.Drawing.Size(94, 13)
        Me.lblProjectPriority.TabIndex = 25
        Me.lblProjectPriority.Text = "Project Priority:"
        '
        'cmbProjectPriority
        '
        Me.cmbProjectPriority.FormattingEnabled = true
        Me.cmbProjectPriority.Location = New System.Drawing.Point(197, 331)
        Me.cmbProjectPriority.Name = "cmbProjectPriority"
        Me.cmbProjectPriority.Size = New System.Drawing.Size(151, 21)
        Me.cmbProjectPriority.TabIndex = 11
        '
        'lblProjectStatus
        '
        Me.lblProjectStatus.AutoSize = true
        Me.lblProjectStatus.Location = New System.Drawing.Point(6, 315)
        Me.lblProjectStatus.Name = "lblProjectStatus"
        Me.lblProjectStatus.Size = New System.Drawing.Size(96, 13)
        Me.lblProjectStatus.TabIndex = 23
        Me.lblProjectStatus.Text = "Project Status:*"
        '
        'cmbProjectStatus
        '
        Me.cmbProjectStatus.FormattingEnabled = true
        Me.cmbProjectStatus.Location = New System.Drawing.Point(6, 331)
        Me.cmbProjectStatus.Name = "cmbProjectStatus"
        Me.cmbProjectStatus.Size = New System.Drawing.Size(151, 21)
        Me.cmbProjectStatus.TabIndex = 14
        '
        'lblSubmitter
        '
        Me.lblSubmitter.AutoSize = true
        Me.lblSubmitter.Location = New System.Drawing.Point(194, 128)
        Me.lblSubmitter.Name = "lblSubmitter"
        Me.lblSubmitter.Size = New System.Drawing.Size(113, 13)
        Me.lblSubmitter.TabIndex = 21
        Me.lblSubmitter.Text = "Project Submitter:*"
        '
        'txtProjectSubmitter
        '
        Me.txtProjectSubmitter.Location = New System.Drawing.Point(197, 148)
        Me.txtProjectSubmitter.Name = "txtProjectSubmitter"
        Me.txtProjectSubmitter.Size = New System.Drawing.Size(151, 20)
        Me.txtProjectSubmitter.TabIndex = 7
        '
        'lblRankingScore
        '
        Me.lblRankingScore.AutoSize = true
        Me.lblRankingScore.Location = New System.Drawing.Point(3, 267)
        Me.lblRankingScore.Name = "lblRankingScore"
        Me.lblRankingScore.Size = New System.Drawing.Size(107, 13)
        Me.lblRankingScore.TabIndex = 19
        Me.lblRankingScore.Text = "Project Ranking:*"
        '
        'lblLaborHours
        '
        Me.lblLaborHours.AutoSize = true
        Me.lblLaborHours.Location = New System.Drawing.Point(6, 360)
        Me.lblLaborHours.Name = "lblLaborHours"
        Me.lblLaborHours.Size = New System.Drawing.Size(80, 13)
        Me.lblLaborHours.TabIndex = 17
        Me.lblLaborHours.Text = "Labor Hours:"
        '
        'lblDepartmentRequest
        '
        Me.lblDepartmentRequest.AutoSize = true
        Me.lblDepartmentRequest.Location = New System.Drawing.Point(4, 83)
        Me.lblDepartmentRequest.Name = "lblDepartmentRequest"
        Me.lblDepartmentRequest.Size = New System.Drawing.Size(147, 13)
        Me.lblDepartmentRequest.TabIndex = 15
        Me.lblDepartmentRequest.Text = "Department of Request:*"
        '
        'txtDepartmentRequest
        '
        Me.txtDepartmentRequest.Location = New System.Drawing.Point(6, 99)
        Me.txtDepartmentRequest.Name = "txtDepartmentRequest"
        Me.txtDepartmentRequest.Size = New System.Drawing.Size(151, 20)
        Me.txtDepartmentRequest.TabIndex = 6
        '
        'clstCategoryID
        '
        Me.clstCategoryID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.clstCategoryID.FormattingEnabled = true
        Me.clstCategoryID.Location = New System.Drawing.Point(197, 447)
        Me.clstCategoryID.Name = "clstCategoryID"
        Me.clstCategoryID.Size = New System.Drawing.Size(158, 109)
        Me.clstCategoryID.TabIndex = 16
        '
        'clstFacilityID
        '
        Me.clstFacilityID.AccessibleName = ""
        Me.clstFacilityID.FormattingEnabled = true
        Me.clstFacilityID.Location = New System.Drawing.Point(6, 444)
        Me.clstFacilityID.Name = "clstFacilityID"
        Me.clstFacilityID.Size = New System.Drawing.Size(157, 109)
        Me.clstFacilityID.TabIndex = 15
        '
        'lblResources
        '
        Me.lblResources.AutoSize = true
        Me.lblResources.Location = New System.Drawing.Point(194, 177)
        Me.lblResources.Name = "lblResources"
        Me.lblResources.Size = New System.Drawing.Size(71, 13)
        Me.lblResources.TabIndex = 11
        Me.lblResources.Text = "Resources:"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = true
        Me.lblProjectName.Location = New System.Drawing.Point(3, 27)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(92, 13)
        Me.lblProjectName.TabIndex = 9
        Me.lblProjectName.Text = "Project Name:*"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(6, 43)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(342, 20)
        Me.txtProjectName.TabIndex = 4
        '
        'lblProjectRequestType
        '
        Me.lblProjectRequestType.AutoSize = true
        Me.lblProjectRequestType.Location = New System.Drawing.Point(194, 83)
        Me.lblProjectRequestType.Name = "lblProjectRequestType"
        Me.lblProjectRequestType.Size = New System.Drawing.Size(139, 13)
        Me.lblProjectRequestType.TabIndex = 7
        Me.lblProjectRequestType.Text = "Project Request Type:*"
        '
        'lblPrimaryLead
        '
        Me.lblPrimaryLead.AutoSize = true
        Me.lblPrimaryLead.Location = New System.Drawing.Point(6, 128)
        Me.lblPrimaryLead.Name = "lblPrimaryLead"
        Me.lblPrimaryLead.Size = New System.Drawing.Size(122, 13)
        Me.lblPrimaryLead.TabIndex = 5
        Me.lblPrimaryLead.Text = "HSIS Primary Lead:*"
        '
        'cmbPrimaryLead
        '
        Me.cmbPrimaryLead.FormattingEnabled = true
        Me.cmbPrimaryLead.Location = New System.Drawing.Point(6, 147)
        Me.cmbPrimaryLead.Name = "cmbPrimaryLead"
        Me.cmbPrimaryLead.Size = New System.Drawing.Size(151, 21)
        Me.cmbPrimaryLead.TabIndex = 8
        '
        'lblProjectSize
        '
        Me.lblProjectSize.AutoSize = true
        Me.lblProjectSize.Location = New System.Drawing.Point(6, 222)
        Me.lblProjectSize.Name = "lblProjectSize"
        Me.lblProjectSize.Size = New System.Drawing.Size(79, 13)
        Me.lblProjectSize.TabIndex = 3
        Me.lblProjectSize.Text = "Project Size:"
        '
        'cmbProjectSize
        '
        Me.cmbProjectSize.FormattingEnabled = true
        Me.cmbProjectSize.Location = New System.Drawing.Point(6, 238)
        Me.cmbProjectSize.Name = "cmbProjectSize"
        Me.cmbProjectSize.Size = New System.Drawing.Size(151, 21)
        Me.cmbProjectSize.TabIndex = 10
        '
        'grpPurpose
        '
        Me.grpPurpose.Controls.Add(Me.lblCharCountFutureState)
        Me.grpPurpose.Controls.Add(Me.lblCharCountComments)
        Me.grpPurpose.Controls.Add(Me.rtxtProjectPurposeFutureState)
        Me.grpPurpose.Controls.Add(Me.lblFutureState)
        Me.grpPurpose.Controls.Add(Me.rtxtProjectCurrentState)
        Me.grpPurpose.Controls.Add(Me.lblCurrentState)
        Me.grpPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpPurpose.Location = New System.Drawing.Point(423, 28)
        Me.grpPurpose.Name = "grpPurpose"
        Me.grpPurpose.Size = New System.Drawing.Size(432, 364)
        Me.grpPurpose.TabIndex = 43
        Me.grpPurpose.TabStop = false
        Me.grpPurpose.Text = "Project Purpose"
        '
        'lblCharCountFutureState
        '
        Me.lblCharCountFutureState.AutoSize = true
        Me.lblCharCountFutureState.Location = New System.Drawing.Point(13, 342)
        Me.lblCharCountFutureState.Name = "lblCharCountFutureState"
        Me.lblCharCountFutureState.Size = New System.Drawing.Size(0, 13)
        Me.lblCharCountFutureState.TabIndex = 20
        '
        'lblCharCountComments
        '
        Me.lblCharCountComments.AutoSize = true
        Me.lblCharCountComments.Location = New System.Drawing.Point(10, 168)
        Me.lblCharCountComments.Name = "lblCharCountComments"
        Me.lblCharCountComments.Size = New System.Drawing.Size(0, 13)
        Me.lblCharCountComments.TabIndex = 19
        '
        'rtxtProjectPurposeFutureState
        '
        Me.rtxtProjectPurposeFutureState.Location = New System.Drawing.Point(9, 207)
        Me.rtxtProjectPurposeFutureState.Name = "rtxtProjectPurposeFutureState"
        Me.rtxtProjectPurposeFutureState.Size = New System.Drawing.Size(412, 129)
        Me.rtxtProjectPurposeFutureState.TabIndex = 18
        Me.rtxtProjectPurposeFutureState.Text = ""
        '
        'lblFutureState
        '
        Me.lblFutureState.AutoSize = true
        Me.lblFutureState.Location = New System.Drawing.Point(6, 187)
        Me.lblFutureState.Name = "lblFutureState"
        Me.lblFutureState.Size = New System.Drawing.Size(86, 13)
        Me.lblFutureState.TabIndex = 2
        Me.lblFutureState.Text = "Future State:*"
        '
        'rtxtProjectCurrentState
        '
        Me.rtxtProjectCurrentState.Location = New System.Drawing.Point(6, 30)
        Me.rtxtProjectCurrentState.Name = "rtxtProjectCurrentState"
        Me.rtxtProjectCurrentState.Size = New System.Drawing.Size(412, 134)
        Me.rtxtProjectCurrentState.TabIndex = 17
        Me.rtxtProjectCurrentState.Text = ""
        '
        'lblCurrentState
        '
        Me.lblCurrentState.AutoSize = true
        Me.lblCurrentState.Location = New System.Drawing.Point(6, 14)
        Me.lblCurrentState.Name = "lblCurrentState"
        Me.lblCurrentState.Size = New System.Drawing.Size(91, 13)
        Me.lblCurrentState.TabIndex = 0
        Me.lblCurrentState.Text = "Current State:*"
        '
        'grpBudget
        '
        Me.grpBudget.Controls.Add(Me.txtFOPALnum)
        Me.grpBudget.Controls.Add(Me.lblFOPALnum)
        Me.grpBudget.Controls.Add(Me.mtxtActualBudget)
        Me.grpBudget.Controls.Add(Me.mtxtDesiredBudget)
        Me.grpBudget.Controls.Add(Me.lblActualBudget)
        Me.grpBudget.Controls.Add(Me.lblDesiredBudget)
        Me.grpBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpBudget.Location = New System.Drawing.Point(907, 111)
        Me.grpBudget.Name = "grpBudget"
        Me.grpBudget.Size = New System.Drawing.Size(313, 195)
        Me.grpBudget.TabIndex = 44
        Me.grpBudget.TabStop = false
        Me.grpBudget.Text = "Project Budget"
        '
        'txtFOPALnum
        '
        Me.txtFOPALnum.Location = New System.Drawing.Point(18, 169)
        Me.txtFOPALnum.Name = "txtFOPALnum"
        Me.txtFOPALnum.Size = New System.Drawing.Size(100, 20)
        Me.txtFOPALnum.TabIndex = 22
        '
        'lblFOPALnum
        '
        Me.lblFOPALnum.AutoSize = true
        Me.lblFOPALnum.Location = New System.Drawing.Point(15, 153)
        Me.lblFOPALnum.Name = "lblFOPALnum"
        Me.lblFOPALnum.Size = New System.Drawing.Size(97, 13)
        Me.lblFOPALnum.TabIndex = 21
        Me.lblFOPALnum.Text = "FOPAL Number:"
        '
        'mtxtActualBudget
        '
        Me.mtxtActualBudget.Location = New System.Drawing.Point(18, 103)
        Me.mtxtActualBudget.Mask = "$0000000"
        Me.mtxtActualBudget.Name = "mtxtActualBudget"
        Me.mtxtActualBudget.Size = New System.Drawing.Size(100, 20)
        Me.mtxtActualBudget.TabIndex = 20
        '
        'mtxtDesiredBudget
        '
        Me.mtxtDesiredBudget.Location = New System.Drawing.Point(18, 42)
        Me.mtxtDesiredBudget.Mask = "$0000000"
        Me.mtxtDesiredBudget.Name = "mtxtDesiredBudget"
        Me.mtxtDesiredBudget.Size = New System.Drawing.Size(100, 20)
        Me.mtxtDesiredBudget.TabIndex = 19
        '
        'lblActualBudget
        '
        Me.lblActualBudget.AutoSize = true
        Me.lblActualBudget.Location = New System.Drawing.Point(15, 87)
        Me.lblActualBudget.Name = "lblActualBudget"
        Me.lblActualBudget.Size = New System.Drawing.Size(91, 13)
        Me.lblActualBudget.TabIndex = 2
        Me.lblActualBudget.Text = "Actual Budget:"
        '
        'lblDesiredBudget
        '
        Me.lblDesiredBudget.AutoSize = true
        Me.lblDesiredBudget.Location = New System.Drawing.Point(15, 26)
        Me.lblDesiredBudget.Name = "lblDesiredBudget"
        Me.lblDesiredBudget.Size = New System.Drawing.Size(98, 13)
        Me.lblDesiredBudget.TabIndex = 1
        Me.lblDesiredBudget.Text = "Desired Budget:"
        '
        'grpProjectRequestor
        '
        Me.grpProjectRequestor.Controls.Add(Me.txtprojectRequestorEmail)
        Me.grpProjectRequestor.Controls.Add(Me.mtxtProjectRequestorPhone)
        Me.grpProjectRequestor.Controls.Add(Me.lblProjectRequestorPhone)
        Me.grpProjectRequestor.Controls.Add(Me.lblProjectRequestorEmail)
        Me.grpProjectRequestor.Controls.Add(Me.lblProjectRequestorName)
        Me.grpProjectRequestor.Controls.Add(Me.txtRequestorName)
        Me.grpProjectRequestor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpProjectRequestor.Location = New System.Drawing.Point(18, 28)
        Me.grpProjectRequestor.Name = "grpProjectRequestor"
        Me.grpProjectRequestor.Size = New System.Drawing.Size(364, 196)
        Me.grpProjectRequestor.TabIndex = 42
        Me.grpProjectRequestor.TabStop = false
        Me.grpProjectRequestor.Text = "Project Requestor"
        '
        'txtprojectRequestorEmail
        '
        Me.txtprojectRequestorEmail.Location = New System.Drawing.Point(17, 99)
        Me.txtprojectRequestorEmail.Name = "txtprojectRequestorEmail"
        Me.txtprojectRequestorEmail.Size = New System.Drawing.Size(141, 20)
        Me.txtprojectRequestorEmail.TabIndex = 2
        '
        'mtxtProjectRequestorPhone
        '
        Me.mtxtProjectRequestorPhone.Location = New System.Drawing.Point(18, 158)
        Me.mtxtProjectRequestorPhone.Mask = "0000000000"
        Me.mtxtProjectRequestorPhone.Name = "mtxtProjectRequestorPhone"
        Me.mtxtProjectRequestorPhone.Size = New System.Drawing.Size(139, 20)
        Me.mtxtProjectRequestorPhone.TabIndex = 3
        '
        'lblProjectRequestorPhone
        '
        Me.lblProjectRequestorPhone.AutoSize = true
        Me.lblProjectRequestorPhone.Location = New System.Drawing.Point(15, 142)
        Me.lblProjectRequestorPhone.Name = "lblProjectRequestorPhone"
        Me.lblProjectRequestorPhone.Size = New System.Drawing.Size(158, 13)
        Me.lblProjectRequestorPhone.TabIndex = 4
        Me.lblProjectRequestorPhone.Text = "Project Requestor Phone:*"
        '
        'lblProjectRequestorEmail
        '
        Me.lblProjectRequestorEmail.AutoSize = true
        Me.lblProjectRequestorEmail.Location = New System.Drawing.Point(15, 83)
        Me.lblProjectRequestorEmail.Name = "lblProjectRequestorEmail"
        Me.lblProjectRequestorEmail.Size = New System.Drawing.Size(156, 13)
        Me.lblProjectRequestorEmail.TabIndex = 2
        Me.lblProjectRequestorEmail.Text = "Project Requestor E-mail:*"
        '
        'lblProjectRequestorName
        '
        Me.lblProjectRequestorName.AutoSize = true
        Me.lblProjectRequestorName.Location = New System.Drawing.Point(15, 32)
        Me.lblProjectRequestorName.Name = "lblProjectRequestorName"
        Me.lblProjectRequestorName.Size = New System.Drawing.Size(154, 13)
        Me.lblProjectRequestorName.TabIndex = 1
        Me.lblProjectRequestorName.Text = "Project Requestor Name:*"
        '
        'txtRequestorName
        '
        Me.txtRequestorName.Location = New System.Drawing.Point(18, 53)
        Me.txtRequestorName.Name = "txtRequestorName"
        Me.txtRequestorName.Size = New System.Drawing.Size(142, 20)
        Me.txtRequestorName.TabIndex = 1
        '
        'grpProjectDates
        '
        Me.grpProjectDates.Controls.Add(Me.chkArchiveDate)
        Me.grpProjectDates.Controls.Add(Me.chkContactedDate)
        Me.grpProjectDates.Controls.Add(Me.chkRequestedDate)
        Me.grpProjectDates.Controls.Add(Me.chkActualEndDate)
        Me.grpProjectDates.Controls.Add(Me.chkScheduledEndDate)
        Me.grpProjectDates.Controls.Add(Me.chkScheduledStartDate)
        Me.grpProjectDates.Controls.Add(Me.chkActualStartDate)
        Me.grpProjectDates.Controls.Add(Me.dtpArchiveDate)
        Me.grpProjectDates.Controls.Add(Me.lblArchiveDate)
        Me.grpProjectDates.Controls.Add(Me.dtpContactedDate)
        Me.grpProjectDates.Controls.Add(Me.lblContactedDate)
        Me.grpProjectDates.Controls.Add(Me.dtpRequestedDate)
        Me.grpProjectDates.Controls.Add(Me.lblRequestedDate)
        Me.grpProjectDates.Controls.Add(Me.dtpActualEndDate)
        Me.grpProjectDates.Controls.Add(Me.lblActualEndDate)
        Me.grpProjectDates.Controls.Add(Me.lblActualStartDate)
        Me.grpProjectDates.Controls.Add(Me.dtpActualStartDate)
        Me.grpProjectDates.Controls.Add(Me.dtpScheduledEndDate)
        Me.grpProjectDates.Controls.Add(Me.lblScheduledEndDate)
        Me.grpProjectDates.Controls.Add(Me.lblScheduledStartDate)
        Me.grpProjectDates.Controls.Add(Me.dtpScheduledStartDate)
        Me.grpProjectDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpProjectDates.Location = New System.Drawing.Point(907, 322)
        Me.grpProjectDates.Name = "grpProjectDates"
        Me.grpProjectDates.Size = New System.Drawing.Size(313, 416)
        Me.grpProjectDates.TabIndex = 45
        Me.grpProjectDates.TabStop = false
        Me.grpProjectDates.Text = "Project Dates"
        '
        'chkArchiveDate
        '
        Me.chkArchiveDate.AutoSize = true
        Me.chkArchiveDate.Location = New System.Drawing.Point(17, 384)
        Me.chkArchiveDate.Name = "chkArchiveDate"
        Me.chkArchiveDate.Size = New System.Drawing.Size(15, 14)
        Me.chkArchiveDate.TabIndex = 28
        Me.chkArchiveDate.UseVisualStyleBackColor = true
        '
        'chkContactedDate
        '
        Me.chkContactedDate.AutoSize = true
        Me.chkContactedDate.Location = New System.Drawing.Point(17, 326)
        Me.chkContactedDate.Name = "chkContactedDate"
        Me.chkContactedDate.Size = New System.Drawing.Size(15, 14)
        Me.chkContactedDate.TabIndex = 27
        Me.chkContactedDate.UseVisualStyleBackColor = true
        '
        'chkRequestedDate
        '
        Me.chkRequestedDate.AutoSize = true
        Me.chkRequestedDate.Location = New System.Drawing.Point(17, 268)
        Me.chkRequestedDate.Name = "chkRequestedDate"
        Me.chkRequestedDate.Size = New System.Drawing.Size(15, 14)
        Me.chkRequestedDate.TabIndex = 33
        Me.chkRequestedDate.UseVisualStyleBackColor = true
        '
        'chkActualEndDate
        '
        Me.chkActualEndDate.AutoSize = true
        Me.chkActualEndDate.Location = New System.Drawing.Point(17, 210)
        Me.chkActualEndDate.Name = "chkActualEndDate"
        Me.chkActualEndDate.Size = New System.Drawing.Size(15, 14)
        Me.chkActualEndDate.TabIndex = 26
        Me.chkActualEndDate.UseVisualStyleBackColor = true
        '
        'chkScheduledEndDate
        '
        Me.chkScheduledEndDate.AutoSize = true
        Me.chkScheduledEndDate.Location = New System.Drawing.Point(17, 94)
        Me.chkScheduledEndDate.Name = "chkScheduledEndDate"
        Me.chkScheduledEndDate.Size = New System.Drawing.Size(15, 14)
        Me.chkScheduledEndDate.TabIndex = 24
        Me.chkScheduledEndDate.UseVisualStyleBackColor = true
        '
        'chkScheduledStartDate
        '
        Me.chkScheduledStartDate.AutoSize = true
        Me.chkScheduledStartDate.Location = New System.Drawing.Point(17, 36)
        Me.chkScheduledStartDate.Name = "chkScheduledStartDate"
        Me.chkScheduledStartDate.Size = New System.Drawing.Size(15, 14)
        Me.chkScheduledStartDate.TabIndex = 23
        Me.chkScheduledStartDate.UseVisualStyleBackColor = true
        '
        'chkActualStartDate
        '
        Me.chkActualStartDate.AutoSize = true
        Me.chkActualStartDate.Location = New System.Drawing.Point(17, 152)
        Me.chkActualStartDate.Name = "chkActualStartDate"
        Me.chkActualStartDate.Size = New System.Drawing.Size(15, 14)
        Me.chkActualStartDate.TabIndex = 25
        Me.chkActualStartDate.UseVisualStyleBackColor = true
        '
        'dtpArchiveDate
        '
        Me.dtpArchiveDate.Location = New System.Drawing.Point(38, 382)
        Me.dtpArchiveDate.Name = "dtpArchiveDate"
        Me.dtpArchiveDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpArchiveDate.TabIndex = 28
        '
        'lblArchiveDate
        '
        Me.lblArchiveDate.AutoSize = true
        Me.lblArchiveDate.Location = New System.Drawing.Point(15, 368)
        Me.lblArchiveDate.Name = "lblArchiveDate"
        Me.lblArchiveDate.Size = New System.Drawing.Size(85, 13)
        Me.lblArchiveDate.TabIndex = 12
        Me.lblArchiveDate.Text = "Archive Date:"
        '
        'dtpContactedDate
        '
        Me.dtpContactedDate.Location = New System.Drawing.Point(38, 324)
        Me.dtpContactedDate.Name = "dtpContactedDate"
        Me.dtpContactedDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpContactedDate.TabIndex = 27
        '
        'lblContactedDate
        '
        Me.lblContactedDate.AutoSize = true
        Me.lblContactedDate.Location = New System.Drawing.Point(14, 308)
        Me.lblContactedDate.Name = "lblContactedDate"
        Me.lblContactedDate.Size = New System.Drawing.Size(100, 13)
        Me.lblContactedDate.TabIndex = 10
        Me.lblContactedDate.Text = "Contacted Date:"
        '
        'dtpRequestedDate
        '
        Me.dtpRequestedDate.Location = New System.Drawing.Point(38, 266)
        Me.dtpRequestedDate.Name = "dtpRequestedDate"
        Me.dtpRequestedDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpRequestedDate.TabIndex = 21
        '
        'lblRequestedDate
        '
        Me.lblRequestedDate.AutoSize = true
        Me.lblRequestedDate.Location = New System.Drawing.Point(14, 250)
        Me.lblRequestedDate.Name = "lblRequestedDate"
        Me.lblRequestedDate.Size = New System.Drawing.Size(108, 13)
        Me.lblRequestedDate.TabIndex = 8
        Me.lblRequestedDate.Text = "Requested Date:*"
        '
        'dtpActualEndDate
        '
        Me.dtpActualEndDate.Location = New System.Drawing.Point(38, 208)
        Me.dtpActualEndDate.Name = "dtpActualEndDate"
        Me.dtpActualEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpActualEndDate.TabIndex = 25
        '
        'lblActualEndDate
        '
        Me.lblActualEndDate.AutoSize = true
        Me.lblActualEndDate.Location = New System.Drawing.Point(15, 192)
        Me.lblActualEndDate.Name = "lblActualEndDate"
        Me.lblActualEndDate.Size = New System.Drawing.Size(104, 13)
        Me.lblActualEndDate.TabIndex = 6
        Me.lblActualEndDate.Text = "Actual End Date:"
        '
        'lblActualStartDate
        '
        Me.lblActualStartDate.AutoSize = true
        Me.lblActualStartDate.Location = New System.Drawing.Point(15, 134)
        Me.lblActualStartDate.Name = "lblActualStartDate"
        Me.lblActualStartDate.Size = New System.Drawing.Size(109, 13)
        Me.lblActualStartDate.TabIndex = 5
        Me.lblActualStartDate.Text = "Actual Start Date:"
        '
        'dtpActualStartDate
        '
        Me.dtpActualStartDate.Location = New System.Drawing.Point(38, 150)
        Me.dtpActualStartDate.Name = "dtpActualStartDate"
        Me.dtpActualStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpActualStartDate.TabIndex = 24
        '
        'dtpScheduledEndDate
        '
        Me.dtpScheduledEndDate.Location = New System.Drawing.Point(38, 92)
        Me.dtpScheduledEndDate.Name = "dtpScheduledEndDate"
        Me.dtpScheduledEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpScheduledEndDate.TabIndex = 23
        '
        'lblScheduledEndDate
        '
        Me.lblScheduledEndDate.AutoSize = true
        Me.lblScheduledEndDate.Location = New System.Drawing.Point(14, 76)
        Me.lblScheduledEndDate.Name = "lblScheduledEndDate"
        Me.lblScheduledEndDate.Size = New System.Drawing.Size(128, 13)
        Me.lblScheduledEndDate.TabIndex = 2
        Me.lblScheduledEndDate.Text = "Scheduled End Date:"
        '
        'lblScheduledStartDate
        '
        Me.lblScheduledStartDate.AutoSize = true
        Me.lblScheduledStartDate.Location = New System.Drawing.Point(14, 18)
        Me.lblScheduledStartDate.Name = "lblScheduledStartDate"
        Me.lblScheduledStartDate.Size = New System.Drawing.Size(133, 13)
        Me.lblScheduledStartDate.TabIndex = 1
        Me.lblScheduledStartDate.Text = "Scheduled Start Date:"
        '
        'dtpScheduledStartDate
        '
        Me.dtpScheduledStartDate.Location = New System.Drawing.Point(38, 34)
        Me.dtpScheduledStartDate.Name = "dtpScheduledStartDate"
        Me.dtpScheduledStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpScheduledStartDate.TabIndex = 22
        Me.dtpScheduledStartDate.Value = New Date(2016, 2, 24, 0, 0, 0, 0)
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(959, 768)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(219, 47)
        Me.btnSubmit.TabIndex = 46
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = true
        '
        'frmUpdate
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 836)
        Me.Controls.Add(Me.grpStatusUpdate)
        Me.Controls.Add(Me.grpProjectBudget)
        Me.Controls.Add(Me.grpPurpose)
        Me.Controls.Add(Me.grpBudget)
        Me.Controls.Add(Me.grpProjectRequestor)
        Me.Controls.Add(Me.grpProjectDates)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmUpdate"
        Me.Text = "Update Project"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpStatusUpdate.ResumeLayout(false)
        Me.grpStatusUpdate.PerformLayout
        CType(Me.dgvAllUpdates,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpProjectBudget.ResumeLayout(false)
        Me.grpProjectBudget.PerformLayout
        Me.grpPurpose.ResumeLayout(false)
        Me.grpPurpose.PerformLayout
        Me.grpBudget.ResumeLayout(false)
        Me.grpBudget.PerformLayout
        Me.grpProjectRequestor.ResumeLayout(false)
        Me.grpProjectRequestor.PerformLayout
        Me.grpProjectDates.ResumeLayout(false)
        Me.grpProjectDates.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpStatusUpdate As GroupBox
    Friend WithEvents lblCharCountStatusUpdates As Label
    Friend WithEvents rtxtStatusUpdate As RichTextBox
    Friend WithEvents grpProjectBudget As GroupBox
    Friend WithEvents clstResources As CheckedListBox
    Friend WithEvents cmbSecondaryLead As ComboBox
    Friend WithEvents lblSecondaryLead As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblFacility As Label
    Friend WithEvents cmbProjectRequestType As ComboBox
    Friend WithEvents mtxtProjectRanking As MaskedTextBox
    Friend WithEvents mtxtLaborHours As MaskedTextBox
    Friend WithEvents lblProjectPriority As Label
    Friend WithEvents cmbProjectPriority As ComboBox
    Friend WithEvents lblProjectStatus As Label
    Friend WithEvents cmbProjectStatus As ComboBox
    Friend WithEvents lblSubmitter As Label
    Friend WithEvents txtProjectSubmitter As TextBox
    Friend WithEvents lblRankingScore As Label
    Friend WithEvents lblLaborHours As Label
    Friend WithEvents lblDepartmentRequest As Label
    Friend WithEvents txtDepartmentRequest As TextBox
    Friend WithEvents clstCategoryID As CheckedListBox
    Friend WithEvents clstFacilityID As CheckedListBox
    Friend WithEvents lblResources As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents lblProjectRequestType As Label
    Friend WithEvents lblPrimaryLead As Label
    Friend WithEvents cmbPrimaryLead As ComboBox
    Friend WithEvents lblProjectSize As Label
    Friend WithEvents cmbProjectSize As ComboBox
    Friend WithEvents grpPurpose As GroupBox
    Friend WithEvents rtxtProjectPurposeFutureState As RichTextBox
    Friend WithEvents lblFutureState As Label
    Friend WithEvents rtxtProjectCurrentState As RichTextBox
    Friend WithEvents lblCurrentState As Label
    Friend WithEvents grpBudget As GroupBox
    Friend WithEvents mtxtActualBudget As MaskedTextBox
    Friend WithEvents mtxtDesiredBudget As MaskedTextBox
    Friend WithEvents lblActualBudget As Label
    Friend WithEvents lblDesiredBudget As Label
    Friend WithEvents grpProjectRequestor As GroupBox
    Friend WithEvents txtprojectRequestorEmail As TextBox
    Friend WithEvents mtxtProjectRequestorPhone As MaskedTextBox
    Friend WithEvents lblProjectRequestorPhone As Label
    Friend WithEvents lblProjectRequestorEmail As Label
    Friend WithEvents lblProjectRequestorName As Label
    Friend WithEvents txtRequestorName As TextBox
    Friend WithEvents grpProjectDates As GroupBox
    Friend WithEvents chkArchiveDate As CheckBox
    Friend WithEvents chkContactedDate As CheckBox
    Friend WithEvents chkRequestedDate As CheckBox
    Friend WithEvents chkActualEndDate As CheckBox
    Friend WithEvents chkScheduledEndDate As CheckBox
    Friend WithEvents chkScheduledStartDate As CheckBox
    Friend WithEvents chkActualStartDate As CheckBox
    Friend WithEvents dtpArchiveDate As DateTimePicker
    Friend WithEvents lblArchiveDate As Label
    Friend WithEvents dtpContactedDate As DateTimePicker
    Friend WithEvents lblContactedDate As Label
    Friend WithEvents dtpRequestedDate As DateTimePicker
    Friend WithEvents lblRequestedDate As Label
    Friend WithEvents dtpActualEndDate As DateTimePicker
    Friend WithEvents lblActualEndDate As Label
    Friend WithEvents lblActualStartDate As Label
    Friend WithEvents dtpActualStartDate As DateTimePicker
    Friend WithEvents dtpScheduledEndDate As DateTimePicker
    Friend WithEvents lblScheduledEndDate As Label
    Friend WithEvents lblScheduledStartDate As Label
    Friend WithEvents dtpScheduledStartDate As DateTimePicker
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblCharCountFutureState As Label
    Friend WithEvents lblCharCountComments As Label
    Friend WithEvents lblNewStatusUpdate As Label
    Friend WithEvents lblAllUpdates As Label
    Friend WithEvents dgvAllUpdates As DataGridView
    Friend WithEvents dtpStatusUpdate As DateTimePicker
    Friend WithEvents lblUpdateDate As Label
    Friend WithEvents txtFOPALnum As TextBox
    Friend WithEvents lblFOPALnum As Label
End Class

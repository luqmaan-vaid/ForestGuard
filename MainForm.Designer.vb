<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSelectForest = New System.Windows.Forms.ComboBox()
        Me.btnCreateForest = New System.Windows.Forms.Button()
        Me.btnRemoveForest = New System.Windows.Forms.Button()
        Me.btnViewForest = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddTrees = New System.Windows.Forms.Button()
        Me.btnViewTrees = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCheckRisk = New System.Windows.Forms.Button()
        Me.btnCalculateDensity = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnHarvestTrees = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  FOREST GUARD" & Global.Microsoft.VisualBasic.ChrW(10) & "        "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(230, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sustainable Forest Manager"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "select forest       "
        '
        'cmbSelectForest
        '
        Me.cmbSelectForest.FormattingEnabled = True
        Me.cmbSelectForest.Location = New System.Drawing.Point(313, 81)
        Me.cmbSelectForest.Name = "cmbSelectForest"
        Me.cmbSelectForest.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelectForest.TabIndex = 3
        '
        'btnCreateForest
        '
        Me.btnCreateForest.Location = New System.Drawing.Point(12, 204)
        Me.btnCreateForest.Name = "btnCreateForest"
        Me.btnCreateForest.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateForest.TabIndex = 4
        Me.btnCreateForest.Text = "create forest"
        Me.btnCreateForest.UseVisualStyleBackColor = True
        '
        'btnRemoveForest
        '
        Me.btnRemoveForest.Location = New System.Drawing.Point(93, 204)
        Me.btnRemoveForest.Name = "btnRemoveForest"
        Me.btnRemoveForest.Size = New System.Drawing.Size(81, 23)
        Me.btnRemoveForest.TabIndex = 5
        Me.btnRemoveForest.Text = "remove forest"
        Me.btnRemoveForest.UseVisualStyleBackColor = True
        '
        'btnViewForest
        '
        Me.btnViewForest.Location = New System.Drawing.Point(49, 244)
        Me.btnViewForest.Name = "btnViewForest"
        Me.btnViewForest.Size = New System.Drawing.Size(81, 23)
        Me.btnViewForest.TabIndex = 6
        Me.btnViewForest.Text = "view forest"
        Me.btnViewForest.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(484, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TREE MANAGEMENT"
        '
        'btnAddTrees
        '
        Me.btnAddTrees.Location = New System.Drawing.Point(466, 204)
        Me.btnAddTrees.Name = "btnAddTrees"
        Me.btnAddTrees.Size = New System.Drawing.Size(81, 23)
        Me.btnAddTrees.TabIndex = 8
        Me.btnAddTrees.Text = "add trees"
        Me.btnAddTrees.UseVisualStyleBackColor = True
        '
        'btnViewTrees
        '
        Me.btnViewTrees.Location = New System.Drawing.Point(589, 204)
        Me.btnViewTrees.Name = "btnViewTrees"
        Me.btnViewTrees.Size = New System.Drawing.Size(81, 23)
        Me.btnViewTrees.TabIndex = 9
        Me.btnViewTrees.Text = "view trees"
        Me.btnViewTrees.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "FOREST ANALYSIS"
        '
        'btnCheckRisk
        '
        Me.btnCheckRisk.Location = New System.Drawing.Point(99, 386)
        Me.btnCheckRisk.Name = "btnCheckRisk"
        Me.btnCheckRisk.Size = New System.Drawing.Size(81, 35)
        Me.btnCheckRisk.TabIndex = 12
        Me.btnCheckRisk.Text = "check risk"
        Me.btnCheckRisk.UseVisualStyleBackColor = True
        '
        'btnCalculateDensity
        '
        Me.btnCalculateDensity.Location = New System.Drawing.Point(3, 386)
        Me.btnCalculateDensity.Name = "btnCalculateDensity"
        Me.btnCalculateDensity.Size = New System.Drawing.Size(75, 35)
        Me.btnCalculateDensity.TabIndex = 11
        Me.btnCalculateDensity.Text = "calculate density"
        Me.btnCalculateDensity.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(484, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 38)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "  FOREST GUARD" & Global.Microsoft.VisualBasic.ChrW(10) & "        "
        '
        'btnHarvestTrees
        '
        Me.btnHarvestTrees.Location = New System.Drawing.Point(516, 392)
        Me.btnHarvestTrees.Name = "btnHarvestTrees"
        Me.btnHarvestTrees.Size = New System.Drawing.Size(81, 23)
        Me.btnHarvestTrees.TabIndex = 14
        Me.btnHarvestTrees.Text = "harvest trees"
        Me.btnHarvestTrees.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 503)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(203, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(832, 749)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHarvestTrees)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCheckRisk)
        Me.Controls.Add(Me.btnCalculateDensity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnViewTrees)
        Me.Controls.Add(Me.btnAddTrees)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnViewForest)
        Me.Controls.Add(Me.btnRemoveForest)
        Me.Controls.Add(Me.btnCreateForest)
        Me.Controls.Add(Me.cmbSelectForest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Forest Guard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSelectForest As ComboBox
    Friend WithEvents btnCreateForest As Button
    Friend WithEvents btnRemoveForest As Button
    Friend WithEvents btnViewForest As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddTrees As Button
    Friend WithEvents btnViewTrees As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCheckRisk As Button
    Friend WithEvents btnCalculateDensity As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHarvestTrees As Button
    Friend WithEvents btnExit As Button
End Class

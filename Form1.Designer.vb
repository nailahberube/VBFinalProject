<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLavishNails
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
        Me.grpNailServices = New System.Windows.Forms.GroupBox()
        Me.radManiPediAndDesign = New System.Windows.Forms.RadioButton()
        Me.radManiAndPedi = New System.Windows.Forms.RadioButton()
        Me.radPediAndDesign = New System.Windows.Forms.RadioButton()
        Me.radManiAndDesign = New System.Windows.Forms.RadioButton()
        Me.radPedicure = New System.Windows.Forms.RadioButton()
        Me.radManicure = New System.Windows.Forms.RadioButton()
        Me.txtRewardPoints = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAddPoints = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddPoints = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.grpNailServices.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpNailServices
        '
        Me.grpNailServices.BackColor = System.Drawing.Color.MistyRose
        Me.grpNailServices.Controls.Add(Me.radManiPediAndDesign)
        Me.grpNailServices.Controls.Add(Me.radManiAndPedi)
        Me.grpNailServices.Controls.Add(Me.radPediAndDesign)
        Me.grpNailServices.Controls.Add(Me.radManiAndDesign)
        Me.grpNailServices.Controls.Add(Me.radPedicure)
        Me.grpNailServices.Controls.Add(Me.radManicure)
        Me.grpNailServices.Font = New System.Drawing.Font("Papyrus", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNailServices.ForeColor = System.Drawing.Color.Salmon
        Me.grpNailServices.Location = New System.Drawing.Point(43, 119)
        Me.grpNailServices.Name = "grpNailServices"
        Me.grpNailServices.Size = New System.Drawing.Size(387, 211)
        Me.grpNailServices.TabIndex = 0
        Me.grpNailServices.TabStop = False
        Me.grpNailServices.Text = "Nail Services"
        '
        'radManiPediAndDesign
        '
        Me.radManiPediAndDesign.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManiPediAndDesign.ForeColor = System.Drawing.Color.Salmon
        Me.radManiPediAndDesign.Location = New System.Drawing.Point(7, 177)
        Me.radManiPediAndDesign.Name = "radManiPediAndDesign"
        Me.radManiPediAndDesign.Size = New System.Drawing.Size(355, 31)
        Me.radManiPediAndDesign.TabIndex = 5
        Me.radManiPediAndDesign.TabStop = True
        Me.radManiPediAndDesign.Text = "Manicure + Pedicure + Nail Design $38" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radManiPediAndDesign.UseVisualStyleBackColor = True
        '
        'radManiAndPedi
        '
        Me.radManiAndPedi.AutoSize = True
        Me.radManiAndPedi.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManiAndPedi.ForeColor = System.Drawing.Color.Salmon
        Me.radManiAndPedi.Location = New System.Drawing.Point(7, 87)
        Me.radManiAndPedi.Name = "radManiAndPedi"
        Me.radManiAndPedi.Size = New System.Drawing.Size(227, 29)
        Me.radManiAndPedi.TabIndex = 4
        Me.radManiAndPedi.TabStop = True
        Me.radManiAndPedi.Text = "Manicure + Pedicure $25"
        Me.radManiAndPedi.UseVisualStyleBackColor = True
        '
        'radPediAndDesign
        '
        Me.radPediAndDesign.AutoSize = True
        Me.radPediAndDesign.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPediAndDesign.ForeColor = System.Drawing.Color.Salmon
        Me.radPediAndDesign.Location = New System.Drawing.Point(7, 147)
        Me.radPediAndDesign.Name = "radPediAndDesign"
        Me.radPediAndDesign.Size = New System.Drawing.Size(250, 29)
        Me.radPediAndDesign.TabIndex = 3
        Me.radPediAndDesign.TabStop = True
        Me.radPediAndDesign.Text = "Pedicure + Nail Design $20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radPediAndDesign.UseVisualStyleBackColor = True
        '
        'radManiAndDesign
        '
        Me.radManiAndDesign.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManiAndDesign.ForeColor = System.Drawing.Color.Salmon
        Me.radManiAndDesign.Location = New System.Drawing.Point(7, 117)
        Me.radManiAndDesign.Name = "radManiAndDesign"
        Me.radManiAndDesign.Size = New System.Drawing.Size(257, 32)
        Me.radManiAndDesign.TabIndex = 2
        Me.radManiAndDesign.TabStop = True
        Me.radManiAndDesign.Text = "Manicure + Nail Design $20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radManiAndDesign.UseVisualStyleBackColor = True
        '
        'radPedicure
        '
        Me.radPedicure.AutoSize = True
        Me.radPedicure.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPedicure.ForeColor = System.Drawing.Color.Salmon
        Me.radPedicure.Location = New System.Drawing.Point(7, 57)
        Me.radPedicure.Name = "radPedicure"
        Me.radPedicure.Size = New System.Drawing.Size(138, 29)
        Me.radPedicure.TabIndex = 1
        Me.radPedicure.TabStop = True
        Me.radPedicure.Text = "Pedicure $10"
        Me.radPedicure.UseVisualStyleBackColor = True
        '
        'radManicure
        '
        Me.radManicure.AutoSize = True
        Me.radManicure.Font = New System.Drawing.Font("Papyrus", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManicure.ForeColor = System.Drawing.Color.Salmon
        Me.radManicure.Location = New System.Drawing.Point(7, 26)
        Me.radManicure.Name = "radManicure"
        Me.radManicure.Size = New System.Drawing.Size(143, 29)
        Me.radManicure.TabIndex = 0
        Me.radManicure.TabStop = True
        Me.radManicure.Text = "Manicure $10"
        Me.radManicure.UseVisualStyleBackColor = True
        '
        'txtRewardPoints
        '
        Me.txtRewardPoints.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRewardPoints.ForeColor = System.Drawing.Color.Salmon
        Me.txtRewardPoints.Location = New System.Drawing.Point(660, 348)
        Me.txtRewardPoints.Name = "txtRewardPoints"
        Me.txtRewardPoints.Size = New System.Drawing.Size(51, 32)
        Me.txtRewardPoints.TabIndex = 1
        Me.txtRewardPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.MistyRose
        Me.lblHeading.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Salmon
        Me.lblHeading.Location = New System.Drawing.Point(116, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(199, 44)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Lavish Nails"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Salmon
        Me.Label2.Location = New System.Drawing.Point(480, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reward Points: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(38, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Your Total: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Salmon
        Me.Label4.Location = New System.Drawing.Point(39, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "* Services include a 15% tip"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Salmon
        Me.lblTotal.Location = New System.Drawing.Point(168, 448)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(532, 55)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "$888.88"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBFinalProject.My.Resources.Resources.OIP
        Me.PictureBox1.Location = New System.Drawing.Point(485, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(570, 395)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 33)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate "
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(677, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAddPoints
        '
        Me.lblAddPoints.Font = New System.Drawing.Font("Papyrus", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPoints.ForeColor = System.Drawing.Color.Salmon
        Me.lblAddPoints.Location = New System.Drawing.Point(467, 240)
        Me.lblAddPoints.Name = "lblAddPoints"
        Me.lblAddPoints.Size = New System.Drawing.Size(283, 55)
        Me.lblAddPoints.TabIndex = 10
        Me.lblAddPoints.Text = "Click ""Add Points"" to add all your reward points you've accumulated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAddPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Salmon
        Me.Label1.Location = New System.Drawing.Point(458, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Click ""Calculate"" to see your discount"
        '
        'btnAddPoints
        '
        Me.btnAddPoints.Location = New System.Drawing.Point(463, 395)
        Me.btnAddPoints.Name = "btnAddPoints"
        Me.btnAddPoints.Size = New System.Drawing.Size(101, 33)
        Me.btnAddPoints.TabIndex = 12
        Me.btnAddPoints.Text = "Add Points"
        Me.btnAddPoints.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Salmon
        Me.Label5.Location = New System.Drawing.Point(38, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Points:"
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPoints.ForeColor = System.Drawing.Color.Salmon
        Me.lblTotalPoints.Location = New System.Drawing.Point(168, 395)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(289, 41)
        Me.lblTotalPoints.TabIndex = 14
        '
        'frmLavishNails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.VBFinalProject.My.Resources.Resources.Baby_Pink_Sparkles
        Me.ClientSize = New System.Drawing.Size(796, 534)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAddPoints)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtRewardPoints)
        Me.Controls.Add(Me.grpNailServices)
        Me.Name = "frmLavishNails"
        Me.Text = "Lavish Nails "
        Me.grpNailServices.ResumeLayout(False)
        Me.grpNailServices.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpNailServices As GroupBox
    Friend WithEvents radManiPediAndDesign As RadioButton
    Friend WithEvents radManiAndPedi As RadioButton
    Friend WithEvents radPediAndDesign As RadioButton
    Friend WithEvents radManiAndDesign As RadioButton
    Friend WithEvents radPedicure As RadioButton
    Friend WithEvents radManicure As RadioButton
    Friend WithEvents txtRewardPoints As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAddPoints As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddPoints As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPoints As Label
End Class

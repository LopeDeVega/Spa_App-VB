<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActivity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActivity))
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.lblMemberServices = New System.Windows.Forms.Label()
        Me.lblMembershipTypes = New System.Windows.Forms.Label()
        Me.ComboBoxMembership = New System.Windows.Forms.ComboBox()
        Me.lblInformalPanel = New System.Windows.Forms.Label()
        Me.btnBackForm4 = New System.Windows.Forms.Button()
        Me.RichTextBoxInformationPanel = New System.Windows.Forms.RichTextBox()
        Me.chbJacuzzi = New System.Windows.Forms.CheckBox()
        Me.chbSauna = New System.Windows.Forms.CheckBox()
        Me.chbSwPool = New System.Windows.Forms.CheckBox()
        Me.chbFtSuit = New System.Windows.Forms.CheckBox()
        Me.chbMassage = New System.Windows.Forms.CheckBox()
        Me.chbTrainer = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.btnSilver = New System.Windows.Forms.Button()
        Me.btnBonze = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnRetun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.BackColor = System.Drawing.Color.White
        Me.lblActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblActivity.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.ForeColor = System.Drawing.Color.Black
        Me.lblActivity.Location = New System.Drawing.Point(55, 173)
        Me.lblActivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(113, 35)
        Me.lblActivity.TabIndex = 2
        Me.lblActivity.Text = "Activity "
        '
        'lblMemberServices
        '
        Me.lblMemberServices.AutoSize = True
        Me.lblMemberServices.BackColor = System.Drawing.Color.White
        Me.lblMemberServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberServices.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberServices.ForeColor = System.Drawing.Color.Black
        Me.lblMemberServices.Location = New System.Drawing.Point(368, 215)
        Me.lblMemberServices.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberServices.Name = "lblMemberServices"
        Me.lblMemberServices.Size = New System.Drawing.Size(190, 35)
        Me.lblMemberServices.TabIndex = 4
        Me.lblMemberServices.Text = "Member Services"
        '
        'lblMembershipTypes
        '
        Me.lblMembershipTypes.AutoSize = True
        Me.lblMembershipTypes.BackColor = System.Drawing.Color.White
        Me.lblMembershipTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMembershipTypes.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipTypes.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipTypes.Location = New System.Drawing.Point(9, 9)
        Me.lblMembershipTypes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMembershipTypes.Name = "lblMembershipTypes"
        Me.lblMembershipTypes.Size = New System.Drawing.Size(417, 35)
        Me.lblMembershipTypes.TabIndex = 6
        Me.lblMembershipTypes.Text = "Membership Types and Monthly Prize"
        '
        'ComboBoxMembership
        '
        Me.ComboBoxMembership.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMembership.ForeColor = System.Drawing.Color.ForestGreen
        Me.ComboBoxMembership.FormattingEnabled = True
        Me.ComboBoxMembership.Items.AddRange(New Object() {"Bronze - £ 10.00 per month", "Silver- £ 20.00 per month" & Global.Microsoft.VisualBasic.ChrW(9), "Gold - £ 30.00 per month"})
        Me.ComboBoxMembership.Location = New System.Drawing.Point(80, 49)
        Me.ComboBoxMembership.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMembership.Name = "ComboBoxMembership"
        Me.ComboBoxMembership.Size = New System.Drawing.Size(236, 24)
        Me.ComboBoxMembership.TabIndex = 7
        '
        'lblInformalPanel
        '
        Me.lblInformalPanel.AutoSize = True
        Me.lblInformalPanel.BackColor = System.Drawing.Color.White
        Me.lblInformalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInformalPanel.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblInformalPanel.ForeColor = System.Drawing.Color.Black
        Me.lblInformalPanel.Location = New System.Drawing.Point(268, 390)
        Me.lblInformalPanel.Name = "lblInformalPanel"
        Me.lblInformalPanel.Size = New System.Drawing.Size(210, 35)
        Me.lblInformalPanel.TabIndex = 8
        Me.lblInformalPanel.Text = "Information Panel"
        '
        'btnBackForm4
        '
        Me.btnBackForm4.BackColor = System.Drawing.Color.White
        Me.btnBackForm4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackForm4.ForeColor = System.Drawing.Color.Black
        Me.btnBackForm4.Location = New System.Drawing.Point(820, 338)
        Me.btnBackForm4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackForm4.Name = "btnBackForm4"
        Me.btnBackForm4.Size = New System.Drawing.Size(147, 59)
        Me.btnBackForm4.TabIndex = 1
        Me.btnBackForm4.Text = "Back to Main Menu"
        Me.btnBackForm4.UseVisualStyleBackColor = False
        '
        'RichTextBoxInformationPanel
        '
        Me.RichTextBoxInformationPanel.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBoxInformationPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.RichTextBoxInformationPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBoxInformationPanel.Location = New System.Drawing.Point(66, 440)
        Me.RichTextBoxInformationPanel.Name = "RichTextBoxInformationPanel"
        Me.RichTextBoxInformationPanel.Size = New System.Drawing.Size(586, 161)
        Me.RichTextBoxInformationPanel.TabIndex = 9
        Me.RichTextBoxInformationPanel.Text = resources.GetString("RichTextBoxInformationPanel.Text")
        '
        'chbJacuzzi
        '
        Me.chbJacuzzi.AutoSize = True
        Me.chbJacuzzi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbJacuzzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chbJacuzzi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chbJacuzzi.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbJacuzzi.ForeColor = System.Drawing.Color.Black
        Me.chbJacuzzi.Location = New System.Drawing.Point(26, 234)
        Me.chbJacuzzi.Name = "chbJacuzzi"
        Me.chbJacuzzi.Size = New System.Drawing.Size(233, 26)
        Me.chbJacuzzi.TabIndex = 10
        Me.chbJacuzzi.Text = "Jacuzzi - £2.00 per session"
        Me.chbJacuzzi.UseVisualStyleBackColor = False
        '
        'chbSauna
        '
        Me.chbSauna.AutoSize = True
        Me.chbSauna.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbSauna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chbSauna.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSauna.ForeColor = System.Drawing.Color.Black
        Me.chbSauna.Location = New System.Drawing.Point(26, 275)
        Me.chbSauna.Name = "chbSauna"
        Me.chbSauna.Size = New System.Drawing.Size(228, 26)
        Me.chbSauna.TabIndex = 14
        Me.chbSauna.Text = "Sauna  - £2.00 per session"
        Me.chbSauna.UseVisualStyleBackColor = False
        '
        'chbSwPool
        '
        Me.chbSwPool.AutoSize = True
        Me.chbSwPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbSwPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chbSwPool.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSwPool.ForeColor = System.Drawing.Color.Black
        Me.chbSwPool.Location = New System.Drawing.Point(26, 315)
        Me.chbSwPool.Name = "chbSwPool"
        Me.chbSwPool.Size = New System.Drawing.Size(301, 26)
        Me.chbSwPool.TabIndex = 15
        Me.chbSwPool.Text = "Swimming Pool  - £2.00 per session"
        Me.chbSwPool.UseVisualStyleBackColor = False
        '
        'chbFtSuit
        '
        Me.chbFtSuit.AutoSize = True
        Me.chbFtSuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbFtSuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chbFtSuit.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFtSuit.ForeColor = System.Drawing.Color.Black
        Me.chbFtSuit.Location = New System.Drawing.Point(26, 356)
        Me.chbFtSuit.Name = "chbFtSuit"
        Me.chbFtSuit.Size = New System.Drawing.Size(198, 26)
        Me.chbFtSuit.TabIndex = 16
        Me.chbFtSuit.Text = "Fitness Suite - FREE"
        Me.chbFtSuit.UseVisualStyleBackColor = False
        '
        'chbMassage
        '
        Me.chbMassage.AutoSize = True
        Me.chbMassage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbMassage.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMassage.Location = New System.Drawing.Point(368, 315)
        Me.chbMassage.Name = "chbMassage"
        Me.chbMassage.Size = New System.Drawing.Size(399, 26)
        Me.chbMassage.TabIndex = 17
        Me.chbMassage.Text = "Sports Massage* - £20 half hour (Not Discount)"
        Me.chbMassage.UseVisualStyleBackColor = False
        '
        'chbTrainer
        '
        Me.chbTrainer.AutoSize = True
        Me.chbTrainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chbTrainer.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTrainer.Location = New System.Drawing.Point(368, 275)
        Me.chbTrainer.Name = "chbTrainer"
        Me.chbTrainer.Size = New System.Drawing.Size(459, 26)
        Me.chbTrainer.TabIndex = 18
        Me.chbTrainer.Text = "Personal Trainer Session*  - £20 A hour (Not Discount)"
        Me.chbTrainer.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRetun)
        Me.GroupBox1.Controls.Add(Me.btnGold)
        Me.GroupBox1.Controls.Add(Me.btnSilver)
        Me.GroupBox1.Controls.Add(Me.btnBonze)
        Me.GroupBox1.Controls.Add(Me.lstBox)
        Me.GroupBox1.Controls.Add(Me.lblCheck)
        Me.GroupBox1.Controls.Add(Me.chbTrainer)
        Me.GroupBox1.Controls.Add(Me.chbMassage)
        Me.GroupBox1.Controls.Add(Me.chbFtSuit)
        Me.GroupBox1.Controls.Add(Me.chbSwPool)
        Me.GroupBox1.Controls.Add(Me.chbSauna)
        Me.GroupBox1.Controls.Add(Me.chbJacuzzi)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxInformationPanel)
        Me.GroupBox1.Controls.Add(Me.btnBackForm4)
        Me.GroupBox1.Controls.Add(Me.lblInformalPanel)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMembership)
        Me.GroupBox1.Controls.Add(Me.lblMembershipTypes)
        Me.GroupBox1.Controls.Add(Me.lblMemberServices)
        Me.GroupBox1.Controls.Add(Me.lblActivity)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1101, 627)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "£2.00 per session"
        '
        'btnGold
        '
        Me.btnGold.BackColor = System.Drawing.Color.Gold
        Me.btnGold.Location = New System.Drawing.Point(606, 183)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(84, 32)
        Me.btnGold.TabIndex = 23
        Me.btnGold.Text = "Gold"
        Me.btnGold.UseVisualStyleBackColor = False
        '
        'btnSilver
        '
        Me.btnSilver.BackColor = System.Drawing.Color.Silver
        Me.btnSilver.Location = New System.Drawing.Point(605, 133)
        Me.btnSilver.Name = "btnSilver"
        Me.btnSilver.Size = New System.Drawing.Size(86, 39)
        Me.btnSilver.TabIndex = 22
        Me.btnSilver.Text = "Silver"
        Me.btnSilver.UseVisualStyleBackColor = False
        '
        'btnBonze
        '
        Me.btnBonze.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBonze.Location = New System.Drawing.Point(602, 85)
        Me.btnBonze.Name = "btnBonze"
        Me.btnBonze.Size = New System.Drawing.Size(90, 34)
        Me.btnBonze.TabIndex = 21
        Me.btnBonze.Text = "Bronze"
        Me.btnBonze.UseVisualStyleBackColor = False
        '
        'lstBox
        '
        Me.lstBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstBox.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.ForeColor = System.Drawing.Color.Blue
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 19
        Me.lstBox.Location = New System.Drawing.Point(729, 58)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(286, 194)
        Me.lstBox.TabIndex = 20
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.lblCheck.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheck.Location = New System.Drawing.Point(771, 15)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(196, 25)
        Me.lblCheck.TabIndex = 19
        Me.lblCheck.Text = "Check Price Activities"
        '
        'btnRetun
        '
        Me.btnRetun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRetun.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetun.Location = New System.Drawing.Point(820, 429)
        Me.btnRetun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRetun.Name = "btnRetun"
        Me.btnRetun.Size = New System.Drawing.Size(151, 75)
        Me.btnRetun.TabIndex = 24
        Me.btnRetun.Text = "Help and more Information"
        Me.btnRetun.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 66)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mark the activities and click on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bronze,  Silver or Gold " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " The price will be d" & _
            "isplayed in the box."
        '
        'FormActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1101, 627)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormActivity"
        Me.Text = "Activities and Prices"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents lblMemberServices As System.Windows.Forms.Label
    Friend WithEvents lblMembershipTypes As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMembership As System.Windows.Forms.ComboBox
    Friend WithEvents lblInformalPanel As System.Windows.Forms.Label
    Friend WithEvents btnBackForm4 As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxInformationPanel As System.Windows.Forms.RichTextBox
    Friend WithEvents chbJacuzzi As System.Windows.Forms.CheckBox
    Friend WithEvents chbSauna As System.Windows.Forms.CheckBox
    Friend WithEvents chbSwPool As System.Windows.Forms.CheckBox
    Friend WithEvents chbFtSuit As System.Windows.Forms.CheckBox
    Friend WithEvents chbMassage As System.Windows.Forms.CheckBox
    Friend WithEvents chbTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents lstBox As System.Windows.Forms.ListBox
    Friend WithEvents btnGold As System.Windows.Forms.Button
    Friend WithEvents btnSilver As System.Windows.Forms.Button
    Friend WithEvents btnBonze As System.Windows.Forms.Button
    Friend WithEvents btnRetun As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

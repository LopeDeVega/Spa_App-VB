<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMem))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblMembershipType = New System.Windows.Forms.Label()
        Me.lblMembershipNo = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblPstCode = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMembershipN = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtMobileN = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtMembershipT = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReturn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(781, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(128, 59)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Back to Main Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblMembershipType
        '
        Me.lblMembershipType.AutoSize = True
        Me.lblMembershipType.BackColor = System.Drawing.Color.White
        Me.lblMembershipType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipType.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblMembershipType.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipType.Location = New System.Drawing.Point(359, 205)
        Me.lblMembershipType.Name = "lblMembershipType"
        Me.lblMembershipType.Size = New System.Drawing.Size(215, 26)
        Me.lblMembershipType.TabIndex = 41
        Me.lblMembershipType.Text = "Membership Type."
        '
        'lblMembershipNo
        '
        Me.lblMembershipNo.AutoSize = True
        Me.lblMembershipNo.BackColor = System.Drawing.Color.White
        Me.lblMembershipNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipNo.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblMembershipNo.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipNo.Location = New System.Drawing.Point(12, 53)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(194, 26)
        Me.lblMembershipNo.TabIndex = 40
        Me.lblMembershipNo.Text = "Membership No."
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.White
        Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEndDate.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblEndDate.ForeColor = System.Drawing.Color.Black
        Me.lblEndDate.Location = New System.Drawing.Point(457, 139)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(117, 26)
        Me.lblEndDate.TabIndex = 39
        Me.lblEndDate.Text = "End Date"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.White
        Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartDate.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblStartDate.ForeColor = System.Drawing.Color.Black
        Me.lblStartDate.Location = New System.Drawing.Point(443, 78)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(131, 26)
        Me.lblStartDate.TabIndex = 38
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.White
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(400, 267)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(174, 26)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email Address"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.BackColor = System.Drawing.Color.White
        Me.lblMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobile.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.ForeColor = System.Drawing.Color.Black
        Me.lblMobile.Location = New System.Drawing.Point(12, 272)
        Me.lblMobile.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(132, 26)
        Me.lblMobile.TabIndex = 36
        Me.lblMobile.Text = "Mobile No:"
        '
        'lblPstCode
        '
        Me.lblPstCode.AutoSize = True
        Me.lblPstCode.BackColor = System.Drawing.Color.White
        Me.lblPstCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPstCode.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPstCode.ForeColor = System.Drawing.Color.Black
        Me.lblPstCode.Location = New System.Drawing.Point(12, 215)
        Me.lblPstCode.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPstCode.Name = "lblPstCode"
        Me.lblPstCode.Size = New System.Drawing.Size(114, 26)
        Me.lblPstCode.TabIndex = 35
        Me.lblPstCode.Text = "Postcode:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(12, 164)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(109, 26)
        Me.lblAddress.TabIndex = 34
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(12, 111)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 26)
        Me.lblName.TabIndex = 33
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Location = New System.Drawing.Point(149, 117)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 20)
        Me.txtName.TabIndex = 42
        '
        'txtMembershipN
        '
        Me.txtMembershipN.ForeColor = System.Drawing.Color.Blue
        Me.txtMembershipN.Location = New System.Drawing.Point(226, 59)
        Me.txtMembershipN.Name = "txtMembershipN"
        Me.txtMembershipN.Size = New System.Drawing.Size(74, 20)
        Me.txtMembershipN.TabIndex = 43
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevious.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnPrevious.Location = New System.Drawing.Point(126, 357)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 40)
        Me.btnPrevious.TabIndex = 44
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnNext.Location = New System.Drawing.Point(285, 357)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 40)
        Me.btnNext.TabIndex = 45
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.ForeColor = System.Drawing.Color.Blue
        Me.txtAddress.Location = New System.Drawing.Point(149, 169)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 46
        '
        'txtPostcode
        '
        Me.txtPostcode.ForeColor = System.Drawing.Color.Blue
        Me.txtPostcode.Location = New System.Drawing.Point(149, 221)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(142, 20)
        Me.txtPostcode.TabIndex = 47
        '
        'txtMobileN
        '
        Me.txtMobileN.ForeColor = System.Drawing.Color.Blue
        Me.txtMobileN.Location = New System.Drawing.Point(152, 276)
        Me.txtMobileN.Name = "txtMobileN"
        Me.txtMobileN.Size = New System.Drawing.Size(139, 20)
        Me.txtMobileN.TabIndex = 48
        '
        'txtStartDate
        '
        Me.txtStartDate.ForeColor = System.Drawing.Color.Blue
        Me.txtStartDate.Location = New System.Drawing.Point(598, 84)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(124, 20)
        Me.txtStartDate.TabIndex = 49
        '
        'txtEndDate
        '
        Me.txtEndDate.ForeColor = System.Drawing.Color.Blue
        Me.txtEndDate.Location = New System.Drawing.Point(598, 136)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(124, 20)
        Me.txtEndDate.TabIndex = 50
        '
        'txtMembershipT
        '
        Me.txtMembershipT.ForeColor = System.Drawing.Color.Blue
        Me.txtMembershipT.Location = New System.Drawing.Point(598, 209)
        Me.txtMembershipT.Name = "txtMembershipT"
        Me.txtMembershipT.Size = New System.Drawing.Size(124, 20)
        Me.txtMembershipT.TabIndex = 51
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.Blue
        Me.txtEmailAddress.Location = New System.Drawing.Point(598, 270)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(176, 20)
        Me.txtEmailAddress.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(423, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Enter a new member"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(683, 357)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 40)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRead.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(809, 357)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(100, 40)
        Me.btnRead.TabIndex = 55
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnhelp.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.Location = New System.Drawing.Point(768, 90)
        Me.btnhelp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(140, 64)
        Me.btnhelp.TabIndex = 56
        Me.btnhelp.Text = "Help and more Information"
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'FormMem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(921, 449)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtMembershipT)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.txtMobileN)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtMembershipN)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMembershipType)
        Me.Controls.Add(Me.lblMembershipNo)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblPstCode)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "FormMem"
        Me.Text = "Member "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents lblMembershipType As System.Windows.Forms.Label
    Friend WithEvents lblMembershipNo As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblPstCode As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMembershipN As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileN As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtMembershipT As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnhelp As System.Windows.Forms.Button
End Class

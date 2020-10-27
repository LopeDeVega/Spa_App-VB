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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblBankHealth = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassWord = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 144)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPassword.Location = New System.Drawing.Point(93, 237)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(166, 20)
        Me.txtPassword.TabIndex = 1
        '
        'lblBankHealth
        '
        Me.lblBankHealth.AutoSize = True
        Me.lblBankHealth.BackColor = System.Drawing.Color.PowderBlue
        Me.lblBankHealth.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBankHealth.ForeColor = System.Drawing.Color.Blue
        Me.lblBankHealth.Location = New System.Drawing.Point(12, 9)
        Me.lblBankHealth.Name = "lblBankHealth"
        Me.lblBankHealth.Size = New System.Drawing.Size(460, 36)
        Me.lblBankHealth.TabIndex = 4
        Me.lblBankHealth.Text = "Welcome To The Bank Health Spa Granada"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Black
        Me.btnLogIn.Location = New System.Drawing.Point(278, 172)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(209, 42)
        Me.btnLogIn.TabIndex = 6
        Me.btnLogIn.Text = "Press to LogIn"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BackColor = System.Drawing.Color.PowderBlue
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.ImageKey = "(none)"
        Me.lblName.Location = New System.Drawing.Point(12, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(148, 33)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Enter Name"
        '
        'lblPassWord
        '
        Me.lblPassWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassWord.BackColor = System.Drawing.Color.PowderBlue
        Me.lblPassWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassWord.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassWord.ImageKey = "(none)"
        Me.lblPassWord.Location = New System.Drawing.Point(12, 176)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(189, 33)
        Me.lblPassWord.TabIndex = 8
        Me.lblPassWord.Text = "Enter Password"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnExit.Location = New System.Drawing.Point(494, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 44)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(601, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblBankHealth)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "LogIn  Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblBankHealth As System.Windows.Forms.Label
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPassWord As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

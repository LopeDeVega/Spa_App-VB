<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainMenu))
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnEditDetails = New System.Windows.Forms.Button()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMainMenu
        '
        Me.lblMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMainMenu.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.Blue
        Me.lblMainMenu.Location = New System.Drawing.Point(251, 9)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(299, 36)
        Me.lblMainMenu.TabIndex = 0
        Me.lblMainMenu.Text = "Welcome to the Main Menu"
        '
        'btnEditDetails
        '
        Me.btnEditDetails.BackColor = System.Drawing.Color.FloralWhite
        Me.btnEditDetails.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditDetails.ForeColor = System.Drawing.Color.Black
        Me.btnEditDetails.Location = New System.Drawing.Point(224, 171)
        Me.btnEditDetails.Name = "btnEditDetails"
        Me.btnEditDetails.Size = New System.Drawing.Size(233, 76)
        Me.btnEditDetails.TabIndex = 1
        Me.btnEditDetails.Text = "Activities and Prices "
        Me.btnEditDetails.UseVisualStyleBackColor = False
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.FloralWhite
        Me.btnhelp.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnhelp.ForeColor = System.Drawing.Color.Black
        Me.btnhelp.Location = New System.Drawing.Point(55, 298)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(233, 76)
        Me.btnhelp.TabIndex = 3
        Me.btnhelp.Text = "Help and more Information"
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.FloralWhite
        Me.btnMembers.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnMembers.ForeColor = System.Drawing.Color.Black
        Me.btnMembers.Location = New System.Drawing.Point(55, 48)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(233, 72)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Members"
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(806, 386)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnEditDetails)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Name = "FormMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents btnEditDetails As System.Windows.Forms.Button
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
End Class

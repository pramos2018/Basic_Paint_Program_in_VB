<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicPaintApp
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
        Me.gBoxShortCuts = New System.Windows.Forms.GroupBox()
        Me.gBoxSetup = New System.Windows.Forms.GroupBox()
        Me.penSize = New System.Windows.Forms.NumericUpDown()
        Me.ckBoxFill = New System.Windows.Forms.CheckBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblPenSize = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.gBoxMenus = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDropDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapDropBox = New System.Windows.Forms.ToolStripComboBox()
        Me.lblText = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInput = New System.Windows.Forms.ToolStripTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gBoxShortCuts.SuspendLayout()
        Me.gBoxSetup.SuspendLayout()
        CType(Me.penSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxMenus.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBoxShortCuts
        '
        Me.gBoxShortCuts.Controls.Add(Me.gBoxSetup)
        Me.gBoxShortCuts.Controls.Add(Me.btnExit)
        Me.gBoxShortCuts.Controls.Add(Me.btnColor)
        Me.gBoxShortCuts.Controls.Add(Me.btnFont)
        Me.gBoxShortCuts.Controls.Add(Me.btnPaste)
        Me.gBoxShortCuts.Controls.Add(Me.btnCopy)
        Me.gBoxShortCuts.Controls.Add(Me.btnCut)
        Me.gBoxShortCuts.Location = New System.Drawing.Point(21, 12)
        Me.gBoxShortCuts.Name = "gBoxShortCuts"
        Me.gBoxShortCuts.Size = New System.Drawing.Size(83, 479)
        Me.gBoxShortCuts.TabIndex = 0
        Me.gBoxShortCuts.TabStop = False
        Me.gBoxShortCuts.Text = "ShortCuts"
        '
        'gBoxSetup
        '
        Me.gBoxSetup.Controls.Add(Me.penSize)
        Me.gBoxSetup.Controls.Add(Me.ckBoxFill)
        Me.gBoxSetup.Controls.Add(Me.txtSize)
        Me.gBoxSetup.Controls.Add(Me.lblShape)
        Me.gBoxSetup.Controls.Add(Me.lblSize)
        Me.gBoxSetup.Controls.Add(Me.lblPenSize)
        Me.gBoxSetup.Location = New System.Drawing.Point(6, 253)
        Me.gBoxSetup.Name = "gBoxSetup"
        Me.gBoxSetup.Size = New System.Drawing.Size(77, 153)
        Me.gBoxSetup.TabIndex = 1
        Me.gBoxSetup.TabStop = False
        Me.gBoxSetup.Text = "Setup"
        '
        'penSize
        '
        Me.penSize.Location = New System.Drawing.Point(10, 47)
        Me.penSize.Name = "penSize"
        Me.penSize.Size = New System.Drawing.Size(48, 20)
        Me.penSize.TabIndex = 5
        '
        'ckBoxFill
        '
        Me.ckBoxFill.AutoSize = True
        Me.ckBoxFill.Location = New System.Drawing.Point(8, 131)
        Me.ckBoxFill.Name = "ckBoxFill"
        Me.ckBoxFill.Size = New System.Drawing.Size(38, 17)
        Me.ckBoxFill.TabIndex = 4
        Me.ckBoxFill.Text = "Fill"
        Me.ckBoxFill.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(8, 85)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(50, 20)
        Me.txtSize.TabIndex = 3
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(6, 111)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 2
        Me.lblShape.Text = "Shape:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(6, 69)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "Size:"
        '
        'lblPenSize
        '
        Me.lblPenSize.AutoSize = True
        Me.lblPenSize.Location = New System.Drawing.Point(6, 25)
        Me.lblPenSize.Name = "lblPenSize"
        Me.lblPenSize.Size = New System.Drawing.Size(52, 13)
        Me.lblPenSize.TabIndex = 0
        Me.lblPenSize.Text = "Pen Size:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(16, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 32)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(16, 204)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(54, 32)
        Me.btnColor.TabIndex = 0
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(16, 158)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(54, 32)
        Me.btnFont.TabIndex = 0
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(16, 112)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(54, 32)
        Me.btnPaste.TabIndex = 0
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(16, 66)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(54, 32)
        Me.btnCopy.TabIndex = 0
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.Location = New System.Drawing.Point(16, 20)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(54, 32)
        Me.btnCut.TabIndex = 0
        Me.btnCut.Text = "Cut"
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'gBoxMenus
        '
        Me.gBoxMenus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gBoxMenus.Controls.Add(Me.MenuStrip1)
        Me.gBoxMenus.Location = New System.Drawing.Point(125, 12)
        Me.gBoxMenus.Name = "gBoxMenus"
        Me.gBoxMenus.Size = New System.Drawing.Size(541, 52)
        Me.gBoxMenus.TabIndex = 1
        Me.gBoxMenus.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenu, Me.helpMenu, Me.clearMenu, Me.lblDropDown, Me.ShapDropBox, Me.lblText, Me.txtInput})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(535, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fileMenu
        '
        Me.fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.SaveFileToolStripMenuItem, Me.SaveFileAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.fileMenu.Name = "fileMenu"
        Me.fileMenu.Size = New System.Drawing.Size(37, 23)
        Me.fileMenu.Text = "&File"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewFileToolStripMenuItem.Text = "&New File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenFileToolStripMenuItem.Text = "&Open File"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveFileToolStripMenuItem.Text = "&Save File"
        '
        'SaveFileAsToolStripMenuItem
        '
        Me.SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem"
        Me.SaveFileAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveFileAsToolStripMenuItem.Text = "&Save File As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'helpMenu
        '
        Me.helpMenu.Name = "helpMenu"
        Me.helpMenu.Size = New System.Drawing.Size(52, 23)
        Me.helpMenu.Text = "&About"
        '
        'clearMenu
        '
        Me.clearMenu.Name = "clearMenu"
        Me.clearMenu.Size = New System.Drawing.Size(46, 23)
        Me.clearMenu.Text = "&Clear"
        '
        'lblDropDown
        '
        Me.lblDropDown.Name = "lblDropDown"
        Me.lblDropDown.Size = New System.Drawing.Size(54, 23)
        Me.lblDropDown.Text = "Shape:"
        '
        'ShapDropBox
        '
        Me.ShapDropBox.Name = "ShapDropBox"
        Me.ShapDropBox.Size = New System.Drawing.Size(100, 23)
        '
        'lblText
        '
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(44, 23)
        Me.lblText.Text = "Text:"
        '
        'txtInput
        '
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(175, 23)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(125, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 384)
        Me.Panel1.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(134, 75)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(128, 13)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Selected Shape: Drawing"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 503)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gBoxMenus)
        Me.Controls.Add(Me.gBoxShortCuts)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Basic Paint Program"
        Me.gBoxShortCuts.ResumeLayout(False)
        Me.gBoxSetup.ResumeLayout(False)
        Me.gBoxSetup.PerformLayout()
        CType(Me.penSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxMenus.ResumeLayout(False)
        Me.gBoxMenus.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gBoxShortCuts As System.Windows.Forms.GroupBox
    Friend WithEvents gBoxMenus As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gBoxSetup As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents penSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents ckBoxFill As System.Windows.Forms.CheckBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents lblShape As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblPenSize As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents fileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clearMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDropDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapDropBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtInput As System.Windows.Forms.ToolStripTextBox
End Class

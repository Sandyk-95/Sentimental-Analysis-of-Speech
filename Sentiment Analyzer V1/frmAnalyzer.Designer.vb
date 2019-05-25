<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyzer
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
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.picSideBar = New System.Windows.Forms.PictureBox()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnAudio = New System.Windows.Forms.Button()
        Me.OfdTxt = New System.Windows.Forms.OpenFileDialog()
        Me.OfdWav = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlSideBar.SuspendLayout()
        CType(Me.picSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlSideBar.Controls.Add(Me.btnAbout)
        Me.pnlSideBar.Controls.Add(Me.btnLogOut)
        Me.pnlSideBar.Controls.Add(Me.picSideBar)
        Me.pnlSideBar.Controls.Add(Me.txtUserName)
        Me.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideBar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 29)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(202, 464)
        Me.pnlSideBar.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(20, 198)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(162, 33)
        Me.btnAbout.TabIndex = 24
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(20, 264)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(162, 33)
        Me.btnLogOut.TabIndex = 23
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'picSideBar
        '
        Me.picSideBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSideBar.BackColor = System.Drawing.Color.Transparent
        Me.picSideBar.Image = Global.Sentiment_Analyzer_V1.My.Resources.Resources.three_line_1_48x50
        Me.picSideBar.Location = New System.Drawing.Point(166, 6)
        Me.picSideBar.Name = "picSideBar"
        Me.picSideBar.Size = New System.Drawing.Size(34, 33)
        Me.picSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSideBar.TabIndex = 4
        Me.picSideBar.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(18, 140)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(167, 26)
        Me.txtUserName.TabIndex = 2
        Me.txtUserName.Text = "User Name"
        Me.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.btnClose)
        Me.pnlTopBar.Controls.Add(Me.Label1)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.ForeColor = System.Drawing.Color.White
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(593, 29)
        Me.pnlTopBar.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(560, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 33)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sentiment Analyzer"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.StatusStrip1)
        Me.pnlMain.Controls.Add(Me.btnAnalyze)
        Me.pnlMain.Controls.Add(Me.txtText)
        Me.pnlMain.Controls.Add(Me.btnText)
        Me.pnlMain.Controls.Add(Me.btnAudio)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMain.Location = New System.Drawing.Point(202, 29)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(391, 464)
        Me.pnlMain.TabIndex = 2
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalyze.Image = Global.Sentiment_Analyzer_V1.My.Resources.Resources.analyze5_48x50
        Me.btnAnalyze.Location = New System.Drawing.Point(231, 338)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(147, 61)
        Me.btnAnalyze.TabIndex = 12
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtText.Location = New System.Drawing.Point(21, 167)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtText.Size = New System.Drawing.Size(360, 151)
        Me.txtText.TabIndex = 11
        Me.txtText.Text = "Enter your text here."
        '
        'btnText
        '
        Me.btnText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnText.Image = Global.Sentiment_Analyzer_V1.My.Resources.Resources.text_48x50
        Me.btnText.Location = New System.Drawing.Point(256, 66)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(122, 77)
        Me.btnText.TabIndex = 10
        Me.btnText.Text = "Text"
        Me.btnText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnAudio
        '
        Me.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAudio.Image = Global.Sentiment_Analyzer_V1.My.Resources.Resources.Mic1_512_48x50
        Me.btnAudio.Location = New System.Drawing.Point(21, 66)
        Me.btnAudio.Name = "btnAudio"
        Me.btnAudio.Size = New System.Drawing.Size(122, 77)
        Me.btnAudio.TabIndex = 9
        Me.btnAudio.Text = "Audio"
        Me.btnAudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAudio.UseVisualStyleBackColor = True
        '
        'OfdTxt
        '
        Me.OfdTxt.FileName = "OpenFileDialog1"
        Me.OfdTxt.Filter = "Text Files|*.txt"
        Me.OfdTxt.Title = "Open Text File"
        '
        'OfdWav
        '
        Me.OfdWav.FileName = "OpenFileDialog1"
        Me.OfdWav.Filter = "Wav Files|*.wav"
        Me.OfdWav.Title = "Open Wav Audio File"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 442)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslabel
        '
        Me.tsslabel.Name = "tsslabel"
        Me.tsslabel.Size = New System.Drawing.Size(0, 17)
        Me.tsslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAnalyzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 493)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSideBar)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmAnalyzer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sentiment Analyzer"
        Me.pnlSideBar.ResumeLayout(False)
        CType(Me.picSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSideBar As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picSideBar As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserName As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents btnAudio As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents OfdTxt As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OfdWav As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslabel As System.Windows.Forms.ToolStripStatusLabel
End Class

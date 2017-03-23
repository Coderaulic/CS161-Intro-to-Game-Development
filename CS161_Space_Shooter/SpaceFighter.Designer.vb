<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceFighter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpaceFighter))
        Me.pnlGameSpace = New System.Windows.Forms.Panel()
        Me.pnlFlash = New System.Windows.Forms.Panel()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.btnFullScreen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChgBckgrnd = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlContainAll = New System.Windows.Forms.Panel()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblActualHighScore = New System.Windows.Forms.Label()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.lblDifficultyText = New System.Windows.Forms.Label()
        Me.grpAudio = New System.Windows.Forms.GroupBox()
        Me.lblAudioSFXValue = New System.Windows.Forms.Label()
        Me.lblAudioMusicValue = New System.Windows.Forms.Label()
        Me.lblAudioMasterValue = New System.Windows.Forms.Label()
        Me.lblAudioSFX = New System.Windows.Forms.Label()
        Me.lblAudioMusic = New System.Windows.Forms.Label()
        Me.lblAudioMaster = New System.Windows.Forms.Label()
        Me.hsbAudioSFX = New System.Windows.Forms.HScrollBar()
        Me.hsbAudioMusic = New System.Windows.Forms.HScrollBar()
        Me.hsbAudioMaster = New System.Windows.Forms.HScrollBar()
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.btnClearHistory = New System.Windows.Forms.Button()
        Me.radDifficultyExtreme = New System.Windows.Forms.RadioButton()
        Me.radDifficultyHard = New System.Windows.Forms.RadioButton()
        Me.radDifficultyMedium = New System.Windows.Forms.RadioButton()
        Me.radDifficultyEasy = New System.Windows.Forms.RadioButton()
        Me.lblGameOption = New System.Windows.Forms.Label()
        Me.pnlScore = New System.Windows.Forms.Panel()
        Me.picFighterHealth = New System.Windows.Forms.PictureBox()
        Me.picBossHealth = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblGameUI = New System.Windows.Forms.Label()
        Me.wmpBGMusic = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpButtonClicks = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpShooting = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpDamage = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpHealth = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpMenuBG = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpBossBG = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlMultiUseScreen = New System.Windows.Forms.Panel()
        Me.btnTitleScreen = New System.Windows.Forms.Button()
        Me.wmpMenuBG2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlGameSpace.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.pnlContainAll.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.grpAudio.SuspendLayout()
        Me.grpDifficulty.SuspendLayout()
        Me.pnlScore.SuspendLayout()
        CType(Me.picFighterHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpBGMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpButtonClicks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpShooting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpMenuBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpBossBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMultiUseScreen.SuspendLayout()
        CType(Me.wmpMenuBG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGameSpace
        '
        Me.pnlGameSpace.BackColor = System.Drawing.Color.Transparent
        Me.pnlGameSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlGameSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGameSpace.Controls.Add(Me.pnlFlash)
        Me.pnlGameSpace.Location = New System.Drawing.Point(8, 57)
        Me.pnlGameSpace.Name = "pnlGameSpace"
        Me.pnlGameSpace.Size = New System.Drawing.Size(600, 500)
        Me.pnlGameSpace.TabIndex = 1
        '
        'pnlFlash
        '
        Me.pnlFlash.Location = New System.Drawing.Point(-5, -1)
        Me.pnlFlash.Name = "pnlFlash"
        Me.pnlFlash.Size = New System.Drawing.Size(605, 500)
        Me.pnlFlash.TabIndex = 5
        Me.pnlFlash.Visible = False
        '
        'grpControls
        '
        Me.grpControls.BackColor = System.Drawing.Color.Transparent
        Me.grpControls.Controls.Add(Me.btnFullScreen)
        Me.grpControls.Controls.Add(Me.btnExit)
        Me.grpControls.Controls.Add(Me.btnChgBckgrnd)
        Me.grpControls.Controls.Add(Me.btnCredits)
        Me.grpControls.Controls.Add(Me.btnOptions)
        Me.grpControls.Controls.Add(Me.btnResume)
        Me.grpControls.Controls.Add(Me.btnStart)
        Me.grpControls.ForeColor = System.Drawing.Color.Yellow
        Me.grpControls.Location = New System.Drawing.Point(614, 57)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(160, 498)
        Me.grpControls.TabIndex = 7
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Main Menu"
        '
        'btnFullScreen
        '
        Me.btnFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFullScreen.ForeColor = System.Drawing.Color.Yellow
        Me.btnFullScreen.Location = New System.Drawing.Point(19, 359)
        Me.btnFullScreen.Name = "btnFullScreen"
        Me.btnFullScreen.Size = New System.Drawing.Size(123, 46)
        Me.btnFullScreen.TabIndex = 9
        Me.btnFullScreen.Text = "Full Screen"
        Me.btnFullScreen.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(19, 433)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 46)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnChgBckgrnd
        '
        Me.btnChgBckgrnd.BackColor = System.Drawing.Color.Transparent
        Me.btnChgBckgrnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChgBckgrnd.ForeColor = System.Drawing.Color.Yellow
        Me.btnChgBckgrnd.Location = New System.Drawing.Point(19, 289)
        Me.btnChgBckgrnd.Name = "btnChgBckgrnd"
        Me.btnChgBckgrnd.Size = New System.Drawing.Size(123, 46)
        Me.btnChgBckgrnd.TabIndex = 8
        Me.btnChgBckgrnd.Text = "Change BG"
        Me.btnChgBckgrnd.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCredits.ForeColor = System.Drawing.Color.Yellow
        Me.btnCredits.Location = New System.Drawing.Point(19, 225)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(123, 46)
        Me.btnCredits.TabIndex = 7
        Me.btnCredits.Text = "&Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOptions.ForeColor = System.Drawing.Color.Yellow
        Me.btnOptions.Location = New System.Drawing.Point(19, 159)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(123, 46)
        Me.btnOptions.TabIndex = 6
        Me.btnOptions.Text = "&Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Transparent
        Me.btnResume.Enabled = False
        Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResume.ForeColor = System.Drawing.Color.Yellow
        Me.btnResume.Location = New System.Drawing.Point(19, 91)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(123, 46)
        Me.btnResume.TabIndex = 5
        Me.btnResume.Text = "&Resume"
        Me.btnResume.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.ForeColor = System.Drawing.Color.Yellow
        Me.btnStart.Location = New System.Drawing.Point(19, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(123, 46)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "&Start New Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'pnlContainAll
        '
        Me.pnlContainAll.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlContainAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlContainAll.Controls.Add(Me.lblHighScore)
        Me.pnlContainAll.Controls.Add(Me.lblActualHighScore)
        Me.pnlContainAll.Controls.Add(Me.pnlOptions)
        Me.pnlContainAll.Controls.Add(Me.pnlScore)
        Me.pnlContainAll.Controls.Add(Me.pnlGameSpace)
        Me.pnlContainAll.Controls.Add(Me.grpControls)
        Me.pnlContainAll.Location = New System.Drawing.Point(-2, -1)
        Me.pnlContainAll.Name = "pnlContainAll"
        Me.pnlContainAll.Size = New System.Drawing.Size(794, 569)
        Me.pnlContainAll.TabIndex = 7
        '
        'lblHighScore
        '
        Me.lblHighScore.BackColor = System.Drawing.Color.Black
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblHighScore.Location = New System.Drawing.Point(636, 8)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(115, 20)
        Me.lblHighScore.TabIndex = 18
        Me.lblHighScore.Text = "High Score:"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActualHighScore
        '
        Me.lblActualHighScore.BackColor = System.Drawing.Color.Black
        Me.lblActualHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualHighScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblActualHighScore.Location = New System.Drawing.Point(636, 31)
        Me.lblActualHighScore.Name = "lblActualHighScore"
        Me.lblActualHighScore.Size = New System.Drawing.Size(115, 20)
        Me.lblActualHighScore.TabIndex = 17
        Me.lblActualHighScore.Text = "0"
        Me.lblActualHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlOptions
        '
        Me.pnlOptions.BackColor = System.Drawing.Color.Transparent
        Me.pnlOptions.Controls.Add(Me.lblDifficultyText)
        Me.pnlOptions.Controls.Add(Me.grpAudio)
        Me.pnlOptions.Controls.Add(Me.grpDifficulty)
        Me.pnlOptions.Controls.Add(Me.lblGameOption)
        Me.pnlOptions.Location = New System.Drawing.Point(8, 57)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(600, 500)
        Me.pnlOptions.TabIndex = 16
        Me.pnlOptions.Visible = False
        '
        'lblDifficultyText
        '
        Me.lblDifficultyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyText.ForeColor = System.Drawing.Color.White
        Me.lblDifficultyText.Location = New System.Drawing.Point(85, 85)
        Me.lblDifficultyText.Name = "lblDifficultyText"
        Me.lblDifficultyText.Size = New System.Drawing.Size(430, 23)
        Me.lblDifficultyText.TabIndex = 3
        Me.lblDifficultyText.Text = "DIFFICULTY CHANGES ARE ONLY REFLECTED ON NEW GAMES"
        '
        'grpAudio
        '
        Me.grpAudio.BackColor = System.Drawing.Color.Transparent
        Me.grpAudio.Controls.Add(Me.lblAudioSFXValue)
        Me.grpAudio.Controls.Add(Me.lblAudioMusicValue)
        Me.grpAudio.Controls.Add(Me.lblAudioMasterValue)
        Me.grpAudio.Controls.Add(Me.lblAudioSFX)
        Me.grpAudio.Controls.Add(Me.lblAudioMusic)
        Me.grpAudio.Controls.Add(Me.lblAudioMaster)
        Me.grpAudio.Controls.Add(Me.hsbAudioSFX)
        Me.grpAudio.Controls.Add(Me.hsbAudioMusic)
        Me.grpAudio.Controls.Add(Me.hsbAudioMaster)
        Me.grpAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAudio.ForeColor = System.Drawing.Color.White
        Me.grpAudio.Location = New System.Drawing.Point(312, 130)
        Me.grpAudio.Name = "grpAudio"
        Me.grpAudio.Size = New System.Drawing.Size(200, 275)
        Me.grpAudio.TabIndex = 2
        Me.grpAudio.TabStop = False
        Me.grpAudio.Text = "AUDIO OPTIONS"
        '
        'lblAudioSFXValue
        '
        Me.lblAudioSFXValue.Location = New System.Drawing.Point(44, 248)
        Me.lblAudioSFXValue.Name = "lblAudioSFXValue"
        Me.lblAudioSFXValue.Size = New System.Drawing.Size(113, 29)
        Me.lblAudioSFXValue.TabIndex = 8
        Me.lblAudioSFXValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAudioMusicValue
        '
        Me.lblAudioMusicValue.Location = New System.Drawing.Point(43, 170)
        Me.lblAudioMusicValue.Name = "lblAudioMusicValue"
        Me.lblAudioMusicValue.Size = New System.Drawing.Size(113, 29)
        Me.lblAudioMusicValue.TabIndex = 7
        Me.lblAudioMusicValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAudioMasterValue
        '
        Me.lblAudioMasterValue.Location = New System.Drawing.Point(42, 89)
        Me.lblAudioMasterValue.Name = "lblAudioMasterValue"
        Me.lblAudioMasterValue.Size = New System.Drawing.Size(113, 29)
        Me.lblAudioMasterValue.TabIndex = 6
        Me.lblAudioMasterValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAudioSFX
        '
        Me.lblAudioSFX.Location = New System.Drawing.Point(39, 219)
        Me.lblAudioSFX.Name = "lblAudioSFX"
        Me.lblAudioSFX.Size = New System.Drawing.Size(124, 29)
        Me.lblAudioSFX.TabIndex = 5
        Me.lblAudioSFX.Text = "SFX Volume"
        Me.lblAudioSFX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAudioMusic
        '
        Me.lblAudioMusic.Location = New System.Drawing.Point(30, 141)
        Me.lblAudioMusic.Name = "lblAudioMusic"
        Me.lblAudioMusic.Size = New System.Drawing.Size(139, 29)
        Me.lblAudioMusic.TabIndex = 4
        Me.lblAudioMusic.Text = "Music Volume"
        Me.lblAudioMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAudioMaster
        '
        Me.lblAudioMaster.Location = New System.Drawing.Point(30, 60)
        Me.lblAudioMaster.Name = "lblAudioMaster"
        Me.lblAudioMaster.Size = New System.Drawing.Size(144, 29)
        Me.lblAudioMaster.TabIndex = 3
        Me.lblAudioMaster.Text = "Master Volume"
        Me.lblAudioMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hsbAudioSFX
        '
        Me.hsbAudioSFX.Location = New System.Drawing.Point(47, 199)
        Me.hsbAudioSFX.Maximum = 109
        Me.hsbAudioSFX.Name = "hsbAudioSFX"
        Me.hsbAudioSFX.Size = New System.Drawing.Size(110, 17)
        Me.hsbAudioSFX.TabIndex = 2
        Me.hsbAudioSFX.Value = 100
        '
        'hsbAudioMusic
        '
        Me.hsbAudioMusic.Location = New System.Drawing.Point(46, 121)
        Me.hsbAudioMusic.Maximum = 109
        Me.hsbAudioMusic.Name = "hsbAudioMusic"
        Me.hsbAudioMusic.Size = New System.Drawing.Size(110, 17)
        Me.hsbAudioMusic.TabIndex = 1
        Me.hsbAudioMusic.Value = 100
        '
        'hsbAudioMaster
        '
        Me.hsbAudioMaster.Location = New System.Drawing.Point(43, 40)
        Me.hsbAudioMaster.Maximum = 109
        Me.hsbAudioMaster.Name = "hsbAudioMaster"
        Me.hsbAudioMaster.Size = New System.Drawing.Size(110, 17)
        Me.hsbAudioMaster.TabIndex = 0
        Me.hsbAudioMaster.Value = 50
        '
        'grpDifficulty
        '
        Me.grpDifficulty.BackColor = System.Drawing.Color.Transparent
        Me.grpDifficulty.Controls.Add(Me.btnClearHistory)
        Me.grpDifficulty.Controls.Add(Me.radDifficultyExtreme)
        Me.grpDifficulty.Controls.Add(Me.radDifficultyHard)
        Me.grpDifficulty.Controls.Add(Me.radDifficultyMedium)
        Me.grpDifficulty.Controls.Add(Me.radDifficultyEasy)
        Me.grpDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDifficulty.ForeColor = System.Drawing.Color.White
        Me.grpDifficulty.Location = New System.Drawing.Point(106, 130)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(200, 275)
        Me.grpDifficulty.TabIndex = 1
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "DIFFICULTY"
        '
        'btnClearHistory
        '
        Me.btnClearHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearHistory.ForeColor = System.Drawing.Color.White
        Me.btnClearHistory.Location = New System.Drawing.Point(15, 210)
        Me.btnClearHistory.Name = "btnClearHistory"
        Me.btnClearHistory.Size = New System.Drawing.Size(166, 46)
        Me.btnClearHistory.TabIndex = 5
        Me.btnClearHistory.Text = "Reset High Score"
        Me.btnClearHistory.UseVisualStyleBackColor = False
        '
        'radDifficultyExtreme
        '
        Me.radDifficultyExtreme.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDifficultyExtreme.Location = New System.Drawing.Point(15, 158)
        Me.radDifficultyExtreme.Name = "radDifficultyExtreme"
        Me.radDifficultyExtreme.Size = New System.Drawing.Size(150, 34)
        Me.radDifficultyExtreme.TabIndex = 3
        Me.radDifficultyExtreme.Text = "Extreme"
        Me.radDifficultyExtreme.UseVisualStyleBackColor = True
        '
        'radDifficultyHard
        '
        Me.radDifficultyHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDifficultyHard.Location = New System.Drawing.Point(15, 118)
        Me.radDifficultyHard.Name = "radDifficultyHard"
        Me.radDifficultyHard.Size = New System.Drawing.Size(104, 34)
        Me.radDifficultyHard.TabIndex = 2
        Me.radDifficultyHard.Text = "Hard"
        Me.radDifficultyHard.UseVisualStyleBackColor = True
        '
        'radDifficultyMedium
        '
        Me.radDifficultyMedium.Checked = True
        Me.radDifficultyMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDifficultyMedium.Location = New System.Drawing.Point(15, 78)
        Me.radDifficultyMedium.Name = "radDifficultyMedium"
        Me.radDifficultyMedium.Size = New System.Drawing.Size(127, 34)
        Me.radDifficultyMedium.TabIndex = 1
        Me.radDifficultyMedium.TabStop = True
        Me.radDifficultyMedium.Text = "Medium"
        Me.radDifficultyMedium.UseVisualStyleBackColor = True
        '
        'radDifficultyEasy
        '
        Me.radDifficultyEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDifficultyEasy.Location = New System.Drawing.Point(15, 28)
        Me.radDifficultyEasy.Name = "radDifficultyEasy"
        Me.radDifficultyEasy.Size = New System.Drawing.Size(94, 43)
        Me.radDifficultyEasy.TabIndex = 0
        Me.radDifficultyEasy.Text = "Easy"
        Me.radDifficultyEasy.UseVisualStyleBackColor = True
        '
        'lblGameOption
        '
        Me.lblGameOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOption.ForeColor = System.Drawing.Color.White
        Me.lblGameOption.Location = New System.Drawing.Point(168, 37)
        Me.lblGameOption.Name = "lblGameOption"
        Me.lblGameOption.Size = New System.Drawing.Size(265, 37)
        Me.lblGameOption.TabIndex = 0
        Me.lblGameOption.Text = "GAME OPTIONS"
        Me.lblGameOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlScore
        '
        Me.pnlScore.BackgroundImage = CType(resources.GetObject("pnlScore.BackgroundImage"), System.Drawing.Image)
        Me.pnlScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlScore.Controls.Add(Me.picFighterHealth)
        Me.pnlScore.Controls.Add(Me.picBossHealth)
        Me.pnlScore.Controls.Add(Me.lblScore)
        Me.pnlScore.Controls.Add(Me.lblGameUI)
        Me.pnlScore.Location = New System.Drawing.Point(8, 8)
        Me.pnlScore.Name = "pnlScore"
        Me.pnlScore.Size = New System.Drawing.Size(600, 43)
        Me.pnlScore.TabIndex = 16
        Me.pnlScore.Visible = False
        '
        'picFighterHealth
        '
        Me.picFighterHealth.ErrorImage = Nothing
        Me.picFighterHealth.InitialImage = Nothing
        Me.picFighterHealth.Location = New System.Drawing.Point(3, 4)
        Me.picFighterHealth.Name = "picFighterHealth"
        Me.picFighterHealth.Size = New System.Drawing.Size(265, 30)
        Me.picFighterHealth.TabIndex = 5
        Me.picFighterHealth.TabStop = False
        '
        'picBossHealth
        '
        Me.picBossHealth.ErrorImage = Nothing
        Me.picBossHealth.InitialImage = Nothing
        Me.picBossHealth.Location = New System.Drawing.Point(390, 4)
        Me.picBossHealth.Name = "picBossHealth"
        Me.picBossHealth.Size = New System.Drawing.Size(201, 30)
        Me.picBossHealth.TabIndex = 6
        Me.picBossHealth.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Black
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblScore.Location = New System.Drawing.Point(272, -2)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(115, 20)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Score:"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGameUI
        '
        Me.lblGameUI.BackColor = System.Drawing.Color.Black
        Me.lblGameUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameUI.ForeColor = System.Drawing.Color.Yellow
        Me.lblGameUI.Location = New System.Drawing.Point(272, 16)
        Me.lblGameUI.Name = "lblGameUI"
        Me.lblGameUI.Size = New System.Drawing.Size(115, 20)
        Me.lblGameUI.TabIndex = 0
        Me.lblGameUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wmpBGMusic
        '
        Me.wmpBGMusic.Enabled = True
        Me.wmpBGMusic.Location = New System.Drawing.Point(13, 578)
        Me.wmpBGMusic.Name = "wmpBGMusic"
        Me.wmpBGMusic.OcxState = CType(resources.GetObject("wmpBGMusic.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpBGMusic.Size = New System.Drawing.Size(75, 23)
        Me.wmpBGMusic.TabIndex = 8
        Me.wmpBGMusic.Visible = False
        '
        'wmpButtonClicks
        '
        Me.wmpButtonClicks.Enabled = True
        Me.wmpButtonClicks.Location = New System.Drawing.Point(118, 578)
        Me.wmpButtonClicks.Name = "wmpButtonClicks"
        Me.wmpButtonClicks.OcxState = CType(resources.GetObject("wmpButtonClicks.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpButtonClicks.Size = New System.Drawing.Size(75, 23)
        Me.wmpButtonClicks.TabIndex = 9
        Me.wmpButtonClicks.Visible = False
        '
        'wmpShooting
        '
        Me.wmpShooting.Enabled = True
        Me.wmpShooting.Location = New System.Drawing.Point(216, 578)
        Me.wmpShooting.Name = "wmpShooting"
        Me.wmpShooting.OcxState = CType(resources.GetObject("wmpShooting.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpShooting.Size = New System.Drawing.Size(75, 23)
        Me.wmpShooting.TabIndex = 10
        Me.wmpShooting.Visible = False
        '
        'wmpDamage
        '
        Me.wmpDamage.Enabled = True
        Me.wmpDamage.Location = New System.Drawing.Point(311, 578)
        Me.wmpDamage.Name = "wmpDamage"
        Me.wmpDamage.OcxState = CType(resources.GetObject("wmpDamage.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpDamage.Size = New System.Drawing.Size(75, 23)
        Me.wmpDamage.TabIndex = 11
        Me.wmpDamage.Visible = False
        '
        'wmpHealth
        '
        Me.wmpHealth.Enabled = True
        Me.wmpHealth.Location = New System.Drawing.Point(418, 578)
        Me.wmpHealth.Name = "wmpHealth"
        Me.wmpHealth.OcxState = CType(resources.GetObject("wmpHealth.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpHealth.Size = New System.Drawing.Size(75, 23)
        Me.wmpHealth.TabIndex = 12
        Me.wmpHealth.Visible = False
        '
        'wmpMenuBG
        '
        Me.wmpMenuBG.Enabled = True
        Me.wmpMenuBG.Location = New System.Drawing.Point(517, 578)
        Me.wmpMenuBG.Name = "wmpMenuBG"
        Me.wmpMenuBG.OcxState = CType(resources.GetObject("wmpMenuBG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpMenuBG.Size = New System.Drawing.Size(75, 23)
        Me.wmpMenuBG.TabIndex = 13
        Me.wmpMenuBG.Visible = False
        '
        'wmpBossBG
        '
        Me.wmpBossBG.Enabled = True
        Me.wmpBossBG.Location = New System.Drawing.Point(615, 581)
        Me.wmpBossBG.Name = "wmpBossBG"
        Me.wmpBossBG.OcxState = CType(resources.GetObject("wmpBossBG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpBossBG.Size = New System.Drawing.Size(75, 23)
        Me.wmpBossBG.TabIndex = 14
        Me.wmpBossBG.Visible = False
        '
        'pnlMultiUseScreen
        '
        Me.pnlMultiUseScreen.Controls.Add(Me.btnTitleScreen)
        Me.pnlMultiUseScreen.Location = New System.Drawing.Point(800, 0)
        Me.pnlMultiUseScreen.Name = "pnlMultiUseScreen"
        Me.pnlMultiUseScreen.Size = New System.Drawing.Size(812, 619)
        Me.pnlMultiUseScreen.TabIndex = 15
        '
        'btnTitleScreen
        '
        Me.btnTitleScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnTitleScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTitleScreen.ForeColor = System.Drawing.Color.Yellow
        Me.btnTitleScreen.Location = New System.Drawing.Point(477, 77)
        Me.btnTitleScreen.Name = "btnTitleScreen"
        Me.btnTitleScreen.Size = New System.Drawing.Size(123, 46)
        Me.btnTitleScreen.TabIndex = 8
        Me.btnTitleScreen.Text = "&Continue"
        Me.btnTitleScreen.UseVisualStyleBackColor = False
        '
        'wmpMenuBG2
        '
        Me.wmpMenuBG2.Enabled = True
        Me.wmpMenuBG2.Location = New System.Drawing.Point(699, 581)
        Me.wmpMenuBG2.Name = "wmpMenuBG2"
        Me.wmpMenuBG2.OcxState = CType(resources.GetObject("wmpMenuBG2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpMenuBG2.Size = New System.Drawing.Size(75, 23)
        Me.wmpMenuBG2.TabIndex = 16
        Me.wmpMenuBG2.Visible = False
        '
        'frmSpaceFighter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(780, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.wmpMenuBG2)
        Me.Controls.Add(Me.pnlMultiUseScreen)
        Me.Controls.Add(Me.wmpBossBG)
        Me.Controls.Add(Me.wmpMenuBG)
        Me.Controls.Add(Me.wmpHealth)
        Me.Controls.Add(Me.wmpDamage)
        Me.Controls.Add(Me.wmpShooting)
        Me.Controls.Add(Me.wmpButtonClicks)
        Me.Controls.Add(Me.wmpBGMusic)
        Me.Controls.Add(Me.pnlContainAll)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpaceFighter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Space Fighter"
        Me.pnlGameSpace.ResumeLayout(False)
        Me.grpControls.ResumeLayout(False)
        Me.pnlContainAll.ResumeLayout(False)
        Me.pnlOptions.ResumeLayout(False)
        Me.grpAudio.ResumeLayout(False)
        Me.grpDifficulty.ResumeLayout(False)
        Me.pnlScore.ResumeLayout(False)
        CType(Me.picFighterHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpBGMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpButtonClicks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpShooting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpMenuBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpBossBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMultiUseScreen.ResumeLayout(False)
        CType(Me.wmpMenuBG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlGameSpace As System.Windows.Forms.Panel
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents pnlFlash As System.Windows.Forms.Panel
    Friend WithEvents pnlContainAll As System.Windows.Forms.Panel
    Friend WithEvents btnChgBckgrnd As System.Windows.Forms.Button
    Friend WithEvents btnFullScreen As System.Windows.Forms.Button
    Friend WithEvents wmpBGMusic As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpButtonClicks As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpShooting As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpDamage As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpHealth As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpMenuBG As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpBossBG As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pnlMultiUseScreen As System.Windows.Forms.Panel
    Friend WithEvents btnTitleScreen As System.Windows.Forms.Button
    Friend WithEvents pnlScore As System.Windows.Forms.Panel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picFighterHealth As System.Windows.Forms.PictureBox
    Friend WithEvents picBossHealth As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameUI As System.Windows.Forms.Label
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents grpAudio As System.Windows.Forms.GroupBox
    Friend WithEvents lblAudioSFX As System.Windows.Forms.Label
    Friend WithEvents lblAudioMusic As System.Windows.Forms.Label
    Friend WithEvents lblAudioMaster As System.Windows.Forms.Label
    Friend WithEvents hsbAudioSFX As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbAudioMusic As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbAudioMaster As System.Windows.Forms.HScrollBar
    Friend WithEvents grpDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents radDifficultyExtreme As System.Windows.Forms.RadioButton
    Friend WithEvents radDifficultyHard As System.Windows.Forms.RadioButton
    Friend WithEvents radDifficultyMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radDifficultyEasy As System.Windows.Forms.RadioButton
    Friend WithEvents lblGameOption As System.Windows.Forms.Label
    Friend WithEvents lblDifficultyText As System.Windows.Forms.Label
    Friend WithEvents lblAudioMasterValue As System.Windows.Forms.Label
    Friend WithEvents lblAudioSFXValue As System.Windows.Forms.Label
    Friend WithEvents lblAudioMusicValue As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents lblActualHighScore As System.Windows.Forms.Label
    Friend WithEvents btnClearHistory As System.Windows.Forms.Button
    Friend WithEvents wmpMenuBG2 As AxWMPLib.AxWindowsMediaPlayer

End Class

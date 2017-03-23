'==============================================================================
'Project:           Final Game Project.
'Title:             Just Another Space Shooter
'File Name:         SpaceFighter.vb
'Date completed:    March 14, 2013.
'Authors:           Russell Brendel, Kleigh Grosshans, Ryu Muthui.
'Class:             CS 161 Intro to Game Development
'
'Description:       The year is 2745, 1 year after the destruction of the 
'                   earth.  What is left of humanity now remains scattered 
'                   across the galaxy on space stations and roaming colony 
'                   ships. You are entrusted with the most advanced 
'                   warfighter, scouting for potential new worlds to colonize.
'                   
'                   As you explore the deep space sector A-SR125...

'                   *Shoot and blow up asteroids to clear a path to your goal!
'		            *Pick up power-ups to rebuild your warfighter if damaged!
'		            *Your space-radar has picked up a significant sized blip
'                    in the horizon - Could it be a potentially colonializable
'                    world?
'		            *Challenge yourself by scouting through more hazardous
'                    asteroid belts!
'
'		            Control your warfighter with WASD controls and shoot with 
'                   the Space Bar (all animated!). Navigate through on-coming 
'                   asteroids and pick up powerups to survive long enough to 
'                   reach your destination. Attempt to beat your previous 
'                   (or friend's) high score with different score multiplier 
'                   based on difficulty settings.
'
'		            Scoring System
'		            Muliplier for scores:

'		            Easy: x1 
'		            Medium: x2 
'		            Hard: x3 
'		            Extreme: x5
'
'		            Destroying an Asteroid:     +50 pts
'		            Warfighter being hit:       -100 pts
'		            Hitting the boss:           +25 pts
'		            Defeating the boss:         +150 pts
'		            Wasting bullets:            -1 pts
'		            Being hit by Boss Bullet:   -25 pts
'
'		            Health:       Easy:   Medium:   Hard:   Extreme:
'		            Warfighter:   20	  10		8		4
'		            Boss:         12	  40		80	    150
'
'		            Distance and Obstacles count:
'		            Easy:		3 cycles, 40 obstacles per cycle
'		            Medium:		5 cycles, 60 obstacles per cycle
'		            Hard:		9 cycles, 100 obstacles per cycle
'		            Extreme:	17 cycles, 200 obstacles per cycle
'==============================================================================
'Known Bugs:        None
'==============================================================================

Option Explicit On
Option Strict On

'imports
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports WMPLib.WMPPlayState

Public Class frmSpaceFighter
    '--------------------------------------------------------------------------
    'Description:   These are class wide declared variables that will be used 
    '               through out the program.              
    '--------------------------------------------------------------------------

    'Array Max Constants
    Const MAX_OBSTACLE As Byte = 199
    Const MAX_BULLETS As Byte = 99
    Const MAX_BOSS_BULLETS As Byte = 99
    Const MAX_EXPLOSION As Byte = 9
    Const NUMBER_OF_OBSTACLES_IMAGES = 3
    Const MAX_FORM_BACKGROUNDS = 5

    'Animation Frame Constants
    Const FIGHTER_W_FRAMES As Byte = 8
    Const FIGHTER_H_FRAMES As Byte = 4
    Const BOSS_W_FRAMES As Byte = 4
    Const BOSS_H_FRAMES As Byte = 3
    Const BULLETS_W_FRAMES As Byte = 4
    Const BULLETS_H_FRAMES As Byte = 1
    Const BOSS_BULLETS_W_FRAMES As Byte = 4
    Const BOSS_BULLETS_H_FRAMES As Byte = 1
    Const OBSTACLE_W_FRAMES As Byte = 16
    Const OBSTACLE_H_FRAMES As Byte = 1
    Const POWER_UPS_W_FRAMES As Byte = 4
    Const POWER_UPS_H_FRAMES As Byte = 1
    Const EXPLOSION_W_FRAMES As Byte = 16
    Const EXPLOSION_H_FRAMES As Byte = 1

    'File Paths to Folder locations
    Dim strAppFolder As String = Application.StartupPath
    Dim strResources As String = "..\Resources\"
    Dim strImageFolder As String = strResources & "Images\"
    Dim strBGImageFolder As String = strResources & "Backgrounds\"
    Dim strMusicFolder As String = _
        strAppFolder.Substring(0, strAppFolder.Length - "Debug".Length) & _
        "Resources\Sounds\music\"
    Dim strSFXFolder As String = _
        strAppFolder.Substring(0, strAppFolder.Length - "Debug".Length) & _
        "Resources\Sounds\sfx\"

    'Fighter variables
    Dim graFighter As Graphics
    Dim bmpFighter As Bitmap
    Dim cshtFighterX As Short
    Dim cshtFighterY As Short
    Dim cshtFighterW As Short
    Dim cshtFighterH As Short
    Dim cbytFighterXStep As Byte = 2
    Dim cbytFighterYStep As Byte = 3
    Dim cshtFighterFrameX As Short
    Dim cshtFighterFrameY As Short

    'Boss variables
    Dim graBoss As Graphics
    Dim bmpBoss As Bitmap
    Dim cshtBossX As Short
    Dim cshtBossY As Short
    Dim cshtBossW As Short
    Dim cshtBossH As Short
    Dim cbytBossXStep As Byte = 1
    Dim cbytBossYStep As Byte = 1
    Dim cblnBossMoveLeft As Boolean
    Dim cshtBossFrameX As Short
    Dim cshtBossFrameY As Short

    'Background variables
    Dim graBG As Graphics
    Dim bmpBG As Bitmap = New Bitmap(strImageFolder & "BG1.png")
    Dim mtxBackGround As Matrix
    Dim cbytBackGroundStepX As Byte = 0
    Dim cbytBackGroundStepY As Byte = 1

    'Obstacle variables
    Dim graObstacle As Graphics
    Dim bmpObstacle(NUMBER_OF_OBSTACLES_IMAGES) As Bitmap
    Dim cbytObstacleImage(MAX_OBSTACLE) As Byte
    Dim cshtObstacleX(MAX_OBSTACLE) As Short
    Dim cshtObstacleY(MAX_OBSTACLE) As Short
    Dim cshtObstacleW(MAX_OBSTACLE) As Short
    Dim cshtObstacleH(MAX_OBSTACLE) As Short
    Dim cblnObstacleActive(MAX_OBSTACLE) As Boolean
    Dim cbytObstacleStep As Short = 1
    Dim cshtObstacleFrameX(MAX_OBSTACLE) As Short
    Dim cshtObstacleFrameY(MAX_OBSTACLE) As Short

    'Explosion variables
    Dim graExplosion As Graphics
    Dim bmpExplosion As Bitmap
    Dim cshtExplosionX(MAX_EXPLOSION) As Short
    Dim cshtExplosionY(MAX_EXPLOSION) As Short
    Dim cshtExplosionW(MAX_EXPLOSION) As Short
    Dim cshtExplosionH(MAX_EXPLOSION) As Short
    Dim cblnExplosionActive(MAX_EXPLOSION) As Boolean
    Dim cshtExplosionFrameX(MAX_EXPLOSION) As Short
    Dim cshtExplosionFrameY(MAX_EXPLOSION) As Short
    Dim cbytexplosionCounter As Short

    'Power-Up variables
    Dim graPowerUps As Graphics
    Dim bmpPowerUps As Bitmap
    Dim cshtPowerUpsX As Short
    Dim cshtPowerUpsY As Short
    Dim cshtPowerUpsW As Short
    Dim cshtPowerUpsH As Short
    Dim cblnPowerUpsActive As Boolean
    Dim cbytPowerUpsStep As SByte
    Dim cshtPowerUpsFrameX As Short
    Dim cshtPowerUpsFrameY As Short

    'Bullets variables
    Dim graBullets As Graphics
    Dim bmpBullets As Bitmap
    Dim cshtBulletsX(MAX_BULLETS) As Short
    Dim cshtBulletsY(MAX_BULLETS) As Short
    Dim cshtBulletsW(MAX_BULLETS) As Short
    Dim cshtBulletsH(MAX_BULLETS) As Short
    Dim cblnBulletsActive(MAX_BULLETS) As Boolean
    Dim cbytBulletsStep As SByte = -1
    Dim cshtBulletsFrameX(MAX_BULLETS) As Short
    Dim cshtBulletsFrameY(MAX_BULLETS) As Short
    Dim cbytBulletCount As Byte = 0
    Dim cbytBulletDelay As Byte

    'Boss Bullets variables
    Dim graBossBullets As Graphics
    Dim bmpBossBullets As Bitmap
    Dim cshtBossBulletsX(MAX_BOSS_BULLETS) As Short
    Dim cshtBossBulletsY(MAX_BOSS_BULLETS) As Short
    Dim cshtBossBulletsW(MAX_BOSS_BULLETS) As Short
    Dim cshtBossBulletsH(MAX_BOSS_BULLETS) As Short
    Dim cblnBossBulletsActive(MAX_BOSS_BULLETS) As Boolean
    Dim cbytBossBulletsStep As Byte = 2
    Dim cshtBossBulletsFrameX(MAX_BOSS_BULLETS) As Short
    Dim cshtBossBulletsFrameY(MAX_BOSS_BULLETS) As Short
    Dim cbytBossBulletCount As Byte

    'Frame variables
    Dim cbyteBackGround As Byte = 1
    Dim recFrame As Rectangle

    'Game Panel variables
    Dim graBGBuffer As Graphics
    Dim bmpBuffer As Bitmap
    Dim cshtViewWidth As Short
    Dim cshtViewHeight As Short

    'Command variables
    Dim cblnUp As Boolean
    Dim cblnDown As Boolean
    Dim cblnLeft As Boolean
    Dim cblnRight As Boolean
    Dim cblnShoot As Boolean

    'Save position variables
    Dim cintI As Integer
    Dim cintJ As Integer
    Dim cblnPause As Boolean
    Dim mtxPause As Matrix
    Dim cblnReturnFromPause As Boolean = False
    Dim cblnBossStart As Boolean = False
    Dim cshtBossStartCounter As Short = 0
    Dim cblnBossDeath As Boolean = False
    Dim cblnFighterDeath As Boolean = False
    Dim cshtDeathCounter As Short = 0
    Dim cblnBossShootBulletsActive As Boolean
    Dim cchrMenuScreenStatus As Char

    'Game variables
    Dim clngScore As Long
    Dim clngHighScore As Long
    Dim cblnGameOver As Boolean
    Dim cblnBoss As Boolean = False
    Dim cshtStartY As Short
    Dim cshtLevelLength As Short
    Dim cshtObstacleLevel As Short
    Dim cshtFighterHealth As Short
    Dim cshtBossHealth As Short
    Dim cshtFighterMaxHealth As Short
    Dim cshtBossMaxHealth As Short
    Dim cshtFighterHealthPercent As Short
    Dim cshtBossHealthPercent As Short
    Dim cblnPowerUpsStart As Boolean

    'Stops events from triggering from pre-load actions
    Dim cblnLoad As Boolean = False

    'Score variables
    Dim cshtObstacleScore As Short = 25
    Dim cshtFighterScore As Short = -25
    Dim cshtBossHitScore As Short = 12
    Dim cshtBossDefeatedScore As Short = 20
    Dim cshtBulletsWastedScore As Short = -1
    Dim cshtBossBulletsScore As Short = -12
    Dim cshtLevelScoreMultiplyer As Short

    Private Sub frmSpaceFighter_Load(sender As Object, _
                                     e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        'Description:   Initializes variables and prepares the board. Shows
        '				the title screen. 
        '
        'Calls:         ButtonColors
        '               SetBullets
        '               SetBossBullets
        '               SetPowerUps
        '               SetExplosion
        '				SetVolumes
        '               BackgroundChange
        '----------------------------------------------------------------------

        'randomize the random values
        Randomize()

        'Show the title screen
        pnlMultiUseScreen.Left = 0
        pnlMultiUseScreen.Top = 0
        pnlMultiUseScreen.Height = Me.Height
        pnlMultiUseScreen.Width = Me.Width
        pnlMultiUseScreen.BackgroundImage = Image.FromFile(strImageFolder & _
                                                        "TITLE_SCREEN.png")
        pnlMultiUseScreen.BackgroundImageLayout = ImageLayout.Stretch
        btnTitleScreen.Left = pnlMultiUseScreen.Width - btnTitleScreen.Width * 2
        btnTitleScreen.Top = btnTitleScreen.Height * 2
        pnlMultiUseScreen.Visible = True
        grpControls.Enabled = False

        Call BackgroundChange()

        'Checks previous High Score from save file and sets it on form
        FileOpen(1, strResources & "HighS.asf", OpenMode.Input)
        Dim strTemp As String = LineInput(1)
        FileClose(1)
        If IsNumeric(strTemp) = True Then
            clngHighScore = CLng(strTemp)
        Else
            clngHighScore = 0
        End If
        lblActualHighScore.Text = CStr(clngHighScore)

        'Set the background color of on-screen buttons
        Call ButtonColors()

        'Set value of game space window variables
        cshtViewWidth = CShort(pnlGameSpace.Width)
        cshtViewHeight = CShort(pnlGameSpace.Height)

        'Create graphics and bitmaps
        graBG = pnlGameSpace.CreateGraphics
        bmpBuffer = New Bitmap(cshtViewWidth, cshtViewHeight, graBG)
        graBGBuffer = Graphics.FromImage(bmpBuffer)

        'Set the images that don't change through out the game
        Call SetBullets()
        Call SetBossBullets()
        Call SetPowerUps()
        Call SetExplosion()
        For i = 0 To NUMBER_OF_OBSTACLES_IMAGES
            bmpObstacle(i) = New Bitmap(strImageFolder & _
                                        "ASTEROID" & i & ".png")
            bmpObstacle(i).MakeTransparent(Color.FromArgb(255, 0, 255))
        Next i

        'Setup Sounds
        wmpBGMusic.settings.autoStart = False
        wmpButtonClicks.settings.autoStart = False
        wmpDamage.settings.autoStart = False
        wmpHealth.settings.autoStart = False
        wmpShooting.settings.autoStart = False
        wmpMenuBG.settings.autoStart = False
        wmpBossBG.settings.autoStart = False
        wmpMenuBG2.settings.autoStart = False
        wmpBGMusic.settings.setMode("loop", True)
        wmpMenuBG2.settings.setMode("loop", True)
        wmpButtonClicks.URL = strSFXFolder & "sfx_menuclick.mp3"
        wmpShooting.URL = strSFXFolder & "sfx_shooting.mp3"
        wmpMenuBG2.URL = strMusicFolder & "story.mp3"
        wmpMenuBG.URL = strMusicFolder & "title.mp3"
        wmpMenuBG.Ctlcontrols.play()
        Call SetVolumes()

        'Prevents audio triggers from activating before fully loading
        cblnLoad = True

        'Declare matrix value for the background scrolling speed
        mtxBackGround = New Matrix(1, 0, 0, 1, _
                                   cbytBackGroundStepX, _
                                   cbytBackGroundStepY)

    End Sub

    Private Sub frmAnimation_KeyDown(sender As Object, _
                    e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '----------------------------------------------------------------------
        'Description:   Recognize key inputs and set variables to allow for
        '				multiple key down presses during fighter movement and
        '               shooting sequence. 
        '
        'Calls:         Pause
        '----------------------------------------------------------------------

        'Suppress Window's system warning sound (Beep key dinging audio)
        e.SuppressKeyPress = True

        'Stop inputs from user during boss entrance
        If cblnBossStart = False Then

            'Direction inputs
            If e.KeyCode = Keys.D Then
                cblnRight = True
            End If
            If e.KeyCode = Keys.A Then
                cblnLeft = True
            End If
            If e.KeyCode = Keys.W Then
                cblnUp = True
            End If
            If e.KeyCode = Keys.S Then
                cblnDown = True
            End If

            'Action inputs
            If e.KeyCode = Keys.Space Then
                cblnShoot = True
            End If

            'Game controls
            If e.KeyCode = Keys.P Then
                cblnPause = True
                Call Pause()
            End If

        Else 'Stop inputs from triggering during boss entrance

            cblnPause = False
            cblnUp = False
            cblnDown = False
            cblnLeft = False
            cblnRight = False
        End If

    End Sub

    Private Sub frmAnimation_KeyUp(sender As Object, _
                    e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        '----------------------------------------------------------------------
        'Description:   Recognize keys are no longer giving inputs
        '----------------------------------------------------------------------

        'Directional inputs
        If e.KeyCode = Keys.D Then
            cblnRight = False
        End If
        If e.KeyCode = Keys.A Then
            cblnLeft = False
        End If
        If e.KeyCode = Keys.W Then
            cblnUp = False
        End If
        If e.KeyCode = Keys.S Then
            cblnDown = False
        End If

        'Action inputs
        If e.KeyCode = Keys.Space Then
            cblnShoot = False
        End If

    End Sub

    Private Sub btnPlay_Start(sender As System.Object, _
                              e As System.EventArgs) Handles btnStart.Click
        '----------------------------------------------------------------------
        'Description:   Starts a new game if no game is currently in-progress.
        '               Asks for verification if game is already in progress.
        '				Then calls and sets the default values.
        '
        'Calls:         GameStartDefaults
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        'Verify user's intent when a game session is currently in-progress
        If cblnPause = True Then
            If MessageBox.Show("Are you sure you want to quit your " & _
                               "current game and start a new one?", _
                               "New Game", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.None) _
                           = Windows.Forms.DialogResult.Yes Then
                Call GameStartDefaults()
            End If
        Else
            Call GameStartDefaults()
        End If

    End Sub

    Private Sub GameStartDefaults()
        '----------------------------------------------------------------------
        'Description:   Sets the default value of a new game.
        '
        'Called by:     btnPlay_Start
        '
        'Calls:         GamePlay
        '				SetFighter
        '				SetBoss
        '				SetObstacle
        '----------------------------------------------------------------------

        'Reset the Pause control values back to the default state
        cintI = bmpBG.Height - cshtViewHeight
        cintJ = 0
        cshtStartY = CShort(bmpBG.Height - cshtViewHeight)
        mtxPause = New Matrix(1, 0, 0, 1, 0, 0)
        cblnPause = False

        'Game starting variables
        pnlFlash.Visible = False
        pnlMultiUseScreen.Visible = False
        pnlOptions.Visible = False
        pnlScore.Visible = True
        cblnBoss = False
        cblnBossDeath = False
        cblnFighterDeath = False
        cblnReturnFromPause = False
        cblnBossStart = False
        cshtBossStartCounter = 0
        cblnBossShootBulletsActive = False
        cshtDeathCounter = 0
        cshtFighterHealthPercent = 0
        cshtBossHealthPercent = 0
        clngScore = 0
        lblGameUI.Text = clngScore.ToString
        cblnPowerUpsStart = False
        clngScore = 0
        cblnGameOver = False

        'Reset player images to default
        Call SetFighter()
        Call SetBoss()
        For i = 0 To MAX_OBSTACLE
            Call SetObstacle(i)
        Next

        'Turn off populated images at start
        cblnPowerUpsActive = False
        For i = 0 To MAX_EXPLOSION
            cblnExplosionActive(i) = False
        Next i
        For i = 0 To MAX_BULLETS
            cblnBulletsActive(i) = False
        Next i
        For i = 0 To MAX_BOSS_BULLETS
            cblnBossBulletsActive(i) = False
        Next

        'Setup sounds
        wmpBGMusic.Ctlcontrols.stop()
        wmpBGMusic.URL = strMusicFolder & "gameplay.mp3"

        'Set variables based on selected difficulty level
        If radDifficultyEasy.Checked = True Then
            cshtLevelLength = 2
            cshtObstacleLevel = 40
            cshtFighterHealth = 20
            cshtBossHealth = 20
            cshtLevelScoreMultiplyer = 1
        ElseIf radDifficultyMedium.Checked = True Then
            cshtLevelLength = 4
            cshtObstacleLevel = 60
            cshtFighterHealth = 10
            cshtBossHealth = 40
            cshtLevelScoreMultiplyer = 2
        ElseIf radDifficultyHard.Checked = True Then
            cshtLevelLength = 8
            cshtObstacleLevel = 99
            cshtFighterHealth = 8
            cshtBossHealth = 80
            cshtLevelScoreMultiplyer = 3
        Else
            cshtLevelLength = 16
            cshtObstacleLevel = MAX_OBSTACLE
            cshtFighterHealth = 4
            cshtBossHealth = 150
            cshtLevelScoreMultiplyer = 5
        End If
        cshtFighterMaxHealth = cshtFighterHealth
        cshtBossMaxHealth = cshtBossHealth

        'Fighter starting position
        cshtFighterX = (cshtViewWidth - cshtFighterW) \ 2S
        cshtFighterY = 300

        Call GamePlay()

    End Sub

    Private Sub GamePlay()
        '----------------------------------------------------------------------
        'Description:   Subroutines that are running during active game-play.
        '
        'Called by:     GameStartDefaults
        '				Pause
        '
        'Calls:         ObstaclePlacement
        '               FighterMovement
        '               ObstacleMovement
        '               BulletMovement
        '               BackgroundMovement
        '               DrawGraphics
        '               bossStart
        '               BossMovement
        '               BossBulletMovement
        '				FighterCollesion
        '				PowerUpCollesion
        '				ObstacleCollesion
        '				UpdateHealths
        '				BossVsBulletsCollesion
        '				BossVsFighterCollesion
        '				FighterVsBossBulletsCollesion
        '				GameEnd
        '----------------------------------------------------------------------

        'Turn off button controls
        grpControls.Enabled = False

        'Stop Sound Options
        wmpButtonClicks.Ctlcontrols.stop()
        wmpDamage.Ctlcontrols.stop()
        wmpHealth.Ctlcontrols.stop()
        wmpShooting.Ctlcontrols.stop()
        wmpMenuBG.Ctlcontrols.stop()
        wmpBossBG.Ctlcontrols.stop()
        wmpMenuBG2.Ctlcontrols.stop()

        'Play the background music
        wmpBGMusic.Ctlcontrols.play()

        'MAIN GAME IN PROGRESS LOOP

        'Obstacle avoidence section of game
        If cblnBoss = False Then

            'Runs the background
            For j = cintJ To cshtLevelLength

                'Place obstacles on playfield
                If cblnReturnFromPause = False Then
                    Call ObstaclePlacement()
                End If

                'Game background loop
                For i = cintI To 0 Step -1

                    'If game has been paused,
                    'save the loop variables and exit the loop
                    If cblnPause = True Then
                        cintI = i
                        mtxPause = graBGBuffer.Transform
                        Exit For
                    ElseIf cblnReturnFromPause = True Then
                        cintI = bmpBG.Height - cshtViewHeight
                    End If

                    'If game is over, exit game-play loop
                    If cblnGameOver = True Then
                        Exit For
                    End If

                    'Place PowerUps on the play space
                    If i = cintI \ 2 Or i = cintI \ 4 * 3 Then
                        PowerUpPlacement()
                    End If

                    'Move items on the board and draw them
                    Call FighterMovement()
                    Call ObstacleMovement()
                    Call BulletMovement()
                    Call BackgroundMovement()
                    Call DrawGraphics(i)

                    'Sets a maximum speed of game-play
                    Thread.Sleep(1)

                    'Allows delay when player dies to run player death sequence
                    'If game is not over, check for collesions and update the
                    'health of player
                    If cblnFighterDeath = True Then
                        cshtDeathCounter += 1S
                        If cshtDeathCounter > 300 Then
                            cblnGameOver = True
                        End If
                    Else
                        Call FighterCollesion()
                        Call PowerUpCollesion()
                        Call ObstacleCollesion()
                        Call UpdateHealths()
                    End If

                    'Allows for continuous game-play when returning from pause
                    cblnReturnFromPause = False

                    'Allow other key inputs to trigger during game-play
                    Application.DoEvents()
                Next i

                'Reset the game background to starting location
                graBGBuffer.ResetTransform()

                'If game has been paused, save the loop state to allow resume
                'and save variable values then exit the loop
                If cblnPause = True Or cblnGameOver Then
                    cintJ = j
                    Exit For
                End If

            Next j

            'Part1: Obstacle avoidance Sequence, Part2: Boss Sequence
            'If completed Part1 of game, go to Part2
            If cblnPause = False And cblnGameOver = False Then
                cshtBossStartCounter = 0
                cblnBossStart = True
                cblnBoss = True
            End If
        End If

        'Part2: Boss Sequence
        If cblnBoss = True Then

            'Loop background until the game is over (or paused)
            Do While cblnGameOver = False

                'Game background loop
                For i = cintI To 0 Step -1

                    'Have boss enter the game
                    If cblnReturnFromPause = False And _
                        cblnBossStart = True Then
                        Call bossStart(i)
                    Else

                        'If game has been paused
                        'save the loop variables and exit the loop
                        If cblnPause = True Then
                            cintI = i
                            mtxPause = graBGBuffer.Transform
                            Exit For
                        ElseIf cblnReturnFromPause = True Then
                            cintI = bmpBG.Height - cshtViewHeight
                        End If

                        'Exit loop if in gameover state
                        If cblnGameOver = True Then
                            Exit For
                        End If

                        'Move items on the board and draw them
                        Call FighterMovement()
                        Call BulletMovement()
                        Call BackgroundMovement()
                        Call BossMovement()
                        Call BossBulletMovement(i)
                        Call DrawGraphics(i)

                        'Allows delay when player or boss dies to run player 
                        'death sequence. If game is not over, check for 
                        'collesions and update the health of player and boss
                        If cblnFighterDeath = True Or cblnBossDeath = True Then
                            cshtDeathCounter += 1S
                            If cshtDeathCounter > 300 Then
                                cblnGameOver = True
                            End If
                        Else
                            Call BossVsBulletsCollesion()
                            Call BossVsFighterCollesion()
                            Call FighterVsBossBulletsCollesion()
                            Call UpdateHealths()
                        End If

                        'Changes the boss intro music to the boss loop music
                        'This also keeps the loop music playing
                        If wmpBossBG.playState = wmppsStopped Then
                            wmpBossBG.URL = strMusicFolder & "bossloop.mp3"
                            wmpBossBG.Ctlcontrols.play()
                        End If

                        'Allows for continuous game-play when returning from pause
                        cblnReturnFromPause = False

                        'Allow other key inputs to trigger during game-play
                        Application.DoEvents()

                    End If

                    'Sets a maximum speed of game-play
                    Thread.Sleep(1)

                Next i

                'Reset the background
                graBGBuffer.ResetTransform()

                'If game has been paused exit the loop
                If cblnPause = True Then
                    Exit Do
                End If
            Loop
        End If

        'Check for end of game conditions
        grpControls.Enabled = True
        If cblnBossDeath = True Then
            pnlMultiUseScreen.BackgroundImage = _
                Image.FromFile(strImageFolder & "ENDING_SCREEN.png")
            Call GameEnd()
        ElseIf cblnFighterDeath = True Then
            pnlMultiUseScreen.BackgroundImage = _
                Image.FromFile(strImageFolder & "GAME_OVER_SCREEN.png")
            Call GameEnd()
        End If

    End Sub

    Private Sub GameEnd()
        '----------------------------------------------------------------------
        'Description:   Turn off gameplay music and start end of game music.
        '               Update game completion state & updates the high score.
        '
        'Calls:         BackgroundChange
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'Sets various variables to game complete state.
        pnlMultiUseScreen.Visible = True
        pnlScore.Visible = False
        wmpBossBG.Ctlcontrols.stop()
        wmpBGMusic.Ctlcontrols.stop()
        wmpMenuBG.URL = strMusicFolder & "ending.mp3"
        wmpMenuBG.Ctlcontrols.play()
        btnResume.Enabled = False
        cchrMenuScreenStatus = "p"c
        Call BackgroundChange()

        'Check to see if most recent game score is the new high score, 
        'and update it.
        If clngScore > clngHighScore Then
            clngHighScore = clngScore
            lblActualHighScore.Text = clngHighScore.ToString
            FileOpen(1, strResources & "HighS.asf", OpenMode.Output)
            WriteLine(1, clngHighScore)
            FileClose(1)
        End If

    End Sub

    Private Sub SetObstacle(intTemp As Integer)
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the obstacles. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     frmSpaceFighter_Load
        '----------------------------------------------------------------------

        Dim shtRandomNumber As Short = CShort(Rnd() * OBSTACLE_W_FRAMES)
        cbytObstacleImage(intTemp) = _
                    CByte(Int(Rnd() * (NUMBER_OF_OBSTACLES_IMAGES + 1)))
        cshtObstacleW(intTemp) = _
            CShort(bmpObstacle(CInt(cbytObstacleImage(intTemp))).Width \ _
                OBSTACLE_W_FRAMES)
        cshtObstacleH(intTemp) = _
            CShort(bmpObstacle(CInt(cbytObstacleImage(intTemp))).Height \ _
                OBSTACLE_H_FRAMES)
        cshtObstacleFrameX(intTemp) = cshtObstacleW(intTemp) * shtRandomNumber
        cshtObstacleFrameY(intTemp) = 0
        graObstacle = Graphics.FromImage(bmpBuffer)

    End Sub

    Private Sub SetBoss()
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the Boss. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     GameStartDefaults
        '----------------------------------------------------------------------

        bmpBoss = New Bitmap(strImageFolder & "BOSSANIMATION.png")
        cshtBossW = CShort(bmpBoss.Width \ BOSS_W_FRAMES)
        cshtBossH = CShort(bmpBoss.Height \ BOSS_H_FRAMES)
        cshtBossX = CShort((cshtViewWidth - cshtBossW) \ 2)
        cshtBossY = -cshtBossH - 5S
        graBoss = Graphics.FromImage(bmpBuffer)
        bmpBoss.MakeTransparent(Color.FromArgb(255, 0, 255))

    End Sub

    Private Sub SetFighter()
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the Fighter. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     GameStartDefaults
        '----------------------------------------------------------------------

        bmpFighter = New Bitmap(strImageFolder & "SpaceShipAnimated.png")
        bmpFighter.MakeTransparent(Color.FromArgb(255, 0, 255))
        cshtFighterW = CShort(bmpFighter.Width \ FIGHTER_W_FRAMES)
        cshtFighterH = CShort(bmpFighter.Height \ FIGHTER_H_FRAMES)
        graFighter = Graphics.FromImage(bmpBuffer)

    End Sub

    Private Sub SetPowerUps()
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the Power Up. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     frmSpaceFighter_Load
        '----------------------------------------------------------------------

        bmpPowerUps = New Bitmap(strImageFolder & "POWERUP.png")
        bmpPowerUps.MakeTransparent(Color.FromArgb(255, 0, 255))
        cshtPowerUpsW = CShort(bmpPowerUps.Width \ POWER_UPS_W_FRAMES)
        cshtPowerUpsH = CShort(bmpPowerUps.Height \ POWER_UPS_H_FRAMES)
        graPowerUps = Graphics.FromImage(bmpBuffer)
        cshtPowerUpsFrameX = 0
        cshtPowerUpsFrameY = 0

    End Sub

    Private Sub SetBossBullets()
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the boss's bullets. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     frmSpaceFighter_Load
        '----------------------------------------------------------------------

        bmpBossBullets = New Bitmap(strImageFolder & "BOSSFIRE.png")
        bmpBossBullets.MakeTransparent(Color.FromArgb(255, 0, 255))

        For i = 0 To MAX_BOSS_BULLETS
            Dim shtRndNumber As Short = CShort(Rnd() * BOSS_BULLETS_W_FRAMES)

            cshtBossBulletsW(i) = CShort(bmpBossBullets.Width \ _
                                         BOSS_BULLETS_W_FRAMES)
            cshtBossBulletsH(i) = CShort(bmpBossBullets.Height \ _
                                         BOSS_BULLETS_H_FRAMES)
            graBossBullets = Graphics.FromImage(bmpBuffer)
            cshtBossBulletsFrameX(i) = cshtBossBulletsW(i) * shtRndNumber
            cshtBossBulletsFrameY(i) = 0
        Next i

    End Sub

    Private Sub SetBullets()
        '----------------------------------------------------------------------
        'Description:   Set values of Width and Height of the Fighter bullets. 
        '               Sets values of Width and Hight of animation frame.
        '
        'Called by:     frmSpaceFighter_Load
        '----------------------------------------------------------------------

        For i = 0 To MAX_BULLETS
            Dim shtRandomNumber As Short = CShort(Rnd() * BULLETS_W_FRAMES)
            bmpBullets = New Bitmap(strImageFolder & "LASER.png")
            cshtBulletsW(i) = CShort(bmpBullets.Width \ BULLETS_W_FRAMES)
            cshtBulletsH(i) = CShort(bmpBullets.Height \ BULLETS_H_FRAMES)
            graBullets = Graphics.FromImage(bmpBuffer)
            cshtBulletsFrameX(i) = cshtBulletsW(i) * shtRandomNumber
            cshtBulletsFrameY(i) = 0
            bmpBullets.MakeTransparent(Color.FromArgb(255, 0, 255))
        Next i

    End Sub

    Private Sub btnResume_Click(sender As System.Object, _
                               e As System.EventArgs) Handles btnResume.Click
        '----------------------------------------------------------------------
        'Description:   Un-pauses game and calls the Pause Subrutine to start  
        '               the game back up. 
        '          
        'Calls:         Pause
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        cblnPause = False
        Call Pause()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, _
                              e As System.EventArgs) Handles btnExit.Click
        '----------------------------------------------------------------------
        'Description:   Exits the program.
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        Me.Close()

    End Sub

    Private Sub btnChgBckgrnd_Click(sender As System.Object, _
                            e As System.EventArgs) Handles btnChgBckgrnd.Click
        '----------------------------------------------------------------------
        'Description:   Changes the background image each time it is click.
        '
        'Calls:         BackgroundChange
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        Call BackgroundChange()

    End Sub

    Private Sub BackgroundChange()
        '----------------------------------------------------------------------
        'Description:   Cycles through the form background images.
        '
        'Called by:     btnChgBckgrnd_Click
        '               GameEnd
        '               frmSpaceFighter_Load
        '----------------------------------------------------------------------

        cbyteBackGround = CByte(cbyteBackGround + 1)
        Me.BackgroundImage = _
            Image.FromFile(strBGImageFolder & "BackGround" & _
                           cbyteBackGround & ".jpg")
        If cbyteBackGround = MAX_FORM_BACKGROUNDS Then
            cbyteBackGround = 0
        End If

    End Sub

    Private Sub btnFullScreen_Click(sender As System.Object, _
                            e As System.EventArgs) Handles btnFullScreen.Click
        '----------------------------------------------------------------------
        'Description:   Toggles full screen property of the form.
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        If WindowState = FormWindowState.Normal Then

            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            btnFullScreen.Text = "Exit Full Sc&reen"
            pnlContainAll.Left = CInt((Me.Width - pnlContainAll.Width) \ 2)
            pnlContainAll.Top = CInt((Me.Height - pnlContainAll.Height) \ 2)
            pnlMultiUseScreen.Left = pnlGameSpace.Left + pnlContainAll.Left
            pnlMultiUseScreen.Top = pnlGameSpace.Top + pnlContainAll.Top

        Else

            Me.WindowState = FormWindowState.Normal
            btnFullScreen.Text = "Full Sc&reen"
            pnlContainAll.Location = New Point(0, 0)
            FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            pnlMultiUseScreen.Location = pnlGameSpace.Location

        End If

    End Sub

    Private Sub Pause()
        '----------------------------------------------------------------------
        'Description:   Sets the 'paused state' of the game and back to 
        '               game-play.
        '
        'Called by:     frmAnimation_KeyDown
        '               btnResume_Click
        '
        'Calls:         GamePlay
        '----------------------------------------------------------------------

        If cblnPause = True Then
            grpControls.Enabled = True
            btnResume.Enabled = True
            wmpBGMusic.Ctlcontrols.pause()
            wmpDamage.Ctlcontrols.stop()
            wmpHealth.Ctlcontrols.stop()
            wmpShooting.Ctlcontrols.stop()
            wmpMenuBG2.Ctlcontrols.play()
            pnlMultiUseScreen.BackgroundImage = _
                        Image.FromFile(strImageFolder & "PauseScreen.png")
            cchrMenuScreenStatus = "p"c
            pnlMultiUseScreen.Visible = True
            pnlScore.Visible = False
        Else
            pnlMultiUseScreen.Visible = False
            pnlOptions.Visible = False
            grpControls.Enabled = False
            cblnReturnFromPause = True
            pnlFlash.Visible = False
            pnlScore.Visible = True
            Call GamePlay()
        End If

    End Sub

    Private Sub FighterMovement()
        '----------------------------------------------------------------------
        'Description:   Moves the fighter around based on user key inputs.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        If cblnFighterDeath = False Then

            If cblnDown = True Then
                cshtFighterFrameY = cshtFighterH * 3S
                If cshtFighterY < (cshtViewHeight - 10 - cshtFighterH) Then
                    cshtFighterY += cbytFighterYStep - 1S
                End If
            End If

            If cblnDown = True Then
                cshtFighterFrameY = cshtFighterH * 3S
                If cshtFighterY < (cshtViewHeight - 10 - cshtFighterH) Then
                    cshtFighterY += cbytFighterYStep - 1S
                End If
            End If

            If cblnUp = True Then
                cshtFighterFrameY = 0
                If cshtFighterY > 0 Then
                    cshtFighterY -= cbytFighterYStep
                End If
            End If

            If cblnRight = True Then
                cshtFighterFrameY = cshtFighterH * 2S
                If cshtFighterX < (cshtViewWidth - 10 - cshtFighterW) Then
                    cshtFighterX += cbytFighterXStep
                End If
            End If

            If cblnLeft = True Then
                cshtFighterFrameY = cshtFighterH * 1S
                If cshtFighterX > 0 Then
                    cshtFighterX -= cbytFighterXStep
                End If
            End If

            If cblnLeft = True And cblnRight = True Then
                cshtFighterFrameY = 0
            End If

            If cblnLeft = True And cblnRight = True And cblnDown = True Then
                cshtFighterFrameY = cshtFighterH * 3S
            End If

            If cblnDown = False And cblnUp = False And _
                cblnRight = False And cblnLeft = False Then
                cshtFighterFrameY = 0
            End If
        End If

    End Sub

    Private Sub ObstacleMovement()
        '----------------------------------------------------------------------
        'Description:   Sets obstacle movements to move with the background.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        For i = 0 To cshtObstacleLevel
            If cblnObstacleActive(i) = True Then
                cshtObstacleY(i) += cbytObstacleStep
                If cshtObstacleY(i) > cshtViewHeight Then
                    cblnObstacleActive(i) = False
                End If
            End If
        Next i

    End Sub

    Private Sub BulletMovement()
        '----------------------------------------------------------------------
        'Description:   Fires and moves the bullets on the game screen.
        '               Also removes bullets that have gone past the game 
        '               screen. 
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'Stop firing if fighter is exploding
        If cblnFighterDeath = False Then

            'Fire new bullets
            If cblnShoot = True Then
                If cbytBulletDelay = 0 Then
                    If cbytBulletCount < MAX_BULLETS Then
                        cbytBulletCount += CByte(1)
                    Else
                        cbytBulletCount = 0
                    End If

                    wmpShooting.Ctlcontrols.play()
                    cblnBulletsActive(cbytBulletCount) = True
                    cshtBulletsX(cbytBulletCount) = _
                                CShort(cshtFighterX + cshtFighterW \ 2 - _
                                cshtBulletsW(cbytBulletCount) \ 2)
                    cshtBulletsY(cbytBulletCount) = cshtFighterY
                    cbytBulletDelay = 2
                Else 'Sets trigger to semi-automatic
                    cbytBulletDelay = 2
                End If
            End If
        End If

        'Keep from firing rate as full-automatic
        If cbytBulletDelay > 0 Then
            cbytBulletDelay -= CByte(1)
        End If

        'Move all of the active bullets
        For i = 0 To MAX_BULLETS
            If cblnBulletsActive(i) = True Then
                cshtBulletsY(i) += cbytBulletsStep
                If cshtBulletsY(i) + cshtBulletsH(i) <= 0 Then
                    cblnBulletsActive(i) = False
                    clngScore += _
                            cshtBulletsWastedScore * cshtLevelScoreMultiplyer
                    If clngScore < 0 Then
                        clngScore = 0
                    End If
                    lblGameUI.Text = CStr(clngScore)
                End If
            End If
        Next

    End Sub

    Private Sub BossMovement()
        '----------------------------------------------------------------------
        'Description:   Moves the boss left and right in game screen.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'Stop moving the boss if it is exploding
        If cblnBossDeath = False Then

            'Move the boss left and right
            If cblnBossMoveLeft = True Then
                cshtBossX -= cbytBossXStep
                cshtBossFrameY = cshtBossH
                If cshtBossX <= cshtFighterW \ 2 Then
                    cblnBossMoveLeft = False
                End If
            Else
                cshtBossX += cbytBossXStep
                cshtBossFrameY = cshtBossH * 2S
                If cshtBossX >= _
                            cshtViewWidth - cshtBossW - cshtFighterW \ 2 Then
                    cblnBossMoveLeft = True
                End If
            End If
        End If

    End Sub

    Private Sub BossBulletMovement(intLoopCount As Integer)
        '----------------------------------------------------------------------
        'Description:   Fires the bullets by the boss and moves them on the
        '               screen. Also removes bullets from an active state when
        '               they have left the visible area. 
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'Stop firing if the boss is exploding
        If cblnBossDeath = False Then

            'Pauses the bullets from firing 
            If cblnBossShootBulletsActive = False Then

                'Set fire rate
                If intLoopCount Mod 25 = 0 Then

                    'Cycle through the bullet arrays
                    If cbytBossBulletCount < MAX_BOSS_BULLETS Then
                        cbytBossBulletCount += CByte(1)
                    Else
                        cbytBossBulletCount = 0
                    End If

                    'Set bullet firing position
                    cblnBossBulletsActive(cbytBossBulletCount) = True
                    cshtBossBulletsX(cbytBossBulletCount) = _
                        CShort(cshtBossX + cshtBossW * 0.35 - _
                            cshtBossBulletsW(cbytBossBulletCount) \ 2)
                    cshtBossBulletsY(cbytBossBulletCount) = _
                        CShort(cshtBossY + cshtBossH * 0.75)

                    'Fire the second bullet & cycle through the bullet arrays
                    If cbytBossBulletCount < MAX_BOSS_BULLETS Then
                        cbytBossBulletCount += CByte(1)
                    Else
                        cbytBossBulletCount = 0
                    End If

                    'Set bullet firing position
                    cblnBossBulletsActive(cbytBossBulletCount) = True
                    cshtBossBulletsX(cbytBossBulletCount) = _
                        CShort(cshtBossX + cshtBossW * 0.65 - _
                            cshtBossBulletsW(cbytBossBulletCount) \ 2)
                    cshtBossBulletsY(cbytBossBulletCount) = _
                        CShort(cshtBossY + cshtBossH * 0.75)
                End If
            End If
        End If

        'Pauses the bullets from firing
        If intLoopCount Mod 200 = 0 Then
            cblnBossShootBulletsActive = Not cblnBossShootBulletsActive
        End If

        'Move the active bullets
        For i = 0 To MAX_BOSS_BULLETS
            If cblnBossBulletsActive(i) = True Then
                cshtBossBulletsY(i) += cbytBossBulletsStep
                If cshtBossBulletsY(i) + cshtBossBulletsH(i) <= 0 Then
                    cblnBossBulletsActive(i) = False
                End If
            End If
        Next

    End Sub

    Private Sub BackgroundMovement()
        '----------------------------------------------------------------------
        'Description:   Moves the game-play background. If returning from
        '               pause, will return background to its former location.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        If cblnReturnFromPause = True Then
            graBGBuffer.MultiplyTransform(mtxPause)
            mtxPause = New Matrix(1, 0, 0, 1, 0, 0)
        End If

        graBGBuffer.MultiplyTransform(mtxBackGround)

    End Sub

    Private Sub ObstaclePlacement()
        '----------------------------------------------------------------------
        'Description:   Places the obstacles on the game-play space. Sets 
        '               unused obstacles to not active. 
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'Place the obstacles in a random spot on the background
        For i = 0 To cshtObstacleLevel
            cshtObstacleX(i) = CShort(Rnd() * (cshtViewWidth - cshtObstacleW(i)))
            cshtObstacleY(i) = CShort(-Rnd() * (bmpBG.Height - _
                                                (cshtViewHeight * 2)))
            cblnObstacleActive(i) = True
        Next i

        'Make sure any unactive obstacles remain unactive
        If cshtObstacleLevel <> MAX_OBSTACLE Then
            For i = cshtObstacleLevel + 1 To MAX_OBSTACLE
                cblnObstacleActive(i) = False
            Next i
        End If

    End Sub

    Private Sub PowerUpPlacement()
        '----------------------------------------------------------------------
        'Description:   Places the power up on the game-play space.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        Dim bytDirection As Byte = CByte(Int(Rnd() * 2))

        'Set the Power Up to travel across the screen from a random side
        If bytDirection = 0 Then
            cbytPowerUpsStep = -1
            cshtPowerUpsX = cshtViewWidth
        Else
            cbytPowerUpsStep = 1
            cshtPowerUpsX = -cshtPowerUpsW
        End If

        'Set the Power Up to be in the top half of the board
        cshtPowerUpsY = CShort(Rnd() * cshtViewHeight) \ 2S
        cblnPowerUpsActive = True

    End Sub

    Private Sub DrawGraphics(intLoopCount As Integer)
        '----------------------------------------------------------------------
        'Description:   Draws all of the graphics on the screen.
        '
        'Called by:     GamePlay
        '               frmSpaceFighter_Paint
        '----------------------------------------------------------------------

        'Draw the game background
        graBGBuffer.DrawImage(bmpBG, 0, -cshtStartY)

        'Draw the bullets
        For i = 0 To MAX_BULLETS
            If cblnBulletsActive(i) = True Then
                If intLoopCount Mod 12 = 0 Then
                    If cshtBulletsFrameX(i) >= _
                        bmpBullets.Width - cshtBulletsW(i) Then
                        cshtBulletsFrameX(i) = 0
                    Else
                        cshtBulletsFrameX(i) += cshtBulletsW(i)
                    End If
                End If
                recFrame = New Rectangle(cshtBulletsFrameX(i), _
                                         cshtBulletsFrameY(i), _
                                         cshtBulletsW(i), _
                                         cshtBulletsH(i))
                graBullets.DrawImage(bmpBullets, cshtBulletsX(i), _
                                     cshtBulletsY(i), recFrame, _
                                     GraphicsUnit.Pixel)
            End If
        Next i

        'Draw the fighter
        recFrame = New Rectangle(cshtFighterFrameX, cshtFighterFrameY, _
                                 cshtFighterW, cshtFighterH)
        graFighter.DrawImage(bmpFighter, cshtFighterX, cshtFighterY, _
                             recFrame, GraphicsUnit.Pixel)
        If intLoopCount Mod 20 = 0 Then
            If cshtFighterFrameX >= bmpFighter.Width - cshtFighterW Then
                If cblnPowerUpsStart = True Then
                    cblnPowerUpsStart = False
                    Call SetFighter()
                End If
                If cblnFighterDeath = False Then
                    cshtFighterFrameX = 0
                End If
            Else
                cshtFighterFrameX += cshtFighterW
            End If
        End If

        'Only draw the boss or the obstacles
        If cblnBoss = True Then

            'Draw the Boss
            recFrame = New Rectangle(cshtBossFrameX, cshtBossFrameY, _
                                     cshtBossW, cshtBossH)
            graBoss.DrawImage(bmpBoss, cshtBossX, cshtBossY, _
                              recFrame, GraphicsUnit.Pixel)
            If intLoopCount Mod 20 = 0 Then
                If cshtBossFrameX >= bmpBoss.Width - cshtBossW Then
                    cshtBossFrameX = 0
                Else
                    cshtBossFrameX += cshtBossW
                End If
            End If

            'Draw the boss bullets
            For i = 0 To MAX_BOSS_BULLETS
                If cblnBossBulletsActive(i) = True Then
                    recFrame = New Rectangle(cshtBossBulletsFrameX(i), _
                                             cshtBossBulletsFrameY(i), _
                                             cshtBossBulletsW(i), _
                                             cshtBossBulletsH(i))
                    graBossBullets.DrawImage(bmpBossBullets, _
                                             cshtBossBulletsX(i), _
                                             cshtBossBulletsY(i), _
                                             recFrame, _
                                             GraphicsUnit.Pixel)
                    If intLoopCount Mod 8 = 0 Then
                        If cshtBossBulletsFrameX(i) >= _
                            bmpBossBullets.Width - cshtBossBulletsW(i) Then
                            cshtBossBulletsFrameX(i) = 0
                        Else
                            cshtBossBulletsFrameX(i) += cshtBossBulletsW(i)
                        End If
                    End If
                End If
            Next i
        Else

            'Draw Obstacles
            graObstacle = Graphics.FromImage(bmpBuffer)
            For i = 0 To cshtObstacleLevel
                If cblnObstacleActive(i) = True Then
                    If intLoopCount Mod 30 = 0 Then
                        If cshtObstacleFrameX(i) >= _
                              bmpObstacle(CInt(cbytObstacleImage(i))).Width - _
                                               cshtObstacleW(i) Then
                            cshtObstacleFrameX(i) = 0
                        Else
                            cshtObstacleFrameX(i) += cshtObstacleW(i)
                        End If
                    End If
                    recFrame = New Rectangle(cshtObstacleFrameX(i), _
                                             cshtObstacleFrameY(i), _
                                             cshtObstacleW(i), _
                                             cshtObstacleH(i))
                    graObstacle. _
                        DrawImage(bmpObstacle(CInt(cbytObstacleImage(i))), _
                                              cshtObstacleX(i), _
                                              cshtObstacleY(i), recFrame, _
                                              GraphicsUnit.Pixel)
                End If
            Next i
        End If

        'Draw Power Ups
        If cblnPowerUpsActive = True Then
            If intLoopCount Mod 20 = 0 Then
                If cshtPowerUpsFrameX >= _
                            bmpPowerUps.Width - cshtPowerUpsW Then
                    cshtPowerUpsFrameX = 0
                Else
                    cshtPowerUpsFrameX += cshtPowerUpsW
                End If
            End If
            cshtPowerUpsX += cbytPowerUpsStep 'Move the powerups
            recFrame = New Rectangle(cshtPowerUpsFrameX, _
                                     cshtPowerUpsFrameY, _
                                     cshtPowerUpsW, _
                                     cshtPowerUpsH)
            graPowerUps.DrawImage(bmpPowerUps, _
                                  cshtPowerUpsX, _
                                  cshtPowerUpsY, _
                                 recFrame, _
                                 GraphicsUnit.Pixel)
        End If

        'Draw the explosions
        For i = 0 To MAX_EXPLOSION
            If cblnExplosionActive(i) = True Then
                If intLoopCount Mod 5 = 0 Then
                    If cshtExplosionFrameX(i) >= _
                                bmpExplosion.Width - cshtExplosionW(i) Then
                        cblnExplosionActive(i) = False
                    Else
                        cshtExplosionFrameX(i) += cshtExplosionW(i)
                    End If
                End If
                recFrame = New Rectangle(cshtExplosionFrameX(i), _
                                         cshtExplosionFrameY(i), _
                                         cshtExplosionW(i), _
                                         cshtExplosionH(i))
                graExplosion.DrawImage(bmpExplosion, _
                                       cshtExplosionX(i), _
                                       cshtExplosionY(i), _
                                       recFrame, _
                                       GraphicsUnit.Pixel)
            End If
        Next i

        graBG.DrawImage(bmpBuffer, 0, 0)

    End Sub

    Private Sub bossStart(intLoopCounter As Integer)
        '----------------------------------------------------------------------
        'Description:   Animation to introduce the boss fight. Stop user input.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        'End normal game play and set to BOSS MODE
        If cshtBossStartCounter = 0 Then
            cshtFighterFrameY = cshtFighterH * 3S
            pnlFlash.Top = 0
            pnlFlash.Left = 0
            pnlFlash.Size = Me.Size
            pnlFlash.BackColor = Color.Red
            pnlFlash.Visible = True
            wmpBGMusic.Ctlcontrols.stop()
            wmpBossBG.Ctlcontrols.stop()
            wmpBossBG.URL = strMusicFolder & "bossintro.mp3"
            wmpBossBG.Ctlcontrols.play()

            'Switch the foreground color between white and red
        ElseIf cshtBossStartCounter = 10 Then
            pnlFlash.BackColor = Color.White
        ElseIf cshtBossStartCounter = 20 Then
            pnlFlash.BackColor = Color.Red
        ElseIf cshtBossStartCounter = 30 Then
            pnlFlash.BackColor = Color.White
        ElseIf cshtBossStartCounter = 40 Then
            pnlFlash.BackColor = Color.Red
        ElseIf cshtBossStartCounter = 50 Then
            pnlFlash.BackColor = Color.White
        ElseIf cshtBossStartCounter = 60 Then
            pnlFlash.BackColor = Color.Red
        ElseIf cshtBossStartCounter = 70 Then
            pnlFlash.BackColor = Color.White

            'Show the boss entering the screen. Move the fighter down.
        ElseIf cshtBossStartCounter > 80 Then
            pnlFlash.Visible = False
            If cshtFighterY < 300 Then
                cshtFighterY += 1S
            End If

            If cshtFighterX > 500 Then
                cshtFighterX -= 1S
            End If

            If cshtFighterX < 100 Then
                cshtFighterX += 1S
            End If

            If cshtBossY < cshtBossH + 100 Then
                cshtBossY += cbytBossYStep
            End If

        End If

        'Resume normal gameplay vs boss
        If cshtBossStartCounter > (cshtBossH + 100) Then
            cblnBossStart = False
            Call DrawGraphics(cshtBossStartCounter)
        End If

        'Keep the background moving
        Call BackgroundMovement()
        Call DrawGraphics(intLoopCounter)
        Application.DoEvents()

        cshtBossStartCounter += 1S

    End Sub

    Private Function fCrash(intObject1X As Integer, intObject1Y As Integer, _
                            intObject1W As Integer, intObject1H As Integer, _
                            intObject2X As Integer, intObject2Y As Integer, _
                            intObject2W As Integer, intObject2H As Integer) _
                        As Boolean
        '----------------------------------------------------------------------
        'Description:   Compares two objects to see if they occupy the same
        '               space on the screen.
        '
        'Return:		Boolean value
        '
        'Called by:     FighterCollesion
        '               PowerUpCollesion
        '               ObstacleCollesion
        '               BossVsFighterCollesion
        '               BossVsBulletsCollesion
        '               BossVsBulletsCollesion
        '               FighterVsBossBulletsCollesion
        '----------------------------------------------------------------------

        Dim blnReturnValue As Boolean = False

        If intObject1X + intObject1W >= intObject2X And _
            intObject1X <= intObject2X + intObject2W And _
            intObject1Y + intObject1H >= intObject2Y And _
            intObject1Y <= intObject2Y + intObject2H Then
            blnReturnValue = True
        End If

        Return blnReturnValue

    End Function

    Private Sub ObstacleHit(intObstacleHit As Integer)
        '----------------------------------------------------------------------
        'Description:   Plays a sound to indecate that the obstacle has been 
        '               hit. Records point values.
        '
        'Called by:     ObstacleCollesion
        '----------------------------------------------------------------------

        wmpDamage.URL = strSFXFolder & "sfx_asteroidhit.mp3"
        wmpDamage.Ctlcontrols.play()
        Call ExplosionStart(intObstacleHit, 1)
        clngScore += cshtObstacleScore * cshtLevelScoreMultiplyer
        If clngScore < 0 Then
            clngScore = 0
        End If
        lblGameUI.Text = CStr(clngScore)

    End Sub

    Private Sub ExplosionStart(intObstacleHit As Integer, bytType As Byte)
        '----------------------------------------------------------------------
        'Description:   Sets an explosion at the location of the object or the
        '				bullet depending on the type of collision.
        '
        'Parameters:	intObstacleHit - the array number of the object hit
        '				bytType - The type of object hit
        '						1 = obstacle
        '						2 = bullet
        '						3 = boss bullet
        '
        'Called by:     ObstacleCollesion
        '----------------------------------------------------------------------

        Dim intX As Integer
        Dim intY As Integer
        Dim intW As Integer
        Dim intH As Integer

        'Get position values for the explosion
        If bytType = 1 Then
            cblnObstacleActive(intObstacleHit) = False
            intX = cshtObstacleX(intObstacleHit)
            intY = cshtObstacleY(intObstacleHit)
            intW = cshtObstacleW(intObstacleHit)
            intH = cshtObstacleH(intObstacleHit)
        ElseIf bytType = 2 Then
            cblnBulletsActive(intObstacleHit) = False
            intX = cshtBulletsX(intObstacleHit)
            intY = cshtBulletsY(intObstacleHit)
            intW = cshtBulletsW(intObstacleHit)
            intH = 1
        Else
            cblnBossBulletsActive(intObstacleHit) = False
            intX = cshtBossBulletsX(intObstacleHit)
            intY = cshtBossBulletsY(intObstacleHit)
            intW = cshtBossBulletsW(intObstacleHit)
            intH = cshtBossBulletsH(intObstacleHit) * 2
        End If

        'Find the next availble explosion animation
        If cbytexplosionCounter > MAX_EXPLOSION Then
            cbytexplosionCounter = 0
        End If

        'Activate the explosion and set its position
        cblnExplosionActive(cbytexplosionCounter) = True
        cshtExplosionX(cbytexplosionCounter) = _
                    CShort(intX + intW \ 2 - _
                        cshtExplosionW(cbytexplosionCounter) \ 2)
        cshtExplosionY(cbytexplosionCounter) = _
                    CShort(intY + intH \ 2 - _
                        cshtExplosionH(cbytexplosionCounter) \ 2)
        cshtExplosionFrameX(cbytexplosionCounter) = 0
        cshtExplosionFrameY(cbytexplosionCounter) = 0

        cbytexplosionCounter += 1S

    End Sub

    Private Sub SetExplosion()
        '----------------------------------------------------------------------
        'Description:	Sets the explosion graphics and related variables.
        '
        'Called by:		frmSpaceFighter_Load
        '----------------------------------------------------------------------

        bmpExplosion = New Bitmap(strImageFolder & "EXPLOSION01.png")
        bmpExplosion.MakeTransparent(Color.FromArgb(255, 0, 255))

        For i = 0 To MAX_EXPLOSION
            cshtExplosionFrameX(i) = 0
            cshtExplosionW(i) = CShort(bmpExplosion.Width \ EXPLOSION_W_FRAMES)
            cshtExplosionH(i) = CShort(bmpExplosion.Height \ _
                                       EXPLOSION_H_FRAMES)
            graExplosion = Graphics.FromImage(bmpBuffer)
        Next i

    End Sub

    Private Sub FighterHit(inthit As Integer, bytType As Byte)
        '----------------------------------------------------------------------
        'Description:   Reduces the health of the fighter and plays a sound to
        '               indicate damage to the fighter. Records point values. 
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        If bytType = 2 Then
            Call ExplosionStart(inthit, 3)
            clngScore += cshtBossBulletsScore * cshtLevelScoreMultiplyer
        Else
            clngScore += cshtFighterScore * cshtLevelScoreMultiplyer
        End If

        wmpDamage.URL = strSFXFolder & "sfx_asteroidhit.mp3"
        wmpDamage.Ctlcontrols.play()

        cshtFighterHealth -= 1S
        If clngScore < 0 Then
            clngScore = 0
        End If
        lblGameUI.Text = CStr(clngScore)

    End Sub

    Private Sub PowerUpsHit()
        '----------------------------------------------------------------------
        'Description:   Gives health to the fighter and plays a sound to 
        '               indecate the fighter's higher health value. Also plays
        '               Power Up animation.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        wmpHealth.URL = strSFXFolder & "sfx_healthpickup.mp3"
        wmpHealth.Ctlcontrols.play()
        cshtFighterHealth += cshtFighterMaxHealth \ 2S
        cblnPowerUpsStart = True

        cshtFighterFrameX = 0
        bmpFighter = New Bitmap(strImageFolder & "POWERUPANIMATION.png")
        bmpFighter.MakeTransparent(Color.FromArgb(255, 0, 255))

    End Sub

    Private Sub BossHit(intHitType As Integer, intBulletHit As Integer)
        '----------------------------------------------------------------------
        'Description:   Records hits to the boss. Plays sounds and records 
        '               point values. Lowers boss's health.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        If intHitType = 2 Then
            clngScore += cshtBossHitScore * cshtLevelScoreMultiplyer
            Call ExplosionStart(intBulletHit, 2)
        ElseIf intHitType = 1 Then
            clngScore += cshtFighterScore * cshtLevelScoreMultiplyer
            cshtFighterHealth -= 1S
        End If
        cshtBossHealth -= CByte(1)
        wmpDamage.Ctlcontrols.play()

        If clngScore < 0 Then
            clngScore = 0
        End If
        lblGameUI.Text = CStr(clngScore)

    End Sub

    Private Sub UpdateHealths()
        '----------------------------------------------------------------------
        'Description:   Updates the health bars for the fighter and the boss.
        '
        'Called by:     GamePlay
        '----------------------------------------------------------------------

        Dim intHealthNumber As Integer

        'Find Fighter health
        If cshtFighterHealth > cshtFighterMaxHealth Then
            cshtFighterHealth = cshtFighterMaxHealth
        ElseIf cshtFighterHealth <= 0 Then
            cshtFighterHealth = 0
            Call FighterDeath() 'Call end of game commands
        End If

        'Get health percentage of fighter
        intHealthNumber = CInt(cshtFighterHealth / cshtFighterMaxHealth * 10)

        'Update health bar for fighter
        If cshtFighterHealthPercent <> intHealthNumber Then
            picFighterHealth.Image = _
                        Image.FromFile(strImageFolder & _
                                       "PLAYER_HEALTH_BAR\HEALTHBAR" & _
                                       intHealthNumber & ".png")
            cshtFighterHealthPercent = CShort(intHealthNumber)
        End If

        'Only track boss health when boss is active
        If cblnBoss = True Then

            'Find Boss health
            If cshtBossHealth > cshtBossMaxHealth Then
                cshtBossHealth = cshtBossMaxHealth
            ElseIf cshtBossHealth <= 0 Then
                cshtBossHealth = 0
                Call BossDeath() 'Call end of game commands
            End If

            'Get health percentage of boss
            intHealthNumber = CInt(cshtBossHealth / cshtBossMaxHealth * 10)

            'Update health bar for boss
            If cshtBossHealthPercent <> intHealthNumber Then
                picBossHealth.Image = _
                            Image.FromFile(strImageFolder & _
                                           "BOSS_HEALTH_BAR\BOSSHEALTH" & _
                                           intHealthNumber & ".png")
                cshtBossHealthPercent = CShort(intHealthNumber)
            End If
            picBossHealth.Visible = True
        Else
            picBossHealth.Visible = False
        End If

    End Sub

    Private Sub FighterDeath()
        '----------------------------------------------------------------------
        'Description:   Sets the animation of the fighter death and starts the
        '               end of game sequence. 
        '
        'Called by:     UpdateHealths
        '----------------------------------------------------------------------

        cblnFighterDeath = True
        wmpBossBG.Ctlcontrols.stop()
        wmpBGMusic.Ctlcontrols.stop()
        wmpDamage.URL = strSFXFolder & "sfx_gameover.mp3"
        wmpDamage.Ctlcontrols.play()

        bmpFighter = New Bitmap(strImageFolder & "SHIPBLOWUP.png")
        cshtFighterW = CShort(bmpFighter.Width \ FIGHTER_W_FRAMES)
        cshtFighterH = CShort(bmpFighter.Height)
        cshtFighterFrameY = 0
        cshtFighterFrameX = 0
        graFighter = Graphics.FromImage(bmpBuffer)
        bmpFighter.MakeTransparent(Color.FromArgb(255, 0, 255))

    End Sub

    Private Sub BossDeath()
        '----------------------------------------------------------------------
        'Description:   Sets the animation of the boss death and starts the
        '               end of game sequence. 
        '
        'Called by:     UpdateHealths
        '----------------------------------------------------------------------

        cblnBossDeath = True
        wmpBossBG.Ctlcontrols.stop()
        wmpBGMusic.Ctlcontrols.stop()

        clngScore += cshtBossDefeatedScore
        bmpBoss = New Bitmap(strImageFolder & "BOSS_BLOWUP.png")
        cshtBossW = CShort(bmpBoss.Width \ BOSS_W_FRAMES * 4)
        cshtBossH = CShort(bmpBoss.Height)
        cshtBossFrameY = 0
        cshtBossFrameX = 0
        graBoss = Graphics.FromImage(bmpBuffer)
        bmpBoss.MakeTransparent(Color.FromArgb(255, 0, 255))

    End Sub

    Private Sub ButtonColors()
        '----------------------------------------------------------------------
        'Description:   Sets the button background colour. 
        '
        'Called by:     frmSpaceFighter_Load
        '----------------------------------------------------------------------

        Dim clrBtnBackcolor As Color = Color.FromArgb(175, 0, 0, 0)
        btnExit.BackColor = clrBtnBackcolor
        btnResume.BackColor = clrBtnBackcolor
        btnFullScreen.BackColor = clrBtnBackcolor
        btnStart.BackColor = clrBtnBackcolor
        btnOptions.BackColor = clrBtnBackcolor
        btnCredits.BackColor = clrBtnBackcolor
        btnChgBckgrnd.BackColor = clrBtnBackcolor
        btnTitleScreen.BackColor = clrBtnBackcolor
        btnClearHistory.BackColor = clrBtnBackcolor

    End Sub

    Private Sub FighterCollesion()
        '----------------------------------------------------------------------
        'Description:   Fighter vs Obstacle Collision. Plays explosion
        '               animation when fighter collides with obstacle.
        '
        'Called by:     GamePlay
        '
        'Calls:			FighterHit
        '				ExplosionStart
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        For i As Integer = 0 To MAX_OBSTACLE
            If cblnObstacleActive(i) = True And cblnFighterDeath = False Then
                Dim blnFighterHit As Boolean = _
                        fCrash(cshtFighterX, cshtFighterY, _
                        cshtFighterW, cshtFighterH, _
                        cshtObstacleX(i), cshtObstacleY(i), _
                        cshtObstacleW(i), cshtObstacleH(i))
                If blnFighterHit = True Then
                    Call FighterHit(0, 1)
                    Call ExplosionStart(i, 1)
                End If
            End If
        Next i

    End Sub

    Private Sub PowerUpCollesion()
        '----------------------------------------------------------------------
        'Description:   Fighter vs Power Up Collision. Plays Power Up
        '               animation when fighter collides with Power Up.
        '
        'Called by:     GamePlay
        '
        'Calls:			PowerUpsHit
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        If cblnPowerUpsActive = True Then
            Dim blnPowerUps As Boolean = _
                    fCrash(cshtFighterX, cshtFighterY, _
                    cshtFighterW, cshtFighterH, _
                    cshtPowerUpsX, cshtPowerUpsY, _
                    cshtPowerUpsW, cshtPowerUpsH)
            If blnPowerUps = True Then
                Call PowerUpsHit()
                cblnPowerUpsActive = False
            End If
        End If

    End Sub

    Private Sub ObstacleCollesion()
        '----------------------------------------------------------------------
        'Description:   Bullet vs Obstacle Collision. Plays explosion
        '               animation when bullet collides with obstacle.
        '
        'Called by:     GamePlay
        '
        'Calls:			ObstacleHit
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        For i As Integer = 0 To MAX_BULLETS
            If cblnBulletsActive(i) = True Then
                For j As Integer = _
                    0 To cshtObstacleLevel
                    If cblnObstacleActive(j) = True Then
                        Dim blnObstacleHit As Boolean = _
                            fCrash(cshtBulletsX(i) - cshtBulletsW(i), _
                                   cshtBulletsY(i), _
                                   cshtBulletsW(i) * 3, cshtBulletsH(i), _
                                   cshtObstacleX(j), cshtObstacleY(j), _
                                   cshtObstacleW(j), cshtObstacleH(j))
                        If blnObstacleHit = True Then
                            Call ObstacleHit(j)
                            cblnBulletsActive(i) = False
                        End If
                    End If
                Next j
            End If
        Next i

    End Sub

    Private Sub BossVsFighterCollesion()
        '----------------------------------------------------------------------
        'Description:   Boss vs Fighter Collision. Boss takes hit.
        '
        'Called by:     GamePlay
        '
        'Calls:			BossHit
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        Dim blnBossHit As Boolean = _
                        fCrash(cshtFighterX, cshtFighterY, _
                        cshtFighterW, cshtFighterH, _
                        cshtBossX, cshtBossY, cshtBossW, _
                        CInt(cshtBossH * 0.75))
        If blnBossHit = True Then
            Call BossHit(1, 0)
        End If

    End Sub

    Private Sub BossVsBulletsCollesion()
        '----------------------------------------------------------------------
        'Description:   Boss vs Bullets Collision. Plays explosion
        '               animation when bullets collides with boss.
        '
        'Called by:     GamePlay
        '
        'Calls:			BossHit
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        For i As Integer = 0 To MAX_BULLETS
            If cblnBulletsActive(i) = True Then
                Dim blnBossHit As Boolean = _
                            fCrash(cshtBulletsX(i) - cshtBulletsW(i), _
                                   cshtBulletsY(i), _
                                   cshtBulletsW(i) * 3, cshtBulletsH(i), _
                                   cshtBossX, cshtBossY, _
                                   cshtBossW, CInt(cshtBossH * 0.75))
                If blnBossHit = True Then
                    Call BossHit(2, i)
                    cblnBulletsActive(i) = False
                End If
            End If
        Next i

    End Sub

    Private Sub FighterVsBossBulletsCollesion()
        '----------------------------------------------------------------------
        'Description:   Fighter vs boss bullets Collision. Plays explosion
        '               animation when boss bullets collide with fighter.
        '
        'Called by:     GamePlay
        '
        'Calls:			FighterHit
        '
        'Functions:		fCrash
        '----------------------------------------------------------------------

        For i As Integer = 0 To MAX_BOSS_BULLETS
            If cblnBossBulletsActive(i) = True Then
                Dim blnObstacleHit As Boolean = _
                            fCrash(cshtBossBulletsX(i), cshtBossBulletsY(i), _
                                   cshtBossBulletsW(i), cshtBossBulletsH(i), _
                                   cshtFighterX, cshtFighterY, _
                                   cshtFighterW, cshtFighterH)
                If blnObstacleHit = True Then
                    Call FighterHit(i, 2)
                    cblnBossBulletsActive(i) = False
                End If
            End If
        Next i

    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) _
                                                    Handles btnCredits.Click
        '----------------------------------------------------------------------
        'Description:   Toggles the credits screen on and off.
        '----------------------------------------------------------------------

        wmpButtonClicks.Ctlcontrols.play()

        'If credits screen active, turn on the pause screen.
        If cchrMenuScreenStatus = "c" Then
            pnlMultiUseScreen.BackgroundImage = Image.FromFile(strImageFolder & _
                                                            "PauseScreen.png")
            cchrMenuScreenStatus = "p"c
            pnlMultiUseScreen.Visible = True
            pnlOptions.Visible = False

            'Turn on the credit screen if any other screen is active.
        Else
            cchrMenuScreenStatus = "c"c
            pnlMultiUseScreen.BackgroundImage = Image.FromFile(strImageFolder & _
                                                            "CREDITS.png")
            pnlMultiUseScreen.Visible = True
            pnlOptions.Visible = True
        End If

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) _
                                                    Handles btnOptions.Click
        '----------------------------------------------------------------------
        'Description:   Toggles the option screen on and off.
        '----------------------------------------------------------------------

        wmpButtonClicks.Ctlcontrols.play()

        'If options screen active, turn on the pause screen.
        If cchrMenuScreenStatus = "o" Then
            pnlMultiUseScreen.BackgroundImage = Image.FromFile(strImageFolder & _
                                                            "PauseScreen.png")
            cchrMenuScreenStatus = "p"c
            pnlMultiUseScreen.Visible = True
            pnlOptions.Visible = False

            'Turn on the option screen if any other screen is active.
        Else
            cchrMenuScreenStatus = "o"c
            pnlMultiUseScreen.Visible = False
            pnlOptions.Visible = True
        End If

    End Sub

    Private Sub wmpMenuBG_PlayStateChange(sender As Object, _
                    e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) _
                    Handles wmpMenuBG.PlayStateChange
        '----------------------------------------------------------------------
        'Description:   Keeps the music playing when title screen and
        '               end of game music stops.
        '----------------------------------------------------------------------

        'Keep the event from trigering before the load event occurs
        If cblnLoad = True Then
            If wmpMenuBG.playState = 8 Then
                wmpMenuBG2.Ctlcontrols.play()
            End If
        End If

    End Sub

    Private Sub btnTitleScreen_Click(sender As Object, e As EventArgs) _
                                                Handles btnTitleScreen.Click
        '----------------------------------------------------------------------
        'Description:   On first press, the continue button changes the opening 
        '				title screen to the story screen. On second press,
        '               change to pause screen. 
        '----------------------------------------------------------------------

        If pnlMultiUseScreen.Location.X = 0 Then
            pnlMultiUseScreen.Visible = False
            pnlMultiUseScreen.Left = pnlGameSpace.Left
            pnlMultiUseScreen.Top = pnlGameSpace.Top
            pnlMultiUseScreen.Height = pnlGameSpace.Height
            pnlMultiUseScreen.Width = pnlGameSpace.Width
            pnlMultiUseScreen.BackgroundImage = _
                Image.FromFile(strImageFolder & "STORY_SCREEN.png")
            pnlMultiUseScreen.BackgroundImageLayout = ImageLayout.Stretch
            btnTitleScreen.Left = pnlMultiUseScreen.Width - btnTitleScreen.Width
            btnTitleScreen.Top = btnTitleScreen.Height * 2
            pnlMultiUseScreen.Visible = True
            grpControls.Enabled = False
        Else
            pnlMultiUseScreen.BackgroundImage = _
                Image.FromFile(strImageFolder & "PauseScreen.png")
            cchrMenuScreenStatus = "p"c
            pnlMultiUseScreen.BackgroundImageLayout = ImageLayout.Stretch
            btnTitleScreen.Visible = False
            pnlFlash.Visible = True
            grpControls.Enabled = True
            btnTitleScreen.Visible = False
        End If

    End Sub

    Private Sub hsbAudioMaster_ValueChanged(sender As Object, _
                                            e As System.EventArgs) _
                                        Handles hsbAudioMaster.ValueChanged
        '----------------------------------------------------------------------
        'Description:   Adjusts the master volume when master volume control
        '               slider is changed.
        '
        'Calls:			SetVolumes
        '----------------------------------------------------------------------

        If cblnLoad = True Then
            Call SetVolumes()
        End If

    End Sub

    Private Sub hsbAudioMusic_ValueChanged(sender As Object, _
                                           e As System.EventArgs) _
                                       Handles hsbAudioMusic.ValueChanged
        '----------------------------------------------------------------------
        'Description:   Adjusts the music volume when music volume control 
        '               slider is changed.
        '
        'Calls:			SetVolumes
        '----------------------------------------------------------------------

        If cblnLoad = True Then
            Call SetVolumes()
        End If

    End Sub

    Private Sub hsbAudioSFX_ValueChanged(sender As Object, _
                                         e As System.EventArgs) _
                                     Handles hsbAudioSFX.ValueChanged
        '----------------------------------------------------------------------
        'Description:   Adjusts the SFX volume when SFX volume control slider 
        '               is changed.
        '
        'Calls:			SetVolumes
        '----------------------------------------------------------------------

        If cblnLoad = True Then
            Call SetVolumes()
        End If

    End Sub

    Private Sub SetVolumes()
        '----------------------------------------------------------------------
        'Description:   Adjusts the volume of sounds and music when the volume
        '				sliders are adjusted and when the program starts.
        '
        'Called by:		hsbAudioMaster_ValueChanged
        '				hsbAudioMusic_ValueChanged
        '				hsbAudioSFX_ValueChanged
        '				frmSpaceFighter_Load
        '----------------------------------------------------------------------

        Dim intSound As Integer
        Dim intMusic As Integer

        'Calculate the sound and music volumes with respect to master volume
        intSound = hsbAudioMaster.Value * hsbAudioSFX.Value \ 100
        intMusic = hsbAudioMaster.Value * hsbAudioMusic.Value \ 100

        'Give feedback to user on volume levels
        lblAudioMasterValue.Text = hsbAudioMaster.Value & "%"
        lblAudioMusicValue.Text = hsbAudioMusic.Value & "%"
        lblAudioSFXValue.Text = hsbAudioSFX.Value & "%"

        'Set volume level of all the music players. Mutes volumes if reaches 0
        If intMusic > 0 Then
            wmpBGMusic.settings.mute = False
            wmpMenuBG.settings.mute = False
            wmpBossBG.settings.mute = False
            wmpMenuBG2.settings.mute = False
            wmpBGMusic.settings.volume = intMusic
            wmpMenuBG.settings.volume = intMusic
            wmpBossBG.settings.volume = intMusic
            wmpMenuBG2.settings.volume = intMusic
        Else
            wmpBGMusic.settings.mute = True
            wmpMenuBG.settings.mute = True
            wmpBossBG.settings.mute = True
            wmpMenuBG2.settings.mute = True
        End If

        'Set volume level of all the sound players. Mutes volumes if reaches 0
        If intSound > 0 Then
            wmpButtonClicks.settings.mute = False
            wmpDamage.settings.mute = False
            wmpHealth.settings.mute = False
            wmpShooting.settings.mute = False
            wmpButtonClicks.settings.volume = intSound
            wmpDamage.settings.volume = intSound
            wmpHealth.settings.volume = intSound
            wmpShooting.settings.volume = intSound
        Else
            wmpButtonClicks.settings.mute = True
            wmpDamage.settings.mute = True
            wmpHealth.settings.mute = True
            wmpShooting.settings.mute = True
        End If

    End Sub

    Private Sub btnClearHistory_Click(sender As Object, _
                                      e As EventArgs) _
                                  Handles btnClearHistory.Click
        '----------------------------------------------------------------------
        'Description:   Clears the high score after prompting the user to 
        '               confirm intended action.
        '----------------------------------------------------------------------

        'Play the 'Button Click' sound
        wmpButtonClicks.Ctlcontrols.play()

        If MessageBox.Show("Are you sure you want to reset the high score?", _
                               "Reset High Score", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.None) _
                           = Windows.Forms.DialogResult.Yes Then
            clngHighScore = 0
            lblActualHighScore.Text = clngHighScore.ToString
            FileOpen(1, strResources & "HighS.asf", OpenMode.Output)
            WriteLine(1, clngHighScore)
            FileClose(1)

        End If

    End Sub

End Class
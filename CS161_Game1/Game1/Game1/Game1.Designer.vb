<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame1
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
        Me.btnRandomDots = New System.Windows.Forms.Button()
        Me.btnGeometricShapes = New System.Windows.Forms.Button()
        Me.btnPictures = New System.Windows.Forms.Button()
        Me.btnGradient = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlGraphics = New System.Windows.Forms.Panel()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRandomDots
        '
        Me.btnRandomDots.BackColor = System.Drawing.Color.Transparent
        Me.btnRandomDots.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandomDots.ForeColor = System.Drawing.Color.White
        Me.btnRandomDots.Location = New System.Drawing.Point(12, 527)
        Me.btnRandomDots.Name = "btnRandomDots"
        Me.btnRandomDots.Size = New System.Drawing.Size(110, 25)
        Me.btnRandomDots.TabIndex = 0
        Me.btnRandomDots.Text = "R&andom Dots"
        Me.btnRandomDots.UseVisualStyleBackColor = False
        '
        'btnGeometricShapes
        '
        Me.btnGeometricShapes.BackColor = System.Drawing.Color.Transparent
        Me.btnGeometricShapes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeometricShapes.ForeColor = System.Drawing.Color.White
        Me.btnGeometricShapes.Location = New System.Drawing.Point(127, 527)
        Me.btnGeometricShapes.Name = "btnGeometricShapes"
        Me.btnGeometricShapes.Size = New System.Drawing.Size(110, 25)
        Me.btnGeometricShapes.TabIndex = 1
        Me.btnGeometricShapes.Text = "G&eometric Shapes"
        Me.btnGeometricShapes.UseVisualStyleBackColor = False
        '
        'btnPictures
        '
        Me.btnPictures.BackColor = System.Drawing.Color.Transparent
        Me.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPictures.ForeColor = System.Drawing.Color.White
        Me.btnPictures.Location = New System.Drawing.Point(240, 527)
        Me.btnPictures.Name = "btnPictures"
        Me.btnPictures.Size = New System.Drawing.Size(110, 25)
        Me.btnPictures.TabIndex = 2
        Me.btnPictures.Text = "P&ictures"
        Me.btnPictures.UseVisualStyleBackColor = False
        '
        'btnGradient
        '
        Me.btnGradient.BackColor = System.Drawing.Color.Transparent
        Me.btnGradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradient.ForeColor = System.Drawing.Color.White
        Me.btnGradient.Location = New System.Drawing.Point(353, 527)
        Me.btnGradient.Name = "btnGradient"
        Me.btnGradient.Size = New System.Drawing.Size(110, 25)
        Me.btnGradient.TabIndex = 3
        Me.btnGradient.Text = "G&radient"
        Me.btnGradient.UseVisualStyleBackColor = False
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Transparent
        Me.btnConnect.Enabled = False
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Location = New System.Drawing.Point(469, 527)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(110, 25)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "C&onnect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(585, 527)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 25)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(707, 527)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(65, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(254, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(260, 21)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Welcome to Game 1!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGraphics
        '
        Me.pnlGraphics.BackColor = System.Drawing.Color.Transparent
        Me.pnlGraphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlGraphics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGraphics.Location = New System.Drawing.Point(28, 101)
        Me.pnlGraphics.Name = "pnlGraphics"
        Me.pnlGraphics.Size = New System.Drawing.Size(700, 420)
        Me.pnlGraphics.TabIndex = 8
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInformation.Location = New System.Drawing.Point(28, 30)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(700, 68)
        Me.lblInformation.TabIndex = 9
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGame1
        '
        Me.AcceptButton = Me.btnReset
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Game1.My.Resources.Resources.BackGround
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlGraphics)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnGradient)
        Me.Controls.Add(Me.btnPictures)
        Me.Controls.Add(Me.btnGeometricShapes)
        Me.Controls.Add(Me.btnRandomDots)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGame1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRandomDots As System.Windows.Forms.Button
    Friend WithEvents btnGeometricShapes As System.Windows.Forms.Button
    Friend WithEvents btnPictures As System.Windows.Forms.Button
    Friend WithEvents btnGradient As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlGraphics As System.Windows.Forms.Panel
    Friend WithEvents lblInformation As System.Windows.Forms.Label

End Class

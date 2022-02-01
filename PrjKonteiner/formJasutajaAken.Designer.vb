<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPikkus = New System.Windows.Forms.Label()
        Me.tsArv = New System.Windows.Forms.Label()
        Me.timerPikkus = New System.Windows.Forms.Timer(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(250, 131)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(306, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(250, 174)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(306, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(250, 255)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(306, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(250, 208)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(306, 42)
        Me.btnPoora1.TabIndex = 3
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(250, 288)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(306, 42)
        Me.btnPoora2.TabIndex = 4
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sisendtekst:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pööramine funktsiooniga:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pööramine protseduuriga:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(250, 353)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(136, 34)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(411, 353)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(145, 34)
        Me.btnStopp.TabIndex = 9
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Teksti pikkus:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Täishäälikute arv:"
        '
        'txtPikkus
        '
        Me.txtPikkus.AutoSize = True
        Me.txtPikkus.Location = New System.Drawing.Point(531, 75)
        Me.txtPikkus.Name = "txtPikkus"
        Me.txtPikkus.Size = New System.Drawing.Size(18, 20)
        Me.txtPikkus.TabIndex = 12
        Me.txtPikkus.Text = "0"
        '
        'tsArv
        '
        Me.tsArv.AutoSize = True
        Me.tsArv.Location = New System.Drawing.Point(531, 105)
        Me.tsArv.Name = "tsArv"
        Me.tsArv.Size = New System.Drawing.Size(18, 20)
        Me.tsArv.TabIndex = 13
        Me.tsArv.Text = "0"
        '
        'timerPikkus
        '
        Me.timerPikkus.Enabled = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(481, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 36)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'formJasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 574)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tsArv)
        Me.Controls.Add(Me.txtPikkus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formJasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopp As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPikkus As Label
    Friend WithEvents tsArv As Label
    Friend WithEvents timerPikkus As Timer
    Friend WithEvents btnClear As Button
End Class

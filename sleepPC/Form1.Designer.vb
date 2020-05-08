<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Restart = New System.Windows.Forms.Button()
        Me.Hibernate = New System.Windows.Forms.Button()
        Me.Sleep = New System.Windows.Forms.Button()
        Me.minuteTextBox = New System.Windows.Forms.TextBox()
        Me.Shutdown = New System.Windows.Forms.Button()
        Me.TextTimer = New System.Windows.Forms.Label()
        Me.eatect = New System.Windows.Forms.LinkLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.countDownMode = New System.Windows.Forms.RadioButton()
        Me.hourMode = New System.Windows.Forms.RadioButton()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.HourTextBox = New System.Windows.Forms.TextBox()
        Me.H = New System.Windows.Forms.Label()
        Me.M = New System.Windows.Forms.Label()
        Me.S = New System.Windows.Forms.Label()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Restart
        '
        resources.ApplyResources(Me.Restart, "Restart")
        Me.Restart.Name = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'Hibernate
        '
        resources.ApplyResources(Me.Hibernate, "Hibernate")
        Me.Hibernate.Name = "Hibernate"
        Me.Hibernate.UseVisualStyleBackColor = True
        '
        'Sleep
        '
        resources.ApplyResources(Me.Sleep, "Sleep")
        Me.Sleep.Name = "Sleep"
        Me.Sleep.UseVisualStyleBackColor = True
        '
        'minuteTextBox
        '
        resources.ApplyResources(Me.minuteTextBox, "minuteTextBox")
        Me.minuteTextBox.Name = "minuteTextBox"
        '
        'Shutdown
        '
        resources.ApplyResources(Me.Shutdown, "Shutdown")
        Me.Shutdown.Name = "Shutdown"
        Me.Shutdown.UseVisualStyleBackColor = True
        '
        'TextTimer
        '
        resources.ApplyResources(Me.TextTimer, "TextTimer")
        Me.TextTimer.Name = "TextTimer"
        '
        'eatect
        '
        resources.ApplyResources(Me.eatect, "eatect")
        Me.eatect.Name = "eatect"
        Me.eatect.TabStop = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Value = New Date(2018, 3, 2, 19, 8, 33, 0)
        '
        'countDownMode
        '
        resources.ApplyResources(Me.countDownMode, "countDownMode")
        Me.countDownMode.Checked = True
        Me.countDownMode.Name = "countDownMode"
        Me.countDownMode.TabStop = True
        Me.countDownMode.UseVisualStyleBackColor = True
        '
        'hourMode
        '
        resources.ApplyResources(Me.hourMode, "hourMode")
        Me.hourMode.Name = "hourMode"
        Me.hourMode.UseVisualStyleBackColor = True
        '
        'SecondTextBox
        '
        resources.ApplyResources(Me.SecondTextBox, "SecondTextBox")
        Me.SecondTextBox.Name = "SecondTextBox"
        '
        'HourTextBox
        '
        resources.ApplyResources(Me.HourTextBox, "HourTextBox")
        Me.HourTextBox.Name = "HourTextBox"
        '
        'H
        '
        resources.ApplyResources(Me.H, "H")
        Me.H.Name = "H"
        '
        'M
        '
        resources.ApplyResources(Me.M, "M")
        Me.M.Name = "M"
        '
        'S
        '
        resources.ApplyResources(Me.S, "S")
        Me.S.Name = "S"
        '
        'TimerDate
        '
        Me.TimerDate.Interval = 1000
        '
        'WebBrowser1
        '
        resources.ApplyResources(Me.WebBrowser1, "WebBrowser1")
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Url = New System.Uri("http://www.eatect.com/sleepPC/ad", System.UriKind.Absolute)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.H)
        Me.Controls.Add(Me.HourTextBox)
        Me.Controls.Add(Me.SecondTextBox)
        Me.Controls.Add(Me.hourMode)
        Me.Controls.Add(Me.countDownMode)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.eatect)
        Me.Controls.Add(Me.TextTimer)
        Me.Controls.Add(Me.Sleep)
        Me.Controls.Add(Me.Hibernate)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Shutdown)
        Me.Controls.Add(Me.minuteTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Restart As Button
    Friend WithEvents Hibernate As Button
    Friend WithEvents Sleep As Button
    Friend WithEvents minuteTextBox As TextBox
    Friend WithEvents Shutdown As Button
    Friend WithEvents TextTimer As Label
    Friend WithEvents eatect As LinkLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents countDownMode As RadioButton
    Friend WithEvents hourMode As RadioButton
    Friend WithEvents SecondTextBox As TextBox
    Friend WithEvents HourTextBox As TextBox
    Friend WithEvents H As Label
    Friend WithEvents M As Label
    Friend WithEvents S As Label
    Friend WithEvents TimerDate As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

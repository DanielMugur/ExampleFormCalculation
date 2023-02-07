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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.gpbValues = New System.Windows.Forms.GroupBox()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber3 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNumber3 = New System.Windows.Forms.Label()
        Me.lblSummation = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtSummation = New System.Windows.Forms.TextBox()
        Me.gpbAnswers = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpbValues.SuspendLayout()
        Me.gpbAnswers.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(254, 25)
        Me.txtNumber1.MaxLength = 10
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(150, 22)
        Me.txtNumber1.TabIndex = 0
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.Location = New System.Drawing.Point(151, 25)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(82, 20)
        Me.lblNumber1.TabIndex = 1
        Me.lblNumber1.Text = "Number 1"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(404, 189)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 30)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'gpbValues
        '
        Me.gpbValues.Controls.Add(Me.lblNumber1)
        Me.gpbValues.Controls.Add(Me.txtNumber1)
        Me.gpbValues.Controls.Add(Me.lblNumber2)
        Me.gpbValues.Controls.Add(Me.txtNumber3)
        Me.gpbValues.Controls.Add(Me.txtNumber2)
        Me.gpbValues.Controls.Add(Me.btnClear)
        Me.gpbValues.Controls.Add(Me.lblNumber3)
        Me.gpbValues.Controls.Add(Me.btnCalculate)
        Me.gpbValues.Location = New System.Drawing.Point(47, 26)
        Me.gpbValues.Name = "gpbValues"
        Me.gpbValues.Size = New System.Drawing.Size(634, 225)
        Me.gpbValues.TabIndex = 3
        Me.gpbValues.TabStop = False
        Me.gpbValues.Text = "Values"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(151, 76)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(82, 20)
        Me.lblNumber2.TabIndex = 6
        Me.lblNumber2.Text = "Number 2"
        '
        'txtNumber3
        '
        Me.txtNumber3.Location = New System.Drawing.Point(254, 122)
        Me.txtNumber3.MaxLength = 10
        Me.txtNumber3.Name = "txtNumber3"
        Me.txtNumber3.Size = New System.Drawing.Size(150, 22)
        Me.txtNumber3.TabIndex = 4
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(254, 76)
        Me.txtNumber2.MaxLength = 10
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(150, 22)
        Me.txtNumber2.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(524, 189)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblNumber3
        '
        Me.lblNumber3.AutoSize = True
        Me.lblNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber3.Location = New System.Drawing.Point(151, 122)
        Me.lblNumber3.Name = "lblNumber3"
        Me.lblNumber3.Size = New System.Drawing.Size(82, 20)
        Me.lblNumber3.TabIndex = 7
        Me.lblNumber3.Text = "Number 3"
        '
        'lblSummation
        '
        Me.lblSummation.AutoSize = True
        Me.lblSummation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummation.Location = New System.Drawing.Point(140, 46)
        Me.lblSummation.Name = "lblSummation"
        Me.lblSummation.Size = New System.Drawing.Size(93, 20)
        Me.lblSummation.TabIndex = 8
        Me.lblSummation.Text = "Summation"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(163, 103)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(70, 20)
        Me.lblAverage.TabIndex = 11
        Me.lblAverage.Text = "Average"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(254, 103)
        Me.txtAverage.MaxLength = 20
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(150, 22)
        Me.txtAverage.TabIndex = 12
        '
        'txtSummation
        '
        Me.txtSummation.Location = New System.Drawing.Point(254, 46)
        Me.txtSummation.MaxLength = 20
        Me.txtSummation.Name = "txtSummation"
        Me.txtSummation.Size = New System.Drawing.Size(150, 22)
        Me.txtSummation.TabIndex = 13
        '
        'gpbAnswers
        '
        Me.gpbAnswers.Controls.Add(Me.txtAverage)
        Me.gpbAnswers.Controls.Add(Me.txtSummation)
        Me.gpbAnswers.Controls.Add(Me.lblSummation)
        Me.gpbAnswers.Controls.Add(Me.lblAverage)
        Me.gpbAnswers.Location = New System.Drawing.Point(47, 287)
        Me.gpbAnswers.Name = "gpbAnswers"
        Me.gpbAnswers.Size = New System.Drawing.Size(634, 160)
        Me.gpbAnswers.TabIndex = 14
        Me.gpbAnswers.TabStop = False
        Me.gpbAnswers.Text = "Answers"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(571, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 507)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpbValues)
        Me.Controls.Add(Me.gpbAnswers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gpbValues.ResumeLayout(False)
        Me.gpbValues.PerformLayout()
        Me.gpbAnswers.ResumeLayout(False)
        Me.gpbAnswers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents gpbValues As GroupBox
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber3 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblNumber3 As Label
    Friend WithEvents lblSummation As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtSummation As TextBox
    Friend WithEvents gpbAnswers As GroupBox
    Friend WithEvents btnExit As Button
End Class

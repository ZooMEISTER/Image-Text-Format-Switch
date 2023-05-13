<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Button_Read = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Button_Switch = New System.Windows.Forms.Button()
        Me.PictureBox_Grey = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Copy = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_Use = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBox_AreaHeight = New System.Windows.Forms.TextBox()
        Me.TextBox_AreaWidth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Grey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'Button_Read
        '
        Me.Button_Read.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Read.Location = New System.Drawing.Point(3, 409)
        Me.Button_Read.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Read.Name = "Button_Read"
        Me.Button_Read.Size = New System.Drawing.Size(93, 65)
        Me.Button_Read.TabIndex = 1
        Me.Button_Read.Text = "打开"
        Me.Button_Read.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("宋体", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox.Location = New System.Drawing.Point(409, 3)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(1028, 800)
        Me.TextBox.TabIndex = 2
        '
        'Button_Switch
        '
        Me.Button_Switch.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Switch.Location = New System.Drawing.Point(102, 409)
        Me.Button_Switch.Name = "Button_Switch"
        Me.Button_Switch.Size = New System.Drawing.Size(301, 65)
        Me.Button_Switch.TabIndex = 3
        Me.Button_Switch.Text = "转换"
        Me.Button_Switch.UseVisualStyleBackColor = True
        '
        'PictureBox_Grey
        '
        Me.PictureBox_Grey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Grey.Location = New System.Drawing.Point(3, 480)
        Me.PictureBox_Grey.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox_Grey.Name = "PictureBox_Grey"
        Me.PictureBox_Grey.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox_Grey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Grey.TabIndex = 4
        Me.PictureBox_Grey.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 807)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "字体：宋体-常规"
        '
        'Button_Copy
        '
        Me.Button_Copy.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Button_Copy.Location = New System.Drawing.Point(1244, 807)
        Me.Button_Copy.Name = "Button_Copy"
        Me.Button_Copy.Size = New System.Drawing.Size(193, 73)
        Me.Button_Copy.TabIndex = 9
        Me.Button_Copy.Text = "复制"
        Me.Button_Copy.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1166, 810)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 23)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "5"
        '
        'Button_Use
        '
        Me.Button_Use.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Use.Location = New System.Drawing.Point(1104, 836)
        Me.Button_Use.Name = "Button_Use"
        Me.Button_Use.Size = New System.Drawing.Size(134, 44)
        Me.Button_Use.TabIndex = 10
        Me.Button_Use.Text = "应用"
        Me.Button_Use.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1101, 813)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "字体大小:"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox.Location = New System.Drawing.Point(963, 859)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(135, 21)
        Me.CheckBox.TabIndex = 13
        Me.CheckBox.Text = "内存不足时勾选此项"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'TextBox_AreaHeight
        '
        Me.TextBox_AreaHeight.Location = New System.Drawing.Point(780, 810)
        Me.TextBox_AreaHeight.Name = "TextBox_AreaHeight"
        Me.TextBox_AreaHeight.Size = New System.Drawing.Size(130, 23)
        Me.TextBox_AreaHeight.TabIndex = 14
        Me.TextBox_AreaHeight.Text = "14"
        '
        'TextBox_AreaWidth
        '
        Me.TextBox_AreaWidth.Location = New System.Drawing.Point(781, 839)
        Me.TextBox_AreaWidth.Name = "TextBox_AreaWidth"
        Me.TextBox_AreaWidth.Size = New System.Drawing.Size(129, 23)
        Me.TextBox_AreaWidth.TabIndex = 15
        Me.TextBox_AreaWidth.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(719, 813)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "区块高度"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(719, 840)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "区块宽度"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 883)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_AreaWidth)
        Me.Controls.Add(Me.TextBox_AreaHeight)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_Use)
        Me.Controls.Add(Me.Button_Copy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_Grey)
        Me.Controls.Add(Me.Button_Switch)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button_Read)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图片文字转换 2.0"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Grey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Button_Read As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Button_Switch As Button
    Friend WithEvents PictureBox_Grey As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Copy As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_Use As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents TextBox_AreaHeight As TextBox
    Friend WithEvents TextBox_AreaWidth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button_Switch.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Read.Click       '读取图片
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.PictureBox.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
            Me.Button_Switch.Enabled = True
        End If
    End Sub


    Private Sub Button_Switch_Click(sender As Object, e As EventArgs) Handles Button_Switch.Click      '先转成黑白，再像素化，再转成黑白(为防止像素化过程中出现的色差)
        Dim f As Double         '区块横向长度
        Dim d As Double         '区块纵向长度
        Dim bl As Double        '区块缩放比例
        bl = 1
        f = Val(TextBox_AreaWidth.Text) * bl
        d = Val(TextBox_AreaHeight.Text) * bl

        Dim x2 As Long
        Dim y2 As Long

        Dim FinalText As String = ""

        Me.Button_Switch.Enabled = False

        '将图片像素化
        Dim Height2 As Integer = BlackAndWhite(Image.FromFile(Me.OpenFileDialog1.FileName)).Height
        Dim Width2 As Integer = BlackAndWhite(Image.FromFile(Me.OpenFileDialog1.FileName)).Width

        Dim NewBitmap2 As Bitmap = New Bitmap(Width2, Height2)

        Dim OldBitmap2 As Bitmap = BlackAndWhite(Image.FromFile(Me.OpenFileDialog1.FileName))

        Dim i As Integer        '遍历区块的X
        Dim k As Integer        '遍历区块的Y
        Dim colorplus As Long   '区块里所有像素r的值的和

        Dim color8 As Integer   '区块的颜色

        Dim BitmapColor(0 To (Int(Width2 / f)) + 1, 0 To (Int(Height2 / d)) + 1) As Integer

        For x2 = 1 To Int（Width2 / f) * f Step f
            For y2 = 1 To Int(Height2 / d) * d Step d

                colorplus = 0

                For i = x2 To x2 + f - 1
                    For k = y2 To y2 + d - 1
                        If i < Width2 And k < Height2 Then
                            colorplus = colorplus + OldBitmap2.GetPixel(i, k).R
                        End If
                    Next
                Next

                color8 = Int(colorplus / (f * d))

                For i = x2 To x2 + f - 1
                    For k = y2 To y2 + d - 1
                        If i < Int(Width2 / f) * f And k < Int(Height2 / d) * d Then NewBitmap2.SetPixel(i, k, Color.FromArgb(color8, color8, color8))
                    Next
                Next
            Next
        Next

        NewBitmap2 = BlackAndWhite(NewBitmap2)

        '——————————————————剪裁图片内存不足则启用此段代码—————————————————————
        'GC.Collect()
        'OldBitmap2.Dispose()

        'If Me.CheckBox.Checked = False Then                      
        '    Try
        '        Dim rc As Rectangle = New Rectangle(1, 1, Int(Width2 / f) * f, Int(Height2 / d) * d)   '起点和长宽
        '        NewBitmap2 = NewBitmap2.Clone(rc, Imaging.PixelFormat.DontCare)   '剪裁图片
        '    Catch ex As Exception
        '        MsgBox("内存不足", vbOKOnly, "错误")
        '        Me.Button_Switch.Enabled = True
        '        Exit Sub
        '    End Try
        'End If
        '——————————————————————————————————————————————————————

        Width2 = NewBitmap2.Width
        Height2 = NewBitmap2.Height

        Me.PictureBox_Grey.Image = NewBitmap2        '显示像素化处理过后的图片

        For x2 = 1 To Width2 Step f
            For y2 = 1 To Height2 Step d
                If x2 < Width2 And y2 < Height2 Then
                    BitmapColor(Int(x2 / f), Int(y2 / d)) = NewBitmap2.GetPixel(x2, y2).R
                End If
            Next
        Next

        Dim p As Integer = 1
        Dim q As Integer = 1

        For q = 1 To Int(y2 / d) - 2
            For p = 1 To Int(x2 / f) - 2
                Dim CodeTXT As String = "MNEFOCTLI "
                If BitmapColor(p, q) = 0 Then
                    FinalText = FinalText + Mid(CodeTXT, 1, 1)
                ElseIf BitmapColor(p, q) = 255 Then
                    FinalText = FinalText + Mid(CodeTXT, 10, 1)
                Else
                    FinalText = FinalText + Mid(CodeTXT, Int((BitmapColor(p, q) + 1)) / 32, 1)
                End If
            Next
            FinalText = FinalText + vbNewLine
        Next
        Me.TextBox.Text = FinalText

        Me.Button_Switch.Enabled = True
    End Sub

    Private Function BlackAndWhite(ByVal bm As Image)          '彩色转黑白函数
        Dim Height As Integer = bm.Height                      '输入的图片的高
        Dim Width As Integer = bm.Width                        '输入的图片的宽
        Dim NewBitmap As Bitmap = New Bitmap(Width, Height)    '输出的图片
        Dim OldBitmap As Bitmap = bm                           '输入的图片
        Dim pixel As Color                                     '存储抓取的像素

        For x As Integer = 1 To Width - 1
            For y As Integer = 1 To Height - 1
                pixel = OldBitmap.GetPixel(x, y)               '抓取像素
                Dim r, g, b As Integer, Result As Integer = 0
                r = pixel.R                                    '获取原像素的RGB
                g = pixel.G
                b = pixel.B

                Result = r * 0.3 + g * 0.59 + b * 0.11              '计算灰度化后的RGB值

                NewBitmap.SetPixel(x, y, Color.FromArgb(Set8Color(Result), Set8Color(Result), Set8Color(Result)))            '将灰度分成8个区间
            Next
        Next

        OldBitmap.Dispose()

        Return NewBitmap
    End Function

    Private Function Set8Color(ByVal clr As Long)              '分灰度(彩色转黑白)函数
        Dim NewColor As Integer                                'clr为输入的颜色R值,分为8个灰度等级,0和255单独分出来，剩下8个区间分别取中间值

        If clr = 255 Then
            NewColor = 255
        ElseIf clr = 0 Then
            NewColor = 0
        Else
            NewColor = Int((clr + 1) / 32) * 32 + 16
        End If

        Return NewColor
    End Function

    Private Sub Button_Copy_Click(sender As Object, e As EventArgs) Handles Button_Copy.Click
        Clipboard.Clear()                         '清除剪贴板
        Clipboard.SetText(Me.TextBox.Text)        '拷贝数据到粘贴板
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_Use.Click
        If TextBox1.Text <> "" And Val(Me.TextBox1.Text) > 0 Then
            With Me.TextBox.Font
                Me.TextBox.Font = New Font("宋体", Val(Me.TextBox1.Text), FontStyle.Regular, .Unit)   '参数都用原来字体参数，只有大小改成你需要的。
            End With
        End If
    End Sub
End Class

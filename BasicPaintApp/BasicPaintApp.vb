Public Class BasicPaintApp

    'Project Variables
    Dim g1, g2 As Graphics
    Dim dColor As Color
    Dim dPen As Pen
    Dim dBrush As Brush
    Dim dFont As Font
    Dim size_h, size_w, dsize As Integer
    Dim selShape, selItem, CurrFile As String
    Dim lp1, lp2, p1, p2 As Point

    Dim currBmp As Bitmap
    Dim currImg As Image
    Dim flagImg, flagPaint, flagFill, flagP1 As Boolean

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start()
    End Sub

    ' ***************** Main Code **********************
    Private Sub start()

        Dim pw As Integer = Panel1.Width
        Dim ph As Integer = Panel1.Height

        currBmp = New Bitmap(pw, ph)
        g1 = Graphics.FromImage(currBmp)
        g2 = Panel1.CreateGraphics()

        dsize = 50 : size_h = 50 : size_w = 50

        txtSize.Text = dsize.ToString()
        penSize.Value = 2

        dColor = Color.Black
        dBrush = New SolidBrush(dColor)
        dPen = New Pen(dBrush, 2)
        flagPaint = False
        flagFill = False
        flagP1 = True
        selShape = "Rectangle"
        createDropDown()
        dFont = txtInput.Font
        clearScreen()
    End Sub
    Private Sub createDropDown()
        shapDropBox.Items.Clear()
        shapDropBox.Items.Add("Drawing")
        shapDropBox.Items.Add("Rectangle (p1,p2)")
        shapDropBox.Items.Add("Ellipse (p1,p2)")
        shapDropBox.Items.Add("Square")
        shapDropBox.Items.Add("Rectangle (H)")
        shapDropBox.Items.Add("Rectangle (V)")
        shapDropBox.Items.Add("Circle")
        shapDropBox.Items.Add("Line")
        shapDropBox.Items.Add("Text")
        shapDropBox.Items.Add("Erase")
        shapDropBox.Items.Add("Erase Range")
        shapDropBox.SelectedIndex = 0
        setShape()

    End Sub
    Private Sub setShape()
        selItem = ShapDropBox.SelectedItem.ToString()

        dsize = Convert.ToInt32(txtSize.Text)
        size_w = dsize : size_h = dsize
        selShape = selItem
        Select selItem
            Case "Drawing" : selShape = "Drawing" : Exit Select
            Case "Square" : selShape = "Rectangle" : Exit Select
            Case "Rectangle (V)" : selShape = "Rectangle" : size_w = dsize : size_h = dsize * 2 : Exit Select
            Case "Rectangle (H)" : selShape = "Rectangle" : size_w = dsize * 2 : size_h = dsize : Exit Select
            Case "Circle" : selShape = "Ellipse" : Exit Select
            Case "Line" : selShape = "Line" : Exit Select
            Case Else : Exit Select
        End Select
        flagP1 = True
        lblStatus.Text = "Selected Shape: " + selShape

    End Sub

    Private Sub pExit()
        Me.Dispose()
        Me.Close()
    End Sub


    Private Sub drawAnimation(g As Graphics, shape As String, pen As Pen, sb As Brush, x As Integer, y As Integer, sz_w As Integer, sz_h As Integer)

        Select (shape)

            Case "Rectangle (p1,p2)"
                If (flagP1 = False) Then
                    lp2 = New Point(x, y)
                    If (flagFill = False) Then g.DrawRectangle(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                    If (flagFill = True) Then g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select
            Case "Ellipse (p1,p2)"
                If (flagP1 = False) Then
                    lp2 = New Point(x, y)
                    If (flagFill = False) Then g.DrawEllipse(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                    If (flagFill = True) Then g.FillEllipse(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select

            Case "Rectangle"
                If (flagFill = False) Then g.DrawRectangle(pen, x, y, sz_w, sz_h)
                If (flagFill = True) Then g.FillRectangle(sb, x, y, size_w, size_h)
                Exit Select
            Case "Ellipse"
                If (flagFill = False) Then g.DrawEllipse(pen, x, y, sz_w, sz_h)
                If (flagFill = True) Then g.FillEllipse(sb, x, y, size_w, size_h)
                Exit Select
            Case "Line"
                If (flagP1 = False) Then lp2 = New Point(x, y) : g.DrawLine(pen, lp1, lp2)
                Exit Select
            Case "Text"
                If (txtInput.Text.Length > 0) Then
                    Dim p2 As Point = New Point(x, y) : g.DrawString(txtInput.Text, dFont, sb, p2)
                End If
                Exit Select
                '********** Edit Events [Copy, Cut, Paste] ***********
            Case "Erase"
                g2.DrawRectangle(New Pen(Color.Blue, 1), x, y, sz_w, sz_h)
                Exit Select
            Case "Erase Range"
                If (flagP1 = False) Then

                    lp2 = New Point(x, y)
                    g2.DrawRectangle(New Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select
            Case "Copy Image"
                If (flagP1 = False) Then

                    lp2 = New Point(x, y)
                    g2.DrawRectangle(New Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If

                Exit Select
            Case "Cut Image"
                If (flagP1 = False) Then

                    lp2 = New Point(x, y)
                    g2.DrawRectangle(New Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If

                Exit Select
            Case "Paste Image"
                If (flagImg = True) Then

                    lp2 = New Point(x, y)
                    g2.DrawImage(currImg, lp2)
                End If
                Exit Select

                '******************************************************
            Case Else : Exit Select
        End Select
        lblStatus.Text = "Selected Shape: " + selShape
    End Sub


    Private Sub drawShape(g As Graphics, shape As String, pen As Pen, sb As Brush, x As Integer, y As Integer, sz_w As Integer, sz_h As Integer)

        Select (shape)
            Case "Rectangle (p1,p2)"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else
                    lp2 = New Point(x, y) : flagP1 = True
                    If (flagFill = False) Then g.DrawRectangle(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                    If (flagFill = True) Then g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select
            Case "Ellipse (p1,p2)"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else

                    lp2 = New Point(x, y) : flagP1 = True
                    If (flagFill = False) Then g.DrawEllipse(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                    If (flagFill = True) Then g.FillEllipse(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select
            Case "Rectangle"
                If (flagFill = False) Then g.DrawRectangle(pen, x, y, sz_w, sz_h)
                If (flagFill = True) Then g.FillRectangle(sb, x, y, size_w, size_h)
                Exit Select
            Case "Ellipse"
                If (flagFill = False) Then g.DrawEllipse(pen, x, y, sz_w, sz_h)
                If (flagFill = True) Then g.FillEllipse(sb, x, y, size_w, size_h)
                Exit Select
            Case "Line"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else
                    lp2 = New Point(x, y) : g.DrawLine(pen, lp1, lp2) : flagP1 = True
                End If
                Exit Select
            Case "Text"
                If (txtInput.Text.Length > 0) Then
                    Dim p2 As Point = New Point(x, y) : g.DrawString(txtInput.Text, dFont, sb, p2)
                End If
                Exit Select
            Case "Erase"
                g.FillRectangle(New SolidBrush(Panel1.BackColor), x, y, size_w, size_h)
                Exit Select
            Case "Erase Range"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else
                    lp2 = New Point(x, y) : flagP1 = True
                    g.FillRectangle(New SolidBrush(Panel1.BackColor), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                End If
                Exit Select
                '********** Edit Events [Copy, Cut, Paste] ***********
            Case "Copy Image"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else
                    lp2 = New Point(x, y)
                    Dim w1, h1 As Integer
                    flagP1 = True : w1 = lp2.X - lp1.X : h1 = lp2.Y - lp1.Y
                    Dim r As Rectangle = New Rectangle(lp1.X, lp1.Y, w1, h1)
                    Try

                        Clipboard.SetImage(CopyBitmap(currBmp, r))
                        setPaste() ' Paste After Copy

                    Catch ex As Exception
                    End Try
                End If
                Exit Select
            Case "Cut Image"
                If (flagP1 = True) Then
                    lp1 = New Point(x, y) : flagP1 = False
                Else
                    Dim w1, h1 As Integer
                    lp2 = New Point(x, y) : w1 = lp2.X - lp1.X : h1 = lp2.Y - lp1.Y
                    Dim r As Rectangle = New Rectangle(lp1.X, lp1.Y, w1, h1)
                    Clipboard.SetImage(CopyBitmap(currBmp, r))
                    Try
                        sb = New SolidBrush(Panel1.BackColor)
                        g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y)
                        flagP1 = True
                        setPaste() ' Paste After Copy
                    Catch ex As Exception
                    End Try
                End If
                Exit Select
            Case "Paste Image"
                g.DrawImage(currImg, lp2) : setShape()
                Exit Select
        End Select
        lblStatus.Text = "Selected Shape: " + selShape
    End Sub
    Private Sub clearScreen()

        g1.Clear(Panel1.BackColor)
        MoveGraphics()
    End Sub
    Private Sub SaveFile()

        If (CurrFile = "" Or CurrFile = Nothing) Then
            SaveAs()
            Return
        End If
        Try
            currBmp.Save(CurrFile, System.Drawing.Imaging.ImageFormat.Bmp)
            MessageBox.Show("File '" + CurrFile + "' Saved!", "Save File")
        Catch ex As Exception
            MessageBox.Show("Error Saving Bitmap to File '" + CurrFile + "\nError: " + ex.Message, "Save File Error")
        End Try


    End Sub
    Private Sub SaveAs()

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.InitialDirectory = "C:\temp"
        'sfd.DefaultExt = "Bitmaps | *.bmp | All Files | *.*":
        sfd.FileName = "C:\temp\csharp1.bmp"
        If (sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            CurrFile = sfd.FileName
            SaveFile()
        End If
    End Sub
    Private Sub OpenFile()

        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.InitialDirectory = "C:\\temp"
        ofd.DefaultExt = "Bitmaps | *.bmp | All Files | *.*"
        If (ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            CurrFile = ofd.FileName
            Try
                Dim tmp As Image = Image.FromFile(CurrFile)
                Dim pw, ph As Integer
                pw = tmp.Width
                ph = tmp.Height

                If (Panel1.Width > pw) Then pw = Panel1.Width
                If (Panel1.Height > ph) Then ph = Panel1.Height

                currBmp = New Bitmap(pw, ph)
                g1 = Graphics.FromImage(currBmp)
                g2 = Panel1.CreateGraphics()
                clearScreen()

                g1.Clear(Panel1.BackColor)
                g1.DrawImage(tmp, New Point(0, 0))
                MoveGraphics()
            Catch ex As Exception

                MessageBox.Show("Error Opening the File! \nError: " + ex.Message, "Error")
                CurrFile = ""
            End Try

        End If
        'FileStatus():
    End Sub

    Private Sub resizePanel()

        Try

            Dim tmp As Bitmap = currBmp
            Dim pw, ph As Integer
            pw = currBmp.Width
            ph = currBmp.Height

            If (ph < Panel1.Height) Then ph = Panel1.Height
            If (pw < Panel1.Width) Then pw = Panel1.Width

            currBmp = New Bitmap(pw, ph)
            g1 = Graphics.FromImage(currBmp)
            g2 = Panel1.CreateGraphics()

            clearScreen()
            g1.DrawImage(tmp, New Point(0, 0))
            MoveGraphics()
        Catch ex As Exception
        End Try
        'MessageBox.Show("Window Resized!"):
    End Sub
    Private Function CopyBitmap(srcBitmap As Bitmap, section As Rectangle) As Bitmap

        'Routine from MSDN
        ' Create the new bitmap and associated graphics object
        Dim bmp As Bitmap = New Bitmap(section.Width, section.Height)
        Dim g3 As Graphics = Graphics.FromImage(bmp)

        ' Draw the specified section of the source bitmap to the new one
        g3.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel)

        ' Clean up
        g3.Dispose()

        ' Return the bitmap
        Return bmp
    End Function

    Private Sub MoveGraphics()
        g2.DrawImage(currBmp, 0, 0)
    End Sub
    Private Sub setPaste()
        selShape = "Paste Image"
        flagP1 = True
        lblStatus.Text = "Selected Shape: " + selShape
        Try
            flagImg = True
            currImg = Clipboard.GetImage()
        Catch ex As Exception
            flagImg = False
        End Try
    End Sub



    ' ************* Panel Mouse Events *****************
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        drawShape(g1, selShape, dPen, dBrush, e.X, e.Y, size_w, size_h)
        MoveGraphics() ' g1 - BitMap, g2 - Panel

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If (selShape = "Drawing") Then flagPaint = True
        p1 = New Point(e.X, e.Y)
    End Sub
    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        MoveGraphics()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (flagPaint = True And selShape = "Drawing") Then
            p2 = New Point(e.X, e.Y)
            g1.DrawLine(dPen, p1, p2)
            p1 = p2
            MoveGraphics() ' g1 - BitMap, g2 - Panel
        End If
        If (selShape <> "Drawing") Then 'Animation
            MoveGraphics() ' g1 - BitMap, g2 - Panel
            drawAnimation(g2, selShape, dPen, dBrush, e.X, e.Y, size_w, size_h)
        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If (selShape = "Drawing") Then flagP1 = True
        flagPaint = False

    End Sub

    ' *********** Buttons and Menus Events **************
    Private Sub button_Click(sender As Object, e As EventArgs) Handles btnCut.Click, btnPaste.Click, btnFont.Click, btnCopy.Click, btnColor.Click, btnExit.Click
        Dim txt As String = sender.ToString()
        Dim i, l As Integer
        l = txt.Length
        i = txt.LastIndexOf(":") + 2
        Dim str As String = txt.Substring(i)
        Select Case (str)
            Case "Exit" : pExit() : Exit Select

            Case "Color"
                Dim cd As ColorDialog = New ColorDialog()
                If (cd.ShowDialog() = DialogResult.OK) Then
                    dColor = cd.Color
                    Dim ps As Integer = Convert.ToInt32(penSize.Value)
                    dPen = New Pen(dColor, ps)
                    dBrush = New SolidBrush(dColor)
                    btnColor.ForeColor = cd.Color
                End If
                Exit Select

            Case "Font"
                Dim fd As FontDialog = New FontDialog()
                If (fd.ShowDialog() = DialogResult.OK) Then
                    dFont = fd.Font
                    txtInput.Font = fd.Font
                    txtInput.Font = New Font(txtInput.Font.FontFamily, 10)
                End If
                Exit Select

            Case "Cut"
                selShape = "Cut Image"
                flagP1 = True
                lblStatus.Text = "Selected Shape: " + selShape
                Exit Select

            Case "Copy"
                selShape = "Copy Image"
                flagP1 = True
                lblStatus.Text = "Selected Shape: " + selShape
                Exit Select

            Case "Paste"
                setPaste()
                Exit Select

        End Select
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub ShapDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShapDropBox.SelectedIndexChanged
        setShape()
    End Sub

    Private Sub txtSize_Leave(sender As Object, e As EventArgs) Handles txtSize.Leave
        setShape()
    End Sub

    Private Sub penSize_ValueChanged(sender As Object, e As EventArgs) Handles penSize.ValueChanged
        Dim ps As Integer = Convert.ToInt32(penSize.Value)
        dPen = New Pen(dColor, ps)

    End Sub

    Private Sub ckBoxFill_Click(sender As Object, e As EventArgs) Handles ckBoxFill.Click
        If (ckBoxFill.Checked = True) Then
            flagFill = True
        Else
            flagFill = False
        End If
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        CurrFile = ""
        clearScreen()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub SaveFileAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileAsToolStripMenuItem.Click
        SaveAs()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        pExit()
    End Sub

    Private Sub helpMenu_Click(sender As Object, e As EventArgs) Handles helpMenu.Click
        Dim msg As String = ""
        msg = msg + "Basic Paint Program " + Chr(13)
        msg = msg + "Made as Part of a Training Program " + Chr(13)
        msg = msg + "By Paulo Ramos @ Jul/2016 " + Chr(13)
        MessageBox.Show(msg, "Basic Paint Program")

    End Sub

    Private Sub clearMenu_Click(sender As Object, e As EventArgs) Handles clearMenu.Click
        clearScreen()
    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        resizePanel()
    End Sub
End Class
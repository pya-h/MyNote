Imports System.IO
Imports System.Drawing.Font
Imports System.Windows.Forms
Public Class MyNote
    Dim ProjectName As String
    Dim Change As Boolean
    Dim blnsave As Boolean
    Dim SaveFileName As String

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim en As Integer
        If Change = False Then
            Call closeme()

        Else
            en = MsgBox("Do you want to save " & Me.Text & " ? ", vbYesNo + vbQuestion)
            If en = vbYes Then
                Call SaveFile()
            Else
                Call closeme()
            End If
        End If

        Call closeme()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PName()
        blnsave = False
    End Sub

    Private Sub TextBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        Dim file() As String
        file = e.Data.GetData(DataFormats.FileDrop)
        TextBox1.Text = IO.File.ReadAllText(file(0))
        Change = False
    End Sub

    Private Sub TextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Change = True
    End Sub

    Private Sub NewProject()
        TextBox1.ReadOnly = False
        Me.Opacity = 0.5
        Call PName()

        TextBox1.Text = ""
        TextBox1.Height = 10
        Me.Opacity = 1

        For h As Integer = 10 To Me.Height - 87 Step 1
            TextBox1.Height = h
        Next
        blnsave = False
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        CloseProjectToolStripMenuItem.Enabled = True
        ClearTextboxToolStripMenuItem.Enabled = True


    End Sub
    Private Sub SaveAsFile()

        SaveFileDialog1.FileName = Me.Text
        SaveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf|Word Documents (*.doc)|*.doc"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(
            SaveFileDialog1.FileName, TextBox1.Text, False)
            blnsave = True
            SaveFileName = SaveFileDialog1.FileName
        End If
    End Sub
    Private Sub PName()
        ProjectName = InputBox("Please enter a name for your project ", "ProjectName")
        If ProjectName <> "" Then
            Me.Text = ProjectName & " - My Notepad"
        Else
            Me.Text = "Untitled - My Notepad"
        End If
    End Sub
    Private Sub SaveFile()
        If blnsave = False Then
            Call SaveAsFile()
        ElseIf blnsave = True Then


            My.Computer.FileSystem.WriteAllText(
            SaveFileName, TextBox1.Text, False)
            blnsave = True


        End If
    End Sub
    Private Sub OpenFile()
        Dim AllText As String = ""
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf|Word Documents (*.doc)|*.doc"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            Try 'open file and trap any errors using handler
                AllText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

                TextBox1.Text = AllText 'display file
                TextBox1.Enabled = True 'allow text cursor
                SaveFileName = OpenFileDialog1.FileName
                TextBox1.ReadOnly = False

                TextBox1.Height = 10
                Me.Opacity = 1

                For h As Integer = 10 To Me.Height - 87 Step 1
                    TextBox1.Height = h
                Next
                blnsave = True
                Change = False
                SaveToolStripMenuItem.Enabled = True
                SaveAsToolStripMenuItem.Enabled = True
                CloseProjectToolStripMenuItem.Enabled = True
                ClearTextboxToolStripMenuItem.Enabled = True
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If

    End Sub
    Private Sub ToTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TimeString & vbCrLf & vbCrLf & TextBox1.Text
    End Sub

    Private Sub ToBottomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & vbCrLf & vbCrLf & TimeString
    End Sub

    Private Sub ToTopToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = DateString & vbCrLf & vbCrLf & TextBox1.Text
    End Sub

    Private Sub ToBottomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & vbCrLf & vbCrLf & DateString
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToBottomToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & vbCrLf & vbCrLf & Now
    End Sub

    Private Sub ToTopToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = Now & vbCrLf & vbCrLf & TextBox1.Text
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Clear()
    End Sub
    Private Sub SelectText()
        If TextBox1.SelectedText <> "" Then

            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        End If

    End Sub
    Private Sub LeftToRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.RightToLeft = 0
    End Sub
    Private Sub closeme()
        For i As Double = Me.Left To -1000 Step -2
            Me.Left = i
        Next
        End
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim ask As String
        If Change = True Then
            ask = MsgBox("Do you want to save " & Me.Text & " ?", vbYesNoCancel + vbQuestion)
            If ask = vbYes Then
                Call SaveFile()
                Call NewProject()
                Change = False
            ElseIf ask = vbNo Then
                Call NewProject()
                Change = False
            Else
                Exit Sub
            End If
        Else
            Call NewProject()
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Call OpenFile()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Call SaveFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Call SaveAsFile()
    End Sub

    Private Sub CloseProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProjectToolStripMenuItem.Click
        Dim asd As Byte
        If Change = False Then

            For h As Integer = TextBox1.Height To 10 Step -1
                TextBox1.Height = h
            Next
            TextBox1.Text = ""
            Change = False
            TextBox1.ReadOnly = True
            Me.Opacity = 0.5
            Me.Text = "Click on New or Open to creat project. "
            SaveToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            CloseProjectToolStripMenuItem.Enabled = False

        Else
            asd = MsgBox("Are you sure do you want to close project whitout saving ?", vbYesNo + vbQuestion)
            If asd = vbYes Then
                For h As Integer = TextBox1.Height To 10 Step -1
                    TextBox1.Height = h
                Next
                TextBox1.Text = ""
                Change = False
                TextBox1.ReadOnly = True
                Me.Opacity = 0.5
                SaveToolStripMenuItem.Enabled = False
                SaveAsToolStripMenuItem.Enabled = False
                CloseProjectToolStripMenuItem.Enabled = False

                Me.Text = "Click on New or Open to creat project. "
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Dim en As Integer
        If Change = False Then
            Call closeme()

        Else
            en = MsgBox("Do you want to save " & Me.Text & " ? ", vbYesNo + vbQuestion)
            If en = vbYes Then
                Call SaveFile()
            Else
                Call closeme()
            End If
        End If
        Call closeme()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
        PasteToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
        PasteToolStripMenuItem.Enabled = True
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub ClearTextboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTextboxToolStripMenuItem.Click
        Dim cleartext As Byte
        If TextBox1.Text <> "" Then
            cleartext = MsgBox("Are you sure ?", vbYesNo + vbQuestion)
            If cleartext = vbYes Then
                TextBox1.Text = ""
                Change = False
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub RightToLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToLeftToolStripMenuItem.Click
        TextBox1.RightToLeft = 1
    End Sub

    Private Sub LeftToRightToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToRightToolStripMenuItem.Click
        TextBox1.RightToLeft = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

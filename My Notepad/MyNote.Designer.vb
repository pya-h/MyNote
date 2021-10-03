<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyNote
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.NewToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.OpenToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.SaveToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.SaveAsToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.CloseProjectToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007StartButton2 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer6 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer7 = New DevComponents.DotNetBar.ItemContainer()
        Me.CutToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.CopyToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.PasteToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ClearTextboxToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.FontToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.UndoToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.RightToLeftToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.LeftToRightToolStripMenuItem = New DevComponents.DotNetBar.ButtonItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(689, 507)
        Me.TextBox1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1, Me.Office2007StartButton2})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(713, 27)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 2
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.Office2007StartButton1.ImagePaddingHorizontal = 0
        Me.Office2007StartButton1.ImagePaddingVertical = 0
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.Office2007StartButton1.Text = "&File"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.ItemContainer4})
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CloseProjectToolStripMenuItem})
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.SubItemsExpandWidth = 24
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.SubItemsExpandWidth = 24
        Me.OpenToolStripMenuItem.Text = "&Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.SubItemsExpandWidth = 24
        Me.SaveToolStripMenuItem.Text = "&Save..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.BeginGroup = True
        Me.CloseProjectToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.SubItemsExpandWidth = 24
        Me.CloseProjectToolStripMenuItem.Text = "&Close Project"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem13})
        '
        'ButtonItem13
        '
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 24
        Me.ButtonItem13.Text = "E&xit"
        '
        'Office2007StartButton2
        '
        Me.Office2007StartButton2.AutoExpandOnClick = True
        Me.Office2007StartButton2.CanCustomize = False
        Me.Office2007StartButton2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton2.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.Office2007StartButton2.ImagePaddingHorizontal = 0
        Me.Office2007StartButton2.ImagePaddingVertical = 0
        Me.Office2007StartButton2.Name = "Office2007StartButton2"
        Me.Office2007StartButton2.ShowSubItems = False
        Me.Office2007StartButton2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer5})
        Me.Office2007StartButton2.Text = "&Edit"
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        Me.ItemContainer5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer6})
        '
        'ItemContainer6
        '
        '
        '
        '
        Me.ItemContainer6.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer6.ItemSpacing = 0
        Me.ItemContainer6.Name = "ItemContainer6"
        Me.ItemContainer6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer7})
        '
        'ItemContainer7
        '
        '
        '
        '
        Me.ItemContainer7.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer7.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer7.Name = "ItemContainer7"
        Me.ItemContainer7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ClearTextboxToolStripMenuItem, Me.FontToolStripMenuItem, Me.UndoToolStripMenuItem, Me.RightToLeftToolStripMenuItem, Me.LeftToRightToolStripMenuItem})
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.SubItemsExpandWidth = 24
        Me.CutToolStripMenuItem.Text = "C&ut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.SubItemsExpandWidth = 24
        Me.CopyToolStripMenuItem.Text = "C&opy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.SubItemsExpandWidth = 24
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ClearTextboxToolStripMenuItem
        '
        Me.ClearTextboxToolStripMenuItem.Name = "ClearTextboxToolStripMenuItem"
        Me.ClearTextboxToolStripMenuItem.Text = "Cl&ear Textbox"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.BeginGroup = True
        Me.FontToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.SubItemsExpandWidth = 24
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RightToLeftToolStripMenuItem
        '
        Me.RightToLeftToolStripMenuItem.Name = "RightToLeftToolStripMenuItem"
        Me.RightToLeftToolStripMenuItem.Text = "Righ&t to Left"
        '
        'LeftToRightToolStripMenuItem
        '
        Me.LeftToRightToolStripMenuItem.Name = "LeftToRightToolStripMenuItem"
        Me.LeftToRightToolStripMenuItem.Text = "Le&ft to Right"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        '
        'MyNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 552)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.MinimumSize = New System.Drawing.Size(729, 590)
        Me.Name = "MyNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents NewToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents OpenToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SaveToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CloseProjectToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SaveAsToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Office2007StartButton2 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer6 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer7 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CutToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CopyToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PasteToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ClearTextboxToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents FontToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents UndoToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RightToLeftToolStripMenuItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LeftToRightToolStripMenuItem As DevComponents.DotNetBar.ButtonItem

End Class

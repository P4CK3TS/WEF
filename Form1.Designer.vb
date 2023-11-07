<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ImportToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        AuthorToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        GroupBox2 = New GroupBox()
        ListBox1 = New ListBox()
        GroupBox3 = New GroupBox()
        ListBox2 = New ListBox()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox4 = New GroupBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        GroupBox7 = New GroupBox()
        CheckBox2 = New CheckBox()
        Label5 = New Label()
        NumericUpDown1 = New NumericUpDown()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        GroupBox5 = New GroupBox()
        ListBox3 = New ListBox()
        GroupBox6 = New GroupBox()
        DataGridView1 = New DataGridView()
        VersionCol = New DataGridViewTextBoxColumn()
        IPAddressCol = New DataGridViewTextBoxColumn()
        PortCol = New DataGridViewTextBoxColumn()
        CountryCol = New DataGridViewTextBoxColumn()
        RatingCol = New DataGridViewTextBoxColumn()
        CodeCol = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox7.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(672, 72)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Target Options"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(498, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Browse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(369, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 7
        Label2.Text = "Range"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 6
        Label1.Text = "Host IP"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(369, 38)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(42, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "/32"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(417, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(357, 23)
        TextBox1.TabIndex = 3
        TextBox1.Text = "127.0.0.1"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(595, 12)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(71, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "IP Range"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(518, 12)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(71, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Host List"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(427, 12)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Single Host"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ImportToolStripMenuItem, ExportToolStripMenuItem, AuthorToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1428, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ImportToolStripMenuItem
        ' 
        ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        ImportToolStripMenuItem.Size = New Size(55, 20)
        ImportToolStripMenuItem.Text = "Import"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(53, 20)
        ExportToolStripMenuItem.Text = "Export"
        ' 
        ' AuthorToolStripMenuItem
        ' 
        AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        AuthorToolStripMenuItem.Size = New Size(52, 20)
        AuthorToolStripMenuItem.Text = "About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 899)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1428, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(26, 17)
        ToolStripStatusLabel1.Text = "Idle"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Location = New Point(12, 217)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(672, 529)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Console"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Black
        ListBox1.ForeColor = Color.Lime
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 27)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(660, 499)
        ListBox1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ListBox2)
        GroupBox3.Location = New Point(690, 27)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(291, 719)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Target List"
        ' 
        ' ListBox2
        ' 
        ListBox2.BackColor = Color.Black
        ListBox2.ForeColor = Color.Lime
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(5, 20)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(280, 694)
        ListBox2.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Button5)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(GroupBox7)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(TextBox4)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(TextBox3)
        GroupBox4.Location = New Point(12, 104)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(672, 107)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Attack Options"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(138, 64)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 37)
        Button5.TabIndex = 7
        Button5.Text = "Terminate"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(270, 64)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 37)
        Button4.TabIndex = 6
        Button4.Text = "Clear Logs"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(6, 64)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 37)
        Button3.TabIndex = 4
        Button3.Text = "Execute"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(CheckBox2)
        GroupBox7.Controls.Add(Label5)
        GroupBox7.Controls.Add(NumericUpDown1)
        GroupBox7.Controls.Add(CheckBox1)
        GroupBox7.Location = New Point(449, 14)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(217, 87)
        GroupBox7.TabIndex = 5
        GroupBox7.TabStop = False
        GroupBox7.Text = "Execution Options"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(10, 22)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(67, 19)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Verbose"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 2
        Label5.Text = "Process Threads"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(10, 54)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(39, 23)
        NumericUpDown1.TabIndex = 1
        NumericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(83, 22)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(98, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Intermediates"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(280, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 4
        Label4.Text = "Switches"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(280, 37)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(156, 23)
        TextBox4.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 2
        Label3.Text = "Script Path"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(6, 37)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(268, 23)
        TextBox3.TabIndex = 1
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(ListBox3)
        GroupBox5.Location = New Point(987, 27)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(430, 719)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "Exploit List"
        ' 
        ' ListBox3
        ' 
        ListBox3.BackColor = Color.Black
        ListBox3.ForeColor = Color.Lime
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(10, 18)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(414, 694)
        ListBox3.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(DataGridView1)
        GroupBox6.Location = New Point(12, 752)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(1404, 144)
        GroupBox6.TabIndex = 7
        GroupBox6.TabStop = False
        GroupBox6.Text = "Routes"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Black
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {VersionCol, IPAddressCol, PortCol, CountryCol, RatingCol, CodeCol})
        DataGridView1.Enabled = False
        DataGridView1.Location = New Point(6, 19)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1392, 119)
        DataGridView1.TabIndex = 0
        ' 
        ' VersionCol
        ' 
        VersionCol.HeaderText = "Version"
        VersionCol.Name = "VersionCol"
        ' 
        ' IPAddressCol
        ' 
        IPAddressCol.HeaderText = "IP Address"
        IPAddressCol.Name = "IPAddressCol"
        ' 
        ' PortCol
        ' 
        PortCol.HeaderText = "Port"
        PortCol.Name = "PortCol"
        ' 
        ' CountryCol
        ' 
        CountryCol.HeaderText = "Country"
        CountryCol.Name = "CountryCol"
        ' 
        ' RatingCol
        ' 
        RatingCol.HeaderText = "Rating"
        RatingCol.Name = "RatingCol"
        ' 
        ' CodeCol
        ' 
        CodeCol.HeaderText = "Code"
        CodeCol.Name = "CodeCol"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 921)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(StatusStrip1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Vector Exploiter Frontend Tool (VEFT)"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VersionCol As DataGridViewTextBoxColumn
    Friend WithEvents IPAddressCol As DataGridViewTextBoxColumn
    Friend WithEvents PortCol As DataGridViewTextBoxColumn
    Friend WithEvents CountryCol As DataGridViewTextBoxColumn
    Friend WithEvents RatingCol As DataGridViewTextBoxColumn
    Friend WithEvents CodeCol As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
End Class

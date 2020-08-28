<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shirtorderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(shirtorderForm))
        Me.customerLabel = New System.Windows.Forms.Label()
        Me.ordernumberLabel = New System.Windows.Forms.Label()
        Me.customernameTextBox = New System.Windows.Forms.TextBox()
        Me.ordernumberTextBox = New System.Windows.Forms.TextBox()
        Me.orderinfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.customershirttotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ordertotalbeforetaxTextBox = New System.Windows.Forms.TextBox()
        Me.displaysummaryButton = New System.Windows.Forms.Button()
        Me.taxTextbox = New System.Windows.Forms.TextBox()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shirtpriceGroupBox = New System.Windows.Forms.GroupBox()
        Me.smallprice1Textbox = New System.Windows.Forms.Label()
        Me.xxlTextbox = New System.Windows.Forms.Label()
        Me.extralargeTextbox = New System.Windows.Forms.Label()
        Me.largepriceTextbox = New System.Windows.Forms.Label()
        Me.mediumpriceTextbox = New System.Windows.Forms.Label()
        Me.smallpriceTextbox = New System.Windows.Forms.Label()
        Me.xxlpriceLabel = New System.Windows.Forms.Label()
        Me.extralargepriceLabel = New System.Windows.Forms.Label()
        Me.largepriceLabel = New System.Windows.Forms.Label()
        Me.mediumpriceLabel = New System.Windows.Forms.Label()
        Me.smallpriceLabel = New System.Windows.Forms.Label()
        Me.ordertotalTextbox = New System.Windows.Forms.TextBox()
        Me.completeorderButton = New System.Windows.Forms.Button()
        Me.currentorderTextbox = New System.Windows.Forms.TextBox()
        Me.clearcurrentitemButton = New System.Windows.Forms.Button()
        Me.ordertotalLabel = New System.Windows.Forms.Label()
        Me.addshirtButton = New System.Windows.Forms.Button()
        Me.currentorderLabel = New System.Windows.Forms.Label()
        Me.pocketCheckbox = New System.Windows.Forms.CheckBox()
        Me.monogramCheckbox = New System.Windows.Forms.CheckBox()
        Me.quantityTextbox = New System.Windows.Forms.TextBox()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.shirtsizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.xxlRadioButton = New System.Windows.Forms.RadioButton()
        Me.extralargeRadioButton = New System.Windows.Forms.RadioButton()
        Me.largeRadioButton = New System.Windows.Forms.RadioButton()
        Me.mediumRadiobutton = New System.Windows.Forms.RadioButton()
        Me.smallRadioButton = New System.Windows.Forms.RadioButton()
        Me.companynameLabel = New System.Windows.Forms.Label()
        Me.alpinelogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SloganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.sloganLabel = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.orderinfoGroupBox.SuspendLayout()
        Me.shirtpriceGroupBox.SuspendLayout()
        Me.shirtsizeGroupBox.SuspendLayout()
        CType(Me.alpinelogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'customerLabel
        '
        Me.customerLabel.AutoSize = True
        Me.customerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerLabel.Location = New System.Drawing.Point(30, 98)
        Me.customerLabel.Name = "customerLabel"
        Me.customerLabel.Size = New System.Drawing.Size(97, 15)
        Me.customerLabel.TabIndex = 0
        Me.customerLabel.Text = "&Customer Name"
        '
        'ordernumberLabel
        '
        Me.ordernumberLabel.AutoSize = True
        Me.ordernumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordernumberLabel.Location = New System.Drawing.Point(43, 137)
        Me.ordernumberLabel.Name = "ordernumberLabel"
        Me.ordernumberLabel.Size = New System.Drawing.Size(86, 15)
        Me.ordernumberLabel.TabIndex = 1
        Me.ordernumberLabel.Text = "Order Number"
        '
        'customernameTextBox
        '
        Me.customernameTextBox.Location = New System.Drawing.Point(148, 98)
        Me.customernameTextBox.Name = "customernameTextBox"
        Me.customernameTextBox.Size = New System.Drawing.Size(171, 20)
        Me.customernameTextBox.TabIndex = 1
        '
        'ordernumberTextBox
        '
        Me.ordernumberTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ordernumberTextBox.Location = New System.Drawing.Point(148, 136)
        Me.ordernumberTextBox.Name = "ordernumberTextBox"
        Me.ordernumberTextBox.ReadOnly = True
        Me.ordernumberTextBox.Size = New System.Drawing.Size(70, 20)
        Me.ordernumberTextBox.TabIndex = 2
        Me.ordernumberTextBox.TabStop = False
        Me.ordernumberTextBox.Text = "1"
        Me.ordernumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'orderinfoGroupBox
        '
        Me.orderinfoGroupBox.Controls.Add(Me.customershirttotalTextBox)
        Me.orderinfoGroupBox.Controls.Add(Me.Label4)
        Me.orderinfoGroupBox.Controls.Add(Me.Label3)
        Me.orderinfoGroupBox.Controls.Add(Me.exitButton)
        Me.orderinfoGroupBox.Controls.Add(Me.ordertotalbeforetaxTextBox)
        Me.orderinfoGroupBox.Controls.Add(Me.displaysummaryButton)
        Me.orderinfoGroupBox.Controls.Add(Me.taxTextbox)
        Me.orderinfoGroupBox.Controls.Add(Me.taxLabel)
        Me.orderinfoGroupBox.Controls.Add(Me.Label2)
        Me.orderinfoGroupBox.Controls.Add(Me.Label1)
        Me.orderinfoGroupBox.Controls.Add(Me.shirtpriceGroupBox)
        Me.orderinfoGroupBox.Controls.Add(Me.ordertotalTextbox)
        Me.orderinfoGroupBox.Controls.Add(Me.completeorderButton)
        Me.orderinfoGroupBox.Controls.Add(Me.currentorderTextbox)
        Me.orderinfoGroupBox.Controls.Add(Me.clearcurrentitemButton)
        Me.orderinfoGroupBox.Controls.Add(Me.ordertotalLabel)
        Me.orderinfoGroupBox.Controls.Add(Me.addshirtButton)
        Me.orderinfoGroupBox.Controls.Add(Me.currentorderLabel)
        Me.orderinfoGroupBox.Controls.Add(Me.pocketCheckbox)
        Me.orderinfoGroupBox.Controls.Add(Me.monogramCheckbox)
        Me.orderinfoGroupBox.Controls.Add(Me.quantityTextbox)
        Me.orderinfoGroupBox.Controls.Add(Me.quantityLabel)
        Me.orderinfoGroupBox.Controls.Add(Me.shirtsizeGroupBox)
        Me.orderinfoGroupBox.Location = New System.Drawing.Point(12, 174)
        Me.orderinfoGroupBox.Name = "orderinfoGroupBox"
        Me.orderinfoGroupBox.Size = New System.Drawing.Size(771, 334)
        Me.orderinfoGroupBox.TabIndex = 4
        Me.orderinfoGroupBox.TabStop = False
        Me.orderinfoGroupBox.Text = "Order Information"
        '
        'customershirttotalTextBox
        '
        Me.customershirttotalTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.customershirttotalTextBox.Location = New System.Drawing.Point(136, 276)
        Me.customershirttotalTextBox.Name = "customershirttotalTextBox"
        Me.customershirttotalTextBox.ReadOnly = True
        Me.customershirttotalTextBox.Size = New System.Drawing.Size(67, 20)
        Me.customershirttotalTextBox.TabIndex = 18
        Me.customershirttotalTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Customer Shirt Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Order Total Before Tax"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(463, 276)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(126, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit Order Form"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ordertotalbeforetaxTextBox
        '
        Me.ordertotalbeforetaxTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ordertotalbeforetaxTextBox.Location = New System.Drawing.Point(136, 182)
        Me.ordertotalbeforetaxTextBox.Name = "ordertotalbeforetaxTextBox"
        Me.ordertotalbeforetaxTextBox.ReadOnly = True
        Me.ordertotalbeforetaxTextBox.Size = New System.Drawing.Size(67, 20)
        Me.ordertotalbeforetaxTextBox.TabIndex = 9
        Me.ordertotalbeforetaxTextBox.TabStop = False
        '
        'displaysummaryButton
        '
        Me.displaysummaryButton.Enabled = False
        Me.displaysummaryButton.Location = New System.Drawing.Point(295, 276)
        Me.displaysummaryButton.Name = "displaysummaryButton"
        Me.displaysummaryButton.Size = New System.Drawing.Size(126, 32)
        Me.displaysummaryButton.TabIndex = 6
        Me.displaysummaryButton.Text = "Displa&y Order Summary"
        Me.displaysummaryButton.UseVisualStyleBackColor = True
        '
        'taxTextbox
        '
        Me.taxTextbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.taxTextbox.Location = New System.Drawing.Point(136, 211)
        Me.taxTextbox.Name = "taxTextbox"
        Me.taxTextbox.ReadOnly = True
        Me.taxTextbox.Size = New System.Drawing.Size(67, 20)
        Me.taxTextbox.TabIndex = 10
        Me.taxTextbox.TabStop = False
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.Location = New System.Drawing.Point(76, 213)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(55, 15)
        Me.taxLabel.TabIndex = 13
        Me.taxLabel.Text = "Tax 10%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(226, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "$1.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(226, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "$2.00"
        '
        'shirtpriceGroupBox
        '
        Me.shirtpriceGroupBox.Controls.Add(Me.smallprice1Textbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.xxlTextbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.extralargeTextbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.largepriceTextbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.mediumpriceTextbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.smallpriceTextbox)
        Me.shirtpriceGroupBox.Controls.Add(Me.xxlpriceLabel)
        Me.shirtpriceGroupBox.Controls.Add(Me.extralargepriceLabel)
        Me.shirtpriceGroupBox.Controls.Add(Me.largepriceLabel)
        Me.shirtpriceGroupBox.Controls.Add(Me.mediumpriceLabel)
        Me.shirtpriceGroupBox.Controls.Add(Me.smallpriceLabel)
        Me.shirtpriceGroupBox.Location = New System.Drawing.Point(506, 20)
        Me.shirtpriceGroupBox.Name = "shirtpriceGroupBox"
        Me.shirtpriceGroupBox.Size = New System.Drawing.Size(250, 184)
        Me.shirtpriceGroupBox.TabIndex = 10
        Me.shirtpriceGroupBox.TabStop = False
        Me.shirtpriceGroupBox.Text = "Shirt Prices"
        '
        'smallprice1Textbox
        '
        Me.smallprice1Textbox.AutoSize = True
        Me.smallprice1Textbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.smallprice1Textbox.Location = New System.Drawing.Point(61, 33)
        Me.smallprice1Textbox.Name = "smallprice1Textbox"
        Me.smallprice1Textbox.Size = New System.Drawing.Size(42, 15)
        Me.smallprice1Textbox.TabIndex = 10
        Me.smallprice1Textbox.Text = "$10.50"
        '
        'xxlTextbox
        '
        Me.xxlTextbox.AutoSize = True
        Me.xxlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xxlTextbox.Location = New System.Drawing.Point(196, 85)
        Me.xxlTextbox.Name = "xxlTextbox"
        Me.xxlTextbox.Size = New System.Drawing.Size(42, 15)
        Me.xxlTextbox.TabIndex = 9
        Me.xxlTextbox.Text = "$12.50"
        '
        'extralargeTextbox
        '
        Me.extralargeTextbox.AutoSize = True
        Me.extralargeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.extralargeTextbox.Location = New System.Drawing.Point(196, 33)
        Me.extralargeTextbox.Name = "extralargeTextbox"
        Me.extralargeTextbox.Size = New System.Drawing.Size(42, 15)
        Me.extralargeTextbox.TabIndex = 8
        Me.extralargeTextbox.Text = "$11.50"
        '
        'largepriceTextbox
        '
        Me.largepriceTextbox.AutoSize = True
        Me.largepriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.largepriceTextbox.Location = New System.Drawing.Point(61, 139)
        Me.largepriceTextbox.Name = "largepriceTextbox"
        Me.largepriceTextbox.Size = New System.Drawing.Size(42, 15)
        Me.largepriceTextbox.TabIndex = 7
        Me.largepriceTextbox.Text = "$10.50"
        '
        'mediumpriceTextbox
        '
        Me.mediumpriceTextbox.AutoSize = True
        Me.mediumpriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mediumpriceTextbox.Location = New System.Drawing.Point(61, 85)
        Me.mediumpriceTextbox.Name = "mediumpriceTextbox"
        Me.mediumpriceTextbox.Size = New System.Drawing.Size(42, 15)
        Me.mediumpriceTextbox.TabIndex = 6
        Me.mediumpriceTextbox.Text = "$10.50"
        '
        'smallpriceTextbox
        '
        Me.smallpriceTextbox.AutoSize = True
        Me.smallpriceTextbox.Location = New System.Drawing.Point(66, 33)
        Me.smallpriceTextbox.Name = "smallpriceTextbox"
        Me.smallpriceTextbox.Size = New System.Drawing.Size(0, 13)
        Me.smallpriceTextbox.TabIndex = 5
        '
        'xxlpriceLabel
        '
        Me.xxlpriceLabel.AutoSize = True
        Me.xxlpriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xxlpriceLabel.Location = New System.Drawing.Point(122, 83)
        Me.xxlpriceLabel.Name = "xxlpriceLabel"
        Me.xxlpriceLabel.Size = New System.Drawing.Size(30, 15)
        Me.xxlpriceLabel.TabIndex = 4
        Me.xxlpriceLabel.Text = "XXL"
        '
        'extralargepriceLabel
        '
        Me.extralargepriceLabel.AutoSize = True
        Me.extralargepriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extralargepriceLabel.Location = New System.Drawing.Point(120, 33)
        Me.extralargepriceLabel.Name = "extralargepriceLabel"
        Me.extralargepriceLabel.Size = New System.Drawing.Size(70, 15)
        Me.extralargepriceLabel.TabIndex = 3
        Me.extralargepriceLabel.Text = "Extra Large"
        '
        'largepriceLabel
        '
        Me.largepriceLabel.AutoSize = True
        Me.largepriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largepriceLabel.Location = New System.Drawing.Point(17, 138)
        Me.largepriceLabel.Name = "largepriceLabel"
        Me.largepriceLabel.Size = New System.Drawing.Size(39, 15)
        Me.largepriceLabel.TabIndex = 2
        Me.largepriceLabel.Text = "Large"
        '
        'mediumpriceLabel
        '
        Me.mediumpriceLabel.AutoSize = True
        Me.mediumpriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumpriceLabel.Location = New System.Drawing.Point(6, 83)
        Me.mediumpriceLabel.Name = "mediumpriceLabel"
        Me.mediumpriceLabel.Size = New System.Drawing.Size(53, 15)
        Me.mediumpriceLabel.TabIndex = 1
        Me.mediumpriceLabel.Text = "Medium"
        '
        'smallpriceLabel
        '
        Me.smallpriceLabel.AutoSize = True
        Me.smallpriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallpriceLabel.Location = New System.Drawing.Point(16, 33)
        Me.smallpriceLabel.Name = "smallpriceLabel"
        Me.smallpriceLabel.Size = New System.Drawing.Size(39, 15)
        Me.smallpriceLabel.TabIndex = 0
        Me.smallpriceLabel.Text = "Small"
        '
        'ordertotalTextbox
        '
        Me.ordertotalTextbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ordertotalTextbox.Location = New System.Drawing.Point(136, 243)
        Me.ordertotalTextbox.Name = "ordertotalTextbox"
        Me.ordertotalTextbox.ReadOnly = True
        Me.ordertotalTextbox.Size = New System.Drawing.Size(67, 20)
        Me.ordertotalTextbox.TabIndex = 11
        Me.ordertotalTextbox.TabStop = False
        '
        'completeorderButton
        '
        Me.completeorderButton.Enabled = False
        Me.completeorderButton.Location = New System.Drawing.Point(534, 242)
        Me.completeorderButton.Name = "completeorderButton"
        Me.completeorderButton.Size = New System.Drawing.Size(126, 22)
        Me.completeorderButton.TabIndex = 5
        Me.completeorderButton.Text = "Complete Shi&rt Order"
        Me.completeorderButton.UseVisualStyleBackColor = True
        '
        'currentorderTextbox
        '
        Me.currentorderTextbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.currentorderTextbox.Location = New System.Drawing.Point(136, 153)
        Me.currentorderTextbox.Name = "currentorderTextbox"
        Me.currentorderTextbox.ReadOnly = True
        Me.currentorderTextbox.Size = New System.Drawing.Size(67, 20)
        Me.currentorderTextbox.TabIndex = 8
        Me.currentorderTextbox.TabStop = False
        '
        'clearcurrentitemButton
        '
        Me.clearcurrentitemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearcurrentitemButton.Location = New System.Drawing.Point(234, 243)
        Me.clearcurrentitemButton.Name = "clearcurrentitemButton"
        Me.clearcurrentitemButton.Size = New System.Drawing.Size(128, 21)
        Me.clearcurrentitemButton.TabIndex = 3
        Me.clearcurrentitemButton.Text = "Clear Current &Item"
        Me.clearcurrentitemButton.UseVisualStyleBackColor = True
        '
        'ordertotalLabel
        '
        Me.ordertotalLabel.AutoSize = True
        Me.ordertotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordertotalLabel.Location = New System.Drawing.Point(60, 245)
        Me.ordertotalLabel.Name = "ordertotalLabel"
        Me.ordertotalLabel.Size = New System.Drawing.Size(68, 15)
        Me.ordertotalLabel.TabIndex = 6
        Me.ordertotalLabel.Text = "Order Total"
        '
        'addshirtButton
        '
        Me.addshirtButton.Location = New System.Drawing.Point(383, 242)
        Me.addshirtButton.Name = "addshirtButton"
        Me.addshirtButton.Size = New System.Drawing.Size(126, 21)
        Me.addshirtButton.TabIndex = 4
        Me.addshirtButton.Text = "A&dd Shirt to Order"
        Me.addshirtButton.UseVisualStyleBackColor = True
        '
        'currentorderLabel
        '
        Me.currentorderLabel.AutoSize = True
        Me.currentorderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentorderLabel.Location = New System.Drawing.Point(49, 153)
        Me.currentorderLabel.Name = "currentorderLabel"
        Me.currentorderLabel.Size = New System.Drawing.Size(81, 15)
        Me.currentorderLabel.TabIndex = 5
        Me.currentorderLabel.Text = "Current Order"
        '
        'pocketCheckbox
        '
        Me.pocketCheckbox.AutoSize = True
        Me.pocketCheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pocketCheckbox.Location = New System.Drawing.Point(133, 110)
        Me.pocketCheckbox.Name = "pocketCheckbox"
        Me.pocketCheckbox.Size = New System.Drawing.Size(63, 19)
        Me.pocketCheckbox.TabIndex = 2
        Me.pocketCheckbox.Text = "&Pocket"
        Me.pocketCheckbox.UseVisualStyleBackColor = True
        '
        'monogramCheckbox
        '
        Me.monogramCheckbox.AutoSize = True
        Me.monogramCheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monogramCheckbox.Location = New System.Drawing.Point(133, 71)
        Me.monogramCheckbox.Name = "monogramCheckbox"
        Me.monogramCheckbox.Size = New System.Drawing.Size(87, 19)
        Me.monogramCheckbox.TabIndex = 1
        Me.monogramCheckbox.Text = "&Monogram"
        Me.monogramCheckbox.UseVisualStyleBackColor = True
        '
        'quantityTextbox
        '
        Me.quantityTextbox.Location = New System.Drawing.Point(133, 28)
        Me.quantityTextbox.Name = "quantityTextbox"
        Me.quantityTextbox.Size = New System.Drawing.Size(70, 20)
        Me.quantityTextbox.TabIndex = 0
        Me.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityLabel.Location = New System.Drawing.Point(68, 28)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(51, 15)
        Me.quantityLabel.TabIndex = 1
        Me.quantityLabel.Text = "&Quantity"
        '
        'shirtsizeGroupBox
        '
        Me.shirtsizeGroupBox.Controls.Add(Me.xxlRadioButton)
        Me.shirtsizeGroupBox.Controls.Add(Me.extralargeRadioButton)
        Me.shirtsizeGroupBox.Controls.Add(Me.largeRadioButton)
        Me.shirtsizeGroupBox.Controls.Add(Me.mediumRadiobutton)
        Me.shirtsizeGroupBox.Controls.Add(Me.smallRadioButton)
        Me.shirtsizeGroupBox.Location = New System.Drawing.Point(277, 20)
        Me.shirtsizeGroupBox.Name = "shirtsizeGroupBox"
        Me.shirtsizeGroupBox.Size = New System.Drawing.Size(223, 185)
        Me.shirtsizeGroupBox.TabIndex = 0
        Me.shirtsizeGroupBox.TabStop = False
        Me.shirtsizeGroupBox.Text = "Shirt Size Selection"
        '
        'xxlRadioButton
        '
        Me.xxlRadioButton.AutoSize = True
        Me.xxlRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xxlRadioButton.Location = New System.Drawing.Point(127, 80)
        Me.xxlRadioButton.Name = "xxlRadioButton"
        Me.xxlRadioButton.Size = New System.Drawing.Size(48, 19)
        Me.xxlRadioButton.TabIndex = 4
        Me.xxlRadioButton.Text = "&XXL"
        Me.xxlRadioButton.UseVisualStyleBackColor = True
        '
        'extralargeRadioButton
        '
        Me.extralargeRadioButton.AutoSize = True
        Me.extralargeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extralargeRadioButton.Location = New System.Drawing.Point(127, 28)
        Me.extralargeRadioButton.Name = "extralargeRadioButton"
        Me.extralargeRadioButton.Size = New System.Drawing.Size(88, 19)
        Me.extralargeRadioButton.TabIndex = 3
        Me.extralargeRadioButton.Text = "&Extra Large"
        Me.extralargeRadioButton.UseVisualStyleBackColor = True
        '
        'largeRadioButton
        '
        Me.largeRadioButton.AutoSize = True
        Me.largeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeRadioButton.Location = New System.Drawing.Point(18, 135)
        Me.largeRadioButton.Name = "largeRadioButton"
        Me.largeRadioButton.Size = New System.Drawing.Size(57, 19)
        Me.largeRadioButton.TabIndex = 2
        Me.largeRadioButton.Text = "Lar&ge"
        Me.largeRadioButton.UseVisualStyleBackColor = True
        '
        'mediumRadiobutton
        '
        Me.mediumRadiobutton.AutoSize = True
        Me.mediumRadiobutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumRadiobutton.Location = New System.Drawing.Point(18, 80)
        Me.mediumRadiobutton.Name = "mediumRadiobutton"
        Me.mediumRadiobutton.Size = New System.Drawing.Size(71, 19)
        Me.mediumRadiobutton.TabIndex = 1
        Me.mediumRadiobutton.Text = "M&edium"
        Me.mediumRadiobutton.UseVisualStyleBackColor = True
        '
        'smallRadioButton
        '
        Me.smallRadioButton.AutoSize = True
        Me.smallRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallRadioButton.Location = New System.Drawing.Point(18, 28)
        Me.smallRadioButton.Name = "smallRadioButton"
        Me.smallRadioButton.Size = New System.Drawing.Size(57, 19)
        Me.smallRadioButton.TabIndex = 0
        Me.smallRadioButton.Text = "Sm&all"
        Me.smallRadioButton.UseVisualStyleBackColor = True
        '
        'companynameLabel
        '
        Me.companynameLabel.AutoSize = True
        Me.companynameLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companynameLabel.Location = New System.Drawing.Point(12, 44)
        Me.companynameLabel.Name = "companynameLabel"
        Me.companynameLabel.Size = New System.Drawing.Size(301, 32)
        Me.companynameLabel.TabIndex = 5
        Me.companynameLabel.Text = "Alpine Snowboards Inc."
        '
        'alpinelogoPictureBox
        '
        Me.alpinelogoPictureBox.Image = CType(resources.GetObject("alpinelogoPictureBox.Image"), System.Drawing.Image)
        Me.alpinelogoPictureBox.Location = New System.Drawing.Point(530, 47)
        Me.alpinelogoPictureBox.Name = "alpinelogoPictureBox"
        Me.alpinelogoPictureBox.Size = New System.Drawing.Size(198, 85)
        Me.alpinelogoPictureBox.TabIndex = 6
        Me.alpinelogoPictureBox.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SaleToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToOrderToolStripMenuItem, Me.ClearThisItemToolStripMenuItem, Me.OrderCompleteToolStripMenuItem})
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SaleToolStripMenuItem.Text = "&Sale"
        '
        'AddToOrderToolStripMenuItem
        '
        Me.AddToOrderToolStripMenuItem.Name = "AddToOrderToolStripMenuItem"
        Me.AddToOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AddToOrderToolStripMenuItem.Text = "&Add to Order"
        '
        'ClearThisItemToolStripMenuItem
        '
        Me.ClearThisItemToolStripMenuItem.Name = "ClearThisItemToolStripMenuItem"
        Me.ClearThisItemToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ClearThisItemToolStripMenuItem.Text = "C&lear This Item"
        '
        'OrderCompleteToolStripMenuItem
        '
        Me.OrderCompleteToolStripMenuItem.Name = "OrderCompleteToolStripMenuItem"
        Me.OrderCompleteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OrderCompleteToolStripMenuItem.Text = "O&rder Complete"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripSeparator2, Me.SloganToolStripMenuItem, Me.LogoToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(107, 6)
        '
        'SloganToolStripMenuItem
        '
        Me.SloganToolStripMenuItem.Checked = True
        Me.SloganToolStripMenuItem.CheckOnClick = True
        Me.SloganToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SloganToolStripMenuItem.Name = "SloganToolStripMenuItem"
        Me.SloganToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SloganToolStripMenuItem.Text = "&Slogan"
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Checked = True
        Me.LogoToolStripMenuItem.CheckOnClick = True
        Me.LogoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.LogoToolStripMenuItem.Text = "&Logo"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'sloganLabel
        '
        Me.sloganLabel.AutoSize = True
        Me.sloganLabel.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Italic)
        Me.sloganLabel.Location = New System.Drawing.Point(567, 142)
        Me.sloganLabel.Name = "sloganLabel"
        Me.sloganLabel.Size = New System.Drawing.Size(135, 20)
        Me.sloganLabel.TabIndex = 14
        Me.sloganLabel.Text = """Boards You Will Love"""
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'shirtorderForm
        '
        Me.AcceptButton = Me.completeorderButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(797, 520)
        Me.Controls.Add(Me.sloganLabel)
        Me.Controls.Add(Me.alpinelogoPictureBox)
        Me.Controls.Add(Me.companynameLabel)
        Me.Controls.Add(Me.orderinfoGroupBox)
        Me.Controls.Add(Me.ordernumberTextBox)
        Me.Controls.Add(Me.customernameTextBox)
        Me.Controls.Add(Me.ordernumberLabel)
        Me.Controls.Add(Me.customerLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "shirtorderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shirt Order Form"
        Me.orderinfoGroupBox.ResumeLayout(False)
        Me.orderinfoGroupBox.PerformLayout()
        Me.shirtpriceGroupBox.ResumeLayout(False)
        Me.shirtpriceGroupBox.PerformLayout()
        Me.shirtsizeGroupBox.ResumeLayout(False)
        Me.shirtsizeGroupBox.PerformLayout()
        CType(Me.alpinelogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customerLabel As System.Windows.Forms.Label
    Friend WithEvents ordernumberLabel As System.Windows.Forms.Label
    Friend WithEvents customernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ordernumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents orderinfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents quantityTextbox As System.Windows.Forms.TextBox
    Friend WithEvents companynameLabel As System.Windows.Forms.Label
    Friend WithEvents alpinelogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents pocketCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents monogramCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents quantityLabel As System.Windows.Forms.Label
    Friend WithEvents shirtsizeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xxlRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents extralargeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents largeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents mediumRadiobutton As System.Windows.Forms.RadioButton
    Friend WithEvents smallRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ordertotalTextbox As System.Windows.Forms.TextBox
    Friend WithEvents currentorderTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ordertotalLabel As System.Windows.Forms.Label
    Friend WithEvents currentorderLabel As System.Windows.Forms.Label
    Friend WithEvents addshirtButton As System.Windows.Forms.Button
    Friend WithEvents clearcurrentitemButton As System.Windows.Forms.Button
    Friend WithEvents completeorderButton As System.Windows.Forms.Button
    Friend WithEvents displaysummaryButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents shirtpriceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xxlpriceLabel As System.Windows.Forms.Label
    Friend WithEvents extralargepriceLabel As System.Windows.Forms.Label
    Friend WithEvents largepriceLabel As System.Windows.Forms.Label
    Friend WithEvents mediumpriceLabel As System.Windows.Forms.Label
    Friend WithEvents smallpriceLabel As System.Windows.Forms.Label
    Friend WithEvents smallprice1Textbox As System.Windows.Forms.Label
    Friend WithEvents xxlTextbox As System.Windows.Forms.Label
    Friend WithEvents extralargeTextbox As System.Windows.Forms.Label
    Friend WithEvents largepriceTextbox As System.Windows.Forms.Label
    Friend WithEvents mediumpriceTextbox As System.Windows.Forms.Label
    Friend WithEvents smallpriceTextbox As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderCompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SloganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents sloganLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents taxTextbox As System.Windows.Forms.TextBox
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents ordertotalbeforetaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents customershirttotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

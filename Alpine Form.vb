'Program Name:  Alpine Snowboards Inc
'Programmer:    Ashley Pope
'Description:   Creating arrays which stores informtation of shirt styles, quantity, size, price and extended price. 
'               

Public Class shirtorderForm
    ' Declare structure and module-level variables.
    Structure ShirtCustomerSales
        Dim quantityInt As Integer
        Dim sizeString As String
        Dim monogramBoolean As String
        Dim pocketBoolean As String
        Dim priceDec As Decimal
        Dim extpriceDecimal As Decimal
        Dim customernameString As String
        Dim ordernumberInt As Integer
    End Structure

    Private shirtsizeString As String
    Private monogramBool As String
    Private pocketBool As String
    Private customershirttotal As Integer
    Public quantityInteger As Integer
    Public currentOrderDecimal, order2totalDecimal, ordertotalDecimal As Decimal

    ' Declare constants.
    Const SMALL_SHIRT_INTEGER As Decimal = 10.5D
    Const MEDIUM_SHIRT_INTEGER As Decimal = 10.5D
    Const LARGE_SHIRT_INTEGER As Decimal = 10.5D
    Const EXTRALARGE_SHIRT_INTEGER As Decimal = 11.5D
    Const XXL_SHIRT_INTEGER As Decimal = 12.5D
    Const MONOGRAM_INTEGER As Decimal = 2D
    Const POCKET_INTEGER As Decimal = 1D
    Const POCKETMONOGRAM_INTEGER As Decimal = 3D
    Const TAX_RATE_DECIMAL As Decimal = 0.1D

    Private CustomerSalesInformation(20) As ShirtCustomerSales
    Private ItemCountInteger As Integer

    ' Declare variables for summary information.
    Friend totalnumberofshirtsDecimal, totalnumberofordersDecimal, dollartotalorderDecimal As Decimal

    Private Sub addshirtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addshirtButton.Click, AddToOrderToolStripMenuItem.Click

        Dim currentOrderDecimal, taxDecimal, order2totalDecimal As Decimal
        Dim quantityInteger As Integer
        Dim current1orderDecimal, shirt1priceDecimal As Decimal

        With Me
            If customernameTextBox.Text <> "" Then
                Try

                    ' Convert quantity to numeric variable.
                    quantityInteger = Integer.Parse(.quantityTextbox.Text)

                    If quantityInteger > 0 Then

                        ' Call function procedure for price of shirts.
                        currentOrderDecimal = FindPriceofShirts(current1orderDecimal, shirt1priceDecimal) * quantityInteger

                        If .smallRadioButton.Checked = True Or .mediumRadiobutton.Checked = True Or .largeRadioButton.Checked = True _
                        Or .extralargeRadioButton.Checked = True Or .xxlRadioButton.Checked = True Then

                            ' Calculate order total.
                            ordertotalDecimal += currentOrderDecimal

                            'Customer shirt totals per order.
                            customershirttotal += quantityInteger
                            .customershirttotalTextBox.Text = customershirttotal.ToString

                            ' Call a function procedure for tax.
                            taxDecimal = FindTax(ordertotalDecimal)

                            ' Calculate order total plus tax.
                            order2totalDecimal += (taxDecimal + ordertotalDecimal)

                            ' Calculate number of shirts.
                            totalnumberofshirtsDecimal += quantityInteger

                            ' Calculate number of orders.
                            totalnumberofordersDecimal = ordernumberTextBox.Text

                            ' Calculate number of total orders.
                            dollartotalorderDecimal += order2totalDecimal


                            ' Display answer for shirt orders.
                            .currentorderTextbox.Text = currentOrderDecimal.ToString("C")
                            .ordertotalTextbox.Text = order2totalDecimal.ToString("C")
                            .taxTextbox.Text = taxDecimal.ToString("N")
                            .ordertotalbeforetaxTextBox.Text = ordertotalDecimal.ToString("C")

                            With CustomerSalesInformation(ItemCountInteger)
                                .quantityInt = quantityInteger
                                .priceDec = FindPriceofShirts(current1orderDecimal, shirt1priceDecimal)
                                .extpriceDecimal = FindPriceofShirts(current1orderDecimal, shirt1priceDecimal) * quantityInteger
                                .monogramBoolean = monogramBool
                                .pocketBoolean = pocketBool
                                .sizeString = shirtsizeString
                                .customernameString = Me.customernameTextBox.Text
                                .ordernumberInt = Me.ordernumberTextBox.Text
                            End With

                            ItemCountInteger += 1

                            ' Allow Clear after an order is begun.
                            .clearcurrentitemButton.Enabled = True
                            .customernameTextBox.Enabled = False
                            clear()
                            completeorderButton.Enabled = True

                        Else
                            MessageBox.Show("Must Select a Shirt size", "No Shirt Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Quantity must be larger than zero", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        With .quantityTextbox
                            .Focus()
                            .SelectAll()
                        End With

                    End If
                Catch quantityException As FormatException
                    MessageBox.Show("Quantity must numeric.", "Data Entry Error", MessageBoxButtons.OK, _
            MessageBoxIcon.Hand)
                    With .quantityTextbox
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            Else
                MessageBox.Show("Enter Customer Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With Me.customernameTextBox
                    .Focus()
                End With
            End If
        End With
    End Sub
    Private Function FindPriceofShirts(ByVal current1orderDecimal As Decimal, ByVal shirt1priceDecimal As Decimal) As Decimal
        ' Function for the price of shirts.
        With Me
            If smallRadioButton.Checked Then
                shirt1priceDecimal = SMALL_SHIRT_INTEGER
                shirtsizeString = "Small"
            End If
            If mediumRadiobutton.Checked Then
                shirt1priceDecimal = MEDIUM_SHIRT_INTEGER
                shirtsizeString = "Medium"
            End If
            If largeRadioButton.Checked Then
                shirt1priceDecimal = LARGE_SHIRT_INTEGER
                shirtsizeString = "Large"
            End If
            If extralargeRadioButton.Checked Then
                shirt1priceDecimal = EXTRALARGE_SHIRT_INTEGER
                shirtsizeString = "Extra Large"
            End If
            If xxlRadioButton.Checked Then
                shirt1priceDecimal = XXL_SHIRT_INTEGER
                shirtsizeString = "XXL"
            End If

            If shirt1priceDecimal <> 0 Then

                If .monogramCheckbox.Checked Then
                    current1orderDecimal += MONOGRAM_INTEGER
                    monogramBool = "Yes"
                Else
                    monogramBool = "No"
                End If
                If .pocketCheckbox.Checked Then
                    current1orderDecimal += POCKET_INTEGER
                    pocketBool = "Yes"
                Else
                    pocketBool = "No"
                End If
            End If
            Return shirt1priceDecimal + current1orderDecimal
        End With
    End Function

    Private Function FindTax(ByVal order1totalDecimal As Decimal) As Decimal
        ' Calculate the sales tax.

        Return order1totalDecimal * TAX_RATE_DECIMAL


    End Function

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click, ExitToolStripMenuItem.Click
        ' Exit the project.

        Me.Close()
    End Sub

    Private Sub clearcurrentitemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearcurrentitemButton.Click, ClearThisItemToolStripMenuItem.Click
        ' Clear the appropriate controls.
        quantityTextbox.Text = ""
        With Me
            clear()
            .currentorderTextbox.Clear()
            .taxTextbox.Clear()
        End With
    End Sub
    Public Sub clear()
        ' Clears the radiobuttons and quantity text box.
        With Me
            .smallRadioButton.Checked = False
            .mediumRadiobutton.Checked = False
            .largeRadioButton.Checked = False
            .extralargeRadioButton.Checked = False
            .xxlRadioButton.Checked = False
            .quantityTextbox.Clear()
        End With
    End Sub

    Private Sub completeorderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles completeorderButton.Click, OrderCompleteToolStripMenuItem.Click
        Dim resultDialogBox As DialogResult
        Dim messageString As String

        ' Occurs after complete order button is clicked.
        With Me
            If quantityTextbox.Text = "" Then
                If completeorderButton.Enabled = True Then
                    completeorderButton.Enabled = False
                End If
                messageString = "Your Total Order: " & .ordertotalTextbox.Text & ControlChars.NewLine & ControlChars.NewLine _
                & "Shirt Totals: " & .customershirttotalTextBox.Text
                MessageBox.Show(messageString, "Total Order", MessageBoxButtons.OK)
                resultDialogBox = MessageBox.Show("Are you sure you want to complete your order?", "Complete Order", MessageBoxButtons.YesNo)
                If resultDialogBox = Windows.Forms.DialogResult.Yes Then
                    .taxTextbox.Clear()
                    .currentorderTextbox.Clear()
                    .ordertotalTextbox.Clear()
                    .displaysummaryButton.Enabled = True
                    .smallRadioButton.Checked = False
                    .mediumRadiobutton.Checked = False
                    .largeRadioButton.Checked = False
                    .extralargeRadioButton.Checked = False
                    .xxlRadioButton.Checked = False
                    .quantityTextbox.Clear()
                    .ordertotalbeforetaxTextBox.Clear()
                    .monogramCheckbox.Checked = False
                    .pocketCheckbox.Checked = False
                    .customernameTextBox.Enabled = True
                    .ordernumberTextBox.Enabled = False
                    ordertotalDecimal = 0
                    customershirttotal = 0
                    .customershirttotalTextBox.Clear()
                    .ordernumberTextBox.Text += 1
                    With .customernameTextBox
                        .Clear()
                        .Focus()
                    End With
                Else
                    With Me.quantityTextbox()
                        .Focus()
                    End With
                    completeorderButton.Enabled = True
                End If
            Else
                MessageBox.Show("Must complete order before hitting complete order button.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With

    End Sub

    Private Sub displaysummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displaysummaryButton.Click, SummaryToolStripMenuItem.Click
        ' Show summary for the day's totals.
        summaryForm.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Allow the user to set the font.
        FontDialog1.ShowDialog()

        With Me
            .sloganLabel.Font() = FontDialog1.Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allow the user to set the color.
        ColorDialog1.ShowDialog()

        With Me
            .sloganLabel.ForeColor = ColorDialog1.Color
        End With
    End Sub

    Private Sub SloganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SloganToolStripMenuItem.Click
        ' Allow the user to select a new font for slogan.

        Me.sloganLabel.Visible = Me.SloganToolStripMenuItem.Checked
    End Sub

    Private Sub LogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoToolStripMenuItem.Click
        ' Allow the user to select a new font for logo.

        Me.alpinelogoPictureBox.Visible = Me.LogoToolStripMenuItem.Checked
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the About message box.
        AlpineAboutBox.Show()
    End Sub
    Private Sub AlpineSplashScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Hold the form on the screen approximately 5 seconds before closing.

        System.Threading.Thread.Sleep(5000)     'Sleep 5000 milliseconds.
    End Sub

End Class

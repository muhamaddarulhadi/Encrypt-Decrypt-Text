<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btCrypt = New System.Windows.Forms.Button()
        Me.btDecrypt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEXT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SHIFT KEY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RESULT"
        '
        'txtText
        '
        Me.txtText.AllowDrop = True
        Me.txtText.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtText.Location = New System.Drawing.Point(36, 91)
        Me.txtText.MaxLength = 99999999
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtText.Size = New System.Drawing.Size(382, 82)
        Me.txtText.TabIndex = 3
        '
        'txtKey
        '
        Me.txtKey.AllowDrop = True
        Me.txtKey.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(112, 22)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(79, 23)
        Me.txtKey.TabIndex = 4
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(36, 276)
        Me.txtResult.MaxLength = 99999999
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(382, 85)
        Me.txtResult.TabIndex = 5
        '
        'btCrypt
        '
        Me.btCrypt.BackColor = System.Drawing.Color.White
        Me.btCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCrypt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCrypt.ForeColor = System.Drawing.Color.Black
        Me.btCrypt.Location = New System.Drawing.Point(36, 182)
        Me.btCrypt.Name = "btCrypt"
        Me.btCrypt.Size = New System.Drawing.Size(79, 29)
        Me.btCrypt.TabIndex = 6
        Me.btCrypt.Text = "ENCRYPT"
        Me.btCrypt.UseVisualStyleBackColor = False
        '
        'btDecrypt
        '
        Me.btDecrypt.BackColor = System.Drawing.Color.White
        Me.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btDecrypt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDecrypt.Location = New System.Drawing.Point(129, 182)
        Me.btDecrypt.Name = "btDecrypt"
        Me.btDecrypt.Size = New System.Drawing.Size(80, 29)
        Me.btDecrypt.TabIndex = 7
        Me.btDecrypt.Text = "DECRYPT"
        Me.btDecrypt.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(384, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CLEAR ALL"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 50
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.BackColor = System.Drawing.Color.White
        Me.ToolTip2.InitialDelay = 50
        Me.ToolTip2.ReshowDelay = 10
        '
        'ToolTip3
        '
        Me.ToolTip3.AutomaticDelay = 50
        Me.ToolTip3.AutoPopDelay = 5000
        Me.ToolTip3.BackColor = System.Drawing.Color.White
        Me.ToolTip3.InitialDelay = 50
        Me.ToolTip3.ReshowDelay = 10
        '
        'ToolTip4
        '
        Me.ToolTip4.AutomaticDelay = 50
        Me.ToolTip4.AutoPopDelay = 5000
        Me.ToolTip4.BackColor = System.Drawing.Color.White
        Me.ToolTip4.InitialDelay = 50
        Me.ToolTip4.ReshowDelay = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(325, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CREATOR"
        '
        'ToolTip5
        '
        Me.ToolTip5.AutomaticDelay = 50
        Me.ToolTip5.AutoPopDelay = 5000
        Me.ToolTip5.BackColor = System.Drawing.Color.White
        Me.ToolTip5.InitialDelay = 50
        Me.ToolTip5.ReshowDelay = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(256, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CLOSE ALL"
        '
        'ToolTip6
        '
        Me.ToolTip6.AutomaticDelay = 50
        Me.ToolTip6.AutoPopDelay = 5000
        Me.ToolTip6.InitialDelay = 50
        Me.ToolTip6.ReshowDelay = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Bisque
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(451, 403)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btDecrypt)
        Me.Controls.Add(Me.btCrypt)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENCRYPT & DECRYPT CAESAR CIPHER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btCrypt As System.Windows.Forms.Button
    Friend WithEvents btDecrypt As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip6 As ToolTip
End Class

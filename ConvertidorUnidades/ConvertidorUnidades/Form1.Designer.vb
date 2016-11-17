<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.cmdconvertir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblum = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.cmdnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESA VALOR"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(37, 29)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(135, 20)
        Me.txtvalor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "A:"
        '
        'cbxentrada
        '
        Me.cbxentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas"})
        Me.cbxentrada.Location = New System.Drawing.Point(38, 78)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(132, 21)
        Me.cbxentrada.TabIndex = 4
        '
        'cbxsalida
        '
        Me.cbxsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas"})
        Me.cbxsalida.Location = New System.Drawing.Point(39, 133)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(131, 21)
        Me.cbxsalida.TabIndex = 5
        '
        'cmdconvertir
        '
        Me.cmdconvertir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmdconvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdconvertir.Location = New System.Drawing.Point(41, 176)
        Me.cmdconvertir.Name = "cmdconvertir"
        Me.cmdconvertir.Size = New System.Drawing.Size(128, 32)
        Me.cmdconvertir.TabIndex = 6
        Me.cmdconvertir.Text = "CONVERTIR"
        Me.cmdconvertir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblum)
        Me.GroupBox1.Controls.Add(Me.lblr)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 76)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADO"
        '
        'lblum
        '
        Me.lblum.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblum.Location = New System.Drawing.Point(130, 28)
        Me.lblum.Name = "lblum"
        Me.lblum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblum.Size = New System.Drawing.Size(65, 37)
        Me.lblum.TabIndex = 1
        '
        'lblr
        '
        Me.lblr.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(6, 25)
        Me.lblr.Name = "lblr"
        Me.lblr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblr.Size = New System.Drawing.Size(114, 37)
        Me.lblr.TabIndex = 0
        '
        'cmdnuevo
        '
        Me.cmdnuevo.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnuevo.Location = New System.Drawing.Point(134, 318)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(114, 31)
        Me.cmdnuevo.TabIndex = 8
        Me.cmdnuevo.Text = "NUEVO"
        Me.cmdnuevo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 372)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdconvertir)
        Me.Controls.Add(Me.cbxsalida)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ConvertidorUnidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxentrada As System.Windows.Forms.ComboBox
    Friend WithEvents cbxsalida As System.Windows.Forms.ComboBox
    Friend WithEvents cmdconvertir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents lblum As System.Windows.Forms.Label
    Friend WithEvents cmdnuevo As System.Windows.Forms.Button

End Class

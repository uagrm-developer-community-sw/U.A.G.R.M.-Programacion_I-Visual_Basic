<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formularo_Numeros_Naturales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formularo_Numeros_Naturales))
        Me.MnStrpFNN = New System.Windows.Forms.MenuStrip()
        Me.INICIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCARGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HERRAMIENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRACTICO1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRACTICO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtBx1 = New System.Windows.Forms.TextBox()
        Me.TxtBx2 = New System.Windows.Forms.TextBox()
        Me.BtnFNNCargar = New System.Windows.Forms.Button()
        Me.BtnFNNDescargar = New System.Windows.Forms.Button()
        Me.BtnFNNLimpiar = New System.Windows.Forms.Button()
        Me.BtnFNNSalir = New System.Windows.Forms.Button()
        Me.TxtBx3 = New System.Windows.Forms.TextBox()
        Me.BtnFNNLimTxtBx1 = New System.Windows.Forms.Button()
        Me.BtnFNNLimTxtBx2 = New System.Windows.Forms.Button()
        Me.BtnFNNLimTxtBx3 = New System.Windows.Forms.Button()
        Me.PcBxFNNLogo = New System.Windows.Forms.PictureBox()
        Me.ContarDgitosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitoMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitoMenorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnStrpFNN.SuspendLayout()
        CType(Me.PcBxFNNLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MnStrpFNN
        '
        Me.MnStrpFNN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIOToolStripMenuItem, Me.HERRAMIENTASToolStripMenuItem, Me.PRACTICO1ToolStripMenuItem, Me.PRACTICO2ToolStripMenuItem})
        Me.MnStrpFNN.Location = New System.Drawing.Point(0, 0)
        Me.MnStrpFNN.Name = "MnStrpFNN"
        Me.MnStrpFNN.Size = New System.Drawing.Size(587, 24)
        Me.MnStrpFNN.TabIndex = 0
        Me.MnStrpFNN.Text = "MenuStrip1"
        '
        'INICIOToolStripMenuItem
        '
        Me.INICIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CARGARToolStripMenuItem, Me.DESCARGARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.INICIOToolStripMenuItem.Name = "INICIOToolStripMenuItem"
        Me.INICIOToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.INICIOToolStripMenuItem.Text = "INICIO"
        '
        'CARGARToolStripMenuItem
        '
        Me.CARGARToolStripMenuItem.Name = "CARGARToolStripMenuItem"
        Me.CARGARToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CARGARToolStripMenuItem.Text = "CARGAR"
        '
        'DESCARGARToolStripMenuItem
        '
        Me.DESCARGARToolStripMenuItem.Name = "DESCARGARToolStripMenuItem"
        Me.DESCARGARToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DESCARGARToolStripMenuItem.Text = "DESCARGAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'HERRAMIENTASToolStripMenuItem
        '
        Me.HERRAMIENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContarDgitosToolStripMenuItem, Me.DigitoMayorToolStripMenuItem, Me.DigitoMenorToolStripMenuItem})
        Me.HERRAMIENTASToolStripMenuItem.Name = "HERRAMIENTASToolStripMenuItem"
        Me.HERRAMIENTASToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.HERRAMIENTASToolStripMenuItem.Text = "HERRAMIENTAS"
        '
        'PRACTICO1ToolStripMenuItem
        '
        Me.PRACTICO1ToolStripMenuItem.Name = "PRACTICO1ToolStripMenuItem"
        Me.PRACTICO1ToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PRACTICO1ToolStripMenuItem.Text = "PRACTICO 1°"
        '
        'PRACTICO2ToolStripMenuItem
        '
        Me.PRACTICO2ToolStripMenuItem.Name = "PRACTICO2ToolStripMenuItem"
        Me.PRACTICO2ToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PRACTICO2ToolStripMenuItem.Text = "PRACTICO 2°"
        '
        'TxtBx1
        '
        Me.TxtBx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx1.Location = New System.Drawing.Point(285, 168)
        Me.TxtBx1.Multiline = True
        Me.TxtBx1.Name = "TxtBx1"
        Me.TxtBx1.Size = New System.Drawing.Size(251, 38)
        Me.TxtBx1.TabIndex = 1
        '
        'TxtBx2
        '
        Me.TxtBx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx2.Location = New System.Drawing.Point(285, 231)
        Me.TxtBx2.Multiline = True
        Me.TxtBx2.Name = "TxtBx2"
        Me.TxtBx2.Size = New System.Drawing.Size(251, 38)
        Me.TxtBx2.TabIndex = 2
        '
        'BtnFNNCargar
        '
        Me.BtnFNNCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNCargar.Location = New System.Drawing.Point(42, 163)
        Me.BtnFNNCargar.Name = "BtnFNNCargar"
        Me.BtnFNNCargar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFNNCargar.TabIndex = 3
        Me.BtnFNNCargar.Text = "CARGAR"
        Me.BtnFNNCargar.UseVisualStyleBackColor = True
        '
        'BtnFNNDescargar
        '
        Me.BtnFNNDescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNDescargar.Location = New System.Drawing.Point(42, 222)
        Me.BtnFNNDescargar.Name = "BtnFNNDescargar"
        Me.BtnFNNDescargar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFNNDescargar.TabIndex = 4
        Me.BtnFNNDescargar.Text = "DESCARGAR"
        Me.BtnFNNDescargar.UseVisualStyleBackColor = True
        '
        'BtnFNNLimpiar
        '
        Me.BtnFNNLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNLimpiar.Location = New System.Drawing.Point(42, 281)
        Me.BtnFNNLimpiar.Name = "BtnFNNLimpiar"
        Me.BtnFNNLimpiar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFNNLimpiar.TabIndex = 5
        Me.BtnFNNLimpiar.Text = "LIMPIAR"
        Me.BtnFNNLimpiar.UseVisualStyleBackColor = True
        '
        'BtnFNNSalir
        '
        Me.BtnFNNSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNSalir.Location = New System.Drawing.Point(42, 340)
        Me.BtnFNNSalir.Name = "BtnFNNSalir"
        Me.BtnFNNSalir.Size = New System.Drawing.Size(110, 53)
        Me.BtnFNNSalir.TabIndex = 6
        Me.BtnFNNSalir.Text = "SALIR"
        Me.BtnFNNSalir.UseVisualStyleBackColor = True
        '
        'TxtBx3
        '
        Me.TxtBx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx3.Location = New System.Drawing.Point(285, 355)
        Me.TxtBx3.Multiline = True
        Me.TxtBx3.Name = "TxtBx3"
        Me.TxtBx3.Size = New System.Drawing.Size(251, 38)
        Me.TxtBx3.TabIndex = 7
        '
        'BtnFNNLimTxtBx1
        '
        Me.BtnFNNLimTxtBx1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNLimTxtBx1.Location = New System.Drawing.Point(204, 168)
        Me.BtnFNNLimTxtBx1.Name = "BtnFNNLimTxtBx1"
        Me.BtnFNNLimTxtBx1.Size = New System.Drawing.Size(75, 38)
        Me.BtnFNNLimTxtBx1.TabIndex = 8
        Me.BtnFNNLimTxtBx1.Text = "LIMPIAR"
        Me.BtnFNNLimTxtBx1.UseVisualStyleBackColor = True
        '
        'BtnFNNLimTxtBx2
        '
        Me.BtnFNNLimTxtBx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNLimTxtBx2.Location = New System.Drawing.Point(204, 231)
        Me.BtnFNNLimTxtBx2.Name = "BtnFNNLimTxtBx2"
        Me.BtnFNNLimTxtBx2.Size = New System.Drawing.Size(75, 38)
        Me.BtnFNNLimTxtBx2.TabIndex = 9
        Me.BtnFNNLimTxtBx2.Text = "LIMPIAR"
        Me.BtnFNNLimTxtBx2.UseVisualStyleBackColor = True
        '
        'BtnFNNLimTxtBx3
        '
        Me.BtnFNNLimTxtBx3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFNNLimTxtBx3.Location = New System.Drawing.Point(204, 355)
        Me.BtnFNNLimTxtBx3.Name = "BtnFNNLimTxtBx3"
        Me.BtnFNNLimTxtBx3.Size = New System.Drawing.Size(75, 38)
        Me.BtnFNNLimTxtBx3.TabIndex = 10
        Me.BtnFNNLimTxtBx3.Text = "LIMPIAR"
        Me.BtnFNNLimTxtBx3.UseVisualStyleBackColor = True
        '
        'PcBxFNNLogo
        '
        Me.PcBxFNNLogo.Image = Global.Programacion_I_Visual_Basic.My.Resources.Resources.logo_y_texto
        Me.PcBxFNNLogo.Location = New System.Drawing.Point(0, 27)
        Me.PcBxFNNLogo.Name = "PcBxFNNLogo"
        Me.PcBxFNNLogo.Size = New System.Drawing.Size(582, 112)
        Me.PcBxFNNLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PcBxFNNLogo.TabIndex = 11
        Me.PcBxFNNLogo.TabStop = False
        '
        'ContarDgitosToolStripMenuItem
        '
        Me.ContarDgitosToolStripMenuItem.Name = "ContarDgitosToolStripMenuItem"
        Me.ContarDgitosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContarDgitosToolStripMenuItem.Text = "Contar Dgitos"
        '
        'DigitoMayorToolStripMenuItem
        '
        Me.DigitoMayorToolStripMenuItem.Name = "DigitoMayorToolStripMenuItem"
        Me.DigitoMayorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DigitoMayorToolStripMenuItem.Text = "Digito Mayor"
        '
        'DigitoMenorToolStripMenuItem
        '
        Me.DigitoMenorToolStripMenuItem.Name = "DigitoMenorToolStripMenuItem"
        Me.DigitoMenorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DigitoMenorToolStripMenuItem.Text = "Digito Menor"
        '
        'Formularo_Numeros_Naturales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(587, 417)
        Me.Controls.Add(Me.PcBxFNNLogo)
        Me.Controls.Add(Me.BtnFNNLimTxtBx3)
        Me.Controls.Add(Me.BtnFNNLimTxtBx2)
        Me.Controls.Add(Me.BtnFNNLimTxtBx1)
        Me.Controls.Add(Me.TxtBx3)
        Me.Controls.Add(Me.BtnFNNSalir)
        Me.Controls.Add(Me.BtnFNNLimpiar)
        Me.Controls.Add(Me.BtnFNNDescargar)
        Me.Controls.Add(Me.BtnFNNCargar)
        Me.Controls.Add(Me.TxtBx2)
        Me.Controls.Add(Me.TxtBx1)
        Me.Controls.Add(Me.MnStrpFNN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnStrpFNN
        Me.MaximumSize = New System.Drawing.Size(603, 456)
        Me.MinimumSize = New System.Drawing.Size(603, 456)
        Me.Name = "Formularo_Numeros_Naturales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formularo Numeros Naturales"
        Me.MnStrpFNN.ResumeLayout(False)
        Me.MnStrpFNN.PerformLayout()
        CType(Me.PcBxFNNLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnStrpFNN As MenuStrip
    Friend WithEvents INICIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARGARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DESCARGARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRACTICO1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRACTICO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HERRAMIENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtBx1 As TextBox
    Friend WithEvents TxtBx2 As TextBox
    Friend WithEvents BtnFNNCargar As Button
    Friend WithEvents BtnFNNDescargar As Button
    Friend WithEvents BtnFNNLimpiar As Button
    Friend WithEvents BtnFNNSalir As Button
    Friend WithEvents TxtBx3 As TextBox
    Friend WithEvents BtnFNNLimTxtBx1 As Button
    Friend WithEvents BtnFNNLimTxtBx2 As Button
    Friend WithEvents BtnFNNLimTxtBx3 As Button
    Friend WithEvents PcBxFNNLogo As PictureBox
    Friend WithEvents ContarDgitosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitoMayorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitoMenorToolStripMenuItem As ToolStripMenuItem
End Class

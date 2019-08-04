<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_Principal))
        Me.PanelFP = New System.Windows.Forms.Panel()
        Me.BtnFPNaturales = New System.Windows.Forms.Button()
        Me.BtnFPCadenas = New System.Windows.Forms.Button()
        Me.BtnFPVectores = New System.Windows.Forms.Button()
        Me.BtnFPMatrices = New System.Windows.Forms.Button()
        Me.PicBxFPLogo = New System.Windows.Forms.PictureBox()
        Me.PanelFP.SuspendLayout()
        CType(Me.PicBxFPLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFP
        '
        Me.PanelFP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelFP.Controls.Add(Me.BtnFPMatrices)
        Me.PanelFP.Controls.Add(Me.BtnFPVectores)
        Me.PanelFP.Controls.Add(Me.BtnFPCadenas)
        Me.PanelFP.Controls.Add(Me.BtnFPNaturales)
        Me.PanelFP.Location = New System.Drawing.Point(1, 124)
        Me.PanelFP.Name = "PanelFP"
        Me.PanelFP.Size = New System.Drawing.Size(180, 302)
        Me.PanelFP.TabIndex = 1
        '
        'BtnFPNaturales
        '
        Me.BtnFPNaturales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFPNaturales.Location = New System.Drawing.Point(22, 13)
        Me.BtnFPNaturales.Name = "BtnFPNaturales"
        Me.BtnFPNaturales.Size = New System.Drawing.Size(138, 63)
        Me.BtnFPNaturales.TabIndex = 0
        Me.BtnFPNaturales.Text = "Naturales"
        Me.BtnFPNaturales.UseVisualStyleBackColor = True
        '
        'BtnFPCadenas
        '
        Me.BtnFPCadenas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFPCadenas.Location = New System.Drawing.Point(22, 82)
        Me.BtnFPCadenas.Name = "BtnFPCadenas"
        Me.BtnFPCadenas.Size = New System.Drawing.Size(138, 63)
        Me.BtnFPCadenas.TabIndex = 1
        Me.BtnFPCadenas.Text = "Cadenas"
        Me.BtnFPCadenas.UseVisualStyleBackColor = True
        '
        'BtnFPVectores
        '
        Me.BtnFPVectores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFPVectores.Location = New System.Drawing.Point(22, 151)
        Me.BtnFPVectores.Name = "BtnFPVectores"
        Me.BtnFPVectores.Size = New System.Drawing.Size(138, 63)
        Me.BtnFPVectores.TabIndex = 2
        Me.BtnFPVectores.Text = "Vectores"
        Me.BtnFPVectores.UseVisualStyleBackColor = True
        '
        'BtnFPMatrices
        '
        Me.BtnFPMatrices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFPMatrices.Location = New System.Drawing.Point(22, 220)
        Me.BtnFPMatrices.Name = "BtnFPMatrices"
        Me.BtnFPMatrices.Size = New System.Drawing.Size(138, 63)
        Me.BtnFPMatrices.TabIndex = 3
        Me.BtnFPMatrices.Text = "Matrices"
        Me.BtnFPMatrices.UseVisualStyleBackColor = True
        '
        'PicBxFPLogo
        '
        Me.PicBxFPLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicBxFPLogo.Image = Global.Programacion_I_Visual_Basic.My.Resources.Resources.solo_el_logo_transparente
        Me.PicBxFPLogo.Location = New System.Drawing.Point(38, 2)
        Me.PicBxFPLogo.Name = "PicBxFPLogo"
        Me.PicBxFPLogo.Size = New System.Drawing.Size(106, 120)
        Me.PicBxFPLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicBxFPLogo.TabIndex = 2
        Me.PicBxFPLogo.TabStop = False
        '
        'Formulario_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(182, 445)
        Me.Controls.Add(Me.PicBxFPLogo)
        Me.Controls.Add(Me.PanelFP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(198, 484)
        Me.MinimumSize = New System.Drawing.Size(198, 484)
        Me.Name = "Formulario_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Principal"
        Me.PanelFP.ResumeLayout(False)
        CType(Me.PicBxFPLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelFP As Panel
    Friend WithEvents BtnFPMatrices As Button
    Friend WithEvents BtnFPVectores As Button
    Friend WithEvents BtnFPCadenas As Button
    Friend WithEvents BtnFPNaturales As Button
    Friend WithEvents PicBxFPLogo As PictureBox
End Class

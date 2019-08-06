<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Cadena
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_Cadena))
        Me.BtnFCLimTxtBx2 = New System.Windows.Forms.Button()
        Me.BtnFCLimTxtBx1 = New System.Windows.Forms.Button()
        Me.BtnFCSalir = New System.Windows.Forms.Button()
        Me.BtnFCLimpiar = New System.Windows.Forms.Button()
        Me.BtnFCDescargar = New System.Windows.Forms.Button()
        Me.BtnFCCargar = New System.Windows.Forms.Button()
        Me.MnStrpFC = New System.Windows.Forms.MenuStrip()
        Me.INICIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerPalabraiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosicionDeLaPalabraiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerPalabrasMasExtensaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerPalabrasMasCortasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarCaracterEnLaPosicionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertirCadenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntercambiarPalabraiConPalabrajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPalabrasMasExtensaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPalabraMasCortaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPalabraiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarConsonantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcedimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarConsonantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertirLasPalabrasDeUnaCadenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPalabraRepetidaYContinuasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PcBxFCLogo = New System.Windows.Forms.PictureBox()
        Me.TimerFC = New System.Windows.Forms.Timer(Me.components)
        Me.PrgrssBrFC = New System.Windows.Forms.ProgressBar()
        Me.RchTBoxFC1 = New System.Windows.Forms.RichTextBox()
        Me.RchTBoxFC2 = New System.Windows.Forms.RichTextBox()
        Me.RchTBoxFC3 = New System.Windows.Forms.RichTextBox()
        Me.BtnFCLimTxtBx3 = New System.Windows.Forms.Button()
        Me.MnStrpFC.SuspendLayout()
        CType(Me.PcBxFCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFCLimTxtBx2
        '
        Me.BtnFCLimTxtBx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCLimTxtBx2.Location = New System.Drawing.Point(196, 246)
        Me.BtnFCLimTxtBx2.Name = "BtnFCLimTxtBx2"
        Me.BtnFCLimTxtBx2.Size = New System.Drawing.Size(75, 37)
        Me.BtnFCLimTxtBx2.TabIndex = 17
        Me.BtnFCLimTxtBx2.Text = "LIMPIAR"
        Me.BtnFCLimTxtBx2.UseVisualStyleBackColor = True
        '
        'BtnFCLimTxtBx1
        '
        Me.BtnFCLimTxtBx1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCLimTxtBx1.Location = New System.Drawing.Point(196, 170)
        Me.BtnFCLimTxtBx1.Name = "BtnFCLimTxtBx1"
        Me.BtnFCLimTxtBx1.Size = New System.Drawing.Size(75, 38)
        Me.BtnFCLimTxtBx1.TabIndex = 16
        Me.BtnFCLimTxtBx1.Text = "LIMPIAR"
        Me.BtnFCLimTxtBx1.UseVisualStyleBackColor = True
        '
        'BtnFCSalir
        '
        Me.BtnFCSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCSalir.Location = New System.Drawing.Point(45, 347)
        Me.BtnFCSalir.Name = "BtnFCSalir"
        Me.BtnFCSalir.Size = New System.Drawing.Size(110, 53)
        Me.BtnFCSalir.TabIndex = 15
        Me.BtnFCSalir.Text = "SALIR"
        Me.BtnFCSalir.UseVisualStyleBackColor = True
        '
        'BtnFCLimpiar
        '
        Me.BtnFCLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCLimpiar.Location = New System.Drawing.Point(45, 288)
        Me.BtnFCLimpiar.Name = "BtnFCLimpiar"
        Me.BtnFCLimpiar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFCLimpiar.TabIndex = 14
        Me.BtnFCLimpiar.Text = "LIMPIAR"
        Me.BtnFCLimpiar.UseVisualStyleBackColor = True
        '
        'BtnFCDescargar
        '
        Me.BtnFCDescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCDescargar.Location = New System.Drawing.Point(45, 229)
        Me.BtnFCDescargar.Name = "BtnFCDescargar"
        Me.BtnFCDescargar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFCDescargar.TabIndex = 13
        Me.BtnFCDescargar.Text = "DESCARGAR"
        Me.BtnFCDescargar.UseVisualStyleBackColor = True
        '
        'BtnFCCargar
        '
        Me.BtnFCCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCCargar.Location = New System.Drawing.Point(45, 170)
        Me.BtnFCCargar.Name = "BtnFCCargar"
        Me.BtnFCCargar.Size = New System.Drawing.Size(110, 53)
        Me.BtnFCCargar.TabIndex = 12
        Me.BtnFCCargar.Text = "CARGAR"
        Me.BtnFCCargar.UseVisualStyleBackColor = True
        '
        'MnStrpFC
        '
        Me.MnStrpFC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIAToolStripMenuItem, Me.FuncionToolStripMenuItem1, Me.ProcedimientoToolStripMenuItem})
        Me.MnStrpFC.Location = New System.Drawing.Point(0, 0)
        Me.MnStrpFC.Name = "MnStrpFC"
        Me.MnStrpFC.Size = New System.Drawing.Size(588, 24)
        Me.MnStrpFC.TabIndex = 18
        Me.MnStrpFC.Text = "MenuStrip1"
        '
        'INICIAToolStripMenuItem
        '
        Me.INICIAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.DescargarToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.INICIAToolStripMenuItem.Name = "INICIAToolStripMenuItem"
        Me.INICIAToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.INICIAToolStripMenuItem.Text = "INICIA"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FuncionToolStripMenuItem1
        '
        Me.FuncionToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObtenerPalabraiToolStripMenuItem, Me.PosicionDeLaPalabraiToolStripMenuItem, Me.ObtenerPalabrasMasExtensaToolStripMenuItem, Me.ObtenerPalabrasMasCortasToolStripMenuItem, Me.EliminarCaracterEnLaPosicionToolStripMenuItem1, Me.InvertirCadenaToolStripMenuItem, Me.IntercambiarPalabraiConPalabrajToolStripMenuItem, Me.EliminarPalabrasMasExtensaToolStripMenuItem, Me.EliminarPalabraMasCortaToolStripMenuItem, Me.EliminarPalabraiToolStripMenuItem, Me.VerificarConsonantesToolStripMenuItem})
        Me.FuncionToolStripMenuItem1.Name = "FuncionToolStripMenuItem1"
        Me.FuncionToolStripMenuItem1.Size = New System.Drawing.Size(104, 20)
        Me.FuncionToolStripMenuItem1.Text = "HERRAMIENTAS"
        '
        'ObtenerPalabraiToolStripMenuItem
        '
        Me.ObtenerPalabraiToolStripMenuItem.Name = "ObtenerPalabraiToolStripMenuItem"
        Me.ObtenerPalabraiToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ObtenerPalabraiToolStripMenuItem.Text = "Obtener palabra ""i"""
        '
        'PosicionDeLaPalabraiToolStripMenuItem
        '
        Me.PosicionDeLaPalabraiToolStripMenuItem.Name = "PosicionDeLaPalabraiToolStripMenuItem"
        Me.PosicionDeLaPalabraiToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.PosicionDeLaPalabraiToolStripMenuItem.Text = "Posicion de la palabra ""i"""
        '
        'ObtenerPalabrasMasExtensaToolStripMenuItem
        '
        Me.ObtenerPalabrasMasExtensaToolStripMenuItem.Name = "ObtenerPalabrasMasExtensaToolStripMenuItem"
        Me.ObtenerPalabrasMasExtensaToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ObtenerPalabrasMasExtensaToolStripMenuItem.Text = "Obtener palabras mas extensa"
        '
        'ObtenerPalabrasMasCortasToolStripMenuItem
        '
        Me.ObtenerPalabrasMasCortasToolStripMenuItem.Name = "ObtenerPalabrasMasCortasToolStripMenuItem"
        Me.ObtenerPalabrasMasCortasToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ObtenerPalabrasMasCortasToolStripMenuItem.Text = "Obtener palabras mas cortas"
        '
        'EliminarCaracterEnLaPosicionToolStripMenuItem1
        '
        Me.EliminarCaracterEnLaPosicionToolStripMenuItem1.Name = "EliminarCaracterEnLaPosicionToolStripMenuItem1"
        Me.EliminarCaracterEnLaPosicionToolStripMenuItem1.Size = New System.Drawing.Size(280, 22)
        Me.EliminarCaracterEnLaPosicionToolStripMenuItem1.Text = "Eliminar caracter en la posicion"
        '
        'InvertirCadenaToolStripMenuItem
        '
        Me.InvertirCadenaToolStripMenuItem.Name = "InvertirCadenaToolStripMenuItem"
        Me.InvertirCadenaToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.InvertirCadenaToolStripMenuItem.Text = "invertir cadena"
        '
        'IntercambiarPalabraiConPalabrajToolStripMenuItem
        '
        Me.IntercambiarPalabraiConPalabrajToolStripMenuItem.Name = "IntercambiarPalabraiConPalabrajToolStripMenuItem"
        Me.IntercambiarPalabraiConPalabrajToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.IntercambiarPalabraiConPalabrajToolStripMenuItem.Text = "Intercambiar palabra ""i"" con palabra ""j"""
        '
        'EliminarPalabrasMasExtensaToolStripMenuItem
        '
        Me.EliminarPalabrasMasExtensaToolStripMenuItem.Name = "EliminarPalabrasMasExtensaToolStripMenuItem"
        Me.EliminarPalabrasMasExtensaToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.EliminarPalabrasMasExtensaToolStripMenuItem.Text = "Eliminar palabras mas extensa"
        '
        'EliminarPalabraMasCortaToolStripMenuItem
        '
        Me.EliminarPalabraMasCortaToolStripMenuItem.Name = "EliminarPalabraMasCortaToolStripMenuItem"
        Me.EliminarPalabraMasCortaToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.EliminarPalabraMasCortaToolStripMenuItem.Text = "Eliminar palabra mas corta"
        '
        'EliminarPalabraiToolStripMenuItem
        '
        Me.EliminarPalabraiToolStripMenuItem.Name = "EliminarPalabraiToolStripMenuItem"
        Me.EliminarPalabraiToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.EliminarPalabraiToolStripMenuItem.Text = "Eliminar palabra ""i"""
        '
        'VerificarConsonantesToolStripMenuItem
        '
        Me.VerificarConsonantesToolStripMenuItem.Name = "VerificarConsonantesToolStripMenuItem"
        Me.VerificarConsonantesToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.VerificarConsonantesToolStripMenuItem.Text = "Verificar consonantes"
        '
        'ProcedimientoToolStripMenuItem
        '
        Me.ProcedimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContarConsonantesToolStripMenuItem, Me.ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem, Me.VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem, Me.VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem, Me.EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem, Me.ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem, Me.EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem, Me.OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem, Me.IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem, Me.InvertirLasPalabrasDeUnaCadenaToolStripMenuItem, Me.EliminarPalabraRepetidaYContinuasToolStripMenuItem, Me.ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem})
        Me.ProcedimientoToolStripMenuItem.Name = "ProcedimientoToolStripMenuItem"
        Me.ProcedimientoToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ProcedimientoToolStripMenuItem.Text = "PRACTICO"
        '
        'ContarConsonantesToolStripMenuItem
        '
        Me.ContarConsonantesToolStripMenuItem.Name = "ContarConsonantesToolStripMenuItem"
        Me.ContarConsonantesToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.ContarConsonantesToolStripMenuItem.Text = "1. Contar consonantes"
        '
        'ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem
        '
        Me.ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem.Name = "ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem"
        Me.ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem.Text = "2. Contar caracteres diferentes de una funcion"
        '
        'VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem
        '
        Me.VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem.Name = "VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuIt" &
    "em"
        Me.VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem.Text = "3. Verificar si una cadena tiene las 5 vocales, sean estas mayusculas o minuscula" &
    "s"
        '
        'VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem
        '
        Me.VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem.Name = "VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem"
        Me.VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem.Text = "4. Verificar si una cadena tiene mas vocales que consonandes"
        '
        'EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem
        '
        Me.EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem.Name = "EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem"
        Me.EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem.Text = "5. Eliminar los Caracteres repetidos y continuos"
        '
        'ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem
        '
        Me.ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem.Name = "ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem"
        Me.ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem.Text = "6. Contar palabras palindromas de una cadena"
        '
        'EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem
        '
        Me.EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem.Name = "EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem"
        Me.EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem.Text = "7. Eliminar una palabra ""p"" de una cadena"
        '
        'OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem
        '
        Me.OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem.Name = "OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem"
        Me.OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem.Text = "8. Ordenar palabras por numero caracteres diferentes de menor a mayor"
        '
        'IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem
        '
        Me.IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem.Name = "IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMe" &
    "nuItem"
        Me.IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem.Text = "9. Intercalar palabras de a su longitud mas extensa, luego mas corta, ...asi suce" &
    "sivamente"
        '
        'InvertirLasPalabrasDeUnaCadenaToolStripMenuItem
        '
        Me.InvertirLasPalabrasDeUnaCadenaToolStripMenuItem.Name = "InvertirLasPalabrasDeUnaCadenaToolStripMenuItem"
        Me.InvertirLasPalabrasDeUnaCadenaToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.InvertirLasPalabrasDeUnaCadenaToolStripMenuItem.Text = "10. invertir las palabras de una cadena"
        '
        'EliminarPalabraRepetidaYContinuasToolStripMenuItem
        '
        Me.EliminarPalabraRepetidaYContinuasToolStripMenuItem.Name = "EliminarPalabraRepetidaYContinuasToolStripMenuItem"
        Me.EliminarPalabraRepetidaYContinuasToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.EliminarPalabraRepetidaYContinuasToolStripMenuItem.Text = "11. Eliminar palabra repetida y continuas"
        '
        'ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem
        '
        Me.ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem.Name = "ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMen" &
    "uItem"
        Me.ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem.Size = New System.Drawing.Size(539, 22)
        Me.ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem.Text = "12. Contar palabras diferentes de una cadena. Se asume que existen palabras repet" &
    "idas"
        '
        'PcBxFCLogo
        '
        Me.PcBxFCLogo.Image = Global.Programacion_I_Visual_Basic.My.Resources.Resources.logo_y_texto
        Me.PcBxFCLogo.Location = New System.Drawing.Point(2, 36)
        Me.PcBxFCLogo.Name = "PcBxFCLogo"
        Me.PcBxFCLogo.Size = New System.Drawing.Size(582, 112)
        Me.PcBxFCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PcBxFCLogo.TabIndex = 19
        Me.PcBxFCLogo.TabStop = False
        '
        'TimerFC
        '
        '
        'PrgrssBrFC
        '
        Me.PrgrssBrFC.Location = New System.Drawing.Point(0, 420)
        Me.PrgrssBrFC.Name = "PrgrssBrFC"
        Me.PrgrssBrFC.Size = New System.Drawing.Size(587, 40)
        Me.PrgrssBrFC.TabIndex = 20
        '
        'RchTBoxFC1
        '
        Me.RchTBoxFC1.Location = New System.Drawing.Point(277, 170)
        Me.RchTBoxFC1.Name = "RchTBoxFC1"
        Me.RchTBoxFC1.Size = New System.Drawing.Size(273, 53)
        Me.RchTBoxFC1.TabIndex = 22
        Me.RchTBoxFC1.Text = ""
        '
        'RchTBoxFC2
        '
        Me.RchTBoxFC2.Location = New System.Drawing.Point(277, 246)
        Me.RchTBoxFC2.Name = "RchTBoxFC2"
        Me.RchTBoxFC2.Size = New System.Drawing.Size(273, 56)
        Me.RchTBoxFC2.TabIndex = 23
        Me.RchTBoxFC2.Text = ""
        '
        'RchTBoxFC3
        '
        Me.RchTBoxFC3.Location = New System.Drawing.Point(277, 329)
        Me.RchTBoxFC3.Name = "RchTBoxFC3"
        Me.RchTBoxFC3.Size = New System.Drawing.Size(273, 71)
        Me.RchTBoxFC3.TabIndex = 25
        Me.RchTBoxFC3.Text = ""
        '
        'BtnFCLimTxtBx3
        '
        Me.BtnFCLimTxtBx3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFCLimTxtBx3.Location = New System.Drawing.Point(196, 329)
        Me.BtnFCLimTxtBx3.Name = "BtnFCLimTxtBx3"
        Me.BtnFCLimTxtBx3.Size = New System.Drawing.Size(75, 37)
        Me.BtnFCLimTxtBx3.TabIndex = 24
        Me.BtnFCLimTxtBx3.Text = "LIMPIAR"
        Me.BtnFCLimTxtBx3.UseVisualStyleBackColor = True
        '
        'Formulario_Cadena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(588, 458)
        Me.Controls.Add(Me.RchTBoxFC3)
        Me.Controls.Add(Me.BtnFCLimTxtBx3)
        Me.Controls.Add(Me.RchTBoxFC2)
        Me.Controls.Add(Me.RchTBoxFC1)
        Me.Controls.Add(Me.PrgrssBrFC)
        Me.Controls.Add(Me.PcBxFCLogo)
        Me.Controls.Add(Me.BtnFCLimTxtBx2)
        Me.Controls.Add(Me.BtnFCLimTxtBx1)
        Me.Controls.Add(Me.BtnFCSalir)
        Me.Controls.Add(Me.BtnFCLimpiar)
        Me.Controls.Add(Me.BtnFCDescargar)
        Me.Controls.Add(Me.BtnFCCargar)
        Me.Controls.Add(Me.MnStrpFC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnStrpFC
        Me.MaximumSize = New System.Drawing.Size(604, 497)
        Me.MinimumSize = New System.Drawing.Size(604, 497)
        Me.Name = "Formulario_Cadena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Cadena"
        Me.MnStrpFC.ResumeLayout(False)
        Me.MnStrpFC.PerformLayout()
        CType(Me.PcBxFCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFCLimTxtBx2 As Button
    Friend WithEvents BtnFCLimTxtBx1 As Button
    Friend WithEvents BtnFCSalir As Button
    Friend WithEvents BtnFCLimpiar As Button
    Friend WithEvents BtnFCDescargar As Button
    Friend WithEvents BtnFCCargar As Button
    Friend WithEvents MnStrpFC As MenuStrip
    Friend WithEvents INICIAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProcedimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PcBxFCLogo As PictureBox
    Friend WithEvents TimerFC As Timer
    Friend WithEvents PrgrssBrFC As ProgressBar
    Friend WithEvents RchTBoxFC1 As RichTextBox
    Friend WithEvents RchTBoxFC2 As RichTextBox
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObtenerPalabraiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosicionDeLaPalabraiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObtenerPalabrasMasExtensaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObtenerPalabrasMasCortasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarCaracterEnLaPosicionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvertirCadenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntercambiarPalabraiConPalabrajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPalabrasMasExtensaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPalabraMasCortaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPalabraiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarConsonantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarCaracteresDiferentesDeUnaFuncionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarSiUnaCadenaTieneLas5VocalesSeanEstasMayusculasOMinusculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarSiUnaCadenaTieneMasVocalesQueConsonandesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarLosCaracteresRepetidosYContinuosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarPalabrasPalindromasDeUnaCadenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnaPalabrapDeUnaCadenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarPalabrasPorNumeroCaracteresDiferentesDeMenorAMayorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntercalarPalabrasDeASuLongitudMasExtensaLuegoMasCortaasiSucesivamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvertirLasPalabrasDeUnaCadenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPalabraRepetidaYContinuasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarPalabrasDiferentesDeUnaCadenaSeAsumeQueExistenPalabrasRepetidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarConsonantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RchTBoxFC3 As RichTextBox
    Friend WithEvents BtnFCLimTxtBx3 As Button
End Class

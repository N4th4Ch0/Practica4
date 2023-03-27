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
        lbl1 = New Label()
        lbl2 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        cmdSum = New Button()
        cmdResta = New Button()
        cmdMulti = New Button()
        cmdDiv = New Button()
        cmdCerrar = New Button()
        cmdLim = New Button()
        cmdResi = New Button()
        lblResultado = New Label()
        cmdConcatenacion = New Button()
        cmdPotencia = New Button()
        cmdDivreal = New Button()
        cmdBorr5 = New Button()
        cmdBorr1 = New Button()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl1.Location = New Point(115, 54)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(165, 20)
        lbl1.TabIndex = 0
        lbl1.Text = "Introduce el numero 1"' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl2.Location = New Point(115, 117)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(165, 20)
        lbl2.TabIndex = 1
        lbl2.Text = "Introduce el numero 2"' 
        ' txtNum1
        ' 
        txtNum1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtNum1.Location = New Point(115, 77)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(100, 23)
        txtNum1.TabIndex = 2
        ' 
        ' txtNum2
        ' 
        txtNum2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtNum2.Location = New Point(115, 140)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(100, 23)
        txtNum2.TabIndex = 3
        ' 
        ' cmdSum
        ' 
        cmdSum.BackColor = Color.Aquamarine
        cmdSum.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdSum.Location = New Point(303, 51)
        cmdSum.Name = "cmdSum"
        cmdSum.Size = New Size(135, 23)
        cmdSum.TabIndex = 4
        cmdSum.Text = "SUMA"
        cmdSum.UseVisualStyleBackColor = False
        ' 
        ' cmdResta
        ' 
        cmdResta.BackColor = Color.Chocolate
        cmdResta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdResta.Location = New Point(303, 95)
        cmdResta.Name = "cmdResta"
        cmdResta.Size = New Size(135, 23)
        cmdResta.TabIndex = 5
        cmdResta.Text = "RESTA"
        cmdResta.UseVisualStyleBackColor = False
        ' 
        ' cmdMulti
        ' 
        cmdMulti.BackColor = Color.Orange
        cmdMulti.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdMulti.Location = New Point(303, 140)
        cmdMulti.Name = "cmdMulti"
        cmdMulti.Size = New Size(135, 29)
        cmdMulti.TabIndex = 6
        cmdMulti.Text = "MULTIPLICACION"
        cmdMulti.UseVisualStyleBackColor = False
        ' 
        ' cmdDiv
        ' 
        cmdDiv.BackColor = Color.DarkTurquoise
        cmdDiv.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdDiv.Location = New Point(303, 186)
        cmdDiv.Name = "cmdDiv"
        cmdDiv.Size = New Size(135, 23)
        cmdDiv.TabIndex = 7
        cmdDiv.Text = "DIVISION"
        cmdDiv.UseVisualStyleBackColor = False
        ' 
        ' cmdCerrar
        ' 
        cmdCerrar.BackColor = Color.Red
        cmdCerrar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdCerrar.ForeColor = SystemColors.ControlText
        cmdCerrar.Location = New Point(357, 299)
        cmdCerrar.Name = "cmdCerrar"
        cmdCerrar.Size = New Size(81, 44)
        cmdCerrar.TabIndex = 8
        cmdCerrar.Text = "CERRAR"
        cmdCerrar.UseVisualStyleBackColor = False
        ' 
        ' cmdLim
        ' 
        cmdLim.BackColor = Color.Red
        cmdLim.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdLim.ForeColor = SystemColors.ActiveCaptionText
        cmdLim.Location = New Point(12, 12)
        cmdLim.Name = "cmdLim"
        cmdLim.Size = New Size(92, 33)
        cmdLim.TabIndex = 9
        cmdLim.Text = "LIMPIAR"
        cmdLim.UseVisualStyleBackColor = False
        ' 
        ' cmdResi
        ' 
        cmdResi.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdResi.Location = New Point(303, 233)
        cmdResi.Name = "cmdResi"
        cmdResi.Size = New Size(135, 23)
        cmdResi.TabIndex = 10
        cmdResi.Text = "RESIDUO"
        cmdResi.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblResultado.Location = New Point(115, 220)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 25)
        lblResultado.TabIndex = 11
        ' 
        ' cmdConcatenacion
        ' 
        cmdConcatenacion.BackColor = Color.RosyBrown
        cmdConcatenacion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmdConcatenacion.Location = New Point(224, 311)
        cmdConcatenacion.Name = "cmdConcatenacion"
        cmdConcatenacion.Size = New Size(75, 23)
        cmdConcatenacion.TabIndex = 12
        cmdConcatenacion.Text = "Concatenar"
        cmdConcatenacion.UseVisualStyleBackColor = False
        ' 
        ' cmdPotencia
        ' 
        cmdPotencia.BackColor = Color.PeachPuff
        cmdPotencia.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmdPotencia.Location = New Point(128, 311)
        cmdPotencia.Name = "cmdPotencia"
        cmdPotencia.Size = New Size(75, 23)
        cmdPotencia.TabIndex = 13
        cmdPotencia.Text = "Potencia"
        cmdPotencia.UseVisualStyleBackColor = False
        ' 
        ' cmdDivreal
        ' 
        cmdDivreal.BackColor = SystemColors.InactiveCaption
        cmdDivreal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmdDivreal.Location = New Point(40, 311)
        cmdDivreal.Name = "cmdDivreal"
        cmdDivreal.Size = New Size(75, 23)
        cmdDivreal.TabIndex = 14
        cmdDivreal.Text = "Div Real"
        cmdDivreal.UseVisualStyleBackColor = False
        ' 
        ' cmdBorr5
        ' 
        cmdBorr5.BackColor = Color.Red
        cmdBorr5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdBorr5.ForeColor = SystemColors.ActiveCaptionText
        cmdBorr5.Location = New Point(12, 133)
        cmdBorr5.Name = "cmdBorr5"
        cmdBorr5.Size = New Size(92, 33)
        cmdBorr5.TabIndex = 15
        cmdBorr5.Text = "Borrar"
        cmdBorr5.UseVisualStyleBackColor = False
        ' 
        ' cmdBorr1
        ' 
        cmdBorr1.BackColor = Color.Red
        cmdBorr1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdBorr1.ForeColor = SystemColors.ActiveCaptionText
        cmdBorr1.Location = New Point(12, 70)
        cmdBorr1.Name = "cmdBorr1"
        cmdBorr1.Size = New Size(92, 33)
        cmdBorr1.TabIndex = 16
        cmdBorr1.Text = "Borrar"
        cmdBorr1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(456, 355)
        Controls.Add(cmdBorr1)
        Controls.Add(cmdBorr5)
        Controls.Add(cmdDivreal)
        Controls.Add(cmdPotencia)
        Controls.Add(cmdConcatenacion)
        Controls.Add(lblResultado)
        Controls.Add(cmdResi)
        Controls.Add(cmdLim)
        Controls.Add(cmdCerrar)
        Controls.Add(cmdDiv)
        Controls.Add(cmdMulti)
        Controls.Add(cmdResta)
        Controls.Add(cmdSum)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents cmdSum As Button
    Friend WithEvents cmdResta As Button
    Friend WithEvents cmdMulti As Button
    Friend WithEvents cmdDiv As Button
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdLim As Button
    Friend WithEvents cmdResi As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents cmdConcatenacion As Button
    Friend WithEvents cmdPotencia As Button
    Friend WithEvents cmdDivreal As Button
    Friend WithEvents cmdBorr5 As Button
    Friend WithEvents cmdBorr1 As Button
End Class

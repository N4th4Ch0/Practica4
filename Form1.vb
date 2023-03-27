Public Class Form1
    Dim resultado As Decimal
    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click

        Me.Close()
        'End tambien para cerrar

    End Sub

    Private Sub cmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 + num2

        lblResultado.Text = Math.Round(resultado, 2)

    End Sub

    Private Sub cmdResta_Click(sender As Object, e As EventArgs) Handles cmdResta.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 - num2

        lblResultado.Text = Math.Round(resultado, 2)

    End Sub

    Private Sub cmdMulti_Click(sender As Object, e As EventArgs) Handles cmdMulti.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 * num2

        lblResultado.Text = Math.Round(resultado, 2)

    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 / num2

        lblResultado.Text = Math.Round(resultado, 2)

    End Sub

    Private Sub cmdLim_Click(sender As Object, e As EventArgs) Handles cmdLim.Click

        txtNum1.Text = " "
        txtNum2.Text = " "
        lblResultado.Text = " "
        txtNum1.Focus()
        txtNum2.Focus()

    End Sub

    Private Sub cmdResi_Click(sender As Object, e As EventArgs) Handles cmdResi.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 Mod num2

        lblResultado.Text = Math.Round(resultado, 2)

    End Sub

    Private Sub cmdConcatenacion_Click(sender As Object, e As EventArgs) Handles cmdConcatenacion.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 & num2

        lblResultado.Text = Math.Round(resultado, 2)
    End Sub

    Private Sub cmdPotencia_Click(sender As Object, e As EventArgs) Handles cmdPotencia.Click

        Dim num1, num2 As Decimal



        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 ^ num2

        lblResultado.Text = Math.Round(resultado, 2)
    End Sub

    Private Sub cmdDivreal_Click(sender As Object, e As EventArgs) Handles cmdDivreal.Click

        Dim num1, num2 As Decimal

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        resultado = num1 \ num2

        lblResultado.Text = Math.Round(resultado, 2)
    End Sub

    Private Sub cmdBorr1_Click(sender As Object, e As EventArgs) Handles cmdBorr1.Click

        'para cambiar solo un numero 1 
        txtNum1.Text = " "
        txtNum1.Focus()

    End Sub

    Private Sub cmdBorr5_Click(sender As Object, e As EventArgs) Handles cmdBorr5.Click

        'Para cambiar solo ese numero 2
        txtNum2.Text = " "
        txtNum2.Focus()

    End Sub
End Class

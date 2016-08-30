Public Class Calculadora

    Dim resultado As Double
    Dim op1 As Double
    Dim op2 As Double
    Dim ope As Double


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtresu.Text = txtresu.Text & “7”
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btn4.Click
        txtresu.Text = txtresu.Text & “4”
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        op2 = Val(txtresu.Text)
        Select Case ope
            Case 1
                resultado = op1 + op2
            Case 2
                resultado = op1 - op2
            Case 3
                resultado = op1 * op2
            Case 4
                If (op2 = 0) Then

                    MsgBox("No se puede dividir entre 0")
                Else
                    resultado = op1 / op2
                End If

            Case 5
                resultado = Math.Sqrt(op1)
        End Select
        txtresu.Text = resultado
        ope = 0

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtresu.Text = txtresu.Text & “8”
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtresu.Text = txtresu.Text & “9”
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click


        ope = 1
        op1 = Val(txtresu.Text)

        txtresu.Text = ""
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        ope = 5

        op1 = Val(txtresu.Text)
        txtresu.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        ope = 2
        op1 = Val(txtresu.Text)
        txtresu.Text = ""
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtresu.Text = txtresu.Text & “6”
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtresu.Text = txtresu.Text & “5”
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtresu.Text = txtresu.Text & “1”
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtresu.Text = txtresu.Text & “2”
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtresu.Text = txtresu.Text & “3”
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        ope = 3
        op1 = Val(txtresu.Text)
        txtresu.Text = ""
    End Sub

    Private Sub btndivi_Click(sender As Object, e As EventArgs) Handles btndivi.Click
        ope = 4
        op1 = Val(txtresu.Text)
        txtresu.Text = ""
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtresu.Text = txtresu.Text & “0”
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtresu.Text = ""



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtresu_TextChanged(sender As Object, e As EventArgs) Handles txtresu.TextChanged

    End Sub

    Private Sub txtresu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtresu.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

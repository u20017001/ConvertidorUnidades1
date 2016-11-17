Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_2(sender As Object, e As EventArgs) Handles lblum.Click

    End Sub

    Private Sub cmdconvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconvertir.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 0.0393701
            lblum.Text = "inch"

        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 10
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 100
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 100000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 0.393701
            lblum.Text = "inch"

        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 39.3701
            lblum.Text = "inch"

        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000000
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100000
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text) * 39370.1
            lblum.Text = "inch"

        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 25.4001
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 2.54001
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 0.0254001
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) * 0.0000254001
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Pulgadas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "inch"
        End If
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        lblr.Text = ""
        lblum.Text = ""
        txtvalor.Text = ""
    End Sub
End Class

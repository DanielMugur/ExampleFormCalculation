Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim iNum1 As Integer
        Dim iNum2 As Integer
        Dim iNum3 As Integer
        Dim iSum As Integer
        Dim dblAvg As Double

        iNum1 = CInt(txtNumber1.Text)
        iNum2 = CInt(txtNumber2.Text)
        iNum3 = CInt(txtNumber3.Text)

        'Doing the sum
        iSum = iNum1 + iNum2 + iNum3

        'Doing the avg
        dblAvg = iSum / 3


        txtSummation.Text = iSum
        txtAverage.Text = Math.Round(dblAvg, 3)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtNumber1.Clear()
        txtNumber2.Clear()
        txtNumber3.Clear()
        txtSummation.Clear()
        txtAverage.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class
Public Class formJasutajaAken
    Private Sub btnPoora1_Click(sender As Object, ByVal e As System.EventArgs) Handles btnPoora1.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon'
        Dim pooraja As PrjTekstiPoorja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile'
        pooraja = New PrjTekstiPoorja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub btnPoora2_Click(sender As Object, ByVal e As System.EventArgs) Handles btnPoora2.Click

        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon'
        Dim pooraja As PrjTekstiPoorja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile'
        pooraja = New PrjTekstiPoorja.CTekstiPooraja
        pooraja.teisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = pooraja.strTekst
    End Sub

    Private Sub btnStart_Click(sender As Object, ByVal e As EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True
        btnStart.Enabled = False

    End Sub

    Private Sub timerUuenda_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerUuenda.Tick
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon'
        Dim pooraja As PrjTekstiPoorja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile'
        pooraja = New PrjTekstiPoorja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True

    End Sub

    Private Sub timerPikkus_Tick(ByVal sender As Object, e As EventArgs) Handles timerPikkus.Tick
        txtPikkus.Text = Len(txtSisendTekst.Text)

        Dim inputString As String
        Dim intCount As Integer = 0
        Const vowels As String = "aeiou"
        inputString = txtSisendTekst.Text

        For Each letter As Char In inputString
            If vowels.IndexOf(letter) <> -1 Then intCount += 1

        Next
        tsArv.Text = intCount.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValjundTekst1.Text = ""
        txtValjundTekst2.Text = ""
        txtSisendTekst.Text = ""
    End Sub
End Class

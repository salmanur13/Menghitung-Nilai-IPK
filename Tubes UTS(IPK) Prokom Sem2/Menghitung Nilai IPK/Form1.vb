Public Class Form1
    Dim matkul1, matkul2, matkul3, matkul4, matkul5, matkul6 As Double
    Dim sks1, sks2, sks3, sks4, sks5, sks6 As Integer
    Dim NA1, NA2, NA3, NA4, NA5, NA6 As String
    Dim NilaiMK As String
    Dim Text As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        matkul1 = TxtMatkul1.Text
        If matkul1 >= "80" And matkul1 <= "100" Then
            NA1 = "4"

        ElseIf matkul1 >= "75" And matkul1 <= "79,99" Then
            NA1 = "3,5"

        ElseIf matkul1 >= "70" And matkul1 <= "74,99" Then
            NA1 = "3"

        ElseIf matkul1 >= "65" And matkul1 <= "69,99" Then
            NA1 = "2,5"

        ElseIf matkul1 >= "60" And matkul1 <= "64,99" Then
            NA1 = "2"

        ElseIf matkul1 >= "56" And matkul1 <= "59,99" Then
            NA1 = "1,5"

        ElseIf matkul1 >= "46" And matkul1 <= "55,99" Then
            NA1 = "1"

        ElseIf matkul1 >= "0" And matkul1 <= "45,99" Then
            NA1 = "0"
        End If

        matkul2 = TxtMatkul2.Text
        If matkul2 >= "80" And matkul2 <= "100" Then
            NA2 = "4"

        ElseIf matkul2 >= "75" And matkul2 <= "79,99" Then
            NA2 = "3,5"

        ElseIf matkul2 >= "70" And matkul2 <= "74,99" Then
            NA2 = "3"

        ElseIf matkul2 >= "65" And matkul2 <= "69,99" Then
            NA2 = "2,5"

        ElseIf matkul2 >= "60" And matkul2 <= "64,99" Then
            NA2 = "2"

        ElseIf matkul2 >= "56" And matkul2 <= "59,99" Then
            NA2 = "1,5"

        ElseIf matkul2 >= "46" And matkul2 <= "55,99" Then
            NA2 = "1"

        ElseIf matkul2 >= "0" And matkul2 <= "45,99" Then
            NA2 = "0"

        End If

        matkul3 = TxtMatkul3.Text
        If matkul3 >= "80" Then
            NA3 = "4"

        ElseIf matkul3 >= "75" And matkul3 <= "79,99" Then
            NA3 = "3,5"

        ElseIf matkul3 >= "70" And matkul3 <= "74,99" Then
            NA3 = "3"

        ElseIf matkul3 >= "65" And matkul3 <= "69,99" Then
            NA3 = "2,5"

        ElseIf matkul3 >= "60" And matkul3 <= "64,99" Then
            NA3 = "2"

        ElseIf matkul3 >= "56" And matkul3 <= "59,99" Then
            NA3 = "1,5"

        ElseIf matkul3 >= "46" And matkul3 <= "55,99" Then
            NA3 = "1"

        ElseIf matkul3 >= "0" And matkul3 <= "45,99" Then
            NA3 = "0"

        End If

        matkul4 = TxtMatkul4.Text
        If matkul4 >= "80" Then
            NA4 = "4"

        ElseIf matkul4 >= "75" And matkul4 <= "79,99" Then
            NA4 = "3,5"

        ElseIf matkul4 >= "70" And matkul4 <= "74,99" Then
            NA4 = "3"

        ElseIf matkul4 >= "65" And matkul4 <= "69,99" Then
            NA4 = "2,5"

        ElseIf matkul4 >= "60" And matkul4 <= "64,99" Then
            NA4 = "2"

        ElseIf matkul4 >= "56" And matkul4 <= "59,99" Then
            NA4 = "1,5"

        ElseIf matkul4 >= "46" And matkul4 <= "55,99" Then
            NA4 = "1"

        ElseIf matkul4 >= "0" And matkul4 <= "45,99" Then
            NA4 = "0"

        End If

        matkul5 = TxtMatkul5.Text
        If matkul5 >= "80" Then
            NA5 = "4"

        ElseIf matkul5 >= "75" And matkul5 <= "79,99" Then
            NA5 = "3,5"

        ElseIf matkul5 >= "70" And matkul5 <= "74,99" Then
            NA5 = "3"

        ElseIf matkul5 >= "65" And matkul5 <= "69,99" Then
            NA5 = "2,5"

        ElseIf matkul5 >= "60" And matkul5 <= "64,99" Then
            NA5 = "2"

        ElseIf matkul5 >= "56" And matkul5 <= "59,99" Then
            NA5 = "1,5"

        ElseIf matkul5 >= "46" And matkul5 <= "55,99" Then
            NA5 = "1"

        ElseIf matkul5 >= "0" And matkul5 <= "45,99" Then
            NA5 = "0"


        End If

        matkul6 = TxtMatkul6.Text
        If matkul6 >= "80" Then
            NA6 = "4"

        ElseIf matkul6 >= "75" And matkul6 <= "79,99" Then
            NA6 = "3,5"

        ElseIf matkul6 >= "70" And matkul6 <= "74,99" Then
            NA6 = "3"

        ElseIf matkul6 >= "65" And matkul6 <= "69,99" Then
            NA6 = "2,5"

        ElseIf matkul6 >= "60" And matkul6 <= "64,99" Then
            NA6 = "2"

        ElseIf matkul6 >= "56" And matkul6 <= "59,99" Then
            NA6 = "1,5"

        ElseIf matkul6 >= "46" And matkul6 <= "55,99" Then
            NA6 = "1"

        ElseIf matkul6 >= "0" And matkul6 <= "45,99" Then
            NA6 = "0"

        End If

        sks1 = Txtsks1.Text
        sks2 = Txtsks2.Text
        sks3 = Txtsks3.Text
        sks4 = Txtsks4.Text
        sks5 = Txtsks5.Text
        sks6 = Txtsks6.Text

        NilaiMK = (NA1 * sks1) + (NA2 * sks2) + (NA3 * sks3) + (NA4 * sks4) + (NA5 * sks5) + (NA6 * sks6)
        TxtIP.Text = NilaiMK / (sks1 + sks2 + sks3 + sks4 + sks5 + sks6)

        Text = TxtIP.Text
        If Text >= 3.5 Then
            txtSelamat.Text = "Yeyy Selamat"
            txtCumlaude.Text = "Anda Cumlaude"
        ElseIf TxtIP.Text >= 3 And TxtIP.Text <= 3.49 Then
            txtSelamat.Text = "Selamat"
            txtCumlaude.Text = "Anda luar Biasa "
        ElseIf TxtIP.Text >= 2 And TxtIP.Text <= 2.99 Then
            txtSelamat.Text = "Semangat!"
            txtCumlaude.Text = "Masih Ada Waktu Untuk Perbaiki"
        ElseIf TxtIP.Text >= 1 And TxtIP.Text <= 1.99 Then
            txtSelamat.Text = "Semangat!"
            txtCumlaude.Text = "JANGAN PANTANG MENYERAH"
        ElseIf TxtIP.Text >= 0 And TxtIP.Text <= 0.99 Then
            txtSelamat.Text = "Semangat!"
            txtCumlaude.Text = "INI NILAI ANDA SUDAH MENGKHAWATIRKAN MASA DEPAN"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Fisika Dasar 1: " & NA1 & Environment.NewLine & "Kimia: " & NA2 & Environment.NewLine &
                         "Kalkulus : " & NA3 & Environment.NewLine & "Pengantar Teknik Industri : " & NA4 & Environment.NewLine & "Menggambar Teknik: " & NA5 & Environment.NewLine &
                         "Pancasila : " & NA6 & Environment.NewLine & Environment.NewLine & "Total IP Semester: " & TxtIP.Text & Environment.NewLine &
                         Environment.NewLine & Environment.NewLine & txtSelamat.Text & Environment.NewLine & txtCumlaude.Text, "Nilai IP Semester")


    End Sub
End Class

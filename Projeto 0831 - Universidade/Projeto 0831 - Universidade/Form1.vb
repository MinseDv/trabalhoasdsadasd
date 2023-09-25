Public Class Form1
    Dim ms, valorbolsa, desconto, pagamento, idade
    Dim dn As Date
    Dim idade As Integer

    Private Property Pen As String

    Private Sub cboarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboarea.SelectedIndexChanged
        Dim num As Integer
        For num = 1 To 10

        Next
        cboarea.Items.Add("Humanas")
        cboarea.Items.Add("Exatas")
        cboarea.Items.Add("Biológicas")

        Dim Valorbolsa As Integer
        For Valorbolsa = 10 To 100 Step 10
        Next
    End Sub


    Private Sub mskdatanasc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskdatanasc.LostFocus
        If Not IsDate(mskdatanasc.Text) Then
            MsgBox("Data Inválida!!!", vbCritical, "Erro")
            mskdatanasc.Text = ""
            mskdatanasc.Mask = "##/##/####"
            mskdatanasc.Focus()
            Exit Sub
        Else


            dn = mskdatanasc.Text
            dn = mskdatanasc.Text
            idade = DateDiff("yyyy", dn, Today)
            lblidade.Text = idade
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbocid.Items.Add("Orlândia")
        cbocid.Items.Add("Sales Oliveira")
        cbocid.Items.Add("Franca")
        cbocid.Items.Add("Ribeirão Preto")
        cbocid.Items.Add("Nuporanga")



        cbodurac.Items.Add("1")
        cbodurac.Items.Add("2")
        cbodurac.Items.Add("3")
        cbodurac.Items.Add("4")
        cbodurac.Items.Add("5")
        cbodurac.Items.Add("6")
        cbodurac.Items.Add("7")
        cbodurac.Items.Add("8")
        cbodurac.Items.Add("9")
        cbodurac.Items.Add("10")


        cbobolsa.Items.Add("10%")
        cbobolsa.Items.Add("20%")
        cbobolsa.Items.Add("30%")
        cbobolsa.Items.Add("40%")
        cbobolsa.Items.Add("50%")
        cbobolsa.Items.Add("60%")
        cbobolsa.Items.Add("70%")
        cbobolsa.Items.Add("80%")
        cbobolsa.Items.Add("90%")
        cbobolsa.Items.Add("100%")



        cboarea.Items.Add("Ciências Exatas")
        cboarea.Items.Add("Ciências(Biológicas)")
        cboarea.Items.Add("Engenharias")
        cboarea.Items.Add("Ciências da Saúde")
        




        cbonc.Items.Add("Matemática")
        cbonc.Items.Add("Química")
        cbonc.Items.Add("Física")


        cbonc.Items.Add("Biologia")

        cbonc.Items.Add("Engenharia Civil")
        cbonc.Items.Add("Engenharia Elétrica")
        cbonc.Items.Add("Engenharia Mecânica")
        cbonc.Items.Add("Educação Física")
        cbonc.Items.Add("Enfermagem")
        cbonc.Items.Add("Medicina")
    End Sub

    Private Sub cbonc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbonc.SelectedIndexChanged
        Dim ms, valorbolsa, desconto, pagamento, idade As Double


        If cbonc.Text = "Matemática" Then
            cboarea.Text = "Ciências Exatas e da Terra"
            ms = 800
        End If



        If cbonc.Text = "Química" Then
            cboarea.Text = "Ciências Exatas e da Terra"
            ms = 900
        End If

        If cbonc.Text = "Física" Then
            cboarea.Text = "Ciências Exatas"
            ms = 1000

        End If


        If cbonc.Text = "Biologia" Then
            cboarea.Text = "Ciências(Biológicas)"
            ms = 1100
        End If

        If cbonc.Text = "Engenharia Civil" Then
            cboarea.Text = "Engenharias"
            ms = 1200
        End If

        If cbonc.Text = "Engenharia Elétrica" Then
            cboarea.Text = "Engenharias"
            ms = 1300
        End If

        If cbonc.Text = "Engenharia Mecânica" Then
            cboarea.Text = "Engenharias"
            ms = 1400
        End If


      
        cbonc.Items.Add("Educação Física")
        cbonc.Items.Add("Enfermagem")
        cbonc.Items.Add("Medicina")

        If cbonc.Text = "Educação Física" Then
            cboarea.Text = "Ciências da Saúde"
            ms = 1500
        End If

        If cbonc.Text = "Enfermagem" Then
            cboarea.Text = "Ciências da Saúde"
            ms = 1600
        End If

        If cbonc.Text = "Medicina" Then
            cboarea.Text = "Ciências da Saúde"
            ms = 1700
        End If
        lblms.Text = MS
        lblms.Text = FormatCurrency(ms)
    End Sub

    Private Sub cbobolsa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobolsa.SelectedIndexChanged
        bolsa()

        If cbobolsa.Text = "Medicina" Then
            MS = 1700

        ElseIf cbobolsa.Text = "Enfermagem" Then
            MS = 1600

        ElseIf cbobolsa.Text = "Educação Física" Then
            MS = 1500

        ElseIf cbobolsa.Text = "Engenharia Mecânica" Then
            MS = 1400

        ElseIf cbobolsa.Text = "Engenharia Elétrica" Then
            MS = 1300

        ElseIf cbobolsa.Text = "Engenharia Civil" Then
            MS = 1200

        ElseIf cbobolsa.Text = "Biologia" Then
            MS = 1100

        ElseIf cbobolsa.Text = "Física" Then
            MS = 1000

        ElseIf cbobolsa.Text = "Química" Then
            MS = 900

        ElseIf cbobolsa.Text = "Matemática" Then

            ms = 800

        End If

        lblvalor.Text = FormatCurrency(lblms)
    End Sub



    Function valorbolsa()
        cbobolsa = pagamento / 100 * desc()
        lblvalor.Text = FormatCurrency(valorbolsa)

        If cbobolsa.Text = "10" Then
            valorbolsa = ms * 0.1
        ElseIf cbobolsa.Text = "20" Then
            valorbolsa = ms * 0.2
        ElseIf cbobolsa.Text = "30" Then
            valorbolsa = ms * 0.3
        ElseIf cbobolsa.Text = "40" Then
            valorbolsa = ms * 0.4
        ElseIf cbobolsa.Text = "50" Then
            valorbolsa = ms * 0.5
        ElseIf cbobolsa.Text = "60" Then
            valorbolsa = ms * 0.6
        ElseIf cbobolsa.Text = "70" Then
            valorbolsa = ms * 0.7
        ElseIf cbobolsa.Text = "80" Then
            valorbolsa = ms * 0.8
        ElseIf cbobolsa.Text = "90" Then
            valorbolsa = ms * 0.9
        ElseIf cbobolsa.Text = "100" Then
            valorbolsa = ms * 1.0
        End If
        lblvalor.Text = valorbolsa
        lblvalor.Text = FormatCurrency(valorbolsa)

        pagamento = ms - valorbolsa - desconto
        lblpagm.Text = pagamento
        lblpagm.Text = FormatCurrency(pagamento)

    End Function
    Function desc()
        If idade > 40 And Pen = "5" Then
            desconto = ms * 10 / 100
        ElseIf idade > 40 And "A" Then
            desconto = ms * 15 / 100
        Else
            desconto = 0
        End If
        Return (vbNull)
    End Function

    Function bolsa()
        lblvalor = lblms
        lbldesct = valorbolsa.Text
        lbldesct = lblms * lbldesct / 100
    End Function

    Function pag()
        pag = valordesconto() - desc()

End Class

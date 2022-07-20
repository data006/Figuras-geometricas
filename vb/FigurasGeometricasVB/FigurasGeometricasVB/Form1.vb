Public Class frmFigurasGeometricas

    'Triangulo
    Private Sub btnCalcularTriangulo_Click(sender As Object, e As EventArgs) Handles btnCalcularTriangulo.Click

        Dim area, perimetro, base, altura, ladoUno, ladoDos, ladoTres As Single

        If chkPeriTriangulo.Checked Then

            ladoUno = Val(InputBox("Ingrese el lado uno (base): ", "Lado uno (base)"))
            ladoDos = Val(InputBox("Ingrese el lado dos: ", "Lado dos"))
            ladoTres = Val(InputBox("Ingrese el lado tres: ", "Lado tres"))

            If ladoUno <= 0 Or ladoDos <= 0 Or ladoTres <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = ladoUno + ladoDos + ladoTres

                MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

            End If

        If chkAreaTriangulo.Checked And chkPeriTriangulo.Checked = False Then

            base = Val(InputBox("Ingrese la base: ", "Base"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If base <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (base * altura) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaTriangulo.Checked And chkPeriTriangulo.Checked = True Then

            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (ladoUno * altura) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If



    End Sub





    'Cuadrado
    Private Sub btnCalcularCuadrado_Click(sender As Object, e As EventArgs) Handles btnCalcularCuadrado.Click

        Dim area, perimetro, lado, altura, ladoUno, ladoDos, ladoTres As Single

        If chkPeriCuadrado.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaCuadrado.Checked And chkPeriCuadrado.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (lado * lado)

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaCuadrado.Checked And chkPeriCuadrado.Checked = True Then

            area = (lado * lado)

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If
    End Sub











    'Rectangulo
    Private Sub btnCalcularRectangulo_Click(sender As Object, e As EventArgs) Handles btnCalcularRectangulo.Click

        Dim area, perimetro, lado, altura, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriRectangulo.Checked Then

            base = Val(InputBox("Ingrese la base: ", "Base"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If base <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = (altura * 2) + (base * 2)

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaRectangulo.Checked And chkPeriRectangulo.Checked = False Then

            base = Val(InputBox("Ingrese la base: ", "Base"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If base <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (base * altura)

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaRectangulo.Checked And chkPeriRectangulo.Checked = True Then

            area = (base * altura)

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub












    'Octagono
    Private Sub btnCalcularOctagono_Click(sender As Object, e As EventArgs) Handles btnCalcularOctagono.Click

        Dim area, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriOctagono.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado + lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaOctagono.Checked And chkPeriOctagono.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))
            perimetro = lado + lado + lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If lado <= 0 Or apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaOctagono.Checked And chkPeriOctagono.Checked = True Then

            perimetro = lado + lado + lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub






    'Circulo
    Private Sub btnCalcularCirculo_Click(sender As Object, e As EventArgs) Handles btnCalcularCirculo.Click

        Dim area, radio, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriCirculo.Checked Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))

            If radio <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = 2 * radio * 3.141592

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaCirculo.Checked And chkPeriCirculo.Checked = False Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))

            If radio <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (radio ^ 2) * (3.141592)



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaCirculo.Checked And chkPeriCirculo.Checked = True Then

            area = (radio ^ 2) * (3.141592)



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub





    'Rombo
    Private Sub btnCalcularRombo_Click(sender As Object, e As EventArgs) Handles btnCalcularRombo.Click

        Dim area, diagonalMayor, diagonalMenor, radio, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriRombo.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaRombo.Checked And chkPeriRombo.Checked = False Then

            diagonalMenor = Val(InputBox("Ingrese la diagonal menor: ", "Diagonal Menor"))
            diagonalMayor = Val(InputBox("Ingrese la diagonal mayor: ", "Diagonal Mayor"))

            If diagonalMayor <= 0 Or diagonalMenor <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = ((diagonalMayor) * (diagonalMenor)) / 2



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaRombo.Checked And chkPeriRombo.Checked = True Then

            diagonalMenor = Val(InputBox("Ingrese la diagonal menor: ", "Diagonal Menor"))
            diagonalMayor = Val(InputBox("Ingrese la diagonal mayor: ", "Diagonal Mayor"))

            If diagonalMenor <= 0 Or diagonalMayor <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = ((diagonalMayor) * (diagonalMenor)) / 2



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub







    'Trapecio
    Private Sub btnCalcularTrapecio_Click(sender As Object, e As EventArgs) Handles btnCalcularTrapecio.Click

        Dim area, diagonalMayor, baseMayor, baseMenor, diagonalUno, diagonalDos, diagonalMenor, radio, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriTrapecio.Checked Then

            baseMayor = Val(InputBox("Ingrese la base mayor: ", "Base mayor"))
            baseMenor = Val(InputBox("Ingrese la base menor: ", "Base menor"))
            diagonalUno = Val(InputBox("Ingrese una diagonal: ", "Diagonal uno"))
            diagonalDos = Val(InputBox("Ingrese la otra diagonal: ", "Diagonal dos"))

            If baseMayor <= 0 Or baseMenor <= 0 Or diagonalUno <= 0 Or diagonalDos <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = baseMayor + baseMenor + diagonalUno + diagonalDos

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaTrapecio.Checked And chkPeriTrapecio.Checked = False Then

            baseMayor = Val(InputBox("Ingrese la base mayor: ", "Base mayor"))
            baseMenor = Val(InputBox("Ingrese la base menor: ", "Base menor"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If baseMenor <= 0 Or baseMayor <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = ((baseMayor + baseMenor) * altura) / 2



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaTrapecio.Checked And chkPeriTrapecio.Checked = True Then

            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = ((baseMayor + baseMenor) * altura) / 2



            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub







    'Pentagono
    Private Sub btnCalcularPentagono_Click(sender As Object, e As EventArgs) Handles btnCalcularPentagono.Click

        Dim area, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriPentagono.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaPentagono.Checked And chkPeriPentagono.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))
            perimetro = lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If lado <= 0 Or apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaPentagono.Checked And chkPeriPentagono.Checked = True Then

            perimetro = lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub








    'Hexagono
    Private Sub btnCalcularHexagono_Click(sender As Object, e As EventArgs) Handles btnCalcularHexagono.Click

        Dim area, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriHexagono.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaHexagono.Checked And chkPeriHexagono.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))
            perimetro = lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If lado <= 0 Or apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaHexagono.Checked And chkPeriHexagono.Checked = True Then

            perimetro = lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub






    'Heptagono
    Private Sub btnCalcularHeptagono_Click(sender As Object, e As EventArgs) Handles btnCalcularHeptagono.Click

        Dim area, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkPeriHeptagono.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado + lado + lado + lado

            MsgBox("Perimetro: " & perimetro, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkAreaHexagono.Checked And chkPeriHeptagono.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))
            perimetro = lado + lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If lado <= 0 Or apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkAreaHexagono.Checked And chkPeriHeptagono.Checked = True Then

            perimetro = lado + lado + lado + lado + lado + lado + lado

            apotema = Val(InputBox("Ingrese el apotema: ", "Apotema"))

            If apotema <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (perimetro * apotema) / 2

            MsgBox("Area: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

    End Sub




    '//////////////////////////////////////////////////
    'FIGURAS 3D




    'Cubo
    Private Sub btnCalcularCubo_Click(sender As Object, e As EventArgs) Handles btnCalcularCubo.Click

        Dim area, perimetro, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTCubo.Checked Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = 6 * (lado ^ 2)

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolCubo.Checked And chkAreaTCubo.Checked = False Then

            lado = Val(InputBox("Ingrese un lado: ", "Lado"))

            If lado <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = lado ^ 3

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolCubo.Checked And chkAreaTCubo.Checked = True Then


            volumen = lado ^ 3

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub






    'Paralelepipedo
    Private Sub btnCalcularParalelepipedo_Click(sender As Object, e As EventArgs) Handles btnCalcularParalelepipedo.Click

        Dim area, perimetro, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTParalelepipedo.Checked Then

            ladoUno = Val(InputBox("Ingrese el lado A: ", "Lado A"))
            ladoDos = Val(InputBox("Ingrese el lado B: ", "Lado B"))
            ladoTres = Val(InputBox("Ingrese el lado C: ", "Lado C"))

            If ladoUno <= 0 Or ladoDos <= 0 Or ladoTres <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = (2 * (ladoUno * ladoDos)) + (2 * (ladoUno * ladoTres)) + (2 * (ladoDos * ladoTres))

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolParalelepipedo.Checked And chkAreaTParalelepipedo.Checked = False Then

            ladoUno = Val(InputBox("Ingrese el lado A: ", "Lado A"))
            ladoDos = Val(InputBox("Ingrese el lado B: ", "Lado B"))
            ladoTres = Val(InputBox("Ingrese el lado C: ", "Lado C"))

            If ladoUno <= 0 Or ladoDos <= 0 Or ladoTres <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = ladoUno * ladoDos * ladoTres

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolParalelepipedo.Checked And chkAreaTParalelepipedo.Checked = True Then


            volumen = ladoUno * ladoDos * ladoTres

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub







    'Esfera
    Private Sub btnCalcularEsfera_Click(sender As Object, e As EventArgs) Handles btnCalcularEsfera.Click

        Dim area, perimetro, radio, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTEsfera.Checked Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))

            If radio <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = 4 * (3.141592) * (radio ^ 2)

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolEsfera.Checked And chkAreaTEsfera.Checked = False Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))

            If radio <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = (4 / 3) * (3.141592) * (radio ^ 3)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolEsfera.Checked And chkAreaTEsfera.Checked = True Then


            volumen = (4 / 3) * (3.141592) * (radio ^ 3)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub








    'Cono
    Private Sub btnCalcularCono_Click(sender As Object, e As EventArgs) Handles btnCalcularCono.Click

        Dim area, perimetro, radio, generatriz, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTCono.Checked Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))
            generatriz = Val(InputBox("Ingrese la generatriz: ", "Generatriz"))

            If radio <= 0 Or generatriz <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = ((3.141592) * (radio)) * ((generatriz * radio))

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolCono.Checked And chkAreaTCono.Checked = False Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If radio <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = ((1 / 3) * (3.141592) * (radio ^ 2)) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolCono.Checked And chkAreaTCono.Checked = True Then

            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = ((1 / 3) * (3.141592) * (radio ^ 2)) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub








    'Cilindro
    Private Sub btnCalcularCilindro_Click(sender As Object, e As EventArgs) Handles btnCalcularCilindro.Click

        Dim area, perimetro, radio, generatriz, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTCilindro.Checked Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If radio <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            area = 2 * (3.141592) * (radio) * (altura + radio)

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolCilindro.Checked And chkAreaTCilindro.Checked = False Then

            radio = Val(InputBox("Ingrese el radio: ", "Radio"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If radio <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            volumen = (3.141592) * (radio ^ 2) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolCilindro.Checked And chkAreaTCilindro.Checked = True Then


            volumen = (3.141592) * (radio ^ 2) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub






    'Piramide
    Private Sub btnCalcularPiramide_Click(sender As Object, e As EventArgs) Handles btnCalcularPiramide.Click

        Dim area, areaBase, perimetro, apotemaBase, radio, generatriz, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, base, lateral As Single

        If chkAreaTPiramide.Checked Then

            lado = Val(InputBox("Ingrese un lado de la base: ", "Lado"))
            apotema = Val(InputBox("Ingrese el apotema de la piramide: ", "Apotema"))
            apotemaBase = Val(InputBox("Ingrese el apotema de la base: ", "Apotema de la base"))

            If lado <= 0 Or apotema <= 0 Or apotemaBase <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            perimetro = lado + lado + lado + lado
            area = (0.5) * (perimetro) * ((apotema + apotemaBase))

            MsgBox("Area Total: " & area, MsgBoxStyle.Exclamation, "Resultado")

        End If

        If chkVolPiramide.Checked And chkAreaTPiramide.Checked = False Then

            lado = Val(InputBox("Ingrese un lado de la base: ", "Lado"))
            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If lado <= 0 Or altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            areaBase = lado * lado
            volumen = (1 / 3) * (areaBase) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

        If chkVolPiramide.Checked And chkAreaTPiramide.Checked = True Then

            altura = Val(InputBox("Ingrese la altura: ", "Altura"))

            If altura <= 0 Then

                MsgBox("Valores invalidos")
                Exit Sub
            End If

            areaBase = lado * lado
            volumen = (1 / 3) * (areaBase) * (altura)

            MsgBox("Volumen: " & volumen, MsgBoxStyle.Critical, "Resultado")

        End If

    End Sub

End Class
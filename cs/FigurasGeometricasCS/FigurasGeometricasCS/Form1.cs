using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasCS
{
	public partial class frmFigurasGeometricasCS : Form
	{
		public frmFigurasGeometricasCS()
		{
			InitializeComponent();
		}

		private void frmFigurasGeometricasCS_Load(object sender, EventArgs e)
		{

		}


		//Triangulo
		private void btnCalcularTriangulo_Click(object sender, EventArgs e)
		{
			float area, perimetro, @base, altura, ladoUno = default(float), ladoDos, ladoTres;
			if (chkPeriTriangulo.Checked)
			{
				ladoUno = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado uno (base): ", "Lado uno (base)")));
				ladoDos = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado dos: ", "Lado dos")));
				ladoTres = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado tres: ", "Lado tres")));
				if (ladoUno <= 0 | ladoDos <= 0 | ladoTres <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = ladoUno + ladoDos + ladoTres;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaTriangulo.Checked & chkPeriTriangulo.Checked == false)
			{
				@base = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base: ", "Base")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (@base <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = @base * altura / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaTriangulo.Checked & chkPeriTriangulo.Checked == true)
			{
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = ladoUno * altura / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}
		}





		// Cuadrado
		private void btnCalcularCuadrado_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado = default(float), altura, ladoUno, ladoDos, ladoTres;
			if (chkPeriCuadrado.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaCuadrado.Checked & chkPeriCuadrado.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = lado * lado;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaCuadrado.Checked & chkPeriCuadrado.Checked == true)
			{
				area = lado * lado;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}









		// Rectangulo
		private void btnCalcularRectangulo_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado, altura = default(float), ladoUno, ladoDos, ladoTres, ladoCuatro, @base = default(float), lateral;
			if (chkPeriRectangulo.Checked)
			{
				@base = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base: ", "Base")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (@base <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = altura * 2 + @base * 2;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaRectangulo.Checked & chkPeriRectangulo.Checked == false)
			{
				@base = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base: ", "Base")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (@base <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = @base * altura;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaRectangulo.Checked & chkPeriRectangulo.Checked == true)
			{
				area = @base * altura;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}








		//Octagono
		private void btnCalcularOctagono_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriOctagono.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado + lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaOctagono.Checked & chkPeriOctagono.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				perimetro = lado + lado + lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (lado <= 0 | apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaOctagono.Checked & chkPeriOctagono.Checked == true)
			{
				perimetro = lado + lado + lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}







		//Circulo
		private void btnCalcularCirculo_Click(object sender, EventArgs e)
		{

			float area, radio = default(float), perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriCirculo.Checked)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				if (radio <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = (float)(2 * radio * 3.141592);
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaCirculo.Checked & chkPeriCirculo.Checked == false)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				if (radio <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (float)(Math.Pow(radio, 2) * 3.141592);
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaCirculo.Checked & chkPeriCirculo.Checked == true)
			{
				area = (float)(Math.Pow(radio, 2) * 3.141592);
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}







		//Rombo
		private void btnCalcularRombo_Click(object sender, EventArgs e)
		{

			float area, diagonalMayor, diagonalMenor, radio, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriRombo.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaRombo.Checked & chkPeriRombo.Checked == false)
			{
				diagonalMenor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la diagonal menor: ", "Diagonal Menor")));
				diagonalMayor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la diagonal mayor: ", "Diagonal Mayor")));
				if (diagonalMayor <= 0 | diagonalMenor <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = diagonalMayor * diagonalMenor / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaRombo.Checked & chkPeriRombo.Checked == true)
			{
				diagonalMenor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la diagonal menor: ", "Diagonal Menor")));
				diagonalMayor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la diagonal mayor: ", "Diagonal Mayor")));
				if (diagonalMenor <= 0 | diagonalMayor <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = diagonalMayor * diagonalMenor / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}






		//Trapecio
		private void btnCalcularTrapecio_Click(object sender, EventArgs e)
		{

			float area, diagonalMayor, baseMayor = default(float), baseMenor = default(float), diagonalUno, diagonalDos, diagonalMenor, radio, perimetro, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriTrapecio.Checked)
			{
				baseMayor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base mayor: ", "Base mayor")));
				baseMenor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base menor: ", "Base menor")));
				diagonalUno = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese una diagonal: ", "Diagonal uno")));
				diagonalDos = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la otra diagonal: ", "Diagonal dos")));
				if (baseMayor <= 0 | baseMenor <= 0 | diagonalUno <= 0 | diagonalDos <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = baseMayor + baseMenor + diagonalUno + diagonalDos;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaTrapecio.Checked & chkPeriTrapecio.Checked == false)
			{
				baseMayor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base mayor: ", "Base mayor")));
				baseMenor = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la base menor: ", "Base menor")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (baseMenor <= 0 | baseMayor <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (baseMayor + baseMenor) * altura / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaTrapecio.Checked & chkPeriTrapecio.Checked == true)
			{
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (baseMayor + baseMenor) * altura / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}






		//Pentagono
		private void btnCalcularPentagono_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriPentagono.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaPentagono.Checked & chkPeriPentagono.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				perimetro = lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (lado <= 0 | apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaPentagono.Checked & chkPeriPentagono.Checked == true)
			{
				perimetro = lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}






		//Hexagono
		private void btnCalcularHexagono_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriHexagono.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaHexagono.Checked & chkPeriHexagono.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				perimetro = lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (lado <= 0 | apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaHexagono.Checked & chkPeriHexagono.Checked == true)
			{
				perimetro = lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}






		//Heptagono
		private void btnCalcularHeptagono_Click(object sender, EventArgs e)
		{

			float area, perimetro, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkPeriHeptagono.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado + lado + lado + lado;
				Interaction.MsgBox("Perimetro: " + Conversions.ToString(perimetro), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkAreaHexagono.Checked & chkPeriHeptagono.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				perimetro = lado + lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (lado <= 0 | apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkAreaHexagono.Checked & chkPeriHeptagono.Checked == true)
			{
				perimetro = lado + lado + lado + lado + lado + lado + lado;
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema: ", "Apotema")));
				if (apotema <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = perimetro * apotema / 2;
				Interaction.MsgBox("Area: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

		}





		//FIGURAS 3D///////////////////////////
		



		//Cubo
		private void btnCalcularCubo_Click(object sender, EventArgs e)
		{

			float area, perimetro, volumen, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkAreaTCubo.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (float)(6 * Math.Pow(lado, 2));
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolCubo.Checked & chkAreaTCubo.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado: ", "Lado")));
				if (lado <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = Conversions.ToSingle(Math.Pow(lado, 3));
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolCubo.Checked & chkAreaTCubo.Checked == true)
			{
				volumen = Conversions.ToSingle(Math.Pow(lado, 3));
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

		}







		//Paralelepipedo
		private void btnCalcularParalelepipedo_Click(object sender, EventArgs e)
		{

			float area, perimetro, volumen, lado, altura, apotema, ladoUno = default(float), ladoDos = default(float), ladoTres = default(float), ladoCuatro, @base, lateral;
			if (chkAreaTParalelepipedo.Checked)
			{
				ladoUno = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado A: ", "Lado A")));
				ladoDos = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado B: ", "Lado B")));
				ladoTres = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado C: ", "Lado C")));
				if (ladoUno <= 0 | ladoDos <= 0 | ladoTres <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = 2 * (ladoUno * ladoDos) + 2 * (ladoUno * ladoTres) + 2 * (ladoDos * ladoTres);
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolParalelepipedo.Checked & chkAreaTParalelepipedo.Checked == false)
			{
				ladoUno = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado A: ", "Lado A")));
				ladoDos = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado B: ", "Lado B")));
				ladoTres = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el lado C: ", "Lado C")));
				if (ladoUno <= 0 | ladoDos <= 0 | ladoTres <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = ladoUno * ladoDos * ladoTres;
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolParalelepipedo.Checked & chkAreaTParalelepipedo.Checked == true)
			{
				volumen = ladoUno * ladoDos * ladoTres;
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

		}





		//Esfera
		private void btnCalcularEsfera_Click(object sender, EventArgs e)
		{

			float area, perimetro, radio = default(float), volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkAreaTEsfera.Checked)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				if (radio <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (float)(4 * 3.141592 * Math.Pow(radio, 2));
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolEsfera.Checked & chkAreaTEsfera.Checked == false)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				if (radio <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = (float)(4 / (double)3 * 3.141592 * Math.Pow(radio, 3));
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolEsfera.Checked & chkAreaTEsfera.Checked == true)
			{
				volumen = (float)(4 / (double)3 * 3.141592 * Math.Pow(radio, 3));
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

		}






		//Cono
		private void btnCalcularCono_Click(object sender, EventArgs e)
		{

			float area, perimetro, radio = default(float), generatriz, volumen, lado, altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkAreaTCono.Checked)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				generatriz = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la generatriz: ", "Generatriz")));
				if (radio <= 0 | generatriz <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (float)(3.141592 * radio * (generatriz * radio));
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolCono.Checked & chkAreaTCono.Checked == false)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (radio <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = (float)(1 / (double)3 * 3.141592 * Math.Pow(radio, 2) * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolCono.Checked & chkAreaTCono.Checked == true)
			{
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = (float)(1 / (double)3 * 3.141592 * Math.Pow(radio, 2) * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

		}





		//Cilindro
		private void btnCalcularCilindro_Click(object sender, EventArgs e)
		{

			float area, perimetro, radio = default(float), generatriz, volumen, lado, altura = default(float), apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkAreaTCilindro.Checked)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (radio <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				area = (float)(2 * 3.141592 * radio * (altura + radio));
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolCilindro.Checked & chkAreaTCilindro.Checked == false)
			{
				radio = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el radio: ", "Radio")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (radio <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				volumen = (float)(3.141592 * Math.Pow(radio, 2) * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolCilindro.Checked & chkAreaTCilindro.Checked == true)
			{
				volumen = (float)(3.141592 * Math.Pow(radio, 2) * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

		}






		//Piramide
		private void btnCalcularPiramide_Click(object sender, EventArgs e)
		{

			float area, areaBase, perimetro, apotemaBase, radio, generatriz, volumen, lado = default(float), altura, apotema, ladoUno, ladoDos, ladoTres, ladoCuatro, @base, lateral;
			if (chkAreaTPiramide.Checked)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado de la base: ", "Lado")));
				apotema = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema de la piramide: ", "Apotema")));
				apotemaBase = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese el apotema de la base: ", "Apotema de la base")));
				if (lado <= 0 | apotema <= 0 | apotemaBase <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				perimetro = lado + lado + lado + lado;
				area = (float)(0.5 * perimetro * (apotema + apotemaBase));
				Interaction.MsgBox("Area Total: " + Conversions.ToString(area), MsgBoxStyle.Exclamation, "Resultado");
			}

			if (chkVolPiramide.Checked & chkAreaTPiramide.Checked == false)
			{
				lado = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese un lado de la base: ", "Lado")));
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (lado <= 0 | altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				areaBase = lado * lado;
				volumen = (float)(1 / (double)3 * areaBase * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}

			if (chkVolPiramide.Checked & chkAreaTPiramide.Checked == true)
			{
				altura = Conversions.ToSingle(Conversion.Val(Interaction.InputBox("Ingrese la altura: ", "Altura")));
				if (altura <= 0)
				{
					Interaction.MsgBox("Valores invalidos");
					return;
				}

				areaBase = lado * lado;
				volumen = (float)(1 / (double)3 * areaBase * altura);
				Interaction.MsgBox("Volumen: " + Conversions.ToString(volumen), MsgBoxStyle.Critical, "Resultado");
			}
		}
	}
}

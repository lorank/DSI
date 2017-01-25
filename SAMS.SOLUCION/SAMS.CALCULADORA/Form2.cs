using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.CALCULADORA
{
    public partial class Form2 : Form
    {
        bool detectaroperaciones = true;
        string operacion, borrado;
        double numero1, numero2, result, guardarmemoria, signo;

        public Form2()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTTONES NUMERICOS
        private void btn1_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "1";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "2";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "3";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "4";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "5";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "6";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "7";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "8";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (detectaroperaciones)
            {
                txt_Pantalla.Text = "";
                txt_Pantalla.Text = "9";
                detectaroperaciones = false;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                txt_Pantalla.Text = txt_Pantalla.Text + "0";
            }
        }
        //FIN DE BOTONES NUMERICOS
        //----------------------------------------------------------------------------------------------------------------------------//
        //BOTONES DE OPERACIONES
        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            detectaroperaciones = true;
            numero1 = double.Parse(txt_Pantalla.Text);
        }

        private void btn_Restar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            detectaroperaciones = true;
            numero1 = double.Parse(txt_Pantalla.Text);
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            operacion = "*";
            detectaroperaciones = true;
            numero1 = double.Parse(txt_Pantalla.Text);
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            detectaroperaciones = true;
            numero1 = double.Parse(txt_Pantalla.Text);
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + ".";
        }
        //FIN DE BOTONES DE OPERACIONES
        //----------------------------------------------------------------------------------------------------------------------------//
        //BOTON RESULTADO
        private void btn_Result_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(txt_Pantalla.Text);
            if (operacion == "+")
            {
                result = numero1 + numero2;
                txt_Pantalla.Text = result.ToString();
                detectaroperaciones = true;
            }
            if (operacion == "-")
            {
                result = numero1 - numero2;
                txt_Pantalla.Text = result.ToString();
                detectaroperaciones = true;
            }
            if (operacion == "*")
            {
                result = numero1 * numero2;
                txt_Pantalla.Text = result.ToString();
                detectaroperaciones = true;
            }
            if (operacion == "/")
            {
                result = numero1 / numero2;
                txt_Pantalla.Text = result.ToString();
                detectaroperaciones = true;
            }
        }
        //FIN DEL BOTON RESULTADO
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON RAIZ
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (numero1 >= 0)
            {
                numero1 = double.Parse(txt_Pantalla.Text);
                result = Math.Sqrt(numero1);
                txt_Pantalla.Text = result.ToString();
                detectaroperaciones = true;
            }
            else
            {
                MessageBox.Show("No se puede calcular la Raiz de numeros menores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //FIN DEL BOTON RAIZ
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON AL CUADRADO
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Pow(numero1, 2).ToString();
        }
        //FIN DEL BOTON CUADRADO
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON RETROCESO
        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = txt_Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            txt_Pantalla.Text = borrado;

            if (txt_Pantalla.Text == "")
            {
                txt_Pantalla.Text = "0";
                detectaroperaciones = true;
            }
            if (txt_Pantalla.Text == "-")
            {
                txt_Pantalla.Text = "0";
                detectaroperaciones = true;
            }
        }
        //FIN DEL BOTON RETROCESO
        //-------------------------------------------------------------------------------------------------------------------------------//
       //BOTON CLEAR
        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            detectaroperaciones = true;
        }
        //FIN DEL BOTON CLEAR
        //--------------------------------------------------------------------------------------------------------------------------------//
        //BOTON PORCENTAJE
        private void btn_Porciento_Click(object sender, EventArgs e)
        {
            operacion = "%";
            numero2 = double.Parse(txt_Pantalla.Text);
            result = numero1 + numero2;
            txt_Pantalla.Text = Convert.ToString((numero1 * numero2) / 100);   
        }
        //FIN DEL BOTON PORCENTAJE
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON MR
        private void btnMR_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = guardarmemoria.ToString();
        }
        // FIN DEL BOTON MR
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON MS
        private void btnMS_Click(object sender, EventArgs e)
        {
            guardarmemoria = double.Parse(txt_Pantalla.Text);
        }
        //FIN DEL BOTON MS
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON MPLUS
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            guardarmemoria = guardarmemoria + double.Parse(txt_Pantalla.Text);
        }
        //FIN DEL BOTON MPLUS
        //-------------------------------------------------------------------------------------------------------------------------------//
        //BOTON SIGNO
        private void btnSigno_Click(object sender, EventArgs e)
        {
            signo = double.Parse(txt_Pantalla.Text);
            signo = signo - (signo * 2);
            txt_Pantalla.Text = signo.ToString();
        }
        //FIN DEL BOTON SIGNO
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON MCLEAR
        private void btnMC_Click(object sender, EventArgs e)
        {
            guardarmemoria = 0;
        }
        //FIN DEL BOTON MCLEAR
        private void estanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
        //BOTON TANGENTE
        private void btnTan_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Tan(numero1).ToString();
        }
        //FIN DEL BOTON TANGENTE
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON COSENO
        private void btnCos_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Cos(numero1).ToString();
        }
        //FIN DEL BOTON COSENO
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON SENO
        private void btnSen_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Sin(numero1).ToString();
        }
        //FIN DEL BOTON SENO
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON AL CUBO
        private void btn_x3_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Pow(numero1, 3).ToString();
        }
        //FIN DEL BOTON CUBO
        //----------------------------------------------------------------------------------------------------------------------------//
       //BOTON 10X
        private void btn_Parentesis_der_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Pow(10,numero1).ToString();
        }
        //FIN DEL BOTON 10X
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON SINH
        private void btnSinh_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Sinh(numero1).ToString();
        }
        //FIN DEL BOTON SINh
        //-----------------------------------------------------------------------------------------------------------------------------//
        //BOTON COSh
        private void btnCosh_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Cosh(numero1).ToString();
        }
        //FIN DEL BOTON COSh
        //-------------------------------------------------------------------------------------------------------------------------------//
        //BOTON TANh
        private void btnTanh_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Tanh(numero1).ToString();
        }
        //FIN DEL BOTON TANh
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON LOGARITMO
        private void btnLog_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Log(numero1).ToString();
        }
        //FIN DEL BOTON LOGARITMO
        //----------------------------------------------------------------------------------------------------------------------------//
        //BOTON Mmenos
        private void btnMmenos_Click(object sender, EventArgs e)
        {

        }
        //FIN DEL BOTON MENOS
        //------------------------------------------------------------------------------------------------------------------------------//
        //BOTON DE SALIR
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}

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
    public partial class Form1 : Form
    {
        bool detectaroperaciones = true;
        string operacion, borrado;
        double numero1, numero2, result,guardarmemoria,signo;
       
        public Form1()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("No se puede calcular la Raiz de numeros menores a 0","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

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
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txt_Pantalla.Text);
            result = numero1;
            txt_Pantalla.Text = Math.Pow(numero1,2).ToString();

        }
        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = txt_Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            txt_Pantalla.Text = borrado;

            if (txt_Pantalla.Text=="") 
            {
                txt_Pantalla.Text = "0";
                detectaroperaciones = true;
            }
            if(txt_Pantalla.Text=="-")
            {
                txt_Pantalla.Text="0";
                detectaroperaciones=true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            detectaroperaciones = true;
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + ".";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            detectaroperaciones = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = guardarmemoria.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            guardarmemoria = double.Parse(txt_Pantalla.Text);
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            guardarmemoria = guardarmemoria + double.Parse(txt_Pantalla.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            guardarmemoria = 0;
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            signo = double.Parse(txt_Pantalla.Text);
            signo = signo - (signo * 2);
            txt_Pantalla.Text = signo.ToString();
        }

        private void btn_Porciento_Click(object sender, EventArgs e)
        {
            operacion = "%";
            numero2 = double.Parse(txt_Pantalla.Text);
            result = numero1 + numero2;
            txt_Pantalla.Text = Convert.ToString((numero1 * numero2) / 100);   
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
    }
}

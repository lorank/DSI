﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAMS.CALCULADORA
{
    class Solo_Numeros
    {
        public static void SoloNumero(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar)) 
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar)) 
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else if (Char.IsSymbol(v.KeyChar)) 
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }
    }
}

namespace SAMS.CALCULADORA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Pantalla = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btn_Porciento = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.btn_Restar = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_Decimal = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cientificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Pantalla
            // 
            this.txt_Pantalla.Location = new System.Drawing.Point(7, 30);
            this.txt_Pantalla.Name = "txt_Pantalla";
            this.txt_Pantalla.Size = new System.Drawing.Size(255, 20);
            this.txt_Pantalla.TabIndex = 3;
            this.txt_Pantalla.Text = "0";
            this.txt_Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(7, 89);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(39, 29);
            this.btnMC.TabIndex = 5;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(7, 124);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(39, 29);
            this.btnMR.TabIndex = 6;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(7, 159);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(39, 29);
            this.btnMS.TabIndex = 7;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Location = new System.Drawing.Point(7, 194);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(39, 29);
            this.btnMPlus.TabIndex = 8;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(48, 194);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(39, 29);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(48, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 29);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(48, 124);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 29);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(48, 89);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 29);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnSigno
            // 
            this.btnSigno.Location = new System.Drawing.Point(92, 194);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(39, 29);
            this.btnSigno.TabIndex = 16;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(92, 159);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 29);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(92, 124);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(39, 29);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(92, 89);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(39, 29);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(223, 159);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(39, 64);
            this.btn_Result.TabIndex = 28;
            this.btn_Result.Text = "=";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(223, 56);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(39, 29);
            this.btnCuadrado.TabIndex = 27;
            this.btnCuadrado.Text = "x^2";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btn_Porciento
            // 
            this.btn_Porciento.Location = new System.Drawing.Point(223, 124);
            this.btn_Porciento.Name = "btn_Porciento";
            this.btn_Porciento.Size = new System.Drawing.Size(39, 29);
            this.btn_Porciento.TabIndex = 26;
            this.btn_Porciento.Text = "%";
            this.btn_Porciento.UseVisualStyleBackColor = true;
            this.btn_Porciento.Click += new System.EventHandler(this.btn_Porciento_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(223, 89);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(39, 29);
            this.btnRaiz.TabIndex = 25;
            this.btnRaiz.Text = "Sqrt";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(178, 194);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(39, 29);
            this.btn_Sumar.TabIndex = 24;
            this.btn_Sumar.Text = "+";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // btn_Restar
            // 
            this.btn_Restar.Location = new System.Drawing.Point(178, 159);
            this.btn_Restar.Name = "btn_Restar";
            this.btn_Restar.Size = new System.Drawing.Size(39, 29);
            this.btn_Restar.TabIndex = 23;
            this.btn_Restar.Text = "-";
            this.btn_Restar.UseVisualStyleBackColor = true;
            this.btn_Restar.Click += new System.EventHandler(this.btn_Restar_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Location = new System.Drawing.Point(178, 124);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(39, 29);
            this.btn_Multi.TabIndex = 22;
            this.btn_Multi.Text = "*";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(178, 89);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(39, 29);
            this.btn_dividir.TabIndex = 21;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_Decimal
            // 
            this.btn_Decimal.Location = new System.Drawing.Point(137, 194);
            this.btn_Decimal.Name = "btn_Decimal";
            this.btn_Decimal.Size = new System.Drawing.Size(39, 29);
            this.btn_Decimal.TabIndex = 20;
            this.btn_Decimal.Text = ".";
            this.btn_Decimal.UseVisualStyleBackColor = true;
            this.btn_Decimal.Click += new System.EventHandler(this.btn_Decimal_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(137, 159);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 29);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(137, 124);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 29);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(137, 89);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(39, 29);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(148, 56);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(69, 29);
            this.btnC.TabIndex = 29;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(77, 56);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(69, 29);
            this.btnCE.TabIndex = 30;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceso.Location = new System.Drawing.Point(7, 56);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(68, 29);
            this.btnRetroceso.TabIndex = 31;
            this.btnRetroceso.Text = "<--";
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cientificaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cientificaToolStripMenuItem
            // 
            this.cientificaToolStripMenuItem.Name = "cientificaToolStripMenuItem";
            this.cientificaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cientificaToolStripMenuItem.Text = "Cientifica";
            this.cientificaToolStripMenuItem.Click += new System.EventHandler(this.cientificaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(271, 237);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btn_Porciento);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btn_Sumar);
            this.Controls.Add(this.btn_Restar);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_Decimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txt_Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pantalla;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btn_Porciento;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.Button btn_Restar;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_Decimal;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cientificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


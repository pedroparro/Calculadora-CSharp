using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //variaveis
        decimal input1 = 0;
        decimal input3 = 0;
        string opr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //numero 1
        private void btn1_Click(object sender, EventArgs e)
        {
            if(resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "1";
            }
            else
            {
                resultado.Text = resultado.Text + "1";
            }
        }

        //numero 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "2";
            }
            else
            {
                resultado.Text = resultado.Text + "2";
            }
        }

        //numero 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "3";
            }
            else
            {
                resultado.Text = resultado.Text + "3";
            }
        }
        //numero 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "4";
            }
            else
            {
                resultado.Text = resultado.Text + "4";
            }
        }
        //numero 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "5";
            }
            else
            {
                resultado.Text = resultado.Text + "5";
            }
        }
        //numero 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "6";
            }
            else
            {
                resultado.Text = resultado.Text + "6";
            }
        }
        //numero 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "7";
            }
            else
            {
                resultado.Text = resultado.Text + "7";
            }
        }
        //numero 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "8";
            }
            else
            {
                resultado.Text = resultado.Text + "8";
            }
        }
        //numero 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "9";
            }
            else
            {
                resultado.Text = resultado.Text + "9";
            }
        }
        //numero 0
        private void btn0_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = "0";
            }
            else
            {
                resultado.Text = resultado.Text + "0";
            }
        }
        //Divisão
        private void op_divisao_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                //operacao DIVISAO
                opr = "DIVISAO";
                input1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
                //limpa o resultado
                resultado.Text = "";
                lblResult.Text = "/";
            }
           
        }
        //Multiplicação
        private void op_multiplicacao_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                //operacao MULT
                opr = "MULT";
                input1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
                //limpa o resultado
                resultado.Text = "";
                lblResult.Text = "*";
            }
            
        }
        //Subtração
        private void op_subtracao_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                //operacao SUB
                opr = "SUB";
                input1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
                //limpa o resultado
                resultado.Text = "";
                lblResult.Text = "-";
            }
            
        }
        //Soma
        private void op_soma_Click(object sender, EventArgs e)
        {
            if(resultado.Text != "")
            {
                //operacao soma
                opr = "SOMA";
                input1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
                //limpa o resultado
                resultado.Text = "";
                lblResult.Text = "+";
            }
        }
        // = Igual
        private void op_igual_Click(object sender, EventArgs e)
        {
            input3 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            if (lblResult.Text == "+")
            {
                resultado.Text = Convert.ToString(input1 + input3);
            }
            else if (lblResult.Text == "-")
            {
                resultado.Text = Convert.ToString(input1 - input3);
            }
            else if (lblResult.Text == "*")
            {
                resultado.Text = Convert.ToString(input1 * input3);
            }
            else if (lblResult.Text == "/")
            {
                resultado.Text = Convert.ToString(input1 / input3);
            }
            else if (lblResult.Text == "%")
            {
                resultado.Text = Convert.ToString((input1 * input3) / 100);
            }
        }

        private void limpa_Click(object sender, EventArgs e)
        {
                resultado.Text = "";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == "")
            {
                resultado.Text = ".";
            }
            else
            {
                resultado.Text = resultado.Text + ".";
            }
        }
    }
}

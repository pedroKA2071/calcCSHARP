using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void escolhaOperador(int numero, string operadorEscolhido)
        {

            lbTemp.Text = numero.ToString();
            lbOperador.Text = operadorEscolhido;
            txbNumero1.Text = "";

        }


        public double calculos(double num1, double num2, string operador)
        {
            double resultado = 0;
            

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "x")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            else if(operador == "r")
            {
                resultado = num1 % num2;
            }
            else if (operador == "%")
            {
                resultado = num1 * num2 / 100;
            }
            return resultado;
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {

            if (txbNumero1.Text != "" && txbNumero1.Text != "Error" )
            {

                int numero1 = int.Parse(txbNumero1.Text);

                //int numero2 = int.Parse( txbNumero2.Text );
                int numero2 = 0;
                int total;

                Button botao = (Button)sender;
                string operadorSelecionado = botao.Text;

                //total = resultadoSoma(numero1, numero2);

                //total = calculos(numero1, numero2, operadorSelecionado);
                //lbResultado.Text = total.ToString();

                escolhaOperador(numero1, operadorSelecionado);

            } else
            {
                txbNumero1.Text = "Error";
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button valorBotao = (Button)sender;

            //MessageBox.Show(valorBotao.Text);
            //txbNumero1.Text = txbNumero1.Text + valorBotao.Text;

            txbNumero1.Text += valorBotao.Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNumero1.Text = "";
     
        }

        private void btnLimpartudo_Click(object sender, EventArgs e)
        {
            txbNumero1.Text = "";
            lbOperador.Text = "";
            lbTemp.Text = "";
            lbResultado.Text = "";

        }

        private void btnIgual_Click(object sender, EventArgs e) 
        {
           int primeiro_numero = int.Parse(lbTemp.Text);

            int segundo_numero = int.Parse(txbNumero1.Text);

            string operador = lbOperador.Text;

            double total = calculos(primeiro_numero, segundo_numero, operador);

            txbNumero1.Text = total.ToString();
            
            
            //MessageBox.Show( primeiro_numero + "|" + segundo_numero + "|" + operador);
        }

        private void btn_negativo (object sender, EventArgs e)
        {
            double negativo = double.Parse(txbNumero1.Text);

            negativo = negativo * (-1);

            txbNumero1.Text = negativo.ToString();
        }
    }
}

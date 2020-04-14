using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string getInd(float imc)
        {
            string mensagem = "";
            
            if (imc <= 15)
            {
                mensagem = "Extremamente abaixo do peso";
            }
            else if (imc <= 16)
            {
                mensagem = "Gravemente abaixo do peso";
            }
            else if (imc <= 18.5)
            {
                mensagem = "Abaixo do peso ideal";
            }
            else if (imc <= 25)
            {
                mensagem = "Faixa de peso ideal";
            }
            else if (imc <= 30)
            {
                mensagem = "Sobrepeso";
            }
            else if (imc <= 35)
            {
                mensagem = "Obesidade grau 1";
            }
            else if (imc <= 40)
            {
                mensagem = "Obesidade grau 2";
            }
            else if (imc > 40)
            {
                mensagem = "Obesidade grau 3";
            }
            return mensagem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float altura = float.Parse(txtAltura.Text);
                float peso = float.Parse(txtPeso.Text);
                float imc = peso / (altura * altura);
                lblInd.Text = getInd(imc);
                lblResultado.Text = Convert.ToString(Math.Round(imc, 2));
            }
            catch (FormatException)
            {
                lblResultado.Text = "Agument NULL";
            }
           

        }

        
    }
}

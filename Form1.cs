using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4
{
    public partial class lbl2 : Form
    {
        public lbl2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declaração de Variaveis:
            double peso = 0;
            double altura = 0;
            double imc = 0;
            peso = double.Parse(textpeso.Text);
            altura = double.Parse(textBox1.Text);
            //Tirando imc a partir da altura e peso:
            imc = peso *(altura*altura);
            //Mostrando o resultado do imc:
            
            //Classificando a situação de acordo com o imc:
            if (imc <= 18.5)
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Abaixo do Peso";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Peso normal";
                lblSituacao.ForeColor = Color.Green;
            }
            else if(imc >25 && imc <=29.9)
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Sobrepeso";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (imc >= 30 && imc <=34.9)
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Obesidade Grau 1";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (imc >=35 && imc <=39.9)
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Obesidade Grau 2";
                lblSituacao.ForeColor = Color.Red;
            }
            else
            {
                lbl.Text = imc.ToString();
                lblSituacao.Text = "Obesidade Grau 3 Ou Mórbida";
                lblSituacao.ForeColor = Color.Red;
            }
                    
                    

            
                    
            

            
        }
    }
}

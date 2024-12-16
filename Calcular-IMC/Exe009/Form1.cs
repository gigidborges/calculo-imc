using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe009
{
    public partial class Form1 : Form
    {
        double peso = 0;
        double altura = 0;
        double imc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblImc.Text = "";
            lblClass.Text = "";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                peso = Double.Parse(txt1.Text);
                altura = Double.Parse(txt2.Text);

                if(peso < 30 || altura < 1 || altura > 3)
                {
                    throw new Exception("peso ou altura fora dos limites!!");
                }

                imc = peso / (altura * altura);
                lblImc.Text = imc.ToString("00.00");


                if (imc < 16)
                {
                    lblClass.Text = "Magreza grau 3";
                }

                else if (imc < 16.0 || imc < 16.9)
                {
                    lblClass.Text = "Magreza grau 2";
                }

                else if (imc < 17.0 || imc < 18.4)
                {
                    lblClass.Text = "Magreza grau 1";
                }

                else if (imc < 18.5 || imc < 24.9)
                {
                    lblClass.Text = "Adequado";
                }

                else if (imc < 25.0 || imc < 29.9)
                {
                    lblClass.Text = "Pré-obeso";
                }

                else if (imc < 30.0 || imc < 34.9)
                {
                    lblClass.Text = "Obesidade grau 1";
                }

                else if (imc < 35.0 || imc < 39.9)
                {
                    lblClass.Text = "Obesidade grau 2";
                }

                else if (imc >= 40)
                {
                    lblClass.Text = "Obesidade grau 3";
                }
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Arenção");
                txt1.Focus();
            }
           
        }
    }
}

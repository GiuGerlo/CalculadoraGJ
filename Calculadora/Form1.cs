using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int Valor1; //definicion de valores de la calculadora
            int Valor2;
            Valor1 = Convert.ToInt32(Numero1Text.Text);
            Valor2 = Convert.ToInt32(Numero2Text.Text);
            int Resultado = Valor1 + Valor2;
            ResultadoText.Text = Resultado.ToString();
            //comentario
            //commit

        }
    }
}

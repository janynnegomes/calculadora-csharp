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
    public partial class calculadora : Form
    {
        
        public calculadora()
        {
            InitializeComponent();
        }

        private void botaoSomar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textoPrimeiroValor.Text) && !String.IsNullOrEmpty(textoSegundoValor.Text))
            {
                exibicaoResultado.Text = (Convert.ToDouble(textoPrimeiroValor.Text) + Convert.ToDouble(textoSegundoValor.Text)).ToString();

                LimparValores();
            }
        }

        protected void LimparValores()
        {
            textoPrimeiroValor.Clear();
            textoSegundoValor.Clear();

            textoPrimeiroValor.Focus();
        }
    }
}

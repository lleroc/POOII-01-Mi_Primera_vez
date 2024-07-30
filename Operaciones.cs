namespace _01_Mi_Primera_vez
{
    using System;
    using System.Windows.Forms;
    using Clases;
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones_Clase Suma = new Operaciones_Clase();
            int resultado =  Suma.Suma(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text));
            lbl_Resultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones_Clase Resta = new Operaciones_Clase();
            lbl_Resultado.Text = Resta.Resta(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }
    }
}

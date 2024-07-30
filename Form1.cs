using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_vez
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var alumnos = new Alumnos();
            alumnos.Cedula = "1803971371";
            alumnos.Nombre = "Luis";
            alumnos.Apellido = "Llerena";
            alumnos.Edad = 36;
            alumnos.fechaNaciento = Convert.ToDateTime("01/03/2365");
            alumnos.Estado = true;

            if (alumnos.Estado == true) {
                MessageBox.Show(alumnos.Cedula);
                MessageBox.Show(alumnos.Nombre);
                MessageBox.Show(alumnos.Apellido + " " +
                    alumnos.Edad + (alumnos.Estado == true ? "Activo" : "Inactivo"));
            }
            else{
                MessageBox.Show("El estudiante no esta activo y por eso no se puede mostrar la informacion");
            }

            while (alumnos.Estado)
            {

            }

            do
            {

            } while (!alumnos.Estado);

            switch (alumnos.Estado)
            {
                case true:
                    MessageBox.Show("Cualqeuir cosa");
                    break;
                case false:
                    MessageBox.Show("El estudiante no esta activo y por eso no se puede mostrar la informacion");
                    break;
            }

            // int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int[,] numeros = new int[3, 3];

            /*   int[,] numeros = new int[,]
             {
                 { 1,2,3},
                 { 4,5,6},
                 { 7,8,9}
             };

           Console.WriteLine("El elemento de la posicion 2,2 es" + numeros[2,2]); // imprimir en consola

             for (int i = 0; i < numeros.GetLength(0); i++)
             {
                 for (int j = 0; j < numeros.GetLength(1); j++)
                 {
                     //fila     y luego columna
                     MessageBox.Show(numeros[i,j].ToString());

                 }
             }*/

        }
    }
}

public class Alumnos {

    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime fechaNaciento { get; set; }
    public int Edad { get; set; }
    public bool Estado { get; set; }
    public int Nivel { get; set; }
}
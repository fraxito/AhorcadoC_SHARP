using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        //almacena la palabra que hay que adivinar
        String palabraOculta = "CETYS";

        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Todos los botones al hacer click vienen a este método
        private void button1_Click(object sender, EventArgs e)
        {
            //casteo el objeto a botón. Sólo va a poder ser botón porque 
            //sólo se genera en los botones
            Button miBoton = (Button)sender;

            String letra = miBoton.Text;
            letra = letra.ToUpper();

            if (palabraOculta.Contains(letra)){
                label1.Text = letra;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2GIT_AERG2223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //AERG-2223.MODIFICAMOS LOS ERRORES
        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            /*AERG-2223.ERROR LOGICO DETECTADO.No está inicializada la variable tipoTelegrama con ningún valor
             por tanto nos da error en la LINEA 42.Debemos de darle valor 'o' a dicha variable.
             */
            char tipoTelegrama = 'o';//AERG-2223.Damos valor al tipoTelegrama
            int numPalabras;
            double coste;
            //TODO AERG-2223.Punto de interrupcion para comprobar que ocurre nada mas recoger el programa el texto.
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ', '.', ',', ':', ';').Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}

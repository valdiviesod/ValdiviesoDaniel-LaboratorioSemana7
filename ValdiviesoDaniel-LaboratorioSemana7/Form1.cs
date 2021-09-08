using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValdiviesoDaniel_LaboratorioSemana7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxTipoDoc.Items.Add("Cedula");
            comboBoxTipoDoc.Items.Add("Tarjeta de Identidad");
        }

        private void TxtTitulo_Click(object sender, EventArgs e)
        {
        }

        private void TxtDocumento_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTipoDoc.SelectedIndex = 0;

        }

        private void TxtBoxDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxDoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            //tabla ASCII
            //if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            //{
            //MessageBox.Show("¡Solo puede ingresar números!");
            //e.Handled = true;
            //return;
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("¡Ingrese sólo números!");
                e.Handled = true;
            }
        }
            

    

        private void TxtBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            //{
            //MessageBox.Show("¡Solo puede ingresar números!");
            //e.Handled = true;
            //return;

            //}
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("¡Ingrese sólo números!");
                e.Handled = true;
            }
        }
        private void TxtBoxEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("¡Solo puede ingresar letras!");
            //e.Handled = true;
            //return;

            //}

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("¡Ingrese sólo letras!");
                e.Handled = false;
            }
        }
               
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String genero = "";
            if (radiobtnMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Fememenino";
            }

                MessageBox.Show("Tipo de documento: " + comboBoxTipoDoc.Text + "\n" + "Numero de documento: " + txtBoxDoc.Text + "\n" + "Nombre " + TxtBoxNombre.Text + "\n" + "Genero: "+ genero + "\n" + "Edad: " + txtBoxEdad.Text + "\n" );
            txtBoxDoc.Clear();
            txtBoxEdad.Clear();
            TxtBoxNombre.Clear();

          

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo1TestingRobertoUrribarri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtSubTotal.Enabled = false;
            txtTotal.Enabled = false;
            txtIVA.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura ingresada satisfactoriamente.");
            txtCantidad.Text = "";
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtIVA.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            txtCantidad.Text = "";
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtIVA.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subtotal, total, precioUnitario, cant;


            precioUnitario = txtPrecioUnitario.Text;
            cant = txtCantidad.Text;
            subtotal = txtSubTotal.Text;
            total = txtTotal.Text;

            txtSubTotal.Text = Convert.ToString(Convert.ToInt64(precioUnitario) * Convert.ToInt64(cant));

            txtIVA.Text = Convert.ToString(Convert.ToInt64(txtSubTotal.Text) * 19 / 100);
            txtTotal.Text = Convert.ToString(Convert.ToInt64(txtSubTotal.Text) + Convert.ToInt64(txtIVA.Text));
        }
    }
}

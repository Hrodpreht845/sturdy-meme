using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Trabajo1TestingRobertoUrribarri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  Public Class Form1
      Private Sub TextBoxSalarioBruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSalarioBruto.KeyPress
          e.Handled = True
      End Sub
      Private Sub TextBoxDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDescuento.KeyPress
          e.Handled = True
      End Sub
      Private Sub TextBoxSalarioNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSalarioNeto.KeyPress
          e.Handled = True
      End Sub
      Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
          Dim salarioBruto, descuento, salarioNeto As Double

          salarioBruto = TextBoxHorasTrabajadas.Text * TextBoxPagoPorHora.Text
          descuento = 0.2 * salarioBruto
          salarioNeto = salarioBruto - descuento

          TextBoxSalarioBruto.Text = salarioBruto.ToString
          TextBoxDescuento.Text = descuento.ToString
          TextBoxSalarioNeto.Text = salarioNeto.ToString

          'sb = Double.Parse(TextBoxSalarioBruto.Text)
      End Sub

      Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
          TextBoxNombre.Focus()

          TextBoxSalarioBruto.Text = ""
          TextBoxDescuento.Text = ""
          TextBoxSalarioNeto.Text = ""
          TextBoxNombre.Text = ""
          TextBoxHorasTrabajadas.Text = ""
          TextBoxPagoPorHora.Text = ""
      End Sub
      Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
          End
      End Sub

      Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          TextBoxSalarioBruto.Enabled = False
          TextBoxDescuento.Enabled = False
          TextBoxSalarioNeto.Enabled = False
      End Sub
  End Class
        */

        private void Form1_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();


            String RazonSocial, Direccion, rutCliente;
            String telefono;
            rutCliente = txtRutCliente.Text;
            RazonSocial = txtRazonSocial.Text;
            Direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            txtRutCliente.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void buttonIngresar_Click_1(object sender, EventArgs e)
        {
            Form2 datosCli = new Form2();
            datosCli.Show();
            this.Visible = false;
        }
        
    }
}

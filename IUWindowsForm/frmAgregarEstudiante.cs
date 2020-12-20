using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForm
{
    public partial class frmAgregarEstudiante : Form
    {
        public frmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCedula.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtCedula.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtApellidos.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtApellidos.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtNombres.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtNombres.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(cmbSexo.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                cmbSexo.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtCorreo.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtEstatura.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtEstatura.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtPeso.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtPeso.Focus();
                return;

            }
            else {

                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.FechaNacimiento = dtpFechaNac.Value;
                persona.Correo = this.txtCorreo.Text;
                persona.Estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);

                int x = CapaDatos.PersonaDAO.crear(persona);
                if (x > 0)
                    MessageBox.Show("Registro agregado con exito...");
                else
                    MessageBox.Show("No se pudo agregar el registro...");
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.email_bien_escrito(txtCorreo.Text);
            if (valido == true)
            {
                lblCorreo.Text = "Correo Valido";
                lblCorreo.Visible = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                lblCorreo.Text = "Correo Invalido";
                lblCorreo.Visible = true;
                btnGuardar.Enabled = false;

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.cedula_bien_escrito(txtCedula.Text);
            if (valido == true)
            {
                lblCedula.Text = "Dato Valido";
                lblCedula.Visible = true;
                btnGuardar.Enabled = true;

            }
            else
            {
                lblCedula.Text = "Dato Invalido";
                lblCedula.Visible = true;
                btnGuardar.Enabled = false;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.nombre_apellidos_bien_escrito(txtApellidos.Text);
            if (valido == true)
            {
                lblApellidos.Text = "Dato Valido";
                lblApellidos.Visible = true;
                btnGuardar.Enabled = true;

            }
            else
            {
                lblApellidos.Text = "Dato Invalido";
                lblApellidos.Visible = true;
                btnGuardar.Enabled = false;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.nombre_apellidos_bien_escrito(txtNombres.Text);
            if (valido == true)
            {
                lblNombre.Text = "Dato Valido";
                lblNombre.Visible = true;
                btnGuardar.Enabled = true;

            }
            else
            {
                lblNombre.Text = "Dato Invalido";
                lblNombre.Visible = true;
                btnGuardar.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.LimpiarDatos(groupBox1);
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.cedula_bien_escrito(txtEstatura.Text);
            if (valido == true)
            {
                lblEstatura.Text = "Dato Valido";
                lblEstatura.Visible = true;
                btnGuardar.Enabled = true;

            }
            else
            {
                lblEstatura.Text = "Dato Invalido";
                lblEstatura.Visible = true;
                btnGuardar.Enabled = false;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos.Persona.cedula_bien_escrito(txtPeso.Text);
            if (valido == true)
            {
                lblPeso.Text = "Dato Valido";
                lblPeso.Visible = true;
                btnGuardar.Enabled = true;

            }
            else
            {
                lblPeso.Text = "Dato Invalido";
                lblPeso.Visible = true;
                btnGuardar.Enabled = false;
            }
        }

      

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            frmListadoEstudiantes mostrar = new frmListadoEstudiantes();
            mostrar.Show();
        }
    }
}

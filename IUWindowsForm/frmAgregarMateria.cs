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
    public partial class frmAgregarMateria : Form
    {
        public frmAgregarMateria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodMateria.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtCodMateria.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtNombreMateria.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtNombreMateria.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(cmbNiveles.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                cmbNiveles.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(txtCarrera.Text))
            {

                MessageBox.Show("Debe llenar la informacion restante");
                txtCarrera.Focus();
                return;

            }
          
            else
            {

                CapaDatos2.Materia materia = new CapaDatos2.Materia();
                materia.CodMat = this.txtCodMateria.Text;
                materia.NombreMateria = this.txtNombreMateria.Text;
                materia.Nivel = int.Parse(this.cmbNiveles.Text);
                materia.Carrera = this.txtCarrera.Text;


                int x = CapaDatos2.clasesMaterias.MateriaDAO.crear(materia);
                if (x > 0)
                    MessageBox.Show("Registro agregado con exito...");
                else
                    MessageBox.Show("No se pudo agregar el registro...");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.LimpiarDatos(groupBox1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmListadoMaterias mostrar = new frmListadoMaterias();
            mostrar.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos2.Materia.codigoMateria(txtCodMateria.Text);
            if (valido == true)
            {
                lblCodMat.ForeColor = Color.FromArgb(47, 225, 159);
                lblCodMat.Text = "Codigo Valido";
                lblCodMat.Visible = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                lblCodMat.ForeColor = Color.FromArgb(255, 0, 0);
                lblCodMat.Text = "Codigo Invalido (solo números)";
                lblCodMat.Visible = true;
                btnGuardar.Enabled = false;

            }
        }

        private void txtCodMateria_TextChanged(object sender, EventArgs e)
        {
            if (txtCodMateria.Text.Length > 10)
            {
                MessageBox.Show("Debe escribir solo 10 caracteres");
                txtCodMateria.Clear();
                
            }
        }

        private void txtNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos2.Materia.validarNombre(txtNombreMateria.Text);
            if (valido == true)
            {
                lblNomMat.ForeColor = Color.FromArgb(47, 225, 159);
                lblNomMat.Text = "Nombre Valido";
                lblNomMat.Visible = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                lblNomMat.ForeColor = Color.FromArgb(255, 0, 0);
                lblNomMat.Text = "Dato Invalido (solo letras)";
                lblNomMat.Visible = true;
                btnGuardar.Enabled = false;

            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valido = CapaDatos2.Materia.validarNombre(txtCarrera.Text);
            if (valido == true)
            {
                lblCarrera.ForeColor = Color.FromArgb(47, 225, 159);
                lblCarrera.Text = "Nombre Valido";
                lblCarrera.Visible = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                lblCarrera.ForeColor = Color.FromArgb(255, 0, 0);
                lblCarrera.Text = "Dato Invalido (solo letras)";
                lblCarrera.Visible = true;
                btnGuardar.Enabled = false;

            }
        }
    }
    }


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
            CapaDatos2.Materia materia = new CapaDatos2.Materia();
            materia.CodMat = this.txtCodMateria.Text;
            materia.NombreMateria = this.txtNombreMateria.Text;
            materia.Nivel = int.Parse(this.txtNivelMat.Text);
            materia.Carrera = this.txtCarrera.Text;
           
           
            int x = CapaDatos2.clasesMaterias.MateriaDAO.crear(materia);
            if (x > 0)
                MessageBox.Show("Registro agregado con exito...");
            else
                MessageBox.Show("No se pudo agregar el registro...");

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.LimpiarDatos(groupBox1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes mostrar = new frmListadoEstudiantes();
            mostrar.Show();
        }
    }
    }


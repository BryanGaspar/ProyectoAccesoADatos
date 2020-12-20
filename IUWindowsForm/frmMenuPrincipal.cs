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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregarMateria agregarMateria = new frmAgregarMateria();
            agregarMateria.Show();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            frmAgregarEstudiante agregarEstudiante = new frmAgregarEstudiante();
            agregarEstudiante.Show();
        }

        private void btnListEstu_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes listadoEstudiantes = new frmListadoEstudiantes();
            listadoEstudiantes.Show();
        }

        private void btnListMat_Click(object sender, EventArgs e)
        {
            frmListadoMaterias listadoMaterias = new frmListadoMaterias();
            listadoMaterias.Show();
        }
    }
}

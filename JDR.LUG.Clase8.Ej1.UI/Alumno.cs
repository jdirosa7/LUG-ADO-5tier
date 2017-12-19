using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.BLL;

namespace JDR.LUG.Clase8.Ej1.UI
{
    public partial class Alumnos : Form
    {
        AlumnoBLL alBLL = new BLL.AlumnoBLL();
        public Alumnos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.Nombre = txtNombre.Text;
            al.Apellido = txtApellido.Text;
            al.DNI = Convert.ToDouble(txtDNI.Text);

            alBLL.Insertar(al);

            ObtenerAlumnos();
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
        }

        private void ObtenerAlumnos()
        {
            List<Alumno> alumnos = alBLL.ObtenerAlumnos();

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos;
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            ObtenerAlumnos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.ID = Convert.ToInt32(txtID.Text);
            al.Nombre = txtNombre.Text;
            al.Apellido = txtApellido.Text;

            alBLL.Actualizar(al);

            ObtenerAlumnos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.ID = Convert.ToInt32(txtID.Text);

            alBLL.Eliminar(al);

            ObtenerAlumnos();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno al = new Alumno();
            al.ID = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            al.Nombre = dgvAlumnos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            al.Apellido = dgvAlumnos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            al.DNI = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["DNI"].Value.ToString());

            txtID.Text = al.ID.ToString();
            txtNombre.Text = al.Nombre;
            txtApellido.Text = al.Apellido;
            txtDNI.Text = al.DNI.ToString();
        }
    }
}

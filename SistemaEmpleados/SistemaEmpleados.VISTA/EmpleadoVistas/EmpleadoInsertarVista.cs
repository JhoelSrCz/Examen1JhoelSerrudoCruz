using SistemaEmpleados.BSS;
using SistemaEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados.VISTA.EmpleadoVistas
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdEmpleadoSeleccionado = 0;
        EmpleadoBss bss = new EmpleadoBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Puesto = txtPuesto.Text;
            empleado.Salario = Convert.ToDecimal(txtSalario.Text);
            empleado.FechaContratacion = dateTimePicker1.Value;

            bss.InsertarEmpleadoBss(empleado);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoListarVista fr = new EmpleadoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Empleado empleado = bss.ObtenerIdBss(IdEmpleadoSeleccionado);
                txtPuesto.Text = empleado.Puesto + " " + empleado.Salario;
            }
        }
    }
}

using SistemaEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into empleado values('" + empleado.Puesto+ "'," +
                                                          "" + empleado.Salario + "," +
                                                          "'" + empleado.FechaContratacion + "')";
            conexion.Ejecutar(consulta);
        }
        public Empleado ObternerEmpleadoId(int id)
        {
            string consulta = "select * from empleado where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Empleado empleado = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                empleado.Puesto = tabla.Rows[0]["puesto"].ToString();
                empleado.Salario = Convert.ToDecimal(tabla.Rows[0]["salario"]);
                empleado.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
            }
            return empleado;
        }
    }
}

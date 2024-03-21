using SistemaEmpleados.DAL;
using SistemaEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoDalBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public Empleado ObtenerIdBss(int id)
        {
            return dal.ObternerEmpleadoId(id);
        }
    }
}

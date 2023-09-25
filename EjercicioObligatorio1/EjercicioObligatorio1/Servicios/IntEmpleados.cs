using EjercicioObligatorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1.Servicios
{
    internal interface IntEmpleados
    {
        Empleados RegistroEmpleado();
        int CapturaEntero(string txt, int min, int max);
        List<Empleados> ModificarEmpleados(List<Empleados> listaEmpleados);
    }
}

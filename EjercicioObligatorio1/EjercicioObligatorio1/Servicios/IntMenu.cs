using EjercicioObligatorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1
{
    public interface IntMenu
    {
        void MostrarMenu();
        void GuardarFichero(List<Empleados> Empleados);
        List<Empleados> AsignarNumeroEmpleado(List<Empleados> listaEmpleados);
    }
}

using EjercicioObligatorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1
{
    public interface IntMenu
    {   /*Metodo simple para mostrar las opciones del menú por consola*/
        void MostrarMenu();
        /*Metodo que recibe una lista de empleados y según la opción guarda todos
         los empleados o el empleado que se le indique por su numero de empleado*/
        void GuardarFichero(List<Empleados> Empleados);
        /*Metodo simple para añadir un numero al atributo "numEmpleado" dependiendo de su 
         posición en la lista*/
        List<Empleados> AsignarNumeroEmpleado(List<Empleados> listaEmpleados);
    }
}

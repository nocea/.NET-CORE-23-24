using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1
{
    public class ImplMenu:IntMenu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("Introduzca una opcion:");
            Console.WriteLine("1.-->Registrar Empleado");
            Console.WriteLine("2.-->Modificar Empleado");
            Console.WriteLine("3.-->Exportar fichero");
            Console.WriteLine("4.-->Cerrar App");
        }
    }
}

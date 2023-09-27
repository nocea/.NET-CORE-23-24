using EjercicioObligatorio1.Entidades;
using System.IO;
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
            Console.WriteLine("1.-->Registrar Empleado");
            Console.WriteLine("2.-->Modificar Empleado");
            Console.WriteLine("3.-->Exportar fichero");
            Console.WriteLine("4.-->Cerrar App");
        }
        public void GuardarFichero(List<Empleados> listaEmpleados)
        {
            int opcion;
            string ruta;
            Console.WriteLine("1-->Guardar un solo empleado");
            Console.WriteLine("2--Guardar todos los empleados");
            Console.Write("Introduce una opción de las siguientes:");
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion <1 || opcion >2)
                {
                    Console.WriteLine("Esa opción no existe");
                }
            } while (opcion <1 || opcion >2);
            ruta1=
        }
            public List<Empleados> AsignarNumeroEmpleado(List<Empleados> listaEmpleados)
            {
                for (int i = 0; i < listaEmpleados.Count(); i++)
                {
                listaEmpleados[i].NumEmpleado=i + 1;
                }
                return listaEmpleados;
            }  
    }
}

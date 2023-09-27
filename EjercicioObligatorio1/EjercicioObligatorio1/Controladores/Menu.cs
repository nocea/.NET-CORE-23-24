using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjercicioObligatorio1.Servicios;
using EjercicioObligatorio1.Entidades;
using System.Threading.Tasks;

namespace EjercicioObligatorio1
{
    class Menu
    {
        static void Main(string[] args)
        {
            IntMenu intMenu = new ImplMenu();
            IntEmpleados intEmpleados = new ImplEmpleados();
            List<Empleados> listaEmpleados = new ArrayList<Empleados>();
            int opcion = 0;
            do
            {
                intMenu.MostrarMenu();
                opcion = intEmpleados.CapturaEntero("Introduzca una opción del menú", 1, 4);
                switch (opcion)
                {
                    case 1:
                        listaEmpleados.Add(intEmpleados.RegistroEmpleado());
                        break;
                    case 2:
                        if (listaEmpleados.Count == 0)
                        {
                            Console.WriteLine("No existe ningún empleado Registrado");
                            Console.WriteLine("Pulse para volver al menú");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            listaEmpleados = intEmpleados.ModificarEmpleados(listaEmpleados);
                        }
                        break;
                    case 3:
                        intMenu.GuardarFichero(listaEmpleados);
                        break;
                }
            } while (opcion != 4);
        }
    }
}

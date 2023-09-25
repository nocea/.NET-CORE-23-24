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
                        listaEmpleados = intMenu.AsignarNumeroEmpleado(listaEmpleados);
                        break;
                    case 2:
                        if (listaEmpleados.Any())
                        {
                            Console.WriteLine("No existe ningún empleado Registrado");
                        }
                        else
                        {
                           
                        }
                        break;
                }
            } while (opcion != 4);




        }
    }
}

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
        {   //Instancias
            IntMenu intMenu = new ImplMenu();
            IntEmpleados intEmpleados = new ImplEmpleados();
            List<Empleados> listaEmpleados = new List<Empleados>();
            int opcion = 0;
            do
            {   
                intMenu.MostrarMenu();//Muestro opciones
                opcion = intEmpleados.CapturaEntero("Introduzca una opción del menú", 1, 4);//guardo opción
                switch (opcion)
                {
                    case 1:
                        //Llamo al método para poder registrar y asignar un numero al empleado
                        listaEmpleados.Add(intEmpleados.RegistroEmpleado());
                        listaEmpleados = intMenu.AsignarNumeroEmpleado(listaEmpleados);
                        break;
                    case 2:
                        
                        if (listaEmpleados.Count == 0)//si la lista está vacía
                        {
                            Console.WriteLine("No existe ningún empleado Registrado");
                            Console.WriteLine("Pulse para volver al menú");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else//si existe algún empleado registrado
                        {
                            listaEmpleados = intEmpleados.ModificarEmpleados(listaEmpleados);
                        }
                        break;
                    case 3:
                        //Guardar en ficheros
                        intMenu.GuardarFichero(listaEmpleados);
                        break;
                }
            } while (opcion != 4);
        }
    }
}

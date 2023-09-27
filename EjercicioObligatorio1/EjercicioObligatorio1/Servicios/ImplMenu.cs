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
            StreamWriter sw;
            int numEmpleado;
            Console.WriteLine("1-->Guardar un solo empleado");
            Console.WriteLine("2--Guardar todos los empleados");
            Console.Write("Introduce una opción de las siguientes:");
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion < 1 || opcion > 2)
                {
                    Console.WriteLine("Esa opción no existe");
                }
            } while (opcion < 1 || opcion > 2);
            if (opcion == 1)
            {
                //Declaro la ruta del archivo
                ruta = ("C:\\Users\\Puesto10\\Desktop\\GITHUB\\.NET-CORE-23-24\\EjercicioObligatorio1\\EjercicioObligatorio1\\Ficheros\\unSoloEmpleado.txt");
                //Pregunto que empleado quiere guardar
                Console.Write("¿Que empleado quiere guardar de la lista?(1..." + listaEmpleados.Count() + ")");
                do
                {
                    numEmpleado = Convert.ToInt32(Console.ReadLine());
                    if (numEmpleado < 1 || numEmpleado > listaEmpleados.Count())
                    {
                        Console.WriteLine("Ese empleado no existe");
                    }
                } while (numEmpleado < 1 || numEmpleado > listaEmpleados.Count());
                sw = File.CreateText(ruta);//Creo el archivo en la ruta
                //Escribo los datos con .ToString()
                sw.WriteLine("--------Empleado Elegido-----------");
                sw.Write(listaEmpleados[numEmpleado-1].ToString());
            }
            else
            {
                ruta = ("C:\\Users\\Puesto10\\Desktop\\GITHUB\\.NET-CORE-23-24\\EjercicioObligatorio1\\EjercicioObligatorio1\\Ficheros\\todosLosEmpleados.txt");
                sw=File.CreateText(ruta);
                sw.WriteLine("--------Lista Empleados-----------");
                //Todos los empleados con un salto de linea
                for (int i = 0; i < listaEmpleados.Count(); i++)
                {
                    sw.WriteLine(listaEmpleados[i].ToString());
                }
            }
            sw.Close();
            Console.WriteLine("Se ha guardado toda la info en la carpeta 'Ficheros' dentro del proyecto");
        }
            public List<Empleados> AsignarNumeroEmpleado(List<Empleados> listaEmpleados)
            {
                for (int i = 0; i < listaEmpleados.Count(); i++)
                {
                listaEmpleados[i].NumEmpleado=i + 1;//se le añade uno al indice para que sea más claro al guardarlo.
                }
                return listaEmpleados;
            }  
    }
}

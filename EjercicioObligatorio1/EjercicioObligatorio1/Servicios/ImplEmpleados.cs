using EjercicioObligatorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1.Servicios
{
    public class ImplEmpleados:IntEmpleados
    {
       public Empleados RegistroEmpleado()
        {
            Empleados nuevoEmpleado=new Empleados();
            Console.WriteLine("Introduce los datos del empleado");
            Console.Write("Nombre del empleado-->");
            nuevoEmpleado.Nombre = Console.ReadLine();
            Console.Write("Apellidos del empleado-->");
            nuevoEmpleado.Apellidos= Console.ReadLine();
            nuevoEmpleado.FechaNac = CrearFecha();
            nuevoEmpleado.Dni = CrearDni();
            return nuevoEmpleado;
        }
        private string CrearDni()
        {
            int numerosDni;
            char letraDNi;
            char Sino;
            int cifras;
            bool estaBien=true;
            do
            {
                numerosDni = Console.ReadLine(); 
            } while (!estaBien);
            return null;
        }
        private string CrearFecha()
        {
            int dia, mes, año;
            año = CapturaEntero("Introduce tu año de nacimiento", 1900, 2100);
            mes = CapturaEntero("Introduce tu mes de nacimiento", 1, 12);
            do
            {
                dia = CapturaEntero("Introduce tu dia de nacimiento",1,31);
                if ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
                    || (dia > 28 && mes == 2))
                    Console.WriteLine("Dia fuera de rango");
            } while ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))|| (dia > 28 && mes == 2)); ;
            return dia + "/" + mes + "/" + año;
        }
        private int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
            } while (!ok);
            //comentario
            return numero;
        }
    }
}

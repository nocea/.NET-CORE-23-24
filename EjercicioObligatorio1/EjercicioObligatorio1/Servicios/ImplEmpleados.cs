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
            Console.Clear();
            Console.Write("Apellidos del empleado-->");
            nuevoEmpleado.Apellidos= Console.ReadLine();
            Console.Clear();
            nuevoEmpleado.FechaNac = CrearFecha();
            nuevoEmpleado.Dni = CrearDni();
            Console.Write("Titulación más alta del empleado-->");
            nuevoEmpleado.Titulacion=Console.ReadLine();
            Console.Clear();
            nuevoEmpleado.NumSegu = CapturaDigito("Introduce tu numero de la Seguridad Social-->",6);
            Console.Clear();
            nuevoEmpleado.NumCuenta = CapturaDigito("Introduce tu numero de tu Cuenta Bancaria",6);
            Console.Clear();
            Console.WriteLine("!Se han guardado tus datos {0}¡",nuevoEmpleado.Nombre);
            Console.WriteLine("Pulsa una tecla para volver al menú");
            Console.ReadKey();
            Console.Clear();
            return nuevoEmpleado;
        }
        public List<Empleados> ModificarEmpleados(List<Empleados> listaEmpleados)
        {
            int numeroEmpleado;
            int opcion;
            Empleados empleadoMod;
            numeroEmpleado = CapturaEntero("Introduzca su numero de empleado",1,listaEmpleados.Count());
            numeroEmpleado = numeroEmpleado - 1;
            do
            {
                Console.WriteLine("¿Qué quieres modificar?");
                Console.WriteLine("1-->Nombre.");
                Console.WriteLine("2-->Apellidos.");
                Console.WriteLine("3-->Fecha Nacimiento.");
                Console.WriteLine("4-->DNI Empleado.");
                Console.WriteLine("5-->Titulacion.");
                Console.WriteLine("6-->Numero Seguridad Social.");
                Console.WriteLine("7-->Numero Cuenta Bancaria.");
                Console.WriteLine("0-->Volver al menu.");
                opcion = CapturaEntero("Introduzca una opción de las siguientes", 0, 7);
                empleadoMod = listaEmpleados[numeroEmpleado];
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre actual-->" + empleadoMod.Nombre);
                        Console.Write("Nuevo nombre-->");
                        empleadoMod.Nombre = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Apellidos actual-->" + empleadoMod.Apellidos);
                        Console.WriteLine("Nuevos Apellidos-->");
                        empleadoMod.Apellidos = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Fecha actual-->" + empleadoMod.FechaNac);
                        Console.WriteLine("Nueva Fecha-->");
                        empleadoMod.FechaNac= CrearFecha();
                        break;
                    case 4:
                        Console.WriteLine("DNI actual-->" + empleadoMod.Dni);
                        Console.WriteLine("Nuevo DNI-->");
                        empleadoMod.Dni=CrearDni();
                        break;
                    case 5:
                        Console.WriteLine("Titulacion actual-->" + empleadoMod.Titulacion);
                        Console.WriteLine("Nueva titulacion-->");
                        empleadoMod.Titulacion = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Numero SS actual-->" + empleadoMod.NumSegu);
                        Console.WriteLine("Nuevo numero-->");
                        empleadoMod.NumSegu = CapturaDigito("Introduce tu numero la Seguridad Social", 6);
                        break;
                    case 7:
                        Console.WriteLine("Numero cuenta actual-->" + empleadoMod.NumCuenta);
                        Console.WriteLine("Nuevo numero-->");
                        empleadoMod.NumCuenta= CapturaDigito("Introduce tu numero de tu Cuenta Bancaria", 6);
                        break;
                }
            } while (opcion != 0);
            return listaEmpleados;
        }
        private string CrearDni()
        {
            int numeroDni;
            char letraDni;
            char sino;
            bool estaBien=true;
            do
            {
                numeroDni = CapturaDigito("Introduzca el numero de su dni", 8);
                Console.WriteLine("Introduce la letra de tu dni");
                letraDni = Console.ReadKey(true).KeyChar;
                do
                {
                    
                    Console.WriteLine("¿Es correcto tu DNI(s/n)?-->" + numeroDni + "-" + letraDni + ":");
                    sino = Console.ReadKey(true).KeyChar;
                    sino = Char.ToLower(sino);
                    
                    if (sino != 's' && sino != 'n')
                    {
                        Console.WriteLine("Debe introducir 's' para aceptar y 'n' para volver a introducir su dni");
                        estaBien = false;
                    }
                    else
                    {
                        if (sino == 'n')
                        {
                            estaBien = false;
                        }
                        else
                        {
                            estaBien = true;
                        }
                    }
                } while (sino != 's' && sino != 'n');
            } while (!estaBien);
            Console.Clear();
            return numeroDni+"-"+letraDni;
        }
        private string CrearFecha()
        {
            int dia, mes, año;
            año = CapturaEntero("Introduce tu año de nacimiento", 1900, 2100);
            mes = CapturaEntero("Introduce tu mes de nacimiento", 1, 12);
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dia = CapturaEntero("Introduce tu dia de nacimiento", 1, 30);
            }
            else if (mes == 2)
            {
                dia = CapturaEntero("Introduce tu dia de nacimiento", 1, 28);
            }
            else
            {
                dia = CapturaEntero("Introduce tu dia de nacimiento", 1, 31);
            }
            return dia + "/" + mes + "/" + año;
        }
        public int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
            } while (!ok);
            Console.Clear();
            return numero;
        }
        public int CapturaDigito(string txt,int numDigitos)
        {
            int numero;
            do
            {
                Console.WriteLine("{0}[{1} digitos]", txt, numDigitos);
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero.ToString().Length != numDigitos)
                {
                    Console.WriteLine("El número que ha indicado no cumple con los digitos");
                }
            } while (numero.ToString().Length != numDigitos);
            return numero;
        } 
    }
}

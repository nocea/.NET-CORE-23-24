using EjercicioObligatorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1.Servicios
{
    internal interface IntEmpleados
    {   /*Metodo que no recibe nada (introduzco los datos de cada atributo de empleado)
         y devuelvo un objeto de empleado*/
        Empleados RegistroEmpleado();
        /*Metodo que recibe:
         -txt=mensaje que se quiere mostrar
         -min=valor minimo del int
         -max=valor maximo del int
          Devuelve el int ya comprobado que esta entre el min y el max*/
        int CapturaEntero(string txt, int min, int max);
        /*Metodo para modificar todos los atributos que se hayan introducido previamente
         en el registro de empleados*/
        List<Empleados> ModificarEmpleados(List<Empleados> listaEmpleados);
    }
}

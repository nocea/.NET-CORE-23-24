using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorioRepaso.Entidades
{
    internal class Empleados
    {
        private string nombre, apellido, dni, titulacion;
        private int numSegu, numCuenta,dia,mes,año;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Titulacion { get => titulacion; set => titulacion = value; }
        public int NumSegu { get => numSegu; set => numSegu = value; }
        public int NumCuenta { get => numCuenta; set => numCuenta = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Año { get => año; set => año = value; }
    }
}

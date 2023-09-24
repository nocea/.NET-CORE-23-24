using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObligatorio1.Entidades
{
    public class Empleados
    {
        private String nombre, apellidos, dni, titulacion, fechaNac;
        private int numEmpleado;
        private long numSegu, numCuenta;

        public Empleados(string nombre, string apellidos, string dni, string titulacion, string fechaNac, int numEmpleado, long numSegu, long numCuenta)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.titulacion = titulacion;
            this.fechaNac = fechaNac;
            this.numEmpleado = numEmpleado;
            this.numSegu = numSegu;
            this.numCuenta = numCuenta;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Titulacion { get => titulacion; set => titulacion = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public int NumEmpleado { get => numEmpleado; set => numEmpleado = value; }
        public long NumSegu { get => numSegu; set => numSegu = value; }
        public long NumCuenta { get => numCuenta; set => numCuenta = value; }
    }
}

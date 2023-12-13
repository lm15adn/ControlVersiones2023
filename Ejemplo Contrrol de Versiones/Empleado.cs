﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Contrrol_de_Versiones
{
    abstract class Empleado
    {

        public Empleado() { 
        
        }

        protected Empleado(string tipoEmpleado, string nombre, char genero, double salario)
        {
            TipoEmpleado = tipoEmpleado;
            Nombre = nombre;
            Genero = genero;
            Salario = salario;

        }

        public string TipoEmpleado { get; set; }

        public string Nombre { get; set; }

        public char Genero { get; set; }

        public double Salario { get; set; }

        public abstract double CalcularSalario();




    }
}

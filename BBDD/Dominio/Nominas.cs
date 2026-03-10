using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class Nominas
    {
        public int id {  get; set; }
        public Empleado empleado { get; set; }
        public int anioPago { get; set; }
        
        public int mesPago { get; set; }

        public decimal salarioBruto { get; set; }

        public decimal salarioNeto { get; set; }

        public decimal salarioBonus { get; set; }


        public Nominas ()
        {
            empleado = new Empleado ();
            anioPago = 0;
            mesPago = 0;
            salarioBruto = 0;
            salarioNeto = 0;
            salarioBonus = 0;


        }

        public Nominas (int idNominas)
        {
            id = idNominas;
            empleado = new Empleado();
            anioPago = 0;
            mesPago = 0;
            salarioBruto = 0;
            salarioNeto = 0;
            salarioBonus = 0;

        }
    }

   
}

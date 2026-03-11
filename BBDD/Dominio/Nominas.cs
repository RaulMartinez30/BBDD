using System;
using System.Collections.Generic;

namespace BBDD.Dominio
{
    internal class Nominas
    {
      
        public int id { get; set; }
        public Empleado empleado { get; set; }
        public int anioPago { get; set; }
        public int mesPago { get; set; }
        public decimal salarioBruto { get; set; }
        public decimal salarioNeto { get; set; }
        public decimal salarioBonus { get; set; }

        public Nominas()
        {
            empleado = new Empleado();
            anioPago = 0;
            mesPago = 0;
            salarioBruto = 0;
            salarioNeto = 0;
            salarioBonus = 0;
        }

        public Nominas(int idNominas)
        {
            id = idNominas;
            empleado = new Empleado();
            anioPago = 0;
            mesPago = 0;
            salarioBruto = 0;
            salarioNeto = 0;
            salarioBonus = 0;
        }

        public bool CheckIfNominaExists(int anio, int mes)
        {
            NominasDao dao = new NominasDao();
            return dao.ExisteNominaMes(anio, mes);
        }

        public int GenerarNominasMes(int anio, int mes)
        {
            NominasDao dao = new NominasDao();

            int totalDiasMes = DateTime.DaysInMonth(anio, mes);
            DateTime primerDiaMes = new DateTime(anio, mes, 1);
            DateTime ultimoDiaMes = new DateTime(anio, mes, totalDiasMes);

            List<int> empleados = dao.GetEmpleadosActivosEnMes(anio, mes);

            List<Nominas> nominasAInsertar = new List<Nominas>();

            for (int i = 0; i < empleados.Count; i++)
            {
                int idEmpleado = empleados[i];

             
                List<PuestoMes> puestos = dao.GetPuestosDeEmpleadoEnMes(idEmpleado, anio, mes);

             
                int diasTotales = dao.GetDiasTrabajadosHasta(idEmpleado, ultimoDiaMes);
                int trienios = diasTotales / 1095;

                decimal salarioBrutoMes = 0m;
                decimal bonusAplicado = 0m;

                for (int j = 0; j < puestos.Count; j++)
                {
                    PuestoMes p = puestos[j];

        
                    DateTime inicio = p.FechaInicio;
                    if (inicio < primerDiaMes)
                        inicio = primerDiaMes;

                    DateTime fin = ultimoDiaMes;
                    if (p.FechaFin.HasValue && p.FechaFin.Value < ultimoDiaMes)
                        fin = p.FechaFin.Value;

                    int diasEnPuesto = (int)(fin - inicio).TotalDays + 1;
                    if (diasEnPuesto <= 0) continue;

                    decimal proporcion = (decimal)diasEnPuesto / totalDiasMes;
                    decimal salarioMensual = p.SalarioAnual / 12m;
                    decimal aporteBase = salarioMensual * proporcion;
                    decimal bonusPorcentaje = p.BonusBase * trienios;
                    decimal aporteBonus = aporteBase * bonusPorcentaje;

                    salarioBrutoMes += aporteBase + aporteBonus;
                    bonusAplicado += bonusPorcentaje * proporcion;
                }

                decimal tasaImpuesto = dao.GetTasaImpuesto(idEmpleado, anio, mes);
                decimal salarioNeto = salarioBrutoMes * (1m - tasaImpuesto);

                Nominas n = new Nominas();
                n.empleado = new Empleado();
                n.empleado.Id = idEmpleado;
                n.anioPago = anio;
                n.mesPago = mes;
                n.salarioBruto = Math.Round(salarioBrutoMes, 2);
                n.salarioNeto = Math.Round(salarioNeto, 2);
                n.salarioBonus = Math.Round(bonusAplicado, 4);

                nominasAInsertar.Add(n);
            }

            if (nominasAInsertar.Count > 0)
                dao.InsertarNominas(nominasAInsertar);

            return nominasAInsertar.Count;
        }
    }

    internal class PuestoMes
    {
        public int IdEmpleado { get; set; }
        public decimal SalarioAnual { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal BonusBase { get; set; }  
    }
}
using System;
using System.Collections.Generic;
using System.Text;

using Company.persistence;
using System;
using System.Collections.Generic;

namespace BBDD.Dominio
{
    internal class NominasDao
    {
        AgenteBD agente = AgenteBD.GetInstance();

        // Verificador de Nominas Año-Mes
        public bool ExisteNominaMes(int anio, int mes)
        {
            string sql = "SELECT COUNT(*) FROM MonthlyPayments WHERE payYear = " + anio + " AND payMonth = " + mes;
            List<string[]> result = agente.Read(sql);
            return int.Parse(result[0][0]) > 0;
        }

        // IDs de empleados con algún puesto activo en el mes
        public List<int> GetEmpleadosActivosEnMes(int anio, int mes)
        {
            DateTime primerDia = new DateTime(anio, mes, 1);
            DateTime ultimoDia = new DateTime(anio, mes, DateTime.DaysInMonth(anio, mes));

            string sql = "SELECT DISTINCT posEmployee FROM Positions " +
                         "WHERE posStartDate <= '" + ultimoDia.ToString("yyyy-MM-dd") + "' " +
                         "AND (posEndDate IS NULL OR posEndDate >= '" + primerDia.ToString("yyyy-MM-dd") + "')";

            List<int> lista = new List<int>();
            List<string[]> result = agente.Read(sql);
            for (int i = 0; i < result.Count; i++)
                lista.Add(int.Parse(result[i][0]));

            return lista;
        }

        // Puestos activos de un empleado concreto en el mes
        public List<PuestoMes> GetPuestosDeEmpleadoEnMes(int idEmpleado, int anio, int mes)
        {
            DateTime primerDia = new DateTime(anio, mes, 1);
            DateTime ultimoDia = new DateTime(anio, mes, DateTime.DaysInMonth(anio, mes));

            string sql = "SELECT p.posYearSalary, p.posStartDate, p.posEndDate, o.offThreeYearBonus " +
                         "FROM Positions p JOIN Offices o ON o.idOffice = p.posOffice " +
                         "WHERE p.posEmployee = " + idEmpleado + " " +
                         "AND p.posStartDate <= '" + ultimoDia.ToString("yyyy-MM-dd") + "' " +
                         "AND (p.posEndDate IS NULL OR p.posEndDate >= '" + primerDia.ToString("yyyy-MM-dd") + "')";

            List<PuestoMes> lista = new List<PuestoMes>();
            List<string[]> result = agente.Read(sql);

            for (int i = 0; i < result.Count; i++)
            {
                PuestoMes p = new PuestoMes();
                p.IdEmpleado = idEmpleado;
                p.SalarioAnual = decimal.Parse(result[i][0]);
                p.FechaInicio = DateTime.Parse(result[i][1]);
                p.FechaFin = result[i][2] == "" ? (DateTime?)null : DateTime.Parse(result[i][2]);
                p.BonusBase = decimal.Parse(result[i][3]) / 100;
                lista.Add(p);
            }
            return lista;
        }

        // Días totales trabajados hasta una fecha (trienios)
        public int GetDiasTrabajadosHasta(int idEmpleado, DateTime fechaLimite)
        {
            string limite = fechaLimite.ToString("yyyy-MM-dd");
            string sql = "SELECT SUM(DATEDIFF(LEAST(IFNULL(posEndDate, '" + limite + "'), '" + limite + "'), posStartDate) + 1) " +
                         "FROM Positions " +
                         "WHERE posEmployee = " + idEmpleado + " AND posStartDate <= '" + limite + "'";

            List<string[]> result = agente.Read(sql);
            if (result.Count == 0 || result[0][0] == "") return 0;
            return int.Parse(result[0][0]);
        }

        // Tasa de impuesto del empleado
        public decimal GetTasaImpuesto(int idEmpleado, int anio, int mes)
        {
            DateTime primerDia = new DateTime(anio, mes, 1);
            DateTime ultimoDia = new DateTime(anio, mes, DateTime.DaysInMonth(anio, mes));

            string sql = "SELECT c.couTaxBase FROM Positions p " +
                         "JOIN Offices o ON o.idOffice = p.posOffice " +
                         "JOIN Countries c ON c.idCountry = o.offCountry " +
                         "WHERE p.posEmployee = " + idEmpleado + " " +
                         "AND p.posStartDate <= '" + ultimoDia.ToString("yyyy-MM-dd") + "' " +
                         "AND (p.posEndDate IS NULL OR p.posEndDate >= '" + primerDia.ToString("yyyy-MM-dd") + "') " +
                         "LIMIT 1";

            List<string[]> result = agente.Read(sql);
            if (result.Count == 0) return 0;
            return decimal.Parse(result[0][0]) / 100;
        }

        // Insertar nóminas en BD
        public void InsertarNominas(List<Nominas> nominas)
        {
            for (int i = 0; i < nominas.Count; i++)
            {
                Nominas n = nominas[i];
                string sql = "INSERT INTO MonthlyPayments (payEmployee, payYear, payMonth, paySalaryGross, paySalaryNet, payBonusApplied) " +
                             "VALUES (" + n.empleado.Id + ", " + n.anioPago + ", " + n.mesPago + ", " +
                             n.salarioBruto.ToString().Replace(",", ".") + ", " +
                             n.salarioNeto.ToString().Replace(",", ".") + ", " +
                             n.salarioBonus.ToString().Replace(",", ".") + ")";
                agente.Change(sql);
            }
        }
    }
}

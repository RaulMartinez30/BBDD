using Company.persistence;
using System;
using System.Collections.Generic;
using System.Data;

namespace BBDD.Dominio
{
    internal class InformesDao
    {
        AgenteBD agente = AgenteBD.GetInstance();

        // INFORME 1: Nóminas de un mes ordenadas de mayor a menor
        // idOficina == -1 == todas las oficinas
        public DataTable GetNominasPorMes(int anio, int mes, int idOficina)
        {
            string mesStr = mes.ToString("D2");
            string filtroOficina;
            if (idOficina != -1)
            {
                filtroOficina = " AND o.idOffice = " + idOficina;
            }
            else
            {
                filtroOficina = "";
            }

            string sql =
                "SELECT e.empName, o.offCity, mp.payYear, mp.payMonth, mp.paySalaryGross, mp.paySalaryNet, mp.payBonusApplied " +
                "FROM MonthlyPayments mp " +
                "JOIN Employees e ON e.idEmployee = mp.payEmployee " +
                "JOIN Positions p ON p.posEmployee = mp.payEmployee " +
                "AND p.posStartDate <= LAST_DAY('" + anio + "-" + mesStr + "-01') " +
                "AND (p.posEndDate IS NULL OR p.posEndDate >= '" + anio + "-" + mesStr + "-01') " +
                "JOIN Offices o ON o.idOffice = p.posOffice " +
                "WHERE mp.payYear = " + anio + " AND mp.payMonth = " + mes + filtroOficina +
                " ORDER BY mp.paySalaryGross DESC";

            List<string[]> data = agente.Read(sql);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("Oficina");
            tabla.Columns.Add("Año");
            tabla.Columns.Add("Mes");
            tabla.Columns.Add("Salario Bruto");
            tabla.Columns.Add("Salario Neto");
            tabla.Columns.Add("Bonus Aplicado");

            for (int i = 0; i < data.Count; i++)
            {
                string[] row = data[i];

                tabla.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }

            return tabla;
        }

        // INFORME 2: Todas las nóminas de un Solo empleado
        public DataTable GetNominasPorEmpleado(int idEmpleado)
        {
            string sql =
                "SELECT e.empName, mp.payYear, mp.payMonth, " +
                "mp.paySalaryGross, mp.paySalaryNet, mp.payBonusApplied " +
                "FROM MonthlyPayments mp " +
                "JOIN Employees e ON e.idEmployee = mp.payEmployee " +
                "WHERE mp.payEmployee = " + idEmpleado + " " +
                "ORDER BY mp.payYear DESC, mp.payMonth DESC";

            List<string[]> data = agente.Read(sql);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("Año");
            tabla.Columns.Add("Mes");
            tabla.Columns.Add("Salario Bruto");
            tabla.Columns.Add("Salario Neto");
            tabla.Columns.Add("Bonus Aplicado");

            for (int i = 0; i < data.Count; i++)
            {
                string[] row = data[i];

                tabla.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }

            return tabla;
        }

        // INFORME 3: Empleados y trienios agrupados por sede
        public DataTable GetEmpleadosConTrienios()
        {
            string hoy = DateTime.Now.ToString("yyyy-MM-dd");

            string sql =
                "SELECT o.offCity, e.empName, " +
                "FLOOR(SUM(DATEDIFF(LEAST(IFNULL(p.posEndDate, '" + hoy + "'), '" + hoy + "'), p.posStartDate) + 1) / 1095) AS trienios " +
                "FROM Positions p " +
                "JOIN Employees e ON e.idEmployee = p.posEmployee " +
                "JOIN Offices   o ON o.idOffice   = p.posOffice " +
                "WHERE p.posStartDate <= '" + hoy + "' " +
                "GROUP BY o.idOffice, o.offCity, e.idEmployee, e.empName " +
                "ORDER BY o.offCity, e.empName";

            List<string[]> data = agente.Read(sql);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Oficina");
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("Trienios");

            for (int i = 0; i < data.Count; i++)
            {
                string[] row = data[i];

                tabla.Rows.Add(row[0], row[1], row[2]);
            }

            return tabla;
        }

        // INFORME 4: Gasto total de una oficina en un mes
        public DataTable GetGastoOficinaMes(int anio, int mes, int idOficina)
        {
            string mesStr = mes.ToString("D2");

            string sql =
                "SELECT o.offCity, mp.payYear, mp.payMonth, " +
                "COUNT(mp.idMonthlyPayment), SUM(mp.paySalaryGross), SUM(mp.paySalaryNet) " +
                "FROM MonthlyPayments mp " +
                "JOIN Positions p ON p.posEmployee = mp.payEmployee " +
                "AND p.posStartDate <= LAST_DAY('" + anio + "-" + mesStr + "-01') " +
                "AND (p.posEndDate IS NULL OR p.posEndDate >= '" + anio + "-" + mesStr + "-01') " +
                "JOIN Offices o ON o.idOffice = p.posOffice " +
                "WHERE mp.payYear = " + anio + " AND mp.payMonth = " + mes +
                "AND o.idOffice = " + idOficina + " " +
                "GROUP BY o.idOffice, o.offCity, mp.payYear, mp.payMonth";

            List<string[]> data = agente.Read(sql);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Oficina");
            tabla.Columns.Add("Año");
            tabla.Columns.Add("Mes");
            tabla.Columns.Add("Nº Nóminas");
            tabla.Columns.Add("Total Bruto");
            tabla.Columns.Add("Total Neto");

            for (int i = 0; i < data.Count; i++)
            {
                string[] row = data[i];

                tabla.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }

            return tabla;
        }

        // INFORME 5: Gasto en nóminas por país en todos los meses
        public DataTable GetGastoPorPaisMes()
        {
            string sql =
                "SELECT c.couName, mp.payYear, mp.payMonth, " +
                "COUNT(mp.idMonthlyPayment), SUM(mp.paySalaryGross), SUM(mp.paySalaryNet) " +
                "FROM MonthlyPayments mp " +
                "JOIN Positions p ON p.posEmployee = mp.payEmployee " +
                "AND p.posStartDate <= LAST_DAY(CONCAT(mp.payYear, '-', LPAD(mp.payMonth, 2, '0'), '-01')) " +
                "AND (p.posEndDate IS NULL OR p.posEndDate >= CONCAT(mp.payYear, '-', LPAD(mp.payMonth, 2, '0'), '-01')) " +
                "JOIN Offices   o ON o.idOffice  = p.posOffice " +
                "JOIN Countries c ON c.idCountry = o.offCountry " +
                "GROUP BY c.idCountry, c.couName, mp.payYear, mp.payMonth " +
                "ORDER BY c.couName, mp.payYear DESC, mp.payMonth DESC";

            List<string[]> data = agente.Read(sql);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("País");
            tabla.Columns.Add("Año");
            tabla.Columns.Add("Mes");
            tabla.Columns.Add("Nº Nóminas");
            tabla.Columns.Add("Total Bruto");
            tabla.Columns.Add("Total Neto");

            for (int i = 0; i < data.Count; i++)
            {
                string[] row = data[i];

                tabla.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }

            return tabla;
        }
    }
}
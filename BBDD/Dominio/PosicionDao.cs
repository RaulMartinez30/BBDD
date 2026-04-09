using Company.persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class PosicionDao
    {
        public PosicionDao() { }

        public List<Posicion> ReadAll()
        {
            List<Posicion> resultado = new List<Posicion>();
            string sql = "SELECT p.*, e.empName FROM positions p JOIN employees e ON p.posEmployee = e.idEmployee";
            List<string[]> data = AgenteBD.GetInstance().Read(sql);

            foreach (string[] row in data)
            {
                Posicion p = new Posicion(int.Parse(row[0]));
                p.empleado = new Empleado(int.Parse(row[1]));

                p.empleado.Name = row[7];

                p.oficina = new Oficina(int.Parse(row[2]));
                p.Name = row[3];
                p.YearSalary = Convert.ToDecimal(row[4]);
                p.StartDate = Convert.ToDateTime(row[5]);

                if (string.IsNullOrEmpty(row[6]))
                    p.EndDate = null;
                else
                    p.EndDate = Convert.ToDateTime(row[6]);

                resultado.Add(p);
            }
            return resultado;
        }

        public int Insert(Posicion p)
        {
            string endDateSql;
            if (p.EndDate == null)
            {
                endDateSql = "NULL";
            }
            else
            {
                // Si no es null, le ponemos las comillas
                endDateSql = "'" + p.EndDate.Value.ToString("yyyy-MM-dd") + "'";
            }

            string sql = "INSERT INTO positions VALUES (" +
                         p.Id + ", " +
                         p.empleado.Id + ", " +
                         p.oficina.Id + ", '" +
                         p.Name + "', " +
                         p.YearSalary + ", '" +
                         p.StartDate.ToString("yyyy-MM-dd") + "', " +
                         endDateSql + ")";

            return AgenteBD.GetInstance().Change(sql);
        }

        public int Update(Posicion p)
        {
            string endDateSql;
            if (p.EndDate == null)
            {
                endDateSql = "NULL";
            }
            else
            {
                // Si hay fecha, le metemos el formato
                endDateSql = "'" + p.EndDate.Value.ToString("yyyy-MM-dd") + "'";
            }

            string sql = "UPDATE positions SET " +
                         "posEmployee = " + p.empleado.Id + ", " +
                         "posOffice = " + p.oficina.Id + ", " +
                         "posName = '" + p.Name + "', " +
                         "posYearSalary = " + p.YearSalary.ToString().Replace(",", ".") + ", " +
                         "posStartDate = '" + p.StartDate.ToString("yyyy-MM-dd") + "', " +
                         "posEndDate = " + endDateSql +
                         " WHERE idPosition = " + p.Id;

            return AgenteBD.GetInstance().Change(sql);
        }

        public int Delete(Posicion p)
        {
            string sql = "DELETE FROM positions WHERE idPosition = " + p.Id;
            return AgenteBD.GetInstance().Change(sql);
        }

        internal bool CheckIfIdExists(int id)
        {
            string sql = "SELECT * FROM positions WHERE idPosition = " + id;
            List<string[]> data = AgenteBD.GetInstance().Read(sql);
            return data.Count > 0;
        }
    }
}
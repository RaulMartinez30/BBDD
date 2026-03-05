using Company.persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class EmpleadoDao
    {
        public EmpleadoDao() { }

        public List<Empleado> ReadAll()
        {
            List<Empleado> resultado = new List<Empleado>();
            string sql = "SELECT * FROM employees";
            List<string[]> data = AgenteBD.GetInstance().Read(sql);
            foreach (string[] row in data)
            {
                Empleado e = new Empleado (int.Parse(row[0]));
                e.Name = row[1];
                e.pais = new Pais(row[2]);
                e.IBAN = row[3];
                resultado.Add(e);
            }
            return resultado;
        }

        public int Insert(Empleado e)
        {

            string sql = "INSERT INTO employees VALUES (" + e.Id + ", '" + e.Name + "', '" + e.pais.Id + "', '" + e.IBAN + "')";
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Update(Empleado e)
        {
            string sql = "UPDATE employees SET empName = '" + e.Name + "', empCountry = '" + e.pais.Id + "', empIBAN = '" + e.IBAN + "' WHERE idEmployee = " + e.Id;
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Delete(Empleado e)
        {
            string sql = "DELETE FROM employees WHERE idEmployee = " + e.Id;
            return AgenteBD.GetInstance().Change(sql);
        }

        internal bool CheckIfIdExists(int id)
        {
            string sql = "SELECT * FROM employees WHERE idEmployee = " + id;
            List<String[]> data = AgenteBD.GetInstance().Read(sql);
            return data.Count > 0;
        }
    }
}

using Company.persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class paisDao
    {
        public paisDao() { }

        public List<Pais> ReadAll()
        {
            List<Pais> resultado = new List<Pais>();
            string sql = "SELECT * FROM countries";
            List<string[]> data = AgenteBD.GetInstance().Read(sql);
            foreach (string[] row in data)
            {
                Pais p = new Pais(row[0]);
                p.Name = row[1];
                p.Impuestos = Convert.ToDecimal(row[2]);
                resultado.Add(p);
            }
            return resultado;
        }

        public void Read(Pais p)
        {
            string sql = "SELECT * FROM countries WHERE idCountry = '" + p.Id + "'";
            List<String[]> data = AgenteBD.GetInstance().Read(sql);
            if (data.Count > 0)
            {
                String[] row = data[0];
                p.Name = row[1];
                p.Impuestos = Convert.ToDecimal(row[2]);
            }
        }

        public int Insert(Pais p)
        {
            
            string sql = "INSERT INTO countries VALUES ('" + p.Id + "', '" + p.Name + "', " + p.Impuestos + ")";
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Update(Pais p)
        {
            
            string sql = "UPDATE countries SET couName = '" + p.Name + "', couTaxBase = " + p.Impuestos + " WHERE idCountry = '" + p.Id + "'";
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Delete(Pais p)
        {
            string sql = "DELETE FROM countries WHERE idCountry = '" + p.Id + "'";
            return AgenteBD.GetInstance().Change(sql);
        }

        internal bool CheckIfIdExists(String id)
        {
            string sql = "SELECT * FROM countries WHERE idCountry = '" + id + "'";
            List<String[]> data = AgenteBD.GetInstance().Read(sql);
            return data.Count > 0;
        }
    }
}
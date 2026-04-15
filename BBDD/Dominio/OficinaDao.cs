using Company.persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class OficinaDao
    {

        public OficinaDao() { }

        public static List<Oficina> ReadAll()
        {
            List<Oficina> resultado = new List<Oficina>();
            string sql = "SELECT * FROM offices";
            List<string[]> data = AgenteBD.GetInstance().Read(sql);
            foreach (string[] row in data)
            {
                Oficina o = new Oficina(int.Parse(row[0]));
                o.pais = new Pais (row[1]);
                o.NameCiudad = row[2];
                o.Direccion = row[3];
                o.Bonus = (int)Convert.ToDecimal(row[4]);
                resultado.Add(o);
                }
                return resultado;   
        }

        public static int Insert(Oficina o)
        {

            string sql = "INSERT INTO offices VALUES ('" + o.Id + "', '" + o.pais + "', '" + o.NameCiudad + " ' , '" +o.Direccion+" ' , "+o.Bonus+ ")";
            return AgenteBD.GetInstance().Change(sql);
        }

        public static  int Update(Oficina o)
        {

            string sql = "UPDATE offices SET offCountry = '" + o.pais.Id + "', offCity = '" + o.NameCiudad + "', offAddress = '" + o.Direccion + "', offThreeYearBonus = " + o.Bonus.ToString().Replace(",", ".") + " WHERE idOffice = " + o.Id;
            return AgenteBD.GetInstance().Change(sql);
        }

        public static int Delete(Oficina o)
        {
            string sql = "DELETE FROM offices WHERE idOffice = '" + o.Id + "'";
            return AgenteBD.GetInstance().Change(sql);
        }

        internal static  bool CheckIfIdExists(int id)
        {
            string sql = "SELECT * FROM offices WHERE idOffice = '" + id + "'";
            List<String[]> data = AgenteBD.GetInstance().Read(sql);
            return data.Count > 0;
        }
    }
}

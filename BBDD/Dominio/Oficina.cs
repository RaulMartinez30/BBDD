using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BBDD.Dominio
{
    internal class Oficina
    {
        public int Id { get; set; }
        public Pais pais {  get; set; }
        public String NameCiudad { get; set; }
        public String Direccion { get; set; }
        public decimal Bonus { get; set; }

        private readonly OficinaDao DaoOficina;

        public Oficina()
        {
            pais = new Pais();
            NameCiudad = "";
            Direccion = "";
            Bonus = 0;
            DaoOficina = new OficinaDao();
        }
        public override string ToString()
        {
            return $"{Id} - {NameCiudad}";
        }
        public Oficina(int  idOficina)
        {
            Id = idOficina;
            pais = new Pais();
            NameCiudad = "";
            Direccion = "";
            Bonus = 0;
            DaoOficina = new OficinaDao();
        }
        public int InsertOficina()
        {
            return OficinaDao.Insert(this);
        }

        public int UpdateOficina()
        {
            return OficinaDao.Update(this);
        }

        public List<Oficina> ReadAllOficinas()
        {
            return OficinaDao.ReadAll();
        }


        public int DeleteOficina()
        {
            return OficinaDao.Delete(this);
        }

        public bool CheckIfIdExists(int id)
        {
            return OficinaDao.CheckIfIdExists(id);

        }

    }
}

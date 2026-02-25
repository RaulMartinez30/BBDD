using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BBDD.Dominio
{
    internal class Pais
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public decimal Impuestos { get; set; }
        private readonly paisDao _dao;

        public Pais()
        {
            Id = "";
            Name = "";
            Impuestos = 0;
            _dao = new paisDao();
        }
        public Pais(String idPais)
        {
            Id = idPais;
            Name = "";
            Impuestos = 0;
            _dao = new paisDao();
        }

        public List<Pais> ReadAllPaises()
        {

        }

        public int UpdatePais()
        {
            return _dao.Update(this);
        }

        public int DeletePais()
        {
            return _dao.Delete(this);
        }

        public bool CheckIfIdExists(string id)
        {
            return _dao.CheckIfIdExists(id);

        }

        public override string ToString()
        {
            return Id;
        }
    }
}

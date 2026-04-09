using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class Posicion
    {
        public int Id { get; set; }
        public Empleado empleado { get; set; }
        public Oficina oficina { get; set; }
        public String Name { get; set; }
        public decimal YearSalary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        private readonly PosicionDao _dao;

        public Posicion()
        {
            Id = 0;
            empleado = new Empleado();
            oficina = new Oficina();
            Name = "";
            YearSalary = 0;
            StartDate = DateTime.Now;
            EndDate = null;
            _dao = new PosicionDao();
        }

        public Posicion(int idPosicion)
        {
            Id = idPosicion;
            empleado = new Empleado();
            oficina = new Oficina();
            Name = "";
            YearSalary = 0;
            StartDate = DateTime.Now;
            EndDate = null;
            _dao = new PosicionDao();
        }

        public List<Posicion> ReadAllPosiciones()
        {
            return _dao.ReadAll();
        }

        public int InsertPosicion()
        {
            return _dao.Insert(this);
        }

        public int UpdatePosicion()
        {
            return _dao.Update(this);
        }

        public int DeletePosicion()
        {
            return _dao.Delete(this);
        }

        public bool CheckIfIdExists(String id)
        {
            return _dao.CheckIfIdExists(int.Parse(id));
        }

        public override string ToString()
        {
            return Id + " - " + Name + " - " + empleado.Name;
        }
    }
}
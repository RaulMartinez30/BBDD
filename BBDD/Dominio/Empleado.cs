using System;
using System.Collections.Generic;
using System.Text;

namespace BBDD.Dominio
{
    internal class Empleado
    {
        public int Id {  get; set; }
        public String Name { get; set; }
        public String IBAN { get; set; }
        public Pais pais { get; set; }
        private readonly EmpleadoDao _dao;

        public Empleado ()
        {
            Id = 0;
            Name = "";
            IBAN = "";
            pais = new Pais();
            _dao = new EmpleadoDao();
        }

        public Empleado (int idEmpleado)
        {
            Id = idEmpleado;
            Name = "";
            IBAN = "";
            pais = new Pais();
            _dao = new EmpleadoDao();
        }

        public List<Empleado> ReadAllEmpleados()
        {
            return _dao.ReadAll();
        }

        public int InsertEmpleado()
        {
            return _dao.Insert(this);
        }

        public int UpdateEmpleado()
        {
            return _dao.Update(this);
        }

        public int DeleteEmpleado()
        {
            return _dao.Delete(this);
        }

        public bool CheckIfIdExists(String id)
        {
            return _dao.CheckIfIdExists(int.Parse(id));
        }

        public override string ToString()
        {
            return Id + " - " + Name;
        }
    }
}

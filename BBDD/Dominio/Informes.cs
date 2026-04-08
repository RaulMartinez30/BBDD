using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BBDD.Dominio
{
    internal class Informes
    {
        private readonly InformesDao _dao;

        public Informes()
        {
            _dao = new InformesDao();
        }

        // Informe 1: nóminas de un mes, opcionalmente filtradas por oficina
        // idOficina = -1 significa "todas las oficinas"
        public DataTable GetNominasPorMes(int anio, int mes, int idOficina)
        {
            return _dao.GetNominasPorMes(anio, mes, idOficina);
        }

        // Informe 2: todas las nóminas de un empleado concreto
        public DataTable GetNominasPorEmpleado(int idEmpleado)
        {
            return _dao.GetNominasPorEmpleado(idEmpleado);
        }

        // Informe 3: empleados agrupados por sede con sus trienios
        public DataTable GetEmpleadosConTrienios()
        {
            return _dao.GetEmpleadosConTrienios();
        }

        // Informe 4: gasto total de una oficina en un mes concreto
        public DataTable GetGastoOficinaMes(int anio, int mes, int idOficina)
        {
            return _dao.GetGastoOficinaMes(anio, mes, idOficina);
        }

        // Informe 5: gasto por país en todos los meses con datos
        public DataTable GetGastoPorPaisMes()
        {
            return _dao.GetGastoPorPaisMes();
        }
    }
}
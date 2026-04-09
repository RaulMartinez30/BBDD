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

        // Informe 1: nominas de un mes
        // idOficina = -1 == todas las oficinas
        public DataTable GetNominasPorMes(int anio, int mes, int idOficina)
        {
            return _dao.GetNominasPorMes(anio, mes, idOficina);
        }

        // Informe 2: todas las nominas de un Solo empleado 
        public DataTable GetNominasPorEmpleado(int idEmpleado)
        {
            return _dao.GetNominasPorEmpleado(idEmpleado);
        }

        // Informe 3: empleados agrupados por sede y trienios
        public DataTable GetEmpleadosConTrienios()
        {
            return _dao.GetEmpleadosConTrienios();
        }

        // Informe 4: gasto total de una oficina en un mes 
        public DataTable GetGastoOficinaMes(int anio, int mes, int idOficina)
        {
            return _dao.GetGastoOficinaMes(anio, mes, idOficina);
        }

        // Informe 5: gasto por pais en todos los meses
        public DataTable GetGastoPorPaisMes()
        {
            return _dao.GetGastoPorPaisMes();
        }
    }
}
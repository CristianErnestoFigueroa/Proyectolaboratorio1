using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.VISTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.NEGOCIO
{
    class clsLogin
    {
        listadoDeUsuarios list = new listadoDeUsuarios();
        listadoDeAdministradores listAdmins = new listadoDeAdministradores();

        public int Users(Login log) {

            int variableAcceso = 0;
            if (log.Estado == 0)
            {
                for (int i = 0; i < list.nombre.Length; i++)
                {
                    if (log.Usuario.Equals(list.nombre[i]) && log.Password.Equals(list.password[i]))
                    {
                        variableAcceso = 1;
                    }
                }
                return variableAcceso;
            }
            else if (log.Estado == 1)
            {
                for (int i = 0; i < listAdmins.nombre.Length; i++)
                {
                    if (log.Usuario.Equals(listAdmins.nombre[i]) && log.Password.Equals(listAdmins.password[i]))
                    {
                        variableAcceso = 1;
                    }
                }
                return variableAcceso;
            }
            else {
                return 0;
            }
        }
    }
}

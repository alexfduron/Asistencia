using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Asistencia_BIS.LOGICA
{
    public class Logica_Personal
    {

        public int ID_Personal
        {
            get;set;
        }

        public string Codigo
        {
            get;set;
        }

        public string Nombre
        {
            get;set;
        }

        public string Apellido
        {
            get;set;
        }

        public int ID_Centro_de_Costo
        {
            get;set;
        }

        public int ID_Cargo
        {
            get;set;
        }

        public int ID_Supervisor
        {
            get;set;
        }

        public string Estado
        {
            get;set;
        }

        public byte[] Foto
        {
            get;set;
        }

    }

}

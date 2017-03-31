using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
   public class Usuario
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ap { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public string Area { get; set; }
        public string Puesto { get; set; }
        public string Rol { get; set; }

        public Usuario() { }

        public Usuario(int Id, string pNom, string pAp, string pUser, string pContraseña, string pArea, string pPuesto, string pRol)

        {

            this.Id = Id;
            this.Nom = pNom;
            this.Ap = pAp;
            this.User = pUser;
            this.Contraseña = pContraseña;
            this.Area = pArea;
            this.Puesto = pPuesto;
            this.Rol = pRol;

        }
    }
}

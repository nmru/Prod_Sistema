using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class prodEtapa
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public string Etapa { get; set; }
        public string Fecha { get; set; }
        public string Issue { get; set; }
        public string Status { get; set; }

        public prodEtapa() { }

        public prodEtapa(int pId, string pSerie, string pEtapa, string pFecha, string pIssue, string pStatus)
        {
            this.Id = pId;
            this.Serie = pSerie;
            this.Etapa = pEtapa;
            this.Fecha = pFecha;
            this.Issue = pIssue;
            this.Status = pStatus;
        }

    }
}

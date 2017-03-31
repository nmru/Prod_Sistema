using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Lote
    {
        public int id { get; set; }
        public string Num_Lote { get; set; }
        public string Ubicacion { get; set; }
        public string SLote { get; set; }


        public Lote() { }

        public Lote(int pId, string pNum_Lote, string pUbicacion, string pSLote)

        {

            this.id = pId;
            this.Num_Lote = pNum_Lote;
            this.Ubicacion = pUbicacion;
            this.SLote = pSLote;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Producto
    {
        public int Id_Prod { get; set; }
        public string Serial { get; set; }
        public string MAC { get; set; }
        public string lote { get; set; }
        public string Disp { get; set; }

        public Producto() { }

        public Producto(int pId_Prod, string pSerial, string pMAC, string plote, string pDis)

        {

            this.Id_Prod = pId_Prod;
            this.Serial = pSerial;
            this.MAC = pMAC;
            this.lote = plote;
            this.Disp = pDis;
        }

    }
}

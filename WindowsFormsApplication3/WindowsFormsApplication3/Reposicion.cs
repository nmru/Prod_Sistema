using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Reposicion
    {
        public int id { get; set; }
        public string ss { get; set; }
        public string ms { get; set; }
        public int ls { get; set; }
        public string se { get; set; }
        public string me { get; set; }
        public int le { get; set; }
        public string canal { get; set; }
        public string cte { get; set; }
        public string cd { get; set; }
        public string fs { get; set; }
        public string motivo { get; set; }
        public string presta { get; set; }
        public string Auto { get; set; }

        public Reposicion() { }

        public Reposicion (int id, string pSS, string pMS, int pLS, string pSE, string pME, int pLE, string pCanal, string pCte, string pCd, string pFS, string pMotivo, string pPresta, string pAuto)
        {
            this.id = id;
            this.ss = pSS;
            this.ms = pMS;
            this.ls = pLS;
            this.se = pSE;
            this.me = pME;
            this.le = pLE;
            this.canal = pCanal;
            this.cte = pCte;
            this.cd = pCd;
            this.fs = pFS;
            this.motivo = pMotivo;
            this.presta = pPresta;
            this.Auto = pAuto;
        }

    }
}

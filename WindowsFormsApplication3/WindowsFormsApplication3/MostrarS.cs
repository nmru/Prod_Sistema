using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MostrarS : Form
    {
        public MostrarS()
        {
            InitializeComponent();
        }

        public string st { get; set; }

        private void MostrarS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.rSLote' table. You can move, or remove it, as needed.
            this.rSLoteTableAdapter.Fill(this.DataSetPrincipal.rSLote, st);

            this.reportViewer1.RefreshReport();
        }
    }
}

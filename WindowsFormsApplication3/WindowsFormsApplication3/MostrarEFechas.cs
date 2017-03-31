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
    public partial class MostrarEFechas : Form
    {
        public MostrarEFechas()
        {
            InitializeComponent();
        }

        public string et { get; set; }
        public DateTime f1 { get; set; }
        public DateTime f2 { get; set; }

        private void MostrarEFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.rFechaE' table. You can move, or remove it, as needed.
            this.rFechaETableAdapter.Fill(this.DataSetPrincipal.rFechaE, et, f1, f2);

            this.reportViewer1.RefreshReport();
        }
    }
}

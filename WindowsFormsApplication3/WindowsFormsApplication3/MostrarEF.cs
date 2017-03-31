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
    public partial class MostrarEF : Form
    {
        public MostrarEF()
        {
            InitializeComponent();
        }

        public string et { get; set; }
        public DateTime f { get; set; }

        private void MostrarEF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.rFecha' table. You can move, or remove it, as needed.
            this.rFechaTableAdapter.Fill(this.DataSetPrincipal.rFecha, et,f);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

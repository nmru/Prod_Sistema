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
    public partial class MostrarL : Form
    {
        public MostrarL()
        {
            InitializeComponent();
        }

        public int pack { get; set; }
        public string serie { get; set; }

        private void MostrarL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.rLote' table. You can move, or remove it, as needed.
            this.rLoteTableAdapter.Fill(this.DataSetPrincipal.rLote, pack, serie);

            this.reportViewer1.RefreshReport();
        }
    }
}

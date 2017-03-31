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
    public partial class MostrarU : Form
    {
        public MostrarU()
        {
            InitializeComponent();
        }
        public string ub { get; set; }
        private void MostrarU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.rLUbicacion' table. You can move, or remove it, as needed.
            this.rLUbicacionTableAdapter.Fill(this.DataSetPrincipal.rLUbicacion,ub);

            this.reportViewer1.RefreshReport();
        }
    }
}

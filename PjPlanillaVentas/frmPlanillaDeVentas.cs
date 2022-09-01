using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPlanillaVentas
{
    public partial class frmPlanillaDeVentas : Form
    {
        public frmPlanillaDeVentas()
        {
            InitializeComponent();
        }

        private void frmPlanillaDeVentas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            
        }


    }
}

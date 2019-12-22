using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionScolaire
{
    public partial class garde_generaleForm : Form
    {
        public garde_generaleForm()
        {
            InitializeComponent();
        }

        private void garde_generaleForm_Load(object sender, EventArgs e)
        {
            btn_ds.Enabled = false;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

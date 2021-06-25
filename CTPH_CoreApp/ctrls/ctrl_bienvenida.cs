using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_bienvenida : UserControl
    {
        private frmApp _container; 
        public ctrl_bienvenida(frmApp container)
        {
            InitializeComponent();

            _container = container;
        }

        private void cmdTomarMuestra_Click(object sender, EventArgs e)
        {
            _container.TomarMuestra();
        }

        private void cmdConfigurar_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}

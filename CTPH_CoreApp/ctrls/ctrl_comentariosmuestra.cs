using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_comentariosmuestra : UserControl
    {
        frmApp _container;

        public ctrl_comentariosmuestra(frmApp container)
        {
            InitializeComponent();

            _container = container;
        }

        private void picOK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void txtObservaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OK();
        }

        private void OK()
        {
            if (!string.IsNullOrWhiteSpace(txtObservaciones.Text.Trim()))
            {
                _container.GrabaMuestra(txtObservaciones.Text.Trim());
            }
        }
    }
}

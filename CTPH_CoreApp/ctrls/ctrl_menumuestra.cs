using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_menumuestra : UserControl
    {
        private frmApp _container;

        public ctrl_menumuestra(frmApp container)
        {
            InitializeComponent();

            _container = container;
        }

        private void cmdMuestra_Click(object sender, EventArgs e)
        {
            _container.SetTipoMuestra(tipos_app.appMuestra.enumTipoMuestra.Muestra);
        }

        private void cmdSituacion_Click(object sender, EventArgs e)
        {
            _container.SetTipoMuestra(tipos_app.appMuestra.enumTipoMuestra.SituacionAmbiente);
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            _container.SetTipoMuestra(tipos_app.appMuestra.enumTipoMuestra.MuestraPlusSituacion);
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.ShowBienvenida();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CTPH_CoreServiceAgent;
using CTPH_CoreBusiness.BusinessObjects;
using CTPH_CoreBusiness.BusinessInterface;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_puntosdemedida : UserControl
    {
        private MuestrasServiceAgent _serviceagent;
        private frmApp _container;

        public ctrl_puntosdemedida(frmApp container, MuestrasServiceAgent serviceagent)
        {
            InitializeComponent();

            _container = container;
            _serviceagent = serviceagent;
        }

        private void ctrl_puntosdemedida_Load(object sender, EventArgs e)
        {
            GetPuntosDeMedida();
        }

        private void GetPuntosDeMedida()
        {
            lvPuntosDeMedida.Items.Clear();

            foreach (var pm in _serviceagent.GetPuntosDeMedida())
            {
                ListViewItem lstIt = new ListViewItem(pm.Descripcion);

                lstIt.SubItems.Add(pm.Observaciones);
                lstIt.SubItems.Add(pm.TipoPuntoMedida.Descripcion);

                lstIt.Tag = pm;

                lvPuntosDeMedida.Items.Add(lstIt);
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            List<IPuntoMedida> lstPuntosMedida = new List<IPuntoMedida>();

            foreach (ListViewItem lstIt in lvPuntosDeMedida.CheckedItems)
            {
                PuntoMedida pm = (PuntoMedida)lstIt.Tag;
                lstPuntosMedida.Add(pm);
            }

            _container.SelectPuntosDeMedida(lstPuntosMedida);
        }

        private void lnkTodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lstIt in lvPuntosDeMedida.Items)
            {
                lstIt.Checked = true;
            }
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.UnselectPuntosDeMedida();
            _container.TomarMuestra();
        }
    }
}

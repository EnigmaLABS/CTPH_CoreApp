using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CTPH_CoreBusiness.BusinessInterface;
using CTPH_CoreBusiness.BusinessObjects;
using CTPH_CoreServiceAgent;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_situacionmenu : UserControl
    {
        private MuestrasServiceAgent _serviceagent;
        private frmApp _container;

        public ctrl_situacionmenu(frmApp container, MuestrasServiceAgent serviceagent)
        {
            InitializeComponent();

            _container = container;
            _serviceagent = serviceagent;
    }

        private void ctrl_situacionmenu_Load(object sender, EventArgs e)
        {
            var elementos = _serviceagent.GetElementos();

            if (elementos != null)
            {
                foreach (var elem in elementos)
                {
                    ListViewItem lstIt = new ListViewItem(elem.Descripcion);
                    lstIt.Tag = elem;

                    lvElementos.Items.Add(lstIt);
                }
            }
        }

        private void picOK_Click(object sender, EventArgs e)
        {
            List<IElemento> elementos = new List<IElemento>();

            foreach (ListViewItem lstIt in lvElementos.CheckedItems)
            {
                Elemento elemento = (Elemento)lstIt.Tag;
                elementos.Add(elemento);
            }

            _container.SelectElementos(elementos);
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.UnselectElementos();
            _container.TomarMuestra();
        }
    }
}

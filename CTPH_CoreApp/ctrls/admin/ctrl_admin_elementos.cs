using System;
using System.Windows.Forms;

using CTPH_CoreServiceAgent;

namespace CTPH_CoreApp.ctrls.admin
{
    public partial class ctrl_admin_elementos : UserControl
    {
        private frmApp _container;
        private AdminServiceAgent _serviceagent;

        public ctrl_admin_elementos(frmApp container, AdminServiceAgent serviceagent)
        {
            InitializeComponent();

            _serviceagent = serviceagent;
            _container = container;
        }

        private void ctrl_admin_elementos_Load(object sender, EventArgs e)
        {
            var elementos = _serviceagent.GetElementos();

            foreach (var elem in elementos)
            {
                ListViewItem lstIt = new ListViewItem(elem.Descripcion);
                lstIt.SubItems.Add(elem.TipoValor.Descripcion);
                lstIt.Tag = elem;

                lvElementos.Items.Add(lstIt);
            }
        }
    }
}

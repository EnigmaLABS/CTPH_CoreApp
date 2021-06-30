using System.Windows.Forms;

namespace CTPH_CoreApp.ctrls.admin
{
    public partial class ctrl_admin_menu : UserControl
    {
        private frmApp _container;

        public ctrl_admin_menu(frmApp container)
        {
            InitializeComponent();

            _container = container;
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.ShowBienvenida();
        }
    }
}

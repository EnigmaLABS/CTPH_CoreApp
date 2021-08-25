using System;
using System.Collections.Generic;
using System.Drawing;
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

        private enum FormViewum { Elementos = 1, Perfiles = 2, PerfilesElementos = 3 }
        private FormViewum formViewActual = FormViewum.Elementos;

        public ctrl_situacionmenu(frmApp container, MuestrasServiceAgent serviceagent)
        {
            InitializeComponent();

            _container = container;
            _serviceagent = serviceagent;
    }

        private void ctrl_situacionmenu_Load(object sender, EventArgs e)
        {
            GetElementos();
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

        private void picPerfil_Click(object sender, EventArgs e)
        {
            if (formViewActual == FormViewum.Elementos)
            {
                picPerfil.BackColor = Color.Red;
                formViewActual = FormViewum.Perfiles;
                GetPerfiles();
            }
            else 
            {
                picPerfil.BackColor = Color.White;
                picAtras.Visible = false;
                formViewActual = FormViewum.Elementos;
                GetElementos();
            }
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            if (formViewActual == FormViewum.PerfilesElementos)
            {
                picAtras.Visible = false;
                formViewActual = FormViewum.Perfiles;
                GetPerfiles();
            }
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.UnselectElementos();
            _container.TomarMuestra();
        }

        private void lvElementos_DoubleClick(object sender, EventArgs e)
        {
            if (lvElementos.SelectedItems.Count == 1)
            {
                var perfil = (Perfil)lvElementos.SelectedItems[0].Tag;

                if (formViewActual == FormViewum.Perfiles)
                {
                    formViewActual = FormViewum.PerfilesElementos;
                    picAtras.Visible = true;
                    GetElementosPerfil(perfil.idPerfil);
                }
            }
        }

        //-->> Métodos privados

        private void GetElementos()
        {
            lvElementos.Items.Clear();
            lvElementos.CheckBoxes = true;

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

        private void GetPerfiles()
        {
            lvElementos.Items.Clear();
            lvElementos.CheckBoxes = false;

            var perfiles = _serviceagent.GetPerfiles();

            if (perfiles != null)
            {
                foreach (var perfil in perfiles)
                {
                    ListViewItem lstIt = new ListViewItem(perfil.Descripcion);
                    lstIt.Tag = perfil;

                    lvElementos.Items.Add(lstIt);
                }
            }
        }

        private void GetElementosPerfil(int idPerfil)
        {
            lvElementos.Items.Clear();
            lvElementos.CheckBoxes = true;

            var elementos_perfil = _serviceagent.GetElementos_Perfil(idPerfil);

            if (elementos_perfil != null)
            {
                foreach (var elem in elementos_perfil)
                {
                    ListViewItem lstIt = new ListViewItem(elem.Descripcion);
                    lstIt.Tag = elem;
                    lstIt.Checked = true;

                    lvElementos.Items.Add(lstIt);
                }
            }
        }
    }
}

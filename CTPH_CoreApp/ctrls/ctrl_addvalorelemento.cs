using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CTPH_CoreBusiness.BusinessInterface;
using CTPH_CoreBusiness.BusinessObjects;
using CTPH_CoreServiceAgent;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_AddValorElemento : UserControl
    {
        private int Index = 0;
        private MuestrasServiceAgent _serviceagent;
        private frmApp _container;
        private tipos_app.appMuestra _muestra;

        public ctrl_AddValorElemento(tipos_app.appMuestra muestra, frmApp container, MuestrasServiceAgent serviceagent)
        {
            InitializeComponent();

            _muestra = muestra;
            _container = container;
            _serviceagent = serviceagent;
        }

        private void ctrl_AddValorElemento_Load(object sender, EventArgs e)
        {
            GetNext();
        }

        private void picOK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void cmdTrue_Click(object sender, EventArgs e)
        {
            InsertValue("true");

            ScreenTransition();
        }

        private void cmdFalse_Click(object sender, EventArgs e)
        {
            InsertValue("false");

            ScreenTransition();
        }

        private void lvListaValores_DoubleClick(object sender, EventArgs e)
        {
            if (lvListaValores.SelectedItems.Count == 1)
            {
                IListaValores valorseleccionado = (IListaValores)lvListaValores.SelectedItems[0].Tag;

                _container.AddElementoListaValor(_muestra.ElementosMuestra[Index].idElemento, valorseleccionado.idListaValor);

                ScreenTransition();
            }
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OK();
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.SetTipoMuestra(_muestra.TipoMuestra);
        }


        //-->>
        #region Métodos privados

        private void GetNext()
        {
            lblElemento.Text = _muestra.ElementosMuestra[Index].Descripcion;

            switch (_muestra.ElementosMuestra[Index].TipoValor.GetTipoValor())
            {
                case enumTipoValor.Numero:
                case enumTipoValor.Texto:

                    lblTipoValor.Text = _muestra.ElementosMuestra[Index].TipoValor.GetTipoValor() == enumTipoValor.Numero ? "Valor numérico"
                                                                                                                          : "Introduzca un texto";
                    ShowPanel_TextBox();
                    break;

                case enumTipoValor.Si_No:

                    ShowPanel_Booleano();
                    break;

                case enumTipoValor.Lista:

                    GetListaValores(_muestra.ElementosMuestra[Index].idElemento);
                    ShowPanel_Lista();
                    break;
            }
        }

        private void InsertValue(string value)
        {
            if (_muestra.Muestra.SituacionAmbiente == null) { _muestra.Muestra.SituacionAmbiente = new SituacionAmbiente(); }

            if (_muestra.Muestra.SituacionAmbiente.Elementos == null) { _muestra.Muestra.SituacionAmbiente.Elementos = new List<ElementoValor>(); }

            _muestra.Muestra.SituacionAmbiente.Observaciones = "Observaciones de prueba";

            _muestra.Muestra.SituacionAmbiente.Elementos.Add(new ElementoValor()
            {
                Elemento = new Elemento()
                {
                    idElemento = _muestra.ElementosMuestra[Index].idElemento
                },
                Valor = value
            });
        }

        private void GetListaValores(int idElemento)
        {
            lvListaValores.Items.Clear();

            foreach (var item in _serviceagent.GetElemento_ListaValores(idElemento))
            {
                ListViewItem lstIt = new ListViewItem(item.NombreListaValor);
                lstIt.Tag = item;

                lvListaValores.Items.Add(lstIt);
            }
        }

        private void ScreenTransition()
        {
            if (Index + 1 == _muestra.ElementosMuestra.Count)
            {
                
                _container.SetValoresElementos(_muestra.Muestra);
            }
            else
            {
                Index++;
                GetNext();
            }
        }

        private void OK()
        {
            //valida y guarda valor
            switch (_muestra.ElementosMuestra[Index].TipoValor.GetTipoValor())
            {
                case enumTipoValor.Numero:

                    decimal val;

                    if (!decimal.TryParse(txtValor.Text.Trim().Replace(".", ","), out val))
                    {
                        // TODO: Salta validación molona (con timer)
                        MessageBox.Show("Norrrrr");
                        break;
                    }

                    InsertValue(txtValor.Text.Trim().Replace(".", ","));

                    break;

                case enumTipoValor.Texto:

                    if (string.IsNullOrWhiteSpace(txtValor.Text))
                    {
                        // TODO: Salta validación molona (con timer)
                        MessageBox.Show("Norrrrr");
                        break;
                    }

                    InsertValue(txtValor.Text.Trim());

                    break;
            }

            ScreenTransition();
        }

        //-->> Visibilidad paneles
        private void ShowPanel_TextBox()
        {
            panelValorLista.Visible = false;
            panelBooleano.Visible = false;

            txtValor.Text = "";
            panelValorTextBox.Visible = true;
            txtValor.Focus();
        }

        private void ShowPanel_Booleano()
        {
            panelValorLista.Visible = false;
            panelValorTextBox.Visible = false;

            panelBooleano.Visible = true;
            panelBooleano.Location = panelValorTextBox.Location;
        }

        private void ShowPanel_Lista()
        {
            panelBooleano.Visible = false;
            panelValorTextBox.Visible = false;

            panelValorLista.Location = panelValorTextBox.Location;
            panelValorLista.Visible = true;
        }


        #endregion
    }
}

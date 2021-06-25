using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CTPH_CoreBusiness.BusinessObjects;

namespace CTPH_CoreApp.ctrls
{
    public partial class ctrl_addvalormedida : UserControl
    {
        private frmApp _container;
        private tipos_app.appMuestra _muestra;
        private int Index = 0;

        public ctrl_addvalormedida(tipos_app.appMuestra muestra, frmApp container)
        {
            InitializeComponent();

            _container = container;
            _muestra = muestra;
        }

        private void ctrl_addvalormedida_Load(object sender, EventArgs e)
        {
            GetNext();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void txtHumedad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OK();
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _container.UnsetValoresMedida();
        }


        //-->>
        #region Métodos privados

        private void OK()
        {
            decimal temperatura;
            byte humedad;

            if (decimal.TryParse(txtTemperatura.Text.Trim().Replace(".", ","), out temperatura) && byte.TryParse(txtHumedad.Text.Trim(), out humedad))
            {
                if (_muestra.Muestra.MuestrasValores == null) { _muestra.Muestra.MuestrasValores = new List<MuestraValor>(); }

                _muestra.Muestra.MuestrasValores.Add(new MuestraValor()
                {
                    Temperatura = temperatura,
                    Humedad = humedad,
                    PuntoMedida = (PuntoMedida)_muestra.PuntosDeMedida[Index]
                });

                ScreenTransition();
            }
            else
            {
                // TODO: Salta validación molona (con timer)
                MessageBox.Show("Norrr");
            }
        }

        private void GetNext()
        {
            txtTemperatura.Text = "";
            txtHumedad.Text = "";

            lblPM.Text = _muestra.PuntosDeMedida[Index].Descripcion  + " - " + _muestra.PuntosDeMedida[Index].Observaciones + " - " + _muestra.PuntosDeMedida[Index].TipoPuntoMedida.Descripcion;

            txtTemperatura.Focus();
        }

        private void ScreenTransition()
        {
            if (Index + 1 == _muestra.PuntosDeMedida.Count)
            {
                _container.SetValoresMedida(_muestra.Muestra);
            }
            else
            {
                Index++;
                GetNext();
            }
        }

        #endregion
    }
}

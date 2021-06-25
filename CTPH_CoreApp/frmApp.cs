using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CTPH_CoreApp.Config;
using CTPH_CoreBusiness.BusinessInterface;
using CTPH_CoreBusiness.BusinessObjects;
using CTPH_CoreServiceAgent;

namespace CTPH_CoreApp
{
    public partial class frmApp : Form
    {
        private tipos_app.appMuestra _Muestra;
        private MuestrasServiceAgent _serviceagent;
        private ClientConfig _config;

        public frmApp(ClientConfig config)
        {
            InitializeComponent();

            _config = config;

            _serviceagent = new MuestrasServiceAgent(_config.Url);
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            ctrls.ctrl_bienvenida ctrl_bienvenida = new ctrls.ctrl_bienvenida(this);
            ctrl_bienvenida.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(ctrl_bienvenida);
        }


        //-->>
        #region Métodos públicos

        public void ShowBienvenida()
        {
            panelContainer.Controls.Clear();

            ctrls.ctrl_bienvenida ctrl_bienvenida = new ctrls.ctrl_bienvenida(this);
            ctrl_bienvenida.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ctrl_bienvenida);
        }

        public void TomarMuestra()
        {
            panelContainer.Controls.Clear();

            ctrls.ctrl_menumuestra ctrl = new ctrls.ctrl_menumuestra(this);
            ctrl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ctrl);
        }

        public void SetTipoMuestra(tipos_app.appMuestra.enumTipoMuestra tipo)
        {
            _Muestra = new tipos_app.appMuestra(tipo);

            panelContainer.Controls.Clear();

            switch (_Muestra.TipoMuestra)
            {
                case tipos_app.appMuestra.enumTipoMuestra.Muestra:

                    ctrls.ctrl_puntosdemedida ctrl_pm = new ctrls.ctrl_puntosdemedida(this, _serviceagent);
                    ctrl_pm.Dock = DockStyle.Fill;

                    panelContainer.Controls.Clear();
                    panelContainer.Controls.Add(ctrl_pm);

                    break;

                case tipos_app.appMuestra.enumTipoMuestra.SituacionAmbiente:
                case tipos_app.appMuestra.enumTipoMuestra.MuestraPlusSituacion:

                    ctrls.ctrl_situacionmenu ctrl_sit = new ctrls.ctrl_situacionmenu(this, _serviceagent);
                    ctrl_sit.Dock = DockStyle.Fill;

                    panelContainer.Controls.Clear();
                    panelContainer.Controls.Add(ctrl_sit);

                    break;
            }
        }

        public void SelectElementos(List<IElemento> elementosMuestra)
        {
            _Muestra.ElementosMuestra = elementosMuestra;

            panelContainer.Controls.Clear();

            ctrls.ctrl_AddValorElemento ctrl = new ctrls.ctrl_AddValorElemento(_Muestra, this, _serviceagent);
            ctrl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ctrl);
        }

        public void UnselectElementos()
        {
            _Muestra.ElementosMuestra = null;
        }

        public void SelectPuntosDeMedida(List<IPuntoMedida> puntosDeMedida)
        {
            _Muestra.PuntosDeMedida = puntosDeMedida;

            panelContainer.Controls.Clear();

            ctrls.ctrl_addvalormedida ctrl = new ctrls.ctrl_addvalormedida(_Muestra, this);
            ctrl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ctrl);
        }
        public void UnselectPuntosDeMedida()
        {
            panelContainer.Controls.Clear();
        }

        public void SetValoresElementos(IMuestraInfo muestra)
        {
            _Muestra.Muestra = muestra;

            panelContainer.Controls.Clear();

            ScreenTransition(true);
        }

        public void SetValoresMedida(IMuestraInfo muestra)
        {
            _Muestra.Muestra = muestra;

            panelContainer.Controls.Clear();

            ScreenTransition(false);
        }

        public void UnsetValoresMedida()
        {
            _Muestra.Muestra.MuestrasValores = null;
        }

        public void AddElementoListaValor(int idElemento, int idListaValor)
        {
            // añade elemento-valor a la muestra
            if (_Muestra.Muestra.SituacionAmbiente == null)
            {
                _Muestra.Muestra.SituacionAmbiente = new SituacionAmbiente()
                {
                    Observaciones = "Observaciones de prueba",
                    Elementos = new List<ElementoValor>()
                };
            }

            _Muestra.Muestra.SituacionAmbiente.Elementos.Add(new ElementoValor()
            {
                Elemento = new Elemento()
                {
                    idElemento = idElemento
                },
                idListaValor = idListaValor
            });
       }

        public void GrabaMuestra(string Observaciones)
        {
            _Muestra.Muestra.Observaciones = Observaciones;

            var resInsert = _serviceagent.Insert(_Muestra.Muestra);

            if (resInsert.OK)
            {
                ShowBienvenida();
            }
            else
            {

            }
        }

        #endregion


        //-->>
        #region Métodos privados

        private void ScreenTransition(bool fromSituacion)
        {
            panelContainer.Controls.Clear();

            switch (_Muestra.TipoMuestra)
            {
                case tipos_app.appMuestra.enumTipoMuestra.Muestra:
                case tipos_app.appMuestra.enumTipoMuestra.SituacionAmbiente:

                    ctrls.ctrl_comentariosmuestra ctrl = new ctrls.ctrl_comentariosmuestra(this);
                    ctrl.Dock = DockStyle.Fill;
                    panelContainer.Controls.Add(ctrl);

                    break;

                case tipos_app.appMuestra.enumTipoMuestra.MuestraPlusSituacion:

                    if (fromSituacion)
                    {
                        ctrls.ctrl_puntosdemedida ctrl_pm = new ctrls.ctrl_puntosdemedida(this, _serviceagent);
                        ctrl_pm.Dock = DockStyle.Fill;
                        panelContainer.Controls.Add(ctrl_pm);
                    }
                    else
                    {
                        ctrls.ctrl_comentariosmuestra ctrl2 = new ctrls.ctrl_comentariosmuestra(this);
                        ctrl2.Dock = DockStyle.Fill;
                        panelContainer.Controls.Add(ctrl2);
                    }
                    break;
            }
        }

        #endregion
    }
}

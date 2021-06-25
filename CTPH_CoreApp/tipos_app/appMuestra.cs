using System.Collections.Generic;

using CTPH_CoreBusiness.ActionInterface;
using CTPH_CoreBusiness.BusinessInterface;
using CTPH_CoreBusiness.BusinessObjects;

namespace CTPH_CoreApp.tipos_app
{
    public class appMuestra
    {
        private IMuestraAction _muestraAction;

        public appMuestra(IMuestraAction muestraAction)
        {
            _muestraAction = muestraAction;
        }

        public enum enumTipoMuestra { Muestra = 0, SituacionAmbiente = 1, MuestraPlusSituacion = 2 }

        public enumTipoMuestra TipoMuestra { get; set; }

        public appMuestra(enumTipoMuestra tipoMuestra)
        {
            this.TipoMuestra = tipoMuestra;
        }

        public IMuestraInfo Muestra { get; set; } = new Muestra();

        public List<IElemento> ElementosMuestra { get; set; }

        public List<IPuntoMedida> PuntosDeMedida { get; set; }
    }
}

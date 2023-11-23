using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Diseno
{
    public class IteratorLlamadas : IIterator<LlamadaDTO>
    {
        private int posicion;
        private List<LlamadaDTO> elementos;
        private object[] filtros;

        public LlamadaDTO actual()
        {
            if (cumpleFiltros())
            {
                return elementos[posicion];
            }
            return null;
        }

        public bool cumpleFiltros()
        {
            Llamada llamada = elementos[posicion].Llamada;
            DateTime fechaInicioPeriodo = Convert.ToDateTime(filtros[0].ToString()); ;
            DateTime fechaFinPeriodo = Convert.ToDateTime(filtros[1].ToString()); ;

            if (llamada.tieneEncuestasRespondidas())
            {
                if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo, out CambioEstado inicial))
                {
                    elementos[posicion].Etiqueta = llamada.getNombreClienteDeLlamada() + " - " + inicial.getFechaHoraInicio().ToString();
                    return true;
                }
            }
            return false;
        }

        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }

        public bool haTerminado()
        {
            if (posicion == elementos.Count -1)
            {
                return true;
            }
            return false;
        }

        public IteratorLlamadas(List<LlamadaDTO> elementos, params object[] filtros)
        {
            this.elementos = elementos;
            this.filtros = filtros;
        }
    }
}

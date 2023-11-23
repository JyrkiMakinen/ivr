using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Diseno
{
    public class LlamadaDTO
    {
        public Llamada Llamada { get; set; }
        public string Etiqueta { get; set; }

        public LlamadaDTO() { }

        public LlamadaDTO(Llamada llamada, string etiqueta) { Llamada = llamada; Etiqueta = etiqueta; }
    }
}

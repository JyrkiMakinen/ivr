using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Diseno
{
    public interface IAgregado<T>
    {
        IIterator<T> crearIterator(List<T> elementos, params object[] filtros);
    }
}

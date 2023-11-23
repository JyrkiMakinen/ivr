using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.Diseno
{
    public interface IIterator<T>
    {
        void primero();

        void siguiente();

        T actual();

        bool cumpleFiltros();

        bool haTerminado();
    }
}

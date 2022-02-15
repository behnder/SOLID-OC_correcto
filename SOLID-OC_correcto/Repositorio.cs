using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OC_correcto
{
    interface Repositorio
    {
         void Cargar();
         void Guardar();
         void Actualizar();
         void Quitar();
    }
}

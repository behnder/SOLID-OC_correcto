using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OC_correcto
{
    class RepositorioPostgreSQL : Repositorio
    {
        public void Actualizar()
        {
            Console.WriteLine("Cargando datos para BD PostgreSQL");
        }

        public void Cargar()
        {
            Console.WriteLine("Guardando datos para BD PostgreSQL");
        }

        public void Guardar()
        {
            Console.WriteLine("Actualizando datos para BD PostgreSQL");
        }

        public void Quitar()
        {
            Console.WriteLine("Eliminando datos para BD PostgreSQL");
        }
    }
}

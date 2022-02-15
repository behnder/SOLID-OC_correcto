using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OC_correcto
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioOracle repoOracle = new RepositorioOracle();
            RepositorioPostgreSQL repoPostgreSQL = new RepositorioPostgreSQL();
            RepositorioSQL repoSQL = new RepositorioSQL();

            repoOracle.Actualizar();
            repoOracle.Cargar();
            repoOracle.Guardar();
            repoOracle.Quitar();

            Console.WriteLine("============");

            repoPostgreSQL.Actualizar();
            repoPostgreSQL.Cargar();
            repoPostgreSQL.Guardar();
            repoPostgreSQL.Quitar();

            Console.WriteLine("============");

            repoSQL.Actualizar();
            repoSQL.Cargar();
            repoSQL.Guardar();
            repoSQL.Quitar();

            Console.WriteLine("============");

            Console.ReadLine();


        }
    }
}

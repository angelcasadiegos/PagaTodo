using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class ExportarRepository
    {
        private string ruta;

        public void ExportarPorEntidad(string nombreEntidad, IList<Entidad> entidades)
        {
            AsignarRuta(nombreEntidad);
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            Guardado Archivo = new Guardado();
            foreach (var item in entidades)
            {
                Archivo.Guardar(item, ruta);
            }
        }
        public void AsignarRuta(string nombreEntidad)
        {
            ruta = @"PagosEntidades.txt";
            if (nombreEntidad == "Electricaribe")
            {
                ruta = @"Electricaribe.txt";
            }
            else if (nombreEntidad == "GasCaribe")
            {
                ruta = @"GasCaribe.txt";
            }
            else
            {
                ruta = @"Emdupar.txt";
            }
        }
    }
}

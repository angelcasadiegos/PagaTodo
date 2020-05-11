using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ExportarService
    {
        private ExportarRepository exportarRepository;
        public ExportarService()
        {
            exportarRepository = new ExportarRepository();
        }
        public string ExportarPorEntidad(string nombreEntidad, IList<Entidad> entidades )
        {
            try
            {
                exportarRepository.ExportarPorEntidad(nombreEntidad, entidades);
                return $"Los datos de los pagos seleccionados han sido exportados correctamente";
            }
            catch (Exception E)
            {
                return "Error de lectura o escritura de archivos: " + E.Message;
            }
        }
    }
}

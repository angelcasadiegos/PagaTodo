using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Guardado
    {        
        public void Guardar(Entidad entidad, string ruta)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(entidad.ToString());
            writer.Close();
            fileStream.Close();
        }
    }
}

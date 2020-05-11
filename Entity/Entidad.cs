using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entidad
    {
        public string NombreEntidad { get; set; }
        public string NumeroRecibo { get; set; }        
        public DateTime FechadePago { get; set; }
        public decimal ValorPagado { get; set; }

        public Entidad()
        {

        }
        public Entidad(string nombreEntidad, string numeroRecibo, DateTime fechadePago, decimal valorPagado)
        {
            NombreEntidad = nombreEntidad;
            NumeroRecibo = numeroRecibo;        
            FechadePago = fechadePago;
            ValorPagado = valorPagado;
        }

        public override string ToString()
        {
            return $"{NombreEntidad},{NumeroRecibo},{FechadePago},{ValorPagado}";
        }
    }
}

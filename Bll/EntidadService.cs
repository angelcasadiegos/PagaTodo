using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dal;

namespace Bll
{
    public class EntidadService
    {
        public EntidadRepository entidadRepository;

        public EntidadService()
        {
            entidadRepository = new EntidadRepository();
        }

        public string Guardar(Entidad entidad)
        {
            try
            {
                if (entidadRepository.Buscar(entidad.NumeroRecibo) == null)
                {
                    entidadRepository.Guardar(entidad);
                    return $"Los datos el recibo de numero {entidad.NumeroRecibo} han sido guardados correctamente";
                }
                return $"No es posible registrar el pago del recibo de numero  {entidad.NumeroRecibo}, porque ya se encuentra registrada";
            }
            catch (Exception E)
            {
                return "Error de lectura " + E.Message;
            }
        }      

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Entidad> entidades = entidadRepository.Consultar();
                if (entidades.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de los pagos de las entidades";
                    respuesta.entidades = entidades;
                }
                else
                {
                    respuesta.Mensaje = "No existen pagos para Consultar";
                    respuesta.entidades = null;
                }

            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Error en datos: " + e.Message;
                respuesta.entidades = null;
            }
            return respuesta;

        }

        public RespuestaBusqueda Buscar(string numeroRecibo)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Entidad entidad = entidadRepository.Buscar(numeroRecibo);
                if (entidad == null)
                {
                    respuesta.Mensaje = $"el credito con  {numeroRecibo} no se encuentra registrada";
                    respuesta.entidad = null;
                }
                else
                {
                    respuesta.entidad = entidad;
                    respuesta.Mensaje = "recibo encontrado\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.entidad = null;
                respuesta.Error = true;
            }
            return respuesta;
        }
        public int TotalizarEntidades()
        {
            return entidadRepository.TotalizarEntidades();
        }
        public int TotalizarPorEntidad(string nombreEntidad)
        {
            return entidadRepository.TotalizarPorEntidad(nombreEntidad);
        }

        public decimal SumarPagos()
        {
            return entidadRepository.SumarPagos();
        }        

        public decimal SumarPorEntidades(string nombreEntidad)
        {
            return entidadRepository.SumarPorEntidades(nombreEntidad);
        }
        public IList<Entidad> ConsultaPorNombreEntidad(string nombreEntidad)
        {
            return entidadRepository.ConsultaPorNombreEntidad(nombreEntidad);
        }
        public IList<Entidad> ConsultarXFecha(DateTime fechaPago)
        {
            return entidadRepository.ConsultarXFecha(fechaPago);
        }    
    }
}

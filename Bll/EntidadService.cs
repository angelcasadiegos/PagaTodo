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
        
        public string Modificar(Entidad entidad)
        {
            try
            {
                if (creditoRepositorio.Buscar(credito.Identificacion) != null)
                {

                    creditoRepositorio.Modificar(credito);
                    return $"Los liquidacion con numero {credito.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La liquidacion {credito.Identificacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }

        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Credito> creditos = creditoRepositorio.Consultar();
                if (creditos.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de liquidaciones";
                    respuesta.creditos = creditos;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.creditos = null;
                }

            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Error en datos: " + e.Message;
                respuesta.creditos = null;
            }
            return respuesta;

        }

        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Credito credito = creditoRepositorio.Buscar(identificacion);
                if (credito == null)
                {
                    respuesta.Mensaje = $"el credito con  {identificacion} no se encuentra registrada";
                    respuesta.credito = null;
                }
                else
                {
                    respuesta.credito = credito;
                    respuesta.Mensaje = "credito encontrad\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.credito = null;
                respuesta.Error = true;
            }
            return respuesta;
        }
    }
}

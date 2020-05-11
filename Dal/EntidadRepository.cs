﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class EntidadRepository
    {
        private string ruta = @"Pagos.txt";
        public IList<Entidad> entidades;

        public EntidadRepository()
        {
            entidades = new List<Entidad>();
        }

        public void Guardar(Entidad entidad)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(entidad.ToString());
            stream.Close();
            fileStream.Close();

        }
        public IList<Entidad> Consultar()
        {
            entidades.Clear();
            FileStream filestream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(filestream);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {

                Entidad entidad = MapearEntidad(linea);
                entidades.Add(entidad);
            }
            filestream.Close();
            reader.Close();
            return entidades;
        }

        public Entidad MapearEntidad(string linea)
        {
            string[] datos = linea.Split(';');
            Entidad entidad = new Entidad();
            string NombeEntidad = datos[0];
            string NumeroRecibo = datos[1];
            DateTime FechadePago = DateTime.Parse(datos[2]);
            decimal ValorPagado = decimal.Parse(datos[3]);
            return entidad;

        }

        public Entidad Buscar(string numerorecibo)
        {
            entidades.Clear();
            entidades = Consultar();

            foreach (var item in entidades)
            {
                if (item.NumeroRecibo.Equals(numerorecibo))
                {
                    return item;
                }
            }
            return null;
        }

        public int TotalizarEntidades()
        {
            return entidades.Count();
        }               

        public IList<Entidad> ConsultaPorNombreEntidad(string nombreEntidad)
        {
            return entidades.Where(l => l.NombreEntidad.Contains(nombreEntidad)).ToList();
        }

        public IList<Entidad> ConsultarXFecha(DateTime fecha)
        {
            return entidades.Where(l => l.FechadePago.Year.Equals(fecha.Year) && l.FechadePago.Month.Equals(fecha.Month)).ToList();
        }
        
    }
}
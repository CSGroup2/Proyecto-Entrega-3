using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Peticion
    {
        private int id_peticion;
        private Cliente cliente;
        private int id_tipo_ambulancia;
        private int n_ambulancia;
        private string punto_origen;
        private string punto_destino;
        private string condicion;
        private DateTime fecha_registro;

        public Peticion()
        {
        }

        public Peticion(Cliente cliente, int id_tipo_ambulancia, int n_ambulancia, string punto_origen, string punto_destino, string condicion)
        {
            this.cliente = cliente;
            this.id_tipo_ambulancia = id_tipo_ambulancia;
            this.n_ambulancia = n_ambulancia;
            this.punto_origen = punto_origen;
            this.punto_destino = punto_destino;
            this.condicion = condicion;
        }

        public int Id_peticion { get => id_peticion; set => id_peticion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Id_tipo_ambulancia { get => id_tipo_ambulancia; set => id_tipo_ambulancia = value; }
        public int N_ambulancia { get => n_ambulancia; set => n_ambulancia = value; }
        public string Punto_origen { get => punto_origen; set => punto_origen = value; }
        public string Punto_destino { get => punto_destino; set => punto_destino = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Condicion { get => condicion; set => condicion = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Secretaria : Persona{

        // Variables
        private int id_secretaria;
        private Usuario usuario;
        private DateTime fecha_contrato;

        public Secretaria () : base () {
            this.id_secretaria = 0;
            this.usuario = null;
            this.fecha_contrato = new DateTime ();
        }

        public Secretaria (int id_secretaria, Usuario usuario, DateTime fecha_contrato, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono) : base (id_persona, cedula, nombre_1, nombre_2, apellido_1,  apellido_2, sexo, fecha_nac, telefono) {
            this.id_secretaria = id_secretaria;
            this.usuario = usuario;
            this.fecha_contrato = fecha_contrato;
        }

        public Usuario Usuario { get => usuario; set => usuario = value; }
        public int Id_secretaria { get => id_secretaria; set => id_secretaria = value; }
        public DateTime Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }

        public override string ToString () {
            return
                base.ToString ()+
                "\r\nUsuario: \n"+usuario.ToString()+
                "\r\nFecha de Contraro: "+ fecha_contrato;
        }
    }
}

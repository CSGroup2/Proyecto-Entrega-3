using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Asignacion_Cabecera {

        // Variables
        private int id_asignacion_cabecera;
        private Peticion peticion;
        private Secretaria secretaria;
        private string condicion;
        private List<Asignacion_Detalle> asignacion_detalle;

        // Constructor: Default
        public Asignacion_Cabecera () {
            this.id_asignacion_cabecera = 0;
            this.peticion = null;
            this.secretaria = null;
            this.condicion = "";
            this.asignacion_detalle = null;
        }

        // Constructor: Parameterized
        public Asignacion_Cabecera (Peticion peticion, Secretaria secretaria, string condicion,List<Asignacion_Detalle> asignacion_detalle) {
            this.peticion = peticion;
            this.secretaria = secretaria;
            this.condicion = condicion;
            this.asignacion_detalle = asignacion_detalle;
        }

        // Getters & Setters
        public int Id_asignacion_cabecera { get => id_asignacion_cabecera; set => id_asignacion_cabecera = value; }
        public Peticion Peticion { get => peticion; set => peticion = value; }
        public Secretaria Secretaria { get => secretaria; set => secretaria = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public List<Asignacion_Detalle> Asignacion_detalle { get => asignacion_detalle; set => asignacion_detalle = value; }

        public override string ToString () {
            return
                "\r\bPetición: \n" +peticion.ToString () +
                "\r\bSecretaria: \n" +secretaria.ToString () +
                "\r\bCondición: " + condicion +
                "\r\bAsignación Detalle: \n" +asignacion_detalle.Count ();
        }

    }
}

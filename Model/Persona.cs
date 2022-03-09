using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Persona {

        // Variables
        private int id_persona;
        private string cedula;
        private string nombre_1;
        private string nombre_2;
        private string apellido_1;
        private string apellido_2;
        private string sexo;
        private DateTime fecha_nac;
        private string telefono;

        // Constructor: Default
        public Persona () {
            this.id_persona = 0;
            this.cedula = "";
            this.nombre_1 = "";
            this.nombre_2 = "";
            this.apellido_1 = "";
            this.apellido_2 = "";
            this.sexo = "";
            this.fecha_nac = new DateTime ();
            this.telefono = "";
        }

        // Constructor: Parameterized
        public Persona (int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono) {
            this.id_persona = id_persona;
            this.cedula = cedula;
            this.nombre_1 = nombre_1;
            this.nombre_2 = nombre_2;
            this.apellido_1 = apellido_1;
            this.apellido_2 = apellido_2;
            this.sexo = sexo;
            this.fecha_nac = fecha_nac;
            this.telefono = telefono;
        }

        // Getters & Setters
        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre_1 { get => nombre_1; set => nombre_1 = value; }
        public string Nombre_2 { get => nombre_2; set => nombre_2 = value; }
        public string Apellido_1 { get => apellido_1; set => apellido_1 = value; }
        public string Apellido_2 { get => apellido_2; set => apellido_2 = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        // ToString
        public override string ToString () {
            return
                "\r\nCédula: " + cedula +
                "\r\nNombres: " + nombre_1 + " " + nombre_2 +
                "\r\nApellidos: " + apellido_1 + " " + apellido_2 +
                "\r\nSexo: " + sexo +
                "\r\nFecha de Nacimiento: " + fecha_nac +
                "\r\nTeléfono: " + telefono;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Conductor : Persona {

        // Variables
        private int id_conductor;
        private DateTime fecha_contrato;
        private string diponibilidad;

        // Constructor: Default
        public Conductor () : base () {
            this.id_conductor = 0;
            this.fecha_contrato = new DateTime ();
            this.diponibilidad = "";
        }

        // Constructor: Parameterized
        public Conductor (int id_conductor, DateTime fecha_contrato, string diponibilidad, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono) : base (id_persona, cedula, nombre_1, nombre_2, apellido_1, apellido_2, sexo, fecha_nac, telefono) {
            this.id_conductor = id_conductor;
            this.fecha_contrato = fecha_contrato;
            this.diponibilidad = diponibilidad;
        }

        // Getters & Setter
        public int Id_conductor { get => id_conductor; set => id_conductor = value; }
        public DateTime Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }
        public string Diponibilidad { get => diponibilidad; set => diponibilidad = value; }

        // ToString
        public override string ToString () {
            return
                base.ToString () +
                "\r\nFecha de Contrato: " + fecha_contrato +
                "\r\nDisonibilidad: " + diponibilidad;
        }

    }
}

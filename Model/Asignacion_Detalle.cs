using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Asignacion_Detalle {

        // Variables
        private int id_asignacion_detalle;
        private int id_asignacion_cabecera;
        private Peticion peticion;
        private Conductor conductor;
        private Ambulancia ambulancia;

        // Constructor: Default
        public Asignacion_Detalle () {
            this.id_asignacion_detalle = 0;
            //this.id_asignacion_cabecera = 0;
            this.conductor = null;
            this.ambulancia = null;
        }

        // Constructor: Parameterized
        public Asignacion_Detalle (Peticion peticion,Conductor conductor, Ambulancia ambulancia) {
            //this.id_asignacion_cabecera = id_asignacion_cabecera;
            this.peticion = peticion;
            this.conductor = conductor;
            this.ambulancia = ambulancia;
        }

        // Getters & Setters
        public int Id_asignacion_detalle { get => id_asignacion_detalle; set => id_asignacion_detalle = value; }
        public Conductor Conductor { get => conductor; set => conductor = value; }
        public Ambulancia Ambulancia { get => ambulancia; set => ambulancia = value; }
        public int Id_asignacion_cabecera { get => id_asignacion_cabecera; set => id_asignacion_cabecera = value; }
        public Peticion Peticion { get => peticion; set => peticion = value; }

        // ToString
        public override string ToString () {
            return
                "\r\nConductor: " + conductor.ToString () +
                "\r\nAmbulancia: " + ambulancia.ToString ();
        }

    }
}

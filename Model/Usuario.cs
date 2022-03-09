using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Usuario {

        // Variables
        private int id_usuario;
        private string correo;
        private string nombre_usuario;
        private string contrasenia;

        // Constructor: Default
        public Usuario () {
            this.id_usuario = 0;
            this.correo = "";
            this.nombre_usuario = "";
            this.contrasenia = "";
        }

        // Constructor: Parameterized
        public Usuario (int id_usuario, string correo, string nombre_usuario, string contrasenia) {
            this.id_usuario = id_usuario;
            this.correo = correo;
            this.nombre_usuario = nombre_usuario;
            this.contrasenia = contrasenia;
        }

        // Getters & Setter
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }

        public override string ToString () {
            return
                "\r\nCorreo: " + correo +
                "\r\nNombre de Usuario" + nombre_usuario +
                "\r\nConstraseña" + contrasenia;
        }
    }
}

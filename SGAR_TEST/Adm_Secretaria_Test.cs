using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST {
    [TestClass]
    public class Adm_Secretaria_Test {

        #region Test Methods: Registrar

        [TestMethod]
        public void InsertarDatosSecretaria_SecretariaExistente () {
            Adm_Secretaria admSecretaria = Adm_Secretaria.GetAdm ();
            string
                mensaje = "",
                cedula = "9876543210",
                nombre1 = "María",
                nombre2 = "Alejandra",
                apellido1 = "García",
                apellido2 = "Mero",
                correo = "maria.garcia@ug.edu.ec",
                telefono = "0987542133",
                sexo = "Femenino",
                nombre_usuario = "MaAl",
                contrasenia1 = "123";
            DateTime
                fecha_nac = new DateTime (1999, 11, 16),
                fecha_contrato = new DateTime (2022, 01, 05);
            mensaje = admSecretaria.guardarDatosSecretaria (cedula, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fecha_nac, fecha_contrato, nombre_usuario, contrasenia1);
            Assert.AreEqual ("¡DATOS NO GUARDADOS!", mensaje);
        }

        /*
        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaNueva () {
            var admA = new Adm_Ambulancia ();
            int tipoA = 1, capacidad = 2;
            string placa = "ACD234", modelo = "modeloxtest2", observacion = "No tiene material de asistencia", msj = "";

            msj = admA.InsertarDatosAmbulancia (placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual ("Los datos se insertaron exitosamente", msj);
        }
        */
        #endregion

        /*
        [TestMethod]
        public void ConsultarAmbulancia_NoExistenRegistros () {
            var admA = new Adm_Ambulancia ();
            DataTable dt = new DataTable ();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "RFG", msj = "";

            dt = admA.ConsultarAmbulancias (dato, tipoA, disponibilidad, buscarOb, buscarOp);

            msj = dt.Rows.Count.ToString ();

            Assert.AreEqual ("0", msj);
        }

        [TestMethod]
        public void ConsultarAmbulancia_ExistenRegistros () {
            var admA = new Adm_Ambulancia ();
            DataTable dt = new DataTable ();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "ABC", msj = "";

            dt = admA.ConsultarAmbulancias (dato, tipoA, disponibilidad, buscarOb, buscarOp);
            if (dt.Rows.Count > 0) {
                msj = "Se encontraron los registros";
            }

            Assert.AreEqual ("Se encontraron los registros", msj);
        }
        */
    }
}

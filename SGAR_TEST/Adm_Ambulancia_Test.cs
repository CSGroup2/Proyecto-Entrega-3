using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Ambulancia_Test
    {
        
        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaExistente()
        {
            Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
            int tipoA = 2, capacidad = 3;
            string placa = "ABC123", modelo = "modeloxtest", observacion = "NN", msj = "";

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);

            Assert.AreEqual("La ambulancia ya está registrada", msj);
        }

        //NOTA: CAMBIAR LOS DATOS DE INSERTAR AMBULANCIA NUEVA PARA QUE EJECUTE CON ÉXITO
        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaNueva()
        {
            Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
            int tipoA = 1, capacidad = 2;
            string placa = "ACD234", modelo = "modeloxtest2", observacion = "No tiene material de asistencia", msj = "";

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);

            Assert.AreEqual("Los datos se insertaron exitosamente", msj);
        }

        [TestMethod]
        public void ConsultarAmbulancia_NoExistenRegistros()
        {
            Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
            DataTable dt = new DataTable();
            int tipoA = 1, disponibilidad = 1, buscarOb =1, buscarOp = 2;
            string dato = "RFG", msj = "";

            dt = admA.ConsultarAmbulancias(dato, tipoA, disponibilidad, buscarOb, buscarOp);

            if (dt.Rows.Count == 0)
            {
                msj = "No hay registros con esos datos";
            }
            
            Assert.AreEqual("No hay registros con esos datos", msj);
        }

        [TestMethod]
        public void ConsultarAmbulancia_ExistenRegistros()
        {
            Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
            DataTable dt = new DataTable();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "ABC", msj = "";

            dt = admA.ConsultarAmbulancias(dato, tipoA, disponibilidad, buscarOb, buscarOp);
            if (dt.Rows.Count > 0)
            {
                msj = "Se encontraron los registros";
            }

            Assert.AreEqual("Se encontraron los registros", msj);
        }
    }
}

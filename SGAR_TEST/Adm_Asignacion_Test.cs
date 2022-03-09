using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Asignacion_Test
    {
        [TestMethod]
        public void guardarAsignacion_AsignacionNueva()
        {
            Adm_Asignacion admAs = Adm_Asignacion.GetAdm();
            string msj = "";
            Asignacion_Detalle acD = new Asignacion_Detalle();
            Asignacion_Cabecera asC = new Asignacion_Cabecera();
            Peticion p = new Peticion();
            Secretaria s = new Secretaria();
            Conductor c = new Conductor();
            Ambulancia a = new Ambulancia();
            List<Asignacion_Detalle> ad = new List<Asignacion_Detalle>();
            List<Asignacion_Cabecera> ac = new List<Asignacion_Cabecera>();
            p.Id_peticion = 100;
            s.Id_secretaria = 100;
            c.Id_conductor = 100;
            a.Id_ambulancia = 101;


            acD = new Asignacion_Detalle(p,c,a);
            ad.Add(acD);
            asC = new Asignacion_Cabecera(p, s, "En Progreso", ad);
            ac.Add(asC);


            msj = admAs.guardarAsignacionBD(ac,ad);


            Assert.AreEqual("La Asignación fue ingresada correctamente.", msj);
        }

        [TestMethod]
        public void guardarAsignacion_AsignacionFallida()
        {
            Adm_Asignacion admAs = Adm_Asignacion.GetAdm();
            string msj = "";
            Asignacion_Detalle acD = new Asignacion_Detalle();
            Asignacion_Cabecera asC = new Asignacion_Cabecera();
            Peticion p = new Peticion();
            Secretaria s = new Secretaria();
            Conductor c = new Conductor();
            Ambulancia a = new Ambulancia();
            List<Asignacion_Detalle> ad = new List<Asignacion_Detalle>();
            List<Asignacion_Cabecera> ac = new List<Asignacion_Cabecera>();
            p.Id_peticion = 1;
            s.Id_secretaria = 1;
            c.Id_conductor = 1;
            a.Id_ambulancia = 1;


            acD = new Asignacion_Detalle(p, c, a);
            ad.Add(acD);
            asC = new Asignacion_Cabecera(p, s, "En Progreso", ad);
            ac.Add(asC);


            msj = admAs.guardarAsignacionBD(ac, ad);


            Assert.AreEqual("Error no se pudo ingresar la asignacion", msj);
        }
    }
}

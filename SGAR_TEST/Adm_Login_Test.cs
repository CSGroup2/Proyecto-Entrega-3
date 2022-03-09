using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Login_Test
    {
        

        //Metodo que comprueba que se puede iniciar sesion exitosamente
        [TestMethod]
        public void Inicio_de_sesion_Exitoso()
        {
            Adm_Login admlogin = Adm_Login.GetAdm();
            bool  respuesta;
            string usuario = "Stefan45S",
            contrasenia = "12345";
            //
            respuesta = admlogin.LoginUser(usuario, contrasenia);

            Assert.IsTrue(respuesta);
        }


        // Metodo de prueba que nos asegura que solo se puede ingresar con credenciales existentes
        [TestMethod]
        public void Inicio_de_sesion_Fallido()
        {
            Adm_Login admlogin = Adm_Login.GetAdm();
            bool respuesta;
            string usuario = "Veronica45M",
            contrasenia = "12345";
            //
            respuesta = admlogin.LoginUser(usuario, contrasenia);

            Assert.IsFalse(respuesta);
        }
    }
}

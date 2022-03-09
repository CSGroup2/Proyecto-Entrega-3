using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Cliente_Test
    {
        //Metodo de prueba que nos asegura que no se pueden ingresar clientes con un mismo número de cedula
        [TestMethod]
        public void InsertarDatosCliente_CedulaExistente()
        {
            Adm_Cliente admclient = Adm_Cliente.GetAdm();
            string msj = "";
            string cedula = "0914201033",
                nombre1 = "Helen",
                nombre2 = "Lisbeth",
                apellido1 = "Bernal",
                apellido2 = "Veliz",
                correo = "helenlbernalv@hotmail.com",
                telefono = "0992015890",
                sexo = "Femenino",
                usuario = "HeBe45",
                contra = "12345";
                DateTime fechanac = DateTime.Now;
                int Id_hospital = 100;
            //

            msj = admclient.guardarDatosCliente(cedula, Id_hospital, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechanac, usuario, contra);


            Assert.AreEqual("¡Error el numero de cedula o usuario ya existen! \n DATOS NO GUARDADOS", msj);
        }
        
        // Metodo de prueba que nos asegura que no se pueden ingresar clientes con un mismo nombre de usuario
        [TestMethod]
        public void InsertarDatosCliente_NombreUsurExistente()
        {
            Adm_Cliente admclient = Adm_Cliente.GetAdm();
            string msj = "";
            string cedula = "0921537642",
                nombre1 = "Billy",
                nombre2 = "Juan",
                apellido1 = "Alvear",
                apellido2 = "Perez",
                correo = "nbillyperez@hotmail.com",
                telefono = "0992015890",
                sexo = "Masculino",
                usuario = "Helen45S",
                contra = "12345";
            DateTime fechanac = DateTime.Now;
            int Id_hospital = 100;
            //

            msj = admclient.guardarDatosCliente(cedula, Id_hospital, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechanac, usuario, contra);

            Assert.AreEqual("¡Error el numero de cedula o usuario ya existen! \n DATOS NO GUARDADOS", msj);
        }


        // El metodo de prueba de abajo esta comentado ya que solo se puede ejecutar una vez debido a que el
        // registro se ingresa correctamente a la base, si 
        //se va a probar este metodo cambiar los datos respectivamente
        /*
        [TestMethod]
        public void InsertarDatosCliente_RegistroExitoso()
        {
            Adm_Cliente admclient = Adm_Cliente.GetAdm();
            string msj = "";
            string cedula = "0953145287",
                nombre1 = "Damon",
                nombre2 = "Stefan",
                apellido1 = "Salvatore",
                apellido2 = "Real",
                correo = "damonsalvatorepet@hotmail.com",
                telefono = "0992015891",
                sexo = "Masculino",
                usuario = "DamonSalvatore45",
                contra = "12345";
            DateTime fechanac = DateTime.Now;
            int Id_hospital = 100;
            //

            msj = admclient.guardarDatosCliente(cedula, Id_hospital, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechanac, usuario, contra);

            Assert.AreEqual("DATOS GUARDADOS CORRECTAMENTE.", msj);
        }*/
                
    }
}

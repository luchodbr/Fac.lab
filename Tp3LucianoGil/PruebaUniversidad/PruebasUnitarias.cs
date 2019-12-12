using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesInstanciables;
using EntidadesAbstractas;
using Archivos;
namespace PruebaUniversidad
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void ValidarExcepcionDni()
        {
            Profesor p = new Profesor(2, "Roberto", "Juarez", "-1",
             EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Jornada j = new Jornada(Universidad.EClases.Laboratorio, p);
            Jornada.Guardar(j);

        }
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void ValidarExcepcioAlumnoRep()
        {
            Alumno a = new Alumno(2, "Roberto", "Juarez", "10",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno b = new Alumno(2, "Roberto", "Juarez", "10",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Universidad u = new Universidad();
            u += a;
            u += b;
        }
        [TestMethod]
        public void TestDniAmbosCasos()
        {
            Alumno a = new Alumno(2, "Roberto", "Juarez", "10",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            //string prueba = "diez";
            string prueba = "10";
            Alumno b = new Alumno(2, "Roberto", "Juarez", prueba,
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            // Assert.AreNotEqual(b.DNI, a.DNI);
            Assert.AreEqual(b.DNI, a.DNI);
        }
        [TestMethod]
        public void TestUniClasesJorn()
        {
            Profesor p = new Profesor(2, "Roberto", "Juarez", "10",
             EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Universidad u = new Universidad();
            try
            {
                u += Universidad.EClases.Laboratorio;
                u += Universidad.EClases.Programacion;
                u += Universidad.EClases.SPD;
                u += Universidad.EClases.Legislacion;
            }
            catch (Exception e)
            {             

            }
            foreach (Jornada j in u.Jornadas)
            {
                Assert.AreEqual(j, p);
            }

        }


    }
}
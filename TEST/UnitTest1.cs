using BE;
using DAL;
using NUnit.Framework;
using System;

namespace TEST
{
    public class Tests
    {

        Empleado unEmpleado;
        EmpleadoDAL empleadoDAL;

        [SetUp]
        public void Setup()
        {
            unEmpleado = new Empleado();
            unEmpleado.Nombre = "Juan";
            unEmpleado.Apellido = "Perez";
            unEmpleado.NumeroRepresentante = 4483;
            unEmpleado.Rol = TipoEmpleado.TecnicoDomiciliario;

            empleadoDAL = new EmpleadoDAL();
        }

        [Test]
        public void TestEmpleadoDAL()
        {
            empleadoDAL.Create(unEmpleado);

            Assert.AreEqual(unEmpleado.Id, 1);

            Empleado empleadoRecuperado = empleadoDAL.GetById(1);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado.Nombre);

            unEmpleado.Nombre = "Ramon";

            empleadoDAL.Update(unEmpleado);

            Empleado empleadoRecuperado2 = empleadoDAL.GetById(1);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado2.Nombre);

            Assert.AreEqual(empleadoDAL.GetAll().Count, 1);

            empleadoDAL.Delete(unEmpleado);

            Assert.AreEqual(0, empleadoDAL.GetAll().Count);

        }
    }
}
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
            unEmpleado.TipoEmpleado = TipoEmpleado.TecnicoDomiciliario;

            empleadoDAL = new EmpleadoDAL();
        }

        [Test]
        public void TestEmpleadoDAL()
        {
            int nextID = empleadoDAL.GetNextId();

            empleadoDAL.Create(unEmpleado);
            
            Assert.AreEqual(nextID, unEmpleado.Id);

            Empleado empleadoRecuperado = empleadoDAL.GetById(nextID);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado.Nombre);

            unEmpleado.Nombre = "Ramon";

            empleadoDAL.Update(unEmpleado);

            Empleado empleadoRecuperado2 = empleadoDAL.GetById(nextID);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado2.Nombre);

            empleadoDAL.Delete(unEmpleado);

            Empleado empleadoBorrado = empleadoDAL.GetById(nextID);

            Assert.IsNull(empleadoBorrado.Nombre);
        }
    }
}
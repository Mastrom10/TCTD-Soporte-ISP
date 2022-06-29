using BE;
using DAL;
using NUnit.Framework;
using System;
using SERV;
using BLL;


namespace TEST
{
    public class CryptografyTest
    {
        [Test]
        public void Test()
        {
            string expected = "this is my test string";
            //log expected
            Console.WriteLine("Valor Original: " + expected);

            string a = expected.Crypt();
            Console.WriteLine("Valor Encriptado: " + a);
            
            string actual = a.Decrypt();
            Console.WriteLine("Valor DesEncriptado: " + actual);

            Assert.AreEqual(expected, actual);
        }

    }
}

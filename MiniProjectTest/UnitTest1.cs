using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiniProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllCustomers_ShouldReturnAllCustomers()

        {
            var testCustomers = GetAllCustomers();
        }

        private static object GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
    
}

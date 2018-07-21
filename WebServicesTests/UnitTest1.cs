using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using WebServices.Controllers;



namespace WebServicesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           var controller = new ValuesController();
           var response = controller.Get(1);
           var contentResult = response;
            // Assert the result  
           Assert.IsNotNull(contentResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new ValuesController();
            IEnumerable<string> test = controller.Get();

            var values = string.Join(",",test);
            Assert.AreEqual("value1,value2",values);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var controller = new ValuesController();
            IEnumerable<string> test = controller.Get();

            string[] values = new string[] { "value1", "value2" };
            Assert.AreNotEqual(values, test);            
        }

        [TestMethod]
        public void TestMethod4()
        {
            var controller = new ValuesController();
            var response = controller.Get(1);
            var contentResult = response;
            
            // Assert the result  
            Assert.IsNotNull(contentResult);
            Assert.AreEqual("value",contentResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            new Email();
                
            // Assert the result  
            /// Assert.IsNotNull(contentResult);
            /// Assert.AreEqual("value", contentResult);
        }
    }
}

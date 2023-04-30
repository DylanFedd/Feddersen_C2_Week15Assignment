using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group_4_DB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_4_DBTests;
using Microsoft.AspNetCore.Mvc;

namespace Group_4_DB.Controllers.Tests
{
    [TestClass()]
    public class InstructorsControllerTests
    {
        [TestMethod()]
        public async Task GetInstructorsTest()
        {
            var dbContext = ContextBuilder.CreateContext();
            var test = "badID";
            var controller = new InstructorsController(dbContext);
            var result = await controller.GetInstructors(test);
            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }

        [TestMethod()]
        public async Task ValidGetInstructorsTest()
        {
            var dbContext = ContextBuilder.CreateContext();
            var test = "I001";
            var controller = new InstructorsController(dbContext);
            var result = await controller.GetInstructors(test);
            Assert.IsNotNull(result.Value);
        }
    }
}
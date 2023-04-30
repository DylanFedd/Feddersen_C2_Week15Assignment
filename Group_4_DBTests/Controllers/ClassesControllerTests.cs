using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group_4_DB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group_4_DB.Data;
using Group_4_DBTests;

namespace Group_4_DB.Controllers.Tests
{
    [TestClass()]
    public class ClassesControllerTests
    {
        [TestMethod()]
        public async Task GetClassesTest()
        {
            var dbContext = ContextBuilder.CreateContext();
            var test = "badID";
            var controller = new ClassesController(dbContext);
            var result = await controller.GetClasses(test);
            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }

        [TestMethod()]
        public async Task ValidGetClassesTest()
        {
            var dbContext = ContextBuilder.CreateContext();
            var test = "C001";
            var controller = new ClassesController(dbContext);
            var result = await controller.GetClasses(test);
            Assert.IsNotNull(result.Value);
        }
    }
}
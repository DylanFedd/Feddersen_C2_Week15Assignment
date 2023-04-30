using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group_4_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_4_DB.Controllers;

namespace Group_4_DB.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager Auth = new JwtAuthenticationManager("testForValidLogin");

            User user = new User
            {
                username = "test",
                password = "password"
            };

            var ret = Auth.Authenticate(user.username, user.password);

            Assert.IsNotNull(ret);
        }
    }
}
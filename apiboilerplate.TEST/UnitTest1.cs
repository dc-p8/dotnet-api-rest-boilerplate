using System;
using NUnit.Framework;
using NLog;
using Moq;
using apiboilerplate.DAL;
using apiboilerplate.DAL.Models;
using apiboilerplate.Controllers;
using System.Web.Http.Results;
using System.Web.Http;

namespace apiboilerplate.TEST
{
    [TestFixture]
    public class UnitTest1
    {
        private ILogger _log;

        [OneTimeSetUp]
        public void init()
        {
            this._log = new Mock<ILogger>().Object;
        }

        [Test]
        public void TestMethod1()
        {
            var repoMock = new Mock<IRepo>();
            repoMock.Setup(x => x.GetOne(It.IsAny<int>())).Returns(new User {Name="test"});

            var controller = new UserController(repoMock.Object, _log);
            IHttpActionResult actionresult = controller.GetName(0);

            var content = actionresult as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(content);
            Assert.AreEqual("test", content.Content);
        }
    }
}

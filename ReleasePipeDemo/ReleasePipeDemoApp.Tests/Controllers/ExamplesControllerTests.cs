﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleasePipeDemoApp;
using ReleasePipeDemoApp.Controllers;

namespace ReleasePipeDemoApp.Tests.Controllers
{
    /// <summary>
    /// Summary description for ExamplesControllerTests
    /// </summary>
    [TestClass]
    public class ExamplesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

    }
}

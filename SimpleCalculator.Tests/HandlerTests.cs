﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class HandlerTests
    {
        Handler TestHandler = new Handler();

        [TestMethod]
        public void CanInstantiateAnInstanceOfHandler()
        {
            Assert.IsNotNull(TestHandler);
        }
    }
}

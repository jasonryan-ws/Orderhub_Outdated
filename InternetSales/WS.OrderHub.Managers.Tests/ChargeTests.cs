﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.OrderHub.Models;

namespace WS.OrderHub.Managers.Tests
{
    [TestClass]
    public class ChargeTests
    {
        [TestMethod]
        public void GetByIdAndNameTest()
        {
            var model = ChargeManager.Get("Tax");
            var result = ChargeManager.Get(model.Id);
            Assert.AreEqual(model.Id, result.Id);
        }

        [TestMethod]
        public void GetAll()
        {
            var result = ChargeManager.GetAsync().Result;
            Assert.AreEqual(result.Count, 3);
        }

        [TestMethod]
        public void CreateTest()
        {
            var model = new ChargeModel();
            model.Name = "Reimbursement";
            model.Description = "Reimbursement charge";
            //model.CreatedByNodeId = NodeManager.GetAsync("IS-SERVER").Result.Id;
            var result = ChargeManager.Create(model, null, true);
            Assert.AreNotEqual(Guid.Empty, model.Id);
        }
    }
}

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
    public class BinTests
    {
        [TestMethod]
        public void CreateTest()
        {
            var model = new BinModel();
            model.Name = "TestBin-01";
            model.IsReserved = false;
            model.IsDefault = true;
            //model.CreatedByNodeId = NodeManager.GetAsync("IS-JASON").Result.Id;
            var result = BinManager.Create(model, false, true);
            Assert.AreNotEqual(model.Id, Guid.Empty);
        }

        [TestMethod]
        public void CreateForceUpdateTest()
        {
            var model = new BinModel();
            model.Name = "TestBin-T";
            model.IsReserved = true;
            model.IsDefault = true;
            //model.CreatedByNodeId = NodeManager.GetAsync("IS-SERVER").Result.Id;
            var result = BinManager.Create(model, true);
            Assert.AreNotEqual(model.Id, Guid.Empty);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var model = BinManager.Get("TestBin-T");
            model.IsReserved = true;
            model.IsDefault = true;
            //model.ModifiedByNodeId = NodeManager.GetAsync("IS-SERVER").Result.Id;
            var result = BinManager.Update(model, true);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void RenameTest()
        {
            var model = BinManager.Get("TestBin-T");
            model.Name = "TestBin-T_Renamed";
            model.IsReserved = true;
            model.IsDefault = true;
            //model.ModifiedByNodeId = NodeManager.GetAsync("IS-SERVER").Result.Id;
            var result = BinManager.Update(model, true);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var model = BinManager.Get("TestBin-T");
            var result = BinManager.Get(model.Id);
            Assert.AreEqual(model.Name, result.Name);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var result = BinManager.GetAsync().Result;
            Assert.AreEqual(3, result.Count);
        }
    }
}

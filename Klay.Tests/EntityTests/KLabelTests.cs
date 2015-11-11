using KLay.Core.KGraph;
using KLay.Core.KGraph.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klay.Tests.EntityTests
{
    [TestClass]
    public class KLabelTests
    {
        [TestMethod]
        public void SetKLabelParentToNull()
        {
            KNode parentNode = new KNode();
            KLabel label = new KLabel();

            label.Parent = parentNode;

            label.Parent = null;

            Assert.AreEqual(null, label.Parent);
            Assert.AreEqual(0, parentNode.LabelList.Count);
        }

        [TestMethod]
        public void UpdatingParentNodeOnLabelUpdatesLabelList()
        {
            KNode parentNode = new KNode();
            KLabel label = new KLabel();

            label.Parent = parentNode;

            Assert.AreEqual(label, parentNode.LabelList[0]);

        }

        [TestMethod]
        public void ChangeParentForAKLabelParentsAreUpdated()
        {
            KNode oldParent = new KNode();
            KNode newParent = new KNode();
            KLabel label = new KLabel();

            label.Parent = oldParent;
            label.Parent = newParent;

            Assert.AreEqual(0, oldParent.LabelList.Count);
            Assert.AreEqual(1, newParent.LabelList.Count);
            Assert.AreEqual(label, newParent.LabelList[0]);

        }
    }
}

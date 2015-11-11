using KLay.Core.KGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klay.Tests.EntityTests
{
    [TestClass]
    public class KNodeTests
    {
        [TestMethod]
        public void AddParentsOfAKNode_ChildListisUpdated()
        {
            KNode parentNode = new KNode();
            KNode childNode = new KNode();
            childNode.Parent = parentNode;

            Assert.AreEqual(parentNode.Children.Count, 1);
            Assert.AreEqual(childNode, parentNode.Children[0]);
            
        }

        [TestMethod]
        public void ChangeParentsOfKNode_ChildListIsChanged()
        {
            KNode oldParent = new KNode();
            KNode childNode = new KNode();
            childNode.Parent = oldParent;

            KNode newParent = new KNode();
            childNode.Parent = newParent;

            Assert.AreEqual(newParent.Children.Count, 1);
            Assert.AreEqual(oldParent.Children.Count, 0);
            Assert.AreEqual(childNode, newParent.Children[0]);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddKNodeRecursiveParentChild_ThrowsException()
        {
            KNode parentNode = new KNode();
            KNode childNode = new KNode();
            childNode.Parent = parentNode;
            parentNode.Parent = childNode;
        }

        [TestMethod]
        public void SetTheKNodeParentToNull()
        {
            KNode parentNode = new KNode();
            KNode childNode = new KNode();
            childNode.Parent = parentNode;

            childNode.Parent = null;

            Assert.AreEqual(null, childNode.Parent);
        }


    }
}

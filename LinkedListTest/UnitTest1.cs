using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenData_WhenSearched_ShouldReturnNodeContainingThatData()
        {
            int data = 30;
            LinkedList list = new LinkedList();
            list.AddToBack(56);
            list.AddToBack(30);
            list.AddToBack(70);
            Node node = list.Search(30);
            Assert.AreEqual(data, node.data);
        }
    }
}
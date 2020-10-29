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

        [TestMethod]
        public void Given3Numbers_WhenInsertingSecondInBetween_ShouldPassLinkedListResult()
        {
            LinkedList list = new LinkedList();
            list.AddToBack(56);
            list.AddToBack(30);
            list.AddToBack(70);
            list.InsertAfterValue(30, 40);
            Node node = list.Search(30);
            Node actual = node.next;
            Node expected = list.Search(40);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GivenALinkedListNumbers_WhenDeletingANodeWithGivenValue_ShouldPassLinkedListResult()
        {
            int expected = 70;
            LinkedList list = new LinkedList();
            list.AddToBack(56);
            list.AddToBack(30);
            list.AddToBack(40);
            list.AddToBack(70);
            list.DeleteWithValue(40);
            Node node = list.Search(30);
            int actual = node.next.data;
            Assert.AreEqual(expected, actual);
        }
    }
}
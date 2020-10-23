using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures_LinkedList;

namespace MsTestLinkedList
{
    [TestClass]
    public class TestMethod
    {
        /// <summary>
        /// TC UC 7.1
        /// </summary>
        /// <param name="searchData"></param>
        [DataRow(30)]
        [TestMethod]
        public void SearchForElementTest(int searchData)
        {
            //Arrange
            bool expected = true;
            LinkedList list = new LinkedList();
            //Act
            bool actual = list.Search(searchData);
            //Assert
            Assert.AreEqual(expected, actual);          
        }
    }
}

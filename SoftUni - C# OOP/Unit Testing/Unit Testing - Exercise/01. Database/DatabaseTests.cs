namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void SetUp()
        {
            // this will be run before every test
            this.database = new Database();
        }
        // Valid functionality of constructor
        //1 -> edge case (no data); 2,3 -> Valid data (success), 4 -> edge case (max data)
        //This test is meant to test the constructor and nothing more! Single responsibility!
        //I assume the Fetch() method and the Count getter to be working fine
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]

        public void ConstructorShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            //Arrange
            Database testDb = new Database(elementsToAdd);

            //Act
            int[] actualData = testDb.Fetch();
            int[] expectedData = elementsToAdd;

            int actualCount = testDb.Count;
            int expectedCount = expectedData.Length;

            //Assert
            CollectionAssert.AreEqual(expectedData, actualData, "Database constructor should initialize data field correctly!");
            Assert.AreEqual(expectedCount, actualCount, "Constructor should set initial value for count field!");
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void ConstructorMustNotAllowToExceedMaximumCount(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testdb = new Database(elementsToAdd);
            }, "Array's capacity must be exactly 16 integers!");
        }
        //Valid functionality of count
        //I assume that the constructor is working fine (I tested it!)
        [Test]
        public void CountMustReturnActualCount()
        {
            int[] initData = new int[] { 1, 2, 3 };
            Database database = new Database(initData);
            int actualCount = database.Count;
            int expectedCount = initData.Length;
            Assert.AreEqual(expectedCount, actualCount, "Count should return the count of the added elements!");

        }
        [Test]
        public void CountMustReturnZeroWhenNoElements()
        {
            int actualCount = this.database.Count;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, actualCount, "Count should be zero when there are no elements in the Database!");
        }
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            foreach (var element in elementsToAdd)
            {
                this.database.Add(element);
            }
            int[] actualData = this.database.Fetch();
            int[] expectedData = elementsToAdd;

            int actualCount = this.database.Count;
            int expectedCount = expectedData.Length;

            CollectionAssert.AreEqual(expectedData, actualData, "Add should physically add the elements to the field!");
            Assert.AreEqual(expectedCount, actualCount, "Add should change the elements count when adding!");
        }
        [Test]
        public void AddShouldThrowExceptionWhenAddingMoreThan16Elements()
        {
            //Act
            for (int i = 1; i <= 16; i++)
            {
                this.database.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(17);
            }, "Array's capacity must be exactly 16 integers!");
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 })]
        public void RemoveShouldRemoveTheLastElementSuccessfullyOnce(int[] startElements)
        {
            //Act
            foreach (var element in startElements)
            {
                this.database.Add(element);
            }
            this.database.Remove();
            List<int> elementList = new List<int>(startElements);
            elementList.RemoveAt(elementList.Count - 1);

            int[] actualData = this.database.Fetch();
            int[] expectedData = elementList.ToArray();

            int actualCount = this.database.Count;
            int expectedCount = expectedData.Length;

            CollectionAssert.AreEqual(expectedData, actualData, "Remove should physically remove the element in the data field!");
            Assert.AreEqual(expectedCount, actualCount, "Remove should decrement the count of the Database!");
        }
        [Test]
        public void RemoveShouldRemoveTheLastElementMoreThanOnce()
        {
            List<int> startData = new List<int>() { 1, 2, 3 };
            foreach (var element in startData)
            {
                this.database.Add(element);
            }
            for (int i = 0; i < startData.Count; i++)
            {
                this.database.Remove();
            }
            int[] actualData = this.database.Fetch();
            int[] expectedDate = new int[] { };

            int actualCount = this.database.Count;
            int expectedCount = 0;

            CollectionAssert.AreEqual(expectedDate, actualData, "Remove should physically remove the element in the data field!");
            Assert.AreEqual(expectedCount, actualCount, "Remove should decrement the count of the Database!");

        }
        [Test]
        public void RemoveShouldThrowErrorWhenThereAreNoElements()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Remove();
            }, "The collection is empty!");
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCopyArray(int[] initData)
        {
            //Act
            foreach (int element in initData)
            {
                this.database.Add(element);
            }

            int[] actualResult = this.database.Fetch();
            int[] expectedResult = initData;

            CollectionAssert.AreEqual(expectedResult, actualResult,"Fetch should return copy of the existing data!");
        }
    }      
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;



namespace Test
{
    [TestClass]
    public class UnitTest1
    {







        [TestMethod]
        public void CaptureValues_something_something()
        {
            //Arrange
            
            //create an Array [0, 1, 2]
            //valueIndex0 == 0, etc.
            //Act
            //read value at a specified index
            //Assert
            //valueIndex0 == 0
            //valueIndex1 == 1
            //valueIndex2 == 2
        }

        [TestMethod]
        public void Add_something_AddIntToEndOfArray()
        {
            //Arrange
            //Add a value of 4 to index 3
            MyList<int> list = new MyList<int>() { 1, 2, 3 };
            int addedValue = 4;
            int expectedValue = 4;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], expectedValue); 
            //Assert.value at index 3 is 4
        }

        public void Add_something_AddStringToEndOfArray()
        {
            //Arrange
            //Add a value of "four" to index 3
            MyList<string> list = new MyList<string>() { "one", "two", "three" };
            string addedValue = "four";
            string expectedValue = "four";
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], expectedValue);
            //Assert.value at index 3 is "four"
        }

        public void Add_something_AddDoubleToEndOfArray()
        {
            //Arrange
            //Add a value of 3 to index 3
            MyList<double> list = new MyList<double>() { 1.1, 2.2, 3.3 };
            double addedValue = 4.4;
            double expectedValue = 4.4;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], expectedValue);
            //Assert.value at index 3 is 3
        }




        [TestMethod]
        public void Add_TestValue_AtAddedIndex()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int addedValue = 3;
            int expectedValue = 3;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual<int>(addedValue, list[0]);
        }


        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //Act
            //Assert
        }


        


















    }
}

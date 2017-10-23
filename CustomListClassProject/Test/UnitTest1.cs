using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;



namespace Test
{
    [TestClass]
    public class UnitTest1
    {







        //[TestMethod]
        //public void CaptureValues_something_something()
        //{
        //    //Arrange
        //    //create an Array [0, 1, 2]
        //    //valueIndex0 == 0, etc.
        //    //Act
        //    //read value at a specified index
        //    //Assert
        //    //valueIndex0 == 0
        //    //valueIndex1 == 1
        //    //valueIndex2 == 2
        //}

        [TestMethod]
        public void Add_something_AddIntToEndOfArray()
        {
            //Arrange
            //Add a value of 4 to index 3
            MyList<int> list = new MyList<int>() { 1, 2, 3 };
            int addedValue = 4;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], addedValue); 
            //Assert.value at index 3 is 4
        }

        public void Add_something_AddStringToEndOfArray()
        {
            //Arrange
            //Add a value of "four" to index 3
            MyList<string> list = new MyList<string>() { "one", "two", "three" };
            string addedValue = "four";
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], addedValue);
            //Assert.value at index 3 is "four"
        }

        public void Add_Double_ToEndOfArray()
        {
            //Arrange
            //Add a value of 4.4 to index 3
            MyList<double> list = new MyList<double>() { 1.1, 2.2, 3.3 };
            double addedValue = 4.4;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], addedValue);
            //Assert.value at index 3 is 4.4
        }

        public void Add_Bool_ToEndOfArray()
        {
            //Arrange
            //Add a value of true to index 3
            MyList<bool> list = new MyList<bool>() { false, false, false };
            bool addedValue = true;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual(list[3], addedValue);
            //Assert.value at index 3 is true
        }


        [TestMethod]
        public void Add_TestValue_AtAddedIndex()
        {
            //Arrange
            MyList<int> list = new MyList<int>() { 1, 2, 3 };
            int addedValue = 4;
            //Act
            list.Add(addedValue);

            //Assert
            Assert.AreEqual<int>(list[3], addedValue);
        }

        [TestMethod]
        public void Add_AddArray_ToEndOfArray()
        {
            //Arrange
            //Add array [4, 5, 6] to the end of [1, 2, 3];
            MyList<Array> myList = new MyList<Array>();
            Array arrayToAdd = new Array[3];
            myList = [1, 2, 3];
            arrayToAdd = [4, 5, 6];
             
            //Act
            myList.Add(arrayToAdd);

            //Assert
            
            //final array is of length 6, [1, 2, 3, 4, 5, 6]
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

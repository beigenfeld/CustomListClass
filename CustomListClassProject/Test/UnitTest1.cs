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
        public void Add_Int_ToEndOfArray()
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

        public void Add_String_ToEndOfArray()
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
        public void Add_Array_ToIndex()
        {
            //Arrange
            //Add array [4, 5, 6] to index 0;
            MyList<Array> myList = new MyList<Array>();
            int[] arrayToAdd = { 4, 5, 6 };
            
            
            //Act
            myList.Add(arrayToAdd);

            //Assert
            Assert.AreEqual(myList[0], arrayToAdd);
            //
        }

        [TestMethod]
        public void Add_Count_Increments()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int valueToAdd = 14;
            int expectedLength = 1;

            //Act
            list.Add(valueToAdd);
            //Assert
            Assert.AreEqual(list.Count, expectedLength);
            //Count = 1
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

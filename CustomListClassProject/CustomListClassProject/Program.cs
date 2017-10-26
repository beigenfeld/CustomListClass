using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList1 = new MyList<int>() { 1, 2, 3 };
            MyList<int> myList2 = new MyList<int>() { 4, 5, 6 };
            MyList<int> expected = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            //Act
            MyList<int> result = myList1 + myList2;




            Console.ReadLine();





        }
    }
}

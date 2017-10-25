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
            MyList<int> intList = new MyList<int>() { 1, 2, 3, 4, 5 };
            intList.Add(6);
            Console.WriteLine(intList[5]);

            MyList<bool> boolList = new MyList<bool>() { false, false, false, false, false };
            boolList.Add(true);
            Console.WriteLine(boolList[5]);

            MyList<double> doubleList = new MyList<double>() { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
            doubleList.Add(1.7);
            Console.WriteLine(doubleList[6]);

            MyList<Array> arrayList = new MyList<Array>() { };



            
            Console.ReadLine();





        }
    }
}

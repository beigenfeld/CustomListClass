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

            MyList<int> numberList = new MyList<int>() { 1,2,3,4,5 };
            numberList.Add(6);
            Console.WriteLine(numberList[5]);
            Console.ReadLine();





        }
    }
}

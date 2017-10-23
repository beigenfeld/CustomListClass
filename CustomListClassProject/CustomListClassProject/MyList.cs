using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable<T>
    {






        //Member Variables
        T[] genericArray;
        private int count = 0;

        //properties
        public T this[int index]
        {
            get
            {
                return genericArray[index];
            }

            set
            {
                genericArray[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

        }



        //Constructor
        public MyList()
        {

        }



        //Member Methods
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CaptureValues()
        {

        }

        public void Add(T value)
        {

        }

        private void Zip()
        {

        }

        private void ToStringOverride()
        {

        }


        private void SortBonus()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}

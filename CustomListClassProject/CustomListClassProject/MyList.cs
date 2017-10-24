using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable<T>
    //implement public interface IEnumerator<T>
    {






        //Member Variables
        T[] genericArray;
        T[] tempArray;
        private int count = 0;
        private int capacity;

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
            this.capacity = 5;
            this.genericArray = new T[capacity];
        }


        //Member Methods

        public void CaptureValues()
        {
            
        }

        public bool CheckArrayCapacity()
        {
            if (capacity/2 <= count)
            {
                DoubleArrayCapacity();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DoubleArrayCapacity()
        {
            capacity += capacity;
        }

        public void Add(T data)
        {
            bool ArrayGotDoubled = CheckArrayCapacity();
            if (ArrayGotDoubled)
            {
                tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = genericArray[i];
                }
                tempArray[count] = data;
                genericArray = tempArray;
            }
            else
            {
                genericArray[count] = data;
            }
            count++;
        }

        public void Remove()
        {
            //count--;
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}

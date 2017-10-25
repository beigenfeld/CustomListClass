using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable<T>
    //implement interface IEnumerator<T>
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


        public bool DoesInstanceExist(T data)
        {
            bool instanceExists = false;
            for (int i = 0; i < count; i++)
            {
                if (genericArray[i].Equals(data))
                {
                    instanceExists =  true;
                }
            }
            return instanceExists;
        }

        public int FindFirstInstance(T data)
        {
            for (int i = 0; i < count; i++)
            {
                if (genericArray[i].Equals(data))
                {
                    return i;
                }
            }

            return -1;
            
        }

        public bool Remove(T data)
        {
            bool instanceExists = DoesInstanceExist(data);
            if (instanceExists)
            {
                int firstInstance = FindFirstInstance(data);
                tempArray = new T[count];
                int currentCount = count;
                for (int i = 0; i < currentCount; i++)
                {
                    if (i < firstInstance)/*originalList[i] != originalList[firstInstance]    */
                    {
                        tempArray[i] = genericArray[i];
                    }
                    else if (i==firstInstance)
                    {
                        count--;
                    }
                    else if (i > firstInstance)
                    {
                        tempArray[i-1] = genericArray[i];
                    }

                }
            }
            else
            {
                Console.WriteLine("Instance does not exist in this List. Nothing removed.");
                
            }
            genericArray = tempArray;
            return instanceExists;
        }
        




        public void Zip()
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

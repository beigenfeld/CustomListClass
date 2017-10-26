using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {

        

        //Member Variables
        T[] genericArray;
        T[] tempArray;
        MyList<T> tempList;
        //MyList<T> zippedList;
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

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<T>)genericArray).IsReadOnly;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }



        //Constructor
        public MyList()
        {
            this.capacity = 10;
            this.genericArray = new T[capacity];
        }


        //Member Methods
        
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



        //public override string ToString()
        //{
        //    string newString;
        //    for (int i = 0; i < count; i++)
        //    {

        //        string stringified = genericArray[i].ToString();
        //        return newString += stringified;
        //    }
        //}



        public MyList<T> Zip(MyList<T> myList1, MyList<T> myList2)
        {
            if (IsFirstLonger(myList1, myList2))
            {
                MyList<T> zippedList = new MyList<T>();
                for (int i = 0; i < myList2.count; i++)
                {
                    zippedList.Add(myList1[i]);
                    zippedList.Add(myList2[i]);
                }
                return zippedList;
            }
            else
            {
                MyList<T> zippedList = new MyList<T>();
                for (int i = 0; i < myList1.count; i++)
                {
                    zippedList.Add(myList1[i]);
                    zippedList.Add(myList2[i]);
                }
                return zippedList;
            }
        }


        private void SortBonus()
        {

        }

        //Helper Methods
        public bool CheckArrayCapacity()
        {
            if (capacity / 2 <= count)
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

        public void Clear()
        {
            ((ICollection<T>)genericArray).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)genericArray).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)genericArray).CopyTo(array, arrayIndex);
        }

        public bool AreTheyEqual(MyList<T> myList1, MyList<T> myList2)
        {
            if (myList1.count == myList2.count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFirstLonger(MyList<T> myList1, MyList<T> myList2)
        {
            if (myList1.count>myList2.count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //ublic static Box operator +(Box b, Box c)
        //{
        //    Box box = new Box();
        //    box.length = b.length + c.length;
        //    box.breadth = b.breadth + c.breadth;
        //    box.height = b.height + c.height;
        //    return box;
        //}








    }
}

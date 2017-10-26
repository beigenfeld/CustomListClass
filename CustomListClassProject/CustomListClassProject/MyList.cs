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
            bool arrayGotDoubled = CheckArrayCapacity();
            if (arrayGotDoubled)
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

        public static MyList<T> operator + (MyList<T> myList1, MyList<T> myList2)
        {
            MyList<T> tempList = new MyList<T>();
            for (int i = 0; i < myList1.count; i++)
            {
                tempList.Add(myList1[i]);
            }

            for (int j = 0; j < myList2.count; j++)
            {
                tempList.Add(myList2[j]);
            }
            tempList.count = myList1.count + myList2.count;
            return tempList;
        }


        public static MyList<T> operator - (MyList<T> myList1, MyList<T> myList2)
        {

            MyList<T> tempList = myList1;
            int tempCount = myList1.count;
            for (int i = 0; i<myList2.count; i++)
            {
                for (int j = 0; j<myList1.count; j++)
                {
                        tempList.Remove(myList2[i]);
                        tempCount--;
                }
                
            }
            myList1.count = tempCount;
            myList1 = tempList;
            return myList1;
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
                    if (i < firstInstance)
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



        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                string stringified = genericArray[i].ToString();
                newString += stringified;
            }
            return newString;
        }



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

        public bool DoesInstanceExist(T data)
        {
            bool instanceExists = false;
            for (int i = 0; i < count; i++)
            {
                if (genericArray[i].Equals(data))
                {
                    instanceExists = true;
                }
            }
            return instanceExists;
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


        
        






        }
}

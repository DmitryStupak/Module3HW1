namespace Module3HW1
{
 public class MyList<T>
     where T : IComparable<T>
 {
     private T[] _arr;
     private int _index = 0;

     public MyList()
     {
         _arr = new T[1];
     }

     public MyList(int dim)
     {
         _arr = new T[dim];
     }

     public void Add(T item)
     {
         if (_index >= _arr.Length)
         {
             Resize(1);
         }

         _arr[_index] = item;
         _index++;
     }

     public void AddRange(T[] arr)
     {
         if (arr.Length >= (_arr.Length - _index))
         {
             Resize(arr.Length - (_arr.Length - _index));
         }

         for (int i = 0; i < arr.Length; i++)
         {
             _arr[_index] = arr[i];
             _index++;
         }
     }

     public bool Remote(T item)
     {
         for (int i = 0; i < _arr.Length; i++)
         {
             if (_arr[i].Equals(item))
             {
                 RemoteAt(i);
                 return true;
             }
         }

         return false;
     }

     public void RemoteAt(int at)
     {
         if (at < _arr.Length && at >= 0)
         {
             int count = 0;
             T[] arr = new T[_arr.Length - 1];
             for (int i = 0; i < _arr.Length; i++)
             {
                 if (i == at)
                 {
                     continue;
                 }

                 arr[count] = _arr[i];
                 count++;
             }

             _arr = arr;
             _index--;
         }
     }

     public T[] GetArr()
     {
         return _arr;
     }

     public void Sort()
     {
         T temp;
         for (int i = 0; i < _arr.Length - 1; i++)
            {
                for (int j = i + 1; j < _arr.Length; j++)
                {
                    if (_arr[i].CompareTo(_arr[j]) > 0)
                    {
                        temp = _arr[i];
                        _arr[i] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
    }

     private void Resize(T[] item)
     {
         T[] arr = new T[item.Length * 2];
         for (int i = 0; i < item.Length; i++)
         {
             arr[i] = item[i];
         }

         _arr = arr;
     }

     private void Resize(int item)
     {
         if (item >= 0)
         {
            T[] arr = new T[_arr.Length + item];
            for (int i = 0; i < _arr.Length; i++)
            {
             arr[i] = _arr[i];
            }

            _arr = arr;
         }
         else
         {
             T[] arr = new T[_arr.Length + item];
             for (int i = 0; i < arr.Length; i++)
            {
             arr[i] = _arr[i];
            }

             _arr = arr;
         }
     }
    }
}
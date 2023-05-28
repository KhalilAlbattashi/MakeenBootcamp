

namespace Generics_1
{
    public class Program
    {
        //Generic arr class that simulalte the functionalities of the Built-in Generic Array

        static void Main(string[] args)
        {
            arr<int> a = new arr<int>();
            a.Add(1);
            a.Add(2);
            a.Add(1);
            a.Add(4);
            a.Add(1);
            a.AddFromTheMiddle(3);
            a.Display();
            a.Reverse();
            a.Display();
            Console.WriteLine(a.isEmpty());
            Console.WriteLine(a.Count());
        }
    }
    public class arr<T>
    {
        public T[] _values;
        public void Add(T val)
        {
            
            if (_values is null)
            {
                this._values = new T[] { val };
            }
            else
            {
                //int Pos = _values.Length;
                T[] temp = new T[ _values.Length + 1];
                for (int i = 0; i < _values.Length; i++)
                {
                    temp[i] = _values[i];
                }
                temp[_values.Length ] = val;
                _values = temp;
            }
        }

        public void Reverse() {
            T[] temp = new T[_values.Length];
            int j = 0;
            for(int i = _values.Length - 1; i >= 0; i--)
            {
                temp[i] = _values[j];
                j++;
            }
            _values = temp;
        }
        public void RemoveAt(int index)
        {
            T[] temp = new T[_values.Length - 1];
            int Pos = 0;
            for (int i = 0; i < _values.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                temp[Pos++] = _values[i];
            }
            _values = temp;
        }
        public bool isEmpty()
        {
            if (_values.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Count() => _values.Length;

        public void AddFromTheMiddle(T val)
        {
            decimal mid = Math.Floor(((decimal)_values.Length)/2);

            T[] temp = new T[_values.Length + 1];
            int pos = 0;
            for(int i = 0; i <  temp.Length; i++)
            {
                if(i == mid)
                {
                    temp[i] = val;
                    continue;
                }
                temp[i] = _values[pos++];
            }
            _values = temp; 
        }
        public void Display()
        {
            for (int i = 0; i < _values.Length; ++i)
            {
                Console.Write($"{_values[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}


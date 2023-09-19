using System;
using System.Collections;

namespace SOLID.Segragation
{
	public class Example2
	{
		public Example2()
		{
		}
	}

    public class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;

        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        //need to implement a Enumerator
        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _head = -1;
                _collection = collection;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                {
                    return true;
                }
                else { }
                return false;
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }
}


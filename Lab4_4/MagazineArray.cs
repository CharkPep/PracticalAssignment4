using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class MagazineArray : IComparable<MagazineArray>, IEnumerable<Magazine>
    {
        private Magazine[] _array;
        public int Length { get { return _array.Length; } }
        public Magazine this[int index]
        {
            get 
            {
                if (index < 0 || index >= _array.Length)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return _array[index]; 
            }
            set
            {
                if (index < 0 || index >= _array.Length)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                _array[index] = value;
            }
        }
        public MagazineArray(int n)
        {
            _array = new Magazine[n];
        }
        public MagazineArray(IEnumerable<Magazine> Array)
        {
            _array = Array.ToArray();
        }
        
        public int CompareTo(MagazineArray? other)
        {
            if(other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return (new MagazineArrayComparer()).Compare(this, other);
        }
        public IEnumerator<Magazine> GetEnumerator()
        {
            foreach(var item in _array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class MagazineArrayComparer : IComparer<MagazineArray>
    {
        public int Compare(MagazineArray x, MagazineArray y)
        {
            // Compare based on PageNumber
            double pageNumberComparison = (x.Sum(m => m.PageNumber) - y.Sum(m => m.PageNumber)) / 1000.0;
            int result = pageNumberComparison > 0 ? 1 : pageNumberComparison < 0 ? -1 : 0;
            if (result != 0)
            {
                return result;
            }

            // If PageNumber is the same, compare based on Rate
            decimal rateComparison = (x.Sum(m => m.Rate) - y.Sum(m => m.Rate))/2.0m;
            result = rateComparison > 0 ? 1 : rateComparison < 0 ? -1 : 0;
            if (result != 0)
            {

                return result;
            }

            // If Rate is also the same, compare based on Sold
            double soldComparison = (x.Sum(m => m.SoldNumber) - y.Sum(m => m.SoldNumber)) / 10000.0;
            result = soldComparison > 0 ? 1 : soldComparison < 0 ? -1 : 0;

            return result;
        }
    }


}

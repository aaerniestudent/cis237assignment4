//Anthony Aernie
//CIS237 MW 6:00
//Mar 20, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I used the algorithms website
//someof the comments are taken from it, but I also added some
namespace cis237assignment4
{
    class MergeSort
    {
        
        
        private void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            //copy to aux[]
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            //merge back into a[]
            int i = lo, j = mid + 1;
            for (int k = lo; k<= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                //This is where the sorting actually happens:
                else if (less(aux[j], aux[i])) a[k] = aux[j++];
                else a[k] = aux[i++];                
            }
        }

        //mergesort a[lo..hi] using auxiliary array aux[lo..hi]
        private void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            //base case when there is one remaining
            if (hi <= lo) return;
            //calculate middle
            int mid = lo + (hi - lo) / 2;
            //sort first half
            sort(a, aux, lo, mid);
            //sort second half
            sort(a, aux, mid + 1, hi);
            //merge the two halves
            merge(a, aux, lo, mid, hi);
        }

        //sort a comparable array, we also pass in a length to show what part of the array actually has droids.
        public void sort(IComparable[] a, int Len)
        {
            //create an auxiliary array to hold info for the merging
            IComparable[] aux = new IComparable[Len];
            //pass in the arrays, the starting min and max
            sort(a, aux, 0, Len - 1);
        }

        //this is the comparison that sorts the array
        //is v less than w?
        private bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

    }
}

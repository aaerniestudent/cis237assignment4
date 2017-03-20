//Anthony Aernie
//CIS237 MW 6:00
//Mar 20, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    interface IGenericQueue<T>
    {
        //enqueue
        void AddToBack(T Data);
        //dequeue
        T RemoveFromFront();

        bool IsEmpty { get; }
        int Size { get; }

    }
}

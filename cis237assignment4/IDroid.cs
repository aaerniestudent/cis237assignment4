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
    //********************************
    //interface implements IComparable
    interface IDroid : IComparable
    {
        //Method to calculate the total cost of a droid
        void CalculateTotalCost();

        //property to get the total cost of a droid
        decimal TotalCost { get; set; }

        //**********************************
        //Model property used for categorize
        string Model { get; }

    }
}

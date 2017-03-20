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
    //Abstract class that implements the IDroid interface
    abstract class Droid : IDroid
    {
        //some protected variables for the class
        protected string material;
        protected string model;
        protected string color;

        protected decimal baseCost;
        protected decimal totalCost;

        //The public property for TotalCost
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public string Model
        {
            get
            {                
                return model;

            }
        }

        //Constructor that takes the main 3 parameters shared amongst all 4 types of droids
        public Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        //Virtual method that can be overridden in the derived classes if needed.
        //This implementation calculates the cost based on the material used for the droid
        protected virtual void CalculateBaseCost()
        {
            switch (this.material)
            {
                case "Carbonite":
                    this.baseCost = 100.00m;
                    break;

                case "Vanadium":
                    this.baseCost = 120.00m;
                    break;

                case "Quadranium":
                    this.baseCost = 150.00m;
                    break;

                default:
                    this.baseCost = 50.00m;
                    break;
            }
        }

        //Abstract method that MUST be overriden in the derived class to calculate the total cost
        public abstract void CalculateTotalCost();

        //Overriden toString method that will return a string representing the basic information for any droid
        public override string ToString()
        {
            return "Material: " + this.material + Environment.NewLine +
                    "Model: " + this.model + Environment.NewLine +
                    "Color: " + this.color + Environment.NewLine;
        }

        //******************
        //CompareTo
        //******************
        //CompareTo Method for merge sort that satisfies IComparable.        
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;
            //if totalCost has never been calculated for this drone
            //note: as it was, totalCost was never calculated until it was displayed.
            //so this is there if this option is selected without that
            if (this.totalCost == 0)
            {
                CalculateTotalCost();
            }
            //assign obj as an IDroid
            IDroid dro = obj as IDroid;
            if (dro != null)
            {
                //if totalCost has never been calculated for the drone we are comparing to
                if (dro.TotalCost == 0)
                {
                    dro.CalculateTotalCost();
                }
                //compares the two decimal values and will return an accurate value
                return this.totalCost.CompareTo(dro.TotalCost);
            } else
            {
                throw new Exception("Failure, everything is trash");
            }
        }
    }
}

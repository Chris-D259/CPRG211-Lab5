using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InClassExercise___MAR0523
{
    internal class Circle
    {
        //Set Parameters
        public double Radius {  get; set; }
        public string Name {  get; set; }
        //Create Constructor
        public Circle(string name)
        {
            this.Name = name;
        }
        //Create Method to Set Radius, provide error handling statement
        public double setRadius(double radius)
        {
            
            if (radius > 0)
            {
                Radius = radius;
                return radius;
                
            }
            else
            {
                string errorMessage = $"The Radius of {this.Name}: radius of {radius} is invalid";
                throw new InvalidRadiusException(errorMessage,new Exception("Additional exception details"));
            }

        }

        //To String Method
        public override string ToString()
        {
            return $"The radius is {Radius} for {this.Name}";
        }
    }
    
    
}

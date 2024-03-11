using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExercise___MAR0523
{
    //Create New Exception for Radius
    internal class InvalidRadiusException:Exception
    {
        //No Argument Constructor
        public InvalidRadiusException() 
        {
            Console.WriteLine("Invalid Radius Error");
        }
        //Invalid Radius Exception Constructor
        public InvalidRadiusException(string message, Exception ex) : base(message,ex)
        {

        }

    }
}

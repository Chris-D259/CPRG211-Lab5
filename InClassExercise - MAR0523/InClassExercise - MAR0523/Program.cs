using System.Runtime.CompilerServices;

namespace InClassExercise___MAR0523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 3 Circle Objects
            Circle circle1 = new Circle("Circle 1");
            Circle circle2 = new Circle("Circle 2");
            Circle circle3 = new Circle("Circle 3");
            
            //Try statements to Set the Radius and catch the erorr if error arrises
                try
                {
                circle1.setRadius(5);
                Console.WriteLine(circle1.ToString());
            }
                catch (InvalidRadiusException ex)
                {
                    Console.WriteLine($"Invalid Radius Exception: " + ex.Message);
                    
                }

                try
                {
                circle2.setRadius(-2);
                Console.WriteLine(circle2.ToString());
            }
                catch(InvalidRadiusException ex)
                {
                    Console.WriteLine($"Invalid Radius Exception: " + ex.Message);
                    
                }
                try
                {
                    circle3.setRadius(0).ToString();
                    Console.WriteLine(circle3.ToString());
                }
                catch(InvalidRadiusException ex)
                {
                    Console.WriteLine($"Invalid Radius Exception: " + ex.Message);
                    
                }
            }

               
             }
        }

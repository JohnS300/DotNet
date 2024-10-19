using System;
//testing functionalities of C#

/*
multiline comments similar to java
*/

namespace FirstApp{
    class FirstApp{
        static void Main(string[] args){
            //Console.WriteLine("First Application");

            int i , x, z, y;
            //float declaration requires F
            float f1= 15.54F;

            i = 5; x = 10 ; z = y = 25; 
            int sum = i + x + z + y;
            //Explicit casting with int
            sum += (int)f1; 
            //String Interpolation
            Console.WriteLine($"Sum = {sum} ");

            Console.WriteLine("Enter your age:");
            //User Input with explicit conversion to Int using Conver.To method
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So your age is : {age} , correct Y/N?");
            //Use a Ternary operator
            bool correct = Console.ReadLine().ToUpper() == "Y"? true : false ;
            //the below is the faster aproach
            //bool correct = Console.ReadLine().ToUpper() == "Y";
            Console.WriteLine(correct);
            

            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight < 40 || weight > 90){
                Console.WriteLine($"Your weight is {weight} and that means you need to go speak with a doctor.");
            };
        }
    }
}
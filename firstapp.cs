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

        }
    }
}
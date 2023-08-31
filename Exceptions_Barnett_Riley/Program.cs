using System;

namespace Exceptions_Barnett_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;
            float myBirthday = 5f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    myBirthday = (float)Convert.ToDouble(Console.ReadLine());
                    float myCurrentAge = 0;
                    result = Divide(myCurrentAge, myBirthday);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Calculations completed with a result of " + result);
            }
            try
            {
                CheckAge(myInt);
            }catch
            {
                Console.WriteLine("Too Young Nerd!");
            }
        }

        static float Divide(float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}


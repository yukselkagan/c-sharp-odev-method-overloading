using System;

namespace c_sharp_odev_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            string string1 = "100";



            bool result = int.TryParse(string1, out int outNumber);
            Console.WriteLine(outNumber);




            Methods methods = new Methods();

            methods.SumNum(2, 3, out int resultNum);
            Console.WriteLine(resultNum);



            methods.Write("hello");
            methods.Write(500);
            methods.Write("hello", "world");



        }
    }









    class Methods
    {
        public void SumNum(int number1, int number2, out int total )
        {
            total = number1 + number2;
        }



        public void Write(string data)
        {
            Console.WriteLine(data);
        }

        public void Write(int data)
        {
            Console.WriteLine(data);
        }

        public void Write(string data1, string data2)
        {
            Console.WriteLine(data1 + " " + data2);
        }




    }






}

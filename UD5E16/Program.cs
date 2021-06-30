using System;

namespace UD5E16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 1 };
            int length = array.Length;
            bool mirror = true;
            for (int index = 0; index < array.Length; index++)
            {
                if (mirror)
                {
                    int start = array[index];
                    int end = array[--length];
                    if (length < index)
                    {
                        break;
                    }
                    if (start != end)
                    {
                        mirror = false;
                    }
                }
            }
            if (mirror)
            {
                Console.WriteLine("Es capicúa");
            }
            else
            {
                Console.WriteLine("No es capicúa");
            }
        }
    }
}

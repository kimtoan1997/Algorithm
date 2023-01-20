using System;

namespace TWO_SUM
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int[] array = { 3, 2, 4 };

            var result = Two_Sum(array, 6);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static int[] Two_Sum(int[] array, int target) 
        {
            int[] result = new int[2];

            
            for (int i = 0; i < array.Length; i++)
            {
                int firstArrayElement = array[i];
                int remainElement = target - firstArrayElement;
                int matchIndex = array.ToList().IndexOf(remainElement);

                if (matchIndex != i && matchIndex != -1)
                {
                    result[0] = i;
                    result[1] = matchIndex;

                    return result;
                }
            }
            return result;
        }
    }
}
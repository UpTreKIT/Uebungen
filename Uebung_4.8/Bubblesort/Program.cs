using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    public class Program
    {
        static void BubbleSort(int[] unsortiertesArray)
        {
            int n = unsortiertesArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (unsortiertesArray[j] > unsortiertesArray[j + 1])
                    {
                        int tempVar = unsortiertesArray[j];
                        unsortiertesArray[j] = unsortiertesArray[j + 1];
                        unsortiertesArray[j + 1] = tempVar;
                    }

                }

            }

        }

    }

}

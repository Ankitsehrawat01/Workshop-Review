using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopReview
{
    internal class Number
    {
        public void FindTriplets(int[]arr, int n)
        {
            bool found = false; 
            for (int i=0; i< n-2; i++)
            {
                for (int j= i+1; j<n-1; j++)
                {
                    for (int k= j+1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k]==0)
                        {
                            Console.Write(arr[i]);
                            Console.Write(" ");
                            Console.Write(arr[j]);
                            Console.Write(" ");
                            Console.Write(arr[k]);
                            Console.Write("\n");
                            found = true;   
                        }
                    }
                }
            }
        }
    }
}

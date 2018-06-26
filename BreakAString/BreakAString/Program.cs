using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAString
{
    class Program
    {  
        static int cutCost(int n, int[] L)
        {
            if (L.Length == 0)
            {
                return 0;
            }
            if (L.Length == 1)
            {
                return n;
            }
            int index = 0;
            for (int i = 1; i < L.Length; i++)
            {
                    index = i; 
            }
            int cl = 0, cr = 0;
            int[] br = new int[L.Length];
            if (index > 0)
            {
                int[] ml = new int[index];
                for (int k = 0; k < index; k++)
                {
                    ml[k] = L[k];
                }
                int nl = L[index];
                cl = cutCost(nl, ml);
            }
            if (index < L.Length - 1) {
                int[] mr = new int[L.Length];
                for (int k = index + 1; k < L.Length; k++)
                {
                    mr[k] = L[k];
                }
                int nr = n - L[index];
                for (int j = 0; j < mr.Length; j++)
                {
                    mr[j] = mr[j] - L[index];
                }
                cr = cutCost(nr, mr);
            }
            return n + cl + cr;
        }
        static void Main(string[] args)
        {
            int[] L = new int[] { 2 ,8, 10 };                           //Input Breaks.
            int n = 20;                                                 //Input String Length.
            Console.Write("Breaks at: ");
            foreach (var i in L)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nBreak Cost: " + cutCost(n, L));
        }
    }
}

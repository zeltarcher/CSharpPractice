using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ConsoleApp1
{
    class SalesByMatch
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] > 0)
                    {
                        if (ar[i] == ar[j])
                        {
                            count++;
                            ar[j] = 0;
                            ar[i] = 0;
                            break;
                        }
                    }
                }
            }
            return count;
        }

        //better approach
        /*
            Set<Integer> colors = new HashSet<>();
            int pairs = 0;

            for (int i = 0; i < n; i++) {
                if (!colors.contains(c[i])) {
                    colors.add(c[i]);
                } else {
                    pairs++;
                    colors.remove(c[i]);
                }
            }

            System.out.println(pairs);
         */

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
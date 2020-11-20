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

class Solution
{

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int jumps = 0;
        int position = 2;//check start from position 2
        while (position < c.Length)
        {
            if (c[position] != 0)
            {
                position--;
            }
            jumps++;
            position += 2;
        }
        //because position == c.length will not add any jump in the counting, so fix this by below code
        if (position == c.Length)
            jumps++;
        return jumps;
    }
    // Better Approach: this is opposite we start with 1 jump only, if this is not 0, then it must be 2 jump and position is moved to i+2 before count
    /*     
      int count = 0;
        for (int i = 0; i < c.Length - 1; i++) {
            if (c[i] == 0) i++;
            count++;
        }
        return count;
     */

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

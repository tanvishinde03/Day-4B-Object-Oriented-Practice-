﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Object_Oriented_Practice_
{
    public class Program
    {
        static void Main(string[] args)
      {        
     	for (int row = 1; row <= 8; ++row)
          {
              for (int col = 1; col <= row; ++col)
              {
                  Console.Write("*");
             }
 
             Console.WriteLine();
         }
         Console.ReadLine();
     }
}      
    }

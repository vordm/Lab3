using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Lab3Console
{
   public abstract class GeneratorBase
   {
      public long[] ResultArray;
      
      public GeneratorBase(long[] resultArray)
      {
         this.ResultArray = resultArray;
      }         

      public void Generate()
      {
         for (long i = 0; i < ResultArray.Length; i++)
         {
            ResultArray[i] = GenerateValue(i);
         }
      }

      public abstract long GenerateValue(long i);

      public abstract string MethodName { get; }

      
   }
}



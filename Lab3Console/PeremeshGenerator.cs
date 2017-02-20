using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3Console
{
    public class PeremeshGenerator : GeneratorBase
    {
        private long initialValue = 1234; //initialValue
        private int capacity;
        private int shift;
             

        public PeremeshGenerator(long[] resultArray) : base(resultArray)
      {
            initialValue = Utils.GetNumberFromDiapason(initialValue, Common.Begin, Common.End);
            capacity = initialValue.ToString().Length;
            shift = capacity / 4;
        }

        public override string MethodName
        {
            get
            {
                return "Метод перемешиваний";
            }
        }

        public override long GenerateValue(long i)
        {
            long currentValue = (i == 0) ? initialValue : ResultArray[i - 1];

            var value1 = (currentValue << shift);
            var value2 = (currentValue >> shift);

            var tempResult = value1 + value2;

            var result = Utils.GetNumberFromDiapason(tempResult, Common.Begin, Common.End);
            return result;
        }
    }
}

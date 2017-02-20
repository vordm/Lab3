using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3Console
{
    public class SeredProizvGenerator : GeneratorBase
    {
        private long initialValue1 = 1234;
        private long initialValue2 = 5678;
        private int capacity;

        public SeredProizvGenerator(long[] resultArray) : base(resultArray)
      {
            initialValue1 = Utils.GetNumberFromDiapason(initialValue1, Common.Begin, Common.End);
            initialValue2 = Utils.GetNumberFromDiapason(initialValue2, Common.Begin, Common.End);
            capacity = initialValue1.ToString().Length;
        }

        public override string MethodName
        {
            get
            {
                return "Метод серединных произведений";
            }
        }

        public override long GenerateValue(long i)
        {
            long baseValue1;
            long baseValue2;

            if (i == 0)
            {
                baseValue1 = initialValue1;
                baseValue2 = initialValue2;
            }
            else if (i == 1)
            {
                baseValue1 = initialValue2;                    
                baseValue2 = ResultArray[i - 1];
            }
            else 
            {
                baseValue1 = ResultArray[i - 2];
                baseValue2 = ResultArray[i - 1];
            }

            var tempVal = baseValue1 * baseValue2;

            var tempResult = Utils.GetMiddleInt(tempVal, capacity);

            var result = Utils.GetNumberFromDiapason(tempResult, Common.Begin, Common.End);
            return result;
        }

    }
}

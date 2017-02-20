using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3Console
{
    public class SeredKvadrGenerator : GeneratorBase
    {
        private long initialValue = 1234; //initialValue
        private int capacity;

        public SeredKvadrGenerator(long[] resultArray) : base(resultArray)
        {
            initialValue = Utils.GetNumberFromDiapason(initialValue, Common.Begin, Common.End);
            capacity = initialValue.ToString().Length;
        }

        public override string MethodName
        {
            get
            {
                return "Метод серединных квадратов";
            }
        }

        public override long GenerateValue(long i)
        {
            var prevValue = (i == 0) ? initialValue : ResultArray[i - 1];                       
            
            var tempVal = (long)Math.Pow(prevValue, 2); 

            var tempResult = Utils.GetMiddleInt(tempVal, capacity);

            var result = Utils.GetNumberFromDiapason(tempResult, Common.Begin, Common.End);
            return result;
        }
    }
}

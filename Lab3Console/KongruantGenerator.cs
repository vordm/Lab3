using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3Console
{
    //Линейный конгруэнтный метод
    //Самый сложнопроизносимый и самый простой для понимания, и, одновременно, самый быстрый.Случайное число вычисляется по формуле:
    //ri + 1 = mod(k · ri + b, M).
    //M — модуль(0 < M);
    //k — множитель(0 ≤ k<M);
    //b — приращение(0 ≤ b<M);
    //r0 — начальное значение(0 ≤ r0<M).
    //Вся хитрость в правильном подборе параметров M, k b r0
    //Например.генератор случайных чисел формируемых на основе чисел:
    //M = 231 – 1
    //k = 1 220 703 125
    //b = 7
    //r0 = 7
    //будет выдавать случайные неповторяющиеся числа с периодом, равным 7 миллионам.

    public class KongruantGenerator : GeneratorBase
    {
        private long initialValue = 7; //1234; //initialValue
        private int capacity;
        private long M = (long)Math.Pow(2, 31) - 1;
        private long K = 1220703125;
        private long B = 7;


        public KongruantGenerator(long[] resultArray) : base(resultArray)
        {
            //initialValue = Utils.GetNumberFromDiapason(initialValue, Common.Begin, Common.End);
            //capacity = initialValue.ToString().Length;
        }

        public override string MethodName
        {
            get
            {
                return "Линейный конгруэнтный метод";
            }
        }

        public override long GenerateValue(long i)
        {
            long currentValue = (i == 0) ? initialValue : ResultArray[i - 1];
            long tempResult = (K * currentValue + B) % M;

            var result = Utils.GetNumberFromDiapason(tempResult, Common.Begin, Common.End);
            return result;
        }
    }
}



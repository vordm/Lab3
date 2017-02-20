using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Console
{
    public static class Utils
    {
        public static long GetMiddleInt(long value, int capacity)
        {
            var stringValue = value.ToString().PadLeft(capacity, '0');
                        
            int startIndex =  (stringValue.Length - capacity)/2;                     

            var resultString = stringValue.Substring(startIndex, capacity);
            return Convert.ToInt64(resultString);
        }

        //преобразует число value к некоторому числу из диапазона begin - end.
        public static long GetNumberFromDiapason(long value, long begin, long end)
        {
            if (value >= begin && value <= end)
            {
                return value;
            }

            var normalizedValue = GetNormalizedNumber(value);

            var result = (normalizedValue * (end - begin)) + begin;
            return (long) result;
        }

        //возвращает число между 0 и 1
        public static double GetNormalizedNumber(long value)
        {
            double result = value;
            
            do
            {
                result = result * 0.1;
            } while (!(0 <= result && result < 1));

            return result;
        }

        
    }
}

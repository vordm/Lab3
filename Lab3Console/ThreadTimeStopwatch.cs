using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace Lab3Console
{
    //https://www.codeproject.com/kb/dotnet/executionstopwatch.aspx
    //секундомер для потока (текущего)
    //см комментарии к базовому классу StopwatchBase
    public class ThreadTimeStopwatch: StopwatchBase
    {
        [DllImport("kernel32.dll")]
        private static extern bool GetThreadTimes
            (IntPtr threadHandle, out long createionTime,
             out long exitTime, out long kernelTime, out long userTime);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThread();
        
        protected override bool GetCurrentTimes(out long lpCreationTime, out long lpExitTime, out long lpKernelTime, out long lpUserTime)
        {
            IntPtr threadHandle = GetCurrentThread();
            bool result = GetThreadTimes
                (threadHandle, out lpCreationTime,
                out lpExitTime, out lpKernelTime, out lpUserTime);

            return result;
        }        
    }
}

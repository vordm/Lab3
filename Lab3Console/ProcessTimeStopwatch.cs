using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Lab3Console
{
    //https://www.codeproject.com/kb/dotnet/executionstopwatch.aspx
    //секундомер для процесса (текущего)
    //см комментарии к базовому классу StopwatchBase
    public class ProcessTimeStopwatch : StopwatchBase
    {
        [DllImport("kernel32.dll")]
        static extern bool GetProcessTimes(IntPtr hProcess,
            out long lpCreationTime,
            out long lpExitTime,
            out long lpKernelTime,
            out long lpUserTime);

        protected override bool GetCurrentTimes(out long lpCreationTime, out long lpExitTime, out long lpKernelTime, out long lpUserTime)
        {
            IntPtr processHandle = Process.GetCurrentProcess().Handle;
            var result = GetProcessTimes(processHandle, out lpCreationTime, out lpExitTime, out lpKernelTime, out lpUserTime);
            return result;
        }        
    }
}

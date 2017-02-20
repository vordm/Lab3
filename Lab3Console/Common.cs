using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Lab3Console
{
   public enum GenerationMethod
   {
      SeredKvadr,
      SeredProizv,
      PeremeshGenerator,
      KongruantGenerator
   }

   public static class Common
   {
        
      public static bool ShowNumbers { get; set; } //true: выводит на экран сгенеренные числа, false: делает, то что требуется в задании

      public static bool LogToFile { get; set; } //true: создает файл "log.txt" в папке с программой

      public static long Begin { get; set; } //начало диапазона

      public static long End { get; set; } //конец диапазона

        public static long Count { get; set; } //количество генерируемых данных

      //глобальные массивы, куда записываются результаты генерации 4х методов
      public static long[] SeredKvadrResultArray;
      public static long[] SeredProizvResultArray;
      public static long[] PeremeshResultArray;
      public static long[] KongruantResultArray;


      public static object LockObject = new object();

      //объекты используемые для блокировки в критических секциях (один на каждый метод)
      public static object SeredKvadrLockObject = new object();
      public static object SeredProizvLockObject = new object();
      public static object PeremeshLockObject = new object();
      public static object KongruantLockObject = new object();

      //массив значений приоритетов потоков в C#
      public static ThreadPriority[] ThreadPriorities = { ThreadPriority.Lowest, ThreadPriority.BelowNormal, ThreadPriority.Normal, ThreadPriority.AboveNormal, ThreadPriority.Highest };

        //сигнальщик событий для   WaitForSingleObject
      public static EventWaitHandle WaitHandle = new AutoResetEvent(false);

      
      public static void WaitForSingleObject()
      {
            //.net аналог WaitForSingleObject() winapi функции
            WaitHandle.WaitOne();
      }

      public static void SevEvent()
      {
            //.net аналог SevEvent() winapi функции
            WaitHandle.Set();
      }

      public static void EnterCriticalSection(object lockObj)
      {
            //.net аналог входа в критическую секцию
            Monitor.Enter(lockObj);
      }

      public static void LeaveCriticalSection(object lockObj)
      {
            //.net аналог выхода из критической секции
            Monitor.Exit(lockObj);
      }

      public static void DeleteCriticalSection(object lockObj)
      {

      }      
   }
}

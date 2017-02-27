using System;
using System.Threading;

namespace Lab3Console
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            InitCommonParameters(args);
            string paramsLog = string.Format(@"Диапазон: {0} - {1}. Кол-во: {2}", Common.Begin, Common.End, Common.Count);
            Logger.Current.WriteLine(paramsLog);

            if (Common.ShowNumbers)
            {
               GenerateAndShowNumbers();
            }
            else
            {
               StartThreads();
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
         finally
         {
            //Console.WriteLine("Нажмите любую клавишу для выхода...");

            Console.ReadKey();
            Logger.Current.Dispose();
         }
      }

      private static void GenerateAndShowNumbers()
      {
         foreach (GenerationMethod generationMethod in Enum.GetValues(typeof(GenerationMethod)))
         {
            GeneratorBase generator = GetGenerator(generationMethod);
            generator.Generate();
            Logger.Current.WriteLine(generator.MethodName);
            Logger.Current.WriteLine();
            WriteResultArray(generator.ResultArray);
            Logger.Current.WriteLine();
         }

      }

      private static void InitCommonParameters(string[] args)
      {
         //инициализируем данные, необходимые для работы программы
         //читаем их из аргументов командной строки или задаем по умолчанию
           

         Common.Begin = (args.Length > 0) ? Convert.ToInt32(args[0]) : 0;
         Common.End = (args.Length > 1) ? Convert.ToInt32(args[1]) : 10000;
         Common.Count = (args.Length > 2) ? Convert.ToInt32(args[2]) : 1000;
         Common.ShowNumbers = (args.Length > 3) ? Convert.ToBoolean(args[3]) : false;
         Common.LogToFile = (args.Length > 4) ? Convert.ToBoolean(args[4]) : false;

         Common.SeredKvadrResultArray = new long[Common.Count];
         Common.SeredProizvResultArray = new long[Common.Count];
         Common.PeremeshResultArray = new long[Common.Count];
         Common.KongruantResultArray = new long[Common.Count];

      }

      private static int cycleCount = 0;

      private static void StartThreads()
      {
         ProcessTimeStopwatch processTimeStopwatch = new ProcessTimeStopwatch();
         processTimeStopwatch.Start();

         foreach (var seredKvardPriority in Common.ThreadPriorities)
         {
            foreach (var seredProizvPriority in Common.ThreadPriorities)
            {
               foreach (var peremeshPriority in Common.ThreadPriorities)
               {
                  foreach (var kongrPriority in Common.ThreadPriorities)
                  {
                     Common.EnterCriticalSection(Common.LockObject);
                     try
                     {
                        cycleCount += 1;
                        Logger.Current.WriteLine("Цикл номер: {0}", cycleCount);

                        StartNewThread(GenerationMethod.SeredKvadr, seredKvardPriority);
                        StartNewThread(GenerationMethod.SeredProizv, seredProizvPriority);
                        StartNewThread(GenerationMethod.PeremeshGenerator, peremeshPriority);
                        StartNewThread(GenerationMethod.KongruantGenerator, kongrPriority);
                     }
                     finally
                     {
                        Common.LeaveCriticalSection(Common.LockObject);
                     }

                     Thread.Sleep(10);
                     Common.SevEvent();                 
                  }
               }
            }
         }

         processTimeStopwatch.Stop();
         Logger.Current.WriteLine();
         Logger.Current.WriteLine("Время работы процесса: {0}", processTimeStopwatch.Elapsed);
      }

      private static void Worker(GenerationMethod generationMethod, ThreadPriority threadPriority)
      {
         Common.EnterCriticalSection(Common.LockObject);
         Common.LeaveCriticalSection(Common.LockObject);

         GeneratorBase generator = GetGenerator(generationMethod);
         
         ThreadTimeStopwatch threadTimeStopwatch = new ThreadTimeStopwatch();
         threadTimeStopwatch.Start();
         
         try
         {
            generator.Generate();

            threadTimeStopwatch.Stop();

            WriteResultSummary(generator, threadPriority, threadTimeStopwatch.Elapsed);
         }
         finally
         {
            Common.WaitForSingleObject();
            Common.SevEvent();            
         }

      }
      
      private static void StartNewThread(GenerationMethod generationMethod, ThreadPriority threadPriority)
      {
         Action action = () => Worker(generationMethod, threadPriority);
         ThreadStart threadStart = new ThreadStart(action);



         Thread workThread = new Thread(threadStart);
         workThread.Priority = threadPriority;
         workThread.Start();
      }

      private static void WriteResultSummary(GeneratorBase generator, ThreadPriority threadPriority, TimeSpan elapsed)
      {
         Logger.Current.WriteLine(string.Empty);

         string summary = string.Format("{0}; приоритет: {1}; время выполнения: {2} ", generator.MethodName, threadPriority, elapsed);
         Logger.Current.WriteLine(summary);


      }

      private static void WriteResultArray(long[] resultArray)
      {
         for (long i = 0; i < resultArray.Length; i++)
         {
            Console.Write("{0} ", resultArray[i]);
         }

         Console.WriteLine();
      }

      private static GeneratorBase GetGenerator(GenerationMethod generationMethod)
      {
         switch (generationMethod)
         {
            case GenerationMethod.SeredKvadr:
               return new SeredKvadrGenerator(Common.SeredKvadrResultArray);

            case GenerationMethod.SeredProizv:
               return new SeredProizvGenerator(Common.SeredProizvResultArray);

            case GenerationMethod.PeremeshGenerator:
               return new PeremeshGenerator(Common.PeremeshResultArray);

            case GenerationMethod.KongruantGenerator:
               return new KongruantGenerator(Common.KongruantResultArray);

            default:
               throw new Exception("Bad generationMethod");
         }
      }

      private static object GetLockObject(GenerationMethod generationMethod)
      {
         switch (generationMethod)
         {
            case GenerationMethod.SeredKvadr:
               return Common.SeredKvadrLockObject;

            case GenerationMethod.SeredProizv:
               return Common.SeredProizvLockObject;

            case GenerationMethod.PeremeshGenerator:
               return Common.PeremeshLockObject;

            case GenerationMethod.KongruantGenerator:
               return Common.KongruantLockObject;

            default:
               throw new Exception("Bad generationMethod");
         }
      }

   }
}

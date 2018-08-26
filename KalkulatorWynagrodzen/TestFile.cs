using System;
using System.Collections.Generic;

namespace KalkulatorWynagrodzen
{
    public class TestFile
    {
        private readonly Dictionary<int, int> MonthsWorkingHours;
        public TestFile()
        {
            MonthsWorkingHours = new ConfigurationFileInterpreter<Dictionary<int, int>>("MonthConfig.json")
                .InterpretConfiguration();
        }
        public int VerifyFile()
        {
            int TestResult = 1;
            int[] DebugTable = new int[13];
            for (int i = 1; i <= 12; i++)
            {
                var NumberWorkingHoursInMonth = MonthsWorkingHours[i];
                if (NumberWorkingHoursInMonth < 100 || NumberWorkingHoursInMonth > 200)
                {
                    DebugTable[i] = NumberWorkingHoursInMonth;
                    TestResult = 0;
                }                  
                else
                {
                    DebugTable[i] = 999999;
                }
                if (i == 12)
                {
                    break;
                }
            }
                Month monthName = new Month();
            if (TestResult == 0)
            {
                Console.Write($"\nProgram nie mógł zostać uruchomiony, ponieważ plik konfiguracyjny \n" +
                    $"'MonthConfig' zawiera niedopuszczalne wartości: \n\n");
                for (int q = 1; q < 13; q++)
                {
                    if (DebugTable[q] >= 0 && DebugTable[q] != 999999)
                    {
                        Console.WriteLine($"Miesiąc {monthName.MonthName(q)}: [{DebugTable[q]}] H");
                    }

                }
            }            
            return TestResult;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassMassiv8;

namespace TestDrivers9
{
    public class CTest_Driver
    {
        Massiv masTesting;
        string filename = "logfile.dat";

        public CTest_Driver()
        {
            try
            {
                using (StreamWriter log = new StreamWriter(filename, true))
                {
                    run(log);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" {ex.ToString()} : Логи были записаны в файл!");
            }
        }

        public void run(StreamWriter log)
        {
            log.WriteLine("/////////////// Лог начат: " + DateTime.Now + " /////////////////////");
            MassTestMaxSimp(log);
            MassTestMaxNull(log);
            MassTestMaxPartExp(log);
            MassTestMaxPartSimp(log);
            log.WriteLine("/////////////// Лог окончен: " + DateTime.Now + " /////////////////////");
        }

        public void MassTestMaxSimp(StreamWriter log)
        {
            int[] massTest1;
            int result = 0;
            massTest1 = new int[] { 2, -84, 100, -1023 };
            masTesting = new Massiv(massTest1);
            result = masTesting.maxNumberOfMas(massTest1);
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                ": Результат: " + result);
        }

        public void MassTestMaxNull(StreamWriter log)
        {
            int[] massTest1;
            int result = 0;
            massTest1 = new int[] { 0, 0, 0, 0 };
            masTesting = new Massiv(massTest1);
            result = masTesting.maxNumberOfMas(massTest1);
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                ": Результат: " + result);
        }

        public void MassTestMaxPartExp(StreamWriter log)
        {
            int[] massTest1;
            int result = 0;
            int indStart = 1;
            int indEnd = 1;
            massTest1 = new int[] { 42, 852, 0, -415 };
            masTesting = new Massiv(massTest1);
            result = masTesting.MaxNumberOfMas(indStart, indEnd);
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                ": Результат: " + result);
        }

        public void MassTestMaxPartSimp(StreamWriter log)
        {
            int[] massTest1;
            int result = 0;
            int indStart = 0;
            int indEnd = 2;
            massTest1 = new int[] { 9, -521, 0, 34 };
            masTesting = new Massiv(massTest1);
            result = masTesting.MaxNumberOfMas(indStart, indEnd);
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() +
                ": Результат: " + result);
        }
    }
}

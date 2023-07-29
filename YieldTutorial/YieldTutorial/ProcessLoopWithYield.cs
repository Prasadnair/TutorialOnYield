using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldTutorial
{
    internal class ProcessLoopWithYield
    {

        public static void DisplayRecordsWithYield()
        {
            //all records will be loaded into studList, then process each record in this collection.
            var studList = GetStudentByYield(1_000_000);
            foreach (var record in studList)
            {
                if (record.Id < 1000)
                    Console.WriteLine($"Id :{record.Id}, FirstName : {record.FirstName}, LastName : {record.LastName} ");
                else
                    break;
            }
        }

        private static IEnumerable<Student> GetStudentByYield(int upperLimit)
        {

            for (int i = 0; i < upperLimit; i++)
            {
                yield return new Student
                {
                    Id = i,
                    FirstName = $"FName{i}",
                    LastName = $"LName{i}"
                };
            }
        }

    }
}

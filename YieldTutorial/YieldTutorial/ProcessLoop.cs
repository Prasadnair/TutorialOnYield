namespace YieldTutorial
{
    internal class ProcessLoop
    {

        public static void DisplayRecords()
        {
            //all records will be loaded into studList, then process each record in this collection.
            var studList= GetStudents(1_000_000);
            foreach (var record in studList)
            {
                if (record.Id < 1000)
                    Console.WriteLine($"Id :{record.Id}, FirstName : {record.FirstName}, LastName : {record.LastName} ");
                else
                    break;
            }
        }        

        private static IEnumerable<Student> GetStudents(int upperLimit)
        {
            var studList =new List<Student>();
            for(int i = 0; i < upperLimit; i++)
            {
                studList.Add(new Student
                {
                    Id = i,
                    FirstName = $"FName{i}",
                    LastName = $"LName{i}"
                });
            }
            return studList;
        }
        
    }
}

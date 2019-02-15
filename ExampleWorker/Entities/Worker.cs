using ExampleWorker.Entities.Enums;

namespace ExampleWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public void AddContract(HourContract contract)
        {
         
        }
        public void RemoveContract(HourContract contract)
        {

        }
        public double Income(int year, int month)
        {
            return year/month ;
        }
    }
}

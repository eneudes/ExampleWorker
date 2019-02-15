using System;

namespace ExampleWorker.Entities
{
    class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours ;
        }
    }
}

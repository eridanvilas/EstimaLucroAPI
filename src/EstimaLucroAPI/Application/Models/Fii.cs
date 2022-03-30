using System;

namespace EstimaLucroAPI.Application.Models
{
    public class Fii
    {
        public Fii(int id,string name, decimal value, decimal avgMonthly, DateTime lastRefreshed)
        {
            Id = id;
            Name = name;
            Value = value;
            AvgMonthly = avgMonthly;
            LastRefreshed = lastRefreshed;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal AvgMonthly { get; set; }
        public DateTime LastRefreshed { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DiningReview.Models
{
    public class Restaurant
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public double? PeanutScore { get; set; }
        public double? EggScore { get; set; }
        public double? DairyScore { get; set; }
        public double? OverallScore { get; set; }
    }
}
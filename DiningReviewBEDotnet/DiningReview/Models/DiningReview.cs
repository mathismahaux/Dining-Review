using System.ComponentModel.DataAnnotations;

namespace DiningReview.Models
{
    public enum DiningReviewStatus
    {
        Pending,
        Accepted,
        Rejected
    }

    public class DiningReview
    {
        public long Id { get; set; }
        public string SubmittedBy { get; set; }
        public long RestaurantId { get; set; }
        public int? PeanutScore { get; set; }
        public int? EggScore { get; set; }
        public int? DairyScore { get; set; }
        public string Commentary { get; set; }
        public DiningReviewStatus Status { get; set; } = DiningReviewStatus.Pending;
    }
}
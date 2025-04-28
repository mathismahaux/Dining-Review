namespace DiningReview.Models
{
    public class User
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public bool InterestedInPeanutAllergy { get; set; }
        public bool InterestedInEggAllergy { get; set; }
        public bool InterestedInDairyAllergy { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace MeetMVC.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string about { get; set; }
        public string lookingFor { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string gender { get; set; }
        public string sexuality { get; set; }
    }
}

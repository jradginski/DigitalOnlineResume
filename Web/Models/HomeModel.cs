using System.Collections.Generic;
using DAL;

namespace Web.Models
{
    public class HomeModel
    {
        public Dictionary<string, string> Skills { get; set; }
        public List<Job> WorkHistroy { get; set; }
        public List<Degree> Education { get; set; }
        public List<string> Interests { get; set; }
        public Dictionary<string, string> FAQ { get; set; }
        public string ProfileImgUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string GithubUrl { get; set; }
    }
}
using System.Collections.Generic;

namespace DAL
{
    public class Job : Base
    {
        public List<string> JobDetails = new List<string>();
        public bool IsCurrentlyEmployed { get; set; }
    }
}

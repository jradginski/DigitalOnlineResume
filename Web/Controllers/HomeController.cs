using System.Web.Mvc;
using System.Web.Configuration;
using Web.Models;
using DAL;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(HomeModel model)
        {
            ViewBag.Title = "Home Page";
            model.Skills = ResumeData.GetSkills();
            model.WorkHistroy = ResumeData.GetJobs();
            model.Education = ResumeData.GetDegrees();
            model.Interests = ResumeData.GetInterests();
            model.FAQ = ResumeData.GetFAQ();
            model.LinkedInUrl = WebConfigurationManager.AppSettings["LinkedInUrl"];
            model.GithubUrl = WebConfigurationManager.AppSettings["GitHubUrl"];
            return View(model);
        }
    }
}
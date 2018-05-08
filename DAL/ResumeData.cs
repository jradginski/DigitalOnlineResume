using System;
using System.Collections.Generic;

namespace DAL
{
    public static class ResumeData
    {
        public static List<string> GetAboutMe()
        {
            var result = new List<string>();
            result.Add("Manager/Team Lead/Senior Developer with more than 7 years of professional experience within information technology.");
            result.Add("Full system life cycle experience: Project planning, design, coding, testing, bug fixing, deployment, documentation and maintenance.");
            result.Add("Strong technical abilities in creating database-enabled Internet/Intranet applications using various languages and platforms.");
            result.Add("Skilled in crafting efficient, standalone executables and middle-layer DLLs using .Net technologies, focusing on C#.");
            result.Add("Experienced in software project lifecycle management, technical training, relational database analysis, mentoring, design, coding and scripting.");
            result.Add("Demonstrate excellent written & verbal communication skills, initiative, creativity, and teamwork, with strong desire to excel. Thrives on new technology and is very eager to learn.");
            return result;
        }

        public static List<Job> GetJobs()
        {
            var result = new List<Job>();
            var tempJob = new Job()
            {
                Name = "U.S. Air National Guard",
                Title = "Jet Engine Technician",
                Location = "Knob Noster, MO",
                StartDate = new DateTime(2002, 02, 01),
                EndDate = new DateTime(2013, 07, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Maintain and repair jet engines on F-15 Airframe (PW F-100)");
            tempJob.JobDetails.Add("Maintain and repair jet engines on B-2 Airframe (GE F-118)");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Consumer Adjustment Company, Inc.",
                Title = "Software Developer",
                Location = "St. Louis, MO",
                StartDate = new DateTime(2011, 02, 01),
                EndDate = new DateTime(2011, 07, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Worked on correcting intranet bugs for business day to day work.");
            tempJob.JobDetails.Add("Worked on a call center and database integration application using MYSQL, ASP .Net 3.0, C#, VB, PHP, JavaScript, Linux and Windows");
            tempJob.JobDetails.Add("Created a sales and client website that collected client information for mailing lists using .Net 3.0 C#.");
            tempJob.JobDetails.Add("Converted internal website from PHP to ASP .Net 3.0 using C#.");
            tempJob.JobDetails.Add("Worked on consolidating manual administrative tasks to help save the company money.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "ROMDevGroup",
                Title = "Owner / Team Lead / Software Developer",
                Location = "O’Fallon, MO",
                StartDate = new DateTime(2011, 12, 01),
                EndDate = new DateTime(2015, 01, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Met with customers to determine what their company needs from a website..");
            tempJob.JobDetails.Add("Designed and developed web applications based on customers’ needs and input.");
            tempJob.JobDetails.Add("Collaborated with a small team of developers and assigned tasks as needed.");
            tempJob.JobDetails.Add("All projects and work completed using one of the following technologies: ASP.Net 4.0 framework, C#, PHP, Linq, Entity Framework, MySQL, SQL Server 2008, Bootstrap, CSS and jQuery.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Harris Corp.",
                Title = "Software Engineer / Consultant",
                Location = "Scott Air Force Base, IL",
                StartDate = new DateTime(2011, 11, 01),
                EndDate = new DateTime(2012, 05, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Worked on correcting production defects.");
            tempJob.JobDetails.Add("Developed new pages for reports based on project managers requirements.");
            tempJob.JobDetails.Add("Created a Java based filter called by Oracle that helped filter malicious inputs from the web forms.");
            tempJob.JobDetails.Add("Collaborated with team members to help identify and deploy bug fixes.");
            tempJob.JobDetails.Add("All projects and work completed utilizing one of the following technologies: ColdFusion, Java, CSS, JavaScript, and Oracle.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Solutia",
                Title = "Software Engineer / Consultant",
                Location = "St. Louis, MO",
                StartDate = new DateTime(2012, 05, 01),
                EndDate = new DateTime(2013, 02, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Worked with graphics arts department for website layout.");
            tempJob.JobDetails.Add("Reviewed and repaired security discrepancies on multiple international company websites.");
            tempJob.JobDetails.Add("Collaborated with companies contracting the development work. Reviewed and corrected issues from their final deliverables.");
            tempJob.JobDetails.Add("Assisted with the migration of several PHP public sites over to ASP .Net 3.5.");
            tempJob.JobDetails.Add("Assisted with the migration to Azure after the company was bought out and the sites were being moved.");
            tempJob.JobDetails.Add("All projects and work completed using one of the following technologies: ASP.Net 3.5, C#, VB, PHP, Linq, MySQL, SQL Server 2008, Oracle, JavaScript, CSS, jQuery and Joomla.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Schnucks",
                Title = "Software Engineer / Consultant",
                Location = "St. Louis, MO",
                StartDate = new DateTime(2013, 02, 01),
                EndDate = new DateTime(2013, 08, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Assisted in troubleshooting and fixing application defects");
            tempJob.JobDetails.Add("Developed requirements and test plans based on data gathered from project managers and internal system users.");
            tempJob.JobDetails.Add("Created a new responsive design for a vendor portal to assist in the negotiating of coupon prices for products that are sold. This involved a complete review and upgrade of the old VB .Net 2.0 code and non-relational data layer. ");
            tempJob.JobDetails.Add("Redesigned and updated several internal applications to use ASP .Net 3.5 instead of the old .Net 2.0 data connections they were using.");
            tempJob.JobDetails.Add("All projects and work completed using C# ASP .Net, VB, Soap WCF Services, Web Api,  JavaScript, CSS, jQuery and Oracle 9i");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Stifel Financial Corp",
                Title = "Senior Web Developer",
                Location = "St. Louis, MO",
                StartDate = new DateTime(2013, 11, 01),
                EndDate = new DateTime(2016, 05, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Created a billing application that gave financial advisers the ability to diversify an account and split the commissions between several different advisers and investment portfolios. When this application was planned, it was estimated to bring in more than $50 million in additional revenue to the company.");
            tempJob.JobDetails.Add("Created an automated queue system where trade reporting was being bottlenecked by a slow 3rd party reporting API. This allowed updates and reporting to be queued up via an intranet web application or picked up in a FTP drop folder. Optimized and re-wrote a few internal web applications to use a relational database instead of one massive table with 50+ columns.");
            tempJob.JobDetails.Add("Maintained and created SSRS reports when requested by different departments.");
            tempJob.JobDetails.Add("Created a meta tagging intranet site that would help the company link different types of television, radio, online video, magazine and other medias. This allowed the company to track people and the media and searchable tags for later use for showing information in other internal and public websites.");
            tempJob.JobDetails.Add("All projects and work completed using ASP.Net 4.5 framework, C#, Linq, Entity Framework, SQL Server 2008, Bootstrap, JavaScript, CSS and jQuery, Telerik Controls (Kindo UI and Kindo Grid).");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Drops of Joy Jewelry",
                Title = "Co-Founder / IT Lead / Lead Developer",
                Location = "O’Fallon, MO",
                StartDate = new DateTime(2014, 11, 01),
                IsCurrentlyEmployed = true
            };
            tempJob.JobDetails.Add("Collaborated and gathered requirement with stakeholders for website design and development needs.");
            tempJob.JobDetails.Add("Planned and developed a responsive website design using ASP.Net 4.5 framework, C#, Linq, Entity Framework, SQL Server 2008, Bootstrap, JavaScript, CSS and jQuery.");
            tempJob.JobDetails.Add("Integrated with PayPal, MailChimp, Google Analytics and other various 3rd party marketing apps.");
            tempJob.JobDetails.Add("Instrumental in assisting with any defects found in the application in a timely manner.");
            tempJob.JobDetails.Add("Developed an error tracking system that would email system errors as well as give insight into the steps leading up to the error.");
            tempJob.JobDetails.Add("Created a custom shopping cart with inventory tracking and coupon management built in.");
            tempJob.JobDetails.Add("Evaluated different hosting platforms and companies to bring the most value and savings to company.");
            tempJob.JobDetails.Add("Instrumental in the conversion over to Shopify.com selling platform as well as continued support.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Ellie Mae",
                Title = "Manager, Software Development, Application Engineering",
                Location = "St. Louis, MO",
                StartDate = new DateTime(2016, 05, 01),
                EndDate = new DateTime(2017, 07, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Mentored a team of developers, quarterly evaluations, code reviews, and development best practices for the team, reporting all progress to Director of Technology..");
            tempJob.JobDetails.Add("Assisted in the planning and setup of production, testing, staging, and development application servers using SQL Server 2008 r2, along with managing permissions, and watching performance.");
            tempJob.JobDetails.Add("Delegated tasks, plan sprints, run daily standups, conduct sprint review and retrospective, manage timelines of sprint with team members, communicated sprint progress and any concerns up to senior leadership.");
            tempJob.JobDetails.Add("Part of many discussions to evaluate customer experience based on system performance, and or system defects");
            tempJob.JobDetails.Add("Worked close with business units and product team to plan projects, estimating scope and time requirements and then executing on that plan.");
            tempJob.JobDetails.Add("Helped plan and execute on integrating two large systems after a company acquisition. Laying the foundation for a true bi-direction sync between systems.");
            tempJob.JobDetails.Add("Planned and coordinated several releases to correct system defects or release new features.");
            tempJob.JobDetails.Add("Developed a data repository all teams used for making database calls utilizing ASP.Net 4.5 framework, C#, Linq, Dapper, SQL Server 2008.");
            tempJob.JobDetails.Add("Mentored Junior developers, delegated work, time tracking, and planned daily activities.");
            tempJob.JobDetails.Add("Met with senior leadership on business requirements and put plans to designs.");
            tempJob.JobDetails.Add("Developed intranet monitoring page to view system health and stability.");
            tempJob.JobDetails.Add("Spearheaded and led team of developers that reduced priority 1 and 2 bugs down to zero from double digit numbers within a short time period.");
            tempJob.JobDetails.Add("Assisted scheduled and unscheduled releases to correct system defects or release new features.");
            result.Add(tempJob);

            tempJob = new Job()
            {
                Name = "Ungerboeck Software International",
                Title = "Senior Software Developer, Infrastructure Team",
                Location = "O’Fallon, MO ",
                StartDate = new DateTime(2017, 08, 01),
                EndDate = new DateTime(2018, 04, 01),
                IsCurrentlyEmployed = false
            };
            tempJob.JobDetails.Add("Worked on a team developing a new framework design for the current software set the company was using, utilizing ASP.Net 4.7.1 framework, C#, Angular, Linq, JavaScript, Soap WCF Service, Web Api, jQuery, CSS, Autofac, SQL Server 2008.");
            tempJob.JobDetails.Add("Mentored Junior developers, assisted with design questions on other teams.");
            tempJob.JobDetails.Add("Met with senior leadership on business requirements and put plans to designs.");
            tempJob.JobDetails.Add("Created Language selector end points for Angular to call followed by repository layer database calls and app service layer calls to support multi platform / device.");
            tempJob.JobDetails.Add("Created Web Theme selector end points for Angular to call followed by repository layer database calls and app service layer calls to support multi platform / device.");
            tempJob.JobDetails.Add("Created a Forgot Password endpoint for Angular to call followed by repository layer database calls and app service layer calls to support multi platform / device.");
            result.Add(tempJob);

            return result;
        }
        public static List<Degree> GetDegrees()
        {
            var result = new List<Degree>();
            var tempJob = new Degree()
            {
                Name = "ITT Technical Institute",
                Title = "Software Applications and Programming",
                Location = "Earth City",
                DegreeType = "Associate"
            };
            result.Add(tempJob);

            tempJob = new Degree()
            {
                Name = "ITT Technical Institute",
                Title = "Software Applications Development",
                Location = "Arnold, Missouri",
                DegreeType = "Bachelor"
            };
            result.Add(tempJob);

            tempJob = new Degree()
            {
                Name = "U.S. Air Force Tech School",
                Title = "Jet Engine Repair, Operation and Troubleshooting",
                Location = "Wichita Falls, TX",
                DegreeType = "Technical"
            };
            result.Add(tempJob);

            return result;
        }

        public static Dictionary<string, string> GetSkills()
        {
            var result = new Dictionary<string, string>()
            {
                {"Languages", "C#, Visual Basic, HTML, DHTML, MVC, Razor, Web Api, Soap WCF Services, jQuery, Telerik Controls, Entity Framework, Linq, Dapper, NLog, JavaScript, CSS, Bootstrap, XML, XSLT, XSL, Java, PHP and C++" },
                {"Databases", "MSSQL Server 2000 - 2008, MySQL, Oracle (9i, 10g), and Access" },
                {"Operating Systems", "Windows, Linux" },
                {"Tools", "Visual Studio 2003 – 2015, All Microsoft Office Products, NetBeans, Joomla, Shopify, WordPress, Eclipse, SoapUI, Team Foundation Server (TFS), and Jira, Azure" },
                {"Methodologies", "Agile, Waterfall and Scrum" }
            };

            return result;
        }

        public static List<string> GetInterests()
        {
            var result = new List<string>();
            result.Add("Apart from writing code I enjoy spending time with my family. My wife runs her business from home and homeschools our children so we try to get out of town as much as our schedules allow to take the kids on trips around the United States. So far, the furthest we have made it is Wisconsin, but we hope to see the Grand Canyon and Disneyland sometime in the near future.");
            result.Add("When family duties are done I normally end up in my office at home writing code for some side project I'm working on or I'm playing Star Citizen or other video games.");
            return result;
        }

        public static Dictionary<string, string> GetFAQ()
        {
            var result = new Dictionary<string, string>()
            {
                {"Why be a programmer?", "I enjoy building software solutions for people who have problems to solve. I enjoy making peoples life easier and I get a thrill out of the feeling it gives me to see them impressed at what software can do. " },
                {"What is your favorite programming language, and why?", "C# is my all time favorite and most comfortable to write. I enjoy the .net framework and all the features it offers for desktops, cloud, game and mobile development. I find it simpler to understand and write compared to C++ and Java. I played around with C Basic and C++ using micro controllers (Arduino and PI), but I always seem to come back to .net." },
                {"Do you Like being a contractor or full-time employee, and why?","I have always enjoyed being a contractor more than having a full-time position. This is mostly because of the experience it offers you and the diverse look into how several companies run their IT departments and code their product. My wife how ever enjoys a more stable paycheck and benefits so my OFFICAL ANSWER is that I love being employed full time."},
                {"Tabs or spaces, and why?", "I never really thought of this being an issue until I worked at a company who mandated one space indent. This drove me insane at first until I finally broke down and made sure all of my auto correct and code helpers respected that rule as well. I still prefer one (four spaced tab)." },
                {"Do you have a Github account?", "Yes, but I only recently created it about 8 months ago for a job interview." },
                {"What do you use to track your personal software projects?", "I currently use Team Foundation Server to organize / plan my projects.  I used to use Jira but got tired of managing my own Jira server with patches and updates. I enjoy using both tools about the same." },
                {"What does JSON stand for?", "Short answer, JavaScript Object Notation. Long answer is more of what it means to me? It’s the way I pass data from one end of the code verse to the other. I can easily wrap class structures into a JSON object and pass it from the controller to the view without having to worry about the consuming language." },
                {"Are you more comfortable as a manager or a developer?", "I really function well in both roles. I know how to follow directions from management and I also know how to lead others when needed. I feel these roles are combined more than we like to think in most cases. We all manage something at some level. Its more of what we are managing, people and their careers or software and our own career." },
                {"Are you more comfortable in, front end, back end or the database?", "I have spent most of my time in back end web services and supporting micro service frameworks. I am skilled in all areas of development but do not consider myself an ALL-KNOWING DBA or UI guy." }
            };
            return result;
        }
    }
}

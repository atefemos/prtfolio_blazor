using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About()
    {
        ViewBag.Skills = GetSkills();
        return View();
    }
    public IActionResult Projects()
    {
        ViewBag.Projects = GetProjects();
        return View();
    }
    private List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "E-Commerce Website",
                Description = "Full-stack e-commerce solution with user authentication, shopping cart, and payment integration.",
                TechStack = "ASP.NET Core, Entity Framework, Bootstrap, JavaScript",
                GitHubUrl = "https://github.com/yourusername/ecommerce-project",
                LiveUrl = "https://demo-ecommerce.com",
                CompletedDate = DateTime.Now.AddMonths(-2),
                IsFeatured = true
            },
            new Project
            {
            Id = 2,
            Title = "Portfolio Website",
            Description = "Personal portfolio website to showcase projects and skills.",
            TechStack = "ASP.NET Core MVC, Bootstrap, CSS",
            GitHubUrl = "https://github.com/yourusername/portfolio",
            LiveUrl = "https://myportfolio.com",
            CompletedDate = DateTime.Now.AddMonths(-5),
            IsFeatured = true
        },
        new Project
        {
            Id = 3,
            Title = "Task Management App",
            Description = "A web application for managing daily tasks and deadlines.",
            TechStack = "ASP.NET Core, Blazor, Entity Framework",
            GitHubUrl = "https://github.com/yourusername/taskapp",
            LiveUrl = "https://taskapp.com",
            CompletedDate = DateTime.Now.AddMonths(-1),
            IsFeatured = false
        }
        };
    }
    // HomeController.cs - GetSkills method
    private List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new Skill { Name = "C#", Category = "Backend", ProficiencyLevel = 5, IconClass = "fab fa-microsoft" },
            new Skill { Name = "ASP.NET Core", Category = "Backend", ProficiencyLevel = 4, IconClass = "fas fa-server" },
            new Skill { Name = "Blazor", Category = "Frontend", ProficiencyLevel = 4, IconClass = "fas fa-bolt" },
            new Skill { Name = "JavaScript", Category = "Frontend", ProficiencyLevel = 4, IconClass = "fab fa-js" },
            new Skill { Name = "Bootstrap", Category = "Frontend", ProficiencyLevel = 4, IconClass = "fab fa-bootstrap" },
            new Skill { Name = "SQL Server", Category = "Database", ProficiencyLevel = 4, IconClass = "fas fa-database" }
        };
    }
}
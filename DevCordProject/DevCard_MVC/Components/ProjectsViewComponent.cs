using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new List<Projects>
            {
                new Projects(1,"Project Heading","Project intro lorem ipsum dolor sit amet...","Google","project-1.jpg"),
                new Projects(2,"Project Heading","Project intro lorem ipsum dolor sit amet...","Dropbox","project-2.jpg"),
                new Projects(3, "Project Heading", "Project intro lorem ipsum dolor sit amet...", "Uber", "project-3.jpg"),
                new Projects(4, "Project Heading", "Project intro lorem ipsum dolor sit amet...", "GOT", "project-4.jpg")
        };
            return View("_Projects", model);
        }
    }
}

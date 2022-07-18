using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }
    
    [Route("/story")]
    public ActionResult Story(string animal,string food,string personname,string noun,string adjective,string noun2,string container,string color,string number,string number2)
    {
    StoryVariable myStoryVariable = new StoryVariable();
    myStoryVariable.Animal = animal;
    myStoryVariable.Food = food;
    myStoryVariable.PersonName = personname;
    myStoryVariable.Noun = noun;
    myStoryVariable.Adjective = adjective;
    myStoryVariable.Noun2 = noun2;
    myStoryVariable.Container = container;
    myStoryVariable.Color = color;
    myStoryVariable.Number = number;
    myStoryVariable.Number2 = number2;
    return View(myStoryVariable);
    }
  }
}
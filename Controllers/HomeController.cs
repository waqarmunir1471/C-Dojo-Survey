using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace C_Dojo_Survey.Controllers{
    public class HomeController : Controller{
    public static Dictionary<string, string> dojosurvey= new Dictionary<string, string>();

        [HttpGet("")]
        public IActionResult Index(){
            return View("Index");
        }

        [HttpPost("process")]
        public IActionResult process(string yName,string dojoLocation,string listLanguage ,string comments){
            ViewBag.Name = yName;
            ViewBag.dojoLocation = dojoLocation;
            ViewBag.listLanguage = listLanguage;
            ViewBag.comments = comments;
            return View("result");
        }

        // [HttpGet("result")]
        // public IActionResult result(){
        //     ViewBag.dojosurvey = dojosurvey;
        //     return View("result");
        // }
        
    }
}
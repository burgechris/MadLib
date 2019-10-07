using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route ("/")] 
        // We use a single slash to create a default page when you loaf the localhost.
        public ActionResult Form() { return View(); }


        [Route ("/output")]
        public ActionResult Output(string adjectiveOne, string adjectiveTwo, string adjectiveThree, string nounOne, string nounTwo, string nounThree, string nounFour, string properNoun) 
        {

        MadLibVariable myMadLib = new MadLibVariable();
        myMadLib.AdjectiveOne = adjectiveOne;
        myMadLib.AdjectiveTwo = adjectiveTwo;
        myMadLib.AdjectiveThree = adjectiveThree;
        myMadLib.NounOne = nounOne;
        myMadLib.NounTwo = nounTwo;
        myMadLib.NounThree = nounThree;
        myMadLib.NounFour = nounFour;
        myMadLib.ProperNoun = properNoun;

        return View(myMadLib);
        }
    }
}

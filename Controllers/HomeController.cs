using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/hello")]
    // public string Hello() { return "Hello friend!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend"; }

    [Produces("text/html")]
    // [Route("/")]
    // public ActionResult Letter()
    // {
    //   return View();
    // }
    [Route("/journal")]
    public ActionResult Journal()
    {
      return View();
    }
    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Jessica");
      myLetterVariable.SetSender("John");

      return View(myLetterVariable);
    }
      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }
      [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
        }

  }
}

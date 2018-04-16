using Microsoft.AspNetCore.Mvc;
using Triangle.Models;

namespace Triangles.Controllers
{
    public class HomeController : Controller
    {
        [Route("/test")] //localhost:5000/test in browser
        public string Test() { return "Testing 1, 2, 3"; }

        [Route("/")]
        public ActionResult Form()
        {
          return View();
        }

        // [Route("/triangle_result")]
        // public ActionResult TriangleResult()
        // {
        //   return View();
        // }

        [Route("/triangle_form")]
        public ActionResult Result()
        {
          TriangleVariable myTriangleVariable = new TriangleVariable();
          myTriangleVariable.SetSide1(int.Parse(Request.Query["side1"]));
          myTriangleVariable.SetSide2(int.Parse(Request.Query["side2"]));
          myTriangleVariable.SetSide3(int.Parse(Request.Query["side3"]));
          return View("TriangleResult", myTriangleVariable);
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController:Controller
    {
        //public string Index()
        //{
        //    return "WebGentle";
        //}

        public ViewResult Index()
        {
            return View();
            //fullpath needs extension also
            //return View("TempView/GautamTemp.cshtml");
            //or same
           // return View("~/TempView/GautamTemp.cshtml");
            //Relative path need not extenstion (it points to default view ,then take 2 back to get view)
           //return View("../../TempView/GautamTemp");


        }

        public ViewResult AboutUs()
        {
            
            return View();
        }

        public ViewResult ContactUs()
        {
            var obj = new { ID =1,Name ="Gautam Katyal"};
            return View(obj);
        }
            
    }
}

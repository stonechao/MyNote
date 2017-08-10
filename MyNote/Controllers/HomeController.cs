using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNote.Models.ViewModels;

namespace MyNote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var my_money_list = new List<MoneyItemViewModel>()
            {
                new MoneyItemViewModel()
                {
                    NoteType=1,
                    NoteAmount=300,
                    NoteDate= DateTime.Parse("2017/01/02"),
                },

                new MoneyItemViewModel()
                {
                    NoteType=1,
                    NoteAmount=1800,
                    NoteDate= DateTime.Parse("2017/01/03"),
                },
                new MoneyItemViewModel()
                {
                    NoteType=1,
                    NoteAmount=800,
                    NoteDate= DateTime.Parse("2017/01/04"),
                }
            };

            return View(my_money_list);

           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}
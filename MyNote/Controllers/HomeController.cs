using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNote.Models.ViewModels;
using MyNote.Models;

namespace MyNote.Controllers
{
    public class HomeController : Controller
    {

        private readonly MoneyItemService _my_monyservice;

        public HomeController()
        {
            _my_monyservice = new MoneyItemService();
        }

        public ActionResult Index()
        {

            IEnumerable<AccountBook> my_account_list = _my_monyservice.Lookup(); //db.AccountBook.ToList();
            var my_money_list = new List<MoneyItemViewModel>();


                foreach ( var my_account_item in my_account_list)
                {
                    my_money_list.Add(
                    new MoneyItemViewModel()
                    {
                        NoteType = my_account_item.Categoryyy,
                        NoteAmount = my_account_item.Amounttt,
                        NoteDate = my_account_item.Dateee
                    });
                }
                
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNote.Models.ViewModels;

namespace MyNote.Controllers
{
    public class MoneyItemOneController : Controller
    {
        // GET: MoneyItemOne
        public ActionResult AddItem()
        {

            var my_single_item = new MoneyItemViewModel();

            return View(my_single_item);
        }
    }
}
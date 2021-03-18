using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMSController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SMSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SMSController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

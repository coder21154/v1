﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using CS4400.Filters;
using CS4400.Models;

namespace CS4400.Controllers
{
    public class ParticipantController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Characteristics()
        {
            return View();
        }
    }
}

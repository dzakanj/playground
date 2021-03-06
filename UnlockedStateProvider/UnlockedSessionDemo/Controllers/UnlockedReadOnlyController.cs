﻿using System.Web.Mvc;
using System.Web.SessionState;
using UnlockedStateProvider;
using UnlockedStateProvider.Redis;

namespace UnlockedSessionDemo.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    [RedisUnlockedStateUsage(Order = 0, Usage = UnlockedStateUsage.ReadOnly)]
    public class UnlockedReadOnlyController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
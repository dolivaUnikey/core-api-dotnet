// Copyright 2012-2016 Unikey Technologies, Inc. All Rights Reserved.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unikey;

namespace UnikeyDemo.Controllers
{
    public class HomeController : Controller
    {
        private string AppId = "YOU APP ID";
        private string AppSecret = "YOUR APP SECRET";

        public ActionResult Index()
        {

            if (Session["token"] == null)
            {
                return
                    Redirect(
                        "https://kevostaging.unikey.com/user/oauth?client_id=add634b7-fd02-4e83-9846-a34c394fdcdb&redirect_uri=https%3A%2F%2Funikeydemo.azurewebsites.net/home/authorize&response_type=code&scope=none&state=none");
            }

            var client = new Client((string)Session["token"]);
            var me = client.Me();
            ViewBag.User = me;
            ViewBag.Locks = client.Locks(me.Id).Locks;

            return View();
        }

        public ActionResult Authorize()
        {
            var code = Request.Params["code"];
            var tokenResult = Client.CreateToken(AppId, AppSecret, code);
            Session["token"] = tokenResult.AccessToken;

            return Redirect("/home/");
        }

        public ActionResult Lock(string id)
        {
            var client = new Client((string)Session["token"]);
            client.CreateLockCommand(id, "lock");

            return Redirect("/home/");
        }
        public ActionResult Unlock(string id)
        {
            var client = new Client((string)Session["token"]);
            client.CreateLockCommand(id, "unlock");

            return Redirect("/home/");
        }

    }
}
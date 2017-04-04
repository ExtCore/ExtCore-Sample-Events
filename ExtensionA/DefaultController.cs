// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using ExtCore.Events;
using ExtensionA.Events;
using Microsoft.AspNetCore.Mvc;

namespace ExtensionA
{
  public class DefaultController : Controller
  {
    public ActionResult Index()
    {
      Event<ISomeActionEventHandler, string>.Broadcast("Some action has happened at " + DateTime.Now.ToString() + "!");
      return this.Content("Some content from the extension A.");
    }
  }
}
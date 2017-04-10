// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using ExtensionA.Events;

namespace ExtensionB
{
  public class SomeActionEventHandler1 : ISomeActionEventHandler
  {
    public int Priority { get { return 1000; } }

    public void HandleEvent(string argument)
    {
      File.AppendAllText(
        @"C:\<Path to the project>\ExtCore-Sample-Events\WebApplication\log.txt",
        "Event handler 1: " + argument + "\r\n"
      );
    }
  }
}
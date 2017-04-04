// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using ExtensionA.Events;

namespace ExtensionB
{
  public class SomeActionEventHandler : ISomeActionEventHandler
  {
    public void HandleEvent(string argument)
    {
      File.WriteAllText(@"C:\<Path to the project>\ExtCore-Sample-Events\WebApplication\log.txt", argument);
    }
  }
}
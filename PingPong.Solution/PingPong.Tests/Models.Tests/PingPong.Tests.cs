using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void Ping_DivisibleBy3and5_String()
    {
      Assert.AreEqual("7", Game.Ping(7));
    }
    [TestMethod]
    public void Display_ListAllResults_List()
    {
      List<string> newList = new List<string> {"1","2","Ping"};
      List<string> result = Game.Display(3);
      CollectionAssert.AreEqual(newList, result);
    }
  }
}

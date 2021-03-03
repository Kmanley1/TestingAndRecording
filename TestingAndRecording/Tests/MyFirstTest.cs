
using System;
using NUnit.Framework;
using TestingAndRecording.Helpers;

namespace Test
{
    [TestFixture]
    public class MyFirstTest : TestBase
    {
        [Test]
        public void NopCommerceDummyTest()
        {
            Recording recording = new Recording();

            recording.CreateRecording();

            Pages.Home.isAt();
            Pages.Home.GoToComputers();
            Pages.Computers.isAt();
            Pages.Computers.EnterSearchText("Search me!");
            Pages.Computers.ClickSearch();

            recording.EndRecording();
        }
    }
}
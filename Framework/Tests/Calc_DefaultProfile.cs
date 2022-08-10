using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestModellerCSharp.Pages.Samples.Calculator;
using Tests;
using Utilities;
using CuriositySoftware.RunResult.Entities;

namespace Tests
{
    [TestFixture]
    public class Calc_DefaultProfile : TestBase
    {
		

		
       [Test]
        [TestModellerId("6162d72d-4620-49b8-aa0c-b698f4d574b0")]
        public void OpenApplication()
        {
            app = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        

        TestModellerCSharp.Pages.DesktopActions	 _DesktopActions	= new TestModellerCSharp.Pages.DesktopActions (app);
    TestModellerLogger.SetLastNodeGuid("3dcec34e-e88e-4135-a4d9-f398439babcb");
    _DesktopActions.OpenApplication("calc.exe");

        }

    }
}
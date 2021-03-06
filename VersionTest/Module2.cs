﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace VersionTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Module2 recording.
    /// </summary>
    [TestModule("7959983d-f364-42b4-8d7e-5baa4f13ffe5", ModuleType.Recording, 1)]
    public partial class Module2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VersionTestRepository repository.
        /// </summary>
        public static VersionTestRepository repo = VersionTestRepository.Instance;

        static Module2 instance = new Module2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Module2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Module2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://testgames.be/connections/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://testgames.be/connections/", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ConnectionManager.Logout' at 59;34.", repo.ConnectionManager.LogoutInfo, new RecordItemIndex(1));
            repo.ConnectionManager.Logout.Click("59;34");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'English' on item 'ConnectionManager.Language'.", repo.ConnectionManager.LanguageInfo, new RecordItemIndex(2));
            repo.ConnectionManager.Language.Element.SetAttributeValue("TagValue", "English");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

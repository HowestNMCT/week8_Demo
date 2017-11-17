using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//PLATFORM SPECIFIC API CALLS:
//  using only for Android

namespace SAP2_ParallelClass
{
    public class PlatformInfo
    {
        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for model in an Android specific way
        /// </summary>
        /// <returns>current Android model</returns>
        public string GetModel()
        {
            return string.Format("{0} {1}",
                 Build.Manufacturer, Build.Model);
        }

        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for version in an Android specific way
        /// </summary>
        /// <returns>Android version on the current device</returns>
        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}
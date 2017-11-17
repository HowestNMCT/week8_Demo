using System;

//PLATFORM SPECIFIC API CALLS:
//1. platform specific uses
using Android.OS;

//2. add reference / using statement to PCL project
using PCL_DepServ.Model;

//3. make the class available for the PCL project using the DependencyService
using Xamarin.Forms;
[assembly: Dependency(typeof(PCL_DepServ.Droid.DroidInfo))]


namespace PCL_DepServ.Droid
{
    public class DroidInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", Build.Manufacturer, Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}
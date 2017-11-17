//PLATFORM SPECIFIC API CALLS:
//1. platform specific uses
using UIKit;

//2. add reference / using statement to PCL project
using PCL_DepServ.Model;

//3. make the class available for the PCL project using the DependencyService
using Xamarin.Forms;
[assembly: Dependency(typeof(PCL_DepServ.iOS.AppleInfo))]

namespace PCL_DepServ.iOS
{
    public class AppleInfo : IPlatformInfo
    {
        private UIDevice _device = new UIDevice();

        public string GetModel()
        {
            return _device.Model;
        }

        public string GetVersion()
        {
            return _device.SystemName + " " + _device.SystemVersion;
        }
    }
}

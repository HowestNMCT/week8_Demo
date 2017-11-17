
//PLATFORM SPECIFIC API CALLS:
//1. platform specific uses
using Windows.Security.ExchangeActiveSyncProvisioning;

//2. add reference / using statement to PCL project
using PCL_DepServ.Model;

//3. make the class available for the PCL project using the DependencyService
using Xamarin.Forms;
[assembly: Dependency(typeof(PCL_DepServ.UWP.PlatformInfo))]


namespace PCL_DepServ.UWP
{
    public class PlatformInfo : IPlatformInfo
    {
        private EasClientDeviceInformation _info = new EasClientDeviceInformation();

        public string GetModel()
        {
            return _info.SystemManufacturer + " " + _info.SystemProductName;
        }

        public string GetVersion()
        {
            return _info.OperatingSystem;
        }
    }
}

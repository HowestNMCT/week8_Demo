using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PLATFORM SPECIFIC API CALLS:
//  using only for UWP
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace SAP2_ParallelClass
{
    public class PlatformInfo
    {
        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for model in an UWP specific way
        /// </summary>
        /// <returns>current UWP model</returns>
        public string GetModel()
        {
            EasClientDeviceInformation devInfo = new EasClientDeviceInformation();
            return string.Format("{0} {1}",
                devInfo.SystemManufacturer, devInfo.SystemProductName);
        }

        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for version in an UWP specific way
        /// </summary>
        /// <returns>UWP version on the current device</returns>
        public string GetVersion()
        {
            EasClientDeviceInformation devInfo = new EasClientDeviceInformation();
            return devInfo.OperatingSystem;

        }
    }
}
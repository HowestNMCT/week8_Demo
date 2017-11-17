using System;
using System.Collections.Generic;
using System.Text;

//PLATFORM SPECIFIC API CALLS:
//  using only for iOS
using UIKit;

namespace SAP2_ParallelClass
{
    public class PlatformInfo
    {
        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for model in an iOS specific way
        /// </summary>
        /// <returns>current iOS model</returns>
        public string GetModel()
        {
            UIDevice device = new UIDevice();
            return device.Model.ToString();
        }

        /// <summary>
        /// PLATFORM SPECIFIC API CALLS:
        /// ask for version in an iOS specific way
        /// </summary>
        /// <returns>iOS version on the current device</returns>
        public string GetVersion()
        {
            UIDevice device = new UIDevice();
            return string.Format("{0} {1}",
                device.SystemName, device.SystemVersion);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//PLATFORM SPECIFIC API CALLS:
/////Use preprocessing to specify usings based on the platform /////
#if __IOS__
    using UIKit;

#elif __ANDROID__
using Android.OS;

#elif WINDOWS_APP || WINDOWS_PHONE_APP || WINDOWS_UWP
using Windows.Security.ExchangeActiveSyncProvisioning;

#endif
/////////////////////////////////// 


namespace SAP1_Preprocess
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            DisplayModelAndVersion();
		}

        /// <summary>
        /// //PLATFORM SPECIFIC API CALLS:
        /// Use preprocessing to ask for model and version in a platform specific way 
        /// </summary>
        private void DisplayModelAndVersion()
        {
#if __IOS__
            UIDevice device = new UIDevice();
            lblModel.Text = device.Model.ToString();
            lblVersion.Text = string.Format("{0} {1}", 
                device.SystemName, device.SystemVersion);

#elif __ANDROID__
            lblModel.Text = string.Format("{0} {1}",
                Build.Manufacturer, Build.Model);
            lblVersion.Text = Build.VERSION.Release.ToString();

#elif WINDOWS_APP || WINDOWS_PHONE_APP || WINDOWS_UWP
            EasClientDeviceInformation devInfo = new EasClientDeviceInformation();
            lblModel.Text = string.Format("{0} {1}",
                devInfo.SystemManufacturer, devInfo.SystemProductName);
            lblVersion.Text = devInfo.OperatingSystem;

#endif
        }
    }
}

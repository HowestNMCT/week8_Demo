using PCL_DepServ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PCL_DepServ
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
            //use the DependencyService to get the correct class that implements IPlatformInfo
            IPlatformInfo info = DependencyService.Get<IPlatformInfo>();
            //model info
            lblModel.Text = info.GetModel();
            //version info
            lblVersion.Text = info.GetVersion();
        }
    }
}

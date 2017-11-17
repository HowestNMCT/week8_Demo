using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SAP2_ParallelClass
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            DisplayModelAndVersion();
		}

        private void DisplayModelAndVersion()
        {
            PlatformInfo platformInfo = new PlatformInfo();
            lblModel.Text = platformInfo.GetModel();
            lblVersion.Text = platformInfo.GetVersion();
        }
    }
}

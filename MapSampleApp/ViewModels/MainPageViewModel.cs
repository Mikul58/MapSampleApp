using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MapSampleApp.ViewModels
{
    class MainPageViewModel
    {
        public MainPageViewModel()
        {
            var status = Task.Run(async ()=> await Permissions.RequestAsync<Permissions.LocationWhenInUse>());
        }
    }
}

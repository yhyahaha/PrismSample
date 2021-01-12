using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Regions;
using PrismSample.Blue;
using Prism.Navigation;

namespace PrismSample.Red
{
    public class TomatoViewModel : BindableBase,IDestructible
    {
        public TomatoViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("BlueContent", typeof(DarkTurquois));
        }

        public void Destroy()
        {
            System.Diagnostics.Debug.WriteLine("Tomato is destroied");
        }
    }
}

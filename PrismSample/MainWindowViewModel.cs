using Prism.Mvvm;
using Prism.Regions;
using PrismSample.Red;
using PrismSample.Blue;
using PrismSample.Green;
using System;

namespace PrismSample
{
    public class MainWindowViewModel : BindableBase, IDisposable
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regMane)
        {
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(Tomato));
            regMane.RegisterViewWithRegion("RedContent", typeof(Tomato));
            regMane.RegisterViewWithRegion("GreenContent", typeof(MediumSeaGreen));
            regMane.RegisterViewWithRegion("BlueContent", typeof(DarkTurquois));
        }

        public void Dispose()
        {
            Dispose(disposing:false);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    foreach(var region in this.regionManager.Regions)
                    {
                        region.RemoveAll();
                    }
                }
                disposedValue = true;
            }
        }

        private bool disposedValue;
        private IRegionManager regionManager;
    }
}

using Prism.Mvvm;
using Prism.Regions;
using PrismSample.Red;
using PrismSample.Blue;
using PrismSample.Green;

namespace PrismSample
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(Tomato));
            //regionManager.RegisterViewWithRegion("RedContent", typeof(Tomato));
            //regionManager.RegisterViewWithRegion("GreenContent", typeof(MediumSeaGreen));
            //regionManager.RegisterViewWithRegion("BlueContent", typeof(DarkTurquois));
        }
    }
}

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismSample.Red;
using PrismSample.Blue;
using PrismSample.Green;

namespace PrismSample
{
    public class ColorViewsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager?.RegisterViewWithRegion("ContentRegion", typeof(Tomato));

            //regionManager?.RegisterViewWithRegion("RedContent", typeof(Tomato));
            //regionManager?.RegisterViewWithRegion("GreenContent", typeof(DarkTurquois));
            //regionManager?.RegisterViewWithRegion("BlueContent", typeof(MediumSeaGreen));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<Tomato, TomatoViewModel>();

            containerRegistry.RegisterForNavigation<MediumSeaGreen, MediumSeaGreenViewModel>();
        }
    }
}
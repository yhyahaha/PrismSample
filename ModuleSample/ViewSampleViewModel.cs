using Prism.Mvvm;
using Prism.Ioc;
using Prism.Commands;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using Prism.Unity;

namespace PrismSample
{
    public class ViewSampleViewModel : BindableBase
    {
        //public ViewSampleViewModel(IContainerProvider injectionContainer)
        //{
        //    this.container = injectionContainer;
        //    this.ExecuteAgent = new DelegateCommand(this.onExecuteAgent);
        //}

        public ViewSampleViewModel()
        {
            this.ExecuteAgent = new DelegateCommand(this.onExecuteAgent);
        }


        public DelegateCommand ExecuteAgent { get; }

        void onExecuteAgent()
        {
            using (var agent = ((Application.Current as PrismApplication).Container.Resolve(typeof(DataAgent)) as DataAgent))
            {
                var person = agent?.GetPerson(1);
            }
        }

        private IContainerProvider container = null;

    }
}

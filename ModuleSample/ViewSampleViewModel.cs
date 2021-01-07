using Prism.Mvvm;
using Prism.Ioc;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismSample
{
    public class ViewSampleViewModel : BindableBase
    {
        public ViewSampleViewModel(IContainerProvider injectionContainer)
        {
            this.container = injectionContainer;
            this.ExecuteAgent = new DelegateCommand(this.onExecuteAgent);
        }

        public DelegateCommand ExecuteAgent { get; }

        void onExecuteAgent()
        {
            using (var agent = this.container.Resolve<DataAgent>())
            {
                var person = agent?.GetPerson(1);
            }
        }

        private IContainerProvider container = null;

    }
}

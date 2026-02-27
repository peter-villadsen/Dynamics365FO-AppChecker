using MaterialDesignExtensions.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace GraphExplorer.ViewModels
{
    using MaterialDesignExtensions.Model;

    public class StepperColorViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067 // Event is never used
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
        public StepperColorViewModel()
        {

        }
    }

    public class StepperShapeViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067 // Event is never used
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
        public StepperShapeViewModel()
        {

        }
    }


    class ConfigurationWindowViewModel : ViewModelBase
    { 
        public ConfigurationWindowViewModel()
        {
        }
    }
}

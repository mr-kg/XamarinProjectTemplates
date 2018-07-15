using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}

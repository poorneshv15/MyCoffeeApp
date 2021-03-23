using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquimentViewModel : BindableObject
    {
        public CoffeeEquimentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }
        public ICommand IncreaseCount { get; }


        int count = 0;
        private void OnIncrease(object obj)
        {
            count++;
            DisplayCount = $"Button Clicked {count} time(s)";
        }

        private string displayCount;
        public string DisplayCount
        {
            get
            {
                return displayCount;
            }
            set
            {
                if (value == displayCount)
                    return;
                displayCount = value;
                OnPropertyChanged();
            }
        }
    }
}

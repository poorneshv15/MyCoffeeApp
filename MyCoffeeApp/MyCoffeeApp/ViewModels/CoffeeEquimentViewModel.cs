using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquimentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<string> Coffee { get; }
        public CoffeeEquimentViewModel()
        {
            IncreaseCountCommand = new Command(OnIncrease);
            CallServiceCommand = new AsyncCommand(CallServer);

        }

        private async Task CallServer()
        {
            var Items = new List<string> { "Cappuchino", "Coffee Latte", "Coffee Mocha" };
            Coffee.AddRange(Items);
        }

        public ICommand IncreaseCountCommand { get; }
        public ICommand CallServiceCommand {get;}

        int count = 0;
        private void OnIncrease(object obj)
        {
            count++;
            DisplayCount = $"Button Clicked {count} time(s)";
        }

        private string displayCount;

        /*  public string DisplayCount
        {
            get
            {
                return displayCount;
            }
            set
            {
                if (displayCount == value)
                    return;
                displayCount = value;
            }
        }*/

        public string DisplayCount
        {
            get => displayCount;
            set => SetProperty(ref displayCount, value);
        }
    }
}

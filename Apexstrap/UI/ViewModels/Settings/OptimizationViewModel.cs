using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Apexstrap.UI.ViewModels.Settings
{
    public class OptimizationViewModel : NotifyPropertyChangedViewModel
    {
        public ICommand ApplyOptimizationsCommand => new RelayCommand(ApplyOptimizations);
        public ICommand ResetOptimizationsCommand => new RelayCommand(ResetOptimizations);

        private void ApplyOptimizations()
        {
            App.Settings.Prop.Save();
        }

        private void ResetOptimizations()
        {
            PingBoostEnabled = false;
            TelemetryDisabled = false;
            HighPriorityEnabled = false;
            CoreAffinityEnabled = false;
            SelectedCoreCount = 0;
            NetworkThrottlingDisabled = false;
            GameModeEnabled = false;
            App.Settings.Prop.Save();
        }

        public bool PingBoostEnabled
        {
            get => App.Settings.Prop.PingBoostEnabled;
            set
            {
                App.Settings.Prop.PingBoostEnabled = value;
                OnPropertyChanged(nameof(PingBoostEnabled));
            }
        }

        public bool TelemetryDisabled
        {
            get => App.Settings.Prop.TelemetryDisabled;
            set
            {
                App.Settings.Prop.TelemetryDisabled = value;
                OnPropertyChanged(nameof(TelemetryDisabled));
            }
        }

        public bool HighPriorityEnabled
        {
            get => App.Settings.Prop.HighPriorityEnabled;
            set
            {
                App.Settings.Prop.HighPriorityEnabled = value;
                OnPropertyChanged(nameof(HighPriorityEnabled));
            }
        }

        public bool CoreAffinityEnabled
        {
            get => App.Settings.Prop.CoreAffinityEnabled;
            set
            {
                App.Settings.Prop.CoreAffinityEnabled = value;
                OnPropertyChanged(nameof(CoreAffinityEnabled));
            }
        }

        public int SelectedCoreCount
        {
            get => App.Settings.Prop.SelectedCoreCount;
            set
            {
                App.Settings.Prop.SelectedCoreCount = value;
                OnPropertyChanged(nameof(SelectedCoreCount));
            }
        }

        public bool NetworkThrottlingDisabled
        {
            get => App.Settings.Prop.NetworkThrottlingDisabled;
            set
            {
                App.Settings.Prop.NetworkThrottlingDisabled = value;
                OnPropertyChanged(nameof(NetworkThrottlingDisabled));
            }
        }

        public bool GameModeEnabled
        {
            get => App.Settings.Prop.GameModeEnabled;
            set
            {
                App.Settings.Prop.GameModeEnabled = value;
                OnPropertyChanged(nameof(GameModeEnabled));
            }
        }
    }
}

using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Apexstrap.UI.ViewModels.Settings
{
    public class DiscordRPCViewModel : NotifyPropertyChangedViewModel
    {
        public ICommand SaveDiscordRPCSettingsCommand => new RelayCommand(SaveDiscordRPCSettings);

        private void SaveDiscordRPCSettings()
        {
            App.Settings.Prop.Save();
        }

        public bool DiscordRPCEnabled
        {
            get => App.Settings.Prop.DiscordRPCEnabled;
            set
            {
                App.Settings.Prop.DiscordRPCEnabled = value;
                OnPropertyChanged(nameof(DiscordRPCEnabled));
            }
        }

        public bool DiscordRPCShowDetails
        {
            get => App.Settings.Prop.DiscordRPCShowDetails;
            set
            {
                App.Settings.Prop.DiscordRPCShowDetails = value;
                OnPropertyChanged(nameof(DiscordRPCShowDetails));
            }
        }

        public string DiscordRPCApplicationId
        {
            get => App.Settings.Prop.DiscordRPCApplicationId ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCApplicationId = value;
                OnPropertyChanged(nameof(DiscordRPCApplicationId));
            }
        }

        public string DiscordRPCLargeImageKey
        {
            get => App.Settings.Prop.DiscordRPCLargeImageKey ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCLargeImageKey = value;
                OnPropertyChanged(nameof(DiscordRPCLargeImageKey));
            }
        }

        public string DiscordRPCLargeImageText
        {
            get => App.Settings.Prop.DiscordRPCLargeImageText ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCLargeImageText = value;
                OnPropertyChanged(nameof(DiscordRPCLargeImageText));
            }
        }

        public string DiscordRPCSmallImageKey
        {
            get => App.Settings.Prop.DiscordRPCSmallImageKey ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCSmallImageKey = value;
                OnPropertyChanged(nameof(DiscordRPCSmallImageKey));
            }
        }

        public string DiscordRPCSmallImageText
        {
            get => App.Settings.Prop.DiscordRPCSmallImageText ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCSmallImageText = value;
                OnPropertyChanged(nameof(DiscordRPCSmallImageText));
            }
        }

        public string DiscordRPCButton1Label
        {
            get => App.Settings.Prop.DiscordRPCButton1Label ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCButton1Label = value;
                OnPropertyChanged(nameof(DiscordRPCButton1Label));
            }
        }

        public string DiscordRPCButton1Url
        {
            get => App.Settings.Prop.DiscordRPCButton1Url ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCButton1Url = value;
                OnPropertyChanged(nameof(DiscordRPCButton1Url));
            }
        }

        public string DiscordRPCButton2Label
        {
            get => App.Settings.Prop.DiscordRPCButton2Label ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCButton2Label = value;
                OnPropertyChanged(nameof(DiscordRPCButton2Label));
            }
        }

        public string DiscordRPCButton2Url
        {
            get => App.Settings.Prop.DiscordRPCButton2Url ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCButton2Url = value;
                OnPropertyChanged(nameof(DiscordRPCButton2Url));
            }
        }

        public string DiscordRPCState
        {
            get => App.Settings.Prop.DiscordRPCState ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCState = value;
                OnPropertyChanged(nameof(DiscordRPCState));
            }
        }

        public string DiscordRPCDetails
        {
            get => App.Settings.Prop.DiscordRPCDetails ?? "";
            set
            {
                App.Settings.Prop.DiscordRPCDetails = value;
                OnPropertyChanged(nameof(DiscordRPCDetails));
            }
        }
    }
}

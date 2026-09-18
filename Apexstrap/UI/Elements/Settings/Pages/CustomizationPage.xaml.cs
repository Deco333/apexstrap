using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using Wpf.Ui.Controls;

namespace Apexstrap.UI.Elements.Settings.Pages
{
    public partial class CustomizationPage : UiPage
    {
        public CustomizationPage()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is string colorHex)
            {
                var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorHex));
                Application.Current.Resources["AccentFillColorPrimaryBrush"] = brush;
                // Save to config here
            }
        }

        private void ThemeRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb && rb.Tag is string theme)
            {
                // Apply theme logic (Light/Dark/System)
                // App.Current.ChangeTheme(theme);
            }
        }

        private void Mica_Checked(object sender, RoutedEventArgs e)
        {
            // Enable Mica/Acrylic effect
            if (Window.GetWindow(this) is Wpf.Ui.Controls.UiWindow window)
            {
                window.ExtendsContentIntoTitleBar = true;
                // window.ApplyMica();
            }
        }

        private void Mica_Unchecked(object sender, RoutedEventArgs e)
        {
            // Disable Mica
            if (Window.GetWindow(this) is Wpf.Ui.Controls.UiWindow window)
            {
                window.ExtendsContentIntoTitleBar = false;
            }
        }

        private void BrowseIcon_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Icon Files|*.ico|All Files|*.*",
                Title = "Select Window Icon"
            };

            if (dialog.ShowDialog() == true)
            {
                IconPathBox.Text = dialog.FileName;
                // Logic to copy file and update app icon
            }
        }

        private void BrowseLogo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg|All Files|*.*",
                Title = "Select Main Logo"
            };

            if (dialog.ShowDialog() == true)
            {
                LogoPathBox.Text = dialog.FileName;
                // Logic to update logo in UI
            }
        }

        private void ResetAssets_Click(object sender, RoutedEventArgs e)
        {
            IconPathBox.Text = "";
            LogoPathBox.Text = "";
            // Reset to default assets
        }
    }
}

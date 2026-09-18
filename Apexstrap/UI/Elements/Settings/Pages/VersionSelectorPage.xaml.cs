using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace Apexstrap.UI.Elements.Settings.Pages
{
    public partial class VersionSelectorPage : UiPage
    {
        public VersionSelectorPage()
        {
            InitializeComponent();
            LoadVersions();
        }

        private void LoadVersions()
        {
            // Simulate scanning for versions
            DetectedVersionsText.Text = "v0.60.0 (Stable), v0.61.0 (Beta)";
            ActiveChannelText.Text = "Stable";
        }

        private void VersionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VersionComboBox.SelectedItem is ComboBoxItem item && item.Tag?.ToString() == "custom")
            {
                CustomPathGrid.Visibility = Visibility.Visible;
            }
            else
            {
                CustomPathGrid.Visibility = Visibility.Collapsed;
            }
        }

        private void BrowsePath_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Executable Files|*.exe|All Files|*.*",
                Title = "Select RobloxPlayerBeta.exe"
            };

            if (dialog.ShowDialog() == true)
            {
                CustomPathBox.Text = dialog.FileName;
            }
        }

        private void ScanVersions_Click(object sender, RoutedEventArgs e)
        {
            DetectedVersionsText.Text = "Scanning...";
            // Logic to scan registry and common paths
            LoadVersions();
        }

        private void DownloadVersion_Click(object sender, RoutedEventArgs e)
        {
            ProgressCard.Visibility = Visibility.Visible;
            ProgressText.Text = "Downloading selected version...";
            DownloadProgress.IsIndeterminate = true;
            
            // Simulate download logic
            // await DownloadManager.DownloadAsync(...);
        }

        private void RepairInstall_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Repairing installation...", "Apexstrap", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Roblox");
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
        }

        private void CancelDownload_Click(object sender, RoutedEventArgs e)
        {
            ProgressCard.Visibility = Visibility.Collapsed;
        }
    }
}

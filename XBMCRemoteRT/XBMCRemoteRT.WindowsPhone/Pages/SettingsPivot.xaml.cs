﻿using XBMCRemoteRT.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XBMCRemoteRT.Helpers;
using XBMCRemoteRT.RPCWrappers;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace XBMCRemoteRT.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPivot : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public SettingsPivot()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        //Crudest but thinnest way to manage button states
        private void LoadButtonCheckedStates()
        {
            string[] buttons = ((string)SettingsHelper.GetValue("ButtonsToShow", "Home, TextInput")).Split(',');
            foreach (string button in buttons)
            {
                CheckBox chk = this.FindName(button.Trim() + "CheckBox") as CheckBox;
                if(chk != null)
                    chk.IsChecked = true;
            }
        }

        private void SaveButtonCheckedStates()
        {
            string buttons = string.Empty;
            if ((bool)OSDCheckBox.IsChecked)
                buttons = buttons + "OSD";
            if ((bool)SubtitlesCheckBox.IsChecked)
                buttons = buttons + "," + "Subtitles";
            if ((bool)InfoCheckBox.IsChecked)
                buttons = buttons + "," + "Info";
            SettingsHelper.SetValue("ButtonsToShow", buttons);
        }

        private void LoadSkipJumpState()
        {
            string forwardFunction = (string)SettingsHelper.GetValue("ForwardButtonCommand", "SmallForward");
            switch (forwardFunction)
            {
                case "IncreaseSpeed":
                    ForwardComboBox.SelectedIndex = 0;
                    break;
                case "SmallForward":
                    ForwardComboBox.SelectedIndex = 1;
                    break;
                case "BigForward":
                    ForwardComboBox.SelectedIndex = 2;
                    break;                    
            }

            string backwardFunction = (string)SettingsHelper.GetValue("BackwardButtonCommand", "SmallBackward");
            switch (backwardFunction)
            {
                case "DecreaseSpeed":
                    BackwardComboBox.SelectedIndex = 0;
                    break;
                case "SmallBackward":
                    BackwardComboBox.SelectedIndex = 1;
                    break;
                case "BigBackward":
                    BackwardComboBox.SelectedIndex = 2;
                    break;
            }
        }

        private void SaveSkipJumpState()
        {
            string forwardValue = "SmallForward";
            switch (ForwardComboBox.SelectedIndex)
            {
                case 0:
                    forwardValue = "IncreaseSpeed";
                    break;
                case 1:
                    forwardValue = "SmallForward";
                    break;
                case 2:
                    forwardValue = "BigForward";
                    break;
            }

            SettingsHelper.SetValue("ForwardButtonCommand", forwardValue);

            string backwardValue = "SmallBackward";
            switch (BackwardComboBox.SelectedIndex)
            {
                case 0:
                    backwardValue = "DecreaseSpeed";
                    break;
                case 1:
                    backwardValue = "SmallBackward";
                    break;
                case 2:
                    backwardValue = "BigBackward";
                    break;
            }

            SettingsHelper.SetValue("BackwardButtonCommand", backwardValue);
        }

        private void LoadAutoConnectState()
        {
            bool autoConnect = (bool)SettingsHelper.GetValue("AutoConnect", true);
            AutoconnectToggle.IsOn = autoConnect;
        }

        private void SaveAutoConnectState()
        {
            SettingsHelper.SetValue("AutoConnect", AutoconnectToggle.IsOn);
        }

        private void LoadAutoRedirectStates()
        {
            bool audioAutoRedirect = AutoRedirectStateToBool((string)SettingsHelper.GetValue("AudioAutoRedirect", "No"));
            AudioSearchToggle.IsOn = audioAutoRedirect;
        }

        private void SaveAutoRedirectStates()
        {
            SettingsHelper.SetValue("AudioAutoRedirect", BoolToAutoRedirectState(AudioSearchToggle.IsOn));
        }

        private void LoadVibrateState()
        {
            bool vibrate = (bool)SettingsHelper.GetValue("Vibrate", true);
            VibrationToggle.IsOn = vibrate;
        }

        private void SaveVibrateState()
        {
            SettingsHelper.SetValue("Vibrate", VibrationToggle.IsOn);
        }

        private bool AutoRedirectStateToBool(string state)
        {
            switch (state)
            {
                case "Yes":
                    return true;
                default:
                    return false;
            }
        }

        private string BoolToAutoRedirectState(bool flag)
        {
            return flag ? "Yes" : "No";
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
            LoadButtonCheckedStates();
            LoadSkipJumpState();
            LoadAutoConnectState();
            LoadAutoRedirectStates();
            LoadVibrateState();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
            SaveButtonCheckedStates();
            SaveSkipJumpState();
            SaveAutoConnectState();
            SaveAutoRedirectStates();
            SaveVibrateState();
        }

        #endregion
              

    }
}

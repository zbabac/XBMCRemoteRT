﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.Windows\Pages\InputPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "52900E2F008B6723E6B7DAE0EAF56DB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XBMCRemoteRT.Pages
{
    partial class InputPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 234 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.VolumeSlider_Loaded;
                 #line default
                 #line hidden
                #line 234 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.RangeBase)(target)).ValueChanged += this.VolumeSlider_ValueChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 197 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PreviousButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 202 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SpeedDownButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 207 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PlayPauseButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 216 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.StopButton_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 221 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SpeedUpButton_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 226 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.NextButton_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 144 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.UpButton_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 149 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RightButton_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 154 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DownButton_Click;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 159 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.LeftButton_Click;
                 #line default
                 #line hidden
                break;
            case 12:
                #line 164 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EnterButton_Click;
                 #line default
                 #line hidden
                break;
            case 13:
                #line 166 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBackButton_Click;
                 #line default
                 #line hidden
                break;
            case 14:
                #line 171 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.OSDButton_Click;
                 #line default
                 #line hidden
                break;
            case 15:
                #line 176 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.MenuButton_Click;
                 #line default
                 #line hidden
                break;
            case 16:
                #line 181 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.HomeButton_Click;
                 #line default
                 #line hidden
                break;
            case 17:
                #line 139 "..\..\Pages\InputPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.SendTextBox_KeyUp;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.WindowsPhone\Pages\Video\SearchMoviesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C85EDABC330A29889B8AE712F47F713"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XBMCRemoteRT.Pages.Video
{
    partial class SearchMoviesPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\Pages\Video\SearchMoviesPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.MovieWrapper_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 27 "..\..\..\Pages\Video\SearchMoviesPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.SearchMoviesTextBox_KeyUp;
                 #line default
                 #line hidden
                #line 27 "..\..\..\Pages\Video\SearchMoviesPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.SearchMoviesTextBox_Loaded;
                 #line default
                 #line hidden
                #line 27 "..\..\..\Pages\Video\SearchMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.SearchMoviesTextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



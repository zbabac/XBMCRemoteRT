﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.Windows\Pages\Video\SearchTVShowsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E78E07A122CAA64DA0BC6D3CEFAA56BB"
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
    partial class SearchTVShowsPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 48 "..\..\..\Pages\Video\SearchTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.SearchTVShowsTextBox_KeyUp;
                 #line default
                 #line hidden
                #line 48 "..\..\..\Pages\Video\SearchTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.SearchTVShowsTextBox_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 54 "..\..\..\Pages\Video\SearchTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.TVShowWrapper_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


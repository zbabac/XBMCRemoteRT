﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2015\Projects\KodiAssist_moj\XBMCRemoteRT\XBMCRemoteRT.WindowsPhone\Pages\Video\AllTVShowsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A982BE260A08DF9150D73CE01B33EFA"
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
    partial class AllTVShowsPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\Pages\Video\AllTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.TVShowWrapper_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 64 "..\..\..\Pages\Video\AllTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RefreshTVShowsAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 65 "..\..\..\Pages\Video\AllTVShowsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SearchTVShowsAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist_moj\XBMCRemoteRT\XBMCRemoteRT.WindowsPhone\Pages\Video\TVShowDetailsHub.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C3EB1ED3694AC15289CE1A4B6BFB8BB"
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
    partial class TVShowDetailsHub : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 99 "..\..\..\..\Pages\Video\TVShowDetailsHub.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.EpisodeWrapper_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 121 "..\..\..\..\Pages\Video\TVShowDetailsHub.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PinUnpinAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


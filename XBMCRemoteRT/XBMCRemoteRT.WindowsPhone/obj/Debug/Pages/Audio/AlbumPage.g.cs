﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.WindowsPhone\Pages\Audio\AlbumPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4211C9EDF8ED3365C096F49CFE48B89C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XBMCRemoteRT.Pages.Audio
{
    partial class AlbumPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 68 "..\..\..\Pages\Audio\AlbumPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SongItemWrapper_Tapped;
                 #line default
                 #line hidden
                #line 68 "..\..\..\Pages\Audio\AlbumPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.SongItemWrapper_Holding;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 71 "..\..\..\Pages\Audio\AlbumPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.QueueSongMFI_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 90 "..\..\..\Pages\Audio\AlbumPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PlayAlbumButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 93 "..\..\..\Pages\Audio\AlbumPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.QueueAlbumAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



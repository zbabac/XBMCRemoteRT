﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.Windows\Pages\Video\AllMoviesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "762D83CDCE09395F7FEBA715DA558BF8"
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
    partial class AllMoviesPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 102 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.GridView_MovieItemClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 84 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.GridView_MovieItemClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 66 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.GridView_MovieItemClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 51 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.FilterComboBox_OnSelectionChanged;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 121 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RefreshMoviesAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 122 "..\..\..\Pages\Video\AllMoviesPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SeachMoviesAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



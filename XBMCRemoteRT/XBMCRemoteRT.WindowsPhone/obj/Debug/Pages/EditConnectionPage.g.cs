﻿

#pragma checksum "C:\Users\ba100065\Documents\Visual Studio 2013\Projects\KodiAssist\XBMCRemoteRT\XBMCRemoteRT.WindowsPhone\Pages\EditConnectionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D1E7D4EA95AB88A037B43C082C683A77"
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
    partial class EditConnectionPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 50 "..\..\Pages\EditConnectionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveConnectionAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 51 "..\..\Pages\EditConnectionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CancelAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



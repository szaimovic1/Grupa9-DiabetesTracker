﻿#pragma checksum "C:\Users\cico\Pictures\Grupa9-DiabetesTracker\Projekat\DiabetesTracker\View\Prijava.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A8FC2398A27707511C03D348D1C81F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiabetesTracker
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.panel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.UsernameIPasswordKontrola = (global::DiabetesTracker.UsernameIPasswordUserControl)(target);
                }
                break;
            case 6:
                {
                    this.dugmadi = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.registerButtonHyperlink = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 60 "..\..\..\View\Prijava.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.registerButtonHyperlink).Click += this.registerButtonHyperlink_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.prijava = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\View\Prijava.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.prijava).Click += this.Prijava_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


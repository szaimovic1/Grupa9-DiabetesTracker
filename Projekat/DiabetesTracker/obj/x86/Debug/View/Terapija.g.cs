﻿#pragma checksum "C:\Users\cico\Documents\Grupa9-DiabetesTracker\Projekat\DiabetesTracker\View\Terapija.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF3FAF1C8E407472D6A033F75C8B6905"
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
    partial class Terapija : 
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
                    this.Drugi = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 62 "..\..\..\View\Terapija.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).SelectionChanged += this.TextBlock_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    global::DiabetesTracker.TerapijaKontrola element6 = (global::DiabetesTracker.TerapijaKontrola)(target);
                    #line 66 "..\..\..\View\Terapija.xaml"
                    ((global::DiabetesTracker.TerapijaKontrola)element6).Loaded += this.TerapijaKontrola_Loaded;
                    #line default
                }
                break;
            case 7:
                {
                    this.DozaLijeka = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.Dalje1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 69 "..\..\..\View\Terapija.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Dalje1).Click += this.Dalje1_Click_1;
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


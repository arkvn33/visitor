﻿#pragma checksum "..\..\..\Windows\WinLicense.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7259F98C8135D4BBDC7A4571C0B374405B83F3A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Visitor.Windows {
    
    
    /// <summary>
    /// WinLicense
    /// </summary>
    public partial class WinLicense : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTitle;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimize;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSerialNum;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtLicensekey;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\WinLicense.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegistration;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Visitor;component/windows/winlicense.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WinLicense.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\Windows\WinLicense.xaml"
            ((Visitor.Windows.WinLicense)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\Windows\WinLicense.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LblTitle = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\..\Windows\WinLicense.xaml"
            this.LblTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragMove);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Windows\WinLicense.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Windows\WinLicense.xaml"
            this.BtnMinimize.Click += new System.Windows.RoutedEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtSerialNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxtLicensekey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnRegistration = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Windows\WinLicense.xaml"
            this.BtnRegistration.Click += new System.Windows.RoutedEventHandler(this.BtnRegistration_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


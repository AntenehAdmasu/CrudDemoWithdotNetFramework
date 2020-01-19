﻿#pragma checksum "..\..\..\Pages\Closet.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A1EF25335A8DA6918059C7750DA6D609BFECE36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EnkuDesigns;
using EnkuDesigns.Pages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EnkuDesigns.Pages {
    
    
    /// <summary>
    /// Closet
    /// </summary>
    public partial class Closet : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image dresspicture;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dresscode;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Amount;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImageLocationTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filechoose;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\Closet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Thelistbox;
        
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
            System.Uri resourceLocater = new System.Uri("/EnkuDesigns;component/pages/closet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Closet.xaml"
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
            this.dresspicture = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.dresscode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ImageLocationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.filechoose = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Pages\Closet.xaml"
            this.filechoose.Click += new System.Windows.RoutedEventHandler(this.FileChooserClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 92 "..\..\..\Pages\Closet.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddDressButtonClicked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Thelistbox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


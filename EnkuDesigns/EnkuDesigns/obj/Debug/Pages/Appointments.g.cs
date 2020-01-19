﻿#pragma checksum "..\..\..\Pages\Appointments.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018D41C20FB1BE4BFA2303F52DB41FA47D2700D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// Appointments
    /// </summary>
    public partial class Appointments : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customername;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerphone;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox appointmentdressid;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox appointmentprice;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox appointmentpaidamount;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker appointmentdate;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker AppointmentDateSelector;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AppointmentsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\Pages\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Snackbar TableUpdateSnackbar;
        
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
            System.Uri resourceLocater = new System.Uri("/EnkuDesigns;component/pages/appointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Appointments.xaml"
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
            this.customername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.customerphone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.appointmentdressid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.appointmentprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.appointmentpaidamount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.appointmentdate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            
            #line 79 "..\..\..\Pages\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AppointButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AppointmentDateSelector = ((System.Windows.Controls.DatePicker)(target));
            
            #line 94 "..\..\..\Pages\Appointments.xaml"
            this.AppointmentDateSelector.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ChangeMainTable);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 103 "..\..\..\Pages\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AppointmentsExport);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 117 "..\..\..\Pages\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshPage);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 131 "..\..\..\Pages\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveChanges);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 145 "..\..\..\Pages\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DressDelivered);
            
            #line default
            #line hidden
            return;
            case 13:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 159 "..\..\..\Pages\Appointments.xaml"
            this.searchTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.searchAppointment);
            
            #line default
            #line hidden
            return;
            case 14:
            this.AppointmentsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 15:
            this.TableUpdateSnackbar = ((MaterialDesignThemes.Wpf.Snackbar)(target));
            return;
            case 16:
            
            #line 223 "..\..\..\Pages\Appointments.xaml"
            ((MaterialDesignThemes.Wpf.SnackbarMessage)(target)).ActionClick += new System.Windows.RoutedEventHandler(this.HideScakBars);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


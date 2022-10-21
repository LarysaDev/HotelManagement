﻿#pragma checksum "..\..\..\..\Reservation\ReservationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F0F74BA27E713200AD11FD56CF5708235B1D8DBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelManagement.Reservation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HotelManagement.Reservation {
    
    
    /// <summary>
    /// ReservationWindow
    /// </summary>
    public partial class ReservationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider stars;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listOfRooms;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxSt;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxLx;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findRooms;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label priceTitle;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceFrom;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceTo;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateFrom;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Reservation\ReservationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateTo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HotelManagement;component/reservation/reservationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Reservation\ReservationWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.open_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.saveAs_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_paste_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.stars = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.listOfRooms = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.cm = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 9:
            
            #line 54 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_open_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 55 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_save_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 56 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_saveAs_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.checkboxSt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\..\..\Reservation\ReservationWindow.xaml"
            this.checkboxSt.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.checkboxLx = ((System.Windows.Controls.CheckBox)(target));
            
            #line 73 "..\..\..\..\Reservation\ReservationWindow.xaml"
            this.checkboxLx.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_2);
            
            #line default
            #line hidden
            return;
            case 14:
            this.findRooms = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Reservation\ReservationWindow.xaml"
            this.findRooms.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 76 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 77 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 17:
            this.priceTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.priceFrom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.priceTo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.dateFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 21:
            this.dateTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 22:
            
            #line 84 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 95 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 107 "..\..\..\..\Reservation\ReservationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addNumber);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


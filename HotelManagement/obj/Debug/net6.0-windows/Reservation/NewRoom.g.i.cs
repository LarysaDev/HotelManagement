﻿#pragma checksum "..\..\..\..\Reservation\NewRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A8DE789474FDC4B5ECA403138AE2BB97732D52A4"
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
    /// NewRoom
    /// </summary>
    public partial class NewRoom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameField;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox windowsAmount;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox roomsAmount;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bedsAmount;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton addToExisting;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton addToNew;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox square_;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Reservation\NewRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price_;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelManagement;component/reservation/newroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Reservation\NewRoom.xaml"
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
            this.nameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.windowsAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.roomsAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bedsAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.submitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Reservation\NewRoom.xaml"
            this.submitBtn.Click += new System.Windows.RoutedEventHandler(this.submitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addToExisting = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.addToNew = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.square_ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.price_ = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


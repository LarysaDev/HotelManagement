﻿#pragma checksum "..\..\..\..\Customers\CustomersInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F6F9FC35FB482E89BDD52A7DF5DBAD0FE1A2E1B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelManagement.Customers;
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


namespace HotelManagement.Customers {
    
    
    /// <summary>
    /// CustomersInfo
    /// </summary>
    public partial class CustomersInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\Customers\CustomersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox customerOption;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Customers\CustomersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listOfCustomers;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Customers\CustomersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Customers\CustomersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button apply;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelManagement;component/customers/customersinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Customers\CustomersInfo.xaml"
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
            
            #line 17 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_exit);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 35 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_12);
            
            #line default
            #line hidden
            return;
            case 6:
            this.customerOption = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.listOfCustomers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.cm = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 9:
            
            #line 47 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_open_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 48 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_save_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 49 "..\..\..\..\Customers\CustomersInfo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.cm_saveAs_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.apply = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Customers\CustomersInfo.xaml"
            this.apply.Click += new System.Windows.RoutedEventHandler(this.Button1_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


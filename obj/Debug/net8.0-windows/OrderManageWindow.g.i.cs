﻿#pragma checksum "..\..\..\OrderManageWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68018EE3EA66F0B2F2D2522567C682A2A5B02471"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SellManager;
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


namespace SellManager {
    
    
    /// <summary>
    /// OrderManageWindow
    /// </summary>
    public partial class OrderManageWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboThanhpho;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboKhachhang;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSlKhachhang;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgData;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgData2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSlHoadon;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\OrderManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSlMathang;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SellManager;component/ordermanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderManageWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cboThanhpho = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\OrderManageWindow.xaml"
            this.cboThanhpho.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboThanhpho_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboKhachhang = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\OrderManageWindow.xaml"
            this.cboKhachhang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboKhachhang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSlKhachhang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DgData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\OrderManageWindow.xaml"
            this.DgData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DgData2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\OrderManageWindow.xaml"
            this.DgData2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtSlHoadon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtSlMathang = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


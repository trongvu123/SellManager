﻿#pragma checksum "..\..\..\CustomerManagerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911D6E0C51A3BCF6A591DD0CEFB7B06FFB447978"
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
    /// CustomerManagerWindow
    /// </summary>
    public partial class CustomerManagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMakh;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboThanhpho;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKhachhang;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDienthoai;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiachi;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgData;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\CustomerManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn colCity;
        
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
            System.Uri resourceLocater = new System.Uri("/SellManager;component/customermanagerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomerManagerWindow.xaml"
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
            this.txtMakh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cboThanhpho = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\CustomerManagerWindow.xaml"
            this.cboThanhpho.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboThanhpho_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtKhachhang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDienthoai = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDiachi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DgData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\..\CustomerManagerWindow.xaml"
            this.DgData.Loaded += new System.Windows.RoutedEventHandler(this.DgData_Loaded);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\CustomerManagerWindow.xaml"
            this.DgData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.colCity = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 8:
            
            #line 68 "..\..\..\CustomerManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 69 "..\..\..\CustomerManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\..\CustomerManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 72 "..\..\..\CustomerManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\CreateOrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F37B8B0536FB238909430775D6A6A4274F6AD77"
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
    /// CreateOrderWindow
    /// </summary>
    public partial class CreateOrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\CreateOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbokhachang;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\CreateOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMahd;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CreateOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgData;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CreateOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn colSanpham;
        
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
            System.Uri resourceLocater = new System.Uri("/SellManager;component/createorderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateOrderWindow.xaml"
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
            this.cbokhachang = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\CreateOrderWindow.xaml"
            this.cbokhachang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbokhachang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtMahd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DgData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\CreateOrderWindow.xaml"
            this.DgData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgData_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\CreateOrderWindow.xaml"
            this.DgData.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.DgData_CellEditEnding);
            
            #line default
            #line hidden
            return;
            case 4:
            this.colSanpham = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 5:
            
            #line 43 "..\..\..\CreateOrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

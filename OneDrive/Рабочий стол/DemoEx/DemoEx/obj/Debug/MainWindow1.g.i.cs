﻿#pragma checksum "..\..\MainWindow1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "369801AE7DE7006197506B063C3A860038F64E68DF5025149818BA6DD7DEF6D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoEx;
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


namespace DemoEx {
    
    
    /// <summary>
    /// MainWindow1
    /// </summary>
    public partial class MainWindow1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textCurrent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textAll;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxFilterProductDiscountAmount;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxFilterProductByPrice;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvProducts;
        
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
            System.Uri resourceLocater = new System.Uri("/DemoEx;component/mainwindow1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow1.xaml"
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
            this.textCurrent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textAll = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ComboBoxFilterProductDiscountAmount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\MainWindow1.xaml"
            this.ComboBoxFilterProductDiscountAmount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxFilterProductDiscountAmount_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBoxFilterProductByPrice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\MainWindow1.xaml"
            this.ComboBoxFilterProductByPrice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxFilterProductByPrice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\MainWindow1.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvProducts = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


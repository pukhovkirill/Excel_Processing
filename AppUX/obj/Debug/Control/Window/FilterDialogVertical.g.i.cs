﻿#pragma checksum "..\..\..\..\Control\Window\FilterDialogVertical.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96FA364C15E71797B3661A48FF00C334C67E62F3D4C98B4A41BECFCEA58F5380"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AppUX.Control.Window;
using ScottPlot;
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


namespace AppUX.Control.Window {
    
    
    /// <summary>
    /// FilterDialogVertical
    /// </summary>
    public partial class FilterDialogVertical : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AppUX.Control.Window.FilterDialogVertical Root;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid content;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SorterComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ExcelFile;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton WordFile;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filterBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button apply;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/AppUX;component/control/window/filterdialogvertical.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
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
            this.Root = ((AppUX.Control.Window.FilterDialogVertical)(target));
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.content = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.SorterComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ExcelFile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.WordFile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.filterBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.apply = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
            this.apply.Click += new System.Windows.RoutedEventHandler(this.apply_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Control\Window\FilterDialogVertical.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


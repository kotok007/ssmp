﻿#pragma checksum "..\..\..\Otkazi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCF43AA94293591D7AF55067699B4EB768620CE1964F8E13BF2944D707F17B6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MISBolnica;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
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


namespace MISBolnica {
    
    
    /// <summary>
    /// Otkazi
    /// </summary>
    public partial class Otkazi : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock currentTextHeader;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrint;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPacient;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textFind;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFind;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFindCancel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEditPacient;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShoPacient;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Otkazi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrintEpikriz;
        
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
            System.Uri resourceLocater = new System.Uri("/MISBolnica;component/otkazi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Otkazi.xaml"
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
            
            #line 14 "..\..\..\Otkazi.xaml"
            ((MISBolnica.Otkazi)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.currentTextHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.buttonPrint = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Otkazi.xaml"
            this.buttonPrint.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridPacient = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.textFind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.buttonFind = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Otkazi.xaml"
            this.buttonFind.Click += new System.Windows.RoutedEventHandler(this.ButtonFind_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonFindCancel = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Otkazi.xaml"
            this.buttonFindCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonFindCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonEditPacient = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Otkazi.xaml"
            this.buttonEditPacient.Click += new System.Windows.RoutedEventHandler(this.ButtonEditPacient_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Otkazi.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonShoPacient = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Otkazi.xaml"
            this.buttonShoPacient.Click += new System.Windows.RoutedEventHandler(this.ButtonShoPacient_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonPrintEpikriz = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Otkazi.xaml"
            this.buttonPrintEpikriz.Click += new System.Windows.RoutedEventHandler(this.ButtonPrintEpikriz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


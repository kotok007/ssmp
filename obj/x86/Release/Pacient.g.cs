﻿#pragma checksum "..\..\..\Pacient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2051ED23968F14A7EAD07242FB8C11AE7600C6951AACD4BE24605BF03CDF80CF"
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
    /// Pacient
    /// </summary>
    public partial class Pacient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock currentTextHeader;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrint;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPacient;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textFind;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFind;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFindCancel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddPacient;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEditPacient;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShoPacient;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonVipisat;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOtkaz;
        
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
            System.Uri resourceLocater = new System.Uri("/MISBolnica;component/pacient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pacient.xaml"
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
            
            #line 14 "..\..\..\Pacient.xaml"
            ((MISBolnica.Pacient)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.currentTextHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.buttonPrint = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pacient.xaml"
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
            
            #line 37 "..\..\..\Pacient.xaml"
            this.buttonFind.Click += new System.Windows.RoutedEventHandler(this.ButtonFind_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonFindCancel = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pacient.xaml"
            this.buttonFindCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonFindCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonAddPacient = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pacient.xaml"
            this.buttonAddPacient.Click += new System.Windows.RoutedEventHandler(this.ButtonAddPacient_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonEditPacient = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pacient.xaml"
            this.buttonEditPacient.Click += new System.Windows.RoutedEventHandler(this.ButtonEditPacient_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pacient.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonShoPacient = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Pacient.xaml"
            this.buttonShoPacient.Click += new System.Windows.RoutedEventHandler(this.ButtonShoPacient_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonVipisat = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pacient.xaml"
            this.buttonVipisat.Click += new System.Windows.RoutedEventHandler(this.ButtonVipisat_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.buttonOtkaz = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Pacient.xaml"
            this.buttonOtkaz.Click += new System.Windows.RoutedEventHandler(this.ButtonOtkaz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


#pragma checksum "..\..\Mkb - Копировать.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1889761A5847D8AB39D7893002A9568DB2AA724E88744DC06EDAF2FCFA522CAA"
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
    /// Mkb
    /// </summary>
    public partial class Mkb : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridMkb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textFind;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFind;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFindCancel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textKodMkb;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNazvanie;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Mkb - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MISBolnica;component/mkb%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be%d0%b2%d0%b0%" +
                    "d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mkb - Копировать.xaml"
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
            
            #line 14 "..\..\Mkb - Копировать.xaml"
            ((MISBolnica.Mkb)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridMkb = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.textFind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttonFind = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Mkb - Копировать.xaml"
            this.buttonFind.Click += new System.Windows.RoutedEventHandler(this.ButtonFind_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonFindCancel = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Mkb - Копировать.xaml"
            this.buttonFindCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonFindCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textKodMkb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textNazvanie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Mkb - Копировать.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Mkb - Копировать.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Views\Requests.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC56AF7D3C09D5381321F032C44D36D9EE9479639591B9E5AAF5639AA254F48C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AbdullinaPZ.Views;
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


namespace AbdullinaPZ.Views {
    
    
    /// <summary>
    /// Requests
    /// </summary>
    public partial class Requests : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserPage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserTypePage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TechTypePage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddReq;
        
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
            System.Uri resourceLocater = new System.Uri("/AbdullinaPZ;component/views/requests.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Requests.xaml"
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
            this.UserPage = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.UserTypePage = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.TechTypePage = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.List = ((System.Windows.Controls.ListBox)(target));
            
            #line 34 "..\..\..\Views\Requests.xaml"
            this.List.KeyDown += new System.Windows.Input.KeyEventHandler(this.list_KeyDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Views\Requests.xaml"
            this.List.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.list_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddReq = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Views\Requests.xaml"
            this.AddReq.Click += new System.Windows.RoutedEventHandler(this.AddReq_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

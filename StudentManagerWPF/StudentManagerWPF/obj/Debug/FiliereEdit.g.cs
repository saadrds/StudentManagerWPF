﻿#pragma checksum "..\..\FiliereEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B5448B23C4BF75BA4B336FC8CB8ED9544B3A91084EE4E22F1D583DECF68976D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StudentManagerWPF;
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


namespace StudentManagerWPF {
    
    
    /// <summary>
    /// FiliereEdit
    /// </summary>
    public partial class FiliereEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FilId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextId;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextRespo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modifier;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button supprimer;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\FiliereEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ajouter;
        
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
            System.Uri resourceLocater = new System.Uri("/StudentManagerWPF;component/filiereedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FiliereEdit.xaml"
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
            
            #line 15 "..\..\FiliereEdit.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TextId = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TextName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextRespo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.modifier = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\FiliereEdit.xaml"
            this.modifier.Click += new System.Windows.RoutedEventHandler(this.Modifier);
            
            #line default
            #line hidden
            return;
            case 7:
            this.supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\FiliereEdit.xaml"
            this.supprimer.Click += new System.Windows.RoutedEventHandler(this.Supprimer);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\FiliereEdit.xaml"
            this.ajouter.Click += new System.Windows.RoutedEventHandler(this.Ajouter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


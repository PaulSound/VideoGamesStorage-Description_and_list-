﻿#pragma checksum "..\..\..\..\View\UpdateForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305975227369E7FE5F0770798A565E383991A845"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using VideoGamesStorage_Description_and_list_.View;


namespace VideoGamesStorage_Description_and_list_.View {
    
    
    /// <summary>
    /// UpdateForm
    /// </summary>
    public partial class UpdateForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _tbName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cbLimits;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cbPlatforms;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cbGenre;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _tbЗPrice;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _tbDescription;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _searchButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _saveButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\UpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _closeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VideoGamesStorage(Description_and_list);component/view/updateform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UpdateForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this._cbLimits = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\..\View\UpdateForm.xaml"
            this._cbLimits.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._cbLimits_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this._cbPlatforms = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\View\UpdateForm.xaml"
            this._cbPlatforms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._cbPlatforms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this._cbGenre = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\View\UpdateForm.xaml"
            this._cbGenre.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._cbGenre_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this._tbЗPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._tbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this._searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\View\UpdateForm.xaml"
            this._searchButton.Click += new System.Windows.RoutedEventHandler(this.SearchGame);
            
            #line default
            #line hidden
            return;
            case 8:
            this._saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\View\UpdateForm.xaml"
            this._saveButton.Click += new System.Windows.RoutedEventHandler(this.UpdateData);
            
            #line default
            #line hidden
            return;
            case 9:
            this._closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\View\UpdateForm.xaml"
            this._closeButton.Click += new System.Windows.RoutedEventHandler(this.CloseForm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


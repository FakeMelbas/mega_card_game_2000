﻿#pragma checksum "..\..\Battle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35DC89D6BCD2EB9DF6FF34BEB9E5041E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mega_card_game_2000;
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


namespace Mega_card_game_2000 {
    
    
    /// <summary>
    /// Battle
    /// </summary>
    public partial class Battle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BattleNames;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock playerHP;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock playerDMG;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button normalAttack;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock enemyHP;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock enemyDMG;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button specialAttack;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BattleLogLabel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Battle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox BattleLog;
        
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
            System.Uri resourceLocater = new System.Uri("/Mega card game 2000;component/battle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Battle.xaml"
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
            this.BattleNames = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.playerHP = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.playerDMG = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.normalAttack = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Battle.xaml"
            this.normalAttack.Click += new System.Windows.RoutedEventHandler(this.normalAttack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.enemyHP = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.enemyDMG = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.specialAttack = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Battle.xaml"
            this.specialAttack.Click += new System.Windows.RoutedEventHandler(this.specialAttack_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BattleLogLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.BattleLog = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


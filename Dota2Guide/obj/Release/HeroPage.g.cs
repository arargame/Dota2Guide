﻿#pragma checksum "C:\Users\koray\Documents\Visual Studio 2010\Projects\Dota2Guide\Dota2Guide\HeroPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1E0AF5616F95C302428B9863DF372B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Dota2Guide {
    
    
    public partial class HeroPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ScrollViewer scrollViewer1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Image heroImg;
        
        internal System.Windows.Controls.TextBlock roleTextBlock;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image IntelligenceImage;
        
        internal System.Windows.Controls.TextBlock IntelligenceTextBlock;
        
        internal System.Windows.Controls.Image DamageImage;
        
        internal System.Windows.Controls.TextBlock DamageTextBlock;
        
        internal System.Windows.Controls.Image AgilityImage;
        
        internal System.Windows.Controls.TextBlock AgilityTextBlock;
        
        internal System.Windows.Controls.Image MoveSpeedImage;
        
        internal System.Windows.Controls.TextBlock MoveSpeedTextBlock;
        
        internal System.Windows.Controls.Image StrengthImage;
        
        internal System.Windows.Controls.TextBlock StrengthTextBlock;
        
        internal System.Windows.Controls.Image ArmorImage;
        
        internal System.Windows.Controls.TextBlock ArmorTextBlock;
        
        internal System.Windows.Controls.TextBlock bioTextBlock;
        
        internal System.Windows.Controls.ListBox skillListBox;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl adControl1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Dota2Guide;component/HeroPage.xaml", System.UriKind.Relative));
            this.scrollViewer1 = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.heroImg = ((System.Windows.Controls.Image)(this.FindName("heroImg")));
            this.roleTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("roleTextBlock")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.IntelligenceImage = ((System.Windows.Controls.Image)(this.FindName("IntelligenceImage")));
            this.IntelligenceTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("IntelligenceTextBlock")));
            this.DamageImage = ((System.Windows.Controls.Image)(this.FindName("DamageImage")));
            this.DamageTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("DamageTextBlock")));
            this.AgilityImage = ((System.Windows.Controls.Image)(this.FindName("AgilityImage")));
            this.AgilityTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("AgilityTextBlock")));
            this.MoveSpeedImage = ((System.Windows.Controls.Image)(this.FindName("MoveSpeedImage")));
            this.MoveSpeedTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("MoveSpeedTextBlock")));
            this.StrengthImage = ((System.Windows.Controls.Image)(this.FindName("StrengthImage")));
            this.StrengthTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("StrengthTextBlock")));
            this.ArmorImage = ((System.Windows.Controls.Image)(this.FindName("ArmorImage")));
            this.ArmorTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("ArmorTextBlock")));
            this.bioTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("bioTextBlock")));
            this.skillListBox = ((System.Windows.Controls.ListBox)(this.FindName("skillListBox")));
            this.adControl1 = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("adControl1")));
        }
    }
}


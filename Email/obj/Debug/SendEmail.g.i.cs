﻿#pragma checksum "..\..\SendEmail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81C71A0F46577DFDE5A1F2DEFD39E232A340DCA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Email;
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


namespace Email {
    
    
    /// <summary>
    /// SendEmail
    /// </summary>
    public partial class SendEmail : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock error;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recipient;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox copy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox subject;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox body;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAttachments;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sendImm;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sendLater;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendEmail;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbAttachments;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button play;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pause;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\SendEmail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
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
            System.Uri resourceLocater = new System.Uri("/Email;component/sendemail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SendEmail.xaml"
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
            this.error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.recipient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.subject = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.body = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 6:
            this.addAttachments = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\SendEmail.xaml"
            this.addAttachments.Click += new System.Windows.RoutedEventHandler(this.addAttachments_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sendImm = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.sendLater = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.sendEmail = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\SendEmail.xaml"
            this.sendEmail.Click += new System.Windows.RoutedEventHandler(this.sendEmail_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 40 "..\..\SendEmail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lbAttachments = ((System.Windows.Controls.ListBox)(target));
            return;
            case 13:
            this.media = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 14:
            this.play = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\SendEmail.xaml"
            this.play.Click += new System.Windows.RoutedEventHandler(this.play_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.pause = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\SendEmail.xaml"
            this.pause.Click += new System.Windows.RoutedEventHandler(this.pause_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.slider = ((System.Windows.Controls.Slider)(target));
            
            #line 67 "..\..\SendEmail.xaml"
            this.slider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.sliProgress_DragStarted));
            
            #line default
            #line hidden
            
            #line 67 "..\..\SendEmail.xaml"
            this.slider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.sliProgress_DragCompleted));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 12:
            
            #line 46 "..\..\SendEmail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.attachmentSelected);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


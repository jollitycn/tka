﻿#pragma checksum "..\..\..\..\View\VideoZoomInWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3BCC9E612550644F91B81FB065AD737FD527700A760FA649D694721D04ED72CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
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
using TKA.View;


namespace TKA.View {
    
    
    /// <summary>
    /// VideoZoomInWindow
    /// </summary>
    public partial class VideoZoomInWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1009 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Maximize;
        
        #line default
        #line hidden
        
        
        #line 1042 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Control ZoomInVideo;
        
        #line default
        #line hidden
        
        
        #line 1070 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Up;
        
        #line default
        #line hidden
        
        
        #line 1076 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Left;
        
        #line default
        #line hidden
        
        
        #line 1086 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Right;
        
        #line default
        #line hidden
        
        
        #line 1094 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Down;
        
        #line default
        #line hidden
        
        
        #line 1110 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZoomIn;
        
        #line default
        #line hidden
        
        
        #line 1117 "..\..\..\..\View\VideoZoomInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZoomOut;
        
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
            System.Uri resourceLocater = new System.Uri("/TKA;component/view/videozoominwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\VideoZoomInWindow.xaml"
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
            this.Maximize = ((System.Windows.Controls.Button)(target));
            
            #line 1010 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Maximize.Click += new System.Windows.RoutedEventHandler(this.Maximize_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 1023 "..\..\..\..\View\VideoZoomInWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ZoomInVideo = ((System.Windows.Forms.Control)(target));
            return;
            case 4:
            this.Up = ((System.Windows.Controls.Button)(target));
            
            #line 1071 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Up.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1072 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Up.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Left = ((System.Windows.Controls.Button)(target));
            
            #line 1077 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Left.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1078 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Left.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Right = ((System.Windows.Controls.Button)(target));
            
            #line 1087 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Right.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1088 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Right.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Down = ((System.Windows.Controls.Button)(target));
            
            #line 1095 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Down.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1096 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.Down.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ZoomIn = ((System.Windows.Controls.Button)(target));
            
            #line 1113 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.ZoomIn.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1114 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.ZoomIn.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ZoomOut = ((System.Windows.Controls.Button)(target));
            
            #line 1121 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.ZoomOut.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Start_Move);
            
            #line default
            #line hidden
            
            #line 1122 "..\..\..\..\View\VideoZoomInWindow.xaml"
            this.ZoomOut.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Camera_Stop_Move);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp10.Platforms.Windows.Renderers
{
    public class CustomPlatformWebviewRenderer
    {
        public void InitRendering(CustomBlazorWebview objWebview)
        {
            BlazorWebViewHandler.BlazorWebViewMapper.AppendToMapping("CustomBlazorWebviewMapper",
                (handler, view) =>
                {
                    var x = view;

                    var wv2 = handler.PlatformView as WebView2;
                    wv2.CoreWebView2Initialized += Wv2_CoreWebView2Initialized;
                    wv2.NavigationStarting += Wv2_NavigationStarting;
                    wv2.NavigationCompleted += Wv2_NavigationCompleted;

                   

                });
        }

        private void Wv2_CoreWebView2Initialized(WebView2 sender, CoreWebView2InitializedEventArgs args)
        {
            var wv2 = sender;

            wv2.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            wv2.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            wv2.CoreWebView2.Settings.AreDevToolsEnabled = false;
            wv2.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            wv2.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            wv2.CoreWebView2.Settings.IsPinchZoomEnabled = false;
            wv2.CoreWebView2.Settings.IsStatusBarEnabled = false;
            wv2.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;
            wv2.CoreWebView2.Settings.IsZoomControlEnabled = false;
        }

        private void Wv2_NavigationStarting(WebView2 sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs args)
        {
            //var wv2 = sender;

            //wv2.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            //wv2.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            //wv2.CoreWebView2.Settings.AreDevToolsEnabled = false;
            //wv2.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            //wv2.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            //wv2.CoreWebView2.Settings.IsPinchZoomEnabled = false;
            //wv2.CoreWebView2.Settings.IsStatusBarEnabled = false;
            //wv2.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;
            //wv2.CoreWebView2.Settings.IsZoomControlEnabled = false;
        }

        private void Wv2_NavigationCompleted(WebView2 sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs args)
        {
            //var wv2 = sender;

            //wv2.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            //wv2.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            //wv2.CoreWebView2.Settings.AreDevToolsEnabled = false;
            //wv2.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            //wv2.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            //wv2.CoreWebView2.Settings.IsPinchZoomEnabled = false;
            //wv2.CoreWebView2.Settings.IsStatusBarEnabled = false;
            //wv2.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;
            //wv2.CoreWebView2.Settings.IsZoomControlEnabled = false;

        }
    }
}

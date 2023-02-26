using Microsoft.AspNetCore.Components.WebView.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp10
{
    public class CustomBlazorWebview: BlazorWebView
    {
        public CustomBlazorWebview()
        {

#if WINDOWS
            var objRendering = new Platforms.Windows.Renderers.CustomPlatformWebviewRenderer();
            objRendering.InitRendering(this);

#endif

        }



    }
}

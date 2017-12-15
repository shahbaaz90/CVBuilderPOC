// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PdfRenderer.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   PdfRenderer
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Net;
using Foundation;
using PCLStorage;
using PrismTest.Controls;
using PrismTest.Services;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomPDFControl), typeof(PrismTest.iOS.Renderers.PdfRenderer))]

namespace PrismTest.iOS.Renderers
{
    public class PdfRenderer : ViewRenderer<CustomPDFControl, UIWebView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomPDFControl> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new UIWebView());
            }
            if (e.OldElement != null)
            {
                // Cleanup
            }
            if (e.NewElement != null)
            {
                var customWebView = Element as CustomPDFControl;
                //string fileName = Path.Combine(NSBundle.MainBundle.BundlePath, string.Format("folder/{0}", WebUtility.UrlEncode(customWebView.Uri)));
                string fileName = Path.Combine(FileSystem.Current.LocalStorage.Path, string.Format("{0}/{1}", PdfHelper.folderName, WebUtility.UrlEncode(customWebView.Uri)));

               // string fileName = "https://codepen.io/DeepS/pen/HJAhp.html";

               // string fileName = "https://google.com.pk";

                Control.LoadRequest(new NSUrlRequest(new NSUrl(fileName)));

              //  NSUrl.url

                //Control.LoadHtmlString("", new NSUrl(fileName));
                Control.ScalesPageToFit = true;
            }
        }
    }
}

// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SecondPageViewModel.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   SecondPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using PrismTest.Services;
using System.Net;
using Xamarin.Forms;

namespace PrismTest.ViewModels
{
    public class SecondPageViewModel : BindableBase
    {
        public SecondPageViewModel()
        {
        }

        private string pdfURI = "BookPreview2-Ch18-Rel0417.pdf";
        public string PdfURI
        {
            get => pdfURI;
            set => SetProperty(ref pdfURI, value);
        }

        private HtmlWebViewSource hTMLSource = new HtmlWebViewSource { Html = @"<html><body>
  <h1>Xamarin.Forms</h1>
  <p>Welcome to WebView.</p>
  </body></html>"};
        
        public HtmlWebViewSource HTMLSource
        {
            get { return hTMLSource; }
            set { SetProperty(ref hTMLSource, value); }
        }
    }
}

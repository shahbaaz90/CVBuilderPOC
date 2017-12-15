// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="CustomPDFControl.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   CustomPDFControl
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using Xamarin.Forms;

namespace PrismTest.Controls
{
    public class CustomPDFControl : WebView
    {
        public CustomPDFControl()
        {
        }

        //browser.Source = htmlSource;


        /// <summary>
        /// The URI property.
        /// </summary>
        public static readonly BindableProperty UriProperty =
            BindableProperty.Create(propertyName: "Uri", returnType: typeof(string), declaringType: typeof(CustomPDFControl), defaultValue: default(string));

        public static readonly BindableProperty StringSourceProperty =
            BindableProperty.Create(propertyName: "StringSource", returnType: typeof(string), declaringType: typeof(CustomPDFControl), defaultValue: default(string));




        /// <summary>
        /// The is busy property.
        /// </summary>
        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create("IsBusy", typeof(bool), typeof(CustomPDFControl), false);

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { this.SetValue(UriProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:GPK.Forms.Controls.PdfWebViewControl"/> is busy.
        /// </summary>
        /// <value><c>true</c> if is busy; otherwise, <c>false</c>.</value>
        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { this.SetValue(IsBusyProperty, value); }
        }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public string StringSource
        {
            get { return (string)GetValue(StringSourceProperty); }
            set { this.SetValue(StringSourceProperty, value); }
        }

    }
}

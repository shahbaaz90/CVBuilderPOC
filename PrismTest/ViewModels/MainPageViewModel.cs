using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using PrismTest.Services;
using System.Net;

namespace PrismTest.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        private readonly INavigationService navigationService;
        private readonly IPdfHelper pdfHelper;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string contentBox;
        public string ContentBox
        {
            get { return contentBox; }
            set { SetProperty(ref contentBox, value); }
        }

        public ICommand GoToNextPage => new DelegateCommand(HandleAction);

        public MainPageViewModel(INavigationService navigationService, IPdfHelper pdfHelper)
        {
            this.navigationService = navigationService;
            this.pdfHelper = pdfHelper;

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

       async void HandleAction()
        {
            // navigationService.NavigateAsync("SecondPage");

            // var pdfOpener = Xamarin.Forms.DependencyService.Get<IPdfOpener>();

            var PdfURI = "BookPreview2-Ch18-Rel0417.pdf";

            // await pdfHelper.PCLGenaratePdf(string.Format("Content/{0}", WebUtility.UrlEncode(PdfURI)));

            await pdfHelper.PCLGenaratePdf(PdfURI, ContentBox);

            await navigationService.NavigateAsync("SecondPage");

           // await pdfHelper.ReadPDF();
        }
    }
}


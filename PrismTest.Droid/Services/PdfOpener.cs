// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PdfOpener.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   PdfOpener
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using PrismTest.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PrismTest.Droid.Services.PdfOpener))]

namespace PrismTest.Droid.Services
{
    public class PdfOpener : IPdfOpener
    {
        public PdfOpener()
        {
        }

        public async Task Generate(string path)
        {
            var creator = new PdfHelper();
            await creator.PCLGenaratePdf(path);
        }

        public async Task ReadPDF()
        {
            string sdCardPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            string fullpath = Path.Combine(sdCardPath, "folder/" + "file.pdf");

            var creator = new PdfHelper();
            string filePath = await creator.PCLReadFile(fullpath);
            Intent intent;
            using (Android.Net.Uri pdfPath = Android.Net.Uri.FromFile(new Java.IO.File(filePath)))
            {
                intent = new Intent(Intent.ActionView);
                intent.SetDataAndType(pdfPath, "application/pdf");
            }

            intent.SetFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }
    }
}

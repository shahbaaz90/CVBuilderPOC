// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="PdfHelper.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   PdfHelper
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PCLStorage;
using System.Net;
using System.IO;

namespace PrismTest.Services
{
    public class PdfHelper : IPdfHelper
    {
        public const string folderName = "folder";

        public async Task PCLGenaratePdf(string path, string text)
        {
            //IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(path);

            IFolder rootFolder =  FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync(folderName, CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync(path, CreationCollisionOption.ReplaceExisting);

            using (var fs = await file.OpenAsync(FileAccess.ReadAndWrite))
            {
                var document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                // Font times = new Font(bfTimes, 12, Font.ITALIC, Color.Red);

                Font times = new Font(bfTimes, 60, Font.BOLD, BaseColor.BLACK);
                Font timessmall = new Font(bfTimes, 30, Font.NORMAL, BaseColor.RED);
                Paragraph standard = new Paragraph("Chapter 1", times);

                document.Add(new Chapter(standard, 1));
                document.Add(new Paragraph(text, timessmall));
                document.Close();
                writer.Close();

            }


            //string url = "https://codepen.io/DeepS/pen/HJAhp.html";
            //HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url); 
            //HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync(); 
            //StreamReader sr = new StreamReader(response.GetResponseStream()); 
            //richTextBox1.Text = sr.ReadToEnd(); 
            //sr.Close(); 
        }

        public async Task<string> PCLReadFile(string path)
        {
            IFile file = await FileSystem.Current.GetFileFromPathAsync(path);
            return file.Path;
        }
    }
}

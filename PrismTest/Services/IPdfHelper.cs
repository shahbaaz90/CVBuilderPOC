// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPdfHelper.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   IPdfHelper
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;

namespace PrismTest.Services
{
    public interface IPdfHelper
    {
        Task PCLGenaratePdf(string path, string text);

        Task<string> PCLReadFile(string path);
    }
}

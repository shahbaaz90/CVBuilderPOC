// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPdfOpener.cs" company="Grosvenor">
// //   Grosvenor
// // </copyright>
// // <summary>
// //   IPdfOpener
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;

namespace PrismTest.Services
{
    public interface IPdfOpener
    {
        Task Generate(string path);

        Task ReadPDF();
    }
}

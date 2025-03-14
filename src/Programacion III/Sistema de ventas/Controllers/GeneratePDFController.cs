﻿using Microsoft.AspNetCore.Mvc;
using P.Final.Components.Modelos;

namespace P.Final.Controllers
{
    public class GeneratePDFController : Controller
    {
        [HttpGet]
        [Route("DownloadPdf")]
       public IActionResult DownloadPDFFile(string pageName)
        {
            var pdf = new GeneratePDF($"https://{Request.Host.Value}/{pageName}");
            var pdfFile = pdf.GetPdf();

            var pdfStream = new System.IO.MemoryStream(pdfFile);
            return new FileStreamResult(pdfStream, "application/pdf");
        }
    }
}

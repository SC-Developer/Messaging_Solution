using System;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Drawing;
using System.IO;
using System.Text;

namespace Messaging.PdfFileAdapter
{
    public class PdfDataService : IPdfDataService
    {
        public string WriteData(string Output)
        {
            //Create a new PDF document.
            PdfDocument document = new PdfDocument();
            //Add a page to the document.
            PdfPage page = document.Pages.Add();
            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            //Draw the text.
            graphics.DrawString(Output, font, PdfBrushes.Black, new PointF(0, 0));
                                   
            FileStream file = new FileStream("Output.pdf", FileMode.Create, FileAccess.Write);

            //Save the document.
            document.Save(file);
            file.Dispose();
            //file.Close();
            //Close the document.
            document.Close(true);
            
            return "Data Written successfully by PdfDataService";
        }
    }
}

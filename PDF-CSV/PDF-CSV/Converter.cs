using iTextSharp.text.pdf;
using System;
using System.Linq;
using System.Text;

namespace PDF_CSV
{
    internal class Converter
    {
        private StringBuilder ExtractPDF(Uri fullPath)
        {
            var fileName = fullPath.LocalPath.Split('/').Last().Replace(".pdf", string.Empty);
            var path = fullPath.LocalPath.Replace($"{fileName}.pdf", string.Empty);

            var parser = new PdfReader(fullPath);
            var result = new StringBuilder(65536);
            var holder = new StringBuilder(16384);
            for (int i = 0; i < parser.NumberOfPages; i++)
            {
                holder.Append(parser.GetPageContent(i));
                //remove NOT USED Shit
                result.AppendLine(holder.ToString());
                holder.Clear();
            }

            return result;
        }

        private void SaveToCSV(Uri path, string fileName)
        {

        }

    }
}

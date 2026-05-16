using ClosedXML;
using ClosedXML.Excel;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filevy.Converters
{
    public static class XLSXConverter
    {
        //ToDo: the User should choose the delimiter in the UI
        public static void Convert(string inputPath, string outputPath, IProgress<int>? progress = null)
        {
            progress?.Report(20);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                BadDataFound = null,
                MissingFieldFound = null,
                DetectDelimiter = true
            };

            using var reader = new StreamReader(inputPath);
            using var csv = new CsvReader(reader, config);

            var records = csv.GetRecords<dynamic>();

            progress?.Report(40);

            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet1");

            int row = 1;
            bool headerWritten = false;

            foreach (var record in records)
            {
                var dict = (IDictionary<string, object>)record;

                //write Header
                if (!headerWritten)
                {
                    int headerCol = 1;
                    foreach (var header in dict.Keys)
                    {
                        worksheet.Cell(row, headerCol).Value = header;
                        worksheet.Cell(row, headerCol).Style.Font.Bold = true;

                        headerCol++;
                    }
                    row++;
                    headerWritten = true;
                }

                //write data
                int col = 1;
                foreach (var value in dict.Values)
                {
                    var cell = worksheet.Cell(row, col);

                    //format all data as string

                    cell.SetValue(value.ToString() ?? string.Empty);
                    col++;

                }
                row++;
            }
            worksheet.Columns().AdjustToContents();

            progress?.Report(90);

            workbook.SaveAs(outputPath);

            progress?.Report(100);
        }


    }
}

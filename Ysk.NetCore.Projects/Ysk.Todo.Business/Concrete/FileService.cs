using FastMember;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using Ysk.Todo.Business.Abstract;

namespace Ysk.Todo.Business.Concrete
{
    // Excel için  => Manage Nuget Package dan,  ""EPPlus""  kütüphanesini yükle
    // PDF   için  => Manage Nuget Package dan,  ""ITextSharp.LGPLv2.Core"" ve ""FastMember""  kütüphanelerini yükle
    public class FileService : IFileService
    {
        public byte[] ToExcel<T>(List<T> list) where T : class, new()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();

            var excelBlank = excelPackage.Workbook.Worksheets.Add("Calisma1");
            excelBlank.Cells["A1"].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Light15);
 
            return excelPackage.GetAsByteArray(); 
        }

        public string ToPdf<T>(List<T> list) where T : class, new()
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(ObjectReader.Create(list));

            string filename = Guid.NewGuid() + ".pdf";
            var returnPath = "/documents/" + filename;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/documents/" + filename);
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4, 25f, 25f, 25f, 25f);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(dataTable.Columns.Count);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                pdfPTable.AddCell(dataTable.Columns[i].ColumnName);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    pdfPTable.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(pdfPTable);
            document.Close();

            return returnPath;
        }
    }
}

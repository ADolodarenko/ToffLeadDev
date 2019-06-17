using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffLeadDev
{
    public class ExcelFileSource : IFileSource
    {
        private const string EXCEPT_FILE_NOT_EXISTS = "The source file doesn't exist.";

        private string fileName;
        private Stream fileStream;
        private IExcelDataReader fileReader;

        public ExcelFileSource(string fileName)
        {
            this.fileName = fileName;
        }

        public void Close()
        {
            if (fileReader != null)
            {
                fileReader.Close();
                fileReader = null;
            }

            if (fileStream != null)
            {
                fileStream.Close();
                fileStream = null;
            }
        }

        public void Open()
        {
            Close();

            if (File.Exists(fileName))
            {
                fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                fileReader = ExcelReaderFactory.CreateReader(fileStream, new ExcelReaderConfiguration()
                {
                    LeaveOpen = true
                });
            }
            else
                throw new Exception(EXCEPT_FILE_NOT_EXISTS);
        }

        public IDataRecord GetNextRecord()
        {
            if (fileReader.Read())
                return fileReader;
            else
                return null;
        }
    }
}

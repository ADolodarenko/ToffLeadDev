using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace ToffLeadDev
{
    /*
     * Источник данных в виде Excel-файла. Реализует интерфейс произвольного файлового источника данных.
     */
    public class ExcelFileSource : IFileSource
    {
        private const string EXCEPT_FILE_NOT_EXISTS = "The source file doesn't exist.";

        private string fileName;
        private Stream fileStream;
        private IExcelDataReader fileReader;

        /*
         * Конструктор.
         */
        public ExcelFileSource(string fileName)
        {
            this.fileName = fileName;
        }

        /*
         * Метод закрывает источник.
         */
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

        /*
         * Метод открывает источник.
         */
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

        /*
         * Метод получает следующую строку из источника в виде IDataRecord.
         */
        public IDataRecord GetNextRecord()
        {
            if (fileReader.Read())
                return fileReader;
            else
                return null;
        }
    }
}

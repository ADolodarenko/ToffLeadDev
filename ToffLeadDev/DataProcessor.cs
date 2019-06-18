using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace ToffLeadDev
{
    /*
     * Процессор загрузки, преобразования и передачи данных на сайт. Ядро логики приложения.
     */
    public class DataProcessor
    {
        private const string PATTERN_MESSAGE = "INN={0} response: {1}";

        private IFileSource fileSource;
        private List<string> logLines;

        /*
         * Конструктор.
         */                
        public DataProcessor(string sourceFileName, string webURL, string webAgentId, string webApiKey, string webApiSecret)
        {
            logLines = new List<string>();

            fileSource = GetFileSource(sourceFileName);

            ToffAPI.setAuthParams(webURL, webAgentId, webApiKey, webApiSecret);
        }

        /*
         * Запуск процессора в отдельном потоке.
         */
        public void Start()
        {
            Thread thread = new Thread(new ThreadStart(Process));
            thread.Start();
        }

        /*
         * Собственно, запуск процессора.
         */
        public void Process()
        {
            if (fileSource != null)
            {
                fileSource.Open();

                IDataRecord dataRecord;

                while ((dataRecord = fileSource.GetNextRecord()) != null)
                {
                    try
                    {
                        ToffLead lead = DataTransformer.MakeToffLead(dataRecord);

                        if (lead != null)
                            logLines.Add(string.Format(PATTERN_MESSAGE, lead.innOrOgrn, ToffAPI.createApplication(lead)));
                    }
                    catch (Exception e)
                    {
                        logLines.Add(e.ToString());
                    }
                }
                                
                fileSource.Close();
            }
        }

        /*
         * Получение списка строк лога работы процессора.
         */
        public List<string> GetLogLines()
        {
            return logLines;
        }

        private IFileSource GetFileSource(string sourceFileName)
        {
            if (sourceFileName.EndsWith(".xls") || sourceFileName.EndsWith(".xlsx"))
                return new ExcelFileSource(sourceFileName);
            else
                return null;
        }
    }
}

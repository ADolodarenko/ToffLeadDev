using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToffLeadDev
{
    public class DataProcessor
    {
        private IFileSource fileSource;
        private List<string> logLines;
        
        public DataProcessor(string sourceFileName, string webURL, string webAgentId, string webApiKey, string webApiSecret)
        {
            logLines = new List<string>();

            fileSource = GetFileSource(sourceFileName);

            ToffAPI.setAuthParams(webURL, webAgentId, webApiKey, webApiSecret);
        }

        public List<string> Process()
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
                            logLines.Add(ToffAPI.createApplication(lead));
                    }
                    catch (Exception e)
                    {
                        logLines.Add(e.ToString());
                    }
                }
                                
                fileSource.Close();
            }

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

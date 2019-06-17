using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffLeadDev
{
    interface IFileSource
    {
        void Open();
        IDataRecord GetNextRecord();
        void Close();
    }
}

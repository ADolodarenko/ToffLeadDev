using System.Data;

namespace ToffLeadDev
{
    /*
     * Интерфейс произвольного файлового источника данных.
     */
    interface IFileSource
    {
        /*
         * Метод открывает источник.
         */
        void Open();

        /*
         * Метод получает следующую строку из источника в виде IDataRecord.
         */
        IDataRecord GetNextRecord();

        /*
         * Метод закрывает источник.
         */
        void Close();
    }
}

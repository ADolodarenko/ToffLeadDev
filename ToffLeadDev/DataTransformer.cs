using System;
using System.Data;
using System.Text;
using ToffLeadDev.Properties;

namespace ToffLeadDev
{
    /*
     * Преобразователь строки данных типа IDataRecord в экземплар ToffLead.
     */
    public class DataTransformer
    {
        private const string PATTERN_INN1 = @"^\s*[0-9]{10}\s*$";
        private const string PATTERN_INN2 = @"^\s*[0-9]{12}\s*$";
        private const string PATTERN_INN3 = @"^\s*[0-9]{13}\s*$";
        private const string PATTERN_INN4 = @"^\s*[0-9]{15}\s*$";

        private const string PATTERN_PHONE = @"^[0-9]{10}$";  // ((\+7)|8) -> (8)
        
        private const string PATTERN_LAST_NAME = @"^[A-Za-zА-Яа-яЁё ]((\ |\-)?[A-Za-zА-Яа-яЁё ]){0,49}$";
        private const string PATTERN_FIRST_NAME = @"^[A-Za-zА-Яа-яЁё ]((\ |\-)?[A-Za-zА-Яа-яЁё ]){0,49}$";
        private const string PATTERN_MIDDLE_NAME = @"^[A-Za-zА-Яа-яЁё ]((\ |\-)?[A-Za-zА-Яа-яЁё ]){0,49}$";
        private const string PATTERN_COMPANY_NAME = "^[\\d\\s\\-\\.\\(\\)\\,\\\"\\/:/+#№»«а-яА-ЯёЁa-zA-Z]{1,150}$";
        private const string PATTERN_EMAIL = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        private const string PREFIX_COMPANY_NAME = @"ИП ";
        private const string MESSAGE_PREFIX = "Can't upload a lead: ";
        private const string MESSAGE_VALUE_DELIMITER = " - ";
        private const string MESSAGE_FIELD_DELIMITER = "; ";
        private const string MESSAGE_WRONG_INN = "Wrong INN";
        private const string MESSAGE_WRONG_PHONE = "Wrong phone";
        private const string MESSAGE_WRONG_LAST_NAME = "Wrong last name";
        private const string MESSAGE_WRONG_FIRST_NAME = "Wrong first name";
        private const string MESSAGE_WRONG_MIDDLE_NAME = "Wrong middle name";
        private const string MESSAGE_WRONG_COMPANY_NAME = "Wrong company name";
        private const string MESSAGE_WRONG_EMAIL = "Wrong email";

        private const int FIELD_INN_INDEX = 0;
        private const int FIELD_LAST_NAME_INDEX = 1;
        private const int FIELD_FIRST_NAME_INDEX = 2;
        private const int FIELD_MIDDLE_NAME = 3;
        private const int FIELD_PHONE_INDEX = 4;
        private const int FIELD_COMPANY_NAME_INDEX = 5;
        private const int FIELD_EMAIL_INDEX = 6;

        /*
         * Собственно, метод получения ToffLead по IDataRecord.
         */
        public static ToffLead MakeToffLead(IDataRecord dataRecord)
        {
            StringBuilder exceptionStringBuilder = new StringBuilder();

            string inn = GetValue(dataRecord, FIELD_INN_INDEX, true, new string[] { PATTERN_INN1, PATTERN_INN2, PATTERN_INN3, PATTERN_INN4 }, exceptionStringBuilder, MESSAGE_WRONG_INN);

            string phone = GetValue(dataRecord, FIELD_PHONE_INDEX, true, null, exceptionStringBuilder, MESSAGE_WRONG_PHONE); //Здесь шаблон не передаем. Контролируем телефон после нормализации.
            if (phone != null)
                phone = NormalizePhone(phone, true, new string[] { PATTERN_PHONE }, exceptionStringBuilder, MESSAGE_WRONG_PHONE);

            string lastName = GetValue(dataRecord, FIELD_LAST_NAME_INDEX, true, new string[] { PATTERN_LAST_NAME }, exceptionStringBuilder, MESSAGE_WRONG_LAST_NAME);
            string firstName = GetValue(dataRecord, FIELD_FIRST_NAME_INDEX, false, new string[] { PATTERN_FIRST_NAME }, exceptionStringBuilder, MESSAGE_WRONG_FIRST_NAME);
            string middleName = GetValue(dataRecord, FIELD_MIDDLE_NAME, false, new string[] { PATTERN_MIDDLE_NAME }, exceptionStringBuilder, MESSAGE_WRONG_MIDDLE_NAME);
            string companyName = GetValue(dataRecord, FIELD_COMPANY_NAME_INDEX, false, new string[] { PATTERN_COMPANY_NAME }, exceptionStringBuilder, MESSAGE_WRONG_COMPANY_NAME);
            string email = GetValue(dataRecord, FIELD_EMAIL_INDEX, false, new string[] { PATTERN_EMAIL }, exceptionStringBuilder, MESSAGE_WRONG_EMAIL);
            
            if (exceptionStringBuilder.Length > 0)
            {
                int endLength = MESSAGE_FIELD_DELIMITER.Length;

                exceptionStringBuilder.Remove(exceptionStringBuilder.Length - endLength, endLength);
                exceptionStringBuilder.Insert(0, MESSAGE_PREFIX);

                throw new Exception(exceptionStringBuilder.ToString());
            }

            companyName = NormalizeCompanyName(companyName, lastName, firstName, middleName);

            return GetLead(inn, lastName, firstName, middleName, phone, companyName);
        }

        private static string GetValue(IDataRecord dataRecord, int fieldIndex, bool isMandatory, string[] patterns, StringBuilder exceptionStringBuilder, string exceptionMessage)
        {
            string value = null;

            if ( fieldIndex < dataRecord.FieldCount && !dataRecord.IsDBNull(fieldIndex) )
            {
                Type fieldType = dataRecord.GetFieldType(fieldIndex);

                if (fieldType.Equals(typeof(string)))
                    value = dataRecord.GetString(fieldIndex);
                else
                    value = dataRecord.GetValue(fieldIndex).ToString();
            }

            if (!IsCorrectValue(isMandatory, value, patterns))
            {
                Utils.AppendToBuilder(exceptionStringBuilder, exceptionMessage, MESSAGE_VALUE_DELIMITER);
                Utils.AppendToBuilder(exceptionStringBuilder, value, MESSAGE_FIELD_DELIMITER);
            }

            return value;
        }

        private static bool IsCorrectValue(bool isMandatory, string value, string[] patterns)
        {
            if (isMandatory)
                return value != null && Utils.MatchesAny(value, patterns);
            else
                return value != null ? Utils.MatchesAny(value, patterns) : true;
        }

        private static string NormalizePhone(string phone, bool isMandatory, string[] patterns, StringBuilder exceptionStringBuilder, string exceptionMessage)
        {
            string normalizedPhone = phone.Trim();

            //char[] wrongChars = { '(', ')', '+', '#', '-', ' ', '.', ',' };
            normalizedPhone = Utils.RemoveAllButDigits(normalizedPhone);

            int length = normalizedPhone.Length;
            if (length > 10)
                normalizedPhone = normalizedPhone.Substring(length - 10);

            if (!IsCorrectValue(isMandatory, normalizedPhone, patterns))
            {
                Utils.AppendToBuilder(exceptionStringBuilder, exceptionMessage, MESSAGE_VALUE_DELIMITER);
                Utils.AppendToBuilder(exceptionStringBuilder, phone, MESSAGE_FIELD_DELIMITER);
            }

            length = normalizedPhone.Length;
            if (length == 10)
                normalizedPhone = Settings.Default.PhonePrefix + normalizedPhone;
            
            return normalizedPhone;
        }

        private static string NormalizeCompanyName(string companyName, string lastName, string firstName, string middleName)
        {
            if (companyName != null)
                return companyName;

            StringBuilder builder = new StringBuilder();
            Utils.AppendToBuilder(builder, PREFIX_COMPANY_NAME, " ");
            Utils.AppendToBuilder(builder, lastName, " ");
            Utils.AppendToBuilder(builder, firstName, " ");
            Utils.AppendToBuilder(builder, middleName, null);
            
            return builder.ToString();
        }

        private static ToffLead GetLead(string inn, string lastName, string firstName, string patronymic, string phone, string companyName)
        {
            ToffLead lead = new ToffLead();

            lead.product = Settings.Default.LeadProduct;
            lead.source = Settings.Default.LeadSource;
            lead.subsource = Settings.Default.LeadSubsource;
            lead.firstName = firstName;
            lead.middleName = patronymic;
            lead.lastName = lastName;
            lead.phoneNumber = phone;
            lead.email = null;
            lead.isHot = Settings.Default.LeadIsHot;
            lead.companyName = companyName;
            lead.innOrOgrn = inn;
            lead.comment = null;
            lead.temperature = Settings.Default.LeadTemperature;

            return lead;
        }

        private DataTransformer() { }
    }
}

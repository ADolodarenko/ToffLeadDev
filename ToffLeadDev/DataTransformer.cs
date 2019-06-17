using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToffLeadDev
{
    public class DataTransformer
    {
        private const string PATTERN_INN = @"^\s*[0-9]{10,12,13,15}\s*$";
        private const string PATTERN_PHONE = @"^\s*[\+7|8]?[0-9]{10}\s*$";
        private const string PATTERN_LAST_NAME = @"^[A-Za-zА-Яа-яЁё ]((\ |\-)?[A-Za-zА-Яа-яЁё ]){0,49}$";
        private const string PATTERN_FIRST_NAME = @"^[A-Za-zА-Яа-яЁё] ((\ |\-)?[A-Za-zА-Яа-яЁё]){0,49}$";
        private const string PATTERN_MIDDLE_NAME = @"^[A-Za-zА-Яа-яЁё] ((\ |\-)?[A-Za-zА-Яа-яЁё]){0,49}$";
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

        private const string LEAD_PRODUCT = "РКО";
        private const string LEAD_SOURCE = "Локальные агенты";
        private const string LEAD_SUBSOURCE = "API";
        private const string LEAD_TEMPERATURE = "COLD";
        private const bool LEAD_ISHOT = false;

        private const int FIELD_INN_INDEX = 0;
        private const int FIELD_LAST_NAME_INDEX = 1;
        private const int FIELD_FIRST_NAME_INDEX = 2;
        private const int FIELD_MIDDLE_NAME = 3;
        private const int FIELD_PHONE_INDEX = 4;
        private const int FIELD_COMPANY_NAME_INDEX = 5;
        private const int FIELD_EMAIL_INDEX = 6;

        public static ToffLead MakeToffLead(IDataRecord dataRecord)
        {
            StringBuilder exceptionStringBuilder = new StringBuilder();

            string inn = GetValue(dataRecord, FIELD_INN_INDEX, true, PATTERN_INN, exceptionStringBuilder, MESSAGE_WRONG_INN);
            string phone = GetValue(dataRecord, FIELD_PHONE_INDEX, true, PATTERN_PHONE, exceptionStringBuilder, MESSAGE_WRONG_PHONE);
            string lastName = GetValue(dataRecord, FIELD_LAST_NAME_INDEX, true, PATTERN_LAST_NAME, exceptionStringBuilder, MESSAGE_WRONG_LAST_NAME);
            string firstName = GetValue(dataRecord, FIELD_FIRST_NAME_INDEX, true, PATTERN_FIRST_NAME, exceptionStringBuilder, MESSAGE_WRONG_FIRST_NAME);
            string middleName = GetValue(dataRecord, FIELD_MIDDLE_NAME, true, PATTERN_MIDDLE_NAME, exceptionStringBuilder, MESSAGE_WRONG_MIDDLE_NAME);
            string companyName = GetValue(dataRecord, FIELD_COMPANY_NAME_INDEX, false, PATTERN_COMPANY_NAME, exceptionStringBuilder, MESSAGE_WRONG_COMPANY_NAME);  //??
            string email = GetValue(dataRecord, FIELD_EMAIL_INDEX, false, PATTERN_EMAIL, exceptionStringBuilder, MESSAGE_WRONG_EMAIL);

            if (exceptionStringBuilder.Length > 0)
            {
                int endLength = MESSAGE_FIELD_DELIMITER.Length;

                exceptionStringBuilder.Remove(exceptionStringBuilder.Length - endLength, endLength);
                exceptionStringBuilder.Insert(0, MESSAGE_PREFIX);

                throw new Exception(exceptionStringBuilder.ToString());
            }

            phone = NormalizePhone(phone);
            companyName = NormalizeCompanyName(companyName, lastName, firstName, middleName);

            return GetLead(inn, lastName, firstName, middleName, phone, companyName);
        }

        private static string GetValue(IDataRecord dataRecord, int fieldIndex, bool isMandatory, string pattern, StringBuilder exceptionStringBuilder, string exceptionMessage)
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

            if (!IsCorrectValue(isMandatory, value, pattern))
            {
                AppendToBuilder(exceptionStringBuilder, exceptionMessage, MESSAGE_VALUE_DELIMITER);
                AppendToBuilder(exceptionStringBuilder, value, MESSAGE_FIELD_DELIMITER);
            }

            return value;
        }

        private static bool IsCorrectValue(bool isMandatory, string value, string pattern)
        {
            if (isMandatory)
                return value != null && (pattern != null ? Regex.IsMatch(value, pattern) : true);
            else
                return (value != null && pattern != null) ? Regex.IsMatch(value, pattern) : true;
        }

        private static void AppendToBuilder(StringBuilder builder, string line, string delimiter)
        {
            builder.Append(line);
            builder.Append(delimiter);
        }

        private static string NormalizePhone(string phone)
        {
            return phone;
        }

        private static string NormalizeCompanyName(string companyName, string lastName, string firstName, string middleName)
        {
            return companyName;
        }

        private static ToffLead GetLead(string inn, string lastName, string firstName, string patronymic, string phone, string companyName)
        {
            ToffLead lead = new ToffLead();

            lead.product = LEAD_PRODUCT;
            lead.source = LEAD_SOURCE;
            lead.subsource = LEAD_SUBSOURCE;
            lead.firstName = firstName;
            lead.middleName = patronymic;
            lead.lastName = lastName;
            lead.phoneNumber = phone;
            lead.email = null;
            lead.isHot = LEAD_ISHOT;
            lead.companyName = companyName;
            lead.innOrOgrn = inn;
            lead.comment = null;
            lead.temperature = LEAD_TEMPERATURE;

            return lead;
        }
    }
}

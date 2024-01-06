using System.Globalization;

namespace Quote.Api.Common
{
    public static class Validator
    {
        public static bool BeAValidPositiveInteger(int value)
        {
            return value > 0;
        }

        public static bool BeAValidPolicyTypeId(int value)
        {
            return value == 1 || value == 2;
        }

        public static bool BeValidDateFormat(string date)
        {
            // Check if the date has a valid dd/MM/yyyy format
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            return false;
        }

        public static bool BeValidModelYear(string date)
        {
            if (DateTime.TryParseExact(date, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            return false;
        }
        public static bool BeValidBooleanValue(bool value)
        {
            // Check if the value is either true, false, 0, or 1
            return value || value == false || value.Equals(0) || value.Equals(1);
        }
    }
}

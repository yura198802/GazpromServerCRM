using Newtonsoft.Json.Linq;

namespace Monica.Core.Service.Extension
{
    public static class ColumnHelper
    {
        public static string GetFieldName(this string fieldName)
        {
            if (fieldName.Contains("{"))
            {
                var obj = JObject.Parse(fieldName);
                fieldName = (obj["Alias"] ?? obj["Fk"])?.ToString() ?? fieldName;
            }

            return fieldName;
        }
    }
}

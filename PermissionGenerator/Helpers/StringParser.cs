using System;

namespace PermissionGenerator.Helpers
{
    //public virtual DbSet<BaseMaterial> BaseMaterial { get; set; }
    public static class StringParser
    {
        public static string GetEntityNameFromRow(string entityRow)
        {
            if (IsDbSetProperty(entityRow))
            {
                var startIndex = entityRow.IndexOf("<", StringComparison.Ordinal) + 1;
                var endIndex = entityRow.IndexOf(">", StringComparison.Ordinal) - startIndex;

                var entityName = entityRow.Substring(startIndex, endIndex);

                return entityName.Contains(".") ? ExtractDotsFromEntityName(entityName) : entityName;
            }

            return "";
        }

        public static bool IsDbSetProperty(string row)
        {
            return row.ToLower().Contains("dbset");
        }

        public static string ExtractDotsFromEntityName(string entityName)
        {
            int lastDotIndex = entityName.LastIndexOf(".", StringComparison.Ordinal)+1;
            return entityName.Substring(lastDotIndex);
        }
    }
}
using System;

namespace PermissionGenerator.Helpers
{
    //public virtual DbSet<BaseMaterial> BaseMaterial { get; set; }
    public static class StringHelper
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

        private static bool IsDbSetProperty(string row)
        {
            return row.ToLower().Contains("dbset");
        }

        private static string ExtractDotsFromEntityName(string entityName)
        {
            int lastDotIndex = entityName.LastIndexOf(".", StringComparison.Ordinal) + 1;
            return entityName.Substring(lastDotIndex);
        }

        public static string CreatePermissionName(string varribleName, string entityName)
        {
            return $"public const string {varribleName} = {(char) 34 + entityName + (char) 34};";
        }

        public static string CreatePermissionContext(string permissionName)
        {
            return $"context.CreatePermission(PermissionNames.{permissionName}, L(PermissionNames.{permissionName}));";
        }
    }
}
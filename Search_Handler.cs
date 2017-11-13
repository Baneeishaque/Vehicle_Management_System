using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aryavidyashala_Vehicle_Management_System
{
    class Search_Handler
    {
        internal static string query_builder_search(String fields, String table)
        {

            return "SELECT " + fields + " FROM " + table + "";
        }

        internal static string query_builder_search_feild(string fields, string table, string search_field, string searchkey)
        {
            return query_builder_search(fields, table) + " where " + search_field + "='" + searchkey + "'";

        }

        internal static string query_builder_search_feild_start(string fields, string table, string search_field, string searchkey)
        {
            return query_builder_search(fields, table) + " where " + search_field + " LIKE '" + searchkey + "%'";
        }

        internal static string query_builder_search_feild_end(string fields, string table, string search_field, string searchkey)
        {
            return query_builder_search(fields, table) + " where " + search_field + " LIKE '%" + searchkey + "'";

        }

        internal static string query_builder_search_feild_contains(string fields, string table, string search_field, string searchkey)
        {

            return query_builder_search(fields, table) + " where " + search_field + " LIKE '%" + searchkey + "%'";
        }

        internal static string query_builder_search_feild_notcontains(string fields, string table, string search_field, string searchkey)
        {

            return query_builder_search(fields, table) + " where " + search_field + " NOT LIKE '%" + searchkey + "%'";

        }

        internal static string query_append(String query, String append_text)
        {
            return query + " " + append_text;
        }
    }
}

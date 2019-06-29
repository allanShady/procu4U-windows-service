using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procu4UvsPrimavera.Utilities
{
    public static class ApiEndPoints
    {
        public const string MAIN_END_POINT = "https://localhost:44364/api/v1/entities"; 
        public const string UNITS = "https://localhost:44364/api/v1/entities/unit";
        public const string CURRENCIES = "https://localhost:44364/api/v1/entities/currency";
        public const string DEPARTMENTS = "https://localhost:44364/api/v1/entities/department";
        public const string REQUISITIONS = "https://localhost:44364/api/v1/entities/requisition";
        public const string SUPPLIERS = "https://localhost:44364/api/v1/entities/supplier";
        public const string PRODUCTS = "https://localhost:44364/api/v1/entities/product";
    }
}

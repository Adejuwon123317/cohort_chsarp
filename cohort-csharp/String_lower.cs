using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public static class String_lower
    {
        public static string ToLower(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            return value.ToLower();

        }

    }
}

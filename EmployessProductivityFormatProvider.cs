using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class EmployessProductivityFormatProvider : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
           int rating = (int)arg;

            if (rating == 0)
            {
                return $"{rating} (new employee)";
            }

            if (rating > 0)
            {
                return $"{rating} (good employee)";
            }

            
                return $"{rating} (bad employee)";
            
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }

            return null;
        }
    }
}

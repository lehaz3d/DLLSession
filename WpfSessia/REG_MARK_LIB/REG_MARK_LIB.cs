using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class REG_MARK_LIB
    {
         //Проверка на правиольность номерного знака
        public static Boolean CheckMark(String mark)
        {
            if (Regex.IsMatch($"{mark}", @"^[A-Z]{1}\d{3}[A-Z]{2}\d{3}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

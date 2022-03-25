using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class VIN_LIB
    {
        //Проверка правильности VIN
       public static Boolean CheckVIN(String vin)
       {
            int countValue = 0;
            char[] vinSyblos = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e' ,'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int j = 0; j < vin.Length; j++)
            {
                String timeNumber = Convert.ToString(vin[j]);
                for (int i = 0; i < vinSyblos.Length; i++)
                {
                    if (timeNumber.ToLower().Contains(vinSyblos[i]))
                    {
                        countValue++;
                    }
                }        
            }
            if (countValue == vin.Length && countValue == 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Возвращает континент производитель по VIN
        public static String GetVINCountry(String vin)
        {
            String countryNumberVin = Convert.ToString(vin[0]);
            String countryName = "";
            char[] ContinentAfrika = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char[] ContinentAzia = { 'j', 'k', 'l', 'm', 'n', 'p', 'r' };
            char[] ContinentEurope = { 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] ContinentSeverAmerica = { '0', '1', '2', '3', '4', '5' };
            char[] ContinentOceania = { '6', '7' };
            char[] ContinentUgAmerika = { '8', '9' };

            for (int i = 0; i < ContinentAfrika.Length; i++)
            {
                if (countryNumberVin.ToLower().Contains(ContinentAfrika[i]))
                {
                    countryName = "Африка";
                }
                else
                {
                    for (int j = 0; j < ContinentEurope.Length; j++)
                    {
                        if (countryNumberVin.ToLower().Contains(ContinentEurope[j]))
                        {
                            countryName = "Европа";
                        }
                        else
                        {
                            for (int a = 0; a < ContinentAzia.Length; a++)
                            {
                                if (countryNumberVin.ToLower().Contains(ContinentAzia[a]))
                                {
                                    countryName = "Азия";
                                }
                                else
                                {
                                    for (int b = 0; b < ContinentOceania.Length; b++)
                                    {
                                        if (countryNumberVin.ToLower().Contains(ContinentOceania[b]))
                                        {
                                            countryName = "Океания";
                                        }
                                        else
                                        {
                                            for (int c = 0; c < ContinentUgAmerika.Length; c++)
                                            {
                                                if (countryNumberVin.ToLower().Contains(ContinentUgAmerika[c]))
                                                {
                                                    countryName = "Южная Америка";
                                                }
                                                else
                                                {
                                                    for (int z = 0; z < ContinentSeverAmerica.Length; z++)
                                                    {
                                                        if (countryNumberVin.ToLower().Contains(ContinentSeverAmerica[z]))
                                                        {
                                                            countryName = "Северная Америка";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return countryName;
        }
        //Возвращает год по VIN
        public static int GetTransportYear(String vin)
        {
            int ValueYear = 0;
            char[] vinSyblosArray = { 'y', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x' };
            int[] yearsArray = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029 };
            String Year = Convert.ToString(vin[9]);
            for (int i = 0; i < vin.Length; i++)
            {
                if (Year.ToLower().Contains(vinSyblosArray[i]))
                {
                    ValueYear = yearsArray[i];
                }
            }
            return ValueYear;
        }
    }
}

namespace String
{
    public class StringMethods
    {
        //в качестве обозначения типа данных будем использовать целые числа от 0 до 3, 
        //такие, что соответсвующему типу данных
        //будет соответсвовать название по этому индексу
        //из этого массива,
        //т.е. положим что мы получили тип данных 0,
        //тогда мы определим его как types[0], т.е. identificator
        public static string[] types = { "identificator", "integer", "real number", "boolean", "string" };
        public static string Substring(string original, int startIndex, int endIndex = -1)
        {
            if (endIndex == -1)
            {
                endIndex = original.Length;
            }
            int length = endIndex - startIndex;
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = original[startIndex + i];
            }
            return new string(result);
        }
        public static int FindOneSubstr(string str, string substr)
        {
            return KMP(str, substr)[0];

        }
        public static int[] FindAllSubstr(string str, string substr)
        {
            return KMP(str, substr);
        }

        public static string InsertSubstring(string str, string substr, int index)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == index)
                {
                    newString += substr;
                }
                newString += str[i];
            }
            if (index == str.Length)
            {
                newString += substr;
            }
            return newString;
        }

        public static string DeleteOneSubstring(string str, string substr)
        {
            return ReplaceOneSubstring(str, substr, "");
        }
        public static string DeleteAllSubstrings(string str, string substr)
        {
            return ReplaceAllSubstrings(str, substr, "");
        }

        public static string ReplaceOneSubstring(string str, string oldSubstr, string newSubstr)
        {
            int index = FindOneSubstr(str, oldSubstr);
            if (index < 0)
            {
                throw new Exception("Подстрока не найдена");
            }
            string result = Substring(str, 0, index) + newSubstr;
            str = Substring(str, index + oldSubstr.Length);
            return result + str;
        }
        public static string ReplaceAllSubstrings(string str, string oldSubstr, string newSubstr)
        {
            string result = str;
            int index = 0;
            while (index <= result.Length - oldSubstr.Length)
            {
                if (result.Substring(index, oldSubstr.Length) == oldSubstr)
                {
                    result = DeleteOneSubstring(result, oldSubstr);
                    result = InsertSubstring(result, newSubstr, index);
                    index += newSubstr.Length;
                }
                else
                {
                    index++;
                }
            }
            return result;
        }

        public static string DefineTypeOfString(string str)
        {

            if (str == "True" || str == "False")
                return types[3];
            try
            {
                var T = ConvertToInteger(str);
                return types[1];
            }
            catch { }
            try
            {
                var T = ConvertToReal(str);
                return types[2];
            }
            catch { }
            try
            {
                var T = ConvertToIdentificator(str);
                return types[0];
            }
            catch { }

            return types[4];
        }

        public static string ConvertToIdentificator(string str)
        {
            string alphabet = "0123456789_qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < str.Length; i++)
            {
                if (!alphabet.Contains(str[i]))
                    throw new Exception("Недопустимый символ!");

                if (i == 0 && alphabet.IndexOf(str[i]) <= 9)
                    throw new Exception("Переменная не может начинаться с цифры!");

            }
            return str;
        }

        public static int ConvertToInteger(string str)
        {
            double MaxChek = 0;
            int result = 0;
            int i = 1;
            foreach (char s in str)
            {
                if (((int)s - 48 >= 0) && ((int)s - 48 <= 9))
                {
                    result += ((int)s - 48) * (int)Math.Pow(10, str.Length - i);
                    i++;
                    MaxChek += ((int)s - 48) * Math.Pow(10, str.Length - i);
                }
                else
                    throw new Exception("Некорректный ввод");
                if (MaxChek > int.MaxValue)
                    throw new Exception("Значение превысело лимит int");
            }
            return result;
        }

        public static double ConvertToReal(string str)
        {
            double BeforePoint = 0;
            double AfterPoint = 0;
            int i = 0;
            int j = -1;
            bool point = false;
            int countpoint = 0;
            foreach (char s in str)
                if (s == ',')
                    countpoint += 1;
            int index = str.IndexOf(',');
            if (countpoint == 0)
                index = str.Length;
            if (countpoint > 1)
                throw new Exception("Некорректный ввод");
            foreach (char s in str)
            {
                if (((int)s - 48 >= 0) && ((int)s - 48 <= 9))
                {
                    if (!point)
                    {
                        BeforePoint += ((int)s - 48) * Math.Pow(10, index - i - 1);
                        i++;
                    }
                    else
                    {
                        AfterPoint += ((int)s - 48) * Math.Pow(10, j);
                        j--;
                    }
                }
                else if (s == ',')
                    point = true;
                else
                    throw new Exception("Некорректный ввод");
            }
            double sum = Math.Round(BeforePoint + AfterPoint, 10);
            return sum;
        }

        public static bool StringConvertToBool(string str)
        {
            if (str == null || str == "")
                return false;
            return true;
        }
        public static bool DoubleConvertToBool(double str)
        {
            if (str == 0)
                return false;
            return true;
        }

        private static int[] PrefixFunction(string s)
        {
            int[] result = new int[s.Length];
            int i = 1;
            int j = 0;

            while (i < s.Length)
            {
                if (s[j] == s[i])
                {
                    result[i] = j + 1;
                    i += 1;
                    j += 1;
                }
                else
                {
                    if (j == 0)
                    {
                        result[i] = 0;
                        i += 1;
                    }
                    else
                    {
                        j = result[j - 1];
                    }
                }
            }
            return result;
        }
        public static int[] KMP(string s1, string s)
        {
            int[] P = PrefixFunction(s);
            //s1 - строка в которой , s - подстрока
            List<int> result = new List<int>();
            int n = s1.Length;
            int m = s.Length;

            int i = 0;
            int j = 0;

            while (i < n)
            {
                if (s1[i] == s[j])
                {
                    i += 1;
                    j += 1;
                    if (j == m)
                    {
                        result.Add(i - j);
                        j -= 1;
                    }
                }
                else
                {
                    if (j > 0) { j = P[j - 1]; }
                    else { i += 1; }
                }
            }
            if (result.Count == 0)
                result.Add(-1);
            return result.ToArray();
        }

    }

}
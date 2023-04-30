using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String;


namespace Forms
{
    class entryPoint 
    {
        private string input;
        private bool fileChoice;
        private int oper;
        private string subStr;
        private string startIndex;
        private bool all;
        private string strInput;
        private string strOutput = "";
        private int choiceType;
        public entryPoint(string input, bool fileChoice, int oper, string subStr, string startIndex, bool all, int choiceType)
        {
            this.input = input;
            this.fileChoice = fileChoice;
            this.oper = oper;
            this.subStr = subStr;
            this.startIndex = startIndex;
            this.all = all;
            this.choiceType = choiceType;
            getStrInp();
        }

        private void getStrInp()
        {
            if (fileChoice)
            {
                fileHandler file = new(input);
                strInput = file.getFileContent();
            } else { strInput = input; }
        }
        public string mainFunc()
        {
            switch (oper)
            {
                case 1:
                    if (all)
                    {
                        findAllSub();
                        return strOutput;
                    } else { findOneSub(); return strOutput; }
                    
                case 2:
                    return StringMethods.InsertSubstring(strInput, subStr, int.Parse(startIndex));
                    
                case 3:
                    if (all)
                    {
                        return StringMethods.DeleteAllSubstrings(strInput, subStr);
                    } else { return StringMethods.DeleteOneSubstring(strInput, subStr); }
                    
                case 4:
                    if (all)
                    {
                        return StringMethods.ReplaceAllSubstrings(strInput, subStr, startIndex);
                    } else { return StringMethods.ReplaceOneSubstring(strInput, subStr, startIndex); }
                    
                case 5:
                    return StringMethods.DefineTypeOfString(strInput);
                    
                case 6:
                    return getTypeStr();
                    
            }
            return "";
        }

        private string getTypeStr()
        {
            switch (choiceType)
            {
                case 1:
                    return StringMethods.ConvertToIdentificator(strInput);
                    
                case 2:
                    return Convert.ToString(StringMethods.ConvertToInteger(strInput));
                case 3:
                    return Convert.ToString(StringMethods.ConvertToReal(strInput));
                case 4:
                    return Convert.ToString(StringMethods.StringConvertToBool(strInput));

            }
            return "";
        }

        private void findAllSub()
        {
            int[] array = StringMethods.FindAllSubstr(strInput, subStr);
            for (int i = 0; i < array.Length; i++)
            {
                strOutput += Convert.ToString($"{array[i]} ");
            }
        }
        private void findOneSub()
        {
            strOutput = Convert.ToString(StringMethods.FindOneSubstr(strInput, subStr));
        }
    }
}

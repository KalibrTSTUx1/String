using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    class fileHandler
    {
        private string filePath;
        public fileHandler(string filePath)
        {
            this.filePath = filePath;
        }
        
        public string getFileContent()
        {
            return fileOpen(filePath);
        }
        
        private string fileOpen(string filePath)
        {
            StreamReader file;
            string str;
            try
            {
                file = new StreamReader(filePath);
                str = fileReader(file);
            }
            catch (Exception)
            {
                return "";
            }
            file.Close();
            return str;
        }
        private string fileReader(StreamReader file)
        {
            string fileContent = "";
            while (true)
            {
                try
                {
                    string line;
                    line = file.ReadLine();
                    if (line != null)
                    {
                        fileContent += $"{line}";
                        fileContent += " ";
                        continue;
                    }
                    fileContent = fileContent.Trim();
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
            if (fileContent.Length == 0)
            {
                return null;
            }

            return fileContent;
        }
        public void fileRecorder(string filePath, string result)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                string[] text = result.Split(" ");
                for (int i = 0; i < text.Length; i++)
                {
                    sw.Write($"{text[i]} ");
                }
            }
        }
    }
        
}

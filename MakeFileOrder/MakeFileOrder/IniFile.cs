using System;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace IniFileExtension
{
    class IniFile
    {
        public string FileName { get; set; }

        public IniFile()
        {
            //在預設情況下，會使用執行檔案名稱做為INI的檔案名稱(與執行檔案相同位置)
            string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string filename = Path.GetFileNameWithoutExtension(path) + ".ini";
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            FileName = Path.Combine(dir, filename);
        }

        public IniFile(string fileName)
        {
            //使用者指定
            FileName = fileName;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        public void Write(string Section , string Key , string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.FileName);
        }

        public string Read(string Section , string Key , string DefaultValue = "")
        {
            StringBuilder temp = new StringBuilder(512);
            int i = GetPrivateProfileString(Section, Key, DefaultValue, temp, 512, this.FileName);
            return temp.ToString(); 
        }
        /// <summary>
        /// 提供額外使用INI寫入方式
        /// </summary>
        /// <param name="IniFileFullPath">INI檔案</param>
        /// <param name="Section">Section</param>
        /// <param name="Key">Key</param>
        /// <param name="Value">Value</param>
        public void SetProfileString(string IniFileFullPath, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, IniFileFullPath);
        }
        /// <summary>
        /// 提供額外使用INI讀取方式
        /// </summary>
        /// <param name="IniFileFullPath">INI檔案</param>
        /// <param name="Section">Section</param>
        /// <param name="Key">Key</param>
        /// <param name="DefaultValue">DefaultValue</param>
        /// <returns></returns>
        public string GetProfileString(string IniFileFullPath, string Section, string Key, string DefaultValue = "")
        {
            StringBuilder temp = new StringBuilder(512);
            int i = GetPrivateProfileString(Section, Key, DefaultValue, temp, temp.Capacity, IniFileFullPath);
            return temp.ToString();
        }
    }
}

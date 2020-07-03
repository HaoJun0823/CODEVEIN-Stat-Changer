using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CODEVEINStatChanger
{
    class Config
    {

        public static String OpenPath = "";

        public static byte[] FileByte;


        public static void LoadCurrentFileByte(String filePath)
        {

            FileByte = File.ReadAllBytes(filePath);
            

        }

        public static void SaveCurrentFileByte(String filePath)
        {
            //File.Create(filePath);
            File.WriteAllBytes(filePath,FileByte);

        }


        

    }
}

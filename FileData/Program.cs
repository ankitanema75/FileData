using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string fileArg = string.Empty, filePath = string.Empty;
         
            FileOperationHelper foh = new FileOperationHelper();
            FileModel fileModelObj = new FileModel();

            if (args !=null)
            {
                fileArg = args[0];
                filePath = args[1];
            }
            
            fileModelObj=foh.getOutput(fileArg,filePath);

            if (fileModelObj != null)
            {
                if(fileModelObj.Size==0)
                    Console.WriteLine("Version: " + fileModelObj.Version);
                else
                    Console.WriteLine("Size " + fileModelObj.Size);
            }


            Console.ReadKey();

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    class FileOperationHelper
    {
        FileDetails fileDetailsObj = new FileDetails();
        FileModel fileModelObj = new FileModel();
        public FileModel getOutput(string fileArg, string filePath)
        {
            
          
           
            try 
            {
                if(fileArg=="-v"||fileArg=="--v"||fileArg=="/v")
                fileModelObj.Version= getVersion(filePath);

               else if (fileArg == "-s" || fileArg == "--s" || fileArg == "/s")
                    fileModelObj.Size = getSize(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return fileModelObj;
        }

        private int getSize(string arg2)
        {
           
            int resultSize ;
            
            try
            {
                resultSize=fileDetailsObj.Size(arg2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultSize;
        }

        private string getVersion(string arg)
        {

            string resultVersion = string.Empty;

            try
            {
                resultVersion=fileDetailsObj.Version(arg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultVersion;
        }
    }
}

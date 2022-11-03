using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace dumphub
{
    class Class1
    {
        // First Run
        static void Main(string[] args)
        {
            // Start

            Console.WriteLine("0xWarning's Anon File Uploader");
            Console.Write("File > ");


            // Create Var
            string filen = Console.ReadLine();


            Console.Clear();

            try // Catch Any Errors
            {
                Console.WriteLine(CreateDownloadLink(filen)); // Execute And Write Result
            }
            catch
            {
                Console.WriteLine("error");
            }

            Console.Read(); // Keep Open
        }


        // Functions
        static string CreateDownloadLink(string File)
        {
            string ReturnValue = string.Empty;
            try
            {
                using (WebClient Client = new WebClient())
                {
                    byte[] Response = Client.UploadFile("https://api.anonfiles.com/upload", File); //Upload And Return Response
                    string ResponseBody = Encoding.ASCII.GetString(Response);
                    if (ResponseBody.Contains("\"error\": {")) // Simple Error Handling
                    {
                        ReturnValue += "There was a erorr while uploading the file.\r\n";
                        ReturnValue += "Error message: " + ResponseBody.Split('"')[7] + "\r\n";
                    }
                    else
                    {
                        ReturnValue += "Download link: " + ResponseBody.Split('"')[15] + "\r\n"; // Completed
                        ReturnValue += "File name: " + ResponseBody.Split('"')[25] + "\r\n";
                    }
                }
            }
            catch (Exception Exception)
            {
                ReturnValue += "Exception Message:\r\n" + Exception.Message + "\r\n"; // Return Error 
            }
            return ReturnValue;
        }
    }
}
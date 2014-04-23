using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using SCEG.ScoreboardPc.Data;

namespace SCEG.ScoreboardPc.Business
{
    class ClassFTP
    {
        public static string FtpUpload(FtpConfig config, string RennenNr, string LaufNr)
        {
            if (config == null) return "Wrong settings";

            if (string.IsNullOrEmpty(config.FTPServer)) return "No FTPServer";
            if (string.IsNullOrEmpty(config.FTPPath)) return "No FTPPath";
            if (string.IsNullOrEmpty(config.FTPFile)) return "No FTPFile";
            if (string.IsNullOrEmpty(config.FTPUser)) return "No FTPUser";
            if (string.IsNullOrEmpty(config.FTPPassword)) return "No FTPPassword";

            string result;           
            try
            {
                string status = RennenNr + ";" + LaufNr;
                byte[] status1 = HelperMethods.StringToByteArray(status);

                FtpWebRequest uploadFileRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + config.FTPServer + config.FTPPath + config.FTPFile);
                uploadFileRequest.Credentials = new NetworkCredential(config.FTPUser, config.FTPPassword);
                uploadFileRequest.KeepAlive = false;
                uploadFileRequest.Method = WebRequestMethods.Ftp.UploadFile;
                uploadFileRequest.UsePassive = true;
                uploadFileRequest.ContentLength = status.Length;

                Stream fileUploadStream = uploadFileRequest.GetRequestStream();

                int start = 0;
                while (start != status.Length)
                {
                    fileUploadStream.Write(status1, start, 1);
                    start++;
                }
                // FTP Verbindung schliessen
                fileUploadStream.Close();
                Console.WriteLine("Upload hat funktioniert");

                // Rückantwort von FTP Server schliessen
                FtpWebResponse uploadFileResponse = (FtpWebResponse)uploadFileRequest.GetResponse();
                uploadFileResponse.Close();
                result = String.Empty;
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }
    }
}


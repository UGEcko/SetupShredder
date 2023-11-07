using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetupShredder;
using System.IO;

namespace SetupShredder
{
    public partial class mainWindow
    {
        public static string storagePath;
        public static string InitTemp() // Create Temp File
        {
            // Helpful variables, if statements will use these to determine if they are already existing or not
            string fileName = "temp.txt";
            string fileNameStorage = "fileStorage.txt";
            string folderName = "SetupShredder";
            string tempPath = Path.GetTempPath();
            string folderPath = (tempPath + folderName);
            string fullPath = (tempPath + folderName + "\\" + fileName);
            storagePath = (tempPath + folderName + "\\" + fileNameStorage);
            try
            {
                if(Directory.Exists(folderPath) == false) // Essentially meaning the user hasnt ran the program yet, make the temp folder
                {
                    Directory.CreateDirectory(folderPath);
                    logSS("Created temp file directory at: " + "'" + folderPath + "'");

                }
                if (File.Exists(fullPath) == false) // Same thing with the folder but for the temp.txt file
                {
                    File.Create(fullPath);
                    File.Create(storagePath);
                    logSS("Created temp file at: " + "'" + fullPath + "'");
                    MessageBox.Show("This seems to be your first time running the program, to ensure everything runs correctly, please reopen the application.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("InitTemp catch error: " + ex.Message);
            }

            return fullPath;
        }

        public static string tmpFile = InitTemp();

        public static void UpdateTMP(string tmpFile, string content)
        {

            try
            {
                // Write to TMP File
                StreamWriter streamWriter = File.AppendText(tmpFile);
                streamWriter.WriteLine(content);
                streamWriter.Flush();
                streamWriter.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to TMP file: " + ex.Message);
            }
        }

        public static void logSS(string content) // Log content to the console AND to the TEMP file as SetupShredder
        {
            Console.WriteLine("SetupShredder : " + content);
            UpdateTMP(tmpFile, ("[" + DateTime.Now + "]" + " SetupShredder : " + content + "\n"));
        }


        public static void updateLogStorage(string[] content)
        {
            StreamWriter streamWriter = File.AppendText(storagePath);
            streamWriter.WriteLine(content);
            streamWriter.Flush();
            streamWriter.Close();
        }
        public static void updateLogStorage(string content)
        {
            StreamWriter streamWriter = File.AppendText(storagePath);
            streamWriter.WriteLine(content);
            streamWriter.Flush();
            streamWriter.Close();
        }

    }
}

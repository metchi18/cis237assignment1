using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ImportCsv(string pathToCSVFile, WineItem[] WineItems)
        {
            //Declare the StreamReader
            StreamReader streamReader = null;

            try
            {
                //declare a string for the line
                string line;

                //Instantiate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                //While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null) 
                {
                    //Process the line
                    processLine(line, WineItems, counter++);
                }

                //Read through the whole file, so we can return true.
                return true;
            }
            catch (Exception e)
            {
                //Output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //return false because it didn't work
                return false;
            }
            finally
            {
                //Check to see if Streamreader was instantiated, make sure it is closed before exiting the reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

            private void processLine(string line, WineItem[] WineItems, int index)
        {
            //declare array of parts that will contain the results of splitting the read in string
            string[] parts = line.Split(',');

            //Assign each part to a variable- dont have to do this
            int ItemID = int.Parse(parts[0]);
            string ItemDesc = parts[1];
            string ItemPack = parts[2];

            //Add a wine into the array that was passed in.
            WineItems[index] = new WineItem(ItemID, ItemDesc, ItemPack);

        }
    }
}

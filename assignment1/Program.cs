using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            WineItem someWine = new WineItem();

            WineItem[] newWine = new WineItem[4000];

            string pathToCsv = "../../..datafiles/WineList.csv";

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, newWine);

            int choice = UserInterface.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string outputString = "";

                    foreach (WineItem wineItem in newWine)
                    {
                        if (wineItem != null)
                        {
                            outputString += wineItem.ToString() + Environment.NewLine;
                        }
                    }

                }

                choice = UserInterface.GetUserInput();
            }
        }
    }
}

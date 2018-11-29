using SecretSanta.AWS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                IAWSClient client = new AWSClient();
                IDataService dataService = new DataService(client);

                Dictionary<string, string> dataToAdd = new Dictionary<string, string>();
                dataToAdd.Add("Id", "1");
                dataToAdd.Add("name", "Irina Pauna");
                dataToAdd.Add("email", "irinapauna@gmail.com");
                dataService.AddNewRecord(dataToAdd).GetAwaiter().GetResult();


                //dataService.GetItemByKey().GetAwaiter().GetResult(); 

                dataService.ScanTable().GetAwaiter().GetResult();

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                var a = 1;
            }
        }
    }
}

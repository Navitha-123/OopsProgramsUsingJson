using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgramUsingJson
{
    public class FetchRiceDataDetailsUC1
    {
        public InventoryModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryModel>(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}

using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApi.Repositories.Models;

namespace WebApi.Repositories
{
    public class CampaignRepository
    {
        public List<CampaignModel> GetByDate(string data = "")
        {
            var result = new List<CampaignModel>();

            var relativePath = Environment.CurrentDirectory;

            var path = $@"{relativePath.Replace(@"\bin\Debug", "")}\Database\database.csv";

            if (!File.Exists(path))
            {
                return null;
            }

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                result = csv.GetRecords<CampaignModel>().ToList();
            }

            result = result.Where(x => x.Date.Replace("/", "") == data).ToList();

            return result;
        }
    }
}

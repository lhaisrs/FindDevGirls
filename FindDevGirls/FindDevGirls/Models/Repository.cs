using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDevGirls.Models
{
    class Repository
    {
        public async Task<List<DevGirl>> GetDevGirls()
        {
            var Service = new Services.AzureServices<DevGirl>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }
    }
}

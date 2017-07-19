using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace FindDevGirls.Models
{
    [DataTable("DevGirls")]
    public class DevGirl
    {
        [Version]
        public string AzureVersion { get; set; }
        public string Id { get; set; }
        public string DataHora { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Especialidades { get; set; }
        public string Github { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}

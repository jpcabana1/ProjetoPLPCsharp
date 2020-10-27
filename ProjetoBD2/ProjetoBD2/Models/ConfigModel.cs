using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD2.Models
{
    class ConfigModel
    {
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Data Source = '" + DataSource + "';");
            stringBuilder.Append("Initial Catalog = '" + InitialCatalog + "';");
            stringBuilder.Append("User = '" + User + "';");
            stringBuilder.Append("Password = '" + Password + "';");
            return stringBuilder.ToString();
        }
    }
}

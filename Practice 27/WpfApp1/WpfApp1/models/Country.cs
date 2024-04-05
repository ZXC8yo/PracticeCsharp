using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    public class Country
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public double Population { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Сладость {Name}")
                .AppendLine($"\tТип Обертки {Area}")
                .AppendLine($"\tСтоимость {Population}")
                .ToString();
        }
    }
}
